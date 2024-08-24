<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnrollment
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
        Me.openingTranstionEnrollment = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lblHeadingOne = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlDock = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlPayments = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmbBoxPaymentType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPaymentType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDocNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDocNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxReportBook = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtReportBook = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblReportBook = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chkBoxPaymentsNotApplicable = New Guna.UI2.WinForms.Guna2CheckBox()
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
        Me.lblClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTotalFees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFees = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateAndFinalise = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlMedicals = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtDisabilities = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDisabilities = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateMedicals = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.chkBoxMedicalsNotApplicable = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtPhysicianContacts = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhysicianContacts = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPhysician = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhysician = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSchedule = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchedule = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDosage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDosage = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtMedications = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMedications = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtRequiredTreatment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRequiredTreament = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAllegies = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAllegies = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlGuardians = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.chkBoxGuardiansNotApplicable = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnCopyAddress = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCopySurname = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtGEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGEmailAdress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtGPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGPhoneNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxTitle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtGAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtGSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGSurname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtGName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateGuardians = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlSubjects = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cntrlCtrlSelection = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.lblSelection = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAdd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListBoxSubjects = New System.Windows.Forms.ListBox()
        Me.lblArrow = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateSubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlStudent = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.chkBoxStudentNotApplicable = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnValidateStudentDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEmailAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPhoneNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPhoneNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtBirthIDNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBirthIDNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtePickerDateOfBirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblDOB = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSurname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnStudentDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuardian = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPayments = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMedicals = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.pnlDock.SuspendLayout()
        Me.pnlPayments.SuspendLayout()
        Me.pnlMedicals.SuspendLayout()
        Me.pnlGuardians.SuspendLayout()
        Me.pnlSubjects.SuspendLayout()
        Me.pnlStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'openingTranstionEnrollment
        '
        Me.openingTranstionEnrollment.AnimateWindow = True
        Me.openingTranstionEnrollment.BorderRadius = 15
        Me.openingTranstionEnrollment.ContainerControl = Me
        Me.openingTranstionEnrollment.DockIndicatorTransparencyValue = 0.6R
        Me.openingTranstionEnrollment.ResizeForm = False
        Me.openingTranstionEnrollment.TransparentWhileDrag = True
        '
        'lblHeadingOne
        '
        Me.lblHeadingOne.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingOne.Font = New System.Drawing.Font("Century Gothic", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingOne.Location = New System.Drawing.Point(21, 16)
        Me.lblHeadingOne.Name = "lblHeadingOne"
        Me.lblHeadingOne.Size = New System.Drawing.Size(309, 39)
        Me.lblHeadingOne.TabIndex = 5
        Me.lblHeadingOne.Text = "Enroll a New Student"
        Me.lblHeadingOne.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlDock
        '
        Me.pnlDock.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlDock.Controls.Add(Me.pnlPayments)
        Me.pnlDock.Controls.Add(Me.pnlMedicals)
        Me.pnlDock.Controls.Add(Me.pnlGuardians)
        Me.pnlDock.Controls.Add(Me.pnlSubjects)
        Me.pnlDock.Controls.Add(Me.pnlStudent)
        Me.pnlDock.Location = New System.Drawing.Point(134, 80)
        Me.pnlDock.Name = "pnlDock"
        Me.pnlDock.ShadowDecoration.Depth = 8
        Me.pnlDock.ShadowDecoration.Enabled = True
        Me.pnlDock.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.pnlDock.Size = New System.Drawing.Size(657, 475)
        Me.pnlDock.TabIndex = 6
        '
        'pnlPayments
        '
        Me.pnlPayments.Controls.Add(Me.cmbBoxPaymentType)
        Me.pnlPayments.Controls.Add(Me.lblPaymentType)
        Me.pnlPayments.Controls.Add(Me.txtDocNumber)
        Me.pnlPayments.Controls.Add(Me.lblDocNumber)
        Me.pnlPayments.Controls.Add(Me.cmbBoxReportBook)
        Me.pnlPayments.Controls.Add(Me.txtReportBook)
        Me.pnlPayments.Controls.Add(Me.lblReportBook)
        Me.pnlPayments.Controls.Add(Me.chkBoxPaymentsNotApplicable)
        Me.pnlPayments.Controls.Add(Me.cmbBoxCurrency)
        Me.pnlPayments.Controls.Add(Me.lblCurrency)
        Me.pnlPayments.Controls.Add(Me.txtMiscellaneous)
        Me.pnlPayments.Controls.Add(Me.txtMiscellaneousCost)
        Me.pnlPayments.Controls.Add(Me.lblMiscellaneous)
        Me.pnlPayments.Controls.Add(Me.cmbTextBooks)
        Me.pnlPayments.Controls.Add(Me.txtTextbooksCost)
        Me.pnlPayments.Controls.Add(Me.lblTextbooksAndSupplys)
        Me.pnlPayments.Controls.Add(Me.cmbUniform)
        Me.pnlPayments.Controls.Add(Me.txtUniformCost)
        Me.pnlPayments.Controls.Add(Me.lblUniform)
        Me.pnlPayments.Controls.Add(Me.txtClassCost)
        Me.pnlPayments.Controls.Add(Me.cmbBoxTransport)
        Me.pnlPayments.Controls.Add(Me.txtTransportCost)
        Me.pnlPayments.Controls.Add(Me.lblTransportCost)
        Me.pnlPayments.Controls.Add(Me.cmbBoxClass)
        Me.pnlPayments.Controls.Add(Me.lblClass)
        Me.pnlPayments.Controls.Add(Me.txtTotalFees)
        Me.pnlPayments.Controls.Add(Me.lblFees)
        Me.pnlPayments.Controls.Add(Me.btnValidateAndFinalise)
        Me.pnlPayments.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPayments.Location = New System.Drawing.Point(0, 40)
        Me.pnlPayments.Name = "pnlPayments"
        Me.pnlPayments.Size = New System.Drawing.Size(657, 435)
        Me.pnlPayments.TabIndex = 3
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
        Me.cmbBoxPaymentType.Location = New System.Drawing.Point(230, 292)
        Me.cmbBoxPaymentType.Name = "cmbBoxPaymentType"
        Me.cmbBoxPaymentType.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxPaymentType.TabIndex = 60
        '
        'lblPaymentType
        '
        Me.lblPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(29, 300)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(100, 19)
        Me.lblPaymentType.TabIndex = 59
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
        Me.txtDocNumber.Location = New System.Drawing.Point(230, 380)
        Me.txtDocNumber.Name = "txtDocNumber"
        Me.txtDocNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocNumber.PlaceholderText = ""
        Me.txtDocNumber.SelectedText = ""
        Me.txtDocNumber.Size = New System.Drawing.Size(136, 30)
        Me.txtDocNumber.TabIndex = 58
        Me.txtDocNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDocNumber
        '
        Me.lblDocNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblDocNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNumber.Location = New System.Drawing.Point(35, 380)
        Me.lblDocNumber.Name = "lblDocNumber"
        Me.lblDocNumber.Size = New System.Drawing.Size(94, 19)
        Me.lblDocNumber.TabIndex = 57
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
        Me.cmbBoxReportBook.Items.AddRange(New Object() {"Once off", "Per month", "Per term", "Per year", "n/a"})
        Me.cmbBoxReportBook.Location = New System.Drawing.Point(230, 166)
        Me.cmbBoxReportBook.Name = "cmbBoxReportBook"
        Me.cmbBoxReportBook.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxReportBook.TabIndex = 56
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
        Me.txtReportBook.Location = New System.Drawing.Point(406, 166)
        Me.txtReportBook.Name = "txtReportBook"
        Me.txtReportBook.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReportBook.PlaceholderText = ""
        Me.txtReportBook.ReadOnly = True
        Me.txtReportBook.SelectedText = ""
        Me.txtReportBook.Size = New System.Drawing.Size(67, 30)
        Me.txtReportBook.TabIndex = 55
        Me.txtReportBook.Tag = "Report book cost"
        '
        'lblReportBook
        '
        Me.lblReportBook.BackColor = System.Drawing.Color.Transparent
        Me.lblReportBook.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportBook.Location = New System.Drawing.Point(39, 177)
        Me.lblReportBook.Name = "lblReportBook"
        Me.lblReportBook.Size = New System.Drawing.Size(90, 19)
        Me.lblReportBook.TabIndex = 54
        Me.lblReportBook.Text = "Report Book  :"
        '
        'chkBoxPaymentsNotApplicable
        '
        Me.chkBoxPaymentsNotApplicable.Animated = True
        Me.chkBoxPaymentsNotApplicable.AutoSize = True
        Me.chkBoxPaymentsNotApplicable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxPaymentsNotApplicable.CheckedState.BorderRadius = 0
        Me.chkBoxPaymentsNotApplicable.CheckedState.BorderThickness = 0
        Me.chkBoxPaymentsNotApplicable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxPaymentsNotApplicable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxPaymentsNotApplicable.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.chkBoxPaymentsNotApplicable.Location = New System.Drawing.Point(486, 6)
        Me.chkBoxPaymentsNotApplicable.Name = "chkBoxPaymentsNotApplicable"
        Me.chkBoxPaymentsNotApplicable.Size = New System.Drawing.Size(165, 20)
        Me.chkBoxPaymentsNotApplicable.TabIndex = 53
        Me.chkBoxPaymentsNotApplicable.Text = "Mark empty fields as n/a?"
        Me.chkBoxPaymentsNotApplicable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkBoxPaymentsNotApplicable.UncheckedState.BorderRadius = 0
        Me.chkBoxPaymentsNotApplicable.UncheckedState.BorderThickness = 0
        Me.chkBoxPaymentsNotApplicable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        Me.cmbBoxCurrency.Location = New System.Drawing.Point(230, 336)
        Me.cmbBoxCurrency.Name = "cmbBoxCurrency"
        Me.cmbBoxCurrency.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxCurrency.TabIndex = 52
        Me.cmbBoxCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.Location = New System.Drawing.Point(61, 342)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(68, 19)
        Me.lblCurrency.TabIndex = 51
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
        Me.txtMiscellaneous.Location = New System.Drawing.Point(230, 254)
        Me.txtMiscellaneous.Name = "txtMiscellaneous"
        Me.txtMiscellaneous.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiscellaneous.PlaceholderText = ""
        Me.txtMiscellaneous.SelectedText = ""
        Me.txtMiscellaneous.Size = New System.Drawing.Size(136, 30)
        Me.txtMiscellaneous.TabIndex = 48
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
        Me.txtMiscellaneousCost.Location = New System.Drawing.Point(406, 250)
        Me.txtMiscellaneousCost.Name = "txtMiscellaneousCost"
        Me.txtMiscellaneousCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiscellaneousCost.PlaceholderText = ""
        Me.txtMiscellaneousCost.SelectedText = ""
        Me.txtMiscellaneousCost.Size = New System.Drawing.Size(67, 30)
        Me.txtMiscellaneousCost.TabIndex = 47
        '
        'lblMiscellaneous
        '
        Me.lblMiscellaneous.BackColor = System.Drawing.Color.Transparent
        Me.lblMiscellaneous.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscellaneous.Location = New System.Drawing.Point(30, 261)
        Me.lblMiscellaneous.Name = "lblMiscellaneous"
        Me.lblMiscellaneous.Size = New System.Drawing.Size(99, 19)
        Me.lblMiscellaneous.TabIndex = 46
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
        Me.cmbTextBooks.Items.AddRange(New Object() {"Once off", "Per month", "Per term", "Per year", "n/a"})
        Me.cmbTextBooks.Location = New System.Drawing.Point(230, 210)
        Me.cmbTextBooks.Name = "cmbTextBooks"
        Me.cmbTextBooks.Size = New System.Drawing.Size(136, 36)
        Me.cmbTextBooks.TabIndex = 45
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
        Me.txtTextbooksCost.Location = New System.Drawing.Point(406, 208)
        Me.txtTextbooksCost.Name = "txtTextbooksCost"
        Me.txtTextbooksCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTextbooksCost.PlaceholderText = ""
        Me.txtTextbooksCost.ReadOnly = True
        Me.txtTextbooksCost.SelectedText = ""
        Me.txtTextbooksCost.Size = New System.Drawing.Size(67, 30)
        Me.txtTextbooksCost.TabIndex = 44
        Me.txtTextbooksCost.Tag = "Textbooks cost"
        '
        'lblTextbooksAndSupplys
        '
        Me.lblTextbooksAndSupplys.BackColor = System.Drawing.Color.Transparent
        Me.lblTextbooksAndSupplys.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextbooksAndSupplys.Location = New System.Drawing.Point(55, 219)
        Me.lblTextbooksAndSupplys.Name = "lblTextbooksAndSupplys"
        Me.lblTextbooksAndSupplys.Size = New System.Drawing.Size(74, 19)
        Me.lblTextbooksAndSupplys.TabIndex = 43
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
        Me.cmbUniform.Items.AddRange(New Object() {"Once off", "Per month", "Per term", "Per year", "n/a"})
        Me.cmbUniform.Location = New System.Drawing.Point(230, 122)
        Me.cmbUniform.Name = "cmbUniform"
        Me.cmbUniform.Size = New System.Drawing.Size(136, 36)
        Me.cmbUniform.TabIndex = 42
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
        Me.txtUniformCost.Location = New System.Drawing.Point(406, 124)
        Me.txtUniformCost.Name = "txtUniformCost"
        Me.txtUniformCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUniformCost.PlaceholderText = ""
        Me.txtUniformCost.ReadOnly = True
        Me.txtUniformCost.SelectedText = ""
        Me.txtUniformCost.Size = New System.Drawing.Size(67, 30)
        Me.txtUniformCost.TabIndex = 41
        Me.txtUniformCost.Tag = "Uniform Cost"
        '
        'lblUniform
        '
        Me.lblUniform.BackColor = System.Drawing.Color.Transparent
        Me.lblUniform.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniform.Location = New System.Drawing.Point(69, 135)
        Me.lblUniform.Name = "lblUniform"
        Me.lblUniform.Size = New System.Drawing.Size(60, 19)
        Me.lblUniform.TabIndex = 40
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
        Me.txtClassCost.Location = New System.Drawing.Point(406, 40)
        Me.txtClassCost.Name = "txtClassCost"
        Me.txtClassCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClassCost.PlaceholderText = ""
        Me.txtClassCost.ReadOnly = True
        Me.txtClassCost.SelectedText = ""
        Me.txtClassCost.Size = New System.Drawing.Size(67, 30)
        Me.txtClassCost.TabIndex = 39
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
        Me.cmbBoxTransport.Items.AddRange(New Object() {"Once off", "Per month", "Per term", "Per year", "n/a"})
        Me.cmbBoxTransport.Location = New System.Drawing.Point(230, 78)
        Me.cmbBoxTransport.Name = "cmbBoxTransport"
        Me.cmbBoxTransport.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxTransport.TabIndex = 38
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
        Me.txtTransportCost.Location = New System.Drawing.Point(406, 82)
        Me.txtTransportCost.Name = "txtTransportCost"
        Me.txtTransportCost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTransportCost.PlaceholderText = ""
        Me.txtTransportCost.ReadOnly = True
        Me.txtTransportCost.SelectedText = ""
        Me.txtTransportCost.Size = New System.Drawing.Size(67, 30)
        Me.txtTransportCost.TabIndex = 37
        Me.txtTransportCost.Tag = "Transport Cost"
        '
        'lblTransportCost
        '
        Me.lblTransportCost.BackColor = System.Drawing.Color.Transparent
        Me.lblTransportCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransportCost.Location = New System.Drawing.Point(11, 93)
        Me.lblTransportCost.Name = "lblTransportCost"
        Me.lblTransportCost.Size = New System.Drawing.Size(118, 19)
        Me.lblTransportCost.TabIndex = 36
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
        Me.cmbBoxClass.Location = New System.Drawing.Point(230, 34)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxClass.TabIndex = 35
        Me.cmbBoxClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(85, 51)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(44, 19)
        Me.lblClass.TabIndex = 34
        Me.lblClass.Text = "Class :"
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
        Me.txtTotalFees.Location = New System.Drawing.Point(452, 362)
        Me.txtTotalFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalFees.PlaceholderText = ""
        Me.txtTotalFees.ReadOnly = True
        Me.txtTotalFees.SelectedText = ""
        Me.txtTotalFees.Size = New System.Drawing.Size(198, 47)
        Me.txtTotalFees.TabIndex = 33
        Me.txtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFees
        '
        Me.lblFees.BackColor = System.Drawing.Color.Transparent
        Me.lblFees.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblFees.Location = New System.Drawing.Point(510, 330)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(78, 20)
        Me.lblFees.TabIndex = 32
        Me.lblFees.Text = "Total Fees"
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
        'pnlMedicals
        '
        Me.pnlMedicals.Controls.Add(Me.txtDisabilities)
        Me.pnlMedicals.Controls.Add(Me.lblDisabilities)
        Me.pnlMedicals.Controls.Add(Me.btnValidateMedicals)
        Me.pnlMedicals.Controls.Add(Me.chkBoxMedicalsNotApplicable)
        Me.pnlMedicals.Controls.Add(Me.txtPhysicianContacts)
        Me.pnlMedicals.Controls.Add(Me.lblPhysicianContacts)
        Me.pnlMedicals.Controls.Add(Me.txtPhysician)
        Me.pnlMedicals.Controls.Add(Me.lblPhysician)
        Me.pnlMedicals.Controls.Add(Me.txtSchedule)
        Me.pnlMedicals.Controls.Add(Me.lblSchedule)
        Me.pnlMedicals.Controls.Add(Me.txtDosage)
        Me.pnlMedicals.Controls.Add(Me.lblDosage)
        Me.pnlMedicals.Controls.Add(Me.txtMedications)
        Me.pnlMedicals.Controls.Add(Me.lblMedications)
        Me.pnlMedicals.Controls.Add(Me.txtRequiredTreatment)
        Me.pnlMedicals.Controls.Add(Me.lblRequiredTreament)
        Me.pnlMedicals.Controls.Add(Me.txtAllegies)
        Me.pnlMedicals.Controls.Add(Me.lblAllegies)
        Me.pnlMedicals.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMedicals.Location = New System.Drawing.Point(0, 30)
        Me.pnlMedicals.Name = "pnlMedicals"
        Me.pnlMedicals.Size = New System.Drawing.Size(657, 10)
        Me.pnlMedicals.TabIndex = 49
        '
        'txtDisabilities
        '
        Me.txtDisabilities.Animated = True
        Me.txtDisabilities.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDisabilities.DefaultText = ""
        Me.txtDisabilities.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDisabilities.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDisabilities.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDisabilities.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDisabilities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDisabilities.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisabilities.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDisabilities.Location = New System.Drawing.Point(247, 292)
        Me.txtDisabilities.Name = "txtDisabilities"
        Me.txtDisabilities.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDisabilities.PlaceholderText = ""
        Me.txtDisabilities.SelectedText = ""
        Me.txtDisabilities.Size = New System.Drawing.Size(345, 30)
        Me.txtDisabilities.TabIndex = 57
        '
        'lblDisabilities
        '
        Me.lblDisabilities.BackColor = System.Drawing.Color.Transparent
        Me.lblDisabilities.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisabilities.Location = New System.Drawing.Point(69, 303)
        Me.lblDisabilities.Name = "lblDisabilities"
        Me.lblDisabilities.Size = New System.Drawing.Size(77, 19)
        Me.lblDisabilities.TabIndex = 56
        Me.lblDisabilities.Text = "Disabilities :"
        '
        'btnValidateMedicals
        '
        Me.btnValidateMedicals.Animated = True
        Me.btnValidateMedicals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateMedicals.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateMedicals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateMedicals.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateMedicals.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateMedicals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateMedicals.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateMedicals.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateMedicals.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateMedicals.ForeColor = System.Drawing.Color.White
        Me.btnValidateMedicals.Location = New System.Drawing.Point(500, 423)
        Me.btnValidateMedicals.Name = "btnValidateMedicals"
        Me.btnValidateMedicals.Size = New System.Drawing.Size(150, 45)
        Me.btnValidateMedicals.TabIndex = 55
        Me.btnValidateMedicals.Text = "Validate"
        '
        'chkBoxMedicalsNotApplicable
        '
        Me.chkBoxMedicalsNotApplicable.Animated = True
        Me.chkBoxMedicalsNotApplicable.AutoSize = True
        Me.chkBoxMedicalsNotApplicable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxMedicalsNotApplicable.CheckedState.BorderRadius = 0
        Me.chkBoxMedicalsNotApplicable.CheckedState.BorderThickness = 0
        Me.chkBoxMedicalsNotApplicable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxMedicalsNotApplicable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxMedicalsNotApplicable.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.chkBoxMedicalsNotApplicable.Location = New System.Drawing.Point(485, 7)
        Me.chkBoxMedicalsNotApplicable.Name = "chkBoxMedicalsNotApplicable"
        Me.chkBoxMedicalsNotApplicable.Size = New System.Drawing.Size(165, 20)
        Me.chkBoxMedicalsNotApplicable.TabIndex = 54
        Me.chkBoxMedicalsNotApplicable.Text = "Mark empty fields as n/a?"
        Me.chkBoxMedicalsNotApplicable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkBoxMedicalsNotApplicable.UncheckedState.BorderRadius = 0
        Me.chkBoxMedicalsNotApplicable.UncheckedState.BorderThickness = 0
        Me.chkBoxMedicalsNotApplicable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'txtPhysicianContacts
        '
        Me.txtPhysicianContacts.Animated = True
        Me.txtPhysicianContacts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhysicianContacts.DefaultText = ""
        Me.txtPhysicianContacts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhysicianContacts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhysicianContacts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhysicianContacts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhysicianContacts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhysicianContacts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicianContacts.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhysicianContacts.Location = New System.Drawing.Point(247, 364)
        Me.txtPhysicianContacts.Name = "txtPhysicianContacts"
        Me.txtPhysicianContacts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhysicianContacts.PlaceholderText = ""
        Me.txtPhysicianContacts.SelectedText = ""
        Me.txtPhysicianContacts.Size = New System.Drawing.Size(345, 30)
        Me.txtPhysicianContacts.TabIndex = 53
        '
        'lblPhysicianContacts
        '
        Me.lblPhysicianContacts.BackColor = System.Drawing.Color.Transparent
        Me.lblPhysicianContacts.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicianContacts.Location = New System.Drawing.Point(75, 375)
        Me.lblPhysicianContacts.Name = "lblPhysicianContacts"
        Me.lblPhysicianContacts.Size = New System.Drawing.Size(71, 19)
        Me.lblPhysicianContacts.TabIndex = 52
        Me.lblPhysicianContacts.Text = "Contacts :"
        '
        'txtPhysician
        '
        Me.txtPhysician.Animated = True
        Me.txtPhysician.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhysician.DefaultText = ""
        Me.txtPhysician.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhysician.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhysician.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhysician.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhysician.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhysician.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysician.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhysician.Location = New System.Drawing.Point(247, 328)
        Me.txtPhysician.Name = "txtPhysician"
        Me.txtPhysician.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhysician.PlaceholderText = ""
        Me.txtPhysician.SelectedText = ""
        Me.txtPhysician.Size = New System.Drawing.Size(345, 30)
        Me.txtPhysician.TabIndex = 51
        '
        'lblPhysician
        '
        Me.lblPhysician.BackColor = System.Drawing.Color.Transparent
        Me.lblPhysician.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysician.Location = New System.Drawing.Point(77, 339)
        Me.lblPhysician.Name = "lblPhysician"
        Me.lblPhysician.Size = New System.Drawing.Size(69, 19)
        Me.lblPhysician.TabIndex = 50
        Me.lblPhysician.Text = "Physician :"
        '
        'txtSchedule
        '
        Me.txtSchedule.Animated = True
        Me.txtSchedule.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchedule.DefaultText = ""
        Me.txtSchedule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchedule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchedule.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchedule.Location = New System.Drawing.Point(247, 220)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchedule.PlaceholderText = ""
        Me.txtSchedule.SelectedText = ""
        Me.txtSchedule.Size = New System.Drawing.Size(345, 30)
        Me.txtSchedule.TabIndex = 49
        '
        'lblSchedule
        '
        Me.lblSchedule.BackColor = System.Drawing.Color.Transparent
        Me.lblSchedule.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(79, 231)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(69, 19)
        Me.lblSchedule.TabIndex = 48
        Me.lblSchedule.Text = "Schedule :"
        '
        'txtDosage
        '
        Me.txtDosage.Animated = True
        Me.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDosage.DefaultText = ""
        Me.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.Location = New System.Drawing.Point(247, 184)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDosage.PlaceholderText = ""
        Me.txtDosage.SelectedText = ""
        Me.txtDosage.Size = New System.Drawing.Size(345, 30)
        Me.txtDosage.TabIndex = 47
        '
        'lblDosage
        '
        Me.lblDosage.BackColor = System.Drawing.Color.Transparent
        Me.lblDosage.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosage.Location = New System.Drawing.Point(85, 195)
        Me.lblDosage.Name = "lblDosage"
        Me.lblDosage.Size = New System.Drawing.Size(61, 19)
        Me.lblDosage.TabIndex = 46
        Me.lblDosage.Text = "Dosage :"
        '
        'txtMedications
        '
        Me.txtMedications.Animated = True
        Me.txtMedications.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedications.DefaultText = ""
        Me.txtMedications.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedications.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedications.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedications.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedications.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedications.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedications.Location = New System.Drawing.Point(247, 148)
        Me.txtMedications.Name = "txtMedications"
        Me.txtMedications.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedications.PlaceholderText = ""
        Me.txtMedications.SelectedText = ""
        Me.txtMedications.Size = New System.Drawing.Size(345, 30)
        Me.txtMedications.TabIndex = 45
        '
        'lblMedications
        '
        Me.lblMedications.BackColor = System.Drawing.Color.Transparent
        Me.lblMedications.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedications.Location = New System.Drawing.Point(59, 159)
        Me.lblMedications.Name = "lblMedications"
        Me.lblMedications.Size = New System.Drawing.Size(89, 19)
        Me.lblMedications.TabIndex = 44
        Me.lblMedications.Text = "Medications :"
        '
        'txtRequiredTreatment
        '
        Me.txtRequiredTreatment.Animated = True
        Me.txtRequiredTreatment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRequiredTreatment.DefaultText = ""
        Me.txtRequiredTreatment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRequiredTreatment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRequiredTreatment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequiredTreatment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRequiredTreatment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequiredTreatment.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequiredTreatment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRequiredTreatment.Location = New System.Drawing.Point(247, 76)
        Me.txtRequiredTreatment.Name = "txtRequiredTreatment"
        Me.txtRequiredTreatment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRequiredTreatment.PlaceholderText = ""
        Me.txtRequiredTreatment.SelectedText = ""
        Me.txtRequiredTreatment.Size = New System.Drawing.Size(345, 30)
        Me.txtRequiredTreatment.TabIndex = 43
        '
        'lblRequiredTreament
        '
        Me.lblRequiredTreament.BackColor = System.Drawing.Color.Transparent
        Me.lblRequiredTreament.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequiredTreament.Location = New System.Drawing.Point(15, 87)
        Me.lblRequiredTreament.Name = "lblRequiredTreament"
        Me.lblRequiredTreament.Size = New System.Drawing.Size(137, 19)
        Me.lblRequiredTreament.TabIndex = 42
        Me.lblRequiredTreament.Text = "Required treatment :"
        '
        'txtAllegies
        '
        Me.txtAllegies.Animated = True
        Me.txtAllegies.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAllegies.DefaultText = ""
        Me.txtAllegies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAllegies.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAllegies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAllegies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAllegies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAllegies.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllegies.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAllegies.Location = New System.Drawing.Point(247, 40)
        Me.txtAllegies.Name = "txtAllegies"
        Me.txtAllegies.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAllegies.PlaceholderText = ""
        Me.txtAllegies.SelectedText = ""
        Me.txtAllegies.Size = New System.Drawing.Size(345, 30)
        Me.txtAllegies.TabIndex = 41
        '
        'lblAllegies
        '
        Me.lblAllegies.BackColor = System.Drawing.Color.Transparent
        Me.lblAllegies.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllegies.Location = New System.Drawing.Point(93, 51)
        Me.lblAllegies.Name = "lblAllegies"
        Me.lblAllegies.Size = New System.Drawing.Size(59, 19)
        Me.lblAllegies.TabIndex = 40
        Me.lblAllegies.Text = "Allegies :"
        '
        'pnlGuardians
        '
        Me.pnlGuardians.Controls.Add(Me.chkBoxGuardiansNotApplicable)
        Me.pnlGuardians.Controls.Add(Me.btnCopyAddress)
        Me.pnlGuardians.Controls.Add(Me.btnCopySurname)
        Me.pnlGuardians.Controls.Add(Me.txtGEmailAddress)
        Me.pnlGuardians.Controls.Add(Me.lblGEmailAdress)
        Me.pnlGuardians.Controls.Add(Me.txtGPhoneNumber)
        Me.pnlGuardians.Controls.Add(Me.lblGPhoneNumber)
        Me.pnlGuardians.Controls.Add(Me.cmbBoxTitle)
        Me.pnlGuardians.Controls.Add(Me.txtGAddress)
        Me.pnlGuardians.Controls.Add(Me.lblGAddress)
        Me.pnlGuardians.Controls.Add(Me.lblGTitle)
        Me.pnlGuardians.Controls.Add(Me.txtGSurname)
        Me.pnlGuardians.Controls.Add(Me.lblGSurname)
        Me.pnlGuardians.Controls.Add(Me.txtGName)
        Me.pnlGuardians.Controls.Add(Me.lblGName)
        Me.pnlGuardians.Controls.Add(Me.btnValidateGuardians)
        Me.pnlGuardians.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGuardians.Location = New System.Drawing.Point(0, 20)
        Me.pnlGuardians.Name = "pnlGuardians"
        Me.pnlGuardians.Size = New System.Drawing.Size(657, 10)
        Me.pnlGuardians.TabIndex = 2
        '
        'chkBoxGuardiansNotApplicable
        '
        Me.chkBoxGuardiansNotApplicable.Animated = True
        Me.chkBoxGuardiansNotApplicable.AutoSize = True
        Me.chkBoxGuardiansNotApplicable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxGuardiansNotApplicable.CheckedState.BorderRadius = 0
        Me.chkBoxGuardiansNotApplicable.CheckedState.BorderThickness = 0
        Me.chkBoxGuardiansNotApplicable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxGuardiansNotApplicable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxGuardiansNotApplicable.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.chkBoxGuardiansNotApplicable.Location = New System.Drawing.Point(485, 9)
        Me.chkBoxGuardiansNotApplicable.Name = "chkBoxGuardiansNotApplicable"
        Me.chkBoxGuardiansNotApplicable.Size = New System.Drawing.Size(165, 20)
        Me.chkBoxGuardiansNotApplicable.TabIndex = 33
        Me.chkBoxGuardiansNotApplicable.Text = "Mark empty fields as n/a?"
        Me.chkBoxGuardiansNotApplicable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkBoxGuardiansNotApplicable.UncheckedState.BorderRadius = 0
        Me.chkBoxGuardiansNotApplicable.UncheckedState.BorderThickness = 0
        Me.chkBoxGuardiansNotApplicable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'btnCopyAddress
        '
        Me.btnCopyAddress.Animated = True
        Me.btnCopyAddress.AutoRoundedCorners = True
        Me.btnCopyAddress.BackColor = System.Drawing.Color.Transparent
        Me.btnCopyAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnCopyAddress.BorderRadius = 11
        Me.btnCopyAddress.BorderThickness = 1
        Me.btnCopyAddress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopyAddress.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCopyAddress.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCopyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopyAddress.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCopyAddress.FillColor = System.Drawing.Color.Empty
        Me.btnCopyAddress.FillColor2 = System.Drawing.Color.Empty
        Me.btnCopyAddress.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyAddress.ForeColor = System.Drawing.Color.Black
        Me.btnCopyAddress.Location = New System.Drawing.Point(615, 245)
        Me.btnCopyAddress.Name = "btnCopyAddress"
        Me.btnCopyAddress.Size = New System.Drawing.Size(35, 24)
        Me.btnCopyAddress.TabIndex = 32
        Me.btnCopyAddress.Text = "?"
        '
        'btnCopySurname
        '
        Me.btnCopySurname.Animated = True
        Me.btnCopySurname.AutoRoundedCorners = True
        Me.btnCopySurname.BackColor = System.Drawing.Color.Transparent
        Me.btnCopySurname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnCopySurname.BorderRadius = 11
        Me.btnCopySurname.BorderThickness = 1
        Me.btnCopySurname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopySurname.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCopySurname.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCopySurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopySurname.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopySurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCopySurname.FillColor = System.Drawing.Color.Empty
        Me.btnCopySurname.FillColor2 = System.Drawing.Color.Empty
        Me.btnCopySurname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopySurname.ForeColor = System.Drawing.Color.Black
        Me.btnCopySurname.Location = New System.Drawing.Point(425, 178)
        Me.btnCopySurname.Name = "btnCopySurname"
        Me.btnCopySurname.Size = New System.Drawing.Size(35, 24)
        Me.btnCopySurname.TabIndex = 31
        Me.btnCopySurname.Text = "?"
        '
        'txtGEmailAddress
        '
        Me.txtGEmailAddress.Animated = True
        Me.txtGEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGEmailAddress.DefaultText = ""
        Me.txtGEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGEmailAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGEmailAddress.Location = New System.Drawing.Point(238, 376)
        Me.txtGEmailAddress.Name = "txtGEmailAddress"
        Me.txtGEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGEmailAddress.PlaceholderText = "Email address ...."
        Me.txtGEmailAddress.SelectedText = ""
        Me.txtGEmailAddress.Size = New System.Drawing.Size(180, 30)
        Me.txtGEmailAddress.TabIndex = 30
        '
        'lblGEmailAdress
        '
        Me.lblGEmailAdress.BackColor = System.Drawing.Color.Transparent
        Me.lblGEmailAdress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGEmailAdress.Location = New System.Drawing.Point(49, 387)
        Me.lblGEmailAdress.Name = "lblGEmailAdress"
        Me.lblGEmailAdress.Size = New System.Drawing.Size(90, 19)
        Me.lblGEmailAdress.TabIndex = 29
        Me.lblGEmailAdress.Text = "Email Adress :"
        '
        'txtGPhoneNumber
        '
        Me.txtGPhoneNumber.Animated = True
        Me.txtGPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGPhoneNumber.DefaultText = ""
        Me.txtGPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGPhoneNumber.Location = New System.Drawing.Point(238, 309)
        Me.txtGPhoneNumber.Name = "txtGPhoneNumber"
        Me.txtGPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGPhoneNumber.PlaceholderText = "Phone number ...."
        Me.txtGPhoneNumber.SelectedText = ""
        Me.txtGPhoneNumber.Size = New System.Drawing.Size(180, 30)
        Me.txtGPhoneNumber.TabIndex = 28
        '
        'lblGPhoneNumber
        '
        Me.lblGPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblGPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPhoneNumber.Location = New System.Drawing.Point(33, 320)
        Me.lblGPhoneNumber.Name = "lblGPhoneNumber"
        Me.lblGPhoneNumber.Size = New System.Drawing.Size(106, 19)
        Me.lblGPhoneNumber.TabIndex = 27
        Me.lblGPhoneNumber.Text = "Phone number :"
        '
        'cmbBoxTitle
        '
        Me.cmbBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxTitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxTitle.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxTitle.ItemHeight = 30
        Me.cmbBoxTitle.Items.AddRange(New Object() {"Father", "Mother", "Grandmother", "Grandfather", "Uncle", "Aunt", "sister", "Brother", "Other"})
        Me.cmbBoxTitle.Location = New System.Drawing.Point(238, 35)
        Me.cmbBoxTitle.Name = "cmbBoxTitle"
        Me.cmbBoxTitle.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxTitle.TabIndex = 26
        '
        'txtGAddress
        '
        Me.txtGAddress.Animated = True
        Me.txtGAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGAddress.DefaultText = ""
        Me.txtGAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGAddress.Location = New System.Drawing.Point(238, 242)
        Me.txtGAddress.Name = "txtGAddress"
        Me.txtGAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGAddress.PlaceholderText = " Address ...."
        Me.txtGAddress.SelectedText = ""
        Me.txtGAddress.Size = New System.Drawing.Size(371, 30)
        Me.txtGAddress.TabIndex = 25
        '
        'lblGAddress
        '
        Me.lblGAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblGAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGAddress.Location = New System.Drawing.Point(79, 253)
        Me.lblGAddress.Name = "lblGAddress"
        Me.lblGAddress.Size = New System.Drawing.Size(60, 19)
        Me.lblGAddress.TabIndex = 24
        Me.lblGAddress.Text = "Address :"
        '
        'lblGTitle
        '
        Me.lblGTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGTitle.Location = New System.Drawing.Point(102, 52)
        Me.lblGTitle.Name = "lblGTitle"
        Me.lblGTitle.Size = New System.Drawing.Size(35, 19)
        Me.lblGTitle.TabIndex = 22
        Me.lblGTitle.Text = "Title :"
        '
        'txtGSurname
        '
        Me.txtGSurname.Animated = True
        Me.txtGSurname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGSurname.DefaultText = ""
        Me.txtGSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGSurname.Location = New System.Drawing.Point(238, 175)
        Me.txtGSurname.Name = "txtGSurname"
        Me.txtGSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGSurname.PlaceholderText = "Surname ...."
        Me.txtGSurname.SelectedText = ""
        Me.txtGSurname.Size = New System.Drawing.Size(180, 30)
        Me.txtGSurname.TabIndex = 21
        '
        'lblGSurname
        '
        Me.lblGSurname.BackColor = System.Drawing.Color.Transparent
        Me.lblGSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSurname.Location = New System.Drawing.Point(70, 186)
        Me.lblGSurname.Name = "lblGSurname"
        Me.lblGSurname.Size = New System.Drawing.Size(67, 19)
        Me.lblGSurname.TabIndex = 20
        Me.lblGSurname.Text = "Surname  :"
        '
        'txtGName
        '
        Me.txtGName.Animated = True
        Me.txtGName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGName.DefaultText = ""
        Me.txtGName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGName.Location = New System.Drawing.Point(238, 108)
        Me.txtGName.Name = "txtGName"
        Me.txtGName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGName.PlaceholderText = "First name ...."
        Me.txtGName.SelectedText = ""
        Me.txtGName.Size = New System.Drawing.Size(180, 30)
        Me.txtGName.TabIndex = 19
        '
        'lblGName
        '
        Me.lblGName.BackColor = System.Drawing.Color.Transparent
        Me.lblGName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGName.Location = New System.Drawing.Point(68, 119)
        Me.lblGName.Name = "lblGName"
        Me.lblGName.Size = New System.Drawing.Size(69, 19)
        Me.lblGName.TabIndex = 18
        Me.lblGName.Text = "Name (s)  :"
        '
        'btnValidateGuardians
        '
        Me.btnValidateGuardians.Animated = True
        Me.btnValidateGuardians.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateGuardians.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateGuardians.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateGuardians.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateGuardians.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateGuardians.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateGuardians.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateGuardians.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateGuardians.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateGuardians.ForeColor = System.Drawing.Color.White
        Me.btnValidateGuardians.Location = New System.Drawing.Point(500, 423)
        Me.btnValidateGuardians.Name = "btnValidateGuardians"
        Me.btnValidateGuardians.Size = New System.Drawing.Size(150, 45)
        Me.btnValidateGuardians.TabIndex = 17
        Me.btnValidateGuardians.Text = "Validate"
        '
        'pnlSubjects
        '
        Me.pnlSubjects.Controls.Add(Me.cntrlCtrlSelection)
        Me.pnlSubjects.Controls.Add(Me.lblSelection)
        Me.pnlSubjects.Controls.Add(Me.lblAdd)
        Me.pnlSubjects.Controls.Add(Me.ListBoxSubjects)
        Me.pnlSubjects.Controls.Add(Me.lblArrow)
        Me.pnlSubjects.Controls.Add(Me.btnValidateSubjects)
        Me.pnlSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubjects.Location = New System.Drawing.Point(0, 10)
        Me.pnlSubjects.Name = "pnlSubjects"
        Me.pnlSubjects.Size = New System.Drawing.Size(657, 10)
        Me.pnlSubjects.TabIndex = 1
        '
        'cntrlCtrlSelection
        '
        Me.cntrlCtrlSelection.AutoScroll = True
        Me.cntrlCtrlSelection.BackColor = System.Drawing.Color.Transparent
        Me.cntrlCtrlSelection.FillColor = System.Drawing.Color.Transparent
        Me.cntrlCtrlSelection.Location = New System.Drawing.Point(424, 52)
        Me.cntrlCtrlSelection.Name = "cntrlCtrlSelection"
        Me.cntrlCtrlSelection.Size = New System.Drawing.Size(214, 344)
        Me.cntrlCtrlSelection.TabIndex = 28
        Me.cntrlCtrlSelection.Text = "Guna2ContainerControl"
        Me.cntrlCtrlSelection.UseTransparentBackground = True
        '
        'lblSelection
        '
        Me.lblSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblSelection.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(486, 18)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(97, 26)
        Me.lblSelection.TabIndex = 27
        Me.lblSelection.Text = "Selection"
        Me.lblSelection.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdd
        '
        Me.lblAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblAdd.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(18, 18)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(211, 26)
        Me.lblAdd.TabIndex = 26
        Me.lblAdd.Text = "Double Click to Add"
        Me.lblAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBoxSubjects
        '
        Me.ListBoxSubjects.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.ListBoxSubjects.FormattingEnabled = True
        Me.ListBoxSubjects.ItemHeight = 17
        Me.ListBoxSubjects.Location = New System.Drawing.Point(18, 52)
        Me.ListBoxSubjects.Name = "ListBoxSubjects"
        Me.ListBoxSubjects.Size = New System.Drawing.Size(230, 344)
        Me.ListBoxSubjects.Sorted = True
        Me.ListBoxSubjects.TabIndex = 25
        '
        'lblArrow
        '
        Me.lblArrow.BackColor = System.Drawing.Color.Transparent
        Me.lblArrow.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrow.Location = New System.Drawing.Point(319, 203)
        Me.lblArrow.Name = "lblArrow"
        Me.lblArrow.Size = New System.Drawing.Size(41, 41)
        Me.lblArrow.TabIndex = 24
        Me.lblArrow.Text = "=>"
        '
        'btnValidateSubjects
        '
        Me.btnValidateSubjects.Animated = True
        Me.btnValidateSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateSubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateSubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateSubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateSubjects.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateSubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateSubjects.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateSubjects.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateSubjects.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateSubjects.ForeColor = System.Drawing.Color.White
        Me.btnValidateSubjects.Location = New System.Drawing.Point(500, 423)
        Me.btnValidateSubjects.Name = "btnValidateSubjects"
        Me.btnValidateSubjects.Size = New System.Drawing.Size(150, 45)
        Me.btnValidateSubjects.TabIndex = 16
        Me.btnValidateSubjects.Text = "Validate"
        '
        'pnlStudent
        '
        Me.pnlStudent.Controls.Add(Me.chkBoxStudentNotApplicable)
        Me.pnlStudent.Controls.Add(Me.btnValidateStudentDetails)
        Me.pnlStudent.Controls.Add(Me.txtEmailAddress)
        Me.pnlStudent.Controls.Add(Me.lblEmailAddress)
        Me.pnlStudent.Controls.Add(Me.txtPhoneNumber)
        Me.pnlStudent.Controls.Add(Me.lblPhoneNumber)
        Me.pnlStudent.Controls.Add(Me.txtAddress)
        Me.pnlStudent.Controls.Add(Me.lblAddress)
        Me.pnlStudent.Controls.Add(Me.txtBirthIDNumber)
        Me.pnlStudent.Controls.Add(Me.btnBirthIDNumber)
        Me.pnlStudent.Controls.Add(Me.dtePickerDateOfBirth)
        Me.pnlStudent.Controls.Add(Me.lblDOB)
        Me.pnlStudent.Controls.Add(Me.txtSurname)
        Me.pnlStudent.Controls.Add(Me.lblSurname)
        Me.pnlStudent.Controls.Add(Me.txtFirstName)
        Me.pnlStudent.Controls.Add(Me.lblName)
        Me.pnlStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStudent.Location = New System.Drawing.Point(0, 0)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(657, 10)
        Me.pnlStudent.TabIndex = 0
        '
        'chkBoxStudentNotApplicable
        '
        Me.chkBoxStudentNotApplicable.Animated = True
        Me.chkBoxStudentNotApplicable.AutoSize = True
        Me.chkBoxStudentNotApplicable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxStudentNotApplicable.CheckedState.BorderRadius = 0
        Me.chkBoxStudentNotApplicable.CheckedState.BorderThickness = 0
        Me.chkBoxStudentNotApplicable.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxStudentNotApplicable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxStudentNotApplicable.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.chkBoxStudentNotApplicable.Location = New System.Drawing.Point(485, 7)
        Me.chkBoxStudentNotApplicable.Name = "chkBoxStudentNotApplicable"
        Me.chkBoxStudentNotApplicable.Size = New System.Drawing.Size(165, 20)
        Me.chkBoxStudentNotApplicable.TabIndex = 16
        Me.chkBoxStudentNotApplicable.Text = "Mark empty fields as n/a?"
        Me.chkBoxStudentNotApplicable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkBoxStudentNotApplicable.UncheckedState.BorderRadius = 0
        Me.chkBoxStudentNotApplicable.UncheckedState.BorderThickness = 0
        Me.chkBoxStudentNotApplicable.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'btnValidateStudentDetails
        '
        Me.btnValidateStudentDetails.Animated = True
        Me.btnValidateStudentDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidateStudentDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateStudentDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidateStudentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateStudentDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidateStudentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidateStudentDetails.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidateStudentDetails.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidateStudentDetails.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidateStudentDetails.ForeColor = System.Drawing.Color.White
        Me.btnValidateStudentDetails.Location = New System.Drawing.Point(500, 423)
        Me.btnValidateStudentDetails.Name = "btnValidateStudentDetails"
        Me.btnValidateStudentDetails.Size = New System.Drawing.Size(150, 45)
        Me.btnValidateStudentDetails.TabIndex = 15
        Me.btnValidateStudentDetails.Text = "Validate"
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
        Me.dtePickerDateOfBirth.FillColor = System.Drawing.Color.RoyalBlue
        Me.dtePickerDateOfBirth.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePickerDateOfBirth.ForeColor = System.Drawing.Color.White
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
        'lblDOB
        '
        Me.lblDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblDOB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(46, 160)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(91, 19)
        Me.lblDOB.TabIndex = 5
        Me.lblDOB.Text = "Date of Birth :"
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
        'btnStudentDetails
        '
        Me.btnStudentDetails.Animated = True
        Me.btnStudentDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentDetails.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnStudentDetails.BorderRadius = 10
        Me.btnStudentDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetails.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentDetails.FillColor = System.Drawing.Color.Empty
        Me.btnStudentDetails.FillColor2 = System.Drawing.Color.Empty
        Me.btnStudentDetails.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentDetails.ForeColor = System.Drawing.Color.Black
        Me.btnStudentDetails.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnStudentDetails.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnStudentDetails.Location = New System.Drawing.Point(9, 117)
        Me.btnStudentDetails.Name = "btnStudentDetails"
        Me.btnStudentDetails.ShadowDecoration.BorderRadius = 10
        Me.btnStudentDetails.ShadowDecoration.Depth = 8
        Me.btnStudentDetails.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnStudentDetails.Size = New System.Drawing.Size(120, 45)
        Me.btnStudentDetails.TabIndex = 15
        Me.btnStudentDetails.Text = "Students"
        Me.btnStudentDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentDetails.UseTransparentBackground = True
        '
        'btnSubjects
        '
        Me.btnSubjects.Animated = True
        Me.btnSubjects.BackColor = System.Drawing.Color.Transparent
        Me.btnSubjects.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnSubjects.BorderRadius = 10
        Me.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubjects.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubjects.FillColor = System.Drawing.Color.Empty
        Me.btnSubjects.FillColor2 = System.Drawing.Color.Empty
        Me.btnSubjects.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjects.ForeColor = System.Drawing.Color.Black
        Me.btnSubjects.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnSubjects.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnSubjects.Location = New System.Drawing.Point(9, 183)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.ShadowDecoration.BorderRadius = 10
        Me.btnSubjects.ShadowDecoration.Depth = 8
        Me.btnSubjects.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnSubjects.Size = New System.Drawing.Size(120, 45)
        Me.btnSubjects.TabIndex = 20
        Me.btnSubjects.Text = "Subjects"
        Me.btnSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSubjects.UseTransparentBackground = True
        '
        'btnGuardian
        '
        Me.btnGuardian.Animated = True
        Me.btnGuardian.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardian.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardian.BorderRadius = 10
        Me.btnGuardian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardian.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardian.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardian.FillColor = System.Drawing.Color.Empty
        Me.btnGuardian.FillColor2 = System.Drawing.Color.Empty
        Me.btnGuardian.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardian.ForeColor = System.Drawing.Color.Black
        Me.btnGuardian.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnGuardian.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnGuardian.Location = New System.Drawing.Point(9, 249)
        Me.btnGuardian.Name = "btnGuardian"
        Me.btnGuardian.ShadowDecoration.BorderRadius = 10
        Me.btnGuardian.ShadowDecoration.Depth = 8
        Me.btnGuardian.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnGuardian.Size = New System.Drawing.Size(120, 45)
        Me.btnGuardian.TabIndex = 21
        Me.btnGuardian.Text = "Guardians"
        Me.btnGuardian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGuardian.UseTransparentBackground = True
        '
        'btnPayments
        '
        Me.btnPayments.Animated = True
        Me.btnPayments.BackColor = System.Drawing.Color.Transparent
        Me.btnPayments.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnPayments.BorderRadius = 10
        Me.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayments.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPayments.FillColor = System.Drawing.Color.Empty
        Me.btnPayments.FillColor2 = System.Drawing.Color.Empty
        Me.btnPayments.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.ForeColor = System.Drawing.Color.Black
        Me.btnPayments.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnPayments.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnPayments.Location = New System.Drawing.Point(9, 381)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.ShadowDecoration.BorderRadius = 10
        Me.btnPayments.ShadowDecoration.Depth = 8
        Me.btnPayments.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnPayments.Size = New System.Drawing.Size(120, 45)
        Me.btnPayments.TabIndex = 22
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPayments.UseTransparentBackground = True
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
        Me.btnClose.TabIndex = 24
        '
        'btnMedicals
        '
        Me.btnMedicals.Animated = True
        Me.btnMedicals.BackColor = System.Drawing.Color.Transparent
        Me.btnMedicals.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnMedicals.BorderRadius = 10
        Me.btnMedicals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedicals.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMedicals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMedicals.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMedicals.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMedicals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMedicals.FillColor = System.Drawing.Color.Empty
        Me.btnMedicals.FillColor2 = System.Drawing.Color.Empty
        Me.btnMedicals.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicals.ForeColor = System.Drawing.Color.Black
        Me.btnMedicals.ImageOffset = New System.Drawing.Point(-11, 0)
        Me.btnMedicals.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnMedicals.Location = New System.Drawing.Point(9, 315)
        Me.btnMedicals.Name = "btnMedicals"
        Me.btnMedicals.ShadowDecoration.BorderRadius = 10
        Me.btnMedicals.ShadowDecoration.Depth = 8
        Me.btnMedicals.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 1, 2, 4)
        Me.btnMedicals.Size = New System.Drawing.Size(120, 45)
        Me.btnMedicals.TabIndex = 25
        Me.btnMedicals.Text = "Medicals"
        Me.btnMedicals.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMedicals.UseTransparentBackground = True
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlDock)
        Me.Controls.Add(Me.lblHeadingOne)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnGuardian)
        Me.Controls.Add(Me.btnSubjects)
        Me.Controls.Add(Me.btnStudentDetails)
        Me.Controls.Add(Me.btnMedicals)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEnrollment"
        Me.pnlDock.ResumeLayout(False)
        Me.pnlPayments.ResumeLayout(False)
        Me.pnlPayments.PerformLayout()
        Me.pnlMedicals.ResumeLayout(False)
        Me.pnlMedicals.PerformLayout()
        Me.pnlGuardians.ResumeLayout(False)
        Me.pnlGuardians.PerformLayout()
        Me.pnlSubjects.ResumeLayout(False)
        Me.pnlSubjects.PerformLayout()
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents openingTranstionEnrollment As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblHeadingOne As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlDock As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnStudentDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSubjects As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPayments As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnGuardian As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlStudent As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblSurname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtePickerDateOfBirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblDOB As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBirthIDNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtBirthIDNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmailAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnValidateStudentDetails As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlSubjects As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnValidateSubjects As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblArrow As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ListBoxSubjects As ListBox
    Friend WithEvents lblAdd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cntrlCtrlSelection As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents lblSelection As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlGuardians As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnValidateGuardians As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtGAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtGSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGSurname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtGName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxTitle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtGEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGEmailAdress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtGPhoneNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGPhoneNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCopyAddress As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCopySurname As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlPayments As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtTotalFees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFees As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnValidateAndFinalise As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblClass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnMedicals As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtTransportCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTransportCost As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbUniform As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtUniformCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUniform As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtClassCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbBoxTransport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbTextBooks As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtTextbooksCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTextbooksAndSupplys As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtMiscellaneousCost As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMiscellaneous As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlMedicals As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents chkBoxStudentNotApplicable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chkBoxGuardiansNotApplicable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtAllegies As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAllegies As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtMedications As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMedications As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtRequiredTreatment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRequiredTreament As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPhysician As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPhysician As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSchedule As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchedule As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDosage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDosage As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chkBoxMedicalsNotApplicable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtPhysicianContacts As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPhysicianContacts As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnValidateMedicals As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtDisabilities As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDisabilities As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtMiscellaneous As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkBoxPaymentsNotApplicable As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cmbBoxCurrency As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCurrency As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxReportBook As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtReportBook As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblReportBook As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents txtDocNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDocNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxPaymentType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPaymentType As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
