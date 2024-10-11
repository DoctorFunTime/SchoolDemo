<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControlPanel))
        Me.lblAddtionalInfoAdmissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFlowMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlUserAccountsDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnUserActivity = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRemoveUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUserAccounts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlDropStudentDetails = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnStudentMedicalDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuardianDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentSubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentPersonalDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRemoveStudent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudentDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlDropFaculty = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnFacultyPersonalDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFacultySubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRemoveFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAttendancy = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClassFees = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnMiscellanousCosts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRates = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnTerm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnConfiguration = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFlowMain.SuspendLayout()
        Me.pnlUserAccountsDrop.SuspendLayout()
        Me.pnlDropStudentDetails.SuspendLayout()
        Me.pnlDropFaculty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoAdmissions
        '
        Me.lblAddtionalInfoAdmissions.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoAdmissions.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoAdmissions.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoAdmissions.Name = "lblAddtionalInfoAdmissions"
        Me.lblAddtionalInfoAdmissions.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoAdmissions.TabIndex = 20
        Me.lblAddtionalInfoAdmissions.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoAdmissions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFlowMain
        '
        Me.pnlFlowMain.AutoScroll = True
        Me.pnlFlowMain.Controls.Add(Me.pnlUserAccountsDrop)
        Me.pnlFlowMain.Controls.Add(Me.pnlDropStudentDetails)
        Me.pnlFlowMain.Controls.Add(Me.pnlDropFaculty)
        Me.pnlFlowMain.Controls.Add(Me.btnAttendancy)
        Me.pnlFlowMain.Controls.Add(Me.btnClassFees)
        Me.pnlFlowMain.Controls.Add(Me.btnMiscellanousCosts)
        Me.pnlFlowMain.Controls.Add(Me.btnRates)
        Me.pnlFlowMain.Controls.Add(Me.btnTerm)
        Me.pnlFlowMain.Controls.Add(Me.btnConfiguration)
        Me.pnlFlowMain.Location = New System.Drawing.Point(12, 20)
        Me.pnlFlowMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlowMain.Name = "pnlFlowMain"
        Me.pnlFlowMain.Size = New System.Drawing.Size(776, 400)
        Me.pnlFlowMain.TabIndex = 22
        '
        'pnlUserAccountsDrop
        '
        Me.pnlUserAccountsDrop.BackColor = System.Drawing.Color.Transparent
        Me.pnlUserAccountsDrop.Controls.Add(Me.btnUserActivity)
        Me.pnlUserAccountsDrop.Controls.Add(Me.btnRemoveUser)
        Me.pnlUserAccountsDrop.Controls.Add(Me.btnUserAccounts)
        Me.pnlUserAccountsDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUserAccountsDrop.Location = New System.Drawing.Point(3, 3)
        Me.pnlUserAccountsDrop.Name = "pnlUserAccountsDrop"
        Me.pnlUserAccountsDrop.Size = New System.Drawing.Size(753, 43)
        Me.pnlUserAccountsDrop.TabIndex = 33
        '
        'btnUserActivity
        '
        Me.btnUserActivity.Animated = True
        Me.btnUserActivity.BorderColor = System.Drawing.Color.Empty
        Me.btnUserActivity.BorderRadius = 10
        Me.btnUserActivity.BorderThickness = 1
        Me.btnUserActivity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserActivity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUserActivity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUserActivity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUserActivity.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUserActivity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUserActivity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserActivity.FillColor = System.Drawing.Color.SlateBlue
        Me.btnUserActivity.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnUserActivity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnUserActivity.ForeColor = System.Drawing.Color.White
        Me.btnUserActivity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUserActivity.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUserActivity.Location = New System.Drawing.Point(0, 88)
        Me.btnUserActivity.Name = "btnUserActivity"
        Me.btnUserActivity.Size = New System.Drawing.Size(753, 45)
        Me.btnUserActivity.TabIndex = 34
        Me.btnUserActivity.Tag = ""
        Me.btnUserActivity.Text = "User activity logs."
        Me.btnUserActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUserActivity.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.Animated = True
        Me.btnRemoveUser.BorderColor = System.Drawing.Color.Empty
        Me.btnRemoveUser.BorderRadius = 10
        Me.btnRemoveUser.BorderThickness = 1
        Me.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemoveUser.FillColor = System.Drawing.Color.SlateBlue
        Me.btnRemoveUser.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnRemoveUser.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnRemoveUser.ForeColor = System.Drawing.Color.White
        Me.btnRemoveUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveUser.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnRemoveUser.Location = New System.Drawing.Point(0, 43)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Size = New System.Drawing.Size(753, 45)
        Me.btnRemoveUser.TabIndex = 33
        Me.btnRemoveUser.Tag = ""
        Me.btnRemoveUser.Text = "Add a new user account."
        Me.btnRemoveUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveUser.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnUserAccounts
        '
        Me.btnUserAccounts.Animated = True
        Me.btnUserAccounts.BorderRadius = 10
        Me.btnUserAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUserAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUserAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUserAccounts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUserAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUserAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserAccounts.FillColor = System.Drawing.Color.PowderBlue
        Me.btnUserAccounts.FillColor2 = System.Drawing.Color.LightGray
        Me.btnUserAccounts.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccounts.ForeColor = System.Drawing.Color.Black
        Me.btnUserAccounts.Image = Global.SchoolDemo.My.Resources.Resources._484
        Me.btnUserAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUserAccounts.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnUserAccounts.Location = New System.Drawing.Point(0, 0)
        Me.btnUserAccounts.Name = "btnUserAccounts"
        Me.btnUserAccounts.Size = New System.Drawing.Size(753, 43)
        Me.btnUserAccounts.TabIndex = 14
        Me.btnUserAccounts.Tag = "Manage accounts."
        Me.btnUserAccounts.Text = "User Accounts"
        Me.btnUserAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlDropStudentDetails
        '
        Me.pnlDropStudentDetails.Controls.Add(Me.btnStudentMedicalDetails)
        Me.pnlDropStudentDetails.Controls.Add(Me.btnGuardianDetails)
        Me.pnlDropStudentDetails.Controls.Add(Me.btnStudentSubjects)
        Me.pnlDropStudentDetails.Controls.Add(Me.btnStudentPersonalDetails)
        Me.pnlDropStudentDetails.Controls.Add(Me.btnRemoveStudent)
        Me.pnlDropStudentDetails.Controls.Add(Me.btnStudentDetails)
        Me.pnlDropStudentDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDropStudentDetails.Location = New System.Drawing.Point(3, 52)
        Me.pnlDropStudentDetails.Name = "pnlDropStudentDetails"
        Me.pnlDropStudentDetails.Size = New System.Drawing.Size(753, 43)
        Me.pnlDropStudentDetails.TabIndex = 31
        '
        'btnStudentMedicalDetails
        '
        Me.btnStudentMedicalDetails.Animated = True
        Me.btnStudentMedicalDetails.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentMedicalDetails.BorderRadius = 10
        Me.btnStudentMedicalDetails.BorderThickness = 1
        Me.btnStudentMedicalDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentMedicalDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentMedicalDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentMedicalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentMedicalDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentMedicalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentMedicalDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentMedicalDetails.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentMedicalDetails.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentMedicalDetails.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentMedicalDetails.ForeColor = System.Drawing.Color.White
        Me.btnStudentMedicalDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentMedicalDetails.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentMedicalDetails.Location = New System.Drawing.Point(0, 223)
        Me.btnStudentMedicalDetails.Name = "btnStudentMedicalDetails"
        Me.btnStudentMedicalDetails.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentMedicalDetails.TabIndex = 27
        Me.btnStudentMedicalDetails.Tag = ""
        Me.btnStudentMedicalDetails.Text = "Medical details."
        Me.btnStudentMedicalDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentMedicalDetails.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnGuardianDetails
        '
        Me.btnGuardianDetails.Animated = True
        Me.btnGuardianDetails.BorderColor = System.Drawing.Color.Empty
        Me.btnGuardianDetails.BorderRadius = 10
        Me.btnGuardianDetails.BorderThickness = 1
        Me.btnGuardianDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardianDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardianDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardianDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardianDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardianDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardianDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGuardianDetails.FillColor = System.Drawing.Color.SlateBlue
        Me.btnGuardianDetails.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnGuardianDetails.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnGuardianDetails.ForeColor = System.Drawing.Color.White
        Me.btnGuardianDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGuardianDetails.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnGuardianDetails.Location = New System.Drawing.Point(0, 178)
        Me.btnGuardianDetails.Name = "btnGuardianDetails"
        Me.btnGuardianDetails.Size = New System.Drawing.Size(753, 45)
        Me.btnGuardianDetails.TabIndex = 29
        Me.btnGuardianDetails.Tag = ""
        Me.btnGuardianDetails.Text = "Guardian details."
        Me.btnGuardianDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGuardianDetails.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentSubjects
        '
        Me.btnStudentSubjects.Animated = True
        Me.btnStudentSubjects.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentSubjects.BorderRadius = 10
        Me.btnStudentSubjects.BorderThickness = 1
        Me.btnStudentSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentSubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentSubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentSubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentSubjects.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentSubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentSubjects.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentSubjects.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentSubjects.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentSubjects.ForeColor = System.Drawing.Color.White
        Me.btnStudentSubjects.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentSubjects.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentSubjects.Location = New System.Drawing.Point(0, 133)
        Me.btnStudentSubjects.Name = "btnStudentSubjects"
        Me.btnStudentSubjects.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentSubjects.TabIndex = 28
        Me.btnStudentSubjects.Tag = ""
        Me.btnStudentSubjects.Text = "Subject details."
        Me.btnStudentSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentSubjects.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentPersonalDetails
        '
        Me.btnStudentPersonalDetails.Animated = True
        Me.btnStudentPersonalDetails.BorderColor = System.Drawing.Color.Empty
        Me.btnStudentPersonalDetails.BorderRadius = 10
        Me.btnStudentPersonalDetails.BorderThickness = 1
        Me.btnStudentPersonalDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentPersonalDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentPersonalDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentPersonalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentPersonalDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentPersonalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentPersonalDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentPersonalDetails.FillColor = System.Drawing.Color.SlateBlue
        Me.btnStudentPersonalDetails.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnStudentPersonalDetails.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnStudentPersonalDetails.ForeColor = System.Drawing.Color.White
        Me.btnStudentPersonalDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentPersonalDetails.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentPersonalDetails.Location = New System.Drawing.Point(0, 88)
        Me.btnStudentPersonalDetails.Name = "btnStudentPersonalDetails"
        Me.btnStudentPersonalDetails.Size = New System.Drawing.Size(753, 45)
        Me.btnStudentPersonalDetails.TabIndex = 30
        Me.btnStudentPersonalDetails.Tag = ""
        Me.btnStudentPersonalDetails.Text = "Personal details."
        Me.btnStudentPersonalDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentPersonalDetails.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnRemoveStudent
        '
        Me.btnRemoveStudent.Animated = True
        Me.btnRemoveStudent.BorderColor = System.Drawing.Color.Empty
        Me.btnRemoveStudent.BorderRadius = 10
        Me.btnRemoveStudent.BorderThickness = 1
        Me.btnRemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveStudent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemoveStudent.FillColor = System.Drawing.Color.IndianRed
        Me.btnRemoveStudent.FillColor2 = System.Drawing.Color.IndianRed
        Me.btnRemoveStudent.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnRemoveStudent.ForeColor = System.Drawing.Color.White
        Me.btnRemoveStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveStudent.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnRemoveStudent.Location = New System.Drawing.Point(0, 43)
        Me.btnRemoveStudent.Name = "btnRemoveStudent"
        Me.btnRemoveStudent.Size = New System.Drawing.Size(753, 45)
        Me.btnRemoveStudent.TabIndex = 31
        Me.btnRemoveStudent.Tag = ""
        Me.btnRemoveStudent.Text = "Remove student."
        Me.btnRemoveStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveStudent.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStudentDetails
        '
        Me.btnStudentDetails.Animated = True
        Me.btnStudentDetails.BorderRadius = 10
        Me.btnStudentDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentDetails.FillColor = System.Drawing.Color.PowderBlue
        Me.btnStudentDetails.FillColor2 = System.Drawing.Color.LightGray
        Me.btnStudentDetails.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.btnStudentDetails.Image = Global.SchoolDemo.My.Resources.Resources._742
        Me.btnStudentDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentDetails.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStudentDetails.Location = New System.Drawing.Point(0, 0)
        Me.btnStudentDetails.Name = "btnStudentDetails"
        Me.btnStudentDetails.Size = New System.Drawing.Size(753, 43)
        Me.btnStudentDetails.TabIndex = 17
        Me.btnStudentDetails.Tag = "Adjust a student's details."
        Me.btnStudentDetails.Text = "Student Details"
        Me.btnStudentDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlDropFaculty
        '
        Me.pnlDropFaculty.Controls.Add(Me.btnFacultyPersonalDetails)
        Me.pnlDropFaculty.Controls.Add(Me.btnFacultySubjects)
        Me.pnlDropFaculty.Controls.Add(Me.btnRemoveFaculty)
        Me.pnlDropFaculty.Controls.Add(Me.btnFaculty)
        Me.pnlDropFaculty.Location = New System.Drawing.Point(3, 101)
        Me.pnlDropFaculty.Name = "pnlDropFaculty"
        Me.pnlDropFaculty.Size = New System.Drawing.Size(753, 43)
        Me.pnlDropFaculty.TabIndex = 23
        '
        'btnFacultyPersonalDetails
        '
        Me.btnFacultyPersonalDetails.Animated = True
        Me.btnFacultyPersonalDetails.BorderColor = System.Drawing.Color.Empty
        Me.btnFacultyPersonalDetails.BorderRadius = 10
        Me.btnFacultyPersonalDetails.BorderThickness = 1
        Me.btnFacultyPersonalDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacultyPersonalDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultyPersonalDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultyPersonalDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultyPersonalDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultyPersonalDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFacultyPersonalDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacultyPersonalDetails.FillColor = System.Drawing.Color.SlateBlue
        Me.btnFacultyPersonalDetails.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnFacultyPersonalDetails.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnFacultyPersonalDetails.ForeColor = System.Drawing.Color.White
        Me.btnFacultyPersonalDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFacultyPersonalDetails.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnFacultyPersonalDetails.Location = New System.Drawing.Point(0, 133)
        Me.btnFacultyPersonalDetails.Name = "btnFacultyPersonalDetails"
        Me.btnFacultyPersonalDetails.Size = New System.Drawing.Size(753, 45)
        Me.btnFacultyPersonalDetails.TabIndex = 32
        Me.btnFacultyPersonalDetails.Tag = ""
        Me.btnFacultyPersonalDetails.Text = "Personal details."
        Me.btnFacultyPersonalDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFacultyPersonalDetails.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnFacultySubjects
        '
        Me.btnFacultySubjects.Animated = True
        Me.btnFacultySubjects.BorderColor = System.Drawing.Color.Empty
        Me.btnFacultySubjects.BorderRadius = 10
        Me.btnFacultySubjects.BorderThickness = 1
        Me.btnFacultySubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacultySubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultySubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFacultySubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultySubjects.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFacultySubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFacultySubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFacultySubjects.FillColor = System.Drawing.Color.SlateBlue
        Me.btnFacultySubjects.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnFacultySubjects.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnFacultySubjects.ForeColor = System.Drawing.Color.White
        Me.btnFacultySubjects.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFacultySubjects.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnFacultySubjects.Location = New System.Drawing.Point(0, 88)
        Me.btnFacultySubjects.Name = "btnFacultySubjects"
        Me.btnFacultySubjects.Size = New System.Drawing.Size(753, 45)
        Me.btnFacultySubjects.TabIndex = 34
        Me.btnFacultySubjects.Tag = ""
        Me.btnFacultySubjects.Text = "Subject details."
        Me.btnFacultySubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFacultySubjects.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnRemoveFaculty
        '
        Me.btnRemoveFaculty.Animated = True
        Me.btnRemoveFaculty.BorderColor = System.Drawing.Color.Empty
        Me.btnRemoveFaculty.BorderRadius = 10
        Me.btnRemoveFaculty.BorderThickness = 1
        Me.btnRemoveFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveFaculty.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemoveFaculty.FillColor = System.Drawing.Color.IndianRed
        Me.btnRemoveFaculty.FillColor2 = System.Drawing.Color.IndianRed
        Me.btnRemoveFaculty.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.btnRemoveFaculty.ForeColor = System.Drawing.Color.White
        Me.btnRemoveFaculty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveFaculty.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnRemoveFaculty.Location = New System.Drawing.Point(0, 43)
        Me.btnRemoveFaculty.Name = "btnRemoveFaculty"
        Me.btnRemoveFaculty.Size = New System.Drawing.Size(753, 45)
        Me.btnRemoveFaculty.TabIndex = 33
        Me.btnRemoveFaculty.Tag = ""
        Me.btnRemoveFaculty.Text = "Remove Faculty."
        Me.btnRemoveFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoveFaculty.TextOffset = New System.Drawing.Point(50, 0)
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
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.Black
        Me.btnFaculty.Image = Global.SchoolDemo.My.Resources.Resources._100
        Me.btnFaculty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFaculty.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFaculty.Location = New System.Drawing.Point(0, 0)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(753, 43)
        Me.btnFaculty.TabIndex = 29
        Me.btnFaculty.Tag = "Adjust a faculty member's details."
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAttendancy
        '
        Me.btnAttendancy.Animated = True
        Me.btnAttendancy.BorderRadius = 10
        Me.btnAttendancy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendancy.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendancy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendancy.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendancy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendancy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendancy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendancy.FillColor = System.Drawing.Color.PowderBlue
        Me.btnAttendancy.FillColor2 = System.Drawing.Color.LightGray
        Me.btnAttendancy.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendancy.ForeColor = System.Drawing.Color.Black
        Me.btnAttendancy.Image = Global.SchoolDemo.My.Resources.Resources._573
        Me.btnAttendancy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendancy.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAttendancy.Location = New System.Drawing.Point(3, 150)
        Me.btnAttendancy.Name = "btnAttendancy"
        Me.btnAttendancy.Size = New System.Drawing.Size(753, 43)
        Me.btnAttendancy.TabIndex = 27
        Me.btnAttendancy.Tag = "Adjust a class's attendace records."
        Me.btnAttendancy.Text = "Attendance"
        Me.btnAttendancy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnClassFees
        '
        Me.btnClassFees.Animated = True
        Me.btnClassFees.BorderRadius = 10
        Me.btnClassFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClassFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClassFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClassFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClassFees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClassFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClassFees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClassFees.FillColor = System.Drawing.Color.PowderBlue
        Me.btnClassFees.FillColor2 = System.Drawing.Color.LightGray
        Me.btnClassFees.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassFees.ForeColor = System.Drawing.Color.Black
        Me.btnClassFees.Image = Global.SchoolDemo.My.Resources.Resources._266
        Me.btnClassFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClassFees.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnClassFees.Location = New System.Drawing.Point(3, 199)
        Me.btnClassFees.Name = "btnClassFees"
        Me.btnClassFees.Size = New System.Drawing.Size(753, 43)
        Me.btnClassFees.TabIndex = 32
        Me.btnClassFees.Tag = "Adjust the fees payable per class."
        Me.btnClassFees.Text = "Fees Structure"
        Me.btnClassFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnMiscellanousCosts
        '
        Me.btnMiscellanousCosts.Animated = True
        Me.btnMiscellanousCosts.BorderRadius = 10
        Me.btnMiscellanousCosts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMiscellanousCosts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMiscellanousCosts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMiscellanousCosts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMiscellanousCosts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMiscellanousCosts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMiscellanousCosts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMiscellanousCosts.FillColor = System.Drawing.Color.PowderBlue
        Me.btnMiscellanousCosts.FillColor2 = System.Drawing.Color.LightGray
        Me.btnMiscellanousCosts.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiscellanousCosts.ForeColor = System.Drawing.Color.Black
        Me.btnMiscellanousCosts.Image = Global.SchoolDemo.My.Resources.Resources._266
        Me.btnMiscellanousCosts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMiscellanousCosts.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMiscellanousCosts.Location = New System.Drawing.Point(3, 248)
        Me.btnMiscellanousCosts.Name = "btnMiscellanousCosts"
        Me.btnMiscellanousCosts.Size = New System.Drawing.Size(753, 43)
        Me.btnMiscellanousCosts.TabIndex = 35
        Me.btnMiscellanousCosts.Tag = "Adjust the miscellanous costs payable per student."
        Me.btnMiscellanousCosts.Text = "Miscellanous Costs"
        Me.btnMiscellanousCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnRates
        '
        Me.btnRates.Animated = True
        Me.btnRates.BorderRadius = 10
        Me.btnRates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRates.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRates.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRates.FillColor = System.Drawing.Color.PowderBlue
        Me.btnRates.FillColor2 = System.Drawing.Color.LightGray
        Me.btnRates.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRates.ForeColor = System.Drawing.Color.Black
        Me.btnRates.Image = Global.SchoolDemo.My.Resources.Resources._532
        Me.btnRates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRates.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRates.Location = New System.Drawing.Point(3, 297)
        Me.btnRates.Name = "btnRates"
        Me.btnRates.Size = New System.Drawing.Size(753, 43)
        Me.btnRates.TabIndex = 29
        Me.btnRates.Tag = "Adjust exchange rates applicable."
        Me.btnRates.Text = "Rates"
        Me.btnRates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTerm
        '
        Me.btnTerm.Animated = True
        Me.btnTerm.BorderRadius = 10
        Me.btnTerm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTerm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTerm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTerm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTerm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTerm.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTerm.FillColor = System.Drawing.Color.PowderBlue
        Me.btnTerm.FillColor2 = System.Drawing.Color.LightGray
        Me.btnTerm.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerm.ForeColor = System.Drawing.Color.Black
        Me.btnTerm.Image = Global.SchoolDemo.My.Resources.Resources._98
        Me.btnTerm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTerm.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnTerm.Location = New System.Drawing.Point(3, 346)
        Me.btnTerm.Name = "btnTerm"
        Me.btnTerm.Size = New System.Drawing.Size(753, 43)
        Me.btnTerm.TabIndex = 30
        Me.btnTerm.Tag = "Set the currently active term."
        Me.btnTerm.Text = "Term"
        Me.btnTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnConfiguration
        '
        Me.btnConfiguration.Animated = True
        Me.btnConfiguration.BorderRadius = 10
        Me.btnConfiguration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguration.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfiguration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfiguration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfiguration.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfiguration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfiguration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguration.FillColor = System.Drawing.Color.PowderBlue
        Me.btnConfiguration.FillColor2 = System.Drawing.Color.LightGray
        Me.btnConfiguration.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguration.ForeColor = System.Drawing.Color.Black
        Me.btnConfiguration.Image = Global.SchoolDemo.My.Resources.Resources._109
        Me.btnConfiguration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfiguration.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnConfiguration.Location = New System.Drawing.Point(3, 395)
        Me.btnConfiguration.Name = "btnConfiguration"
        Me.btnConfiguration.Size = New System.Drawing.Size(753, 43)
        Me.btnConfiguration.TabIndex = 34
        Me.btnConfiguration.Tag = "Set system configuration settings."
        Me.btnConfiguration.Text = "Configurations"
        Me.btnConfiguration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.pnlFlowMain)
        Me.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Panel"
        Me.pnlFlowMain.ResumeLayout(False)
        Me.pnlUserAccountsDrop.ResumeLayout(False)
        Me.pnlDropStudentDetails.ResumeLayout(False)
        Me.pnlDropFaculty.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFlowMain As FlowLayoutPanel
    Friend WithEvents btnConfiguration As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClassFees As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRates As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnTerm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAttendancy As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlUserAccountsDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnUserActivity As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRemoveUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUserAccounts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlDropStudentDetails As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnStudentMedicalDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnGuardianDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentSubjects As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentPersonalDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRemoveStudent As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlDropFaculty As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFacultyPersonalDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRemoveFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFacultySubjects As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMiscellanousCosts As Guna.UI2.WinForms.Guna2GradientButton
End Class
