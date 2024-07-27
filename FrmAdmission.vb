Public Class FrmAdmission
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnStudentReports.MouseHover, btnFacultyMembers.MouseHover, btnEnrollment.MouseHover, btnAttendance.MouseHover
        lblAddtionalInfoAdmissions.Text = sender.Tag
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnStudentReports.Click, btnFacultyMembers.Click, btnEnrollment.Click, btnClassRegister.Click, btnAttendance.Click

        Select Case sender.name
            Case "btnAttendance"
                If pnlAttendacyDrop.Height = 178 Then pnlAttendacyDrop.Height = 59 Else pnlAttendacyDrop.Height = 178
            Case "btnStudentReports"
                If pnlStudentReportsDrop.Height = 237 Then pnlStudentReportsDrop.Height = 59 Else pnlStudentReportsDrop.Height = 237
            Case "btnEnrollment"
                FrmEnrollment.Show()
            Case "btnFacultyMembers"
                FrmFaculty.Show()
        End Select

    End Sub
End Class