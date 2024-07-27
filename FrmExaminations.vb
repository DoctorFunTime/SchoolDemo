Imports System.Web

Public Class FrmExaminations
    Private Sub btnUploadMarks_MouseHover(sender As Object, e As EventArgs) Handles btnUploadMarks.MouseHover, pnlDragExams.MouseHover
        lblAddtionalInfoExaminations.Text = sender.Tag
    End Sub
    'Button clicks
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnUploadMarks.Click, btnExaminationsAdd.Click

        Select Case sender.name

            Case "btnExaminationsAdd"

                Dim OpenFileDialoge = New OpenFileDialog With {
                    .InitialDirectory = "C:\",
                    .FilterIndex = 1,
                    .Filter = "All files (*.*)|*.*",
                    .RestoreDirectory = True,
                    .Multiselect = True
                }

                If OpenFileDialoge.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = OpenFileDialoge.FileName
                    MessageBox.Show(filePath)
                End If

            Case "btnUploadMarks"
                If pnlExamDrop.Height = 178 Then pnlExamDrop.Height = 59 Else pnlExamDrop.Height = 178

        End Select
    End Sub

    Private Sub PnlDragExams_DragEnter(sender As Object, e As DragEventArgs) Handles pnlDragExams.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub PnlDragExamsDrop_DragEnter(sender As Object, e As DragEventArgs) Handles pnlDragExams.DragDrop

        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        If files IsNot Nothing AndAlso files.Length > 0 Then

            Dim filepath As String = files(0)
            MessageBox.Show(filepath)

        End If
    End Sub
End Class