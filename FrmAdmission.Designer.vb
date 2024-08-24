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
        Me.btnFacultyMembers = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl.SuspendLayout()
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
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.BorderColor = System.Drawing.Color.Gray
        Me.flowpnl.Controls.Add(Me.btnFacultyMembers)
        Me.flowpnl.Controls.Add(Me.btnEnrollment)
        Me.flowpnl.Controls.Add(Me.btnAttendance)
        Me.flowpnl.Location = New System.Drawing.Point(12, 20)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 400)
        Me.flowpnl.TabIndex = 19
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
        Me.btnFacultyMembers.Tag = "Add a new faculty member."
        Me.btnFacultyMembers.Text = "Faculty Member"
        Me.btnFacultyMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnEnrollment.Location = New System.Drawing.Point(0, 45)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(776, 45)
        Me.btnEnrollment.TabIndex = 12
        Me.btnEnrollment.Tag = "Enroll a new student."
        Me.btnEnrollment.Text = "Enrollment"
        Me.btnEnrollment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnAttendance.Tag = "Mark the day's attendancy register."
        Me.btnAttendance.Text = "Register"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'FrmAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.flowpnl)
        Me.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.flowpnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFacultyMembers As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
End Class
