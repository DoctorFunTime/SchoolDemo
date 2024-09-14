Imports Frond_End_Design
Imports DatabaseSelectStatements
Imports MyEncapsulation
Imports SQLStatements
Imports bubble
Imports Guna.UI2.WinForms

Public Class FrmUploadExam
    Private design As New Design
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Dim Popup As New NotificationBubble
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

                        Dim newEntry As New ExamTestMarks(dtePickerDate.Value, stdId, sclass, _term, cmbBoxSubject.Text, examMark, txtDescription.Text, txtTopics.Text, cmbBoxExamTest.Text, contributes)
                        selection.Add(newEntry)

                    Next

                    SQLLine.InsertExamTestMarks(_frm.lblConnectedUser.Text, selection, _conn)
                    Popup.ShowNotification("Ok", "Successful", $"{_message} {cmbBoxExamTest.Text} marks were successfully processed.", Me)
                    Close()
                Else
                    vis()
                    pnlControls.Width = 799
                End If

            Case "btnValidate"
                Dim verified As Boolean = design.txtboxformats(pnlContainerControls)

                If verified Then
                    pnlControls.Width = 35

                    Dim filteredExamDetails As DataTable = selectStatement.GetFilteredExamPrepDetails(cmbBoxSubject.Text, _message, _conn)
                    DataGridView.Columns.Clear()
                    DataGridView.DataSource = filteredExamDetails
                    AddColumn()
                End If

            Case "btnToggleFilter"
                vis()

                If pnlControls.Width = 35 Then
                    pnlControls.Width = 799
                Else
                    pnlControls.Width = 35
                End If
        End Select

    End Sub

    Private Sub FrmUploadExam_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMgrid()

        Dim subjectList As DataTable = selectStatement.GetSubjects(_conn)

        For Each row As DataRow In subjectList.Rows
            Dim subject As String = row("s_subject").ToString
            cmbBoxSubject.Items.Add(subject)
        Next

        If _fillClause = "Manage Exams" Then
            Dim adjustableStudentExam As DataTable = selectStatement.GetStudentGrades(_message, _term, _exam, _conn)
            DataGridView.DataSource = adjustableStudentExam
            cmbBoxSubject.Text = _message
            txtDescription.Text = _exam
            btnValidateAndFinalise.Text = "Update Changes"
        Else
            Dim studentExamDetails As DataTable = selectStatement.GetExamPrepDetails(_message, _conn)
            DataGridView.DataSource = studentExamDetails
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

    Private Sub vis()
        lblDate.Visible = True
        lblDescription.Visible = True
        lblSubject.Visible = True
        lblTopic.Visible = True
        lblExamTest.Visible = True
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
            lblTopic,
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
            btnToggleFilter
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtTopics,
            txtDescription
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