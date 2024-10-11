<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegisterSelection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegisterSelection))
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlMainControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlSchoolDetails = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBankDetails = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtBankingDetails = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchoolEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSchoolName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSlogan = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtBubText = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchoolContacts = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtContacts = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchoolName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlUserAccounts = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblCPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbAccountType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAccountType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlInvoicingStudents = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmbBoxPaymentType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPaymentType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDocNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDocNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxReportBook = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtReportBook = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblReportBook = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxCurrency = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCurrency = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtMiscellaneous = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiscellaneousCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMiscellaneous = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbTextBooks = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtTextbooksCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTextbooksAndSupplys = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbUniform = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtUniformCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUniform = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtClassCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbBoxTransport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtTransportCost = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTransportCost = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblInvClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalFees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFees = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlRegisterFilters = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbTerm = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTerm = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtePickerDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnValidateAndFinalise = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlMainControls.SuspendLayout()
        Me.pnlSchoolDetails.SuspendLayout()
        Me.pnlUserAccounts.SuspendLayout()
        Me.pnlInvoicingStudents.SuspendLayout()
        Me.pnlRegisterFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'openingTranstionReceipts
        '
        Me.openingTranstionReceipts.AnimateWindow = True
        Me.openingTranstionReceipts.BorderRadius = 15
        Me.openingTranstionReceipts.ContainerControl = Me
        Me.openingTranstionReceipts.DockIndicatorTransparencyValue = 0.6R
        Me.openingTranstionReceipts.ResizeForm = False
        Me.openingTranstionReceipts.TransparentWhileDrag = True
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.lblHeading)
        Me.pnlTopBar.Controls.Add(Me.btnClose)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.FillColor = System.Drawing.Color.PowderBlue
        Me.pnlTopBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(576, 41)
        Me.pnlTopBar.TabIndex = 59
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(212, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(121, 25)
        Me.lblHeading.TabIndex = 56
        Me.lblHeading.Text = "Set the Filters"
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
        Me.btnClose.Location = New System.Drawing.Point(535, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 41)
        Me.btnClose.TabIndex = 55
        '
        'pnlMainControls
        '
        Me.pnlMainControls.Controls.Add(Me.pnlSchoolDetails)
        Me.pnlMainControls.Controls.Add(Me.pnlUserAccounts)
        Me.pnlMainControls.Controls.Add(Me.pnlInvoicingStudents)
        Me.pnlMainControls.Controls.Add(Me.pnlRegisterFilters)
        Me.pnlMainControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainControls.Location = New System.Drawing.Point(0, 41)
        Me.pnlMainControls.Name = "pnlMainControls"
        Me.pnlMainControls.Size = New System.Drawing.Size(576, 434)
        Me.pnlMainControls.TabIndex = 60
        '
        'pnlSchoolDetails
        '
        Me.pnlSchoolDetails.Controls.Add(Me.lblID)
        Me.pnlSchoolDetails.Controls.Add(Me.lblBankDetails)
        Me.pnlSchoolDetails.Controls.Add(Me.txtBankingDetails)
        Me.pnlSchoolDetails.Controls.Add(Me.lblSchoolEmail)
        Me.pnlSchoolDetails.Controls.Add(Me.txtEmail)
        Me.pnlSchoolDetails.Controls.Add(Me.txtSchoolName)
        Me.pnlSchoolDetails.Controls.Add(Me.lblSlogan)
        Me.pnlSchoolDetails.Controls.Add(Me.txtBubText)
        Me.pnlSchoolDetails.Controls.Add(Me.lblAddress)
        Me.pnlSchoolDetails.Controls.Add(Me.txtAddress)
        Me.pnlSchoolDetails.Controls.Add(Me.lblSchoolContacts)
        Me.pnlSchoolDetails.Controls.Add(Me.txtContacts)
        Me.pnlSchoolDetails.Controls.Add(Me.lblSchoolName)
        Me.pnlSchoolDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSchoolDetails.Location = New System.Drawing.Point(0, 30)
        Me.pnlSchoolDetails.Name = "pnlSchoolDetails"
        Me.pnlSchoolDetails.Size = New System.Drawing.Size(576, 404)
        Me.pnlSchoolDetails.TabIndex = 61
        Me.pnlSchoolDetails.Visible = False
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(545, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(15, 19)
        Me.lblID.TabIndex = 101
        Me.lblID.Text = "id"
        '
        'lblBankDetails
        '
        Me.lblBankDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblBankDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankDetails.Location = New System.Drawing.Point(109, 290)
        Me.lblBankDetails.Name = "lblBankDetails"
        Me.lblBankDetails.Size = New System.Drawing.Size(109, 19)
        Me.lblBankDetails.TabIndex = 100
        Me.lblBankDetails.Text = "Banking Details :"
        '
        'txtBankingDetails
        '
        Me.txtBankingDetails.Animated = True
        Me.txtBankingDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBankingDetails.DefaultText = ""
        Me.txtBankingDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBankingDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBankingDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBankingDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBankingDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBankingDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankingDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBankingDetails.Location = New System.Drawing.Point(250, 285)
        Me.txtBankingDetails.Name = "txtBankingDetails"
        Me.txtBankingDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBankingDetails.PlaceholderText = ""
        Me.txtBankingDetails.SelectedText = ""
        Me.txtBankingDetails.Size = New System.Drawing.Size(218, 103)
        Me.txtBankingDetails.TabIndex = 99
        '
        'lblSchoolEmail
        '
        Me.lblSchoolEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolEmail.Location = New System.Drawing.Point(172, 237)
        Me.lblSchoolEmail.Name = "lblSchoolEmail"
        Me.lblSchoolEmail.Size = New System.Drawing.Size(46, 19)
        Me.lblSchoolEmail.TabIndex = 98
        Me.lblSchoolEmail.Text = "Email :"
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(250, 232)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(218, 30)
        Me.txtEmail.TabIndex = 97
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Animated = True
        Me.txtSchoolName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolName.DefaultText = ""
        Me.txtSchoolName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchoolName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchoolName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolName.Location = New System.Drawing.Point(250, 20)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolName.PlaceholderText = ""
        Me.txtSchoolName.SelectedText = ""
        Me.txtSchoolName.Size = New System.Drawing.Size(218, 30)
        Me.txtSchoolName.TabIndex = 96
        '
        'lblSlogan
        '
        Me.lblSlogan.BackColor = System.Drawing.Color.Transparent
        Me.lblSlogan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.Location = New System.Drawing.Point(160, 184)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(58, 19)
        Me.lblSlogan.TabIndex = 95
        Me.lblSlogan.Text = "SubText :"
        '
        'txtBubText
        '
        Me.txtBubText.Animated = True
        Me.txtBubText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBubText.DefaultText = ""
        Me.txtBubText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBubText.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBubText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBubText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBubText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBubText.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBubText.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBubText.Location = New System.Drawing.Point(250, 179)
        Me.txtBubText.Name = "txtBubText"
        Me.txtBubText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBubText.PlaceholderText = ""
        Me.txtBubText.SelectedText = ""
        Me.txtBubText.Size = New System.Drawing.Size(218, 30)
        Me.txtBubText.TabIndex = 94
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(158, 131)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 19)
        Me.lblAddress.TabIndex = 93
        Me.lblAddress.Text = "Address :"
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
        Me.txtAddress.Location = New System.Drawing.Point(250, 126)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(218, 30)
        Me.txtAddress.TabIndex = 92
        '
        'lblSchoolContacts
        '
        Me.lblSchoolContacts.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolContacts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolContacts.Location = New System.Drawing.Point(147, 78)
        Me.lblSchoolContacts.Name = "lblSchoolContacts"
        Me.lblSchoolContacts.Size = New System.Drawing.Size(71, 19)
        Me.lblSchoolContacts.TabIndex = 90
        Me.lblSchoolContacts.Text = "Contacts  :"
        '
        'txtContacts
        '
        Me.txtContacts.Animated = True
        Me.txtContacts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContacts.DefaultText = ""
        Me.txtContacts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContacts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContacts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContacts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContacts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContacts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacts.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContacts.Location = New System.Drawing.Point(250, 73)
        Me.txtContacts.Name = "txtContacts"
        Me.txtContacts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContacts.PlaceholderText = ""
        Me.txtContacts.SelectedText = ""
        Me.txtContacts.Size = New System.Drawing.Size(218, 30)
        Me.txtContacts.TabIndex = 89
        '
        'lblSchoolName
        '
        Me.lblSchoolName.BackColor = System.Drawing.Color.Transparent
        Me.lblSchoolName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolName.Location = New System.Drawing.Point(120, 25)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(98, 19)
        Me.lblSchoolName.TabIndex = 88
        Me.lblSchoolName.Text = "School Name  :"
        '
        'pnlUserAccounts
        '
        Me.pnlUserAccounts.Controls.Add(Me.lblCPassword)
        Me.pnlUserAccounts.Controls.Add(Me.txtCPassword)
        Me.pnlUserAccounts.Controls.Add(Me.lblPassword)
        Me.pnlUserAccounts.Controls.Add(Me.txtPassword)
        Me.pnlUserAccounts.Controls.Add(Me.cmbAccountType)
        Me.pnlUserAccounts.Controls.Add(Me.lblUsername)
        Me.pnlUserAccounts.Controls.Add(Me.txtUsername)
        Me.pnlUserAccounts.Controls.Add(Me.lblAccountType)
        Me.pnlUserAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUserAccounts.Location = New System.Drawing.Point(0, 20)
        Me.pnlUserAccounts.Name = "pnlUserAccounts"
        Me.pnlUserAccounts.Size = New System.Drawing.Size(576, 10)
        Me.pnlUserAccounts.TabIndex = 60
        Me.pnlUserAccounts.Visible = False
        '
        'lblCPassword
        '
        Me.lblCPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblCPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPassword.Location = New System.Drawing.Point(140, 266)
        Me.lblCPassword.Name = "lblCPassword"
        Me.lblCPassword.Size = New System.Drawing.Size(128, 19)
        Me.lblCPassword.TabIndex = 87
        Me.lblCPassword.Text = "Confirm Password  :"
        '
        'txtCPassword
        '
        Me.txtCPassword.Animated = True
        Me.txtCPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCPassword.DefaultText = ""
        Me.txtCPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCPassword.Location = New System.Drawing.Point(300, 258)
        Me.txtCPassword.Name = "txtCPassword"
        Me.txtCPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCPassword.PlaceholderText = ""
        Me.txtCPassword.SelectedText = ""
        Me.txtCPassword.Size = New System.Drawing.Size(136, 30)
        Me.txtCPassword.TabIndex = 86
        Me.txtCPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(196, 213)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 19)
        Me.lblPassword.TabIndex = 85
        Me.lblPassword.Text = "Password  :"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(300, 206)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(136, 30)
        Me.txtPassword.TabIndex = 84
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cmbAccountType
        '
        Me.cmbAccountType.BackColor = System.Drawing.Color.Transparent
        Me.cmbAccountType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbAccountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAccountType.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbAccountType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAccountType.ItemHeight = 30
        Me.cmbAccountType.Items.AddRange(New Object() {"Admin", "Standard"})
        Me.cmbAccountType.Location = New System.Drawing.Point(300, 96)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(136, 36)
        Me.cmbAccountType.TabIndex = 83
        Me.cmbAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(194, 160)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 19)
        Me.lblUsername.TabIndex = 82
        Me.lblUsername.Text = "Username  :"
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(300, 154)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(136, 30)
        Me.txtUsername.TabIndex = 81
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAccountType
        '
        Me.lblAccountType.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.Location = New System.Drawing.Point(170, 107)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(98, 19)
        Me.lblAccountType.TabIndex = 80
        Me.lblAccountType.Text = "Account Type  :"
        '
        'pnlInvoicingStudents
        '
        Me.pnlInvoicingStudents.AutoScroll = True
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbBoxPaymentType)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblPaymentType)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtDocNumber)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblDocNumber)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbBoxReportBook)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtReportBook)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblReportBook)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbBoxCurrency)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblCurrency)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtMiscellaneous)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtMiscellaneousCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblMiscellaneous)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbTextBooks)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtTextbooksCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblTextbooksAndSupplys)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbUniform)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtUniformCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblUniform)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtClassCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbBoxTransport)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtTransportCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblTransportCost)
        Me.pnlInvoicingStudents.Controls.Add(Me.cmbBoxClass)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblInvClass)
        Me.pnlInvoicingStudents.Controls.Add(Me.txtTotalFees)
        Me.pnlInvoicingStudents.Controls.Add(Me.lblFees)
        Me.pnlInvoicingStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInvoicingStudents.Location = New System.Drawing.Point(0, 10)
        Me.pnlInvoicingStudents.Name = "pnlInvoicingStudents"
        Me.pnlInvoicingStudents.Size = New System.Drawing.Size(576, 10)
        Me.pnlInvoicingStudents.TabIndex = 59
        Me.pnlInvoicingStudents.Visible = False
        '
        'cmbBoxPaymentType
        '
        Me.cmbBoxPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxPaymentType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxPaymentType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxPaymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxPaymentType.ItemHeight = 30
        Me.cmbBoxPaymentType.Items.AddRange(New Object() {"Cash", "EFT", "Cheque"})
        Me.cmbBoxPaymentType.Location = New System.Drawing.Point(181, 289)
        Me.cmbBoxPaymentType.Name = "cmbBoxPaymentType"
        Me.cmbBoxPaymentType.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxPaymentType.TabIndex = 86
        Me.cmbBoxPaymentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPaymentType
        '
        Me.lblPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(42, 300)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(100, 19)
        Me.lblPaymentType.TabIndex = 85
        Me.lblPaymentType.Text = "Payment Type  :"
        '
        'txtDocNumber
        '
        Me.txtDocNumber.Animated = True
        Me.txtDocNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocNumber.DefaultText = ""
        Me.txtDocNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDocNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDocNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocNumber.Location = New System.Drawing.Point(181, 383)
        Me.txtDocNumber.Name = "txtDocNumber"
        Me.txtDocNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocNumber.PlaceholderText = ""
        Me.txtDocNumber.SelectedText = ""
        Me.txtDocNumber.Size = New System.Drawing.Size(136, 30)
        Me.txtDocNumber.TabIndex = 84
        Me.txtDocNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDocNumber
        '
        Me.lblDocNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblDocNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNumber.Location = New System.Drawing.Point(48, 389)
        Me.lblDocNumber.Name = "lblDocNumber"
        Me.lblDocNumber.Size = New System.Drawing.Size(94, 19)
        Me.lblDocNumber.TabIndex = 83
        Me.lblDocNumber.Text = "Doc Number  :"
        '
        'cmbBoxReportBook
        '
        Me.cmbBoxReportBook.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxReportBook.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxReportBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxReportBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxReportBook.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxReportBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxReportBook.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxReportBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxReportBook.ItemHeight = 30
        Me.cmbBoxReportBook.Items.AddRange(New Object() {"Include", "n/a"})
        Me.cmbBoxReportBook.Location = New System.Drawing.Point(181, 154)
        Me.cmbBoxReportBook.Name = "cmbBoxReportBook"
        Me.cmbBoxReportBook.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxReportBook.TabIndex = 82
        Me.cmbBoxReportBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReportBook
        '
        Me.txtReportBook.Animated = True
        Me.txtReportBook.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReportBook.DefaultText = "0"
        Me.txtReportBook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReportBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReportBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReportBook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReportBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportBook.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReportBook.Location = New System.Drawing.Point(350, 153)
        Me.txtReportBook.Name = "txtReportBook"
        Me.txtReportBook.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReportBook.PlaceholderText = ""
        Me.txtReportBook.ReadOnly = True
        Me.txtReportBook.SelectedText = ""
        Me.txtReportBook.Size = New System.Drawing.Size(67, 30)
        Me.txtReportBook.TabIndex = 81
        Me.txtReportBook.Tag = "Report book cost"
        '
        'lblReportBook
        '
        Me.lblReportBook.BackColor = System.Drawing.Color.Transparent
        Me.lblReportBook.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportBook.Location = New System.Drawing.Point(52, 165)
        Me.lblReportBook.Name = "lblReportBook"
        Me.lblReportBook.Size = New System.Drawing.Size(90, 19)
        Me.lblReportBook.TabIndex = 80
        Me.lblReportBook.Text = "Report Book  :"
        '
        'cmbBoxCurrency
        '
        Me.cmbBoxCurrency.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxCurrency.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxCurrency.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxCurrency.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxCurrency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxCurrency.ItemHeight = 30
        Me.cmbBoxCurrency.Items.AddRange(New Object() {"USD", "ZIG"})
        Me.cmbBoxCurrency.Location = New System.Drawing.Point(181, 336)
        Me.cmbBoxCurrency.Name = "cmbBoxCurrency"
        Me.cmbBoxCurrency.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxCurrency.TabIndex = 79
        Me.cmbBoxCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.Location = New System.Drawing.Point(74, 346)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(68, 19)
        Me.lblCurrency.TabIndex = 78
        Me.lblCurrency.Text = "Currency  :"
        '
        'txtMiscellaneous
        '
        Me.txtMiscellaneous.Animated = True
        Me.txtMiscellaneous.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiscellaneous.DefaultText = "n/a"
        Me.txtMiscellaneous.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneous.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneous.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiscellaneous.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneous.Location = New System.Drawing.Point(181, 248)
        Me.txtMiscellaneous.Name = "txtMiscellaneous"
        Me.txtMiscellaneous.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiscellaneous.PlaceholderText = ""
        Me.txtMiscellaneous.SelectedText = ""
        Me.txtMiscellaneous.Size = New System.Drawing.Size(136, 30)
        Me.txtMiscellaneous.TabIndex = 77
        Me.txtMiscellaneous.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMiscellaneousCost
        '
        Me.txtMiscellaneousCost.Animated = True
        Me.txtMiscellaneousCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiscellaneousCost.DefaultText = "0"
        Me.txtMiscellaneousCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiscellaneousCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiscellaneousCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneousCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneousCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneousCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiscellaneousCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneousCost.Location = New System.Drawing.Point(350, 245)
        Me.txtMiscellaneousCost.Name = "txtMiscellaneousCost"
        Me.txtMiscellaneousCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiscellaneousCost.PlaceholderText = ""
        Me.txtMiscellaneousCost.SelectedText = ""
        Me.txtMiscellaneousCost.Size = New System.Drawing.Size(67, 30)
        Me.txtMiscellaneousCost.TabIndex = 76
        '
        'lblMiscellaneous
        '
        Me.lblMiscellaneous.BackColor = System.Drawing.Color.Transparent
        Me.lblMiscellaneous.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscellaneous.Location = New System.Drawing.Point(43, 254)
        Me.lblMiscellaneous.Name = "lblMiscellaneous"
        Me.lblMiscellaneous.Size = New System.Drawing.Size(99, 19)
        Me.lblMiscellaneous.TabIndex = 75
        Me.lblMiscellaneous.Text = "Miscellaneous  :"
        '
        'cmbTextBooks
        '
        Me.cmbTextBooks.BackColor = System.Drawing.Color.Transparent
        Me.cmbTextBooks.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbTextBooks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTextBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTextBooks.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTextBooks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTextBooks.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbTextBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTextBooks.ItemHeight = 30
        Me.cmbTextBooks.Items.AddRange(New Object() {"Include", "n/a"})
        Me.cmbTextBooks.Location = New System.Drawing.Point(181, 201)
        Me.cmbTextBooks.Name = "cmbTextBooks"
        Me.cmbTextBooks.Size = New System.Drawing.Size(136, 36)
        Me.cmbTextBooks.TabIndex = 74
        Me.cmbTextBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTextbooksCost
        '
        Me.txtTextbooksCost.Animated = True
        Me.txtTextbooksCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTextbooksCost.DefaultText = "0"
        Me.txtTextbooksCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTextbooksCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTextbooksCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTextbooksCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTextbooksCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTextbooksCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextbooksCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTextbooksCost.Location = New System.Drawing.Point(350, 199)
        Me.txtTextbooksCost.Name = "txtTextbooksCost"
        Me.txtTextbooksCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTextbooksCost.PlaceholderText = ""
        Me.txtTextbooksCost.ReadOnly = True
        Me.txtTextbooksCost.SelectedText = ""
        Me.txtTextbooksCost.Size = New System.Drawing.Size(67, 30)
        Me.txtTextbooksCost.TabIndex = 73
        Me.txtTextbooksCost.Tag = "Textbooks cost"
        '
        'lblTextbooksAndSupplys
        '
        Me.lblTextbooksAndSupplys.BackColor = System.Drawing.Color.Transparent
        Me.lblTextbooksAndSupplys.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextbooksAndSupplys.Location = New System.Drawing.Point(68, 211)
        Me.lblTextbooksAndSupplys.Name = "lblTextbooksAndSupplys"
        Me.lblTextbooksAndSupplys.Size = New System.Drawing.Size(74, 19)
        Me.lblTextbooksAndSupplys.TabIndex = 72
        Me.lblTextbooksAndSupplys.Text = "Textbooks  :"
        '
        'cmbUniform
        '
        Me.cmbUniform.BackColor = System.Drawing.Color.Transparent
        Me.cmbUniform.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbUniform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUniform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUniform.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbUniform.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbUniform.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbUniform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbUniform.ItemHeight = 30
        Me.cmbUniform.Items.AddRange(New Object() {"Include", "n/a"})
        Me.cmbUniform.Location = New System.Drawing.Point(181, 107)
        Me.cmbUniform.Name = "cmbUniform"
        Me.cmbUniform.Size = New System.Drawing.Size(136, 36)
        Me.cmbUniform.TabIndex = 71
        Me.cmbUniform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUniformCost
        '
        Me.txtUniformCost.Animated = True
        Me.txtUniformCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUniformCost.DefaultText = "0"
        Me.txtUniformCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUniformCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUniformCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUniformCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUniformCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUniformCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUniformCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUniformCost.Location = New System.Drawing.Point(350, 107)
        Me.txtUniformCost.Name = "txtUniformCost"
        Me.txtUniformCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUniformCost.PlaceholderText = ""
        Me.txtUniformCost.ReadOnly = True
        Me.txtUniformCost.SelectedText = ""
        Me.txtUniformCost.Size = New System.Drawing.Size(67, 30)
        Me.txtUniformCost.TabIndex = 70
        Me.txtUniformCost.Tag = "Uniform Cost"
        '
        'lblUniform
        '
        Me.lblUniform.BackColor = System.Drawing.Color.Transparent
        Me.lblUniform.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniform.Location = New System.Drawing.Point(82, 119)
        Me.lblUniform.Name = "lblUniform"
        Me.lblUniform.Size = New System.Drawing.Size(60, 19)
        Me.lblUniform.TabIndex = 69
        Me.lblUniform.Text = "Uniform  :"
        '
        'txtClassCost
        '
        Me.txtClassCost.Animated = True
        Me.txtClassCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClassCost.DefaultText = "0"
        Me.txtClassCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtClassCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtClassCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtClassCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtClassCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClassCost.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtClassCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtClassCost.Location = New System.Drawing.Point(350, 15)
        Me.txtClassCost.Name = "txtClassCost"
        Me.txtClassCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClassCost.PlaceholderText = ""
        Me.txtClassCost.ReadOnly = True
        Me.txtClassCost.SelectedText = ""
        Me.txtClassCost.Size = New System.Drawing.Size(67, 30)
        Me.txtClassCost.TabIndex = 68
        Me.txtClassCost.Tag = "Student Fees"
        '
        'cmbBoxTransport
        '
        Me.cmbBoxTransport.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxTransport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxTransport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxTransport.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxTransport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxTransport.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxTransport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxTransport.ItemHeight = 30
        Me.cmbBoxTransport.Items.AddRange(New Object() {"Include", "n/a"})
        Me.cmbBoxTransport.Location = New System.Drawing.Point(181, 60)
        Me.cmbBoxTransport.Name = "cmbBoxTransport"
        Me.cmbBoxTransport.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxTransport.TabIndex = 67
        Me.cmbBoxTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTransportCost
        '
        Me.txtTransportCost.Animated = True
        Me.txtTransportCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransportCost.DefaultText = "0"
        Me.txtTransportCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTransportCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTransportCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransportCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTransportCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransportCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransportCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTransportCost.Location = New System.Drawing.Point(350, 61)
        Me.txtTransportCost.Name = "txtTransportCost"
        Me.txtTransportCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransportCost.PlaceholderText = ""
        Me.txtTransportCost.ReadOnly = True
        Me.txtTransportCost.SelectedText = ""
        Me.txtTransportCost.Size = New System.Drawing.Size(67, 30)
        Me.txtTransportCost.TabIndex = 66
        Me.txtTransportCost.Tag = "Transport Cost"
        '
        'lblTransportCost
        '
        Me.lblTransportCost.BackColor = System.Drawing.Color.Transparent
        Me.lblTransportCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransportCost.Location = New System.Drawing.Point(24, 70)
        Me.lblTransportCost.Name = "lblTransportCost"
        Me.lblTransportCost.Size = New System.Drawing.Size(118, 19)
        Me.lblTransportCost.TabIndex = 65
        Me.lblTransportCost.Text = "Transport Service  :"
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
        Me.cmbBoxClass.Location = New System.Drawing.Point(181, 13)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxClass.TabIndex = 64
        Me.cmbBoxClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInvClass
        '
        Me.lblInvClass.BackColor = System.Drawing.Color.Transparent
        Me.lblInvClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvClass.Location = New System.Drawing.Point(98, 23)
        Me.lblInvClass.Name = "lblInvClass"
        Me.lblInvClass.Size = New System.Drawing.Size(44, 19)
        Me.lblInvClass.TabIndex = 63
        Me.lblInvClass.Text = "Class :"
        '
        'txtTotalFees
        '
        Me.txtTotalFees.Animated = True
        Me.txtTotalFees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFees.DefaultText = ""
        Me.txtTotalFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalFees.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalFees.Location = New System.Drawing.Point(366, 366)
        Me.txtTotalFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalFees.PlaceholderText = ""
        Me.txtTotalFees.ReadOnly = True
        Me.txtTotalFees.SelectedText = ""
        Me.txtTotalFees.Size = New System.Drawing.Size(198, 47)
        Me.txtTotalFees.TabIndex = 62
        Me.txtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFees
        '
        Me.lblFees.BackColor = System.Drawing.Color.Transparent
        Me.lblFees.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblFees.Location = New System.Drawing.Point(426, 335)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(78, 20)
        Me.lblFees.TabIndex = 61
        Me.lblFees.Text = "Total Fees"
        '
        'pnlRegisterFilters
        '
        Me.pnlRegisterFilters.Controls.Add(Me.lblDate)
        Me.pnlRegisterFilters.Controls.Add(Me.cmbTerm)
        Me.pnlRegisterFilters.Controls.Add(Me.lblClass)
        Me.pnlRegisterFilters.Controls.Add(Me.lblTerm)
        Me.pnlRegisterFilters.Controls.Add(Me.cmbClass)
        Me.pnlRegisterFilters.Controls.Add(Me.dtePickerDate)
        Me.pnlRegisterFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRegisterFilters.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegisterFilters.Name = "pnlRegisterFilters"
        Me.pnlRegisterFilters.Size = New System.Drawing.Size(576, 10)
        Me.pnlRegisterFilters.TabIndex = 58
        Me.pnlRegisterFilters.Visible = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(125, 138)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 19)
        Me.lblDate.TabIndex = 54
        Me.lblDate.Text = "Date  :"
        '
        'cmbTerm
        '
        Me.cmbTerm.BackColor = System.Drawing.Color.Transparent
        Me.cmbTerm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerm.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTerm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTerm.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbTerm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTerm.ItemHeight = 30
        Me.cmbTerm.Items.AddRange(New Object() {"Term 1", "Term 2", "Term 3", "Term 4"})
        Me.cmbTerm.Location = New System.Drawing.Point(209, 269)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(136, 36)
        Me.cmbTerm.TabIndex = 57
        Me.cmbTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(124, 208)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(44, 19)
        Me.lblClass.TabIndex = 50
        Me.lblClass.Text = "Class :"
        '
        'lblTerm
        '
        Me.lblTerm.BackColor = System.Drawing.Color.Transparent
        Me.lblTerm.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm.Location = New System.Drawing.Point(127, 278)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(41, 19)
        Me.lblTerm.TabIndex = 56
        Me.lblTerm.Text = "Term :"
        '
        'cmbClass
        '
        Me.cmbClass.BackColor = System.Drawing.Color.Transparent
        Me.cmbClass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbClass.ItemHeight = 30
        Me.cmbClass.Location = New System.Drawing.Point(211, 198)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbClass.TabIndex = 51
        Me.cmbClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtePickerDate
        '
        Me.dtePickerDate.Checked = True
        Me.dtePickerDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePickerDate.FillColor = System.Drawing.Color.RoyalBlue
        Me.dtePickerDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePickerDate.ForeColor = System.Drawing.Color.White
        Me.dtePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtePickerDate.Location = New System.Drawing.Point(209, 128)
        Me.dtePickerDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtePickerDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtePickerDate.Name = "dtePickerDate"
        Me.dtePickerDate.Size = New System.Drawing.Size(266, 35)
        Me.dtePickerDate.TabIndex = 55
        Me.dtePickerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtePickerDate.Value = New Date(2024, 7, 21, 0, 0, 0, 0)
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
        Me.btnValidateAndFinalise.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnValidateAndFinalise.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateAndFinalise.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateAndFinalise.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateAndFinalise.ForeColor = System.Drawing.Color.White
        Me.btnValidateAndFinalise.Location = New System.Drawing.Point(0, 475)
        Me.btnValidateAndFinalise.Name = "btnValidateAndFinalise"
        Me.btnValidateAndFinalise.Size = New System.Drawing.Size(576, 39)
        Me.btnValidateAndFinalise.TabIndex = 49
        Me.btnValidateAndFinalise.Text = "Validate and Finalise"
        '
        'FrmRegisterSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 514)
        Me.Controls.Add(Me.pnlMainControls)
        Me.Controls.Add(Me.btnValidateAndFinalise)
        Me.Controls.Add(Me.pnlTopBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegisterSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterations"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlMainControls.ResumeLayout(False)
        Me.pnlSchoolDetails.ResumeLayout(False)
        Me.pnlSchoolDetails.PerformLayout()
        Me.pnlUserAccounts.ResumeLayout(False)
        Me.pnlUserAccounts.PerformLayout()
        Me.pnlInvoicingStudents.ResumeLayout(False)
        Me.pnlInvoicingStudents.PerformLayout()
        Me.pnlRegisterFilters.ResumeLayout(False)
        Me.pnlRegisterFilters.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblHeading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMainControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmbClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblClass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnValidateAndFinalise As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents dtePickerDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbTerm As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblTerm As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlRegisterFilters As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlInvoicingStudents As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmbBoxPaymentType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPaymentType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDocNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDocNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxReportBook As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtReportBook As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReportBook As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxCurrency As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCurrency As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtMiscellaneous As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiscellaneousCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMiscellaneous As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbTextBooks As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtTextbooksCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTextbooksAndSupplys As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbUniform As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtUniformCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUniform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtClassCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbBoxTransport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtTransportCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTransportCost As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblInvClass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalFees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFees As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlUserAccounts As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cmbAccountType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAccountType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnlSchoolDetails As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtSchoolName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSlogan As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtBubText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchoolContacts As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtContacts As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchoolName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBankDetails As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtBankingDetails As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchoolEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
