﻿Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmBanking
    Dim selectStatement As New SelectStats()
    Private design As New Design
    Private _darkMode As Boolean
    Private _conn As String
    Private _term As String
    Private _frm As Homepage

    Public Sub New(darkmode As Boolean, frm As Form, term As String, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _conn = conn
        _darkMode = darkmode
        _term = term
        If _darkMode Then design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub FrmBanking_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _darkMode Then
            pnlFlowMain.BackColor = Color.FromArgb(40, 30, 50)
        Else
            pnlFlowMain.BackColor = Color.White
        End If
    End Sub

    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnSchoolCashbook.MouseHover, btnOutStandingFees.MouseHover, btnInvoiceAccounts.MouseHover, btnFeesStatements.MouseHover, btnCashBook.MouseHover, btnExpenseIncome.MouseHover
        lblAddtionalInfoBanking.Text = sender.Tag
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnSchoolCashbook.Click, btnOutStandingFees.Click, btnInvoiceAccounts.Click, btnFeesStatements.Click, btnCashBook.Click, btnExpenseIncome.Click

        Select Case sender.name

            Case "btnCashBook"
                If pnlCashbookDrop.Height = 237 Then pnlCashbookDrop.Height = 59 Else pnlCashbookDrop.Height = 237

            Case "btnFeesStatements"

                Dim formID As String
                formID = "studentFeesStatement"
                Dim selectStudent As New FrmSelectStudent(formID, _darkMode, _frm, _conn)
                selectStudent.Show()

            Case "btnSchoolCashbook"
                Dim dt As DataTable = selectStatement.GetCashBook(_conn)

                Dim reportForm As New FrmStudentReport(dt, "Cashbook", "Cashbook", _darkMode)
                reportForm.Show()

            Case "btnOutStandingFees"
                Dim dt As DataTable = selectStatement.GetOutstandingFees(_conn)

                Dim reportForm As New FrmStudentReport(dt, "FeesOwing", "FeesOwing", _darkMode)
                reportForm.Show()

            Case "btnInvoiceAccounts"

                Dim formID As String = "Invoice Students"
                Dim selectStudent As New FrmRegisterSelection(_darkMode, formID, _term, _frm, _conn)
                selectStudent.ShowDialog()

            Case "btnExpenseIncome"
                Dim dt As DataTable = selectStatement.GetExpenseIncome(_conn)

                Dim reportForm As New FrmStudentReport(dt, "ExpenseIncome", "ExpenseIncome", _darkMode)
                reportForm.Show()

        End Select
    End Sub

    Private Sub btnDrops_Click(sender As Object, e As EventArgs) Handles btnReceipts.Click, btnExpenses.Click, btnSchoolFees.Click

        Select Case sender.name
            Case "btnReceipts"
                Dim frm As New FrmReceipts(_darkMode, _frm, _conn)
                frm.ShowDialog()

            Case "btnExpenses"
                Dim frm As New FrmPayment(_darkMode, _frm, _conn)
                frm.ShowDialog()

            Case "btnSchoolFees"
                Dim formID As String = "FrmTuition"
                Dim selectStudent As New FrmSelectStudent(formID, _darkMode, _frm, _conn)
                selectStudent.Show()

        End Select
    End Sub

    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton)
        Return sidebarButtons
    End Function

    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton)
        Return pagebuttons
    End Function

    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
        }
        Return topPanels
    End Function

    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoBanking
        }
        Return labels
    End Function

    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
             btnFeesStatements,
             btnCashBook,
             btnSchoolCashbook,
             btnOutStandingFees,
             btnInvoiceAccounts,
             btnExpenseIncome
        }

        Return pagebuttons
    End Function

    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox)
        Return placeholder
    End Function

    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox)
        Return placeholder
    End Function

    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function

    Private Sub btnFeesStatements_Click(sender As Object, e As EventArgs)

    End Sub

End Class