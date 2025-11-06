<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Dim lblCode As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblEmail As System.Windows.Forms.Label
        Dim lblPhone As System.Windows.Forms.Label
        Dim lblPosition As System.Windows.Forms.Label
        Dim lblDepartment As System.Windows.Forms.Label
        Dim lblHireDate As System.Windows.Forms.Label
        Dim lblSalary As System.Windows.Forms.Label
        Me.splitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.panelList = New System.Windows.Forms.Panel()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.chkIncludeInactive = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gridEmployees = New System.Windows.Forms.DataGridView()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.tableEditor = New System.Windows.Forms.TableLayoutPanel()
        Me.txtEmployeeCode = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.numSalary = New System.Windows.Forms.NumericUpDown()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        lblCode = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblEmail = New System.Windows.Forms.Label()
        lblPhone = New System.Windows.Forms.Label()
        lblPosition = New System.Windows.Forms.Label()
        lblDepartment = New System.Windows.Forms.Label()
        lblHireDate = New System.Windows.Forms.Label()
        lblSalary = New System.Windows.Forms.Label()
        CType(Me.splitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerMain.Panel1.SuspendLayout()
        Me.splitContainerMain.Panel2.SuspendLayout()
        Me.splitContainerMain.SuspendLayout()
        Me.panelList.SuspendLayout()
        CType(Me.gridEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelButtons.SuspendLayout()
        Me.pnlEditor.SuspendLayout()
        Me.tableEditor.SuspendLayout()
        CType(Me.numSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCode
        '
        lblCode.AutoSize = True
        lblCode.Location = New System.Drawing.Point(3, 0)
        lblCode.Name = "lblCode"
        lblCode.Size = New System.Drawing.Size(81, 15)
        lblCode.TabIndex = 0
        lblCode.Text = "Employee Code"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Location = New System.Drawing.Point(3, 40)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(64, 15)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Location = New System.Drawing.Point(3, 80)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(63, 15)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.Location = New System.Drawing.Point(3, 120)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(39, 15)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Email"
        '
        'lblPhone
        '
        lblPhone.AutoSize = True
        lblPhone.Location = New System.Drawing.Point(3, 160)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New System.Drawing.Size(79, 15)
        lblPhone.TabIndex = 8
        lblPhone.Text = "Phone Number"
        '
        'lblPosition
        '
        lblPosition.AutoSize = True
        lblPosition.Location = New System.Drawing.Point(3, 200)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New System.Drawing.Size(51, 15)
        lblPosition.TabIndex = 10
        lblPosition.Text = "Position"
        '
        'lblDepartment
        '
        lblDepartment.AutoSize = True
        lblDepartment.Location = New System.Drawing.Point(3, 240)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New System.Drawing.Size(70, 15)
        lblDepartment.TabIndex = 12
        lblDepartment.Text = "Department"
        '
        'lblHireDate
        '
        lblHireDate.AutoSize = True
        lblHireDate.Location = New System.Drawing.Point(3, 280)
        lblHireDate.Name = "lblHireDate"
        lblHireDate.Size = New System.Drawing.Size(57, 15)
        lblHireDate.TabIndex = 14
        lblHireDate.Text = "Hire Date"
        '
        'lblSalary
        '
        lblSalary.AutoSize = True
        lblSalary.Location = New System.Drawing.Point(3, 320)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New System.Drawing.Size(72, 15)
        lblSalary.TabIndex = 16
        lblSalary.Text = "Basic Salary"
        '
        'splitContainerMain
        '
        Me.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.splitContainerMain.Name = "splitContainerMain"
        Me.splitContainerMain.Panel1.Controls.Add(Me.panelList)
        Me.splitContainerMain.Panel2.Controls.Add(Me.pnlEditor)
        Me.splitContainerMain.Panel2.Controls.Add(Me.panelButtons)
        Me.splitContainerMain.Size = New System.Drawing.Size(984, 561)
        Me.splitContainerMain.SplitterDistance = 470
        Me.splitContainerMain.TabIndex = 0
        '
        'panelList
        '
        Me.panelList.Controls.Add(Me.lblRecordCount)
        Me.panelList.Controls.Add(Me.chkIncludeInactive)
        Me.panelList.Controls.Add(Me.btnSearch)
        Me.panelList.Controls.Add(Me.txtSearch)
        Me.panelList.Controls.Add(Me.gridEmployees)
        Me.panelList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelList.Location = New System.Drawing.Point(0, 0)
        Me.panelList.Name = "panelList"
        Me.panelList.Padding = New System.Windows.Forms.Padding(12)
        Me.panelList.Size = New System.Drawing.Size(470, 561)
        Me.panelList.TabIndex = 0
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.Location = New System.Drawing.Point(256, 526)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(202, 23)
        Me.lblRecordCount.TabIndex = 4
        Me.lblRecordCount.Text = "0 employees"
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkIncludeInactive
        '
        Me.chkIncludeInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncludeInactive.AutoSize = True
        Me.chkIncludeInactive.Location = New System.Drawing.Point(356, 50)
        Me.chkIncludeInactive.Name = "chkIncludeInactive"
        Me.chkIncludeInactive.Size = New System.Drawing.Size(102, 19)
        Me.chkIncludeInactive.TabIndex = 2
        Me.chkIncludeInactive.Text = "Show Inactive"
        Me.chkIncludeInactive.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(356, 17)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(15, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search by code, name, email, or department"
        Me.txtSearch.Size = New System.Drawing.Size(335, 23)
        Me.txtSearch.TabIndex = 0
        '
        'gridEmployees
        '
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepartment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.gridEmployees.AllowUserToAddRows = False
        Me.gridEmployees.AllowUserToDeleteRows = False
        Me.gridEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCode, Me.colName, Me.colEmail, Me.colDepartment, Me.colPosition, Me.colHireDate})
        Me.gridEmployees.Location = New System.Drawing.Point(15, 75)
        Me.gridEmployees.MultiSelect = False
        Me.gridEmployees.Name = "gridEmployees"
        Me.gridEmployees.ReadOnly = True
        Me.gridEmployees.RowHeadersVisible = False
        Me.gridEmployees.RowTemplate.Height = 28
        Me.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEmployees.Size = New System.Drawing.Size(443, 448)
        Me.gridEmployees.TabIndex = 3

        Me.colCode.DataPropertyName = "EmployeeCode"
        Me.colCode.HeaderText = "Code"
        Me.colCode.MinimumWidth = 80
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True

        Me.colName.DataPropertyName = "FullName"
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 120
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True

        Me.colEmail.DataPropertyName = "Email"
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.MinimumWidth = 120
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True

        Me.colDepartment.DataPropertyName = "Department"
        Me.colDepartment.HeaderText = "Department"
        Me.colDepartment.MinimumWidth = 100
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.ReadOnly = True

        Me.colPosition.DataPropertyName = "Position"
        Me.colPosition.HeaderText = "Position"
        Me.colPosition.MinimumWidth = 100
        Me.colPosition.Name = "colPosition"
        Me.colPosition.ReadOnly = True

        Me.colHireDate.DataPropertyName = "HireDate"
        Me.colHireDate.HeaderText = "Hire Date"
        Me.colHireDate.MinimumWidth = 90
        Me.colHireDate.Name = "colHireDate"
        Me.colHireDate.ReadOnly = True
        Me.colHireDate.DefaultCellStyle.Format = "d"
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.btnCancel)
        Me.panelButtons.Controls.Add(Me.btnSave)
        Me.panelButtons.Controls.Add(Me.btnDelete)
        Me.panelButtons.Controls.Add(Me.btnEdit)
        Me.panelButtons.Controls.Add(Me.btnNew)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 491)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Padding = New System.Windows.Forms.Padding(12)
        Me.panelButtons.Size = New System.Drawing.Size(510, 70)
        Me.panelButtons.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(408, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 34)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(318, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 34)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(208, 18)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 34)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(118, 18)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 34)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(28, 18)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(84, 34)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'pnlEditor
        '
        Me.pnlEditor.Controls.Add(Me.tableEditor)
        Me.pnlEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEditor.Location = New System.Drawing.Point(0, 0)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlEditor.Size = New System.Drawing.Size(510, 491)
        Me.pnlEditor.TabIndex = 0
        '
        'tableEditor
        '
        Me.tableEditor.ColumnCount = 2
        Me.tableEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tableEditor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableEditor.Controls.Add(lblCode, 0, 0)
        Me.tableEditor.Controls.Add(Me.txtEmployeeCode, 1, 0)
        Me.tableEditor.Controls.Add(lblFirstName, 0, 1)
        Me.tableEditor.Controls.Add(Me.txtFirstName, 1, 1)
        Me.tableEditor.Controls.Add(lblLastName, 0, 2)
        Me.tableEditor.Controls.Add(Me.txtLastName, 1, 2)
        Me.tableEditor.Controls.Add(lblEmail, 0, 3)
        Me.tableEditor.Controls.Add(Me.txtEmail, 1, 3)
        Me.tableEditor.Controls.Add(lblPhone, 0, 4)
        Me.tableEditor.Controls.Add(Me.txtPhone, 1, 4)
        Me.tableEditor.Controls.Add(lblPosition, 0, 5)
        Me.tableEditor.Controls.Add(Me.cmbPosition, 1, 5)
        Me.tableEditor.Controls.Add(lblDepartment, 0, 6)
        Me.tableEditor.Controls.Add(Me.cmbDepartment, 1, 6)
        Me.tableEditor.Controls.Add(lblHireDate, 0, 7)
        Me.tableEditor.Controls.Add(Me.dtpHireDate, 1, 7)
        Me.tableEditor.Controls.Add(lblSalary, 0, 8)
        Me.tableEditor.Controls.Add(Me.numSalary, 1, 8)
        Me.tableEditor.Controls.Add(Me.chkIsActive, 1, 9)
        Me.tableEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableEditor.Location = New System.Drawing.Point(16, 16)
        Me.tableEditor.Name = "tableEditor"
        Me.tableEditor.RowCount = 11
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tableEditor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableEditor.Size = New System.Drawing.Size(478, 459)
        Me.tableEditor.TabIndex = 0
        '
        'txtEmployeeCode
        '
        Me.txtEmployeeCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmployeeCode.Location = New System.Drawing.Point(123, 3)
        Me.txtEmployeeCode.Name = "txtEmployeeCode"
        Me.txtEmployeeCode.Size = New System.Drawing.Size(352, 23)
        Me.txtEmployeeCode.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.Location = New System.Drawing.Point(123, 43)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(352, 23)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.Location = New System.Drawing.Point(123, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(352, 23)
        Me.txtLastName.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(123, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(352, 23)
        Me.txtEmail.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.Location = New System.Drawing.Point(123, 163)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(352, 23)
        Me.txtPhone.TabIndex = 9
        '
        'cmbPosition
        '
        Me.cmbPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Location = New System.Drawing.Point(123, 203)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(352, 23)
        Me.cmbPosition.TabIndex = 11
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(123, 243)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(352, 23)
        Me.cmbDepartment.TabIndex = 13
        '
        'dtpHireDate
        '
        Me.dtpHireDate.Location = New System.Drawing.Point(123, 283)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpHireDate.TabIndex = 15
        '
        'numSalary
        '
        Me.numSalary.DecimalPlaces = 2
        Me.numSalary.Location = New System.Drawing.Point(123, 323)
        Me.numSalary.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numSalary.Name = "numSalary"
        Me.numSalary.Size = New System.Drawing.Size(200, 23)
        Me.numSalary.TabIndex = 17
        Me.numSalary.ThousandsSeparator = True
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Location = New System.Drawing.Point(123, 363)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(64, 19)
        Me.chkIsActive.TabIndex = 18
        Me.chkIsActive.Text = "Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.splitContainerMain)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Management"
        Me.splitContainerMain.Panel1.ResumeLayout(False)
        Me.splitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.splitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerMain.ResumeLayout(False)
        Me.panelList.ResumeLayout(False)
        Me.panelList.PerformLayout()
        CType(Me.gridEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelButtons.ResumeLayout(False)
        Me.pnlEditor.ResumeLayout(False)
        Me.tableEditor.ResumeLayout(False)
        Me.tableEditor.PerformLayout()
        CType(Me.numSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents splitContainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents panelList As System.Windows.Forms.Panel
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents chkIncludeInactive As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents gridEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnlEditor As System.Windows.Forms.Panel
    Friend WithEvents tableEditor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents dtpHireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents numSalary As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDepartment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHireDate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
