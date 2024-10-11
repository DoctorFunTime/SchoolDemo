<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReports))
        Me.lblAddtionalInfoReports = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFlowMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlStudentReportsDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnStudentDetailsReport = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentGradeReport = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlKPIsDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnKPIPassRates = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentPasses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnKPIExamGrowth = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnKPIClassPassRate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnKPI = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlDropTopPerformers = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnHighAchievers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAttendacy = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFlowMain.SuspendLayout()
        Me.pnlStudentReportsDrop.SuspendLayout()
        Me.pnlKPIsDrop.SuspendLayout()
        Me.pnlDropTopPerformers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoReports
        '
        Me.lblAddtionalInfoReports.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoReports.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblAddtionalInfoReports.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoReports.Name = "lblAddtionalInfoReports"
        Me.lblAddtionalInfoReports.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoReports.TabIndex = 27
        Me.lblAddtionalInfoReports.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoReports.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFlowMain
        '
        Me.pnlFlowMain.AutoScroll = True
        Me.pnlFlowMain.Controls.Add(Me.pnlStudentReportsDrop)
        Me.pnlFlowMain.Controls.Add(Me.pnlKPIsDrop)
        Me.pnlFlowMain.Controls.Add(Me.pnlDropTopPerformers)
        Me.pnlFlowMain.Controls.Add(Me.btnAttendacy)
        Me.pnlFlowMain.Controls.Add(Me.btnFaculty)
        Me.pnlFlowMain.Location = New System.Drawing.Point(12, 20)
        Me.pnlFlowMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlowMain.Name = "pnlFlowMain"
        Me.pnlFlowMain.Size = New System.Drawing.Size(776, 400)
        Me.pnlFlowMain.TabIndex = 37
        '
        'pnlStudentReportsDrop
        '
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnStudentDetailsReport)
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnStudentGradeReport)
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnStudentReports)
        Me.pnlStudentReportsDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStudentReportsDrop.Location = New System.Drawing.Point(3, 3)
        Me.pnlStudentReportsDrop.Name = "pnlStudentReportsDrop"
        Me.pnlStudentReportsDrop.Size = New System.Drawing.Size(753, 45)
        Me.pnlStudentReportsDrop.TabIndex = 43
        '
        'btnStudentDetailsReport
        '
        Me.btnStudentDetailsReport.Animated = True
        Me.btnStudentDetailsReport.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentDetailsReport.BorderRadius = 10
        Me.btnStudentDetailsReport.BorderThickness = 1
        Me.btnStudentDetailsReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentDetailsReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetailsReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetailsReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetailsReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetailsReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentDetailsReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentDetailsReport.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentDetailsReport.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentDetailsReport.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentDetailsReport.ForeColor = System.Drawing.Color.White
        Me.btnStudentDetailsReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentDetailsReport.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentDetailsReport.Location = New System.Drawing.Point(0, 90)
        Me.btnStudentDetailsReport.Name = "btnStudentDetailsReport"
        Me.btnStudentDetailsReport.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentDetailsReport.TabIndex = 27
        Me.btnStudentDetailsReport.Tag = ""
        Me.btnStudentDetailsReport.Text = "Student personal details report."
        Me.btnStudentDetailsReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentDetailsReport.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentGradeReport
        '
        Me.btnStudentGradeReport.Animated = True
        Me.btnStudentGradeReport.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentGradeReport.BorderRadius = 10
        Me.btnStudentGradeReport.BorderThickness = 1
        Me.btnStudentGradeReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentGradeReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentGradeReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentGradeReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentGradeReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentGradeReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentGradeReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentGradeReport.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentGradeReport.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentGradeReport.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentGradeReport.ForeColor = System.Drawing.Color.White
        Me.btnStudentGradeReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentGradeReport.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentGradeReport.Location = New System.Drawing.Point(0, 45)
        Me.btnStudentGradeReport.Name = "btnStudentGradeReport"
        Me.btnStudentGradeReport.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentGradeReport.TabIndex = 26
        Me.btnStudentGradeReport.Tag = ""
        Me.btnStudentGradeReport.Text = "Student grades report."
        Me.btnStudentGradeReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentGradeReport.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentReports
        '
        Me.btnStudentReports.Animated = True
        Me.btnStudentReports.BorderRadius = 10
        Me.btnStudentReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentReports.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentReports.FillColor = System.Drawing.Color.PowderBlue
        Me.btnStudentReports.FillColor2 = System.Drawing.Color.LightGray
        Me.btnStudentReports.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudentReports.ForeColor = System.Drawing.Color.Black
        Me.btnStudentReports.Image = Global.SchoolDemo.My.Resources.Resources._277
        Me.btnStudentReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentReports.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStudentReports.Location = New System.Drawing.Point(0, 0)
        Me.btnStudentReports.Name = "btnStudentReports"
        Me.btnStudentReports.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentReports.TabIndex = 25
        Me.btnStudentReports.Tag = "View a student's reports."
        Me.btnStudentReports.Text = "Student Reports"
        Me.btnStudentReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlKPIsDrop
        '
        Me.pnlKPIsDrop.BackColor = System.Drawing.Color.Transparent
        Me.pnlKPIsDrop.Controls.Add(Me.btnKPIPassRates)
        Me.pnlKPIsDrop.Controls.Add(Me.btnStudentPasses)
        Me.pnlKPIsDrop.Controls.Add(Me.btnKPIExamGrowth)
        Me.pnlKPIsDrop.Controls.Add(Me.btnKPIClassPassRate)
        Me.pnlKPIsDrop.Controls.Add(Me.btnKPI)
        Me.pnlKPIsDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKPIsDrop.Location = New System.Drawing.Point(3, 54)
        Me.pnlKPIsDrop.Name = "pnlKPIsDrop"
        Me.pnlKPIsDrop.Size = New System.Drawing.Size(753, 45)
        Me.pnlKPIsDrop.TabIndex = 42
        Me.pnlKPIsDrop.UseTransparentBackground = True
        '
        'btnKPIPassRates
        '
        Me.btnKPIPassRates.Animated = True
        Me.btnKPIPassRates.BorderColor = System.Drawing.Color.Empty
        Me.btnKPIPassRates.BorderRadius = 10
        Me.btnKPIPassRates.BorderThickness = 1
        Me.btnKPIPassRates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKPIPassRates.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIPassRates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIPassRates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIPassRates.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIPassRates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKPIPassRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKPIPassRates.FillColor = System.Drawing.Color.SlateBlue
        Me.btnKPIPassRates.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnKPIPassRates.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnKPIPassRates.ForeColor = System.Drawing.Color.White
        Me.btnKPIPassRates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIPassRates.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnKPIPassRates.Location = New System.Drawing.Point(0, 180)
        Me.btnKPIPassRates.Name = "btnKPIPassRates"
        Me.btnKPIPassRates.Size = New System.Drawing.Size(753, 45)
        Me.btnKPIPassRates.TabIndex = 24
        Me.btnKPIPassRates.Tag = ""
        Me.btnKPIPassRates.Text = "Subject pass rates."
        Me.btnKPIPassRates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIPassRates.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentPasses
        '
        Me.btnStudentPasses.Animated = True
        Me.btnStudentPasses.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentPasses.BorderRadius = 10
        Me.btnStudentPasses.BorderThickness = 1
        Me.btnStudentPasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentPasses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentPasses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentPasses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentPasses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentPasses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentPasses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentPasses.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentPasses.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentPasses.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentPasses.ForeColor = System.Drawing.Color.White
        Me.btnStudentPasses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentPasses.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentPasses.Location = New System.Drawing.Point(0, 135)
        Me.btnStudentPasses.Name = "btnStudentPasses"
        Me.btnStudentPasses.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentPasses.TabIndex = 26
        Me.btnStudentPasses.Tag = ""
        Me.btnStudentPasses.Text = "Student passes."
        Me.btnStudentPasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentPasses.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnKPIExamGrowth
        '
        Me.btnKPIExamGrowth.Animated = True
        Me.btnKPIExamGrowth.BorderColor = System.Drawing.Color.Empty
        Me.btnKPIExamGrowth.BorderRadius = 10
        Me.btnKPIExamGrowth.BorderThickness = 1
        Me.btnKPIExamGrowth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKPIExamGrowth.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIExamGrowth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIExamGrowth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIExamGrowth.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIExamGrowth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKPIExamGrowth.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKPIExamGrowth.FillColor = System.Drawing.Color.SlateBlue
        Me.btnKPIExamGrowth.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnKPIExamGrowth.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnKPIExamGrowth.ForeColor = System.Drawing.Color.White
        Me.btnKPIExamGrowth.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIExamGrowth.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnKPIExamGrowth.Location = New System.Drawing.Point(0, 90)
        Me.btnKPIExamGrowth.Name = "btnKPIExamGrowth"
        Me.btnKPIExamGrowth.Size = New System.Drawing.Size(753, 45)
        Me.btnKPIExamGrowth.TabIndex = 23
        Me.btnKPIExamGrowth.Tag = ""
        Me.btnKPIExamGrowth.Text = "Student growth statistics."
        Me.btnKPIExamGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIExamGrowth.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnKPIClassPassRate
        '
        Me.btnKPIClassPassRate.Animated = True
        Me.btnKPIClassPassRate.BorderColor = System.Drawing.Color.Empty
        Me.btnKPIClassPassRate.BorderRadius = 10
        Me.btnKPIClassPassRate.BorderThickness = 1
        Me.btnKPIClassPassRate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKPIClassPassRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIClassPassRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKPIClassPassRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIClassPassRate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPIClassPassRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKPIClassPassRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKPIClassPassRate.FillColor = System.Drawing.Color.SlateBlue
        Me.btnKPIClassPassRate.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnKPIClassPassRate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnKPIClassPassRate.ForeColor = System.Drawing.Color.White
        Me.btnKPIClassPassRate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIClassPassRate.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnKPIClassPassRate.Location = New System.Drawing.Point(0, 45)
        Me.btnKPIClassPassRate.Name = "btnKPIClassPassRate"
        Me.btnKPIClassPassRate.Size = New System.Drawing.Size(753, 45)
        Me.btnKPIClassPassRate.TabIndex = 25
        Me.btnKPIClassPassRate.Tag = ""
        Me.btnKPIClassPassRate.Text = "Detailed pass rates."
        Me.btnKPIClassPassRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPIClassPassRate.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnKPI
        '
        Me.btnKPI.Animated = True
        Me.btnKPI.BorderRadius = 10
        Me.btnKPI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKPI.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnKPI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnKPI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPI.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnKPI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnKPI.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKPI.FillColor = System.Drawing.Color.PowderBlue
        Me.btnKPI.FillColor2 = System.Drawing.Color.LightGray
        Me.btnKPI.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKPI.ForeColor = System.Drawing.Color.Black
        Me.btnKPI.Image = Global.SchoolDemo.My.Resources.Resources._108
        Me.btnKPI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnKPI.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnKPI.Location = New System.Drawing.Point(0, 0)
        Me.btnKPI.Name = "btnKPI"
        Me.btnKPI.Size = New System.Drawing.Size(753, 45)
        Me.btnKPI.TabIndex = 24
        Me.btnKPI.Tag = "Analyze student performances based on various factors."
        Me.btnKPI.Text = "Student's Key Performance Indicators"
        Me.btnKPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlDropTopPerformers
        '
        Me.pnlDropTopPerformers.BackColor = System.Drawing.Color.Transparent
        Me.pnlDropTopPerformers.Controls.Add(Me.btnHighAchievers)
        Me.pnlDropTopPerformers.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDropTopPerformers.Location = New System.Drawing.Point(3, 105)
        Me.pnlDropTopPerformers.Name = "pnlDropTopPerformers"
        Me.pnlDropTopPerformers.Size = New System.Drawing.Size(753, 45)
        Me.pnlDropTopPerformers.TabIndex = 45
        Me.pnlDropTopPerformers.UseTransparentBackground = True
        '
        'btnHighAchievers
        '
        Me.btnHighAchievers.Animated = True
        Me.btnHighAchievers.BorderRadius = 10
        Me.btnHighAchievers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHighAchievers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHighAchievers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHighAchievers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHighAchievers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHighAchievers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHighAchievers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHighAchievers.FillColor = System.Drawing.Color.PowderBlue
        Me.btnHighAchievers.FillColor2 = System.Drawing.Color.LightGray
        Me.btnHighAchievers.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHighAchievers.ForeColor = System.Drawing.Color.Black
        Me.btnHighAchievers.Image = Global.SchoolDemo.My.Resources.Resources._264
        Me.btnHighAchievers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHighAchievers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnHighAchievers.Location = New System.Drawing.Point(0, 0)
        Me.btnHighAchievers.Name = "btnHighAchievers"
        Me.btnHighAchievers.Size = New System.Drawing.Size(753, 45)
        Me.btnHighAchievers.TabIndex = 36
        Me.btnHighAchievers.Tag = "Top performing students."
        Me.btnHighAchievers.Text = "Top Performers"
        Me.btnHighAchievers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAttendacy
        '
        Me.btnAttendacy.Animated = True
        Me.btnAttendacy.BorderRadius = 10
        Me.btnAttendacy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendacy.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendacy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendacy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendacy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendacy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendacy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendacy.FillColor = System.Drawing.Color.PowderBlue
        Me.btnAttendacy.FillColor2 = System.Drawing.Color.LightGray
        Me.btnAttendacy.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAttendacy.ForeColor = System.Drawing.Color.Black
        Me.btnAttendacy.Image = Global.SchoolDemo.My.Resources.Resources._573
        Me.btnAttendacy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendacy.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnAttendacy.Location = New System.Drawing.Point(3, 156)
        Me.btnAttendacy.Name = "btnAttendacy"
        Me.btnAttendacy.Size = New System.Drawing.Size(753, 45)
        Me.btnAttendacy.TabIndex = 41
        Me.btnAttendacy.Tag = "Track a student's attendace records."
        Me.btnAttendacy.Text = "Attendance"
        Me.btnAttendacy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendacy.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'btnFaculty
        '
        Me.btnFaculty.Animated = True
        Me.btnFaculty.BorderRadius = 10
        Me.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFaculty.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFaculty.FillColor = System.Drawing.Color.PowderBlue
        Me.btnFaculty.FillColor2 = System.Drawing.Color.LightGray
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFaculty.ForeColor = System.Drawing.Color.Black
        Me.btnFaculty.Image = Global.SchoolDemo.My.Resources.Resources._100
        Me.btnFaculty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFaculty.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFaculty.Location = New System.Drawing.Point(3, 207)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(753, 45)
        Me.btnFaculty.TabIndex = 44
        Me.btnFaculty.Tag = "View faculty reports."
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.pnlFlowMain)
        Me.Controls.Add(Me.lblAddtionalInfoReports)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReports"
        Me.Text = "Reports"
        Me.pnlFlowMain.ResumeLayout(False)
        Me.pnlStudentReportsDrop.ResumeLayout(False)
        Me.pnlKPIsDrop.ResumeLayout(False)
        Me.pnlDropTopPerformers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddtionalInfoReports As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFlowMain As FlowLayoutPanel
    Friend WithEvents pnlStudentReportsDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnStudentDetailsReport As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentGradeReport As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlKPIsDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnKPIClassPassRate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnKPIPassRates As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnKPIExamGrowth As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnKPI As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlDropTopPerformers As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnHighAchievers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAttendacy As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentPasses As Guna.UI2.WinForms.Guna2GradientButton
End Class
