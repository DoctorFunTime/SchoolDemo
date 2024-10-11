Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Functionality
Imports Guna.UI2.WinForms
Imports MyEncapsulation
Imports SQLStatements
Imports SQLUpdateStatements
Imports UpdateEncapsulation

Public Class FrmUploadExam
    Private dragger As New SystemFunctions
    Private design As New Design
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Public stdClass As String
    Private _message As String
    Private _term As String
    Private _fillClause As String
    Private _exam As String
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(message As String, term As String, exam As String, fillClause As String, darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHeading.Text = $"{message} Exam/Test Register - {Date.Today.ToString("dddd-MMM-yyyy")}."
        dtePickerDate.Value = Date.Today
        _frm = frm
        _conn = conn
        _message = message
        _term = term
        _exam = exam
        _fillClause = fillClause
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnValidateAndFinalise.Click, btnToggleFilter.Click, btnValidate.Click
        Select Case sender.name

            Case "btnClose"
                Close()

            Case "btnValidateAndFinalise"
                Dim verified As Boolean = design.txtboxformats(pnlContainerControls)

                If btnValidateAndFinalise.Text = "Validate and Finalise" Then

                    If verified Then
                        Dim dt As DataTable = dtGrid()

                        Dim selection As New List(Of ExamTestMarks)

                        For Each row In dt.Rows
                            Dim stdId As Integer = row("student_id")
                            Dim sclass As String = row("class")
                            Dim examMark As Decimal = row("e_result")
                            Dim contributes As Boolean
                            If chkBoxContributes.Checked Then
                                contributes = True
                            Else
                                contributes = False
                            End If

                            Dim newEntry As New ExamTestMarks(dtePickerDate.Value, stdId, sclass, _term, cmbBoxSubject.Text, examMark, txtDescription.Text, cmbBoxExamTest.Text, contributes)
                            selection.Add(newEntry)

                        Next

                        SQLLine.InsertExamTestMarks(_frm.lblConnectedUser.Text, selection, _conn)
                        Close()
                    Else
                        vis()
                        pnlControls.Width = 799

                    End If

                ElseIf btnValidateAndFinalise.Text = "Update Changes" Then

                    If verified Then
                        Dim dt As DataTable = dtGrid()

                        Dim updates As New List(Of UpdateExamTestMarks)

                        For Each row In dt.Rows
                            Dim eID As Integer = row("exam_id")
                            Dim stdID As Integer = row("student_id")
                            Dim sclass As String = row("class")
                            Dim term As String = row("term")
                            Dim edate As DateTime = dtePickerDate.Value
                            Dim subject As String = cmbBoxSubject.Text
                            Dim exam As String = txtDescription.Text
                            Dim result As Decimal = row("mark")
                            Dim type As String = cmbBoxExamTest.Text
                            Dim contributes As Boolean
                            If chkBoxContributes.Checked Then
                                contributes = True
                            ElseIf Not chkBoxContributes.Checked Then
                                contributes = False
                            End If

                            Dim newEntry As New UpdateExamTestMarks(edate, stdID, sclass, term, subject, result, exam, type, contributes, eID)
                            updates.Add(newEntry)

                            UpdateStatements.UpdateStudentMarks(_frm.lblConnectedUser.Text, updates, _conn)
                            Close()
                        Next
                    Else
                        vis()
                        pnlControls.Width = 799
                    End If

                ElseIf btnValidateAndFinalise.Text = "Add Student Mark" Then

                    If verified Then
                        Dim dt As DataTable = dtGrid()

                        Dim selection As New List(Of ExamTestMarks)

                        For Each row In dt.Rows
                            Dim stdId As Integer
                            If Integer.TryParse(txtStudentID.Text.Trim(), stdId) Then
                            End If

                            Dim sclass As String = stdClass
                            Dim examMark As Decimal = row("e_result")
                            Dim contributes As Boolean
                            If chkBoxContributes.Checked Then
                                contributes = True
                            Else
                                contributes = False
                            End If

                            Dim newEntry As New ExamTestMarks(dtePickerDate.Value, stdId, sclass, _term, cmbBoxSubject.Text, examMark, txtDescription.Text, cmbBoxExamTest.Text, contributes)
                            selection.Add(newEntry)

                        Next
                        SQLLine.InsertExamTestMarks(_frm.lblConnectedUser.Text, selection, _conn)
                        Close()
                    Else
                        vis()
                        pnlControls.Width = 799
                    End If

                End If


            Case "btnValidate"

                If btnValidateAndFinalise.Text = "Validate and Finalise" Then
                    Dim verified As Boolean = design.txtboxformats(pnlContainerControls)

                    If verified Then
                        pnlControls.Width = 36

                        Dim filteredExamDetails As DataTable = selectStatement.GetFilteredExamPrepDetails(cmbBoxSubject.Text, _message, _conn)
                        DataGridView.Columns.Clear()
                        DataGridView.DataSource = filteredExamDetails
                        AddColumn()
                    End If
                ElseIf btnValidateAndFinalise.Text = "Add Student Mark" Then

                    Dim verified As Boolean = design.txtboxformats(pnlContainerControls)
                    If verified Then
                        pnlControls.Width = 36
                        studentCols()
                        AddColumn()
                    End If

                Else
                    btnToggleFilter.PerformClick()
                End If

            Case "btnToggleFilter"
                vis()

                If pnlControls.Width = 36 Then
                    pnlControls.Width = 799
                Else
                    pnlControls.Width = 36
                End If
        End Select

    End Sub

    Private Sub FrmUploadExam_Load(sender As Object, e As EventArgs) Handles Me.Load

        dragger.EnableDrag(Me, pnlTopBar)
        DKMgrid()

        Dim subjectList As DataTable = selectStatement.GetSubjects(_conn)

        For Each row As DataRow In subjectList.Rows
            Dim subject As String = row("s_subject").ToString
            cmbBoxSubject.Items.Add(subject)
        Next

        If _fillClause = "Manage Exams" Then

            txtName.Text = "n/a"
            txtStudentID.Text = "n/a"
            btnAddStudent.Text = "n/a"

            Dim adjustableStudentExam As DataTable = selectStatement.GetStudentGrades(_message, _term, _exam, _conn)
            DataGridView.DataSource = adjustableStudentExam

            Dim readOnlyColumns As String() = {"student_id", "exam_id", "name", "surname", "date", "contributes", "type", "class", "term"}
            For Each colName As String In readOnlyColumns
                DataGridView.Columns(colName).ReadOnly = True
            Next

            Dim ExamRow As DataRow = adjustableStudentExam.Rows(0)
            Dim contributes As Boolean = ExamRow("contributes")
            Dim type As String = ExamRow("type")
            Dim Edate As DateTime = ExamRow("date")

            dtePickerDate.Value = Edate
            cmbBoxSubject.Text = _message
            cmbBoxExamTest.Text = type
            chkBoxContributes.Checked = contributes
            txtDescription.Text = _exam
            btnValidateAndFinalise.Text = "Update Changes"

        ElseIf _fillClause = "Add Student Marks" Then

            btnValidateAndFinalise.Text = "Add Student Mark"

            Dim adjustableStudentExam As DataTable = selectStatement.GetStudentGrades(_message, _term, _exam, _conn)
            Dim ExamRow As DataRow = adjustableStudentExam.Rows(0)
            Dim contributes As Boolean = ExamRow("contributes")
            Dim type As String = ExamRow("type")
            Dim Edate As DateTime = ExamRow("date")

            dtePickerDate.Value = Edate
            cmbBoxSubject.Text = _message
            cmbBoxExamTest.Text = type
            chkBoxContributes.Checked = contributes
            txtDescription.Text = _exam

            txtName.Visible = True
            txtStudentID.Visible = True
            btnAddStudent.Visible = True


        Else

            txtName.Text = "n/a"
            txtStudentID.Text = "n/a"
            btnAddStudent.Text = "n/a"

            Dim studentExamDetails As DataTable = selectStatement.GetExamPrepDetails(_message, _conn)
            DataGridView.DataSource = studentExamDetails

            Dim readOnlyColumns As String() = {"student_id", "name", "surname", "class"}
            For Each colName As String In readOnlyColumns
                DataGridView.Columns(colName).ReadOnly = True
            Next

            AddColumn()
        End If

    End Sub

    Private Sub AddColumn()
        Dim result As New DataGridViewTextBoxColumn() With {
            .Name = "e_result",
            .HeaderText = "Mark(%)",
            .DataPropertyName = "Decimal",
            .ValueType = GetType(Decimal)
        }

        DataGridView.Columns.Add(result)
    End Sub
    Private Sub studentCols()

        Dim stdId As Integer
        If Integer.TryParse(txtStudentID.Text.Trim(), stdId) Then
        End If
        Dim studentSubject As DataTable = selectStatement.GetStudentEnrolledSubject(stdId, cmbBoxSubject.Text, _conn)

        If studentSubject.Rows.Count < 1 Then
            design.messagboxError("Ooops!", $"{txtName.Text} is not enrolled under the {cmbBoxSubject.Text} subject.", Me)
            Exit Sub
        Else
            DataGridView.Columns.Clear()
            Dim cr_date As New DataGridViewTextBoxColumn() With {
                        .Name = "date",
                        .HeaderText = "date",
                        .DataPropertyName = "Date",
                        .ValueType = GetType(DateTime),
                        .[ReadOnly] = True
                    }

            Dim cr_term As New DataGridViewTextBoxColumn() With {
                        .Name = "term",
                        .HeaderText = "Term",
                        .DataPropertyName = "String",
                        .ValueType = GetType(String),
                        .[ReadOnly] = True
                    }

            DataGridView.Columns.Add(cr_date)
            DataGridView.Columns.Add(cr_term)

            Dim chkBxColumn As New DataGridViewCheckBoxColumn() With {
                         .HeaderText = "contributes",
                         .Name = "contributes",
                         .[ReadOnly] = True
                    }

            DataGridView.Columns.Add(chkBxColumn)
            DataGridView.Rows.Add()

            For Each row In DataGridView.Rows
                row.cells("date").value = dtePickerDate.Value
            Next

            For Each row In DataGridView.Rows

                If chkBoxContributes.Checked Then
                    row.cells("contributes").value = True
                ElseIf Not chkBoxContributes.Checked Then
                    row.cells("contributes").value = False
                End If

            Next

            For Each row In DataGridView.Rows
                row.cells("term").value = _term
            Next
        End If

    End Sub
    Private Sub vis()
        lblDate.Visible = True
        lblDescription.Visible = True
        lblSubject.Visible = True
        lblExamTest.Visible = True
    End Sub
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim frm As New FrmSelectStudent(_fillClause, _darkmode, Me, _conn)
        frm.Show()
    End Sub
    Private Function dtGrid()

        Dim dt As New DataTable
        Try
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
        Catch ex As Exception
            If ex.Message.Contains("'e_result' to be null") Then
                design.messagboxError("Operation failed", "No student result mark could be identified.", Me)
            Else
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Try

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
            lblSubject,
            lblExamTest,
            lblDescription,
            lblDate,
            lblHeading
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateAndFinalise,
            btnValidate,
            btnToggleFilter,
            btnAddStudent
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtDescription,
            txtStudentID,
            txtName
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxSubject,
            cmbBoxExamTest
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
            chkBoxContributes
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