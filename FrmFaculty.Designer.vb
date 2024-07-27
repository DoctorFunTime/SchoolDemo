<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFaculty
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
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeadingOne = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnRoles = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.openingTranstionFaculty = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlDock = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlRoles = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cntrlCtrlSelection = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAdd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListBoxSubjects = New System.Windows.Forms.ListBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateAndFinalise = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFaculty = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnValidateFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEmailAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhoneNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtBirthIDNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBirthIDNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtePickerDateOfBirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSurname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlDock.SuspendLayout()
        Me.pnlRoles.SuspendLayout()
        Me.pnlFaculty.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Animated = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.SchoolDemo.My.Resources.Resources._938
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(759, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 39)
        Me.btnClose.TabIndex = 28
        '
        'lblHeadingOne
        '
        Me.lblHeadingOne.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingOne.Font = New System.Drawing.Font("Century Gothic", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingOne.Location = New System.Drawing.Point(21, 16)
        Me.lblHeadingOne.Name = "lblHeadingOne"
        Me.lblHeadingOne.Size = New System.Drawing.Size(324, 39)
        Me.lblHeadingOne.TabIndex = 25
        Me.lblHeadingOne.Text = "New Faculty Member"
        Me.lblHeadingOne.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRoles
        '
        Me.btnRoles.Animated = True
        Me.btnRoles.BackColor = System.Drawing.Color.Transparent
        Me.btnRoles.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnRoles.BorderRadius = 10
        Me.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRoles.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRoles.FillColor = System.Drawing.Color.Empty
        Me.btnRoles.FillColor2 = System.Drawing.Color.Empty
        Me.btnRoles.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoles.ForeColor = System.Drawing.Color.Black
        Me.btnRoles.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnRoles.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnRoles.Location = New System.Drawing.Point(9, 189)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.ShadowDecoration.BorderRadius = 10
        Me.btnRoles.ShadowDecoration.Depth = 8
        Me.btnRoles.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnRoles.Size = New System.Drawing.Size(120, 45)
        Me.btnRoles.TabIndex = 27
        Me.btnRoles.Text = "Roles"
        Me.btnRoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRoles.UseTransparentBackground = True
        '
        'btnFaculty
        '
        Me.btnFaculty.Animated = True
        Me.btnFaculty.BackColor = System.Drawing.Color.Transparent
        Me.btnFaculty.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnFaculty.BorderRadius = 10
        Me.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFaculty.FillColor = System.Drawing.Color.Empty
        Me.btnFaculty.FillColor2 = System.Drawing.Color.Empty
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.Black
        Me.btnFaculty.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnFaculty.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnFaculty.Location = New System.Drawing.Point(9, 117)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.ShadowDecoration.BorderRadius = 10
        Me.btnFaculty.ShadowDecoration.Depth = 8
        Me.btnFaculty.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnFaculty.Size = New System.Drawing.Size(120, 45)
        Me.btnFaculty.TabIndex = 26
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFaculty.UseTransparentBackground = True
        '
        'openingTranstionFaculty
        '
        Me.openingTranstionFaculty.AnimateWindow = True
        Me.openingTranstionFaculty.BorderRadius = 15
        Me.openingTranstionFaculty.ContainerControl = Me
        Me.openingTranstionFaculty.DockIndicatorTransparencyValue = 0.6R
        Me.openingTranstionFaculty.ResizeForm = False
        Me.openingTranstionFaculty.TransparentWhileDrag = True
        '
        'pnlDock
        '
        Me.pnlDock.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlDock.Controls.Add(Me.pnlRoles)
        Me.pnlDock.Controls.Add(Me.pnlFaculty)
        Me.pnlDock.Location = New System.Drawing.Point(134, 80)
        Me.pnlDock.Name = "pnlDock"
        Me.pnlDock.ShadowDecoration.Depth = 8
        Me.pnlDock.ShadowDecoration.Enabled = True
        Me.pnlDock.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.pnlDock.Size = New System.Drawing.Size(657, 475)
        Me.pnlDock.TabIndex = 29
        '
        'pnlRoles
        '
        Me.pnlRoles.Controls.Add(Me.cntrlCtrlSelection)
        Me.pnlRoles.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnlRoles.Controls.Add(Me.lblAdd)
        Me.pnlRoles.Controls.Add(Me.ListBoxSubjects)
        Me.pnlRoles.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnlRoles.Controls.Add(Me.cmbBoxClass)
        Me.pnlRoles.Controls.Add(Me.lblClass)
        Me.pnlRoles.Controls.Add(Me.btnValidateAndFinalise)
        Me.pnlRoles.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRoles.Location = New System.Drawing.Point(0, 10)
        Me.pnlRoles.Name = "pnlRoles"
        Me.pnlRoles.Size = New System.Drawing.Size(657, 477)
        Me.pnlRoles.TabIndex = 3
        '
        'cntrlCtrlSelection
        '
        Me.cntrlCtrlSelection.AutoScroll = True
        Me.cntrlCtrlSelection.Location = New System.Drawing.Point(436, 120)
        Me.cntrlCtrlSelection.Name = "cntrlCtrlSelection"
        Me.cntrlCtrlSelection.Size = New System.Drawing.Size(214, 291)
        Me.cntrlCtrlSelection.TabIndex = 40
        Me.cntrlCtrlSelection.Text = "Guna2ContainerControl1"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(500, 86)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(97, 26)
        Me.Guna2HtmlLabel3.TabIndex = 39
        Me.Guna2HtmlLabel3.Text = "Selection"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdd
        '
        Me.lblAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblAdd.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(18, 86)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(211, 26)
        Me.lblAdd.TabIndex = 38
        Me.lblAdd.Text = "Double Click to Add"
        Me.lblAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxSubjects
        '
        Me.ListBoxSubjects.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ListBoxSubjects.FormattingEnabled = True
        Me.ListBoxSubjects.ItemHeight = 17
        Me.ListBoxSubjects.Location = New System.Drawing.Point(18, 120)
        Me.ListBoxSubjects.Name = "ListBoxSubjects"
        Me.ListBoxSubjects.Size = New System.Drawing.Size(230, 293)
        Me.ListBoxSubjects.Sorted = True
        Me.ListBoxSubjects.TabIndex = 37
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(333, 246)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(41, 41)
        Me.Guna2HtmlLabel2.TabIndex = 36
        Me.Guna2HtmlLabel2.Text = "=>"
        '
        'cmbBoxClass
        '
        Me.cmbBoxClass.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxClass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxClass.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxClass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxClass.ItemHeight = 30
        Me.cmbBoxClass.Items.AddRange(New Object() {"Form 1", "Form 2", "Form 3", "Form 4", "Form 5", "Form 6"})
        Me.cmbBoxClass.Location = New System.Drawing.Point(160, 21)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxClass.TabIndex = 35
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(95, 38)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(44, 19)
        Me.lblClass.TabIndex = 34
        Me.lblClass.Text = "Class :"
        '
        'btnValidateAndFinalise
        '
        Me.btnValidateAndFinalise.Animated = True
        Me.btnValidateAndFinalise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateAndFinalise.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateAndFinalise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateAndFinalise.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateAndFinalise.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateAndFinalise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateAndFinalise.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateAndFinalise.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateAndFinalise.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateAndFinalise.ForeColor = System.Drawing.Color.White
        Me.btnValidateAndFinalise.Location = New System.Drawing.Point(452, 423)
        Me.btnValidateAndFinalise.Name = "btnValidateAndFinalise"
        Me.btnValidateAndFinalise.Size = New System.Drawing.Size(198, 45)
        Me.btnValidateAndFinalise.TabIndex = 31
        Me.btnValidateAndFinalise.Text = "Validate and Finalise"
        '
        'pnlFaculty
        '
        Me.pnlFaculty.Controls.Add(Me.btnValidateFaculty)
        Me.pnlFaculty.Controls.Add(Me.txtEmailAddress)
        Me.pnlFaculty.Controls.Add(Me.lblEmailAddress)
        Me.pnlFaculty.Controls.Add(Me.txtPhoneNumber)
        Me.pnlFaculty.Controls.Add(Me.lblPhoneNumber)
        Me.pnlFaculty.Controls.Add(Me.txtAddress)
        Me.pnlFaculty.Controls.Add(Me.lblAddress)
        Me.pnlFaculty.Controls.Add(Me.txtBirthIDNumber)
        Me.pnlFaculty.Controls.Add(Me.btnBirthIDNumber)
        Me.pnlFaculty.Controls.Add(Me.dtePickerDateOfBirth)
        Me.pnlFaculty.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlFaculty.Controls.Add(Me.txtSurname)
        Me.pnlFaculty.Controls.Add(Me.lblSurname)
        Me.pnlFaculty.Controls.Add(Me.txtFirstName)
        Me.pnlFaculty.Controls.Add(Me.lblName)
        Me.pnlFaculty.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFaculty.Location = New System.Drawing.Point(0, 0)
        Me.pnlFaculty.Name = "pnlFaculty"
        Me.pnlFaculty.Size = New System.Drawing.Size(657, 10)
        Me.pnlFaculty.TabIndex = 0
        '
        'btnValidateFaculty
        '
        Me.btnValidateFaculty.Animated = True
        Me.btnValidateFaculty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateFaculty.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateFaculty.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateFaculty.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateFaculty.ForeColor = System.Drawing.Color.White
        Me.btnValidateFaculty.Location = New System.Drawing.Point(500, 423)
        Me.btnValidateFaculty.Name = "btnValidateFaculty"
        Me.btnValidateFaculty.Size = New System.Drawing.Size(150, 45)
        Me.btnValidateFaculty.TabIndex = 15
        Me.btnValidateFaculty.Text = "Validate"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Animated = True
        Me.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAddress.DefaultText = ""
        Me.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.Location = New System.Drawing.Point(238, 377)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAddress.PlaceholderText = "Email address ...."
        Me.txtEmailAddress.SelectedText = ""
        Me.txtEmailAddress.Size = New System.Drawing.Size(180, 30)
        Me.txtEmailAddress.TabIndex = 14
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.Location = New System.Drawing.Point(49, 388)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(90, 19)
        Me.lblEmailAddress.TabIndex = 13
        Me.lblEmailAddress.Text = "Email Adress :"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Animated = True
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.DefaultText = ""
        Me.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(238, 320)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber.PlaceholderText = "Phone number ...."
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 30)
        Me.txtPhoneNumber.TabIndex = 12
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(33, 331)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(106, 19)
        Me.lblPhoneNumber.TabIndex = 11
        Me.lblPhoneNumber.Text = "Phone number :"
        '
        'txtAddress
        '
        Me.txtAddress.Animated = True
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(238, 263)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = " Address ...."
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(386, 30)
        Me.txtAddress.TabIndex = 10
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(79, 274)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 19)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address :"
        '
        'txtBirthIDNumber
        '
        Me.txtBirthIDNumber.Animated = True
        Me.txtBirthIDNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBirthIDNumber.DefaultText = ""
        Me.txtBirthIDNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBirthIDNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBirthIDNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBirthIDNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBirthIDNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBirthIDNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthIDNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBirthIDNumber.Location = New System.Drawing.Point(238, 206)
        Me.txtBirthIDNumber.Name = "txtBirthIDNumber"
        Me.txtBirthIDNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBirthIDNumber.PlaceholderText = " ID Number ...."
        Me.txtBirthIDNumber.SelectedText = ""
        Me.txtBirthIDNumber.Size = New System.Drawing.Size(180, 30)
        Me.txtBirthIDNumber.TabIndex = 8
        '
        'btnBirthIDNumber
        '
        Me.btnBirthIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.btnBirthIDNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBirthIDNumber.Location = New System.Drawing.Point(18, 217)
        Me.btnBirthIDNumber.Name = "btnBirthIDNumber"
        Me.btnBirthIDNumber.Size = New System.Drawing.Size(121, 19)
        Me.btnBirthIDNumber.TabIndex = 7
        Me.btnBirthIDNumber.Text = "Birth / ID Number :"
        '
        'dtePickerDateOfBirth
        '
        Me.dtePickerDateOfBirth.Checked = True
        Me.dtePickerDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePickerDateOfBirth.FillColor = System.Drawing.Color.White
        Me.dtePickerDateOfBirth.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtePickerDateOfBirth.Location = New System.Drawing.Point(238, 144)
        Me.dtePickerDateOfBirth.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtePickerDateOfBirth.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtePickerDateOfBirth.Name = "dtePickerDateOfBirth"
        Me.dtePickerDateOfBirth.Size = New System.Drawing.Size(266, 35)
        Me.dtePickerDateOfBirth.TabIndex = 6
        Me.dtePickerDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtePickerDateOfBirth.Value = New Date(2024, 7, 21, 0, 0, 0, 0)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(46, 160)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(91, 19)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Date of Birth :"
        '
        'txtSurname
        '
        Me.txtSurname.Animated = True
        Me.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSurname.DefaultText = ""
        Me.txtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.Location = New System.Drawing.Point(238, 92)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.PlaceholderText = "Surname ...."
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.Size = New System.Drawing.Size(180, 30)
        Me.txtSurname.TabIndex = 4
        '
        'lblSurname
        '
        Me.lblSurname.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(70, 103)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(67, 19)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname  :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Animated = True
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(238, 35)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "First name ...."
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(180, 30)
        Me.txtFirstName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(70, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name (s)  :"
        '
        'FrmFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.pnlDock)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHeadingOne)
        Me.Controls.Add(Me.btnRoles)
        Me.Controls.Add(Me.btnFaculty)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFaculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFaculty"
        Me.pnlDock.ResumeLayout(False)
        Me.pnlRoles.ResumeLayout(False)
        Me.pnlRoles.PerformLayout()
        Me.pnlFaculty.ResumeLayout(False)
        Me.pnlFaculty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHeadingOne As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnRoles As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents openingTranstionFaculty As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlDock As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlRoles As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblClass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnValidateAndFinalise As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlFaculty As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnValidateFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmailAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtBirthIDNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBirthIDNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtePickerDateOfBirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSurname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cntrlCtrlSelection As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAdd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ListBoxSubjects As ListBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
