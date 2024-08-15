Public Class FrmAdmission
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnFacultyMembers.MouseHover, btnEnrollment.MouseHover, btnAttendance.MouseHover
        lblAddtionalInfoAdmissions.Text = sender.Tag
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnFacultyMembers.Click, btnEnrollment.Click, btnAttendance.Click

        Select Case sender.name
            Case "btnAttendance"
                FrmSelectClass.ShowDialog()
            Case "btnEnrollment"
                FrmEnrollment.Show()
            Case "btnFacultyMembers"
                FrmFaculty.Show()
        End Select

    End Sub
End Class