<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tableLayoutMain = New System.Windows.Forms.TableLayoutPanel()
        Me.groupQuickActions = New System.Windows.Forms.GroupBox()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnManageEmployees = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.groupOverview = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeCount = New System.Windows.Forms.Label()
        Me.labelEmployee = New System.Windows.Forms.Label()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.statusLabelConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tableLayoutMain.SuspendLayout()
        Me.groupQuickActions.SuspendLayout()
        Me.groupOverview.SuspendLayout()
        Me.statusStrip.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutMain
        '
        Me.tableLayoutMain.ColumnCount = 2
        Me.tableLayoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tableLayoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tableLayoutMain.Controls.Add(Me.groupQuickActions, 0, 0)
        Me.tableLayoutMain.Controls.Add(Me.groupOverview, 1, 0)
        Me.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutMain.Location = New System.Drawing.Point(0, 72)
        Me.tableLayoutMain.Name = "tableLayoutMain"
        Me.tableLayoutMain.RowCount = 1
        Me.tableLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutMain.Size = New System.Drawing.Size(984, 447)
        Me.tableLayoutMain.TabIndex = 0
        '
        'groupQuickActions
        '
        Me.groupQuickActions.Controls.Add(Me.btnReports)
        Me.groupQuickActions.Controls.Add(Me.btnPayroll)
        Me.groupQuickActions.Controls.Add(Me.btnAttendance)
        Me.groupQuickActions.Controls.Add(Me.btnManageEmployees)
        Me.groupQuickActions.Controls.Add(Me.btnExit)
        Me.groupQuickActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupQuickActions.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.groupQuickActions.Location = New System.Drawing.Point(16, 16)
        Me.groupQuickActions.Margin = New System.Windows.Forms.Padding(16)
        Me.groupQuickActions.Name = "groupQuickActions"
        Me.groupQuickActions.Padding = New System.Windows.Forms.Padding(16)
        Me.groupQuickActions.Size = New System.Drawing.Size(408, 415)
        Me.groupQuickActions.TabIndex = 0
        Me.groupQuickActions.TabStop = False
        Me.groupQuickActions.Text = "Quick Actions"
        '
        'btnReports
        '
        Me.btnReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnReports.Location = New System.Drawing.Point(19, 233)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(370, 40)
        Me.btnReports.TabIndex = 3
        Me.btnReports.Text = "Crystal Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnReports, "Preview and export Crystal Reports")
        '
        'btnPayroll
        '
        Me.btnPayroll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayroll.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnPayroll.Location = New System.Drawing.Point(19, 177)
        Me.btnPayroll.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(370, 40)
        Me.btnPayroll.TabIndex = 2
        Me.btnPayroll.Text = "Generate Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnPayroll, "Generate and export payroll for a pay period")
        '
        'btnAttendance
        '
        Me.btnAttendance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAttendance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnAttendance.Location = New System.Drawing.Point(19, 121)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(370, 40)
        Me.btnAttendance.TabIndex = 1
        Me.btnAttendance.Text = "Record Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnAttendance, "Record employee attendance and export daily logs")
        '
        'btnManageEmployees
        '
        Me.btnManageEmployees.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageEmployees.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnManageEmployees.Location = New System.Drawing.Point(19, 65)
        Me.btnManageEmployees.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.btnManageEmployees.Name = "btnManageEmployees"
        Me.btnManageEmployees.Size = New System.Drawing.Size(370, 40)
        Me.btnManageEmployees.TabIndex = 0
        Me.btnManageEmployees.Text = "Manage Employees"
        Me.btnManageEmployees.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnManageEmployees, "Add, edit, or deactivate employees")
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnExit.Location = New System.Drawing.Point(267, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'groupOverview
        '
        Me.groupOverview.Controls.Add(Me.lblEmployeeCount)
        Me.groupOverview.Controls.Add(Me.labelEmployee)
        Me.groupOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupOverview.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.groupOverview.Location = New System.Drawing.Point(456, 16)
        Me.groupOverview.Margin = New System.Windows.Forms.Padding(16)
        Me.groupOverview.Name = "groupOverview"
        Me.groupOverview.Padding = New System.Windows.Forms.Padding(16)
        Me.groupOverview.Size = New System.Drawing.Size(512, 415)
        Me.groupOverview.TabIndex = 1
        Me.groupOverview.TabStop = False
        Me.groupOverview.Text = "Overview"
        '
        'lblEmployeeCount
        '
        Me.lblEmployeeCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployeeCount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmployeeCount.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.lblEmployeeCount.Location = New System.Drawing.Point(16, 80)
        Me.lblEmployeeCount.Name = "lblEmployeeCount"
        Me.lblEmployeeCount.Size = New System.Drawing.Size(480, 70)
        Me.lblEmployeeCount.TabIndex = 1
        Me.lblEmployeeCount.Text = "--"
        Me.lblEmployeeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelEmployee
        '
        Me.labelEmployee.AutoSize = True
        Me.labelEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.labelEmployee.Location = New System.Drawing.Point(20, 42)
        Me.labelEmployee.Name = "labelEmployee"
        Me.labelEmployee.Size = New System.Drawing.Size(209, 25)
        Me.labelEmployee.TabIndex = 0
        Me.labelEmployee.Text = "Active Employees Total"
        '
        'statusStrip
        '
        Me.statusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabelConnection})
        Me.statusStrip.Location = New System.Drawing.Point(0, 519)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.statusStrip.Size = New System.Drawing.Size(984, 22)
        Me.statusStrip.TabIndex = 2
        '
        'statusLabelConnection
        '
        Me.statusLabelConnection.Name = "statusLabelConnection"
        Me.statusLabelConnection.Size = New System.Drawing.Size(154, 17)
        Me.statusLabelConnection.Text = "Disconnected from MySQL"
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(32, 64, 105)
        Me.panelHeader.Controls.Add(Me.btnTestConnection)
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Padding = New System.Windows.Forms.Padding(16)
        Me.panelHeader.Size = New System.Drawing.Size(984, 72)
        Me.panelHeader.TabIndex = 3
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestConnection.BackColor = System.Drawing.Color.White
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTestConnection.Location = New System.Drawing.Point(807, 21)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(161, 32)
        Me.btnTestConnection.TabIndex = 1
        Me.btnTestConnection.Text = "Test Connection"
        Me.btnTestConnection.UseVisualStyleBackColor = False
        Me.toolTip.SetToolTip(Me.btnTestConnection, "Check connectivity to the MySQL database")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(19, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(477, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Hotel Human Resource Management System"

        'MainForm
        '
        Me.AcceptButton = Me.btnManageEmployees
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(984, 541)
        Me.Controls.Add(Me.tableLayoutMain)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.statusStrip)
        Me.MinimumSize = New System.Drawing.Size(1000, 580)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel HR Management System"
        Me.tableLayoutMain.ResumeLayout(False)
        Me.groupQuickActions.ResumeLayout(False)
        Me.groupOverview.ResumeLayout(False)
        Me.groupOverview.PerformLayout()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tableLayoutMain As System.Windows.Forms.TableLayoutPanel
    Private WithEvents groupQuickActions As System.Windows.Forms.GroupBox
    Private WithEvents btnReports As System.Windows.Forms.Button
    Private WithEvents btnPayroll As System.Windows.Forms.Button
    Private WithEvents btnAttendance As System.Windows.Forms.Button
    Private WithEvents btnManageEmployees As System.Windows.Forms.Button
    Private WithEvents groupOverview As System.Windows.Forms.GroupBox
    Private WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Private WithEvents panelHeader As System.Windows.Forms.Panel
    Private WithEvents btnTestConnection As System.Windows.Forms.Button
    Private WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents statusLabelConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEmployeeCount As System.Windows.Forms.Label
    Private WithEvents labelEmployee As System.Windows.Forms.Label
    Private WithEvents toolTip As System.Windows.Forms.ToolTip
    Private WithEvents btnExit As System.Windows.Forms.Button

End Class
