Imports System.Drawing.Text
Imports DatabaseSelectStatements
Imports Guna.UI2.WinForms
Imports Frond_End_Design
Imports MyEncapsulation

Public Class FrmSelectClass
    Private selctStatement As New SelectStats
    Private design As New Design
    Private classList As DataTable
    Private examList As DataTable
    Private _message As String
    Private _term As String
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage
    Public notifications As New List(Of Notifications)
    Public Sub New(message As String, darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _conn = conn
        classList = selctStatement.GetClasses(_conn)
        _message = message
        _darkmode = darkmode
        design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmSelectClass_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMflowPanel()

        If _message = "Manage Exams" Then

            cmbBoxClass.Visible = True
            lblHeading.Text = "Exam Selection"

            For Each row In classList.Rows
                Dim sclass As String = row("cl_class").ToString
                cmbBoxClass.Items.Add(sclass)
            Next

        ElseIf _message = "Notifications" Then
            lblHeading.Text = "Notifications"
            For Each notif In notifications
                classButton(notif.text, notif.buttonName)
            Next
        Else
            For Each row In classList.Rows
                Dim sclass As String = row("cl_class").ToString
                classButton(sclass)
            Next
        End If

        Dim activeTerm As DataTable = selctStatement.GetTerm(_conn)
        For Each row In activeTerm.Rows
            Dim term As String = row("at_term").ToString
            _term = term
        Next

    End Sub

    Private Sub classButton(message As String)

        Dim color1 As Color
        Dim color2 As Color
        Dim forecolor As Color
        Dim bordercolor As Color

        If _darkmode Then
            color1 = Color.FromArgb(40, 30, 100)
            color2 = Color.FromArgb(60, 40, 120)
            forecolor = Color.White
            bordercolor = Color.FromArgb(40, 30, 90)
            pnlFlwClasses.BackColor = Color.FromArgb(40, 30, 90)
        Else

            color1 = Color.PowderBlue
            color2 = Color.LightGray
            forecolor = Color.Black
            bordercolor = Color.White
            pnlFlwClasses.BackColor = Color.White
        End If

        Dim classButton As New Guna2GradientButton With {
            .Text = message,
            .TextAlign = HorizontalAlignment.Center,
            .Font = New Font("Century Gothic", 14),
            .ForeColor = forecolor,
            .Size = New Size(180, 150),
            .Cursor = Cursors.Hand,
            .Animated = True,
            .BorderRadius = 5,
            .BorderThickness = 1,
            .BorderColor = bordercolor,
            .FillColor = color1,
            .FillColor2 = color2,
            .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal,
            .Dock = DockStyle.Top
        }

        AddHandler classButton.Click, AddressOf classButtonClicked

        pnlFlwClasses.Controls.Add(classButton)

    End Sub
    Private Sub classButton(message As String, subjectName As String)

        Dim color1 As Color
        Dim color2 As Color
        Dim forecolor As Color
        Dim bordercolor As Color

        If _darkmode Then
            color1 = Color.FromArgb(40, 30, 100)
            color2 = Color.FromArgb(60, 40, 120)
            forecolor = Color.White
            bordercolor = Color.FromArgb(40, 30, 90)
            pnlFlwClasses.BackColor = Color.FromArgb(40, 30, 90)
        Else
            color1 = Color.PowderBlue
            color2 = Color.LightGray
            forecolor = Color.Black
            bordercolor = Color.White
            pnlFlwClasses.BackColor = Color.White
        End If

        Dim pnlDock As New Guna2GradientPanel With {
            .BorderRadius = 0,
            .BorderThickness = 1,
            .BorderColor = bordercolor,
            .FillColor = color1,
            .FillColor2 = color2,
            .Size = New Size(180, 150),
            .Cursor = Cursors.Hand
           }

        Dim classButton As New Guna2GradientButton With {
            .Text = message,
            .TextAlign = HorizontalAlignment.Left,
            .Font = New Font("Century Gothic", 14),
            .ForeColor = forecolor,
            .Height = 120,
            .Cursor = Cursors.Hand,
            .Animated = True,
            .BorderRadius = 0,
            .BorderThickness = 1,
            .BorderColor = bordercolor,
            .FillColor = color1,
            .FillColor2 = color2,
            .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal,
            .Tag = subjectName,
            .Dock = DockStyle.Top
        }

        Dim subject As New Guna2HtmlLabel With {
            .Text = subjectName,
            .Font = New Font("Century Gothic", 10, FontStyle.Bold),
            .ForeColor = forecolor,
            .Cursor = Cursors.Hand,
            .Height = 30,
            .Location = New Point(pnlDock.Location.X + 6, pnlDock.Location.Y + classButton.Height + 6)
        }

        AddHandler classButton.Click, AddressOf classButtonClicked


        pnlDock.Controls.Add(classButton)
        pnlDock.Controls.Add(subject)
        pnlFlwClasses.Controls.Add(pnlDock)

    End Sub

    Private Sub classButtonClicked(sender As Object, e As EventArgs)

        Select Case _message

            Case "Class Register"

                Dim register As New FrmRegister($"{sender.text}", "", Date.Today, _term, _term, _darkmode, _frm, _conn)
                register.ShowDialog()

            Case "Upload Exam"
                Dim frm As New FrmUploadExam($"{sender.text}", _term, $"{sender.tag}", _message, _darkmode, _frm, _conn)
                frm.ShowDialog()

            Case "Manage Exams"

                Dim frm As New FrmUploadExam($"{sender.tag}", _term, $"{sender.text}", _message, _darkmode, _frm, _conn)
                frm.ShowDialog()

            Case "Notifications"

                Select Case sender.text
                    Case "Complete Registers"
                        Dim FormID As String = "Class Register"
                        Dim frm As New FrmSelectClass(FormID, _darkmode, _frm, _conn)
                        frm.ShowDialog()

                    Case "Activation Key"
                        _frm.btnActivateKey.PerformClick()
                        _frm.notifications.Clear()
                        _frm.notificationUpdate()

                    Case "Incoming Events (Next 7 Days)"
                        Dim frm As New FrmEventsPlanner(_darkmode, _frm, _conn)
                        frm.ShowDialog()

                    Case "Students Not Invoiced"
                        Dim formID As String = "Invoice Students"
                        Dim selectStudent As New FrmRegisterSelection(_darkmode, formID, _term, _frm, _conn)
                        selectStudent.ShowDialog()


                End Select
                Close()
        End Select

    End Sub

    Private Sub cmbBoxClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBoxClass.SelectedValueChanged
        examList = selctStatement.GetStudentGradesSubjectSelection(sender.text, _term, _conn)

        pnlFlwClasses.Controls.Clear()

        For Each row In examList.Rows
            Dim ExamName As String = row("e_exam").ToString
            Dim subject As String = row("e_subject").ToString
            classButton(ExamName, subject)
        Next

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
            pnlTopBar
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblHeading
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton)
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox)
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxClass
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function
    Private Sub DKMflowPanel()
        If _darkmode Then
            pnlFlwClasses.BackColor = Color.FromArgb(40, 30, 90)
        Else
            pnlFlwClasses.BackColor = Color.White
        End If
    End Sub
End Class