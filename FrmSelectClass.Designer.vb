<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectClass
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
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFlwClasses = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbBoxClass = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlTopBar.SuspendLayout()
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
        Me.pnlTopBar.Controls.Add(Me.cmbBoxClass)
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
        Me.lblHeading.Location = New System.Drawing.Point(8, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(142, 25)
        Me.lblHeading.TabIndex = 56
        Me.lblHeading.Text = "Class Selection"
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
        'pnlFlwClasses
        '
        Me.pnlFlwClasses.AutoScroll = True
        Me.pnlFlwClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFlwClasses.Location = New System.Drawing.Point(0, 41)
        Me.pnlFlwClasses.Name = "pnlFlwClasses"
        Me.pnlFlwClasses.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.pnlFlwClasses.Size = New System.Drawing.Size(576, 409)
        Me.pnlFlwClasses.TabIndex = 60
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
        Me.cmbBoxClass.Location = New System.Drawing.Point(393, 2)
        Me.cmbBoxClass.Name = "cmbBoxClass"
        Me.cmbBoxClass.Size = New System.Drawing.Size(136, 36)
        Me.cmbBoxClass.TabIndex = 57
        Me.cmbBoxClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmbBoxClass.Visible = False
        '
        'FrmSelectClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 450)
        Me.Controls.Add(Me.pnlFlwClasses)
        Me.Controls.Add(Me.pnlTopBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSelectClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSelectClass"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblHeading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlFlwClasses As FlowLayoutPanel
    Friend WithEvents cmbBoxClass As Guna.UI2.WinForms.Guna2ComboBox
End Class
