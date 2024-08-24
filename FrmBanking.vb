Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Public Class FrmBanking
    Dim selectStatement As New SelectStats()
    Private design As New Design
    Private _darkMode As Boolean
    Public Sub New(darkmode)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _darkMode = darkmode
        If _darkMode Then design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnFeesStatements.MouseHover, btnCashBook.MouseHover, btnSchoolCashbook.MouseHover, btnFeesStanding.MouseHover
        lblAddtionalInfoBanking.Text = sender.Tag
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnFeesStatements.Click, btnCashBook.Click, btnSchoolCashbook.Click, btnFeesStanding.Click

        Select Case sender.name

            Case "btnCashBook"
                If pnlCashbookDrop.Height = 237 Then pnlCashbookDrop.Height = 59 Else pnlCashbookDrop.Height = 237

            Case "btnFeesStatements"

                Dim formID As String
                formID = "studentFeesStatement"
                Dim selectStudent As New FrmSelectStudent(formID, _darkMode, Me)
                selectStudent.ShowDialog()

            Case "btnSchoolCashbook"
                Dim dt As DataTable = selectStatement.GetCashBook()

                Dim reportForm As New FrmStudentReport(dt, "Cashbook", "Cashbook", _darkMode)
                reportForm.Show()

            Case "btnFeesStanding"
                Dim dt As DataTable = selectStatement.GetFeesStatementStanding()

                Dim reportForm As New FrmStudentReport(dt, "Standing", "Standing", _darkMode)
                reportForm.Show()

        End Select
    End Sub
    Private Sub btnDrops_Click(sender As Object, e As EventArgs) Handles btnReceipts.Click, btnExpenses.Click, btnSchoolFees.Click

        Select Case sender.name
            Case "btnReceipts"
                Dim frm As New FrmReceipts(_darkMode)
                frm.ShowDialog()

            Case "btnExpenses"
                Dim frm As New FrmPayment(_darkMode)
                frm.ShowDialog()

            Case "btnSchoolFees"
                Dim formID As String = "FrmTuition"
                Dim selectStudent As New FrmSelectStudent(formID, _darkMode, Me)
                selectStudent.ShowDialog()

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
            flowpnl
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
             btnFeesStanding
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
End Class