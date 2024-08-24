<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Me.openingTranstionPayments = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.cmbBoxDocCurrency = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCurrency = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtePickerDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDocName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPayee = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtDocDocNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDocumentNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxDocPaymentType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPaymentType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDocDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblHeadingOne = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDocAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAmount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEffectiveRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'openingTranstionPayments
        '
        Me.openingTranstionPayments.AnimateWindow = True
        Me.openingTranstionPayments.BorderRadius = 15
        Me.openingTranstionPayments.ContainerControl = Me
        Me.openingTranstionPayments.DockIndicatorTransparencyValue = 0.6R
        Me.openingTranstionPayments.ResizeForm = False
        Me.openingTranstionPayments.TransparentWhileDrag = True
        '
        'cmbBoxDocCurrency
        '
        Me.cmbBoxDocCurrency.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxDocCurrency.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxDocCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxDocCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxDocCurrency.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxDocCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxDocCurrency.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxDocCurrency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxDocCurrency.ItemHeight = 30
        Me.cmbBoxDocCurrency.Items.AddRange(New Object() {"USD", "ZIG"})
        Me.cmbBoxDocCurrency.Location = New System.Drawing.Point(243, 464)
        Me.cmbBoxDocCurrency.Name = "cmbBoxDocCurrency"
        Me.cmbBoxDocCurrency.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxDocCurrency.TabIndex = 71
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.Location = New System.Drawing.Point(81, 479)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(68, 19)
        Me.lblCurrency.TabIndex = 70
        Me.lblCurrency.Text = "Currency  :"
        '
        'dtePickerDate
        '
        Me.dtePickerDate.Animated = True
        Me.dtePickerDate.BackColor = System.Drawing.Color.White
        Me.dtePickerDate.Checked = True
        Me.dtePickerDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePickerDate.FillColor = System.Drawing.Color.RoyalBlue
        Me.dtePickerDate.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtePickerDate.ForeColor = System.Drawing.Color.White
        Me.dtePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtePickerDate.Location = New System.Drawing.Point(243, 88)
        Me.dtePickerDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtePickerDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtePickerDate.Name = "dtePickerDate"
        Me.dtePickerDate.Size = New System.Drawing.Size(217, 35)
        Me.dtePickerDate.TabIndex = 68
        Me.dtePickerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtePickerDate.Value = New Date(2024, 7, 21, 0, 0, 0, 0)
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(106, 104)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 19)
        Me.lblDate.TabIndex = 67
        Me.lblDate.Text = "Date :"
        '
        'txtDocName
        '
        Me.txtDocName.Animated = True
        Me.txtDocName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocName.DefaultText = ""
        Me.txtDocName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDocName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDocName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDocName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocName.Location = New System.Drawing.Point(243, 166)
        Me.txtDocName.Name = "txtDocName"
        Me.txtDocName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocName.PlaceholderText = "Name of payee ...."
        Me.txtDocName.SelectedText = ""
        Me.txtDocName.Size = New System.Drawing.Size(217, 30)
        Me.txtDocName.TabIndex = 64
        '
        'lblPayee
        '
        Me.lblPayee.BackColor = System.Drawing.Color.Transparent
        Me.lblPayee.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayee.Location = New System.Drawing.Point(99, 179)
        Me.lblPayee.Name = "lblPayee"
        Me.lblPayee.Size = New System.Drawing.Size(50, 19)
        Me.lblPayee.TabIndex = 63
        Me.lblPayee.Text = "Payee :"
        '
        'btnConfirm
        '
        Me.btnConfirm.Animated = True
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.FillColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(637, 511)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(150, 45)
        Me.btnConfirm.TabIndex = 62
        Me.btnConfirm.Text = "Confirm"
        '
        'txtDocDocNumber
        '
        Me.txtDocDocNumber.Animated = True
        Me.txtDocDocNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocDocNumber.DefaultText = ""
        Me.txtDocDocNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDocDocNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDocDocNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocDocNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocDocNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocDocNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDocDocNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocDocNumber.Location = New System.Drawing.Point(243, 391)
        Me.txtDocDocNumber.Name = "txtDocDocNumber"
        Me.txtDocDocNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocDocNumber.PlaceholderText = "Document Number ...."
        Me.txtDocDocNumber.SelectedText = ""
        Me.txtDocDocNumber.Size = New System.Drawing.Size(217, 30)
        Me.txtDocDocNumber.TabIndex = 61
        '
        'lblDocumentNumber
        '
        Me.lblDocumentNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblDocumentNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentNumber.Location = New System.Drawing.Point(55, 404)
        Me.lblDocumentNumber.Name = "lblDocumentNumber"
        Me.lblDocumentNumber.Size = New System.Drawing.Size(94, 19)
        Me.lblDocumentNumber.TabIndex = 60
        Me.lblDocumentNumber.Text = "Doc Number :"
        '
        'cmbBoxDocPaymentType
        '
        Me.cmbBoxDocPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxDocPaymentType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxDocPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxDocPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxDocPaymentType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxDocPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxDocPaymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxDocPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxDocPaymentType.ItemHeight = 30
        Me.cmbBoxDocPaymentType.Items.AddRange(New Object() {"Cash", "EFT", "Cheque"})
        Me.cmbBoxDocPaymentType.Location = New System.Drawing.Point(243, 312)
        Me.cmbBoxDocPaymentType.Name = "cmbBoxDocPaymentType"
        Me.cmbBoxDocPaymentType.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxDocPaymentType.TabIndex = 59
        '
        'lblPaymentType
        '
        Me.lblPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(49, 329)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(100, 19)
        Me.lblPaymentType.TabIndex = 58
        Me.lblPaymentType.Text = "Payment Type  :"
        '
        'txtDocDescription
        '
        Me.txtDocDescription.Animated = True
        Me.txtDocDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocDescription.DefaultText = ""
        Me.txtDocDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDocDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDocDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocDescription.Location = New System.Drawing.Point(243, 239)
        Me.txtDocDescription.Name = "txtDocDescription"
        Me.txtDocDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocDescription.PlaceholderText = "Description of payment ...."
        Me.txtDocDescription.SelectedText = ""
        Me.txtDocDescription.Size = New System.Drawing.Size(217, 30)
        Me.txtDocDescription.TabIndex = 56
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(66, 254)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 19)
        Me.lblDescription.TabIndex = 55
        Me.lblDescription.Text = "Description  :"
        '
        'lblHeadingOne
        '
        Me.lblHeadingOne.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingOne.Font = New System.Drawing.Font("Century Gothic", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingOne.Location = New System.Drawing.Point(27, 7)
        Me.lblHeadingOne.Name = "lblHeadingOne"
        Me.lblHeadingOne.Size = New System.Drawing.Size(149, 39)
        Me.lblHeadingOne.TabIndex = 53
        Me.lblHeadingOne.Text = "Payments"
        Me.lblHeadingOne.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDocAmount
        '
        Me.txtDocAmount.Animated = True
        Me.txtDocAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDocAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDocAmount.DefaultText = ""
        Me.txtDocAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDocAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDocAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDocAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocAmount.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtDocAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDocAmount.Location = New System.Drawing.Point(637, 391)
        Me.txtDocAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocAmount.Name = "txtDocAmount"
        Me.txtDocAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDocAmount.PlaceholderText = "Amount ...."
        Me.txtDocAmount.SelectedText = ""
        Me.txtDocAmount.Size = New System.Drawing.Size(150, 45)
        Me.txtDocAmount.TabIndex = 52
        Me.txtDocAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(670, 357)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(86, 18)
        Me.lblAmount.TabIndex = 51
        Me.lblAmount.Text = "Amount Paid"
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
        Me.btnClose.Location = New System.Drawing.Point(761, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 39)
        Me.btnClose.TabIndex = 54
        '
        'txtEffectiveRate
        '
        Me.txtEffectiveRate.Animated = True
        Me.txtEffectiveRate.BackColor = System.Drawing.Color.Transparent
        Me.txtEffectiveRate.BorderColor = System.Drawing.Color.LightGray
        Me.txtEffectiveRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEffectiveRate.DefaultText = ""
        Me.txtEffectiveRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEffectiveRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEffectiveRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEffectiveRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEffectiveRate.FillColor = System.Drawing.Color.PowderBlue
        Me.txtEffectiveRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEffectiveRate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtEffectiveRate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtEffectiveRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEffectiveRate.Location = New System.Drawing.Point(560, 6)
        Me.txtEffectiveRate.Name = "txtEffectiveRate"
        Me.txtEffectiveRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEffectiveRate.PlaceholderText = "Effective rate...."
        Me.txtEffectiveRate.ReadOnly = True
        Me.txtEffectiveRate.SelectedText = ""
        Me.txtEffectiveRate.Size = New System.Drawing.Size(195, 31)
        Me.txtEffectiveRate.TabIndex = 72
        Me.txtEffectiveRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.txtEffectiveRate)
        Me.Controls.Add(Me.cmbBoxDocCurrency)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.dtePickerDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDocName)
        Me.Controls.Add(Me.lblPayee)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtDocDocNumber)
        Me.Controls.Add(Me.lblDocumentNumber)
        Me.Controls.Add(Me.cmbBoxDocPaymentType)
        Me.Controls.Add(Me.lblPaymentType)
        Me.Controls.Add(Me.txtDocDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHeadingOne)
        Me.Controls.Add(Me.txtDocAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents openingTranstionPayments As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cmbBoxDocCurrency As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCurrency As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtePickerDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDocName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPayee As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtDocDocNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDocumentNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxDocPaymentType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPaymentType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDocDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHeadingOne As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDocAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAmount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents txtEffectiveRate As Guna.UI2.WinForms.Guna2TextBox
End Class
