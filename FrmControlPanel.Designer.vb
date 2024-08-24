<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmControlPanel
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
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblAddtionalInfoAdmissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flowpnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.BorderColor = System.Drawing.Color.Gray
        Me.flowpnl.Controls.Add(Me.btnAttendance)
        Me.flowpnl.Location = New System.Drawing.Point(12, 20)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 400)
        Me.flowpnl.TabIndex = 21
        '
        'btnAttendance
        '
        Me.btnAttendance.Animated = True
        Me.btnAttendance.BorderRadius = 10
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAttendance.FillColor = System.Drawing.Color.PowderBlue
        Me.btnAttendance.FillColor2 = System.Drawing.Color.LightGray
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.Image = Global.SchoolDemo.My.Resources.Resources._573
        Me.btnAttendance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnAttendance.Location = New System.Drawing.Point(0, 0)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(776, 45)
        Me.btnAttendance.TabIndex = 13
        Me.btnAttendance.Tag = "Mark the day's attendancy register."
        Me.btnAttendance.Text = "Register"
        Me.btnAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.TextOffset = New System.Drawing.Point(-9, 0)
        '
        'lblAddtionalInfoAdmissions
        '
        Me.lblAddtionalInfoAdmissions.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoAdmissions.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoAdmissions.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoAdmissions.Name = "lblAddtionalInfoAdmissions"
        Me.lblAddtionalInfoAdmissions.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoAdmissions.TabIndex = 20
        Me.lblAddtionalInfoAdmissions.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoAdmissions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.flowpnl)
        Me.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmControlPanel"
        Me.flowpnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
