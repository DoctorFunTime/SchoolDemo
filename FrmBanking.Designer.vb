<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBanking
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
        Me.lblAddtionalInfoBanking = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnInvoices = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCashBook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFeesStatements = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlInvoiceDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnStudentInvoice = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStandardInvoice = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlCashbookDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExpenses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReceipts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSchoolFees = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.flowpnl.SuspendLayout()
        Me.pnlInvoiceDrop.SuspendLayout()
        Me.pnlCashbookDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoBanking
        '
        Me.lblAddtionalInfoBanking.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoBanking.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoBanking.Location = New System.Drawing.Point(12, 466)
        Me.lblAddtionalInfoBanking.Name = "lblAddtionalInfoBanking"
        Me.lblAddtionalInfoBanking.Size = New System.Drawing.Size(313, 23)
        Me.lblAddtionalInfoBanking.TabIndex = 23
        Me.lblAddtionalInfoBanking.Text = "Hover over button for further information."
        Me.lblAddtionalInfoBanking.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInvoices
        '
        Me.btnInvoices.Animated = True
        Me.btnInvoices.BorderRadius = 10
        Me.btnInvoices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoices.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoices.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvoices.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvoices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInvoices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInvoices.FillColor = System.Drawing.Color.PowderBlue
        Me.btnInvoices.FillColor2 = System.Drawing.Color.LightGray
        Me.btnInvoices.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnInvoices.ForeColor = System.Drawing.Color.Black
        Me.btnInvoices.Image = Global.SchoolDemo.My.Resources.Resources._244
        Me.btnInvoices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInvoices.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnInvoices.Location = New System.Drawing.Point(0, 0)
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(776, 45)
        Me.btnInvoices.TabIndex = 25
        Me.btnInvoices.Tag = "Generate periodic/individual invoices."
        Me.btnInvoices.Text = "Invoice"
        Me.btnInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnCashBook
        '
        Me.btnCashBook.Animated = True
        Me.btnCashBook.BorderRadius = 10
        Me.btnCashBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCashBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCashBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCashBook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCashBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCashBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashBook.FillColor = System.Drawing.Color.PowderBlue
        Me.btnCashBook.FillColor2 = System.Drawing.Color.LightGray
        Me.btnCashBook.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCashBook.ForeColor = System.Drawing.Color.Black
        Me.btnCashBook.Image = Global.SchoolDemo.My.Resources.Resources._566
        Me.btnCashBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCashBook.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCashBook.Location = New System.Drawing.Point(0, 0)
        Me.btnCashBook.Name = "btnCashBook"
        Me.btnCashBook.Size = New System.Drawing.Size(776, 45)
        Me.btnCashBook.TabIndex = 24
        Me.btnCashBook.Tag = "Make payments, Receive payments."
        Me.btnCashBook.Text = "Cashbook"
        Me.btnCashBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnFeesStatements
        '
        Me.btnFeesStatements.Animated = True
        Me.btnFeesStatements.BorderRadius = 10
        Me.btnFeesStatements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFeesStatements.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFeesStatements.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFeesStatements.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFeesStatements.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFeesStatements.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFeesStatements.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFeesStatements.FillColor = System.Drawing.Color.PowderBlue
        Me.btnFeesStatements.FillColor2 = System.Drawing.Color.LightGray
        Me.btnFeesStatements.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnFeesStatements.ForeColor = System.Drawing.Color.Black
        Me.btnFeesStatements.Image = Global.SchoolDemo.My.Resources.Resources._266
        Me.btnFeesStatements.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFeesStatements.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnFeesStatements.Location = New System.Drawing.Point(0, 0)
        Me.btnFeesStatements.Name = "btnFeesStatements"
        Me.btnFeesStatements.Size = New System.Drawing.Size(776, 45)
        Me.btnFeesStatements.TabIndex = 19
        Me.btnFeesStatements.Tag = "View student's fees statements."
        Me.btnFeesStatements.Text = "Fees Statement"
        Me.btnFeesStatements.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'flowpnl
        '
        Me.flowpnl.AutoScroll = True
        Me.flowpnl.Controls.Add(Me.pnlInvoiceDrop)
        Me.flowpnl.Controls.Add(Me.pnlCashbookDrop)
        Me.flowpnl.Controls.Add(Me.btnFeesStatements)
        Me.flowpnl.Location = New System.Drawing.Point(12, 20)
        Me.flowpnl.Name = "flowpnl"
        Me.flowpnl.Size = New System.Drawing.Size(776, 343)
        Me.flowpnl.TabIndex = 31
        '
        'pnlInvoiceDrop
        '
        Me.pnlInvoiceDrop.Controls.Add(Me.btnStudentInvoice)
        Me.pnlInvoiceDrop.Controls.Add(Me.btnStandardInvoice)
        Me.pnlInvoiceDrop.Controls.Add(Me.btnInvoices)
        Me.pnlInvoiceDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInvoiceDrop.Location = New System.Drawing.Point(0, 90)
        Me.pnlInvoiceDrop.Name = "pnlInvoiceDrop"
        Me.pnlInvoiceDrop.Size = New System.Drawing.Size(776, 45)
        Me.pnlInvoiceDrop.TabIndex = 27
        '
        'btnStudentInvoice
        '
        Me.btnStudentInvoice.Animated = True
        Me.btnStudentInvoice.BorderColor = System.Drawing.Color.LightGray
        Me.btnStudentInvoice.BorderRadius = 10
        Me.btnStudentInvoice.BorderThickness = 1
        Me.btnStudentInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudentInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudentInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentInvoice.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudentInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudentInvoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentInvoice.FillColor = System.Drawing.Color.Empty
        Me.btnStudentInvoice.FillColor2 = System.Drawing.Color.Empty
        Me.btnStudentInvoice.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentInvoice.ForeColor = System.Drawing.Color.Black
        Me.btnStudentInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentInvoice.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStudentInvoice.Location = New System.Drawing.Point(0, 90)
        Me.btnStudentInvoice.Name = "btnStudentInvoice"
        Me.btnStudentInvoice.Size = New System.Drawing.Size(776, 45)
        Me.btnStudentInvoice.TabIndex = 24
        Me.btnStudentInvoice.Tag = ""
        Me.btnStudentInvoice.Text = "Generate a students fees  invoice."
        Me.btnStudentInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudentInvoice.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnStandardInvoice
        '
        Me.btnStandardInvoice.Animated = True
        Me.btnStandardInvoice.BorderColor = System.Drawing.Color.LightGray
        Me.btnStandardInvoice.BorderRadius = 10
        Me.btnStandardInvoice.BorderThickness = 1
        Me.btnStandardInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStandardInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStandardInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStandardInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStandardInvoice.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStandardInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStandardInvoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStandardInvoice.FillColor = System.Drawing.Color.Empty
        Me.btnStandardInvoice.FillColor2 = System.Drawing.Color.Empty
        Me.btnStandardInvoice.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStandardInvoice.ForeColor = System.Drawing.Color.Black
        Me.btnStandardInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStandardInvoice.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnStandardInvoice.Location = New System.Drawing.Point(0, 45)
        Me.btnStandardInvoice.Name = "btnStandardInvoice"
        Me.btnStandardInvoice.Size = New System.Drawing.Size(776, 45)
        Me.btnStandardInvoice.TabIndex = 23
        Me.btnStandardInvoice.Tag = ""
        Me.btnStandardInvoice.Text = "Generate a standard invoice."
        Me.btnStandardInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStandardInvoice.TextOffset = New System.Drawing.Point(50, 0)
        '
        'pnlCashbookDrop
        '
        Me.pnlCashbookDrop.Controls.Add(Me.btnExpenses)
        Me.pnlCashbookDrop.Controls.Add(Me.btnReceipts)
        Me.pnlCashbookDrop.Controls.Add(Me.btnSchoolFees)
        Me.pnlCashbookDrop.Controls.Add(Me.btnCashBook)
        Me.pnlCashbookDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCashbookDrop.Location = New System.Drawing.Point(0, 45)
        Me.pnlCashbookDrop.Name = "pnlCashbookDrop"
        Me.pnlCashbookDrop.Size = New System.Drawing.Size(776, 45)
        Me.pnlCashbookDrop.TabIndex = 26
        '
        'btnExpenses
        '
        Me.btnExpenses.Animated = True
        Me.btnExpenses.BorderColor = System.Drawing.Color.LightGray
        Me.btnExpenses.BorderRadius = 10
        Me.btnExpenses.BorderThickness = 1
        Me.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExpenses.FillColor = System.Drawing.Color.Empty
        Me.btnExpenses.FillColor2 = System.Drawing.Color.Empty
        Me.btnExpenses.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.Black
        Me.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnExpenses.Location = New System.Drawing.Point(0, 135)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(776, 45)
        Me.btnExpenses.TabIndex = 23
        Me.btnExpenses.Tag = ""
        Me.btnExpenses.Text = "Process amounts paid."
        Me.btnExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnReceipts
        '
        Me.btnReceipts.Animated = True
        Me.btnReceipts.BorderColor = System.Drawing.Color.LightGray
        Me.btnReceipts.BorderRadius = 10
        Me.btnReceipts.BorderThickness = 1
        Me.btnReceipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReceipts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReceipts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReceipts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReceipts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReceipts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReceipts.FillColor = System.Drawing.Color.Empty
        Me.btnReceipts.FillColor2 = System.Drawing.Color.Empty
        Me.btnReceipts.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipts.ForeColor = System.Drawing.Color.Black
        Me.btnReceipts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReceipts.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnReceipts.Location = New System.Drawing.Point(0, 90)
        Me.btnReceipts.Name = "btnReceipts"
        Me.btnReceipts.Size = New System.Drawing.Size(776, 45)
        Me.btnReceipts.TabIndex = 22
        Me.btnReceipts.Tag = ""
        Me.btnReceipts.Text = "Process amounts received."
        Me.btnReceipts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReceipts.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnSchoolFees
        '
        Me.btnSchoolFees.Animated = True
        Me.btnSchoolFees.BorderColor = System.Drawing.Color.LightGray
        Me.btnSchoolFees.BorderRadius = 10
        Me.btnSchoolFees.BorderThickness = 1
        Me.btnSchoolFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchoolFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolFees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchoolFees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchoolFees.FillColor = System.Drawing.Color.Empty
        Me.btnSchoolFees.FillColor2 = System.Drawing.Color.Empty
        Me.btnSchoolFees.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchoolFees.ForeColor = System.Drawing.Color.Black
        Me.btnSchoolFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolFees.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSchoolFees.Location = New System.Drawing.Point(0, 45)
        Me.btnSchoolFees.Name = "btnSchoolFees"
        Me.btnSchoolFees.Size = New System.Drawing.Size(776, 45)
        Me.btnSchoolFees.TabIndex = 25
        Me.btnSchoolFees.Tag = ""
        Me.btnSchoolFees.Text = "Process school fees."
        Me.btnSchoolFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolFees.TextOffset = New System.Drawing.Point(50, 0)
        '
        'FrmBanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.flowpnl)
        Me.Controls.Add(Me.lblAddtionalInfoBanking)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBanking"
        Me.Text = "FrmBanking"
        Me.flowpnl.ResumeLayout(False)
        Me.pnlInvoiceDrop.ResumeLayout(False)
        Me.pnlCashbookDrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddtionalInfoBanking As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnFeesStatements As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnInvoices As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCashBook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents flowpnl As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlCashbookDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnExpenses As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReceipts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlInvoiceDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnStandardInvoice As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudentInvoice As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSchoolFees As Guna.UI2.WinForms.Guna2GradientButton
End Class
