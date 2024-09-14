<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExaminations
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
        Me.lblAddtionalInfoExaminations = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFlowMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnManageMarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUploadMarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFlowMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoExaminations
        '
        Me.lblAddtionalInfoExaminations.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoExaminations.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblAddtionalInfoExaminations.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoExaminations.Name = "lblAddtionalInfoExaminations"
        Me.lblAddtionalInfoExaminations.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoExaminations.TabIndex = 19
        Me.lblAddtionalInfoExaminations.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoExaminations.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFlowMain
        '
        Me.pnlFlowMain.AutoScroll = True
        Me.pnlFlowMain.Controls.Add(Me.btnManageMarks)
        Me.pnlFlowMain.Controls.Add(Me.btnUploadMarks)
        Me.pnlFlowMain.Location = New System.Drawing.Point(12, 20)
        Me.pnlFlowMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlowMain.Name = "pnlFlowMain"
        Me.pnlFlowMain.Size = New System.Drawing.Size(776, 400)
        Me.pnlFlowMain.TabIndex = 23
        '
        'btnManageMarks
        '
        Me.btnManageMarks.Animated = True
        Me.btnManageMarks.BorderRadius = 10
        Me.btnManageMarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageMarks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManageMarks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManageMarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageMarks.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManageMarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManageMarks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageMarks.FillColor = System.Drawing.Color.PowderBlue
        Me.btnManageMarks.FillColor2 = System.Drawing.Color.LightGray
        Me.btnManageMarks.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageMarks.ForeColor = System.Drawing.Color.Black
        Me.btnManageMarks.Image = Global.SchoolDemo.My.Resources.Resources._316
        Me.btnManageMarks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManageMarks.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnManageMarks.Location = New System.Drawing.Point(3, 3)
        Me.btnManageMarks.Name = "btnManageMarks"
        Me.btnManageMarks.Size = New System.Drawing.Size(753, 45)
        Me.btnManageMarks.TabIndex = 25
        Me.btnManageMarks.Tag = "Manage the student's marks."
        Me.btnManageMarks.Text = "Manage Marks"
        Me.btnManageMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnUploadMarks
        '
        Me.btnUploadMarks.Animated = True
        Me.btnUploadMarks.BorderRadius = 10
        Me.btnUploadMarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadMarks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadMarks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadMarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadMarks.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadMarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUploadMarks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUploadMarks.FillColor = System.Drawing.Color.PowderBlue
        Me.btnUploadMarks.FillColor2 = System.Drawing.Color.LightGray
        Me.btnUploadMarks.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUploadMarks.ForeColor = System.Drawing.Color.Black
        Me.btnUploadMarks.Image = Global.SchoolDemo.My.Resources.Resources._558
        Me.btnUploadMarks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUploadMarks.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUploadMarks.Location = New System.Drawing.Point(3, 54)
        Me.btnUploadMarks.Name = "btnUploadMarks"
        Me.btnUploadMarks.Size = New System.Drawing.Size(753, 45)
        Me.btnUploadMarks.TabIndex = 24
        Me.btnUploadMarks.Tag = "Upload student's exam and/  test marks."
        Me.btnUploadMarks.Text = "Upload Marks"
        Me.btnUploadMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmExaminations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.pnlFlowMain)
        Me.Controls.Add(Me.lblAddtionalInfoExaminations)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmExaminations"
        Me.Text = "FrmExaminations"
        Me.pnlFlowMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddtionalInfoExaminations As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFlowMain As FlowLayoutPanel
    Friend WithEvents btnManageMarks As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUploadMarks As Guna.UI2.WinForms.Guna2GradientButton
End Class
