<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudentReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OpeningTransition = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ConStrpExport = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.strpPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.strpWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.strpExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.rv1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlReportControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.ConStrpExport.SuspendLayout()
        Me.pnlReportControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SchoolDemo.StudentReport.rdlc"
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'OpeningTransition
        '
        Me.OpeningTransition.AnimateWindow = True
        Me.OpeningTransition.BorderRadius = 15
        Me.OpeningTransition.ContainerControl = Me
        Me.OpeningTransition.DockIndicatorColor = System.Drawing.SystemColors.Window
        Me.OpeningTransition.DockIndicatorTransparencyValue = 0.6R
        Me.OpeningTransition.ResizeForm = False
        Me.OpeningTransition.TransparentWhileDrag = True
        '
        'ConStrpExport
        '
        Me.ConStrpExport.BackColor = System.Drawing.Color.PowderBlue
        Me.ConStrpExport.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConStrpExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strpPDF, Me.strpWord, Me.strpExcel})
        Me.ConStrpExport.Name = "ConStrpExport"
        Me.ConStrpExport.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConStrpExport.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.ConStrpExport.RenderStyle.ColorTable = Nothing
        Me.ConStrpExport.RenderStyle.RoundedEdges = True
        Me.ConStrpExport.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.ConStrpExport.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConStrpExport.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ConStrpExport.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.ConStrpExport.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.ConStrpExport.ShowImageMargin = False
        Me.ConStrpExport.Size = New System.Drawing.Size(139, 70)
        '
        'strpPDF
        '
        Me.strpPDF.Name = "strpPDF"
        Me.strpPDF.Size = New System.Drawing.Size(138, 22)
        Me.strpPDF.Text = "PDF File"
        Me.strpPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'strpWord
        '
        Me.strpWord.Name = "strpWord"
        Me.strpWord.Size = New System.Drawing.Size(138, 22)
        Me.strpWord.Text = "Word Document"
        '
        'strpExcel
        '
        Me.strpExcel.Name = "strpExcel"
        Me.strpExcel.Size = New System.Drawing.Size(138, 22)
        Me.strpExcel.Text = "Excel File"
        '
        'rv1
        '
        Me.rv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rv1.Location = New System.Drawing.Point(0, 35)
        Me.rv1.Name = "rv1"
        Me.rv1.ServerReport.BearerToken = Nothing
        Me.rv1.ShowToolBar = False
        Me.rv1.Size = New System.Drawing.Size(760, 535)
        Me.rv1.TabIndex = 59
        '
        'pnlReportControls
        '
        Me.pnlReportControls.Controls.Add(Me.btnRefresh)
        Me.pnlReportControls.Controls.Add(Me.btnExport)
        Me.pnlReportControls.Controls.Add(Me.btnPrint)
        Me.pnlReportControls.Controls.Add(Me.btnMinimize)
        Me.pnlReportControls.Controls.Add(Me.btnClose)
        Me.pnlReportControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReportControls.FillColor = System.Drawing.Color.PowderBlue
        Me.pnlReportControls.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlReportControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlReportControls.Name = "pnlReportControls"
        Me.pnlReportControls.Size = New System.Drawing.Size(760, 33)
        Me.pnlReportControls.TabIndex = 60
        '
        'btnRefresh
        '
        Me.btnRefresh.Animated = True
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BorderColor = System.Drawing.Color.LightGray
        Me.btnRefresh.BorderRadius = 5
        Me.btnRefresh.BorderThickness = 1
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.FillColor = System.Drawing.Color.Empty
        Me.btnRefresh.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Image = Global.SchoolDemo.My.Resources.Resources._959
        Me.btnRefresh.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnRefresh.Location = New System.Drawing.Point(110, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 33)
        Me.btnRefresh.TabIndex = 59
        Me.btnRefresh.UseTransparentBackground = True
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BorderColor = System.Drawing.Color.LightGray
        Me.btnExport.BorderRadius = 5
        Me.btnExport.BorderThickness = 1
        Me.btnExport.ContextMenuStrip = Me.ConStrpExport
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExport.FillColor = System.Drawing.Color.Empty
        Me.btnExport.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Image = Global.SchoolDemo.My.Resources.Resources._298
        Me.btnExport.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnExport.Location = New System.Drawing.Point(55, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(55, 33)
        Me.btnExport.TabIndex = 58
        Me.btnExport.UseTransparentBackground = True
        '
        'btnPrint
        '
        Me.btnPrint.Animated = True
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderColor = System.Drawing.Color.LightGray
        Me.btnPrint.BorderRadius = 5
        Me.btnPrint.BorderThickness = 1
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FillColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = Global.SchoolDemo.My.Resources.Resources._878
        Me.btnPrint.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(55, 33)
        Me.btnPrint.TabIndex = 57
        Me.btnPrint.UseTransparentBackground = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FillColor = System.Drawing.Color.Empty
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Global.SchoolDemo.My.Resources.Resources._9952
        Me.btnMinimize.ImageOffset = New System.Drawing.Point(0, 1)
        Me.btnMinimize.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnMinimize.Location = New System.Drawing.Point(674, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(43, 33)
        Me.btnMinimize.TabIndex = 60
        Me.btnMinimize.UseTransparentBackground = True
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.SchoolDemo.My.Resources.Resources._938
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(717, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 33)
        Me.btnClose.TabIndex = 56
        Me.btnClose.UseTransparentBackground = True
        '
        'FrmStudentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 570)
        Me.Controls.Add(Me.pnlReportControls)
        Me.Controls.Add(Me.rv1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStudentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStudentReport"
        Me.ConStrpExport.ResumeLayout(False)
        Me.pnlReportControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OpeningTransition As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rv1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnlReportControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ConStrpExport As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents strpPDF As ToolStripMenuItem
    Friend WithEvents strpWord As ToolStripMenuItem
    Friend WithEvents strpExcel As ToolStripMenuItem
End Class
