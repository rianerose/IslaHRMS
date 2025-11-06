<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.btnQuickGenerate = New System.Windows.Forms.Button()
        Me.btnReloadHistory = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.numAdditionalDeductions = New System.Windows.Forms.NumericUpDown()
        Me.labelDeductions = New System.Windows.Forms.Label()
        Me.numTaxRate = New System.Windows.Forms.NumericUpDown()
        Me.labelTaxRate = New System.Windows.Forms.Label()
        Me.dtpPeriodEnd = New System.Windows.Forms.DateTimePicker()
        Me.labelTo = New System.Windows.Forms.Label()
        Me.labelPeriod = New System.Windows.Forms.Label()
        Me.dtpPeriodStart = New System.Windows.Forms.DateTimePicker()
        Me.panelSummary = New System.Windows.Forms.Panel()
        Me.lblTotalOvertime = New System.Windows.Forms.Label()
        Me.lblTotalNetPay = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.gridPayroll = New System.Windows.Forms.DataGridView()
        Me.colEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBaseHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOvertimeHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTaxes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelActions = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.panelSpacer = New System.Windows.Forms.Panel()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tableLayout.SuspendLayout()
        Me.panelFilters.SuspendLayout()
        CType(Me.numAdditionalDeductions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTaxRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSummary.SuspendLayout()
        CType(Me.gridPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayout
        '
        Me.tableLayout.ColumnCount = 1
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayout.Controls.Add(Me.panelFilters, 0, 0)
        Me.tableLayout.Controls.Add(Me.panelSummary, 0, 1)
        Me.tableLayout.Controls.Add(Me.gridPayroll, 0, 2)
        Me.tableLayout.Controls.Add(Me.panelActions, 0, 3)
        Me.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayout.Location = New System.Drawing.Point(0, 0)
        Me.tableLayout.Name = "tableLayout"
        Me.tableLayout.RowCount = 4
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tableLayout.Size = New System.Drawing.Size(1000, 640)
        Me.tableLayout.TabIndex = 0
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.btnQuickGenerate)
        Me.panelFilters.Controls.Add(Me.btnReloadHistory)
        Me.panelFilters.Controls.Add(Me.btnGenerate)
        Me.panelFilters.Controls.Add(Me.numAdditionalDeductions)
        Me.panelFilters.Controls.Add(Me.labelDeductions)
        Me.panelFilters.Controls.Add(Me.numTaxRate)
        Me.panelFilters.Controls.Add(Me.labelTaxRate)
        Me.panelFilters.Controls.Add(Me.dtpPeriodEnd)
        Me.panelFilters.Controls.Add(Me.labelTo)
        Me.panelFilters.Controls.Add(Me.labelPeriod)
        Me.panelFilters.Controls.Add(Me.dtpPeriodStart)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFilters.Location = New System.Drawing.Point(3, 3)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Padding = New System.Windows.Forms.Padding(16)
        Me.panelFilters.Size = New System.Drawing.Size(994, 114)
        Me.panelFilters.TabIndex = 0
        '
        'btnQuickGenerate
        '
        Me.btnQuickGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickGenerate.Location = New System.Drawing.Point(676, 67)
        Me.btnQuickGenerate.Name = "btnQuickGenerate"
        Me.btnQuickGenerate.Size = New System.Drawing.Size(140, 32)
        Me.btnQuickGenerate.TabIndex = 9
        Me.btnQuickGenerate.Text = "Quick Generate"
        Me.btnQuickGenerate.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnQuickGenerate, "Generate payroll using default settings")
        '
        'btnReloadHistory
        '
        Me.btnReloadHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReloadHistory.Location = New System.Drawing.Point(822, 67)
        Me.btnReloadHistory.Name = "btnReloadHistory"
        Me.btnReloadHistory.Size = New System.Drawing.Size(140, 32)
        Me.btnReloadHistory.TabIndex = 10
        Me.btnReloadHistory.Text = "Load Saved Batch"
        Me.btnReloadHistory.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(530, 67)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(140, 32)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate Preview"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'numAdditionalDeductions
        '
        Me.numAdditionalDeductions.DecimalPlaces = 2
        Me.numAdditionalDeductions.Location = New System.Drawing.Point(363, 72)
        Me.numAdditionalDeductions.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numAdditionalDeductions.Name = "numAdditionalDeductions"
        Me.numAdditionalDeductions.Size = New System.Drawing.Size(120, 23)
        Me.numAdditionalDeductions.TabIndex = 7
        Me.numAdditionalDeductions.ThousandsSeparator = True
        '
        'labelDeductions
        '
        Me.labelDeductions.AutoSize = True
        Me.labelDeductions.Location = New System.Drawing.Point(215, 74)
        Me.labelDeductions.Name = "labelDeductions"
        Me.labelDeductions.Size = New System.Drawing.Size(133, 15)
        Me.labelDeductions.TabIndex = 6
        Me.labelDeductions.Text = "Add. Deductions (fixed)"
        '
        'numTaxRate
        '
        Me.numTaxRate.DecimalPlaces = 2
        Me.numTaxRate.Location = New System.Drawing.Point(363, 35)
        Me.numTaxRate.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numTaxRate.Name = "numTaxRate"
        Me.numTaxRate.Size = New System.Drawing.Size(120, 23)
        Me.numTaxRate.TabIndex = 5
        Me.numTaxRate.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'labelTaxRate
        '
        Me.labelTaxRate.AutoSize = True
        Me.labelTaxRate.Location = New System.Drawing.Point(215, 37)
        Me.labelTaxRate.Name = "labelTaxRate"
        Me.labelTaxRate.Size = New System.Drawing.Size(129, 15)
        Me.labelTaxRate.TabIndex = 4
        Me.labelTaxRate.Text = "Tax / Statutory Rate (%)"
        '
        'dtpPeriodEnd
        '
        Me.dtpPeriodEnd.Location = New System.Drawing.Point(93, 71)
        Me.dtpPeriodEnd.Name = "dtpPeriodEnd"
        Me.dtpPeriodEnd.Size = New System.Drawing.Size(116, 23)
        Me.dtpPeriodEnd.TabIndex = 3
        '
        'labelTo
        '
        Me.labelTo.AutoSize = True
        Me.labelTo.Location = New System.Drawing.Point(68, 75)
        Me.labelTo.Name = "labelTo"
        Me.labelTo.Size = New System.Drawing.Size(19, 15)
        Me.labelTo.TabIndex = 2
        Me.labelTo.Text = "To"
        '
        'labelPeriod
        '
        Me.labelPeriod.AutoSize = True
        Me.labelPeriod.Location = New System.Drawing.Point(16, 37)
        Me.labelPeriod.Name = "labelPeriod"
        Me.labelPeriod.Size = New System.Drawing.Size(41, 15)
        Me.labelPeriod.TabIndex = 0
        Me.labelPeriod.Text = "Period"
        '
        'dtpPeriodStart
        '
        Me.dtpPeriodStart.Location = New System.Drawing.Point(93, 33)
        Me.dtpPeriodStart.Name = "dtpPeriodStart"
        Me.dtpPeriodStart.Size = New System.Drawing.Size(116, 23)
        Me.dtpPeriodStart.TabIndex = 1
        '
        'panelSummary
        '
        Me.panelSummary.Controls.Add(Me.lblTotalOvertime)
        Me.panelSummary.Controls.Add(Me.lblTotalNetPay)
        Me.panelSummary.Controls.Add(Me.lblSummary)
        Me.panelSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSummary.Location = New System.Drawing.Point(3, 123)
        Me.panelSummary.Name = "panelSummary"
        Me.panelSummary.Padding = New System.Windows.Forms.Padding(16)
        Me.panelSummary.Size = New System.Drawing.Size(994, 54)
        Me.panelSummary.TabIndex = 1
        '
        'lblTotalOvertime
        '
        Me.lblTotalOvertime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalOvertime.Location = New System.Drawing.Point(609, 16)
        Me.lblTotalOvertime.Name = "lblTotalOvertime"
        Me.lblTotalOvertime.Size = New System.Drawing.Size(180, 23)
        Me.lblTotalOvertime.TabIndex = 2
        Me.lblTotalOvertime.Text = "OT Pay: 0.00"
        Me.lblTotalOvertime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalNetPay
        '
        Me.lblTotalNetPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalNetPay.Location = New System.Drawing.Point(795, 16)
        Me.lblTotalNetPay.Name = "lblTotalNetPay"
        Me.lblTotalNetPay.Size = New System.Drawing.Size(183, 23)
        Me.lblTotalNetPay.TabIndex = 1
        Me.lblTotalNetPay.Text = "Net Pay: 0.00"
        Me.lblTotalNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(19, 18)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(97, 15)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "No payroll data"
        '
        'gridPayroll
        '
        Me.gridPayroll.AllowUserToAddRows = False
        Me.gridPayroll.AllowUserToDeleteRows = False
        Me.gridPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEmployee, Me.colBaseHours, Me.colOvertimeHours, Me.colGross, Me.colNet, Me.colTaxes, Me.colNotes})
        Me.gridPayroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPayroll.Location = New System.Drawing.Point(3, 183)
        Me.gridPayroll.MultiSelect = False
        Me.gridPayroll.Name = "gridPayroll"
        Me.gridPayroll.ReadOnly = True
        Me.gridPayroll.RowHeadersVisible = False
        Me.gridPayroll.RowTemplate.Height = 26
        Me.gridPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridPayroll.Size = New System.Drawing.Size(994, 384)
        Me.gridPayroll.TabIndex = 2
        '
        'colEmployee
        '
        Me.colEmployee.DataPropertyName = "EmployeeName"
        Me.colEmployee.HeaderText = "Employee"
        Me.colEmployee.MinimumWidth = 150
        Me.colEmployee.Name = "colEmployee"
        Me.colEmployee.ReadOnly = True
        '
        'colBaseHours
        '
        Me.colBaseHours.DataPropertyName = "BaseHoursWorked"
        Me.colBaseHours.HeaderText = "Base Hours"
        Me.colBaseHours.MinimumWidth = 80
        Me.colBaseHours.Name = "colBaseHours"
        Me.colBaseHours.ReadOnly = True
        Me.colBaseHours.DefaultCellStyle.Format = "N2"
        '
        'colOvertimeHours
        '
        Me.colOvertimeHours.DataPropertyName = "OvertimeHours"
        Me.colOvertimeHours.HeaderText = "OT Hours"
        Me.colOvertimeHours.MinimumWidth = 80
        Me.colOvertimeHours.Name = "colOvertimeHours"
        Me.colOvertimeHours.ReadOnly = True
        Me.colOvertimeHours.DefaultCellStyle.Format = "N2"
        '
        'colGross
        '
        Me.colGross.DataPropertyName = "GrossPay"
        Me.colGross.HeaderText = "Gross"
        Me.colGross.MinimumWidth = 80
        Me.colGross.Name = "colGross"
        Me.colGross.ReadOnly = True
        Me.colGross.DefaultCellStyle.Format = "C2"
        '
        'colNet
        '
        Me.colNet.DataPropertyName = "NetPay"
        Me.colNet.HeaderText = "Net"
        Me.colNet.MinimumWidth = 80
        Me.colNet.Name = "colNet"
        Me.colNet.ReadOnly = True
        Me.colNet.DefaultCellStyle.Format = "C2"
        '
        'colTaxes
        '
        Me.colTaxes.DataPropertyName = "Taxes"
        Me.colTaxes.HeaderText = "Taxes"
        Me.colTaxes.MinimumWidth = 80
        Me.colTaxes.Name = "colTaxes"
        Me.colTaxes.ReadOnly = True
        Me.colTaxes.DefaultCellStyle.Format = "C2"
        '
        'colNotes
        '
        Me.colNotes.DataPropertyName = "Notes"
        Me.colNotes.HeaderText = "Notes"
        Me.colNotes.MinimumWidth = 150
        Me.colNotes.Name = "colNotes"
        Me.colNotes.ReadOnly = True
        '
        'panelActions
        '
        Me.panelActions.Controls.Add(Me.btnExport)
        Me.panelActions.Controls.Add(Me.btnSave)
        Me.panelActions.Controls.Add(Me.panelSpacer)
        Me.panelActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelActions.Location = New System.Drawing.Point(3, 573)
        Me.panelActions.Name = "panelActions"
        Me.panelActions.Padding = New System.Windows.Forms.Padding(16)
        Me.panelActions.Size = New System.Drawing.Size(994, 64)
        Me.panelActions.TabIndex = 3
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(774, 16)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 32)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(880, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save Batch"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'panelSpacer
        '
        Me.panelSpacer.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSpacer.Location = New System.Drawing.Point(16, 16)
        Me.panelSpacer.Name = "panelSpacer"
        Me.panelSpacer.Size = New System.Drawing.Size(200, 32)
        Me.panelSpacer.TabIndex = 0
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 640)
        Me.Controls.Add(Me.tableLayout)
        Me.MinimumSize = New System.Drawing.Size(1020, 680)
        Me.Name = "PayrollForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payroll Generation"
        Me.tableLayout.ResumeLayout(False)
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        CType(Me.numAdditionalDeductions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTaxRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSummary.ResumeLayout(False)
        Me.panelSummary.PerformLayout()
        CType(Me.gridPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelFilters As System.Windows.Forms.Panel
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents numAdditionalDeductions As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelDeductions As System.Windows.Forms.Label
    Friend WithEvents numTaxRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelTaxRate As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelTo As System.Windows.Forms.Label
    Friend WithEvents labelPeriod As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents panelSummary As System.Windows.Forms.Panel
    Friend WithEvents lblTotalOvertime As System.Windows.Forms.Label
    Friend WithEvents lblTotalNetPay As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents gridPayroll As System.Windows.Forms.DataGridView
    Friend WithEvents panelActions As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents panelSpacer As System.Windows.Forms.Panel
    Friend WithEvents btnQuickGenerate As System.Windows.Forms.Button
    Friend WithEvents btnReloadHistory As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents colEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBaseHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOvertimeHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGross As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTaxes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
