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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBanking))
        Me.lblAddtionalInfoBanking = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFlowMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOutStandingFees = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFeesStatements = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlCashbookDrop = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnExpenses = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnReceipts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSchoolFees = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnCashBook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnInvoiceAccounts = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSchoolCashbook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnExpenseIncome = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pnlFlowMain.SuspendLayout()
        Me.pnlCashbookDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddtionalInfoBanking
        '
        Me.lblAddtionalInfoBanking.BackColor = System.Drawing.Color.Transparent
        Me.lblAddtionalInfoBanking.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddtionalInfoBanking.Location = New System.Drawing.Point(12, 433)
        Me.lblAddtionalInfoBanking.Name = "lblAddtionalInfoBanking"
        Me.lblAddtionalInfoBanking.Size = New System.Drawing.Size(339, 25)
        Me.lblAddtionalInfoBanking.TabIndex = 23
        Me.lblAddtionalInfoBanking.Text = "Hover over a button for further information."
        Me.lblAddtionalInfoBanking.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFlowMain
        '
        Me.pnlFlowMain.AutoScroll = True
        Me.pnlFlowMain.Controls.Add(Me.btnOutStandingFees)
        Me.pnlFlowMain.Controls.Add(Me.btnFeesStatements)
        Me.pnlFlowMain.Controls.Add(Me.pnlCashbookDrop)
        Me.pnlFlowMain.Controls.Add(Me.btnInvoiceAccounts)
        Me.pnlFlowMain.Controls.Add(Me.btnSchoolCashbook)
        Me.pnlFlowMain.Controls.Add(Me.btnExpenseIncome)
        Me.pnlFlowMain.Location = New System.Drawing.Point(12, 20)
        Me.pnlFlowMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlowMain.Name = "pnlFlowMain"
        Me.pnlFlowMain.Size = New System.Drawing.Size(776, 400)
        Me.pnlFlowMain.TabIndex = 32
        '
        'btnOutStandingFees
        '
        Me.btnOutStandingFees.Animated = True
        Me.btnOutStandingFees.BorderRadius = 10
        Me.btnOutStandingFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOutStandingFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOutStandingFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOutStandingFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOutStandingFees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOutStandingFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOutStandingFees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOutStandingFees.FillColor = System.Drawing.Color.PowderBlue
        Me.btnOutStandingFees.FillColor2 = System.Drawing.Color.LightGray
        Me.btnOutStandingFees.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOutStandingFees.ForeColor = System.Drawing.Color.Black
        Me.btnOutStandingFees.Image = Global.SchoolDemo.My.Resources.Resources._559
        Me.btnOutStandingFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOutStandingFees.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnOutStandingFees.Location = New System.Drawing.Point(3, 3)
        Me.btnOutStandingFees.Name = "btnOutStandingFees"
        Me.btnOutStandingFees.Size = New System.Drawing.Size(753, 45)
        Me.btnOutStandingFees.TabIndex = 36
        Me.btnOutStandingFees.Tag = "View all the students owing fees."
        Me.btnOutStandingFees.Text = "Student Fees Due"
        Me.btnOutStandingFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOutStandingFees.TextOffset = New System.Drawing.Point(-3, 0)
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
        Me.btnFeesStatements.Location = New System.Drawing.Point(3, 54)
        Me.btnFeesStatements.Name = "btnFeesStatements"
        Me.btnFeesStatements.Size = New System.Drawing.Size(753, 45)
        Me.btnFeesStatements.TabIndex = 32
        Me.btnFeesStatements.Tag = "View a selected student's fees statement."
        Me.btnFeesStatements.Text = "Student Fees Statement"
        Me.btnFeesStatements.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlCashbookDrop
        '
        Me.pnlCashbookDrop.Controls.Add(Me.btnExpenses)
        Me.pnlCashbookDrop.Controls.Add(Me.btnReceipts)
        Me.pnlCashbookDrop.Controls.Add(Me.btnSchoolFees)
        Me.pnlCashbookDrop.Controls.Add(Me.btnCashBook)
        Me.pnlCashbookDrop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCashbookDrop.Location = New System.Drawing.Point(3, 105)
        Me.pnlCashbookDrop.Name = "pnlCashbookDrop"
        Me.pnlCashbookDrop.Size = New System.Drawing.Size(753, 45)
        Me.pnlCashbookDrop.TabIndex = 33
        '
        'btnExpenses
        '
        Me.btnExpenses.Animated = True
        Me.btnExpenses.BorderColor = System.Drawing.Color.Empty
        Me.btnExpenses.BorderRadius = 10
        Me.btnExpenses.BorderThickness = 1
        Me.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenses.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExpenses.FillColor = System.Drawing.Color.SlateBlue
        Me.btnExpenses.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnExpenses.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.White
        Me.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnExpenses.Location = New System.Drawing.Point(0, 135)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(753, 45)
        Me.btnExpenses.TabIndex = 23
        Me.btnExpenses.Tag = ""
        Me.btnExpenses.Text = "Process amounts paid."
        Me.btnExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenses.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnReceipts
        '
        Me.btnReceipts.Animated = True
        Me.btnReceipts.BorderColor = System.Drawing.Color.Empty
        Me.btnReceipts.BorderRadius = 10
        Me.btnReceipts.BorderThickness = 1
        Me.btnReceipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReceipts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReceipts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReceipts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReceipts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReceipts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReceipts.FillColor = System.Drawing.Color.SlateBlue
        Me.btnReceipts.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnReceipts.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipts.ForeColor = System.Drawing.Color.White
        Me.btnReceipts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReceipts.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnReceipts.Location = New System.Drawing.Point(0, 90)
        Me.btnReceipts.Name = "btnReceipts"
        Me.btnReceipts.Size = New System.Drawing.Size(753, 45)
        Me.btnReceipts.TabIndex = 22
        Me.btnReceipts.Tag = ""
        Me.btnReceipts.Text = "Process amounts received."
        Me.btnReceipts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReceipts.TextOffset = New System.Drawing.Point(50, 0)
        '
        'btnSchoolFees
        '
        Me.btnSchoolFees.Animated = True
        Me.btnSchoolFees.BorderColor = System.Drawing.Color.Empty
        Me.btnSchoolFees.BorderRadius = 10
        Me.btnSchoolFees.BorderThickness = 1
        Me.btnSchoolFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchoolFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolFees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchoolFees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchoolFees.FillColor = System.Drawing.Color.SlateBlue
        Me.btnSchoolFees.FillColor2 = System.Drawing.Color.SlateBlue
        Me.btnSchoolFees.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchoolFees.ForeColor = System.Drawing.Color.White
        Me.btnSchoolFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolFees.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSchoolFees.Location = New System.Drawing.Point(0, 45)
        Me.btnSchoolFees.Name = "btnSchoolFees"
        Me.btnSchoolFees.Size = New System.Drawing.Size(753, 45)
        Me.btnSchoolFees.TabIndex = 25
        Me.btnSchoolFees.Tag = ""
        Me.btnSchoolFees.Text = "Process school fees."
        Me.btnSchoolFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolFees.TextOffset = New System.Drawing.Point(50, 0)
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
        Me.btnCashBook.Size = New System.Drawing.Size(753, 45)
        Me.btnCashBook.TabIndex = 24
        Me.btnCashBook.Tag = "Process payment and receipt transactions. "
        Me.btnCashBook.Text = "Transactions"
        Me.btnCashBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnInvoiceAccounts
        '
        Me.btnInvoiceAccounts.Animated = True
        Me.btnInvoiceAccounts.BorderRadius = 10
        Me.btnInvoiceAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoiceAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoiceAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInvoiceAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvoiceAccounts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInvoiceAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInvoiceAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInvoiceAccounts.FillColor = System.Drawing.Color.PowderBlue
        Me.btnInvoiceAccounts.FillColor2 = System.Drawing.Color.LightGray
        Me.btnInvoiceAccounts.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnInvoiceAccounts.ForeColor = System.Drawing.Color.Black
        Me.btnInvoiceAccounts.Image = Global.SchoolDemo.My.Resources.Resources._244
        Me.btnInvoiceAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInvoiceAccounts.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnInvoiceAccounts.Location = New System.Drawing.Point(3, 156)
        Me.btnInvoiceAccounts.Name = "btnInvoiceAccounts"
        Me.btnInvoiceAccounts.Size = New System.Drawing.Size(753, 45)
        Me.btnInvoiceAccounts.TabIndex = 37
        Me.btnInvoiceAccounts.Tag = "Debit student accounts with fees due for the month."
        Me.btnInvoiceAccounts.Text = "Invoice Student Accounts"
        Me.btnInvoiceAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSchoolCashbook
        '
        Me.btnSchoolCashbook.Animated = True
        Me.btnSchoolCashbook.BorderRadius = 10
        Me.btnSchoolCashbook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSchoolCashbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolCashbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchoolCashbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolCashbook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchoolCashbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchoolCashbook.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchoolCashbook.FillColor = System.Drawing.Color.PowderBlue
        Me.btnSchoolCashbook.FillColor2 = System.Drawing.Color.LightGray
        Me.btnSchoolCashbook.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSchoolCashbook.ForeColor = System.Drawing.Color.Black
        Me.btnSchoolCashbook.Image = Global.SchoolDemo.My.Resources.Resources._129
        Me.btnSchoolCashbook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchoolCashbook.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSchoolCashbook.Location = New System.Drawing.Point(3, 207)
        Me.btnSchoolCashbook.Name = "btnSchoolCashbook"
        Me.btnSchoolCashbook.Size = New System.Drawing.Size(753, 45)
        Me.btnSchoolCashbook.TabIndex = 34
        Me.btnSchoolCashbook.Tag = "View the school's cashbook."
        Me.btnSchoolCashbook.Text = "Cashbook"
        Me.btnSchoolCashbook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnExpenseIncome
        '
        Me.btnExpenseIncome.Animated = True
        Me.btnExpenseIncome.BorderRadius = 10
        Me.btnExpenseIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenseIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenseIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExpenseIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenseIncome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExpenseIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExpenseIncome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExpenseIncome.FillColor = System.Drawing.Color.PowderBlue
        Me.btnExpenseIncome.FillColor2 = System.Drawing.Color.LightGray
        Me.btnExpenseIncome.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExpenseIncome.ForeColor = System.Drawing.Color.Black
        Me.btnExpenseIncome.Image = Global.SchoolDemo.My.Resources.Resources._2771
        Me.btnExpenseIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnExpenseIncome.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnExpenseIncome.Location = New System.Drawing.Point(3, 258)
        Me.btnExpenseIncome.Name = "btnExpenseIncome"
        Me.btnExpenseIncome.Size = New System.Drawing.Size(753, 45)
        Me.btnExpenseIncome.TabIndex = 38
        Me.btnExpenseIncome.Tag = "View the Expense/Income report."
        Me.btnExpenseIncome.Text = "Income / Expense Report"
        Me.btnExpenseIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmBanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.pnlFlowMain)
        Me.Controls.Add(Me.lblAddtionalInfoBanking)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBanking"
        Me.Text = "Banking"
        Me.pnlFlowMain.ResumeLayout(False)
        Me.pnlCashbookDrop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddtionalInfoBanking As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlFlowMain As FlowLayoutPanel
    Friend WithEvents btnInvoiceAccounts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSchoolCashbook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pnlCashbookDrop As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnExpenses As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnReceipts As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSchoolFees As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnCashBook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnOutStandingFees As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFeesStatements As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnExpenseIncome As Guna.UI2.WinForms.Guna2GradientButton
End Class
