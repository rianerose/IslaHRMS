Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Threading.Tasks
Imports Data.Models
Imports MySqlConnector

Namespace Data

    Public Class AttendanceRepository

        Private ReadOnly _context As DatabaseContext

        Public Sub New(context As DatabaseContext)
            _context = context
        End Sub

        Public Async Function GetByDateRangeAsync(startDate As Date, endDate As Date, Optional employeeId As Integer? = Nothing) As Task(Of IList(Of AttendanceRecord))
            Dim sql = "SELECT id, employee_id, attendance_date, check_in_time, check_out_time, notes, created_at, updated_at FROM attendance WHERE attendance_date BETWEEN @Start AND @End" &
                      If(employeeId.HasValue, " AND employee_id = @EmployeeId", String.Empty) &
                      " ORDER BY attendance_date DESC, check_in_time ASC;"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@Start", MySqlDbType.Date) With {.Value = startDate.Date},
                New MySqlParameter("@End", MySqlDbType.Date) With {.Value = endDate.Date}
            }
            If employeeId.HasValue Then
                parameters.Add(New MySqlParameter("@EmployeeId", MySqlDbType.Int32) With {.Value = employeeId.Value})
            End If

            Dim table = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim items As New List(Of AttendanceRecord)(table.Rows.Count)
            For Each row As DataRow In table.Rows
                items.Add(MapAttendance(row))
            Next
            Return items
        End Function

        Public Async Function GetDailySummaryAsync(targetDate As Date) As Task(Of IDictionary(Of Integer, Decimal))
            Dim sql = "SELECT employee_id, SUM(TIMESTAMPDIFF(MINUTE, check_in_time, check_out_time)) / 60.0 AS hours_worked FROM attendance WHERE attendance_date = @TargetDate AND check_in_time IS NOT NULL AND check_out_time IS NOT NULL GROUP BY employee_id;"
            Dim parameters = {
                New MySqlParameter("@TargetDate", MySqlDbType.Date) With {.Value = targetDate.Date}
            }

            Dim table = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim summary As New Dictionary(Of Integer, Decimal)(table.Rows.Count)
            For Each row As DataRow In table.Rows
                Dim id = Convert.ToInt32(row("employee_id"), CultureInfo.InvariantCulture)
                Dim hours = Convert.ToDecimal(row("hours_worked"), CultureInfo.InvariantCulture)
                summary(id) = Math.Round(hours, 2, MidpointRounding.AwayFromZero)
            Next
            Return summary
        End Function

        Public Async Function CreateAsync(record As AttendanceRecord) As Task(Of Integer)
            Const sql = "INSERT INTO attendance (employee_id, attendance_date, check_in_time, check_out_time, notes, created_at, updated_at) VALUES (@EmployeeId, @Date, @CheckIn, @CheckOut, @Notes, @Created, @Updated); SELECT LAST_INSERT_ID();"
            Dim parameters = GetParameters(record, includeId:=False)
            Dim newId = Await _context.ExecuteScalarAsync(Of Long)(sql, parameters).ConfigureAwait(False)
            Return Convert.ToInt32(newId, CultureInfo.InvariantCulture)
        End Function

        Public Async Function UpdateAsync(record As AttendanceRecord) As Task(Of Boolean)
            Const sql = "UPDATE attendance SET attendance_date = @Date, check_in_time = @CheckIn, check_out_time = @CheckOut, notes = @Notes, updated_at = @Updated WHERE id = @Id;"
            Dim parameters = GetParameters(record, includeId:=True)
            Dim rows = Await _context.ExecuteNonQueryAsync(sql, parameters).ConfigureAwait(False)
            Return rows > 0
        End Function

        Public Async Function DeleteAsync(id As Integer) As Task(Of Boolean)
            Const sql = "DELETE FROM attendance WHERE id = @Id;"
            Dim parameters = {
                New MySqlParameter("@Id", MySqlDbType.Int32) With {.Value = id}
            }

            Dim rows = Await _context.ExecuteNonQueryAsync(sql, parameters).ConfigureAwait(False)
            Return rows > 0
        End Function

        Private Shared Function MapAttendance(row As DataRow) As AttendanceRecord
            Dim record As New AttendanceRecord With {
                .Id = Convert.ToInt32(row("id"), CultureInfo.InvariantCulture),
                .EmployeeId = Convert.ToInt32(row("employee_id"), CultureInfo.InvariantCulture),
                .AttendanceDate = row.Field(Of Date)("attendance_date"),
                .Notes = row.Field(Of String)("notes"),
                .CreatedAt = row.Field(Of Date)("created_at"),
                .UpdatedAt = row.Field(Of Date)("updated_at")
            }

            If Not row.IsNull("check_in_time") Then
                record.CheckInTime = row.Field(Of Date)("check_in_time")
            End If
            If Not row.IsNull("check_out_time") Then
                record.CheckOutTime = row.Field(Of Date)("check_out_time")
            End If

            Return record
        End Function

        Private Shared Function GetParameters(record As AttendanceRecord, includeId As Boolean) As IEnumerable(Of MySqlParameter)
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@EmployeeId", MySqlDbType.Int32) With {.Value = record.EmployeeId},
                New MySqlParameter("@Date", MySqlDbType.Date) With {.Value = record.AttendanceDate.Date},
                New MySqlParameter("@CheckIn", MySqlDbType.DateTime) With {.Value = If(record.CheckInTime.HasValue, CType(record.CheckInTime.Value, Object), DBNull.Value)},
                New MySqlParameter("@CheckOut", MySqlDbType.DateTime) With {.Value = If(record.CheckOutTime.HasValue, CType(record.CheckOutTime.Value, Object), DBNull.Value)},
                New MySqlParameter("@Notes", MySqlDbType.VarChar, 500) With {.Value = record.Notes},
                New MySqlParameter("@Created", MySqlDbType.DateTime) With {.Value = record.CreatedAt},
                New MySqlParameter("@Updated", MySqlDbType.DateTime) With {.Value = Date.UtcNow}
            }

            If includeId Then
                parameters.Add(New MySqlParameter("@Id", MySqlDbType.Int32) With {.Value = record.Id})
            End If

            Return parameters
        End Function

    End Class

End Namespace
