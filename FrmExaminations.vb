Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmExaminations
    Private design As New Design
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub FrmExaminations_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _darkmode Then
            pnlFlowMain.BackColor = Color.FromArgb(40, 30, 50)
        Else
            pnlFlowMain.BackColor = Color.White
        End If
    End Sub

    Private Sub btnUploadMarks_MouseHover(sender As Object, e As EventArgs) Handles btnUploadMarks.MouseHover, btnManageMarks.MouseHover, btnExamMarks.MouseHover, btnStudentMarks.MouseHover
        lblAddtionalInfoExaminations.Text = sender.Tag
    End Sub

    'Button clicks
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnUploadMarks.Click, btnManageMarks.Click, btnExamMarks.Click, btnStudentMarks.Click

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
                Dim frm As New FrmSelectClass("Upload Exam", _darkmode, _frm, _conn)
                frm.Show()

            Case "btnManageMarks"
                Dim frm As New FrmSelectClass("Manage Exams", _darkmode, _frm, _conn)
                frm.Show()

            Case "btnExamMarks"
                Dim frm As New FrmSelectClass("View Exams", _darkmode, _frm, _conn)
                frm.Show()

            Case "btnStudentMarks"
                Dim frm As New FrmSelectClass("Add Student Marks", _darkmode, _frm, _conn)
                frm.Show()

        End Select
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
        }
        Return topPanels
    End Function

    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoExaminations
        }
        Return labels
    End Function

    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnUploadMarks,
           btnManageMarks,
           btnExamMarks,
           btnStudentMarks
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