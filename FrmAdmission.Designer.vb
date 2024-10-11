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
        Me.pnlFlowMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClasses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFacultyMembers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEvents = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSchoolDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentRemarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFlowMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoAdmissions
        '
        Me.lblAddtionalInfoAdmissions.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoAdmissions.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoAdmissions.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoAdmissions.Name = "lblAddtionalInfoAdmissions"
        Me.lblAddtionalInfoAdmissions.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoAdmissions.TabIndex = 18
        Me.lblAddtionalInfoAdmissions.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoAdmissions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFlowMain
        '
        Me.pnlFlowMain.AutoScroll = True
        Me.pnlFlowMain.Controls.Add(Me.btnAttendance)
        Me.pnlFlowMain.Controls.Add(Me.btnClasses)
        Me.pnlFlowMain.Controls.Add(Me.btnEnrollment)
        Me.pnlFlowMain.Controls.Add(Me.btnFacultyMembers)
        Me.pnlFlowMain.Controls.Add(Me.btnEvents)
        Me.pnlFlowMain.Controls.Add(Me.btnSchoolDetails)
        Me.pnlFlowMain.Controls.Add(Me.btnStudentRemarks)
        Me.pnlFlowMain.Location = New System.Drawing.Point(12, 20)
        Me.pnlFlowMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlowMain.Name = "pnlFlowMain"
        Me.pnlFlowMain.Size = New System.Drawing.Size(776, 400)
        Me.pnlFlowMain.TabIndex = 19
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
        Me.btnAttendance.Location = New System.Drawing.Point(3, 3)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(753, 45)
        Me.btnAttendance.TabIndex = 20
        Me.btnAttendance.Tag = "Mark the day's attendancy register."
        Me.btnAttendance.Text = "Mark Register"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'btnClasses
        '
        Me.btnClasses.Animated = True
        Me.btnClasses.BorderRadius = 10
        Me.btnClasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClasses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClasses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClasses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClasses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClasses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClasses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClasses.FillColor = System.Drawing.Color.PowderBlue
        Me.btnClasses.FillColor2 = System.Drawing.Color.LightGray
        Me.btnClasses.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClasses.ForeColor = System.Drawing.Color.Black
        Me.btnClasses.Image = Global.SchoolDemo.My.Resources.Resources._472
        Me.btnClasses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClasses.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnClasses.Location = New System.Drawing.Point(3, 54)
        Me.btnClasses.Name = "btnClasses"
        Me.btnClasses.Size = New System.Drawing.Size(753, 45)
        Me.btnClasses.TabIndex = 23
        Me.btnClasses.Tag = "View a selected class's register."
        Me.btnClasses.Text = "Class"
        Me.btnClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnEnrollment.Location = New System.Drawing.Point(3, 105)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(753, 45)
        Me.btnEnrollment.TabIndex = 19
        Me.btnEnrollment.Tag = "Enroll a new student."
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnFacultyMembers.Location = New System.Drawing.Point(3, 156)
        Me.btnFacultyMembers.Name = "btnFacultyMembers"
        Me.btnFacultyMembers.Size = New System.Drawing.Size(753, 45)
        Me.btnFacultyMembers.TabIndex = 21
        Me.btnFacultyMembers.Tag = "Add a new faculty member."
        Me.btnFacultyMembers.Text = "Faculty Member"
        Me.btnFacultyMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnEvents
        '
        Me.btnEvents.Animated = True
        Me.btnEvents.BorderRadius = 10
        Me.btnEvents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEvents.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEvents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEvents.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEvents.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEvents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEvents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEvents.FillColor = System.Drawing.Color.PowderBlue
        Me.btnEvents.FillColor2 = System.Drawing.Color.LightGray
        Me.btnEvents.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvents.ForeColor = System.Drawing.Color.Black
        Me.btnEvents.Image = Global.SchoolDemo.My.Resources.Resources._89
        Me.btnEvents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEvents.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEvents.Location = New System.Drawing.Point(3, 207)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(753, 45)
        Me.btnEvents.TabIndex = 22
        Me.btnEvents.Tag = "Plan and budget for future events."
        Me.btnEvents.Text = "Events"
        Me.btnEvents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSchoolDetails
        '
        Me.btnSchoolDetails.Animated = True
        Me.btnSchoolDetails.BorderRadius = 10
        Me.btnSchoolDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchoolDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchoolDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchoolDetails.FillColor = System.Drawing.Color.PowderBlue
        Me.btnSchoolDetails.FillColor2 = System.Drawing.Color.LightGray
        Me.btnSchoolDetails.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchoolDetails.ForeColor = System.Drawing.Color.Black
        Me.btnSchoolDetails.Image = Global.SchoolDemo.My.Resources.Resources._613
        Me.btnSchoolDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolDetails.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSchoolDetails.Location = New System.Drawing.Point(3, 258)
        Me.btnSchoolDetails.Name = "btnSchoolDetails"
        Me.btnSchoolDetails.Size = New System.Drawing.Size(753, 45)
        Me.btnSchoolDetails.TabIndex = 24
        Me.btnSchoolDetails.Tag = "Adjust the school details used by the system."
        Me.btnSchoolDetails.Text = "School Details"
        Me.btnSchoolDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnStudentRemarks
        '
        Me.btnStudentRemarks.Animated = True
        Me.btnStudentRemarks.BorderRadius = 10
        Me.btnStudentRemarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentRemarks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentRemarks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentRemarks.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentRemarks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentRemarks.FillColor = System.Drawing.Color.PowderBlue
        Me.btnStudentRemarks.FillColor2 = System.Drawing.Color.LightGray
        Me.btnStudentRemarks.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentRemarks.ForeColor = System.Drawing.Color.Black
        Me.btnStudentRemarks.Image = Global.SchoolDemo.My.Resources.Resources._269
        Me.btnStudentRemarks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentRemarks.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStudentRemarks.Location = New System.Drawing.Point(3, 309)
        Me.btnStudentRemarks.Name = "btnStudentRemarks"
        Me.btnStudentRemarks.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentRemarks.TabIndex = 25
        Me.btnStudentRemarks.Tag = "Enter students remarks for their reports."
        Me.btnStudentRemarks.Text = "Student Remarks"
        Me.btnStudentRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.pnlFlowMain)
        Me.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.pnlFlowMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFlowMain As FlowLayoutPanel
    Friend WithEvents btnEvents As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFacultyMembers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClasses As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSchoolDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentRemarks As Guna.UI2.WinForms.Guna2GradientButton
End Class
