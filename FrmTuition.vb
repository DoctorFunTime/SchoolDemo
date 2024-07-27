Public Class FrmTuition
    Public formID As String
    Private Sub studentSelection_Click(sender As Object, e As EventArgs) Handles btnStudent.Click, btnClose.Click, btnConfirm.Click

        Select Case sender.name
            Case "btnStudent"
                formID = "FrmTuition"
                Dim selectStudent As New FrmSelectStudent(formID)
                selectStudent.ShowDialog()

            Case "btnClose"
                Close()

            Case "btnConfirm"

        End Select


    End Sub

End Class