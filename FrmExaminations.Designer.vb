<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExaminations
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
        Me.pnlDragExams = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExaminationsAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblAddtionalInfoAdmissions = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAddtionalInfoExaminations = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnUploadMarks = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlExamDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnUploadExam = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlDragExams.SuspendLayout()
        Me.flowpnl.SuspendLayout()
        Me.pnlExamDrop.SuspendLayout()
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
        Me.pnlDragExams.Location = New System.Drawing.Point(245, 29)
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
        Me.lblAddtionalInfoExaminations.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoExaminations.Location = New System.Drawing.Point(12, 466)
        Me.lblAddtionalInfoExaminations.Name = "lblAddtionalInfoExaminations"
        Me.lblAddtionalInfoExaminations.Size = New System.Drawing.Size(313, 23)
        Me.lblAddtionalInfoExaminations.TabIndex = 19
        Me.lblAddtionalInfoExaminations.Text = "Hover over button for further information."
        Me.lblAddtionalInfoExaminations.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
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
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.Controls.Add(Me.pnlExamDrop)
        Me.flowpnl.Location = New System.Drawing.Point(12, 239)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 198)
        Me.flowpnl.TabIndex = 22
        '
        'pnlExamDrop
        '
        Me.pnlExamDrop.Controls.Add(Me.Guna2GradientButton1)
        Me.pnlExamDrop.Controls.Add(Me.btnUploadExam)
        Me.pnlExamDrop.Controls.Add(Me.btnUploadMarks)
        Me.pnlExamDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExamDrop.Location = New System.Drawing.Point(0, 0)
        Me.pnlExamDrop.Name = "pnlExamDrop"
        Me.pnlExamDrop.Size = New System.Drawing.Size(776, 172)
        Me.pnlExamDrop.TabIndex = 23
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2GradientButton1.BorderRadius = 10
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(0, 90)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(776, 45)
        Me.Guna2GradientButton1.TabIndex = 24
        Me.Guna2GradientButton1.Tag = ""
        Me.Guna2GradientButton1.Text = "Upload students test marks."
        Me.Guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2GradientButton1.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnUploadExam
        '
        Me.btnUploadExam.Animated = True
        Me.btnUploadExam.BorderColor = System.Drawing.Color.LightGray
        Me.btnUploadExam.BorderRadius = 10
        Me.btnUploadExam.BorderThickness = 1
        Me.btnUploadExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploadExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUploadExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadExam.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUploadExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUploadExam.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUploadExam.FillColor = System.Drawing.Color.Empty
        Me.btnUploadExam.FillColor2 = System.Drawing.Color.Empty
        Me.btnUploadExam.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadExam.ForeColor = System.Drawing.Color.Black
        Me.btnUploadExam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUploadExam.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUploadExam.Location = New System.Drawing.Point(0, 45)
        Me.btnUploadExam.Name = "btnUploadExam"
        Me.btnUploadExam.Size = New System.Drawing.Size(776, 45)
        Me.btnUploadExam.TabIndex = 23
        Me.btnUploadExam.Tag = ""
        Me.btnUploadExam.Text = "Upload students exam marks."
        Me.btnUploadExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUploadExam.TextOffset = New System.Drawing.Point(50, 0)
        '
        'FrmExaminations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.pnlExamDrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDragExams As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblAddtionalInfoAdmissions As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnExaminationsAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAddtionalInfoExaminations As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnUploadMarks As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlExamDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnUploadExam As Guna.UI2.WinForms.Guna2GradientButton
End Class
