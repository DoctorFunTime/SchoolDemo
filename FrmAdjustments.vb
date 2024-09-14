Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports SQLDeleteStatements
Imports SQLUpdateStatements
Imports UpdateEncapsulation

Public Class FrmAdjustments
    Private design As New Design
    Private selectStatement As New SelectStats
    Private _darkmode As Boolean
    Private _conn As String
    Private _message As String
    Private _loadDate As Boolean = False
    Private updateHomepage As Homepage
    Public _stdId As Integer
    Public _FMID As Integer

    Public Sub New(message As String, darkmode As Boolean, conn As String, openedForm As Form, stdID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If openedForm.Name = "Homepage" Then updateHomepage = openedForm
        _stdId = stdID
        _message = message
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub FrmAdjustments_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMgrid()

        Select Case _message

            Case "Rates"
                dtePickerFilter.Value = Date.Today
                dtePickerFilter.Visible = True
                DataGridView.DataSource = selectStatement.GetAllRates(Date.Today, _conn)
                Dim readOnlyColumns As String() = {"id", "date", "code"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

                lblHeading.Text = $"Adjustments - {_message}"

            Case "Term"
                lblHeading.Text = $"Adjustments - {_message}"
                lblTerm.Visible = True
                cmbTerm.Visible = True

            Case "Student Personal Details"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetStudentUpdateDetails(_stdId, _conn)
                Dim readOnlyColumns As String() = {"student_id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

            Case "Student Guardian Details"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetStudentUpdateGuardian(_stdId, _conn)
                Dim readOnlyColumns As String() = {"student_id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

            Case "Student Medical Details"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetStudentUpdateMedicals(_stdId, _conn)
                Dim readOnlyColumns As String() = {"student_id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

            Case "Student Subject Details"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetStudentUpdateSubjects(_stdId, _conn)
                comboBoxColumn()
                Dim readOnlyColumns As String() = {"student_id", "subject_id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

            Case "Fees Structure"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetFeesStructureUpdatae(_conn)
                Dim readOnlyColumns As String() = {"id", "class"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

            Case "Faculty Personal Details"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetFacultyDetailsUpdate(_FMID, _conn)
                Dim readOnlyColumns As String() = {"id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next
                DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader

            Case "Faculty Subjects"
                lblHeading.Text = $"Adjustments - {_message}"
                DataGridView.DataSource = selectStatement.GetFacultySubjects(_FMID, _conn)
                comboBoxColumn()
                Dim readOnlyColumns As String() = {"faculty_id", "subject_id"}
                For Each colName As String In readOnlyColumns
                    DataGridView.Columns(colName).ReadOnly = True
                Next

        End Select

        _loadDate = True

    End Sub
    Private Sub comboBoxColumn()

        Dim subjectList As DataTable = selectStatement.GetSubjects(_conn)
        Dim ListBoxSubjects As New List(Of String)

        For Each row As DataRow In subjectList.Rows
            Dim subject As String = row("s_subject").ToString
            ListBoxSubjects.Add(subject)
        Next


        Dim columnIndex As Integer = DataGridView.Columns("subjects").Index
        DataGridView.Columns.Remove("subjects")
        Dim cmbColumn As New DataGridViewComboBoxColumn() With {
            .HeaderText = "Subjects",
            .Name = "Subjects",
            .DataPropertyName = "Subjects"
        }

        cmbColumn.Items.AddRange(ListBoxSubjects.ToArray())

        DataGridView.Columns.Insert(columnIndex, cmbColumn)
    End Sub
    Private Sub btnValidateAndFinalise_Click(sender As Object, e As EventArgs) Handles btnValidateAndFinalise.Click

        Select Case _message

            Case "Rates"
                Dim rates As New List(Of Rates)
                Dim dt As DataTable = dtGrid()

                For Each row In dt.Rows

                    Dim id As String = row("id")
                    Dim rDate As DateTime = row("date")
                    Dim rate As Decimal = 1 / row("rate")
                    Dim code As String = row("code")

                    Dim entries As New Rates(id, rDate, code, rate)
                    rates.Add(entries)
                    UpdateStatements.UpdateRates(updateHomepage.lblConnectedUser.Text, rates, _conn)
                    updateHomepage.Updates()
                    Close()
                Next

            Case "Term"
                If Not String.IsNullOrEmpty(cmbTerm.Text) Then
                    UpdateStatements.UpdateTerm(1, updateHomepage.lblConnectedUser.Text, cmbTerm.Text, _conn)
                    updateHomepage.Updates()
                    Close()
                Else
                    cmbTerm.BorderThickness = 2
                    cmbTerm.BorderColor = Color.Red
                    cmbTerm.Focus()
                End If

            Case "Student Personal Details"

                Dim stdPersonalDetails As New List(Of StudentDetails)
                Dim dt As DataTable = dtGrid()
                Dim row As DataRow = dt.Rows(0)

                Dim id As Integer = row("student_id")
                Dim name As String = row("name")
                Dim surname As String = row("surname")
                Dim sclass As String = row("class")
                Dim dob As DateTime = row("dob")
                Dim id_no As String = row("id_no")
                Dim address As String = row("address")
                Dim contacts As String = row("contacts")
                Dim email As String = row("email")
                Dim joinDate As DateTime = row("join_date")

                Dim newEntry As New StudentDetails(id, name, surname, sclass, dob, id_no, address, contacts, email, joinDate)
                stdPersonalDetails.Add(newEntry)
                UpdateStatements.UpdateStudentPersonalDetails(updateHomepage.lblConnectedUser.Text, stdPersonalDetails, _conn)
                Close()

            Case "Student Guardian Details"

                Dim stdGuardianDetails As New List(Of StudentGuadian)
                Dim dt As DataTable = dtGrid()
                Dim row As DataRow = dt.Rows(0)

                Dim id As Integer = row("student_id")
                Dim title As String = row("title")
                Dim name As String = row("name")
                Dim surname As String = row("surname")
                Dim address As String = row("address")
                Dim contacts As String = row("contacts")
                Dim email As String = row("email")


                Dim newEntry As New StudentGuadian(id, name, surname, title, address, contacts, email)
                stdGuardianDetails.Add(newEntry)
                UpdateStatements.UpdateStudentGuardianDetails(updateHomepage.lblConnectedUser.Text, stdGuardianDetails, _conn)
                Close()

            Case "Student Medical Details"

                Dim stdMedicalDetails As New List(Of StudentMedicals)
                Dim dt As DataTable = dtGrid()
                Dim row As DataRow = dt.Rows(0)

                Dim id As Integer = row("student_id")
                Dim allegies As String = row("allegies")
                Dim rq_treatment As String = row("rq_treatment")
                Dim medications As String = row("medications")
                Dim dosage As String = row("dosage")
                Dim schedule As String = row("schedule")
                Dim disabilities As String = row("disabilities")
                Dim physician As String = row("physician")
                Dim contacts As String = row("contacts")


                Dim newEntry As New StudentMedicals(id, allegies, rq_treatment, medications, dosage, schedule, disabilities, physician, contacts)
                stdMedicalDetails.Add(newEntry)
                UpdateStatements.UpdateStudentMedicalDetails(updateHomepage.lblConnectedUser.Text, stdMedicalDetails, _conn)
                Close()

            Case "Student Subject Details"

                Dim stdSubjectDetails As New List(Of StudentSubjects)
                Dim dt As DataTable = dtGrid()
                Dim StudentRow As DataRow = dt.Rows(0)

                Dim OriginalSubject As New List(Of String)
                Dim subjectDt As DataTable = selectStatement.GetIndividualStudentGrades(StudentRow("student_id"), _conn)
                For Each row In subjectDt.Rows
                    OriginalSubject.Add(row("subjects"))
                Next

                Dim updatedList As New List(Of String)

                For Each row In dt.Rows

                    Dim id As Integer = row("student_id")
                    Dim subjects As String = row("subjects")
                    Dim subjectid As Integer = row("subject_id")


                    updatedList.Add(subjects)
                    Dim newEntry As New StudentSubjects(id, subjects, subjectid)
                    stdSubjectDetails.Add(newEntry)

                Next

                Dim subjectListToDelete As New List(Of String)
                For Each subject As String In OriginalSubject
                    If Not updatedList.Contains(subject) Then
                        subjectListToDelete.Add(subject)
                    End If
                Next

                DeleteStatement.DeleteAssociatedSubjectMarks(StudentRow("student_id"), updateHomepage.lblConnectedUser.Text, subjectListToDelete, _conn)
                UpdateStatements.UpdateStudentSubjects(updateHomepage.lblConnectedUser.Text, stdSubjectDetails, _conn)

                Close()


            Case "Fees Structure"

                Dim feesStructure As New List(Of FeesStructure)
                Dim dt As DataTable = dtGrid()

                For Each row In dt.Rows
                    Dim id As Integer = row("id")
                    Dim sclass As String = row("class")
                    Dim amount As Integer = row("amount")

                    Dim newEntry As New FeesStructure(id, sclass, amount)
                    feesStructure.Add(newEntry)
                Next

                UpdateStatements.UpdateFeesStructure(updateHomepage.lblConnectedUser.Text, feesStructure, _conn)

                Close()


            Case "Faculty Personal Details"
                Dim facultyDetails As New List(Of UpdateEncapsulation.FacultyDetails)
                Dim dt As DataTable = dtGrid()
                Dim dtRow As DataRow = dt.Rows(0)

                Dim id As Integer = dtRow("id")
                Dim name As String = dtRow("name")
                Dim surname As String = dtRow("surname")
                Dim sclass As String = dtRow("class")
                Dim dateOfBirth As DateTime = dtRow("dob")
                Dim idNumber As String = dtRow("id_number")
                Dim address As String = dtRow("address")
                Dim phoneNumber As String = dtRow("phone")
                Dim email As String = dtRow("email")
                Dim joinDate As DateTime = dtRow("joined")
                Dim allegies As String = dtRow("allegies")
                Dim rqTreatment As String = dtRow("rq_treatment")
                Dim medications As String = dtRow("medications")
                Dim dosage As String = dtRow("dosage")
                Dim schedule As String = dtRow("schedule")
                Dim disabilities As String = dtRow("disabilities")
                Dim physician As String = dtRow("physician")
                Dim contacts As String = dtRow("contacts")

                Dim newEntry As New UpdateEncapsulation.FacultyDetails(id, name, surname, sclass, dateOfBirth, idNumber, address, phoneNumber, email, joinDate, allegies, rqTreatment, medications, dosage, schedule, disabilities, physician, contacts)
                facultyDetails.Add(newEntry)
                UpdateStatements.UpdateFacultyDetails(updateHomepage.lblConnectedUser.Text, facultyDetails, _conn)
                Close()


            Case "Faculty Subjects"
                Dim facultySubjects As New List(Of FacultySubjects)
                Dim dt As DataTable = dtGrid()

                For Each row In dt.Rows
                    Dim id As Integer = row("faculty_id")
                    Dim subject As String = row("subjects")
                    Dim subjectId As Integer = row("subject_id")

                    Dim newentry As New FacultySubjects(id, subject, subjectId)
                    facultySubjects.Add(newentry)
                    UpdateStatements.UpdateFacultySubjects(updateHomepage.lblConnectedUser.Text, facultySubjects, _conn)
                    Close()
                Next

        End Select

    End Sub
    Private Sub dtePickerFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtePickerFilter.ValueChanged
        If _loadDate Then
            DataGridView.DataSource = selectStatement.GetAllRates(dtePickerFilter.Value, _conn)
        End If
    End Sub
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Function dtGrid()

        Dim dt As New DataTable

        For Each column As DataGridViewColumn In DataGridView.Columns
            Dim columnType As Type = If(column.ValueType, GetType(String))
            dt.Columns.Add(column.Name, columnType)
        Next

        For Each row As DataGridViewRow In DataGridView.Rows
            If Not row.IsNewRow Then
                Dim datarow As DataRow = dt.NewRow
                For Each column As DataGridViewColumn In DataGridView.Columns
                    datarow(column.Name) = row.Cells(column.Name).Value
                Next
                dt.Rows.Add(datarow)
            End If
        Next

        Return dt

    End Function
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
            lblHeading,
            lblTerm
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateAndFinalise
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbTerm
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
        }
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