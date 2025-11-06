Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Threading.Tasks
Imports Data.Models
Imports HotelHRMS.My
Imports MySqlConnector

Namespace Data

    Public Class PayrollRepository

        Private ReadOnly _context As DatabaseContext

        Public Sub New(context As DatabaseContext)
            _context = context
        End Sub

        Public Async Function GeneratePayrollAsync(period As PayPeriod, Optional taxRatePercent As Decimal = 10D, Optional additionalDeductions As Decimal = 0D) As Task(Of IList(Of PayrollEntry))
            Dim defaultHoursPerDay = Convert.ToDecimal(MySettings.Default.DefaultWorkDayHours, CultureInfo.InvariantCulture)
            Dim defaultWorkingDays As Decimal = 22D
            Dim overtimeMultiplier = MySettings.Default.DefaultOvertimeRate

            Dim sql = "SELECT e.id, CONCAT(e.first_name, ' ', e.last_name) AS employee_name, e.basic_salary, " &
                      "COALESCE(SUM(LEAST(TIMESTAMPDIFF(MINUTE, a.check_in_time, a.check_out_time) / 60.0, @BaseHoursPerDay)), 0) AS base_hours, " &
                      "COALESCE(SUM(GREATEST((TIMESTAMPDIFF(MINUTE, a.check_in_time, a.check_out_time) / 60.0) - @BaseHoursPerDay, 0)), 0) AS overtime_hours " &
                      "FROM employees e LEFT JOIN attendance a ON a.employee_id = e.id AND a.attendance_date BETWEEN @Start AND @End AND a.check_in_time IS NOT NULL AND a.check_out_time IS NOT NULL " &
                      "WHERE e.is_active = 1 GROUP BY e.id, employee_name, e.basic_salary ORDER BY employee_name;"

            Dim parameters = {
                New MySqlParameter("@Start", MySqlDbType.Date) With {.Value = period.StartDate.Date},
                New MySqlParameter("@End", MySqlDbType.Date) With {.Value = period.EndDate.Date},
                New MySqlParameter("@BaseHoursPerDay", MySqlDbType.Decimal) With {.Value = defaultHoursPerDay}
            }

            Dim table = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim payrollEntries As New List(Of PayrollEntry)(table.Rows.Count)

            For Each row As DataRow In table.Rows
                Dim employeeId = Convert.ToInt32(row("id"), CultureInfo.InvariantCulture)
                Dim basicSalary = Convert.ToDecimal(row("basic_salary"), CultureInfo.InvariantCulture)
                Dim baseHours = Convert.ToDecimal(row("base_hours"), CultureInfo.InvariantCulture)
                Dim overtimeHours = Convert.ToDecimal(row("overtime_hours"), CultureInfo.InvariantCulture)

                Dim hourlyRate = Math.Round(basicSalary / (defaultHoursPerDay * defaultWorkingDays), 2, MidpointRounding.AwayFromZero)
                Dim basePay = Math.Round(baseHours * hourlyRate, 2, MidpointRounding.AwayFromZero)
                Dim overtimePay = Math.Round(overtimeHours * hourlyRate * overtimeMultiplier, 2, MidpointRounding.AwayFromZero)
                Dim grossPay = basePay + overtimePay
                Dim taxes = Math.Round(grossPay * (taxRatePercent / 100D), 2, MidpointRounding.AwayFromZero)
                Dim totalDeductions = Math.Round(additionalDeductions, 2, MidpointRounding.AwayFromZero)
                Dim netPay = Math.Round(grossPay - taxes - totalDeductions, 2, MidpointRounding.AwayFromZero)

                payrollEntries.Add(New PayrollEntry With {
                    .EmployeeId = employeeId,
                    .EmployeeName = row.Field(Of String)("employee_name"),
                    .PayPeriodStart = period.StartDate,
                    .PayPeriodEnd = period.EndDate,
                    .BaseHoursWorked = Math.Round(baseHours, 2, MidpointRounding.AwayFromZero),
                    .OvertimeHours = Math.Round(overtimeHours, 2, MidpointRounding.AwayFromZero),
                    .BasePay = basePay,
                    .OvertimePay = overtimePay,
                    .GrossPay = grossPay,
                    .Taxes = taxes,
                    .TotalDeductions = totalDeductions,
                    .NetPay = netPay,
                    .Notes = $"Generated on {Date.UtcNow:yyyy-MM-dd HH:mm}"
                })
            Next

            Return payrollEntries
        End Function

        Public Async Function SavePayrollBatchAsync(entries As IEnumerable(Of PayrollEntry)) As Task
            Const sql = "INSERT INTO payroll (employee_id, pay_period_start, pay_period_end, base_hours_worked, overtime_hours, base_pay, overtime_pay, gross_pay, total_deductions, taxes, net_pay, generated_at, notes) VALUES (@EmployeeId, @Start, @End, @BaseHours, @OvertimeHours, @BasePay, @OvertimePay, @GrossPay, @TotalDeductions, @Taxes, @NetPay, @GeneratedAt, @Notes);"

            Using connection = _context.CreateConnection()
                Await connection.OpenAsync().ConfigureAwait(False)
                Using transaction = Await connection.BeginTransactionAsync().ConfigureAwait(False)
                    For Each entry In entries
                        Using command As New MySqlCommand(sql, connection, transaction)
                            command.Parameters.AddRange(New() {
                                New MySqlParameter("@EmployeeId", MySqlDbType.Int32) With {.Value = entry.EmployeeId},
                                New MySqlParameter("@Start", MySqlDbType.Date) With {.Value = entry.PayPeriodStart.Date},
                                New MySqlParameter("@End", MySqlDbType.Date) With {.Value = entry.PayPeriodEnd.Date},
                                New MySqlParameter("@BaseHours", MySqlDbType.Decimal) With {.Value = entry.BaseHoursWorked},
                                New MySqlParameter("@OvertimeHours", MySqlDbType.Decimal) With {.Value = entry.OvertimeHours},
                                New MySqlParameter("@BasePay", MySqlDbType.Decimal) With {.Value = entry.BasePay},
                                New MySqlParameter("@OvertimePay", MySqlDbType.Decimal) With {.Value = entry.OvertimePay},
                                New MySqlParameter("@GrossPay", MySqlDbType.Decimal) With {.Value = entry.GrossPay},
                                New MySqlParameter("@TotalDeductions", MySqlDbType.Decimal) With {.Value = entry.TotalDeductions},
                                New MySqlParameter("@Taxes", MySqlDbType.Decimal) With {.Value = entry.Taxes},
                                New MySqlParameter("@NetPay", MySqlDbType.Decimal) With {.Value = entry.NetPay},
                                New MySqlParameter("@GeneratedAt", MySqlDbType.DateTime) With {.Value = Date.UtcNow},
                                New MySqlParameter("@Notes", MySqlDbType.VarChar, 500) With {.Value = entry.Notes}
                            })
                            Await command.ExecuteNonQueryAsync().ConfigureAwait(False)
                        End Using
                    Next
                    Await transaction.CommitAsync().ConfigureAwait(False)
                End Using
            End Using
        End Function

        Public Async Function GetPayrollHistoryAsync(period As PayPeriod) As Task(Of IList(Of PayrollEntry))
            Const sql = "SELECT id, employee_id, employee_name, pay_period_start, pay_period_end, base_hours_worked, overtime_hours, base_pay, overtime_pay, gross_pay, total_deductions, taxes, net_pay, generated_at, notes FROM payroll WHERE pay_period_start >= @Start AND pay_period_end <= @End ORDER BY generated_at DESC;"
            Dim parameters = {
                New MySqlParameter("@Start", MySqlDbType.Date) With {.Value = period.StartDate.Date},
                New MySqlParameter("@End", MySqlDbType.Date) With {.Value = period.EndDate.Date}
            }

            Dim table = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim entries As New List(Of PayrollEntry)(table.Rows.Count)

            For Each row As DataRow In table.Rows
                entries.Add(New PayrollEntry With {
                    .Id = Convert.ToInt32(row("id"), CultureInfo.InvariantCulture),
                    .EmployeeId = Convert.ToInt32(row("employee_id"), CultureInfo.InvariantCulture),
                    .EmployeeName = row.Field(Of String)("employee_name"),
                    .PayPeriodStart = row.Field(Of Date)("pay_period_start"),
                    .PayPeriodEnd = row.Field(Of Date)("pay_period_end"),
                    .BaseHoursWorked = Convert.ToDecimal(row("base_hours_worked"), CultureInfo.InvariantCulture),
                    .OvertimeHours = Convert.ToDecimal(row("overtime_hours"), CultureInfo.InvariantCulture),
                    .BasePay = Convert.ToDecimal(row("base_pay"), CultureInfo.InvariantCulture),
                    .OvertimePay = Convert.ToDecimal(row("overtime_pay"), CultureInfo.InvariantCulture),
                    .GrossPay = Convert.ToDecimal(row("gross_pay"), CultureInfo.InvariantCulture),
                    .TotalDeductions = Convert.ToDecimal(row("total_deductions"), CultureInfo.InvariantCulture),
                    .Taxes = Convert.ToDecimal(row("taxes"), CultureInfo.InvariantCulture),
                    .NetPay = Convert.ToDecimal(row("net_pay"), CultureInfo.InvariantCulture),
                    .GeneratedAt = row.Field(Of Date)("generated_at"),
                    .Notes = row.Field(Of String)("notes")
                })
            Next

            Return entries
        End Function

    End Class

End Namespace
