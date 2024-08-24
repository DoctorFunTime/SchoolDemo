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
        Me.pnlDragExams = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExaminationsAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblAddtionalInfoAdmissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAddtionalInfoExaminations = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnViewExams = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnManageMarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUploadMarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlDragExams.SuspendLayout()
        Me.flowpnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDragExams
        '
        Me.pnlDragExams.AllowDrop = True
        Me.pnlDragExams.BorderColor = System.Drawing.Color.LightGray
        Me.pnlDragExams.BorderRadius = 10
        Me.pnlDragExams.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.pnlDragExams.BorderThickness = 3
        Me.pnlDragExams.Controls.Add(Me.btnExaminationsAdd)
        Me.pnlDragExams.Controls.Add(Me.lblAddtionalInfoAdmissions)
        Me.pnlDragExams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlDragExams.Location = New System.Drawing.Point(245, 12)
        Me.pnlDragExams.Name = "pnlDragExams"
        Me.pnlDragExams.Size = New System.Drawing.Size(296, 196)
        Me.pnlDragExams.TabIndex = 0
        Me.pnlDragExams.Tag = "Only Word and PDF Documents are acceptable."
        '
        'btnExaminationsAdd
        '
        Me.btnExaminationsAdd.Animated = True
        Me.btnExaminationsAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnExaminationsAdd.BorderColor = System.Drawing.Color.LightGray
        Me.btnExaminationsAdd.BorderRadius = 8
        Me.btnExaminationsAdd.BorderThickness = 1
        Me.btnExaminationsAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExaminationsAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExaminationsAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExaminationsAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExaminationsAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExaminationsAdd.FillColor = System.Drawing.Color.Empty
        Me.btnExaminationsAdd.FillColor2 = System.Drawing.Color.Empty
        Me.btnExaminationsAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminationsAdd.ForeColor = System.Drawing.Color.Black
        Me.btnExaminationsAdd.Location = New System.Drawing.Point(108, 147)
        Me.btnExaminationsAdd.Name = "btnExaminationsAdd"
        Me.btnExaminationsAdd.Size = New System.Drawing.Size(81, 33)
        Me.btnExaminationsAdd.TabIndex = 21
        Me.btnExaminationsAdd.Text = "Add"
        Me.btnExaminationsAdd.UseTransparentBackground = True
        '
        'lblAddtionalInfoAdmissions
        '
        Me.lblAddtionalInfoAdmissions.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoAdmissions.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoAdmissions.Location = New System.Drawing.Point(53, 34)
        Me.lblAddtionalInfoAdmissions.Name = "lblAddtionalInfoAdmissions"
        Me.lblAddtionalInfoAdmissions.Size = New System.Drawing.Size(239, 18)
        Me.lblAddtionalInfoAdmissions.TabIndex = 19
        Me.lblAddtionalInfoAdmissions.Text = "Drag and drop your document here."
        Me.lblAddtionalInfoAdmissions.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
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
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.Controls.Add(Me.btnViewExams)
        Me.flowpnl.Controls.Add(Me.btnManageMarks)
        Me.flowpnl.Controls.Add(Me.btnUploadMarks)
        Me.flowpnl.Location = New System.Drawing.Point(12, 239)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 188)
        Me.flowpnl.TabIndex = 22
        '
        'btnViewExams
        '
        Me.btnViewExams.Animated = True
        Me.btnViewExams.BorderRadius = 10
        Me.btnViewExams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewExams.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewExams.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewExams.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewExams.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewExams.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewExams.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViewExams.FillColor = System.Drawing.Color.PowderBlue
        Me.btnViewExams.FillColor2 = System.Drawing.Color.LightGray
        Me.btnViewExams.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewExams.ForeColor = System.Drawing.Color.Black
        Me.btnViewExams.Image = Global.SchoolDemo.My.Resources.Resources._557
        Me.btnViewExams.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewExams.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnViewExams.Location = New System.Drawing.Point(0, 90)
        Me.btnViewExams.Name = "btnViewExams"
        Me.btnViewExams.Size = New System.Drawing.Size(776, 45)
        Me.btnViewExams.TabIndex = 23
        Me.btnViewExams.Tag = "View exam/test/assignment."
        Me.btnViewExams.Text = "View"
        Me.btnViewExams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btnManageMarks.Location = New System.Drawing.Point(0, 45)
        Me.btnManageMarks.Name = "btnManageMarks"
        Me.btnManageMarks.Size = New System.Drawing.Size(776, 45)
        Me.btnManageMarks.TabIndex = 22
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
        Me.btnUploadMarks.Location = New System.Drawing.Point(0, 0)
        Me.btnUploadMarks.Name = "btnUploadMarks"
        Me.btnUploadMarks.Size = New System.Drawing.Size(776, 45)
        Me.btnUploadMarks.TabIndex = 21
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
        Me.Controls.Add(Me.flowpnl)
        Me.Controls.Add(Me.lblAddtionalInfoExaminations)
        Me.Controls.Add(Me.pnlDragExams)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmExaminations"
        Me.Text = "FrmExaminations"
        Me.pnlDragExams.ResumeLayout(False)
        Me.pnlDragExams.PerformLayout()
        Me.flowpnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDragExams As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnExaminationsAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAddtionalInfoExaminations As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUploadMarks As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnManageMarks As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnViewExams As Guna.UI2.WinForms.Guna2GradientButton
End Class
