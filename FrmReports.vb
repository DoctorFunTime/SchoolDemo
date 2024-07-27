Public Class FrmReports
    Private Sub btnCashBook_MouseHover(sender As Object, e As EventArgs) Handles btnStudentReports.MouseHover, btnHighAchievers.MouseHover, btnCashBook.MouseHover, btnKPI.MouseHover, btnAttendacy.MouseHover, btnAreasOfConcern.MouseHover
        lblAddtionalInfoReports.Text = sender.Tag
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentReports.Click, btnHighAchievers.Click, btnCashBook.Click, btnKPI.Click, btnAttendacy.Click, btnAreasOfConcern.Click
        Select Case sender.name
            Case "btnKPI"
                If pnlKPIsDrop.Height = 178 Then pnlKPIsDrop.Height = 59 Else pnlKPIsDrop.Height = 178

        End Select
    End Sub
End Class