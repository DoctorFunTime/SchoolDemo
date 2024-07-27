<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmission
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
        Me.lblAddtionalInfoAdmissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlStudentReportsDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExportReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPrintStudentReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnViewStudentsReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentReports = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFacultyMembers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlAttendacyDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnDayRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClassRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl.SuspendLayout()
        Me.pnlStudentReportsDrop.SuspendLayout()
        Me.pnlAttendacyDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoAdmissions
        '
        Me.lblAddtionalInfoAdmissions.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoAdmissions.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoAdmissions.Location = New System.Drawing.Point(12, 466)
        Me.lblAddtionalInfoAdmissions.Name = "lblAddtionalInfoAdmissions"
        Me.lblAddtionalInfoAdmissions.Size = New System.Drawing.Size(313, 23)
        Me.lblAddtionalInfoAdmissions.TabIndex = 18
        Me.lblAddtionalInfoAdmissions.Text = "Hover over button for further information."
        Me.lblAddtionalInfoAdmissions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.Controls.Add(Me.pnlStudentReportsDrop)
        Me.flowpnl.Controls.Add(Me.btnFacultyMembers)
        Me.flowpnl.Controls.Add(Me.pnlAttendacyDrop)
        Me.flowpnl.Controls.Add(Me.btnEnrollment)
        Me.flowpnl.Location = New System.Drawing.Point(12, 20)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 343)
        Me.flowpnl.TabIndex = 19
        '
        'pnlStudentReportsDrop
        '
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnExportReports)
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnPrintStudentReports)
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnViewStudentsReports)
        Me.pnlStudentReportsDrop.Controls.Add(Me.btnStudentReports)
        Me.pnlStudentReportsDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStudentReportsDrop.Location = New System.Drawing.Point(0, 135)
        Me.pnlStudentReportsDrop.Name = "pnlStudentReportsDrop"
        Me.pnlStudentReportsDrop.Size = New System.Drawing.Size(776, 45)
        Me.pnlStudentReportsDrop.TabIndex = 20
        '
        'btnExportReports
        '
        Me.btnExportReports.Animated = True
        Me.btnExportReports.BorderColor = System.Drawing.Color.LightGray
        Me.btnExportReports.BorderRadius = 10
        Me.btnExportReports.BorderThickness = 1
        Me.btnExportReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExportReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExportReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportReports.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExportReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExportReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExportReports.FillColor = System.Drawing.Color.Empty
        Me.btnExportReports.FillColor2 = System.Drawing.Color.Empty
        Me.btnExportReports.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportReports.ForeColor = System.Drawing.Color.Black
        Me.btnExportReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExportReports.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnExportReports.Location = New System.Drawing.Point(0, 135)
        Me.btnExportReports.Name = "btnExportReports"
        Me.btnExportReports.Size = New System.Drawing.Size(776, 45)
        Me.btnExportReports.TabIndex = 20
        Me.btnExportReports.Tag = ""
        Me.btnExportReports.Text = "Export a student(s) report to a PDF file."
        Me.btnExportReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExportReports.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnPrintStudentReports
        '
        Me.btnPrintStudentReports.Animated = True
        Me.btnPrintStudentReports.BorderColor = System.Drawing.Color.LightGray
        Me.btnPrintStudentReports.BorderRadius = 10
        Me.btnPrintStudentReports.BorderThickness = 1
        Me.btnPrintStudentReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintStudentReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintStudentReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintStudentReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrintStudentReports.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrintStudentReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrintStudentReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrintStudentReports.FillColor = System.Drawing.Color.Empty
        Me.btnPrintStudentReports.FillColor2 = System.Drawing.Color.Empty
        Me.btnPrintStudentReports.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintStudentReports.ForeColor = System.Drawing.Color.Black
        Me.btnPrintStudentReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPrintStudentReports.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnPrintStudentReports.Location = New System.Drawing.Point(0, 90)
        Me.btnPrintStudentReports.Name = "btnPrintStudentReports"
        Me.btnPrintStudentReports.Size = New System.Drawing.Size(776, 45)
        Me.btnPrintStudentReports.TabIndex = 22
        Me.btnPrintStudentReports.Tag = ""
        Me.btnPrintStudentReports.Text = "Print the student's reports."
        Me.btnPrintStudentReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPrintStudentReports.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnViewStudentsReports
        '
        Me.btnViewStudentsReports.Animated = True
        Me.btnViewStudentsReports.BorderColor = System.Drawing.Color.LightGray
        Me.btnViewStudentsReports.BorderRadius = 10
        Me.btnViewStudentsReports.BorderThickness = 1
        Me.btnViewStudentsReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewStudentsReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewStudentsReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewStudentsReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewStudentsReports.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewStudentsReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewStudentsReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewStudentsReports.FillColor = System.Drawing.Color.Empty
        Me.btnViewStudentsReports.FillColor2 = System.Drawing.Color.Empty
        Me.btnViewStudentsReports.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudentsReports.ForeColor = System.Drawing.Color.Black
        Me.btnViewStudentsReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewStudentsReports.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnViewStudentsReports.Location = New System.Drawing.Point(0, 45)
        Me.btnViewStudentsReports.Name = "btnViewStudentsReports"
        Me.btnViewStudentsReports.Size = New System.Drawing.Size(776, 45)
        Me.btnViewStudentsReports.TabIndex = 21
        Me.btnViewStudentsReports.Tag = ""
        Me.btnViewStudentsReports.Text = "View student's reports."
        Me.btnViewStudentsReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewStudentsReports.TextOffset = New System.Drawing.Point(50, 0)
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
        Me.btnStudentReports.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentReports.ForeColor = System.Drawing.Color.Black
        Me.btnStudentReports.Image = Global.SchoolDemo.My.Resources.Resources._277
        Me.btnStudentReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentReports.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStudentReports.Location = New System.Drawing.Point(0, 0)
        Me.btnStudentReports.Name = "btnStudentReports"
        Me.btnStudentReports.Size = New System.Drawing.Size(776, 45)
        Me.btnStudentReports.TabIndex = 16
        Me.btnStudentReports.Tag = "View and/ print student reports."
        Me.btnStudentReports.Text = "Student Reports"
        Me.btnStudentReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnFacultyMembers
        '
        Me.btnFacultyMembers.Animated = True
        Me.btnFacultyMembers.BorderRadius = 10
        Me.btnFacultyMembers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacultyMembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultyMembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultyMembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultyMembers.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultyMembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFacultyMembers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacultyMembers.FillColor = System.Drawing.Color.PowderBlue
        Me.btnFacultyMembers.FillColor2 = System.Drawing.Color.LightGray
        Me.btnFacultyMembers.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacultyMembers.ForeColor = System.Drawing.Color.Black
        Me.btnFacultyMembers.Image = Global.SchoolDemo.My.Resources.Resources._100
        Me.btnFacultyMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFacultyMembers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFacultyMembers.Location = New System.Drawing.Point(0, 90)
        Me.btnFacultyMembers.Name = "btnFacultyMembers"
        Me.btnFacultyMembers.Size = New System.Drawing.Size(776, 45)
        Me.btnFacultyMembers.TabIndex = 17
        Me.btnFacultyMembers.Tag = "New faculty members."
        Me.btnFacultyMembers.Text = "Faculty Members"
        Me.btnFacultyMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlAttendacyDrop
        '
        Me.pnlAttendacyDrop.Controls.Add(Me.btnDayRegister)
        Me.pnlAttendacyDrop.Controls.Add(Me.btnClassRegister)
        Me.pnlAttendacyDrop.Controls.Add(Me.btnAttendance)
        Me.pnlAttendacyDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAttendacyDrop.Location = New System.Drawing.Point(0, 45)
        Me.pnlAttendacyDrop.Name = "pnlAttendacyDrop"
        Me.pnlAttendacyDrop.Size = New System.Drawing.Size(776, 45)
        Me.pnlAttendacyDrop.TabIndex = 19
        '
        'btnDayRegister
        '
        Me.btnDayRegister.Animated = True
        Me.btnDayRegister.BorderColor = System.Drawing.Color.LightGray
        Me.btnDayRegister.BorderRadius = 10
        Me.btnDayRegister.BorderThickness = 1
        Me.btnDayRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDayRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDayRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDayRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDayRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDayRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDayRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDayRegister.FillColor = System.Drawing.Color.Empty
        Me.btnDayRegister.FillColor2 = System.Drawing.Color.Empty
        Me.btnDayRegister.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDayRegister.ForeColor = System.Drawing.Color.Black
        Me.btnDayRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDayRegister.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnDayRegister.Location = New System.Drawing.Point(0, 90)
        Me.btnDayRegister.Name = "btnDayRegister"
        Me.btnDayRegister.Size = New System.Drawing.Size(776, 45)
        Me.btnDayRegister.TabIndex = 19
        Me.btnDayRegister.Tag = ""
        Me.btnDayRegister.Text = "Complete the day's attendancy register."
        Me.btnDayRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDayRegister.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnClassRegister
        '
        Me.btnClassRegister.Animated = True
        Me.btnClassRegister.BorderColor = System.Drawing.Color.LightGray
        Me.btnClassRegister.BorderRadius = 10
        Me.btnClassRegister.BorderThickness = 1
        Me.btnClassRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClassRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClassRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClassRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClassRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClassRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClassRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClassRegister.FillColor = System.Drawing.Color.Empty
        Me.btnClassRegister.FillColor2 = System.Drawing.Color.Empty
        Me.btnClassRegister.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassRegister.ForeColor = System.Drawing.Color.Black
        Me.btnClassRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClassRegister.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnClassRegister.Location = New System.Drawing.Point(0, 45)
        Me.btnClassRegister.Name = "btnClassRegister"
        Me.btnClassRegister.Size = New System.Drawing.Size(776, 45)
        Me.btnClassRegister.TabIndex = 18
        Me.btnClassRegister.Tag = ""
        Me.btnClassRegister.Text = "View a class register based on a filter."
        Me.btnClassRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClassRegister.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnAttendance
        '
        Me.btnAttendance.Animated = True
        Me.btnAttendance.BorderRadius = 10
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendance.FillColor = System.Drawing.Color.PowderBlue
        Me.btnAttendance.FillColor2 = System.Drawing.Color.LightGray
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.Image = Global.SchoolDemo.My.Resources.Resources._573
        Me.btnAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnAttendance.Location = New System.Drawing.Point(0, 0)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(776, 45)
        Me.btnAttendance.TabIndex = 13
        Me.btnAttendance.Tag = "Mark the day's register , View class registers."
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'btnEnrollment
        '
        Me.btnEnrollment.Animated = True
        Me.btnEnrollment.BorderRadius = 10
        Me.btnEnrollment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrollment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnrollment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnrollment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollment.FillColor = System.Drawing.Color.PowderBlue
        Me.btnEnrollment.FillColor2 = System.Drawing.Color.LightGray
        Me.btnEnrollment.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollment.ForeColor = System.Drawing.Color.Black
        Me.btnEnrollment.Image = Global.SchoolDemo.My.Resources.Resources._742
        Me.btnEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEnrollment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEnrollment.Location = New System.Drawing.Point(0, 0)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(776, 45)
        Me.btnEnrollment.TabIndex = 12
        Me.btnEnrollment.Tag = "Enroll new students into the school."
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.flowpnl)
        Me.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.flowpnl.ResumeLayout(False)
        Me.pnlStudentReportsDrop.ResumeLayout(False)
        Me.pnlAttendacyDrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFacultyMembers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnClassRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlAttendacyDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnDayRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlStudentReportsDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnPrintStudentReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnViewStudentsReports As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnExportReports As Guna.UI2.WinForms.Guna2GradientButton
End Class
