Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Linq
Imports Data
Imports Data.Models
Imports Utilities

Namespace Forms

    Public Class PayrollForm
        Inherits Form

        Private ReadOnly _payrollRepository As PayrollRepository
        Private ReadOnly _dialog As DialogService = DialogService.Instance
        Private ReadOnly _bindingSource As New BindingSource()
        Private _currentEntries As IList(Of PayrollEntry) = New List(Of PayrollEntry)()

        Public Sub New(payrollRepository As PayrollRepository)
            InitializeComponent()
            _payrollRepository = payrollRepository
            gridPayroll.ConfigureDataGrid()
            gridPayroll.DataSource = _bindingSource

            dtpPeriodStart.Value = New Date(Date.Today.Year, Date.Today.Month, 1)
            dtpPeriodEnd.Value = dtpPeriodStart.Value.AddMonths(1).AddDays(-1)
        End Sub

        Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UpdateSummary()
        End Sub

        Private Async Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
            Await GeneratePayrollAsync()
        End Sub

        Private Async Function GeneratePayrollAsync() As Task
            Dim period As New PayPeriod(dtpPeriodStart.Value.Date, dtpPeriodEnd.Value.Date)
            Dim taxRate = numTaxRate.Value
            Dim deductions = numAdditionalDeductions.Value

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim entries = Await _payrollRepository.GeneratePayrollAsync(period, taxRate, deductions).ConfigureAwait(False)
                                               _currentEntries = entries
                                               _bindingSource.DataSource = New BindingList(Of PayrollEntry)(entries.ToList())
                                               UpdateSummary()
                                               _dialog.ShowInfo("Payroll preview generated.")
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to generate payroll.", ex)
                                           End Try
                                       End Function)
        End Function

        Private Sub UpdateSummary()
            If _currentEntries Is Nothing OrElse _currentEntries.Count = 0 Then
                lblSummary.Text = "No payroll data"
                lblTotalNetPay.Text = "Net Pay: 0.00"
                lblTotalOvertime.Text = "OT Pay: 0.00"
                btnSave.Enabled = False
                btnExport.Enabled = False
                Return
            End If

            Dim count = _currentEntries.Count
            Dim totalNet = _currentEntries.Sum(Function(p) p.NetPay)
            Dim totalOvertime = _currentEntries.Sum(Function(p) p.OvertimePay)
            lblSummary.Text = $"{count} employees"
            lblTotalNetPay.Text = $"Net Pay: {totalNet:C2}"
            lblTotalOvertime.Text = $"OT Pay: {totalOvertime:C2}"
            btnSave.Enabled = True
            btnExport.Enabled = True
        End Sub

        Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If _currentEntries Is Nothing OrElse _currentEntries.Count = 0 Then
                _dialog.ShowWarning("Generate payroll before saving.")
                Return
            End If

            If Not _dialog.AskConfirmation("Persist the generated payroll to the database?") Then
                Return
            End If

            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Await _payrollRepository.SavePayrollBatchAsync(_currentEntries).ConfigureAwait(False)
                                               _dialog.ShowInfo("Payroll saved to database.")
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to save payroll batch.", ex)
                                           End Try
                                       End Function)
        End Sub

        Private Async Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            If _currentEntries Is Nothing OrElse _currentEntries.Count = 0 Then
                _dialog.ShowWarning("Generate payroll before exporting.")
                Return
            End If

            Using dialog As New SaveFileDialog()
                dialog.Filter = "CSV Files|*.csv"
                dialog.FileName = $"Payroll_{dtpPeriodStart.Value:yyyyMMdd}_{dtpPeriodEnd.Value:yyyyMMdd}.csv"
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    Await CsvExportService.ExportPayrollAsync(_currentEntries, dialog.FileName)
                    _dialog.ShowInfo("Payroll exported to CSV.")
                End If
            End Using
        End Sub

        Private Async Sub btnReloadHistory_Click(sender As Object, e As EventArgs) Handles btnReloadHistory.Click
            Dim period As New PayPeriod(dtpPeriodStart.Value.Date, dtpPeriodEnd.Value.Date)
            Await Me.RunOperationAsync(Async Function()
                                           Try
                                               Dim history = Await _payrollRepository.GetPayrollHistoryAsync(period).ConfigureAwait(False)
                                               _currentEntries = history
                                               _bindingSource.DataSource = New BindingList(Of PayrollEntry)(history.ToList())
                                               UpdateSummary()
                                               _dialog.ShowInfo("Historical payroll loaded.")
                                           Catch ex As Exception
                                               _dialog.ShowError("Unable to load payroll history.", ex)
                                           End Try
                                       End Function)
        End Sub

        Private Sub gridPayroll_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles gridPayroll.DataBindingComplete
            UpdateSummary()
        End Sub

        Private Async Sub btnQuickGenerate_Click(sender As Object, e As EventArgs) Handles btnQuickGenerate.Click
            numTaxRate.Value = 10D
            numAdditionalDeductions.Value = 0D
            Await GeneratePayrollAsync()
        End Sub

    End Class

End Namespace
