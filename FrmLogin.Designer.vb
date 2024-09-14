<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picBoxSignIn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlUnderlineUsername = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlUnderlinePassword = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.OpeningTransition = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnActivateKey = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.picBoxSignIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassword.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.LightGray
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtPassword.IconLeft = Global.SchoolDemo.My.Resources.Resources._531
        Me.txtPassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPassword.Location = New System.Drawing.Point(46, 248)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(293, 43)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.TextOffset = New System.Drawing.Point(7, 0)
        '
        'picBoxSignIn
        '
        Me.picBoxSignIn.BackgroundImage = Global.SchoolDemo.My.Resources.Resources._884
        Me.picBoxSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBoxSignIn.FillColor = System.Drawing.Color.Transparent
        Me.picBoxSignIn.ImageRotate = 0!
        Me.picBoxSignIn.Location = New System.Drawing.Point(108, 38)
        Me.picBoxSignIn.Name = "picBoxSignIn"
        Me.picBoxSignIn.Size = New System.Drawing.Size(173, 106)
        Me.picBoxSignIn.TabIndex = 60
        Me.picBoxSignIn.TabStop = False
        '
        'pnlUnderlineUsername
        '
        Me.pnlUnderlineUsername.FillColor = System.Drawing.Color.White
        Me.pnlUnderlineUsername.FillColor2 = System.Drawing.Color.White
        Me.pnlUnderlineUsername.Location = New System.Drawing.Point(46, 224)
        Me.pnlUnderlineUsername.Name = "pnlUnderlineUsername"
        Me.pnlUnderlineUsername.Size = New System.Drawing.Size(293, 3)
        Me.pnlUnderlineUsername.TabIndex = 53
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(98, 329)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(194, 45)
        Me.btnLogin.TabIndex = 59
        Me.btnLogin.Text = "Login"
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Empty
        Me.btnClose.FillColor2 = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnClose.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnClose.Image = Global.SchoolDemo.My.Resources.Resources._938
        Me.btnClose.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnClose.Location = New System.Drawing.Point(345, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 36)
        Me.btnClose.TabIndex = 57
        Me.btnClose.UseTransparentBackground = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.FillColor = System.Drawing.Color.Empty
        Me.btnMinimize.FillColor2 = System.Drawing.Color.Empty
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMinimize.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnMinimize.Image = Global.SchoolDemo.My.Resources.Resources._995
        Me.btnMinimize.Location = New System.Drawing.Point(299, -2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 36)
        Me.btnMinimize.TabIndex = 58
        Me.btnMinimize.UseTransparentBackground = True
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsername.BorderThickness = 0
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = "Username"
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsername.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.txtUsername.IconLeft = Global.SchoolDemo.My.Resources.Resources._884
        Me.txtUsername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtUsername.Location = New System.Drawing.Point(46, 179)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(293, 45)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextOffset = New System.Drawing.Point(7, 0)
        '
        'pnlUnderlinePassword
        '
        Me.pnlUnderlinePassword.FillColor = System.Drawing.Color.White
        Me.pnlUnderlinePassword.FillColor2 = System.Drawing.Color.White
        Me.pnlUnderlinePassword.Location = New System.Drawing.Point(46, 291)
        Me.pnlUnderlinePassword.Name = "pnlUnderlinePassword"
        Me.pnlUnderlinePassword.Size = New System.Drawing.Size(293, 3)
        Me.pnlUnderlinePassword.TabIndex = 54
        '
        'OpeningTransition
        '
        Me.OpeningTransition.AnimateWindow = True
        Me.OpeningTransition.AnimationInterval = 1500
        Me.OpeningTransition.BorderRadius = 15
        Me.OpeningTransition.ContainerControl = Me
        Me.OpeningTransition.DockIndicatorTransparencyValue = 0.6R
        Me.OpeningTransition.ResizeForm = False
        Me.OpeningTransition.TransparentWhileDrag = True
        '
        'btnActivateKey
        '
        Me.btnActivateKey.Animated = True
        Me.btnActivateKey.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnActivateKey.BorderThickness = 1
        Me.btnActivateKey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActivateKey.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnActivateKey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnActivateKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActivateKey.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActivateKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnActivateKey.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActivateKey.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnActivateKey.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnActivateKey.ForeColor = System.Drawing.Color.White
        Me.btnActivateKey.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnActivateKey.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnActivateKey.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnActivateKey.Location = New System.Drawing.Point(283, 414)
        Me.btnActivateKey.Name = "btnActivateKey"
        Me.btnActivateKey.PressedColor = System.Drawing.Color.PowderBlue
        Me.btnActivateKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnActivateKey.Size = New System.Drawing.Size(93, 28)
        Me.btnActivateKey.TabIndex = 61
        Me.btnActivateKey.Text = "Activate"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 450)
        Me.Controls.Add(Me.btnActivateKey)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.picBoxSignIn)
        Me.Controls.Add(Me.pnlUnderlineUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.pnlUnderlinePassword)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        CType(Me.picBoxSignIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picBoxSignIn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlUnderlineUsername As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlUnderlinePassword As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents OpeningTransition As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnActivateKey As Guna.UI2.WinForms.Guna2GradientButton
End Class
