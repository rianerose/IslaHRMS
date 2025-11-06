Option Strict On
Option Explicit On

Imports System.Data
Imports System.Globalization
Imports Data
Imports Utilities
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace Forms

    Public Class ReportViewerForm
        Inherits Form

        Private ReadOnly _employeeRepository As EmployeeRepository
        Private ReadOnly _attendanceRepository As AttendanceRepository
        Private ReadOnly _payrollRepository As PayrollRepository
        Private ReadOnly _dialog As DialogService = DialogService.Instance
        Private _currentReport As ReportDocument

        Public Sub New(employeeRepository As EmployeeRepository, attendanceRepository As AttendanceRepository, payrollRepository As PayrollRepository)
            InitializeComponent()
            _employeeRepository = employeeRepository
            _attendanceRepository = attendanceRepository
            _payrollRepository = payrollRepository

            cmbReportType.Items.AddRange(New Object() {"Employee Directory", "Attendance Summary", "Payroll Summary"})
            cmbReportType.SelectedIndex = 0
        End Sub

        Private Async Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Await LoadReportAsync()
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to load report.", ex)
                                           End Try
                                       End Function)
        End Sub

        Private Async Function LoadReportAsync() As Task
            Dim reportPath = GetReportPath()
            If Not IO.File.Exists(reportPath) Then
                Throw New IO.FileNotFoundException($"Crystal report template not found: {reportPath}")
            End If

            DisposeCurrentReport()

            Dim reportDocument As New ReportDocument()
            reportDocument.Load(reportPath)

            Select Case cmbReportType.SelectedItem.ToString()
                Case "Employee Directory"
                    Dim data = Await _employeeRepository.GetAllAsync(includeInactive:=True).ConfigureAwait(False)
                    reportDocument.SetDataSource(ToEmployeeTable(data))
                Case "Attendance Summary"
                    Dim startDate = dtpRangeStart.Value.Date
                    Dim endDate = dtpRangeEnd.Value.Date
                    If endDate < startDate Then
                        Throw New InvalidOperationException("End date cannot be before start date.")
                    End If
                    Dim data = Await _attendanceRepository.GetByDateRangeAsync(startDate, endDate).ConfigureAwait(False)
                    reportDocument.SetDataSource(ToAttendanceTable(data))
                Case "Payroll Summary"
                    Dim period As New Data.Models.PayPeriod(dtpRangeStart.Value.Date, dtpRangeEnd.Value.Date)
                    Dim entries = Await _payrollRepository.GetPayrollHistoryAsync(period).ConfigureAwait(False)
                    reportDocument.SetDataSource(ToPayrollTable(entries))
                Case Else
                    Throw New InvalidOperationException("Unknown report type selected.")
            End Select

            crystalViewer.ReportSource = reportDocument
            crystalViewer.RefreshReport()
            _currentReport = reportDocument
        End Function

        Private Function GetReportPath() As String
            Dim baseDirectory = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports")
            If Not IO.Directory.Exists(baseDirectory) Then
                baseDirectory = IO.Path.Combine(Application.StartupPath, "Reports")
            End If

            Dim fileName As String
            Select Case cmbReportType.SelectedItem.ToString()
                Case "Employee Directory"
                    fileName = "EmployeeDirectory.rpt"
                Case "Attendance Summary"
                    fileName = "AttendanceSummary.rpt"
                Case "Payroll Summary"
                    fileName = "PayrollSummary.rpt"
                Case Else
                    Throw New InvalidOperationException("Unknown report selected.")
            End Select

            Return IO.Path.Combine(baseDirectory, fileName)
        End Function

        Private Function ToEmployeeTable(employees As IEnumerable(Of Data.Models.Employee)) As DataTable
            Dim table As New DataTable("EmployeeDirectory")
            table.Columns.Add("EmployeeCode", GetType(String))
            table.Columns.Add("FullName", GetType(String))
            table.Columns.Add("Department", GetType(String))
            table.Columns.Add("Position", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("PhoneNumber", GetType(String))
            table.Columns.Add("HireDate", GetType(Date))
            table.Columns.Add("IsActive", GetType(Boolean))

            For Each employee In employees
                table.Rows.Add(employee.EmployeeCode, employee.FullName, employee.Department, employee.Position, employee.Email, employee.PhoneNumber, employee.HireDate, employee.IsActive)
            Next

            Return table
        End Function

        Private Function ToAttendanceTable(records As IEnumerable(Of Data.Models.AttendanceRecord)) As DataTable
            Dim table As New DataTable("AttendanceSummary")
            table.Columns.Add("EmployeeId", GetType(Integer))
            table.Columns.Add("AttendanceDate", GetType(Date))
            table.Columns.Add("CheckIn", GetType(String))
            table.Columns.Add("CheckOut", GetType(String))
            table.Columns.Add("HoursWorked", GetType(Decimal))
            table.Columns.Add("Notes", GetType(String))

            For Each record In records
                table.Rows.Add(record.EmployeeId,
                               record.AttendanceDate,
                               If(record.CheckInTime.HasValue, record.CheckInTime.Value.ToString("HH:mm", CultureInfo.InvariantCulture), String.Empty),
                               If(record.CheckOutTime.HasValue, record.CheckOutTime.Value.ToString("HH:mm", CultureInfo.InvariantCulture), String.Empty),
                               record.HoursWorked,
                               record.Notes)
            Next

            Return table
        End Function

        Private Function ToPayrollTable(entries As IEnumerable(Of PayrollEntry)) As DataTable
            Dim table As New DataTable("PayrollSummary")
            table.Columns.Add("Employee", GetType(String))
            table.Columns.Add("PayPeriodStart", GetType(Date))
            table.Columns.Add("PayPeriodEnd", GetType(Date))
            table.Columns.Add("BaseHours", GetType(Decimal))
            table.Columns.Add("OvertimeHours", GetType(Decimal))
            table.Columns.Add("GrossPay", GetType(Decimal))
            table.Columns.Add("Taxes", GetType(Decimal))
            table.Columns.Add("TotalDeductions", GetType(Decimal))
            table.Columns.Add("NetPay", GetType(Decimal))
            table.Columns.Add("Notes", GetType(String))

            For Each entry In entries
                table.Rows.Add(entry.EmployeeName,
                               entry.PayPeriodStart,
                               entry.PayPeriodEnd,
                               entry.BaseHoursWorked,
                               entry.OvertimeHours,
                               entry.GrossPay,
                               entry.Taxes,
                               entry.TotalDeductions,
                               entry.NetPay,
                               entry.Notes)
            Next

            Return table
        End Function

        Private Sub DisposeCurrentReport()
            If _currentReport IsNot Nothing Then
                Try
                    _currentReport.Close()
                    _currentReport.Dispose()
                Catch
                    ' ignore
                End Try
                _currentReport = Nothing
            End If
        End Sub

        Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
            If _currentReport Is Nothing Then
                _dialog.ShowWarning("Preview a report before exporting.")
                Return
            End If

            Using dialog As New SaveFileDialog()
                dialog.Filter = "PDF File|*.pdf"
                dialog.FileName = $"{cmbReportType.SelectedItem}_{Date.Now:yyyyMMddHHmm}.pdf"
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    Dim exportOptions = _currentReport.ExportOptions
                    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                    exportOptions.DestinationOptions = New DiskFileDestinationOptions With {.DiskFileName = dialog.FileName}
                    _currentReport.Export()
                    _dialog.ShowInfo("Report exported to PDF.")
                End If
            End Using
        End Sub

        Private Sub ReportViewerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            DisposeCurrentReport()
        End Sub

    End Class

End Namespace
