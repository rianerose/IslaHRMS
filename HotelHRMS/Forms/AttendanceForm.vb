Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Linq
Imports Data
Imports Data.Models
Imports Utilities

Namespace Forms

    Public Class AttendanceForm
        Inherits Form

        Private ReadOnly _attendanceRepository As AttendanceRepository
        Private ReadOnly _employeeRepository As EmployeeRepository
        Private ReadOnly _dialog As DialogService = DialogService.Instance
        Private ReadOnly _validation As ValidationService = ValidationService.Instance
        Private ReadOnly _attendanceBinding As New BindingSource()
        Private ReadOnly _employeeBinding As New BindingSource()
        Private ReadOnly _employeeLookup As New Dictionary(Of Integer, String)()
        Private _currentRecord As AttendanceRecord

        Public Sub New(attendanceRepository As AttendanceRepository, employeeRepository As EmployeeRepository)
            InitializeComponent()
            _attendanceRepository = attendanceRepository
            _employeeRepository = employeeRepository

            gridAttendance.ConfigureDataGrid()
            gridAttendance.DataSource = _attendanceBinding
            cmbEditorEmployee.DataSource = _employeeBinding
            cmbEditorEmployee.DisplayMember = "FullName"
            cmbEditorEmployee.ValueMember = "Id"
            cmbFilterEmployee.DataSource = _employeeBinding
            cmbFilterEmployee.DisplayMember = "FullName"
            cmbFilterEmployee.ValueMember = "Id"
            cmbFilterEmployee.SelectedIndex = -1

            dtpFilterStart.Value = Date.Today.AddDays(-7)
            dtpFilterEnd.Value = Date.Today
            dtpCheckIn.CustomFormat = "HH:mm"
            dtpCheckOut.CustomFormat = "HH:mm"
        End Sub

        Private Async Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await LoadEmployeesAsync()
            Await LoadAttendanceAsync()
        End Sub

        Private Async Function LoadEmployeesAsync() As Task
            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim employees = Await _employeeRepository.GetAllAsync(includeInactive:=False).ConfigureAwait(False)
                                               _employeeBinding.DataSource = New BindingList(Of Employee)(employees.ToList())
                                               _employeeLookup.Clear()
                                               For Each employee In employees
                                                   _employeeLookup(employee.Id) = employee.FullName
                                               Next
                                               cmbFilterEmployee.InvokeIfRequired(Sub()
                                                                                    cmbFilterEmployee.SelectedIndex = -1
                                                                                End Sub)
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to load employees for attendance.", ex)
                                           End Try
                                       End Function)
        End Function

        Private Async Function LoadAttendanceAsync() As Task
            Await Me.RunOperationAsync(Async Function()
                                            Try
                                                Dim startDate = dtpFilterStart.Value.Date
                                                Dim endDate = dtpFilterEnd.Value.Date
                                                Dim employeeId As Integer? = Nothing
                                                If chkFilterByEmployee.Checked AndAlso cmbFilterEmployee.SelectedValue IsNot Nothing AndAlso TypeOf cmbFilterEmployee.SelectedValue Is Integer Then
                                                    employeeId = CInt(cmbFilterEmployee.SelectedValue)
                                                End If

                                               Dim records = Await _attendanceRepository.GetByDateRangeAsync(startDate, endDate, employeeId).ConfigureAwait(False)
                                               _attendanceBinding.DataSource = New BindingList(Of AttendanceRecord)(records.OrderByDescending(Function(r) r.AttendanceDate).ToList())
                                               lblSummary.Text = $"{records.Count} records"
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to load attendance records.", ex)
                                           End Try
                                       End Function)
        End Function

        Private Sub gridAttendance_SelectionChanged(sender As Object, e As EventArgs) Handles gridAttendance.SelectionChanged
            If gridAttendance.SelectedRows.Count = 0 Then
                Return
            End If

            Dim record = TryCast(gridAttendance.SelectedRows(0).DataBoundItem, AttendanceRecord)
            If record Is Nothing Then
                Return
            End If

            _currentRecord = record
            PopulateForm(record)
        End Sub

        Private Sub gridAttendance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridAttendance.CellFormatting
            If gridAttendance.Columns(e.ColumnIndex).Name = "colEmployee" AndAlso e.Value IsNot Nothing Then
                Dim employeeId As Integer
                If Integer.TryParse(e.Value.ToString(), employeeId) AndAlso _employeeLookup.ContainsKey(employeeId) Then
                    e.Value = _employeeLookup(employeeId)
                    e.FormattingApplied = True
                End If
            End If
        End Sub

        Private Sub PopulateForm(record As AttendanceRecord)
            cmbEditorEmployee.SelectedValue = record.EmployeeId
            dtpAttendanceDate.Value = record.AttendanceDate
            dtpCheckIn.Value = If(record.CheckInTime.HasValue, record.CheckInTime.Value, Date.Today.AddHours(9))
            dtpCheckOut.Value = If(record.CheckOutTime.HasValue, record.CheckOutTime.Value, Date.Today.AddHours(17))
            txtNotes.Text = record.Notes
            lblHoursWorked.Text = $"{record.HoursWorked:N2} hrs"
        End Sub

        Private Sub ResetForm()
            _currentRecord = Nothing
            If cmbEditorEmployee.Items.Count > 0 Then
                cmbEditorEmployee.SelectedIndex = 0
            End If
            dtpAttendanceDate.Value = Date.Today
            dtpCheckIn.Value = Date.Today.AddHours(9)
            dtpCheckOut.Value = Date.Today.AddHours(17)
            txtNotes.Clear()
            lblHoursWorked.Text = "0 hrs"
            errorProvider.Clear()
        End Sub

        Private Sub chkEnableTimes_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableTimes.CheckedChanged
            dtpCheckIn.Enabled = chkEnableTimes.Checked
            dtpCheckOut.Enabled = chkEnableTimes.Checked
        End Sub

        Private Sub UpdateHoursPreview() Handles dtpCheckIn.ValueChanged, dtpCheckOut.ValueChanged
            If Not chkEnableTimes.Checked Then
                lblHoursWorked.Text = "0 hrs"
                Return
            End If

            Dim diff = dtpCheckOut.Value - dtpCheckIn.Value
            If diff.TotalMinutes <= 0 Then
                lblHoursWorked.Text = "0 hrs"
            Else
                lblHoursWorked.Text = $"{diff.TotalHours:N2} hrs"
            End If
        End Sub

        Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If cmbEditorEmployee.SelectedValue Is Nothing Then
                _dialog.ShowWarning("Select an employee before saving attendance.")
                Return
            End If

            Dim record = BuildRecordFromForm()
            Dim validation = _validation.ValidateAttendance(record)
            validation.ApplyTo(errorProvider, GetControlMap())
            If Not validation.IsValid Then
                _dialog.ShowWarning("Please resolve validation errors before saving.")
                Return
            End If

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               If record.Id = 0 Then
                                                   record.Id = Await _attendanceRepository.CreateAsync(record).ConfigureAwait(False)
                                                   _dialog.ShowInfo("Attendance recorded.")
                                               Else
                                                   Dim updated = Await _attendanceRepository.UpdateAsync(record).ConfigureAwait(False)
                                                   If Not updated Then
                                                       Throw New InvalidOperationException("Attendance record may have been modified by another user.")
                                                   End If
                                                   _dialog.ShowInfo("Attendance updated.")
                                               End If
                                               Await LoadAttendanceAsync().ConfigureAwait(False)
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to save attendance.", ex)
                                           End Try
                                       End Function)

            ResetForm()
        End Sub

        Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If _currentRecord Is Nothing Then
                _dialog.ShowWarning("Select a record to delete.")
                Return
            End If

            If Not _dialog.AskConfirmation("Delete the selected attendance record?") Then
                Return
            End If

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim deleted = Await _attendanceRepository.DeleteAsync(_currentRecord.Id).ConfigureAwait(False)
                                               If deleted Then
                                                   _dialog.ShowInfo("Attendance record deleted.")
                                                   Await LoadAttendanceAsync().ConfigureAwait(False)
                                               End If
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to delete attendance record.", ex)
                                           End Try
                                       End Function)

            ResetForm()
        End Sub

        Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            Await LoadAttendanceAsync()
        End Sub

        Private Async Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            If _attendanceBinding.Count = 0 Then
                _dialog.ShowWarning("There are no records to export.")
                Return
            End If

            Using dialog As New SaveFileDialog()
                dialog.Filter = "CSV Files|*.csv"
                dialog.FileName = $"Attendance_{dtpFilterStart.Value:yyyyMMdd}_{dtpFilterEnd.Value:yyyyMMdd}.csv"
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    Dim lookup = _employeeBinding.List.OfType(Of Employee).ToDictionary(Function(emp) emp.Id)
                    Dim entries = _attendanceBinding.Cast(Of AttendanceRecord)().Select(Function(r)
                                                                                             Dim name As String = If(lookup.ContainsKey(r.EmployeeId), lookup(r.EmployeeId).FullName, $"Employee #{r.EmployeeId}")
                                                                                             Return New PayrollEntry With {
                                                                                                 .EmployeeId = r.EmployeeId,
                                                                                                 .EmployeeName = name,
                                                                                                 .PayPeriodStart = r.AttendanceDate,
                                                                                                 .PayPeriodEnd = r.AttendanceDate,
                                                                                                 .BaseHoursWorked = r.HoursWorked,
                                                                                                 .Notes = r.Notes
                                                                                             }
                                                                                         End Function).ToList()
                    Await CsvExportService.ExportPayrollAsync(entries, dialog.FileName)
                    _dialog.ShowInfo("Attendance exported to CSV.")
                End If
            End Using
        End Sub

        Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
            ResetForm()
        End Sub

        Private Async Sub filterChanged(sender As Object, e As EventArgs) Handles dtpFilterStart.ValueChanged, dtpFilterEnd.ValueChanged, chkFilterByEmployee.CheckedChanged, cmbFilterEmployee.SelectedIndexChanged
            If Not IsHandleCreated Then
                Return
            End If

            If chkFilterByEmployee.Checked AndAlso (cmbFilterEmployee.SelectedValue Is Nothing OrElse Not TypeOf cmbFilterEmployee.SelectedValue Is Integer) Then
                Return
            End If

            Await LoadAttendanceAsync()
        End Sub

        Private Function GetControlMap() As IDictionary(Of String, Control)
            Return New Dictionary(Of String, Control)(StringComparer.OrdinalIgnoreCase) From {
                {"AttendanceDate", dtpAttendanceDate},
                {"CheckOutTime", dtpCheckOut}
            }
        End Function

        Private Function GetSelectedEmployeeId() As Integer
            If cmbEditorEmployee.SelectedValue Is Nothing Then
                Throw New InvalidOperationException("Select an employee.")
            End If

            If TypeOf cmbEditorEmployee.SelectedValue Is Integer Then
                Return CInt(cmbEditorEmployee.SelectedValue)
            End If

            Dim employee = TryCast(cmbEditorEmployee.SelectedItem, Employee)
            If employee IsNot Nothing Then
                Return employee.Id
            End If

            Throw New InvalidOperationException("Unable to resolve employee selection.")
        End Function

        Private Function BuildRecordFromForm() As AttendanceRecord
            Dim record = If(_currentRecord, New AttendanceRecord())
            record.EmployeeId = GetSelectedEmployeeId()
            record.AttendanceDate = dtpAttendanceDate.Value.Date
            record.CheckInTime = If(chkEnableTimes.Checked, CType(dtpCheckIn.Value, Date?), Nothing)
            record.CheckOutTime = If(chkEnableTimes.Checked, CType(dtpCheckOut.Value, Date?), Nothing)
            record.Notes = txtNotes.Text.Trim()
            record.CreatedAt = If(record.CreatedAt = Date.MinValue, Date.UtcNow, record.CreatedAt)
            record.UpdatedAt = Date.UtcNow
            Return record
        End Function

    End Class

End Namespace
