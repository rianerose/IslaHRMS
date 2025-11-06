Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Linq
Imports Data
Imports Data.Models
Imports Utilities

Namespace Forms

    Public Class EmployeeForm
        Inherits Form

        Private ReadOnly _repository As EmployeeRepository
        Private ReadOnly _dialog As DialogService = DialogService.Instance
        Private ReadOnly _validation As ValidationService = ValidationService.Instance
        Private ReadOnly _bindingSource As New BindingSource()
        Private _currentEmployee As Employee

        Public Sub New(repository As EmployeeRepository)
            InitializeComponent()
            _repository = repository
            gridEmployees.ConfigureDataGrid()
            gridEmployees.DataSource = _bindingSource
        End Sub

        Private Async Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ConfigureDropdowns()
            Await LoadEmployeesAsync()
        End Sub

        Private Sub ConfigureDropdowns()
            cmbDepartment.Items.AddRange(New Object() {"Front Office", "Housekeeping", "Food & Beverage", "Engineering", "HR", "Finance"})
            cmbPosition.Items.AddRange(New Object() {"Manager", "Supervisor", "Associate", "Executive", "Intern"})
        End Sub

        Private Async Function LoadEmployeesAsync(Optional searchTerm As String = "") As Task
            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim includeInactive = chkIncludeInactive.Checked
                                               Dim employees = If(String.IsNullOrWhiteSpace(searchTerm),
                                                                  Await _repository.GetAllAsync(includeInactive).ConfigureAwait(False),
                                                                  Await _repository.SearchAsync(searchTerm, includeInactive).ConfigureAwait(False))
                                               Dim list = New BindingList(Of Employee)(employees.ToList())
                                               gridEmployees.InvokeIfRequired(Sub()
                                                                                 _bindingSource.DataSource = list
                                                                                 lblRecordCount.Text = $"{list.Count} employees"
                                                                             End Sub)
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to load employees.", ex)
                                           End Try
                                       End Function)
        End Function

        Private Sub gridEmployees_SelectionChanged(sender As Object, e As EventArgs) Handles gridEmployees.SelectionChanged
            If gridEmployees.SelectedRows.Count = 0 Then
                Return
            End If

            Dim employee = TryCast(gridEmployees.SelectedRows(0).DataBoundItem, Employee)
            If employee Is Nothing Then
                Return
            End If

            _currentEmployee = employee.Clone()
            PopulateForm(_currentEmployee)
            ToggleEditState(False)
        End Sub

        Private Sub PopulateForm(employee As Employee)
            txtEmployeeCode.Text = employee.EmployeeCode
            txtFirstName.Text = employee.FirstName
            txtLastName.Text = employee.LastName
            txtEmail.Text = employee.Email
            txtPhone.Text = employee.PhoneNumber
            cmbPosition.Text = employee.Position
            cmbDepartment.Text = employee.Department
            dtpHireDate.Value = If(employee.HireDate = Date.MinValue, Date.Today, employee.HireDate)
            numSalary.Value = Math.Max(0D, employee.BasicSalary)
            chkIsActive.Checked = employee.IsActive
        End Sub

        Private Sub ResetForm()
            txtEmployeeCode.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            cmbPosition.SelectedIndex = -1
            cmbDepartment.SelectedIndex = -1
            dtpHireDate.Value = Date.Today
            numSalary.Value = 0D
            chkIsActive.Checked = True
            errorProvider.Clear()
            _currentEmployee = Nothing
            ToggleEditState(True, isNew:=True)
        End Sub

        Private Sub ToggleEditState(isEditing As Boolean, Optional isNew As Boolean = False)
            pnlEditor.Enabled = isEditing OrElse isNew
            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnDelete.Enabled = Not isNew AndAlso _currentEmployee IsNot Nothing
        End Sub

        Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
            ResetForm()
            txtEmployeeCode.Focus()
        End Sub

        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            If _currentEmployee Is Nothing Then
                _dialog.ShowWarning("Please select an employee to edit.")
                Return
            End If
            ToggleEditState(True)
        End Sub

        Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim employee = If(_currentEmployee?.Clone(), New Employee())

            employee.EmployeeCode = txtEmployeeCode.Text.Trim()
            employee.FirstName = txtFirstName.Text.Trim()
            employee.LastName = txtLastName.Text.Trim()
            employee.Email = txtEmail.Text.Trim()
            employee.PhoneNumber = txtPhone.Text.Trim()
            employee.Position = cmbPosition.Text.Trim()
            employee.Department = cmbDepartment.Text.Trim()
            employee.HireDate = dtpHireDate.Value.Date
            employee.BasicSalary = numSalary.Value
            employee.IsActive = chkIsActive.Checked

            Dim validation = _validation.ValidateEmployee(employee)
            validation.ApplyTo(errorProvider, GetEditorControlMap())
            If Not validation.IsValid Then
                _dialog.ShowWarning("Please fix validation errors before saving.")
                Return
            End If

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               If employee.Id = 0 Then
                                                   employee.Id = Await _repository.CreateAsync(employee).ConfigureAwait(False)
                                                   _dialog.ShowInfo("Employee added successfully.")
                                               Else
                                                   Dim updated = Await _repository.UpdateAsync(employee).ConfigureAwait(False)
                                                   If Not updated Then
                                                       Throw New InvalidOperationException("The employee record may have been modified by another user.")
                                                   End If
                                                   _dialog.ShowInfo("Employee updated successfully.")
                                               End If
                                               Await LoadEmployeesAsync(txtSearch.Text).ConfigureAwait(False)
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to save employee.", ex)
                                           End Try
                                       End Function)

            ToggleEditState(False)
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            If _currentEmployee IsNot Nothing Then
                PopulateForm(_currentEmployee)
                ToggleEditState(False)
            Else
                ResetForm()
            End If
        End Sub

        Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If _currentEmployee Is Nothing Then
                Return
            End If

            If Not _dialog.AskConfirmation("Delete the selected employee? This cannot be undone.") Then
                Return
            End If

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim deleted = Await _repository.DeleteAsync(_currentEmployee.Id).ConfigureAwait(False)
                                               If deleted Then
                                                   _dialog.ShowInfo("Employee deleted.")
                                                   Await LoadEmployeesAsync(txtSearch.Text).ConfigureAwait(False)
                                               Else
                                                   _dialog.ShowWarning("Employee could not be deleted. It may have already been removed.")
                                               End If
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to delete employee.", ex)
                                           End Try
                                       End Function)

            ResetForm()
        End Sub

        Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            Await LoadEmployeesAsync(txtSearch.Text.Trim())
        End Sub

        Private Async Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                Await LoadEmployeesAsync(txtSearch.Text.Trim())
            End If
        End Sub

        Private Async Sub chkIncludeInactive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeInactive.CheckedChanged
            Await LoadEmployeesAsync(txtSearch.Text.Trim())
        End Sub

        Private Function GetEditorControlMap() As IDictionary(Of String, Control)
            Return New Dictionary(Of String, Control)(StringComparer.OrdinalIgnoreCase) From {
                {"EmployeeCode", txtEmployeeCode},
                {"FirstName", txtFirstName},
                {"LastName", txtLastName},
                {"Email", txtEmail},
                {"PhoneNumber", txtPhone},
                {"Position", cmbPosition},
                {"Department", cmbDepartment},
                {"BasicSalary", numSalary}
            }
        End Function

    End Class

End Namespace
