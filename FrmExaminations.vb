Imports System.Web
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmExaminations
    Private design As New Design
    Private _darkmode As Boolean

    Public Sub New(darkmode)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnUploadMarks_MouseHover(sender As Object, e As EventArgs) Handles btnUploadMarks.MouseHover, pnlDragExams.MouseHover, btnManageMarks.MouseHover, btnViewExams.MouseHover
        lblAddtionalInfoExaminations.Text = sender.Tag
    End Sub
    'Button clicks
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnUploadMarks.Click, btnExaminationsAdd.Click, btnManageMarks.Click

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
                Dim frm As New FrmSelectClass("Upload Exam", _darkmode)
                frm.ShowDialog()

            Case "btnManageMarks"
                Dim frm As New FrmSelectClass("Manage Exams", _darkmode)
                frm.ShowDialog()

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
    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton)
        Return sidebarButtons
    End Function

    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
        }

        Return pagebuttons
    End Function
    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            flowpnl,
            pnlDragExams
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoAdmissions,
            lblAddtionalInfoExaminations
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnUploadMarks,
           btnExaminationsAdd,
           btnManageMarks,
           btnViewExams
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