Imports System.Web.UI.Design.WebControls
Imports DatabaseSelectStatements

Public Class FrmReports
    Dim selectStatement As New SelectStats()

    Private Sub BtnCashBook_MouseHover(sender As Object, e As EventArgs) Handles btnStudentReports.MouseHover, btnHighAchievers.MouseHover, btnCashBook.MouseHover, btnKPI.MouseHover, btnAttendacy.MouseHover, btnAreasOfConcern.MouseHover
        lblAddtionalInfoReports.Text = sender.Tag
    End Sub

    Private Sub BtnAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentReports.Click, btnHighAchievers.Click, btnCashBook.Click, btnKPI.Click, btnAttendacy.Click, btnAreasOfConcern.Click
        Select Case sender.name

            Case "btnKPI"
                If pnlKPIsDrop.Height = 178 Then pnlKPIsDrop.Height = 59 Else pnlKPIsDrop.Height = 178

            Case "btnStudentReports"
                ShowReport()

        End Select
    End Sub

    Private Sub ShowReport()
        Dim datatable As DataTable = selectStatement.GetNamesFromTable()

        Dim reportForm As New FrmStudentReport(datatable, "DTSStudents")
        reportForm.Show()

    End Sub
End Class