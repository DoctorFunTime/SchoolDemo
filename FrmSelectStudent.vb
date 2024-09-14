Imports DatabaseSelectStatements
Imports Guna.UI2.WinForms
Imports Frond_End_Design
Imports System.Web.Security
Imports SQLDeleteStatements

Public Class FrmSelectStudent

    Dim selectStatement As New SelectStats()
    Public FMID As Integer
    Public stID As Integer
    Public stName As String
    Public stSurname As String
    Public stClass As String
    Public _targetForm As String
    Private design As New Design
    Private classList As DataTable
    Private _darkmode As Boolean
    Private facultyForm As FrmFaculty
    Private enrolForm As FrmEnrollment
    Private _conn As String
    Private _term As String
    Public _frm As Homepage


    Public Sub New(targetForm As String, darkmode As Boolean, openForm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        Select Case openForm.Name
            Case "FrmFaculty"
                facultyForm = openForm
            Case "FrmEnrollment"
                enrolForm = openForm
            Case "Homepage"
                _frm = openForm
        End Select
        _conn = conn
        ' initialization after the InitializeComponent() call.
        _targetForm = targetForm
        classList = selectStatement.GetClasses(_conn)
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnToggleFilter.Click, btnFilter.Click

        Select Case sender.name
            Case "btnClose"
                Close()

            Case "btnClear"
                cmbBoxClass.Text = ""

            Case "btnFilter"
                StudentFilters()
                pnlControls.Width = 35

            Case "btnToggleFilter"
                lblClass.Visible = True
                lblName.Visible = True
                lblSurname.Visible = True

                If pnlControls.Width = 35 Then
                    pnlControls.Width = 575
                Else
                    pnlControls.Width = 35
                End If
        End Select
    End Sub
    Private Sub FrmSelectStudent_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMgrid()

        If _targetForm = "New Faculty" Or _targetForm = "Faculty Details" Or _targetForm = "Faculty Personal Details" Or _targetForm = "Faculty Subjects" Or _targetForm = "Remove Faculty" Then

            Dim classes As DataTable = selectStatement.GetClasses(_conn)
            Dim datatable As DataTable = selectStatement.GetFacultyFromTable(_conn)
            DataGridView.DataSource = datatable

            For Each row As DataRow In classes.Rows
                Dim sclass As String = row("cl_class").ToString
                cmbBoxClass.Items.Add(sclass)
            Next

            lblHeading.Text = "Faculty Selection"
        Else
            Dim datatable As DataTable = selectStatement.GetNamesFromTable(_conn)
            DataGridView.DataSource = datatable

            For Each row As DataRow In classList.Rows
                Dim sclass As String = row("cl_class").ToString
                cmbBoxClass.Items.Add(sclass)
            Next
        End If

        Dim dt As DataTable = selectStatement.GetTerm(_conn)
        For Each row In dt.Rows
            _term = row("at_term")
        Next

    End Sub
    Private Sub DataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView.DoubleClick

        Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

        If _targetForm = "New Faculty" Or _targetForm = "Faculty Details" Or _targetForm = "Faculty Personal Details" Or _targetForm = "Faculty Subjects" Or _targetForm = "Remove Faculty" Then
            FMID = selectedRow.Cells("faculty_id").Value
            stName = selectedRow.Cells("name").Value
            stSurname = selectedRow.Cells("surname").Value

            Select Case _targetForm

                Case "New Faculty"
                    facultyForm.newFmID = FMID

                Case "Faculty Details"
                    Dim datatable As DataTable = selectStatement.GetFacultyProfile(FMID, _conn)

                    Dim reportForm As New FrmStudentReport(datatable, "FacultyDetails", "FacultyDetails", _darkmode)
                    reportForm.ShowDialog()

                Case "Faculty Personal Details"
                    Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, 0) With {
                        ._FMID = FMID
                    }

                    frm.ShowDialog()

                Case "Faculty Subjects"
                    Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, 0) With {
                        ._FMID = FMID
                    }
                    frm.ShowDialog()

                Case "Remove Faculty"

                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "*You are about to remove a Faculty member and all associated records from the system." & vbCrLf & "*Please note this process cannot be reversed." & vbCrLf & vbCrLf & "Proceed?",
                        .Parent = Me,
                        .Buttons = MessageDialogButtons.YesNo,
                        .Style = MessageDialogStyle.Dark,
                        .Icon = MessageDialogIcon.Warning,
                        .Caption = "Warning!"
                    }

                    Dim result As DialogResult = CustomMessageBox.Show
                    If result = DialogResult.Yes Then
                        DeleteStatement.DeleteFaculty(FMID, _frm.lblConnectedUser.Text, _conn)
                    Else
                        Close()
                    End If

            End Select

        Else

            stID = selectedRow.Cells("student_id").Value
            stName = selectedRow.Cells("name").Value
            stSurname = selectedRow.Cells("surname").Value
            stClass = selectedRow.Cells("class").Value

            Select Case _targetForm

                Case "FrmTuition"
                    Dim frm As New FrmTuition(stName & " " & stSurname, stID, _darkmode, _frm, _conn)
                    frm.ShowDialog()

                Case "Student Details"
                    Dim datatable As DataTable = selectStatement.GetStudentProfile(stID, _conn)

                    Dim reportForm As New FrmStudentReport(datatable, "stdDetails", "studentDetails", _darkmode)
                    reportForm.ShowDialog()

                Case "studentFeesStatement"
                    Dim datatable As DataTable = selectStatement.GetFeesStatement(stID, _conn)

                    Dim reportForm As New FrmStudentReport(datatable, "StudentFeesStatement", "FeesStatement", _darkmode)
                    reportForm.ShowDialog()

                Case "Enrollment"

                    enrolForm.newStdID = stID

                Case "Attendacy record"
                    Dim dt As DataTable = selectStatement.GetIndividualAttendacyRecords(stID, _conn)

                    Dim reportForm As New FrmStudentReport(dt, "AttendacyRecords", "AttendacyRecords", _darkmode)
                    reportForm.ShowDialog()

                Case "Student Grades"
                    Dim dt As DataTable = selectStatement.GetStudentGrades(stID, _term, _conn)

                    Dim reportForm As New FrmStudentReport(dt, "StudentGrades", "StudentGrades", _darkmode)
                    reportForm.ShowDialog()

                Case "Exam Growth"

                    Dim datatable As DataTable = selectStatement.GetStudentExamGrowth(stID, _term, _conn)

                    Dim reportForm As New FrmStudentReport(datatable, "ExamGrowth", "ExamGrowth", _darkmode)
                    reportForm.ShowDialog()

                Case "Student Personal Details"

                    Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, stID)
                    frm.Show()

                Case "Student Guardian Details"

                    Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, stID)
                    frm.Show()

                Case "Student Medical Details"

                    Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, stID)
                    frm.Show()

                Case "Student Subject Details"

                    Dim CustomMessageBox As New Guna2MessageDialog With {
                    .Text = "*Please note that changing a student's subjects will result in the deletion of their previously recorded grades." & vbCrLf & vbCrLf & "Proceed?",
                    .Parent = Me,
                    .Buttons = MessageDialogButtons.YesNo,
                    .Style = MessageDialogStyle.Dark,
                    .Icon = MessageDialogIcon.Warning,
                    .Caption = "Warning!"
                    }

                    Dim result As DialogResult = CustomMessageBox.Show
                    If result = DialogResult.Yes Then
                        Dim frm As New FrmAdjustments(_targetForm, _darkmode, _conn, _frm, stID)
                        frm.Show()
                    Else
                        Close()
                    End If

                Case "Remove Student"
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                    .Text = "*You are about to remove a student and all associated records from the system." & vbCrLf & "*Please note this process cannot be reversed." & vbCrLf & vbCrLf & "Proceed?",
                    .Parent = Me,
                    .Buttons = MessageDialogButtons.YesNo,
                    .Style = MessageDialogStyle.Dark,
                    .Icon = MessageDialogIcon.Warning,
                    .Caption = "Warning!"
                    }

                    Dim result As DialogResult = CustomMessageBox.Show
                    If result = DialogResult.Yes Then
                        DeleteStatement.DeleteStudent(stID, _frm.lblConnectedUser.Text, _conn)
                    Else
                        Close()
                    End If

            End Select
        End If

        Close()

    End Sub
    Private Sub StudentFilters()

        Dim dgSurname As String = txtSurname.Text
        Dim dgName As String = txtName.Text
        Dim dgClass As String = cmbBoxClass.Text

        If _targetForm = "New Faculty" Then

            Dim datatable As DataTable = selectStatement.GetFacultyFromTable(_conn)
            If String.IsNullOrEmpty(dgName) And String.IsNullOrEmpty(dgClass) And String.IsNullOrEmpty(dgSurname) Then
                DataGridView.DataSource = datatable
            Else
                Dim filterText As String = $"name = '{dgName}' OR role = '{dgClass}' OR surname = '{dgSurname}'"
                Dim dataView As New DataView(datatable) With {
                    .RowFilter = filterText
                }
                DataGridView.DataSource = dataView
            End If

        Else

            Dim datatable As DataTable = selectStatement.GetNamesFromTable(_conn)
            If String.IsNullOrEmpty(dgName) And String.IsNullOrEmpty(dgClass) And String.IsNullOrEmpty(dgSurname) Then
                DataGridView.DataSource = datatable
            Else
                Dim filterText As String = $"name = '{dgName}' OR class = '{dgClass}' OR surname = '{dgSurname}'"
                Dim dataView As New DataView(datatable) With {
                    .RowFilter = filterText
                }
                DataGridView.DataSource = dataView
            End If

        End If

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
            pnlContainerControls,
            pnlControls,
            pnlFillSpace,
            pnlFillspaceRight,
            pnlFillSpaceInSpace,
            pnlTopBar
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblSurname,
            lblName,
            lblHeading,
            lblClass
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnFilter,
           btnToggleFilter
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtSurname,
            txtName
        }
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
    Private Sub DKMgrid()
        If _darkmode Then
            DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 30, 90)
            DataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.LightGray
            DataGridView.BackgroundColor = Color.FromArgb(40, 30, 90)
            DataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 30, 120)
            DataGridView.RowsDefaultCellStyle.ForeColor = Color.LightGray
            DataGridView.GridColor = Color.FromArgb(40, 30, 90)
        Else
            DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White
            DataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
            DataGridView.BackgroundColor = Color.White
            DataGridView.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView.RowsDefaultCellStyle.ForeColor = Color.Black
            DataGridView.GridColor = Color.FromArgb(231, 229, 255)
        End If
    End Sub

End Class