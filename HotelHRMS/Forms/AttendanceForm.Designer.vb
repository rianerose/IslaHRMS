<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Dim lblEmployee As System.Windows.Forms.Label
        Dim lblAttendanceDate As System.Windows.Forms.Label
        Dim lblCheckIn As System.Windows.Forms.Label
        Dim lblCheckOut As System.Windows.Forms.Label
        Dim lblNotes As System.Windows.Forms.Label
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.panelFilters = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.chkFilterByEmployee = New System.Windows.Forms.CheckBox()
        Me.cmbFilterEmployee = New System.Windows.Forms.ComboBox()
        Me.dtpFilterEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpFilterStart = New System.Windows.Forms.DateTimePicker()
        Me.labelTo = New System.Windows.Forms.Label()
        Me.labelFrom = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.gridAttendance = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelEditor = New System.Windows.Forms.Panel()
        Me.tableEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbEditorEmployee = New System.Windows.Forms.ComboBox()
        Me.dtpAttendanceDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.chkEnableTimes = New System.Windows.Forms.CheckBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        lblEmployee = New System.Windows.Forms.Label()
        lblAttendanceDate = New System.Windows.Forms.Label()
        lblCheckIn = New System.Windows.Forms.Label()
        lblCheckOut = New System.Windows.Forms.Label()
        lblNotes = New System.Windows.Forms.Label()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        Me.panelFilters.SuspendLayout()
        CType(Me.gridAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEditor.SuspendLayout()
        Me.tableEditor.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmployee
        '
        lblEmployee.AutoSize = True
        lblEmployee.Location = New System.Drawing.Point(3, 0)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New System.Drawing.Size(60, 15)
        lblEmployee.TabIndex = 0
        lblEmployee.Text = "Employee"
        '
        'lblAttendanceDate
        '
        lblAttendanceDate.AutoSize = True
        lblAttendanceDate.Location = New System.Drawing.Point(3, 50)
        lblAttendanceDate.Name = "lblAttendanceDate"
        lblAttendanceDate.Size = New System.Drawing.Size(88, 15)
        lblAttendanceDate.TabIndex = 2
        lblAttendanceDate.Text = "Attendance Day"
        '
        'lblCheckIn
        '
        lblCheckIn.AutoSize = True
        lblCheckIn.Location = New System.Drawing.Point(3, 100)
        lblCheckIn.Name = "lblCheckIn"
        lblCheckIn.Size = New System.Drawing.Size(52, 15)
        lblCheckIn.TabIndex = 4
        lblCheckIn.Text = "Check-in"
        '
        'lblCheckOut
        '
        lblCheckOut.AutoSize = True
        lblCheckOut.Location = New System.Drawing.Point(3, 140)
        lblCheckOut.Name = "lblCheckOut"
        lblCheckOut.Size = New System.Drawing.Size(60, 15)
        lblCheckOut.TabIndex = 6
        lblCheckOut.Text = "Check-out"
        '
        'lblNotes
        '
        lblNotes.AutoSize = True
        lblNotes.Location = New System.Drawing.Point(3, 180)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New System.Drawing.Size(36, 15)
        lblNotes.TabIndex = 8
        lblNotes.Text = "Notes"
        '
        'splitContainer
        '
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Panel1.Controls.Add(Me.gridAttendance)
        Me.splitContainer.Panel1.Controls.Add(Me.panelFilters)
        Me.splitContainer.Panel2.Controls.Add(Me.panelEditor)
        Me.splitContainer.Panel2.Controls.Add(Me.panelButtons)
        Me.splitContainer.Size = New System.Drawing.Size(1024, 600)
        Me.splitContainer.SplitterDistance = 600
        Me.splitContainer.TabIndex = 0
        '
        'panelFilters
        '
        Me.panelFilters.Controls.Add(Me.btnExport)
        Me.panelFilters.Controls.Add(Me.btnRefresh)
        Me.panelFilters.Controls.Add(Me.chkFilterByEmployee)
        Me.panelFilters.Controls.Add(Me.cmbFilterEmployee)
        Me.panelFilters.Controls.Add(Me.dtpFilterEnd)
        Me.panelFilters.Controls.Add(Me.dtpFilterStart)
        Me.panelFilters.Controls.Add(Me.labelTo)
        Me.panelFilters.Controls.Add(Me.labelFrom)
        Me.panelFilters.Controls.Add(Me.lblSummary)
        Me.panelFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelFilters.Name = "panelFilters"
        Me.panelFilters.Padding = New System.Windows.Forms.Padding(12)
        Me.panelFilters.Size = New System.Drawing.Size(600, 120)
        Me.panelFilters.TabIndex = 0
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(487, 64)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(96, 32)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(487, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 32)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkFilterByEmployee
        '
        Me.chkFilterByEmployee.AutoSize = True
        Me.chkFilterByEmployee.Location = New System.Drawing.Point(16, 80)
        Me.chkFilterByEmployee.Name = "chkFilterByEmployee"
        Me.chkFilterByEmployee.Size = New System.Drawing.Size(130, 19)
        Me.chkFilterByEmployee.TabIndex = 3
        Me.chkFilterByEmployee.Text = "Filter specific staff"
        Me.chkFilterByEmployee.UseVisualStyleBackColor = True
        '
        'cmbEmployee
        '
        Me.cmbFilterEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFilterEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterEmployee.FormattingEnabled = True
        Me.cmbFilterEmployee.Location = New System.Drawing.Point(170, 78)
        Me.cmbFilterEmployee.Name = "cmbFilterEmployee"
        Me.cmbFilterEmployee.Size = New System.Drawing.Size(299, 23)
        Me.cmbFilterEmployee.TabIndex = 4
        '
        'dtpFilterEnd
        '
        Me.dtpFilterEnd.Location = New System.Drawing.Point(170, 46)
        Me.dtpFilterEnd.Name = "dtpFilterEnd"
        Me.dtpFilterEnd.Size = New System.Drawing.Size(200, 23)
        Me.dtpFilterEnd.TabIndex = 2
        '
        'dtpFilterStart
        '
        Me.dtpFilterStart.Location = New System.Drawing.Point(170, 14)
        Me.dtpFilterStart.Name = "dtpFilterStart"
        Me.dtpFilterStart.Size = New System.Drawing.Size(200, 23)
        Me.dtpFilterStart.TabIndex = 1
        '
        'labelTo
        '
        Me.labelTo.AutoSize = True
        Me.labelTo.Location = New System.Drawing.Point(135, 50)
        Me.labelTo.Name = "labelTo"
        Me.labelTo.Size = New System.Drawing.Size(19, 15)
        Me.labelTo.TabIndex = 5
        Me.labelTo.Text = "To"
        '
        'labelFrom
        '
        Me.labelFrom.AutoSize = True
        Me.labelFrom.Location = New System.Drawing.Point(122, 18)
        Me.labelFrom.Name = "labelFrom"
        Me.labelFrom.Size = New System.Drawing.Size(33, 15)
        Me.labelFrom.TabIndex = 4
        Me.labelFrom.Text = "From"
        '
        'lblSummary
        '
        Me.lblSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSummary.Location = New System.Drawing.Point(380, 14)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(96, 23)
        Me.lblSummary.TabIndex = 8
        Me.lblSummary.Text = "0 records"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gridAttendance
        '
        Me.gridAttendance.AllowUserToAddRows = False
        Me.gridAttendance.AllowUserToDeleteRows = False
        Me.gridAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAttendance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colEmployee, Me.colCheckIn, Me.colCheckOut, Me.colHours, Me.colNotes})
        Me.gridAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAttendance.Location = New System.Drawing.Point(0, 120)
        Me.gridAttendance.MultiSelect = False
        Me.gridAttendance.Name = "gridAttendance"
        Me.gridAttendance.ReadOnly = True
        Me.gridAttendance.RowHeadersVisible = False
        Me.gridAttendance.RowTemplate.Height = 26
        Me.gridAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAttendance.Size = New System.Drawing.Size(600, 480)
        Me.gridAttendance.TabIndex = 1
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "AttendanceDate"
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 90
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.DefaultCellStyle.Format = "d"
        '
        'colEmployee
        '
        Me.colEmployee.DataPropertyName = "EmployeeId"
        Me.colEmployee.HeaderText = "Employee ID"
        Me.colEmployee.MinimumWidth = 90
        Me.colEmployee.Name = "colEmployee"
        Me.colEmployee.ReadOnly = True
        '
        'colCheckIn
        '
        Me.colCheckIn.DataPropertyName = "CheckInTime"
        Me.colCheckIn.HeaderText = "Check-in"
        Me.colCheckIn.MinimumWidth = 90
        Me.colCheckIn.Name = "colCheckIn"
        Me.colCheckIn.ReadOnly = True
        Me.colCheckIn.DefaultCellStyle.Format = "t"
        '
        'colCheckOut
        '
        Me.colCheckOut.DataPropertyName = "CheckOutTime"
        Me.colCheckOut.HeaderText = "Check-out"
        Me.colCheckOut.MinimumWidth = 90
        Me.colCheckOut.Name = "colCheckOut"
        Me.colCheckOut.ReadOnly = True
        Me.colCheckOut.DefaultCellStyle.Format = "t"
        '
        'colHours
        '
        Me.colHours.DataPropertyName = "HoursWorked"
        Me.colHours.HeaderText = "Hours"
        Me.colHours.MinimumWidth = 70
        Me.colHours.Name = "colHours"
        Me.colHours.ReadOnly = True
        Me.colHours.DefaultCellStyle.Format = "N2"
        '
        'colNotes
        '
        Me.colNotes.DataPropertyName = "Notes"
        Me.colNotes.HeaderText = "Notes"
        Me.colNotes.MinimumWidth = 150
        Me.colNotes.Name = "colNotes"
        Me.colNotes.ReadOnly = True
        '
        'panelEditor
        '
        Me.panelEditor.Controls.Add(Me.tableEditor)
        Me.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEditor.Location = New System.Drawing.Point(0, 0)
        Me.panelEditor.Name = "panelEditor"
        Me.panelEditor.Padding = New System.Windows.Forms.Padding(16)
        Me.panelEditor.Size = New System.Drawing.Size(420, 530)
        Me.panelEditor.TabIndex = 0
        '
        'tableEditor
        '
        Me.tableEditor.ColumnCount = 2
        Me.tableEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tableEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableEditor.Controls.Add(lblEmployee, 0, 0)
        Me.tableEditor.Controls.Add(Me.cmbEditorEmployee, 1, 0)
        Me.tableEditor.Controls.Add(lblAttendanceDate, 0, 1)
        Me.tableEditor.Controls.Add(Me.dtpAttendanceDate, 1, 1)
        Me.tableEditor.Controls.Add(lblCheckIn, 0, 2)
        Me.tableEditor.Controls.Add(Me.dtpCheckIn, 1, 2)
        Me.tableEditor.Controls.Add(lblCheckOut, 0, 3)
        Me.tableEditor.Controls.Add(Me.dtpCheckOut, 1, 3)
        Me.tableEditor.Controls.Add(Me.chkEnableTimes, 1, 4)
        Me.tableEditor.Controls.Add(lblNotes, 0, 5)
        Me.tableEditor.Controls.Add(Me.txtNotes, 1, 5)
        Me.tableEditor.Controls.Add(Me.lblHoursWorked, 1, 6)
        Me.tableEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableEditor.Location = New System.Drawing.Point(16, 16)
        Me.tableEditor.Name = "tableEditor"
        Me.tableEditor.RowCount = 8
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableEditor.Size = New System.Drawing.Size(388, 498)
        Me.tableEditor.TabIndex = 0
        '
        'dtpAttendanceDate
        '
        Me.cmbEditorEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEditorEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditorEmployee.FormattingEnabled = True
        Me.cmbEditorEmployee.Location = New System.Drawing.Point(123, 3)
        Me.cmbEditorEmployee.Name = "cmbEditorEmployee"
        Me.cmbEditorEmployee.Size = New System.Drawing.Size(262, 23)
        Me.cmbEditorEmployee.TabIndex = 1

        Me.dtpAttendanceDate.Location = New System.Drawing.Point(123, 53)
        Me.dtpAttendanceDate.Name = "dtpAttendanceDate"
        Me.dtpAttendanceDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpAttendanceDate.TabIndex = 3
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CustomFormat = "HH:mm"
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckIn.Location = New System.Drawing.Point(123, 103)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.ShowUpDown = True
        Me.dtpCheckIn.Size = New System.Drawing.Size(100, 23)
        Me.dtpCheckIn.TabIndex = 5
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CustomFormat = "HH:mm"
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOut.Location = New System.Drawing.Point(123, 153)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.ShowUpDown = True
        Me.dtpCheckOut.Size = New System.Drawing.Size(100, 23)
        Me.dtpCheckOut.TabIndex = 7
        '
        'chkEnableTimes
        '
        Me.chkEnableTimes.AutoSize = True
        Me.chkEnableTimes.Checked = True
        Me.chkEnableTimes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnableTimes.Location = New System.Drawing.Point(123, 203)
        Me.chkEnableTimes.Name = "chkEnableTimes"
        Me.chkEnableTimes.Size = New System.Drawing.Size(170, 19)
        Me.chkEnableTimes.TabIndex = 9
        Me.chkEnableTimes.Text = "Include check-in/out times"
        Me.chkEnableTimes.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right) Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Location = New System.Drawing.Point(123, 243)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(262, 114)
        Me.txtNotes.TabIndex = 10
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHoursWorked.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.lblHoursWorked.Location = New System.Drawing.Point(123, 367)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(53, 19)
        Me.lblHoursWorked.TabIndex = 11
        Me.lblHoursWorked.Text = "0 hrs"
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.btnDelete)
        Me.panelButtons.Controls.Add(Me.btnSave)
        Me.panelButtons.Controls.Add(Me.btnNew)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 530)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Padding = New System.Windows.Forms.Padding(16)
        Me.panelButtons.Size = New System.Drawing.Size(420, 70)
        Me.panelButtons.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(195, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 34)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(291, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(19, 18)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 34)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'AttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.splitContainer)
        Me.MinimumSize = New System.Drawing.Size(1040, 640)
        Me.Name = "AttendanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attendance Management"
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        Me.panelFilters.ResumeLayout(False)
        Me.panelFilters.PerformLayout()
        CType(Me.gridAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEditor.ResumeLayout(False)
        Me.tableEditor.ResumeLayout(False)
        Me.tableEditor.PerformLayout()
        Me.panelButtons.ResumeLayout(False)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents panelFilters As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents chkFilterByEmployee As System.Windows.Forms.CheckBox
    Friend WithEvents cmbFilterEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFilterEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFilterStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelTo As System.Windows.Forms.Label
    Friend WithEvents labelFrom As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents gridAttendance As System.Windows.Forms.DataGridView
    Friend WithEvents panelEditor As System.Windows.Forms.Panel
    Friend WithEvents tableEditor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbEditorEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAttendanceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkEnableTimes As System.Windows.Forms.CheckBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
