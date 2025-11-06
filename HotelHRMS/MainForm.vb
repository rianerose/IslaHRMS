Option Strict On
Option Explicit On

Imports Data
Imports Utilities

Public Class MainForm

    Private ReadOnly _context As New DatabaseContext()
    Private ReadOnly _employeeRepository As New EmployeeRepository(_context)
    Private ReadOnly _attendanceRepository As New AttendanceRepository(_context)
    Private ReadOnly _payrollRepository As New PayrollRepository(_context)
    Private ReadOnly _dialog As DialogService = DialogService.Instance

    Public Sub New()
        InitializeComponent()
        Text = My.Resources.Resources.AppTitle
    End Sub

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await RefreshDashboardAsync()
    End Sub

    Private Async Function RefreshDashboardAsync() As Task
        Await Me.RunOperationAsync(Async Function()
                                        Try
                                            Await _context.TestConnectionAsync().ConfigureAwait(False)
                                            UpdateConnectionStatus(True)
                                        Catch ex As Exception
                                            UpdateConnectionStatus(False, ex.Message)
                                        End Try

                                        Try
                                            Dim activeCount = Await _employeeRepository.GetActiveCountAsync().ConfigureAwait(False)
                                            lblEmployeeCount.InvokeIfRequired(Sub() lblEmployeeCount.Text = activeCount.ToString())
                                        Catch ex As Exception
                                            _dialog.LogError("Failed to load employee count.", ex)
                                            lblEmployeeCount.InvokeIfRequired(Sub() lblEmployeeCount.Text = "--")
                                        End Try
                                    End Function)
    End Function

    Private Sub UpdateConnectionStatus(isConnected As Boolean, Optional message As String = "")
        statusLabelConnection.InvokeIfRequired(
            Sub()
                If isConnected Then
                    statusLabelConnection.Text = "Connected to MySQL"
                    statusLabelConnection.ForeColor = System.Drawing.Color.DarkGreen
                Else
                    statusLabelConnection.Text = $"Connection failed: {message}"
                    statusLabelConnection.ForeColor = System.Drawing.Color.DarkRed
                End If
            End Sub)
    End Sub

    Private Async Sub btnManageEmployees_Click(sender As Object, e As EventArgs) Handles btnManageEmployees.Click
        Using employeeForm As New Forms.EmployeeForm(_employeeRepository)
            employeeForm.ShowDialog(Me)
        End Using
        Await RefreshDashboardAsync()
    End Sub

    Private Async Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Using attendanceForm As New Forms.AttendanceForm(_attendanceRepository, _employeeRepository)
            attendanceForm.ShowDialog(Me)
        End Using
        Await RefreshDashboardAsync()
    End Sub

    Private Async Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        Using payrollForm As New Forms.PayrollForm(_payrollRepository)
            payrollForm.ShowDialog(Me)
        End Using
        Await RefreshDashboardAsync()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Using reportForm As New Forms.ReportViewerForm(_employeeRepository, _attendanceRepository, _payrollRepository)
            reportForm.ShowDialog(Me)
        End Using
    End Sub

    Private Async Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Await Me.RunOperationAsync(Async Function()
                                       Try
                                           Await _context.TestConnectionAsync().ConfigureAwait(False)
                                           UpdateConnectionStatus(True)
                                           _dialog.ShowInfo("Connection successful.")
                                       Catch ex As Exception
                                           UpdateConnectionStatus(False, ex.Message)
                                           _dialog.ShowError("Unable to connect to the database.", ex)
                                       End Try
                                   End Function)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
