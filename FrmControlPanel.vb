Imports Guna.UI2.WinForms
Imports Frond_End_Design
Imports DatabaseSelectStatements

Public Class FrmControlPanel
    Dim selectStatement As New SelectStats
    Private _darkmode As Boolean
    Private design As New Design
    Private _conn As String
    Private _UpdateForm As Homepage
    Public Sub New(darkmode As Boolean, conn As String, openedForm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _UpdateForm = openedForm
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub FrmControlPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _darkmode Then
            pnlFlowMain.BackColor = Color.FromArgb(40, 30, 50)
        Else
            pnlFlowMain.BackColor = Color.White
        End If

    End Sub
    Private Sub btnRates_MouseHover(sender As Object, e As EventArgs) Handles btnUserAccounts.MouseHover, btnTerm.MouseHover, btnStudentDetails.MouseHover, btnRates.MouseHover, btnConfiguration.MouseHover, btnClassFees.MouseHover, btnAttendancy.MouseHover
        lblAddtionalInfoAdmissions.Text = sender.Tag
    End Sub

    Private Sub btn_Click_1(sender As Object, e As EventArgs) Handles btnUserAccounts.Click, btnTerm.Click, btnStudentDetails.Click, btnRates.Click, btnConfiguration.Click, btnClassFees.Click, btnAttendancy.Click, btnFaculty.Click
        Select Case sender.name

            Case "btnTerm"
                Dim message As String = "Term"
                Dim frm As New FrmAdjustments(message, _darkmode, _conn, _UpdateForm, 0)
                frm.Show()

            Case "btnStudentDetails"
                If pnlDropStudentDetails.Height = 352 Then pnlDropStudentDetails.Height = 56 Else pnlDropStudentDetails.Height = 352

            Case "btnRates"
                Dim message As String = "Rates"
                Dim frm As New FrmAdjustments(message, _darkmode, _conn, _UpdateForm, 0)
                frm.Show()

            Case "btnFaculty"
                If pnlDropFaculty.Height = 235 Then pnlDropFaculty.Height = 56 Else pnlDropFaculty.Height = 235

            Case "btnAttendancy"
                Dim dt As DataTable = selectStatement.GetTerm(_conn)
                Dim termRow As DataRow = dt.Rows(0)

                Dim frm As New FrmRegisterSelection(_darkmode, "Register Filter", termRow("at_term"), _UpdateForm, _conn)
                frm.ShowDialog()

            Case "btnClassFees"
                Dim message As String = "Fees Structure"
                Dim frm As New FrmAdjustments(message, _darkmode, _conn, _UpdateForm, 0)
                frm.Show()

            Case "btnUserAccounts"
                If pnlUserAccountsDrop.Height = 176 Then pnlUserAccountsDrop.Height = 56 Else pnlUserAccountsDrop.Height = 176

            Case "btnConfiguration"
                If _UpdateForm.lblConnectedUser.Text = "DrFunTimes" Then
                    Dim frm As New FrmConfigurations(_darkmode, _UpdateForm, _conn)
                    frm.ShowDialog()
                Else
                End If
        End Select
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnUserActivity.Click, btnStudentSubjects.Click, btnStudentPersonalDetails.Click, btnStudentMedicalDetails.Click, btnRemoveUser.Click, btnRemoveStudent.Click, btnGuardianDetails.Click, btnRemoveFaculty.Click, btnFacultyPersonalDetails.Click, btnFacultySubjects.Click

        Select Case sender.name
            Case "btnStudentSubjects"
                Dim message As String = "Student Subject Details"
                Dim frm As New FrmSelectStudent(message, _darkmode, _UpdateForm, _conn)
                frm.Show()


            Case "btnStudentMedicalDetails"
                Dim message As String = "Student Medical Details"
                Dim frm As New FrmSelectStudent(message, _darkmode, _UpdateForm, _conn)
                frm.Show()

            Case "btnGuardianDetails"
                Dim message As String = "Student Guardian Details"
                Dim frm As New FrmSelectStudent(message, _darkmode, _UpdateForm, _conn)
                frm.Show()

            Case "btnStudentPersonalDetails"

                Dim message As String = "Student Personal Details"
                Dim frm As New FrmSelectStudent(message, _darkmode, _UpdateForm, _conn)
                frm.Show()

            Case "btnRemoveStudent"
                Dim message As String = "Remove Student"
                Dim frm As New FrmSelectStudent(message, _darkmode, _UpdateForm, _conn)
                frm.Show()

            Case "btnFacultySubjects"
                Dim facultySelection As New FrmSelectStudent("Faculty Subjects", _darkmode, _UpdateForm, _conn)
                facultySelection.ShowDialog()

            Case "btnRemoveUser"
                Dim frm As New FrmRegisterSelection(_darkmode, "New User", _UpdateForm.lblConnectedUser.Text, _UpdateForm, _conn)
                frm.ShowDialog()

            Case "btnRemoveFaculty"
                Dim facultySelection As New FrmSelectStudent("Remove Faculty", _darkmode, _UpdateForm, _conn)
                facultySelection.ShowDialog()

            Case "btnFacultyPersonalDetails"
                Dim facultySelection As New FrmSelectStudent("Faculty Personal Details", _darkmode, _UpdateForm, _conn)
                facultySelection.ShowDialog()

            Case "btnUserActivity"
                Dim datatable As DataTable = selectStatement.GetUserActivity(_conn)

                Dim reportForm As New FrmStudentReport(datatable, "UserActivity", "UserActivity", _darkmode)
                reportForm.ShowDialog()

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
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoAdmissions
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnTerm,
            btnStudentDetails,
            btnRates,
            btnFaculty,
            btnAttendancy,
            btnUserAccounts,
            btnClassFees,
            btnUserAccounts,
            btnConfiguration
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