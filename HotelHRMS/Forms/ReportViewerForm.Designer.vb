<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewerForm
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnExportPdf = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.labelTo = New System.Windows.Forms.Label()
        Me.dtpRangeEnd = New System.Windows.Forms.DateTimePicker()
        Me.labelFrom = New System.Windows.Forms.Label()
        Me.dtpRangeStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.labelReport = New System.Windows.Forms.Label()
        Me.panelHint = New System.Windows.Forms.Panel()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.crystalViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelTop.SuspendLayout()
        Me.panelHint.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.Controls.Add(Me.btnExportPdf)
        Me.panelTop.Controls.Add(Me.btnPreview)
        Me.panelTop.Controls.Add(Me.labelTo)
        Me.panelTop.Controls.Add(Me.dtpRangeEnd)
        Me.panelTop.Controls.Add(Me.labelFrom)
        Me.panelTop.Controls.Add(Me.dtpRangeStart)
        Me.panelTop.Controls.Add(Me.cmbReportType)
        Me.panelTop.Controls.Add(Me.labelReport)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Padding = New System.Windows.Forms.Padding(12)
        Me.panelTop.Size = New System.Drawing.Size(1100, 90)
        Me.panelTop.TabIndex = 0
        '
        'btnExportPdf
        '
        Me.btnExportPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportPdf.Location = New System.Drawing.Point(978, 32)
        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Size = New System.Drawing.Size(102, 32)
        Me.btnExportPdf.TabIndex = 6
        Me.btnExportPdf.Text = "Export PDF"
        Me.btnExportPdf.UseVisualStyleBackColor = True
        Me.toolTip.SetToolTip(Me.btnExportPdf, "Export the current report to PDF")
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(870, 32)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(102, 32)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'labelTo
        '
        Me.labelTo.AutoSize = True
        Me.labelTo.Location = New System.Drawing.Point(568, 40)
        Me.labelTo.Name = "labelTo"
        Me.labelTo.Size = New System.Drawing.Size(19, 15)
        Me.labelTo.TabIndex = 4
        Me.labelTo.Text = "To"
        '
        'dtpRangeEnd
        '
        Me.dtpRangeEnd.Location = New System.Drawing.Point(593, 36)
        Me.dtpRangeEnd.Name = "dtpRangeEnd"
        Me.dtpRangeEnd.Size = New System.Drawing.Size(130, 23)
        Me.dtpRangeEnd.TabIndex = 3
        '
        'labelFrom
        '
        Me.labelFrom.AutoSize = True
        Me.labelFrom.Location = New System.Drawing.Point(403, 40)
        Me.labelFrom.Name = "labelFrom"
        Me.labelFrom.Size = New System.Drawing.Size(33, 15)
        Me.labelFrom.TabIndex = 2
        Me.labelFrom.Text = "From"
        '
        'dtpRangeStart
        '
        Me.dtpRangeStart.Location = New System.Drawing.Point(442, 36)
        Me.dtpRangeStart.Name = "dtpRangeStart"
        Me.dtpRangeStart.Size = New System.Drawing.Size(120, 23)
        Me.dtpRangeStart.TabIndex = 1
        '
        'cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Location = New System.Drawing.Point(105, 36)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(280, 23)
        Me.cmbReportType.TabIndex = 0
        '
        'labelReport
        '
        Me.labelReport.AutoSize = True
        Me.labelReport.Location = New System.Drawing.Point(16, 40)
        Me.labelReport.Name = "labelReport"
        Me.labelReport.Size = New System.Drawing.Size(78, 15)
        Me.labelReport.TabIndex = 0
        Me.labelReport.Text = "Report Type"
        '
        'panelHint
        '
        Me.panelHint.Controls.Add(Me.lblHint)
        Me.panelHint.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHint.Location = New System.Drawing.Point(0, 90)
        Me.panelHint.Name = "panelHint"
        Me.panelHint.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.panelHint.Size = New System.Drawing.Size(1100, 40)
        Me.panelHint.TabIndex = 1
        '
        'lblHint
        '
        Me.lblHint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHint.ForeColor = System.Drawing.Color.DimGray
        Me.lblHint.Location = New System.Drawing.Point(12, 0)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(1076, 40)
        Me.lblHint.TabIndex = 0
        Me.lblHint.Text = "Crystal Reports templates (.rpt) are expected in the Reports folder. Use the same field names exposed by the generated datasets."
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'crystalViewer
        '
        Me.crystalViewer.ActiveViewIndex = -1
        Me.crystalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crystalViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crystalViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crystalViewer.Location = New System.Drawing.Point(0, 130)
        Me.crystalViewer.Name = "crystalViewer"
        Me.crystalViewer.ShowLogo = False
        Me.crystalViewer.Size = New System.Drawing.Size(1100, 590)
        Me.crystalViewer.TabIndex = 2

        'ReportViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 720)
        Me.Controls.Add(Me.crystalViewer)
        Me.Controls.Add(Me.panelHint)
        Me.Controls.Add(Me.panelTop)
        Me.MinimumSize = New System.Drawing.Size(1120, 760)
        Me.Name = "ReportViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crystal Reports"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelHint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents btnExportPdf As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents labelTo As System.Windows.Forms.Label
    Friend WithEvents dtpRangeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFrom As System.Windows.Forms.Label
    Friend WithEvents dtpRangeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents labelReport As System.Windows.Forms.Label
    Friend WithEvents panelHint As System.Windows.Forms.Panel
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents crystalViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip

End Class
