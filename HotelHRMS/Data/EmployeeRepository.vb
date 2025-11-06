Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports System.Threading.Tasks
Imports Data.Models
Imports MySqlConnector

Namespace Data

    Public Class EmployeeRepository

        Private ReadOnly _context As DatabaseContext

        Public Sub New(context As DatabaseContext)
            _context = context
        End Sub

        Public Async Function GetAllAsync(includeInactive As Boolean, Optional cancellationToken As Threading.CancellationToken = Nothing) As Task(Of IList(Of Employee))
            Dim sql = "SELECT id, employee_code, first_name, last_name, email, phone_number, position, department, hire_date, basic_salary, is_active, last_modified FROM employees WHERE (@includeInactive = 1) OR (is_active = 1) ORDER BY last_name, first_name;"
            Dim parameters = {
                New MySqlParameter("@includeInactive", MySqlDbType.Bool) With {.Value = If(includeInactive, 1, 0)}
            }

            Dim resultTable = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim employees As New List(Of Employee)(resultTable.Rows.Count)
            For Each row As DataRow In resultTable.Rows
                employees.Add(MapEmployee(row))
            Next
            Return employees
        End Function

        Public Async Function SearchAsync(term As String, Optional includeInactive As Boolean = False) As Task(Of IList(Of Employee))
            Dim sql = "SELECT id, employee_code, first_name, last_name, email, phone_number, position, department, hire_date, basic_salary, is_active, last_modified FROM employees WHERE ((@includeInactive = 1) OR (is_active = 1)) AND (employee_code LIKE @term OR first_name LIKE @term OR last_name LIKE @term OR email LIKE @term OR department LIKE @term) ORDER BY last_name, first_name;"
            Dim parameters = {
                New MySqlParameter("@term", MySqlDbType.VarChar, 255) With {.Value = $"%{term.Trim()}%"},
                New MySqlParameter("@includeInactive", MySqlDbType.Bool) With {.Value = If(includeInactive, 1, 0)}
            }

            Dim resultTable = Await _context.GetDataTableAsync(sql, parameters).ConfigureAwait(False)
            Dim employees As New List(Of Employee)(resultTable.Rows.Count)
            For Each row As DataRow In resultTable.Rows
                employees.Add(MapEmployee(row))
            Next
            Return employees
        End Function

        Public Async Function CreateAsync(employee As Employee) As Task(Of Integer)
            Dim sql = "INSERT INTO employees (employee_code, first_name, last_name, email, phone_number, position, department, hire_date, basic_salary, is_active, last_modified) VALUES (@EmployeeCode, @FirstName, @LastName, @Email, @Phone, @Position, @Department, @HireDate, @BasicSalary, @IsActive, @LastModified); SELECT LAST_INSERT_ID();"
            Dim parameters = GetEmployeeParameters(employee, includeId:=False)
            Dim newId = Await _context.ExecuteScalarAsync(Of Long)(sql, parameters).ConfigureAwait(False)
            Return Convert.ToInt32(newId, CultureInfo.InvariantCulture)
        End Function

        Public Async Function UpdateAsync(employee As Employee) As Task(Of Boolean)
            Dim sql = "UPDATE employees SET employee_code = @EmployeeCode, first_name = @FirstName, last_name = @LastName, email = @Email, phone_number = @Phone, position = @Position, department = @Department, hire_date = @HireDate, basic_salary = @BasicSalary, is_active = @IsActive, last_modified = @LastModified WHERE id = @Id;"
            Dim parameters = GetEmployeeParameters(employee, includeId:=True)
            Dim rowsAffected = Await _context.ExecuteNonQueryAsync(sql, parameters).ConfigureAwait(False)
            Return rowsAffected > 0
        End Function

        Public Async Function DeleteAsync(employeeId As Integer) As Task(Of Boolean)
            Dim sql = "DELETE FROM employees WHERE id = @Id;"
            Dim parameters = {
                New MySqlParameter("@Id", MySqlDbType.Int32) With {.Value = employeeId}
            }

            Dim rowsAffected = Await _context.ExecuteNonQueryAsync(sql, parameters).ConfigureAwait(False)
            Return rowsAffected > 0
        End Function

        Public Async Function GetActiveCountAsync() As Task(Of Integer)
            Dim sql = "SELECT COUNT(*) FROM employees WHERE is_active = 1;"
            Dim count = Await _context.ExecuteScalarAsync(Of Long)(sql, Array.Empty(Of MySqlParameter)()).ConfigureAwait(False)
            Return Convert.ToInt32(count, CultureInfo.InvariantCulture)
        End Function

        Private Shared Function MapEmployee(row As DataRow) As Employee
            Return New Employee With {
                .Id = Convert.ToInt32(row("id"), CultureInfo.InvariantCulture),
                .EmployeeCode = row.Field(Of String)("employee_code"),
                .FirstName = row.Field(Of String)("first_name"),
                .LastName = row.Field(Of String)("last_name"),
                .Email = row.Field(Of String)("email"),
                .PhoneNumber = row.Field(Of String)("phone_number"),
                .Position = row.Field(Of String)("position"),
                .Department = row.Field(Of String)("department"),
                .HireDate = row.Field(Of Date)("hire_date"),
                .BasicSalary = row.Field(Of Decimal)("basic_salary"),
                .IsActive = row.Field(Of Boolean)("is_active"),
                .LastModified = row.Field(Of Date)("last_modified")
            }
        End Function

        Private Shared Function GetEmployeeParameters(employee As Employee, includeId As Boolean) As IEnumerable(Of MySqlParameter)
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@EmployeeCode", MySqlDbType.VarChar, 50) With {.Value = employee.EmployeeCode},
                New MySqlParameter("@FirstName", MySqlDbType.VarChar, 100) With {.Value = employee.FirstName},
                New MySqlParameter("@LastName", MySqlDbType.VarChar, 100) With {.Value = employee.LastName},
                New MySqlParameter("@Email", MySqlDbType.VarChar, 150) With {.Value = employee.Email},
                New MySqlParameter("@Phone", MySqlDbType.VarChar, 50) With {.Value = employee.PhoneNumber},
                New MySqlParameter("@Position", MySqlDbType.VarChar, 100) With {.Value = employee.Position},
                New MySqlParameter("@Department", MySqlDbType.VarChar, 100) With {.Value = employee.Department},
                New MySqlParameter("@HireDate", MySqlDbType.Date) With {.Value = employee.HireDate.Date},
                New MySqlParameter("@BasicSalary", MySqlDbType.Decimal) With {.Value = employee.BasicSalary},
                New MySqlParameter("@IsActive", MySqlDbType.Bool) With {.Value = If(employee.IsActive, 1, 0)},
                New MySqlParameter("@LastModified", MySqlDbType.DateTime) With {.Value = Date.UtcNow}
            }

            If includeId Then
                parameters.Add(New MySqlParameter("@Id", MySqlDbType.Int32) With {.Value = employee.Id})
            End If

            Return parameters
        End Function

    End Class

End Namespace
