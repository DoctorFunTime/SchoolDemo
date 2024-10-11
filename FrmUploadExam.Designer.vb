<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUploadExam
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUploadExam))
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnValidateAndFinalise = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlContainerControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAddStudent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnValidate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.chkBoxContributes = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.dtePickerDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxExamTest = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblExamTest = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbBoxSubject = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblSubject = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFillSpace = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnToggleFilter = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFillSpaceInSpace = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlFillspaceRight = New Guna.UI2.WinForms.Guna2GradientPanel()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlContainerControls.SuspendLayout()
        Me.pnlFillSpace.SuspendLayout()
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
        Me.btnValidateAndFinalise.Location = New System.Drawing.Point(36, 407)
        Me.btnValidateAndFinalise.Name = "btnValidateAndFinalise"
        Me.btnValidateAndFinalise.Size = New System.Drawing.Size(730, 43)
        Me.btnValidateAndFinalise.TabIndex = 65
        Me.btnValidateAndFinalise.Text = "Validate and Finalise"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.ColumnHeadersHeight = 30
        Me.DataGridView.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.Location = New System.Drawing.Point(36, 41)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView.Size = New System.Drawing.Size(730, 409)
        Me.DataGridView.TabIndex = 64
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.PowderBlue
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridView.ThemeStyle.ReadOnly = False
        Me.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.pnlTopBar.Size = New System.Drawing.Size(800, 41)
        Me.pnlTopBar.TabIndex = 63
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(12, 7)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(52, 25)
        Me.lblHeading.TabIndex = 56
        Me.lblHeading.Text = "Class " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.btnClose.Location = New System.Drawing.Point(759, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 41)
        Me.btnClose.TabIndex = 55
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.Controls.Add(Me.pnlContainerControls)
        Me.pnlControls.Controls.Add(Me.pnlFillSpace)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlControls.FillColor = System.Drawing.Color.PowderBlue
        Me.pnlControls.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.pnlControls.Location = New System.Drawing.Point(0, 41)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(36, 409)
        Me.pnlControls.TabIndex = 66
        '
        'pnlContainerControls
        '
        Me.pnlContainerControls.Controls.Add(Me.btnAddStudent)
        Me.pnlContainerControls.Controls.Add(Me.txtName)
        Me.pnlContainerControls.Controls.Add(Me.txtStudentID)
        Me.pnlContainerControls.Controls.Add(Me.btnValidate)
        Me.pnlContainerControls.Controls.Add(Me.chkBoxContributes)
        Me.pnlContainerControls.Controls.Add(Me.dtePickerDate)
        Me.pnlContainerControls.Controls.Add(Me.lblDate)
        Me.pnlContainerControls.Controls.Add(Me.cmbBoxExamTest)
        Me.pnlContainerControls.Controls.Add(Me.lblExamTest)
        Me.pnlContainerControls.Controls.Add(Me.txtDescription)
        Me.pnlContainerControls.Controls.Add(Me.lblDescription)
        Me.pnlContainerControls.Controls.Add(Me.cmbBoxSubject)
        Me.pnlContainerControls.Controls.Add(Me.lblSubject)
        Me.pnlContainerControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainerControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainerControls.Name = "pnlContainerControls"
        Me.pnlContainerControls.Size = New System.Drawing.Size(2, 409)
        Me.pnlContainerControls.TabIndex = 69
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Animated = True
        Me.btnAddStudent.BorderColor = System.Drawing.Color.PowderBlue
        Me.btnAddStudent.BorderThickness = 1
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddStudent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddStudent.FillColor = System.Drawing.Color.SeaGreen
        Me.btnAddStudent.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnAddStudent.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnAddStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddStudent.Location = New System.Drawing.Point(232, 8)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(80, 30)
        Me.btnAddStudent.TabIndex = 82
        Me.btnAddStudent.Text = "Add"
        Me.btnAddStudent.Visible = False
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.BorderColor = System.Drawing.Color.LightGray
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FillColor = System.Drawing.Color.PowderBlue
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(12, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = "Student Name"
        Me.txtName.ReadOnly = True
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(136, 30)
        Me.txtName.TabIndex = 81
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName.Visible = False
        '
        'txtStudentID
        '
        Me.txtStudentID.Animated = True
        Me.txtStudentID.BorderColor = System.Drawing.Color.LightGray
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FillColor = System.Drawing.Color.PowderBlue
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStudentID.ForeColor = System.Drawing.Color.Black
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Location = New System.Drawing.Point(164, 8)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = "ID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.Size = New System.Drawing.Size(51, 30)
        Me.txtStudentID.TabIndex = 80
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStudentID.Visible = False
        '
        'btnValidate
        '
        Me.btnValidate.Animated = True
        Me.btnValidate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnValidate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnValidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnValidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnValidate.FillColor = System.Drawing.Color.SeaGreen
        Me.btnValidate.FillColor2 = System.Drawing.Color.SeaGreen
        Me.btnValidate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidate.ForeColor = System.Drawing.Color.White
        Me.btnValidate.Location = New System.Drawing.Point(32, 364)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(734, 45)
        Me.btnValidate.TabIndex = 79
        Me.btnValidate.Text = "Validate"
        '
        'chkBoxContributes
        '
        Me.chkBoxContributes.Animated = True
        Me.chkBoxContributes.AutoSize = True
        Me.chkBoxContributes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxContributes.CheckedState.BorderRadius = 0
        Me.chkBoxContributes.CheckedState.BorderThickness = 0
        Me.chkBoxContributes.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkBoxContributes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxContributes.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.chkBoxContributes.Location = New System.Drawing.Point(474, 218)
        Me.chkBoxContributes.Name = "chkBoxContributes"
        Me.chkBoxContributes.Size = New System.Drawing.Size(219, 20)
        Me.chkBoxContributes.TabIndex = 78
        Me.chkBoxContributes.Text = "Contributes to the final report mark?"
        Me.chkBoxContributes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkBoxContributes.UncheckedState.BorderRadius = 0
        Me.chkBoxContributes.UncheckedState.BorderThickness = 0
        Me.chkBoxContributes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'dtePickerDate
        '
        Me.dtePickerDate.Checked = True
        Me.dtePickerDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePickerDate.FillColor = System.Drawing.Color.RoyalBlue
        Me.dtePickerDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePickerDate.ForeColor = System.Drawing.Color.White
        Me.dtePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtePickerDate.Location = New System.Drawing.Point(267, 83)
        Me.dtePickerDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtePickerDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtePickerDate.Name = "dtePickerDate"
        Me.dtePickerDate.Size = New System.Drawing.Size(266, 35)
        Me.dtePickerDate.TabIndex = 77
        Me.dtePickerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtePickerDate.Value = New Date(2024, 7, 21, 0, 0, 0, 0)
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(171, 92)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 19)
        Me.lblDate.TabIndex = 76
        Me.lblDate.Text = "Date :"
        Me.lblDate.Visible = False
        '
        'cmbBoxExamTest
        '
        Me.cmbBoxExamTest.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxExamTest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxExamTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxExamTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxExamTest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxExamTest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxExamTest.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxExamTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxExamTest.ItemHeight = 30
        Me.cmbBoxExamTest.Items.AddRange(New Object() {"Exam", "Test", "Assignment"})
        Me.cmbBoxExamTest.Location = New System.Drawing.Point(267, 208)
        Me.cmbBoxExamTest.Name = "cmbBoxExamTest"
        Me.cmbBoxExamTest.Size = New System.Drawing.Size(171, 36)
        Me.cmbBoxExamTest.TabIndex = 75
        '
        'lblExamTest
        '
        Me.lblExamTest.BackColor = System.Drawing.Color.Transparent
        Me.lblExamTest.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamTest.Location = New System.Drawing.Point(140, 214)
        Me.lblExamTest.Name = "lblExamTest"
        Me.lblExamTest.Size = New System.Drawing.Size(75, 19)
        Me.lblExamTest.TabIndex = 74
        Me.lblExamTest.Text = "Exam/Test :"
        Me.lblExamTest.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Animated = True
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(267, 271)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(274, 30)
        Me.txtDescription.TabIndex = 73
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(132, 275)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 19)
        Me.lblDescription.TabIndex = 72
        Me.lblDescription.Text = "Description :"
        Me.lblDescription.Visible = False
        '
        'cmbBoxSubject
        '
        Me.cmbBoxSubject.BackColor = System.Drawing.Color.Transparent
        Me.cmbBoxSubject.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cmbBoxSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxSubject.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBoxSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbBoxSubject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbBoxSubject.ItemHeight = 30
        Me.cmbBoxSubject.Location = New System.Drawing.Point(267, 145)
        Me.cmbBoxSubject.Name = "cmbBoxSubject"
        Me.cmbBoxSubject.Size = New System.Drawing.Size(171, 36)
        Me.cmbBoxSubject.Sorted = True
        Me.cmbBoxSubject.TabIndex = 69
        '
        'lblSubject
        '
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(157, 153)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(58, 19)
        Me.lblSubject.TabIndex = 59
        Me.lblSubject.Text = "Subject :"
        Me.lblSubject.Visible = False
        '
        'pnlFillSpace
        '
        Me.pnlFillSpace.Controls.Add(Me.btnToggleFilter)
        Me.pnlFillSpace.Controls.Add(Me.pnlFillSpaceInSpace)
        Me.pnlFillSpace.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFillSpace.Location = New System.Drawing.Point(2, 0)
        Me.pnlFillSpace.Name = "pnlFillSpace"
        Me.pnlFillSpace.Size = New System.Drawing.Size(34, 409)
        Me.pnlFillSpace.TabIndex = 69
        '
        'btnToggleFilter
        '
        Me.btnToggleFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToggleFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToggleFilter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToggleFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToggleFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnToggleFilter.FillColor = System.Drawing.Color.Empty
        Me.btnToggleFilter.FillColor2 = System.Drawing.Color.White
        Me.btnToggleFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnToggleFilter.ForeColor = System.Drawing.SystemColors.Window
        Me.btnToggleFilter.Image = Global.SchoolDemo.My.Resources.Resources._935
        Me.btnToggleFilter.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btnToggleFilter.ImageSize = New System.Drawing.Size(28, 28)
        Me.btnToggleFilter.Location = New System.Drawing.Point(0, 0)
        Me.btnToggleFilter.Name = "btnToggleFilter"
        Me.btnToggleFilter.Size = New System.Drawing.Size(34, 33)
        Me.btnToggleFilter.TabIndex = 69
        Me.btnToggleFilter.UseTransparentBackground = True
        '
        'pnlFillSpaceInSpace
        '
        Me.pnlFillSpaceInSpace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFillSpaceInSpace.FillColor2 = System.Drawing.Color.White
        Me.pnlFillSpaceInSpace.Location = New System.Drawing.Point(0, 0)
        Me.pnlFillSpaceInSpace.Name = "pnlFillSpaceInSpace"
        Me.pnlFillSpaceInSpace.Size = New System.Drawing.Size(34, 409)
        Me.pnlFillSpaceInSpace.TabIndex = 0
        '
        'pnlFillspaceRight
        '
        Me.pnlFillspaceRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFillspaceRight.Location = New System.Drawing.Point(766, 41)
        Me.pnlFillspaceRight.Name = "pnlFillspaceRight"
        Me.pnlFillspaceRight.Size = New System.Drawing.Size(34, 409)
        Me.pnlFillspaceRight.TabIndex = 67
        '
        'FrmUploadExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnValidateAndFinalise)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlFillspaceRight)
        Me.Controls.Add(Me.pnlTopBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUploadExam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examinations"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlContainerControls.ResumeLayout(False)
        Me.pnlContainerControls.PerformLayout()
        Me.pnlFillSpace.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnValidateAndFinalise As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblHeading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlContainerControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblSubject As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFillSpace As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlFillSpaceInSpace As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnToggleFilter As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxExamTest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblExamTest As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxSubject As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtePickerDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chkBoxContributes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnValidate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlFillspaceRight As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddStudent As Guna.UI2.WinForms.Guna2GradientButton
End Class
