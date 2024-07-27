<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOptions
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
        Me.lblAddtionalInfoUsers = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAdditionalInfoSettings = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnDarkMode = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlRunDiagnosticsDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnReportBugs = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRepairApplication = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnConnectivity = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRunDiagnostics = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUpdates = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBackUp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.picBoxlogo = New System.Windows.Forms.PictureBox()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPassword = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnNewUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl.SuspendLayout()
        Me.pnlRunDiagnosticsDrop.SuspendLayout()
        CType(Me.picBoxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoUsers
        '
        Me.lblAddtionalInfoUsers.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoUsers.Font = New System.Drawing.Font("Century Gothic", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoUsers.Location = New System.Drawing.Point(12, 255)
        Me.lblAddtionalInfoUsers.Name = "lblAddtionalInfoUsers"
        Me.lblAddtionalInfoUsers.Size = New System.Drawing.Size(183, 18)
        Me.lblAddtionalInfoUsers.TabIndex = 5
        Me.lblAddtionalInfoUsers.Text = "Adjust your account details."
        Me.lblAddtionalInfoUsers.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditionalInfoSettings
        '
        Me.lblAdditionalInfoSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblAdditionalInfoSettings.Font = New System.Drawing.Font("Century Gothic", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalInfoSettings.Location = New System.Drawing.Point(524, 255)
        Me.lblAdditionalInfoSettings.Name = "lblAdditionalInfoSettings"
        Me.lblAdditionalInfoSettings.Size = New System.Drawing.Size(132, 18)
        Me.lblAdditionalInfoSettings.TabIndex = 7
        Me.lblAdditionalInfoSettings.Text = "Adjust your settings."
        Me.lblAdditionalInfoSettings.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.Controls.Add(Me.btnDarkMode)
        Me.flowpnl.Controls.Add(Me.pnlRunDiagnosticsDrop)
        Me.flowpnl.Controls.Add(Me.btnUpdates)
        Me.flowpnl.Controls.Add(Me.btnBackUp)
        Me.flowpnl.Location = New System.Drawing.Point(516, 7)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(460, 224)
        Me.flowpnl.TabIndex = 20
        '
        'btnDarkMode
        '
        Me.btnDarkMode.Animated = True
        Me.btnDarkMode.BorderRadius = 10
        Me.btnDarkMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDarkMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDarkMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDarkMode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDarkMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDarkMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDarkMode.FillColor = System.Drawing.Color.PowderBlue
        Me.btnDarkMode.FillColor2 = System.Drawing.Color.LightGray
        Me.btnDarkMode.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarkMode.ForeColor = System.Drawing.Color.Black
        Me.btnDarkMode.Image = Global.SchoolDemo.My.Resources.Resources._124
        Me.btnDarkMode.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDarkMode.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDarkMode.Location = New System.Drawing.Point(0, 126)
        Me.btnDarkMode.Name = "btnDarkMode"
        Me.btnDarkMode.Size = New System.Drawing.Size(460, 42)
        Me.btnDarkMode.TabIndex = 8
        Me.btnDarkMode.Text = "Dark mode"
        Me.btnDarkMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlRunDiagnosticsDrop
        '
        Me.pnlRunDiagnosticsDrop.Controls.Add(Me.btnReportBugs)
        Me.pnlRunDiagnosticsDrop.Controls.Add(Me.btnRepairApplication)
        Me.pnlRunDiagnosticsDrop.Controls.Add(Me.btnConnectivity)
        Me.pnlRunDiagnosticsDrop.Controls.Add(Me.btnRunDiagnostics)
        Me.pnlRunDiagnosticsDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRunDiagnosticsDrop.Location = New System.Drawing.Point(0, 84)
        Me.pnlRunDiagnosticsDrop.Name = "pnlRunDiagnosticsDrop"
        Me.pnlRunDiagnosticsDrop.Size = New System.Drawing.Size(460, 42)
        Me.pnlRunDiagnosticsDrop.TabIndex = 21
        '
        'btnReportBugs
        '
        Me.btnReportBugs.Animated = True
        Me.btnReportBugs.BorderColor = System.Drawing.Color.LightGray
        Me.btnReportBugs.BorderRadius = 10
        Me.btnReportBugs.BorderThickness = 1
        Me.btnReportBugs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportBugs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReportBugs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReportBugs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReportBugs.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReportBugs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReportBugs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportBugs.FillColor = System.Drawing.Color.Empty
        Me.btnReportBugs.FillColor2 = System.Drawing.Color.Empty
        Me.btnReportBugs.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportBugs.ForeColor = System.Drawing.Color.Black
        Me.btnReportBugs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReportBugs.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnReportBugs.Location = New System.Drawing.Point(0, 132)
        Me.btnReportBugs.Name = "btnReportBugs"
        Me.btnReportBugs.Size = New System.Drawing.Size(460, 45)
        Me.btnReportBugs.TabIndex = 24
        Me.btnReportBugs.Tag = ""
        Me.btnReportBugs.Text = "Report a bug found in the application."
        Me.btnReportBugs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReportBugs.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnRepairApplication
        '
        Me.btnRepairApplication.Animated = True
        Me.btnRepairApplication.BorderColor = System.Drawing.Color.LightGray
        Me.btnRepairApplication.BorderRadius = 10
        Me.btnRepairApplication.BorderThickness = 1
        Me.btnRepairApplication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRepairApplication.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRepairApplication.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRepairApplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRepairApplication.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRepairApplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRepairApplication.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepairApplication.FillColor = System.Drawing.Color.Empty
        Me.btnRepairApplication.FillColor2 = System.Drawing.Color.Empty
        Me.btnRepairApplication.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepairApplication.ForeColor = System.Drawing.Color.Black
        Me.btnRepairApplication.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRepairApplication.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnRepairApplication.Location = New System.Drawing.Point(0, 87)
        Me.btnRepairApplication.Name = "btnRepairApplication"
        Me.btnRepairApplication.Size = New System.Drawing.Size(460, 45)
        Me.btnRepairApplication.TabIndex = 23
        Me.btnRepairApplication.Tag = ""
        Me.btnRepairApplication.Text = "Repair and restart application."
        Me.btnRepairApplication.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRepairApplication.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnConnectivity
        '
        Me.btnConnectivity.Animated = True
        Me.btnConnectivity.BorderColor = System.Drawing.Color.LightGray
        Me.btnConnectivity.BorderRadius = 10
        Me.btnConnectivity.BorderThickness = 1
        Me.btnConnectivity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnectivity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConnectivity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConnectivity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConnectivity.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConnectivity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConnectivity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConnectivity.FillColor = System.Drawing.Color.Empty
        Me.btnConnectivity.FillColor2 = System.Drawing.Color.Empty
        Me.btnConnectivity.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectivity.ForeColor = System.Drawing.Color.Black
        Me.btnConnectivity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConnectivity.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnConnectivity.Location = New System.Drawing.Point(0, 42)
        Me.btnConnectivity.Name = "btnConnectivity"
        Me.btnConnectivity.Size = New System.Drawing.Size(460, 45)
        Me.btnConnectivity.TabIndex = 22
        Me.btnConnectivity.Tag = ""
        Me.btnConnectivity.Text = "Troubleshoot your connections."
        Me.btnConnectivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConnectivity.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnRunDiagnostics
        '
        Me.btnRunDiagnostics.Animated = True
        Me.btnRunDiagnostics.BorderRadius = 10
        Me.btnRunDiagnostics.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRunDiagnostics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRunDiagnostics.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRunDiagnostics.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRunDiagnostics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRunDiagnostics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRunDiagnostics.FillColor = System.Drawing.Color.PowderBlue
        Me.btnRunDiagnostics.FillColor2 = System.Drawing.Color.LightGray
        Me.btnRunDiagnostics.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunDiagnostics.ForeColor = System.Drawing.Color.Black
        Me.btnRunDiagnostics.Image = Global.SchoolDemo.My.Resources.Resources._96
        Me.btnRunDiagnostics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRunDiagnostics.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRunDiagnostics.Location = New System.Drawing.Point(0, 0)
        Me.btnRunDiagnostics.Name = "btnRunDiagnostics"
        Me.btnRunDiagnostics.Size = New System.Drawing.Size(460, 42)
        Me.btnRunDiagnostics.TabIndex = 11
        Me.btnRunDiagnostics.Text = "Run diagnostics"
        Me.btnRunDiagnostics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnUpdates
        '
        Me.btnUpdates.Animated = True
        Me.btnUpdates.BorderRadius = 10
        Me.btnUpdates.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdates.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdates.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdates.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpdates.FillColor = System.Drawing.Color.PowderBlue
        Me.btnUpdates.FillColor2 = System.Drawing.Color.LightGray
        Me.btnUpdates.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdates.ForeColor = System.Drawing.Color.Black
        Me.btnUpdates.Image = Global.SchoolDemo.My.Resources.Resources._864
        Me.btnUpdates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdates.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnUpdates.Location = New System.Drawing.Point(0, 42)
        Me.btnUpdates.Name = "btnUpdates"
        Me.btnUpdates.Size = New System.Drawing.Size(460, 42)
        Me.btnUpdates.TabIndex = 19
        Me.btnUpdates.Text = "Check for updates"
        Me.btnUpdates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBackUp
        '
        Me.btnBackUp.Animated = True
        Me.btnBackUp.BorderRadius = 10
        Me.btnBackUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackUp.FillColor = System.Drawing.Color.PowderBlue
        Me.btnBackUp.FillColor2 = System.Drawing.Color.LightGray
        Me.btnBackUp.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp.ForeColor = System.Drawing.Color.Black
        Me.btnBackUp.Image = Global.SchoolDemo.My.Resources.Resources._869
        Me.btnBackUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBackUp.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBackUp.Location = New System.Drawing.Point(0, 0)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(460, 42)
        Me.btnBackUp.TabIndex = 10
        Me.btnBackUp.Text = "Back up data"
        Me.btnBackUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'picBoxlogo
        '
        Me.picBoxlogo.BackColor = System.Drawing.Color.Transparent
        Me.picBoxlogo.BackgroundImage = Global.SchoolDemo.My.Resources.Resources.blog
        Me.picBoxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBoxlogo.Location = New System.Drawing.Point(12, 7)
        Me.picBoxlogo.Name = "picBoxlogo"
        Me.picBoxlogo.Size = New System.Drawing.Size(153, 170)
        Me.picBoxlogo.TabIndex = 4
        Me.picBoxlogo.TabStop = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Animated = True
        Me.btnSignOut.BorderRadius = 8
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignOut.FillColor = System.Drawing.Color.PowderBlue
        Me.btnSignOut.FillColor2 = System.Drawing.Color.LightGray
        Me.btnSignOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.ForeColor = System.Drawing.Color.Black
        Me.btnSignOut.Image = Global.SchoolDemo.My.Resources.Resources._132
        Me.btnSignOut.ImageOffset = New System.Drawing.Point(15, -10)
        Me.btnSignOut.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnSignOut.Location = New System.Drawing.Point(340, 105)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(144, 97)
        Me.btnSignOut.TabIndex = 3
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.TextOffset = New System.Drawing.Point(-12, 27)
        '
        'btnRemove
        '
        Me.btnRemove.Animated = True
        Me.btnRemove.BorderRadius = 8
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.PowderBlue
        Me.btnRemove.FillColor2 = System.Drawing.Color.LightGray
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Image = Global.SchoolDemo.My.Resources.Resources._347
        Me.btnRemove.ImageOffset = New System.Drawing.Point(19, -13)
        Me.btnRemove.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnRemove.Location = New System.Drawing.Point(340, 7)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(144, 97)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextOffset = New System.Drawing.Point(-12, 27)
        '
        'btnPassword
        '
        Me.btnPassword.Animated = True
        Me.btnPassword.BorderRadius = 8
        Me.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPassword.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPassword.FillColor = System.Drawing.Color.PowderBlue
        Me.btnPassword.FillColor2 = System.Drawing.Color.LightGray
        Me.btnPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.Black
        Me.btnPassword.Image = Global.SchoolDemo.My.Resources.Resources._397
        Me.btnPassword.ImageOffset = New System.Drawing.Point(20, -13)
        Me.btnPassword.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnPassword.Location = New System.Drawing.Point(195, 105)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(144, 97)
        Me.btnPassword.TabIndex = 1
        Me.btnPassword.Text = "Password"
        Me.btnPassword.TextOffset = New System.Drawing.Point(-12, 27)
        '
        'btnNewUser
        '
        Me.btnNewUser.Animated = True
        Me.btnNewUser.BorderRadius = 8
        Me.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewUser.FillColor = System.Drawing.Color.PowderBlue
        Me.btnNewUser.FillColor2 = System.Drawing.Color.LightGray
        Me.btnNewUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnNewUser.Image = Global.SchoolDemo.My.Resources.Resources._346
        Me.btnNewUser.ImageOffset = New System.Drawing.Point(20, -13)
        Me.btnNewUser.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnNewUser.Location = New System.Drawing.Point(195, 7)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(144, 97)
        Me.btnNewUser.TabIndex = 0
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.TextOffset = New System.Drawing.Point(-12, 27)
        '
        'FrmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 280)
        Me.Controls.Add(Me.lblAdditionalInfoSettings)
        Me.Controls.Add(Me.lblAddtionalInfoUsers)
        Me.Controls.Add(Me.picBoxlogo)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.flowpnl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOptions"
        Me.Text = "FrmOptions"
        Me.flowpnl.ResumeLayout(False)
        Me.pnlRunDiagnosticsDrop.ResumeLayout(False)
        CType(Me.picBoxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPassword As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents picBoxlogo As PictureBox
    Friend WithEvents lblAddtionalInfoUsers As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAdditionalInfoSettings As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDarkMode As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBackUp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRunDiagnostics As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUpdates As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlRunDiagnosticsDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnReportBugs As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnRepairApplication As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnConnectivity As Guna.UI2.WinForms.Guna2GradientButton
End Class
