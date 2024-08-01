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
        Me.cmbBoxClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFees = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateAndFinalise = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlGuardians = New Guna.UI2.WinForms.Guna2GradientPanel()
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
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAdd = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ListBoxSubjects = New System.Windows.Forms.ListBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnValidateSubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlStudent = New Guna.UI2.WinForms.Guna2GradientPanel()
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSurname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnStudentDetails = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSubjects = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuardian = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPayments = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlDock.SuspendLayout()
        Me.pnlPayments.SuspendLayout()
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
        Me.pnlPayments.Controls.Add(Me.cmbBoxClass)
        Me.pnlPayments.Controls.Add(Me.lblClass)
        Me.pnlPayments.Controls.Add(Me.txtFees)
        Me.pnlPayments.Controls.Add(Me.lblFees)
        Me.pnlPayments.Controls.Add(Me.btnValidateAndFinalise)
        Me.pnlPayments.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPayments.Location = New System.Drawing.Point(0, 447)
        Me.pnlPayments.Name = "pnlPayments"
        Me.pnlPayments.Size = New System.Drawing.Size(657, 444)
        Me.pnlPayments.TabIndex = 3
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
        Me.cmbBoxClass.Location = New System.Drawing.Point(238, 43)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxClass.TabIndex = 35
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(93, 60)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(44, 19)
        Me.lblClass.TabIndex = 34
        Me.lblClass.Text = "Class :"
        '
        'txtFees
        '
        Me.txtFees.Animated = True
        Me.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFees.DefaultText = ""
        Me.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFees.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFees.Location = New System.Drawing.Point(238, 124)
        Me.txtFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFees.Name = "txtFees"
        Me.txtFees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFees.PlaceholderText = "Total Fees ...."
        Me.txtFees.SelectedText = ""
        Me.txtFees.Size = New System.Drawing.Size(202, 47)
        Me.txtFees.TabIndex = 33
        '
        'lblFees
        '
        Me.lblFees.BackColor = System.Drawing.Color.Transparent
        Me.lblFees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(66, 149)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(73, 19)
        Me.lblFees.TabIndex = 32
        Me.lblFees.Text = "Total Fees :"
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
        'pnlGuardians
        '
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
        Me.pnlGuardians.Size = New System.Drawing.Size(657, 427)
        Me.pnlGuardians.TabIndex = 2
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
        Me.pnlSubjects.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnlSubjects.Controls.Add(Me.lblAdd)
        Me.pnlSubjects.Controls.Add(Me.ListBoxSubjects)
        Me.pnlSubjects.Controls.Add(Me.Guna2HtmlLabel2)
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
        Me.cntrlCtrlSelection.Location = New System.Drawing.Point(424, 52)
        Me.cntrlCtrlSelection.Name = "cntrlCtrlSelection"
        Me.cntrlCtrlSelection.Size = New System.Drawing.Size(214, 344)
        Me.cntrlCtrlSelection.TabIndex = 28
        Me.cntrlCtrlSelection.Text = "Guna2ContainerControl1"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(486, 18)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(97, 26)
        Me.Guna2HtmlLabel3.TabIndex = 27
        Me.Guna2HtmlLabel3.Text = "Selection"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
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
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(319, 203)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(41, 41)
        Me.Guna2HtmlLabel2.TabIndex = 24
        Me.Guna2HtmlLabel2.Text = "=>"
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
        Me.pnlStudent.Controls.Add(Me.Guna2HtmlLabel1)
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
        Me.btnStudentDetails.Text = "Student"
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
        Me.btnSubjects.Location = New System.Drawing.Point(9, 189)
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
        Me.btnGuardian.Location = New System.Drawing.Point(9, 261)
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
        Me.btnPayments.Location = New System.Drawing.Point(8, 333)
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
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEnrollment"
        Me.pnlDock.ResumeLayout(False)
        Me.pnlPayments.ResumeLayout(False)
        Me.pnlPayments.PerformLayout()
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
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
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
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ListBoxSubjects As ListBox
    Friend WithEvents lblAdd As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cntrlCtrlSelection As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
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
    Friend WithEvents txtFees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFees As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnValidateAndFinalise As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblClass As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
