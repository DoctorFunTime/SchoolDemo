<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSelectStudent
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
        Me.btnFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlContainerControls = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.cmbBoxClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtIDNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblIDNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblClass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSurname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFillSpace = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlFillSpaceInSpace = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnToggleFilter = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.pnlContainerControls.SuspendLayout()
        Me.pnlFillSpace.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFilter
        '
        Me.btnFilter.Animated = True
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFilter.FillColor = System.Drawing.Color.SeaGreen
        Me.btnFilter.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(0, 366)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(0, 43)
        Me.btnFilter.TabIndex = 18
        Me.btnFilter.Text = "Search"
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
        Me.DataGridView.Location = New System.Drawing.Point(30, 41)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
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
        Me.DataGridView.Size = New System.Drawing.Size(546, 409)
        Me.DataGridView.TabIndex = 17
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
        Me.DataGridView.ThemeStyle.ReadOnly = True
        Me.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.Controls.Add(Me.pnlContainerControls)
        Me.pnlControls.Controls.Add(Me.btnFilter)
        Me.pnlControls.Controls.Add(Me.pnlFillSpace)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlControls.FillColor = System.Drawing.Color.PowderBlue
        Me.pnlControls.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.pnlControls.Location = New System.Drawing.Point(0, 41)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(30, 409)
        Me.pnlControls.TabIndex = 19
        '
        'pnlContainerControls
        '
        Me.pnlContainerControls.Controls.Add(Me.cmbBoxClass)
        Me.pnlContainerControls.Controls.Add(Me.txtIDNumber)
        Me.pnlContainerControls.Controls.Add(Me.lblName)
        Me.pnlContainerControls.Controls.Add(Me.lblIDNumber)
        Me.pnlContainerControls.Controls.Add(Me.txtName)
        Me.pnlContainerControls.Controls.Add(Me.lblClass)
        Me.pnlContainerControls.Controls.Add(Me.txtSurname)
        Me.pnlContainerControls.Controls.Add(Me.lblSurname)
        Me.pnlContainerControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainerControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainerControls.Name = "pnlContainerControls"
        Me.pnlContainerControls.Size = New System.Drawing.Size(0, 366)
        Me.pnlContainerControls.TabIndex = 69
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
        Me.cmbBoxClass.Location = New System.Drawing.Point(172, 185)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(171, 36)
        Me.cmbBoxClass.TabIndex = 69
        Me.cmbBoxClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Animated = True
        Me.txtIDNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDNumber.DefaultText = ""
        Me.txtIDNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIDNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIDNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDNumber.Location = New System.Drawing.Point(171, 251)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDNumber.PlaceholderText = ""
        Me.txtIDNumber.SelectedText = ""
        Me.txtIDNumber.Size = New System.Drawing.Size(274, 30)
        Me.txtIDNumber.TabIndex = 68
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(102, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 19)
        Me.lblName.TabIndex = 59
        Me.lblName.Text = "Name  :"
        Me.lblName.Visible = False
        '
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblIDNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.Location = New System.Drawing.Point(72, 257)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(80, 19)
        Me.lblIDNumber.TabIndex = 67
        Me.lblIDNumber.Text = "ID Number  :"
        Me.lblIDNumber.Visible = False
        '
        'txtName
        '
        Me.txtName.Animated = True
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(172, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(274, 30)
        Me.txtName.TabIndex = 60
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(109, 195)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(44, 19)
        Me.lblClass.TabIndex = 61
        Me.lblClass.Text = "Class  :"
        Me.lblClass.Visible = False
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
        Me.txtSurname.Location = New System.Drawing.Point(172, 125)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.PlaceholderText = ""
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.Size = New System.Drawing.Size(274, 30)
        Me.txtSurname.TabIndex = 64
        '
        'lblSurname
        '
        Me.lblSurname.BackColor = System.Drawing.Color.Transparent
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(86, 133)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(67, 19)
        Me.lblSurname.TabIndex = 63
        Me.lblSurname.Text = "Surname  :"
        Me.lblSurname.Visible = False
        '
        'pnlFillSpace
        '
        Me.pnlFillSpace.Controls.Add(Me.pnlFillSpaceInSpace)
        Me.pnlFillSpace.Controls.Add(Me.btnToggleFilter)
        Me.pnlFillSpace.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlFillSpace.Location = New System.Drawing.Point(-4, 0)
        Me.pnlFillSpace.Name = "pnlFillSpace"
        Me.pnlFillSpace.Size = New System.Drawing.Size(34, 409)
        Me.pnlFillSpace.TabIndex = 69
        '
        'pnlFillSpaceInSpace
        '
        Me.pnlFillSpaceInSpace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFillSpaceInSpace.FillColor2 = System.Drawing.Color.White
        Me.pnlFillSpaceInSpace.Location = New System.Drawing.Point(0, 33)
        Me.pnlFillSpaceInSpace.Name = "pnlFillSpaceInSpace"
        Me.pnlFillSpaceInSpace.Size = New System.Drawing.Size(34, 376)
        Me.pnlFillSpaceInSpace.TabIndex = 0
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
        Me.pnlTopBar.TabIndex = 58
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(205, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(162, 25)
        Me.lblHeading.TabIndex = 56
        Me.lblHeading.Text = "Student Selection"
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
        'FrmSelectStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlTopBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSelectStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSelectStudent"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlContainerControls.ResumeLayout(False)
        Me.pnlContainerControls.PerformLayout()
        Me.pnlFillSpace.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblHeading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnToggleFilter As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlFillSpace As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlFillSpaceInSpace As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlContainerControls As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtIDNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIDNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblClass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSurname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
End Class
