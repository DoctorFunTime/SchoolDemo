<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevelopers
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
        Me.openingTransitionDevelopers = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnWhatsApp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblGIT1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.SuspendLayout()
        '
        'openingTransitionDevelopers
        '
        Me.openingTransitionDevelopers.AnimateWindow = True
        Me.openingTransitionDevelopers.BorderRadius = 15
        Me.openingTransitionDevelopers.ContainerControl = Me
        Me.openingTransitionDevelopers.DockIndicatorTransparencyValue = 0.6R
        Me.openingTransitionDevelopers.ResizeForm = False
        Me.openingTransitionDevelopers.TransparentWhileDrag = True
        '
        'btnWhatsApp
        '
        Me.btnWhatsApp.Animated = True
        Me.btnWhatsApp.BorderColor = System.Drawing.Color.Green
        Me.btnWhatsApp.BorderRadius = 8
        Me.btnWhatsApp.BorderThickness = 1
        Me.btnWhatsApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWhatsApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWhatsApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWhatsApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWhatsApp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWhatsApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWhatsApp.FillColor = System.Drawing.Color.Empty
        Me.btnWhatsApp.FillColor2 = System.Drawing.Color.Empty
        Me.btnWhatsApp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWhatsApp.ForeColor = System.Drawing.Color.Black
        Me.btnWhatsApp.Image = Global.SchoolDemo.My.Resources.Resources.whatsapp
        Me.btnWhatsApp.ImageOffset = New System.Drawing.Point(22, -15)
        Me.btnWhatsApp.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnWhatsApp.Location = New System.Drawing.Point(293, 86)
        Me.btnWhatsApp.Name = "btnWhatsApp"
        Me.btnWhatsApp.Size = New System.Drawing.Size(163, 135)
        Me.btnWhatsApp.TabIndex = 1
        Me.btnWhatsApp.Text = "WhatsApp"
        Me.btnWhatsApp.TextOffset = New System.Drawing.Point(-17, 40)
        '
        'lblGIT1
        '
        Me.lblGIT1.BackColor = System.Drawing.Color.Transparent
        Me.lblGIT1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGIT1.Location = New System.Drawing.Point(12, 69)
        Me.lblGIT1.Name = "lblGIT1"
        Me.lblGIT1.Size = New System.Drawing.Size(193, 24)
        Me.lblGIT1.TabIndex = 6
        Me.lblGIT1.Text = "Get in touch with us."
        Me.lblGIT1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(66, 169)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(300, 200)
        Me.Guna2GroupBox1.TabIndex = 7
        Me.Guna2GroupBox1.Text = "Contacts"
        '
        'FrmDevelopers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.lblGIT1)
        Me.Controls.Add(Me.btnWhatsApp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDevelopers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDevelopers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents openingTransitionDevelopers As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnWhatsApp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblGIT1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
End Class
