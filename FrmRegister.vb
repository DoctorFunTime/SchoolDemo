Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports DatabaseSelectStatements
Imports SQLStatements
Imports MyEncapsulation
Imports Newtonsoft.Json.Linq
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports SQLUpdateStatements

Public Class FrmRegister
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Private _messsage As String
    Private _term As String
    Private design As New Design
    Private _darkmode As Boolean
    Private _conn As String
    Private _date As DateTime
    Private _editTerm As String
    Private _clause As String
    Private _frm As Homepage
    Public Sub New(message As String, clause As String, tdate As DateTime, editTerm As String, term As String, darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _clause = clause
        _date = tdate
        _editTerm = editTerm

        If _clause = "Update Register" Then
            lblHeading.Text = $"{message} Class Register Edit- {tdate.ToString("dddd-MMM-yyyy")}."
        Else
            lblHeading.Text = $"{message} Class Register - {Date.Today.ToString("dddd-MMM-yyyy")}."
        End If

        _messsage = message
        _conn = conn
        _term = term
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMgrid()

        Select Case _clause

            Case "Update Register"
                DataGridView.DataSource = selectStatement.GetClassesForRegisterUpdates(_date, _editTerm, _messsage, _conn)

                Dim readOnlyCol As String() = {"date", "id", "term", "class", "name", "surname"}
                For Each col As String In readOnlyCol
                    DataGridView.Columns(col).ReadOnly = True
                Next

            Case Else
                Dim cr_date As New DataGridViewTextBoxColumn() With {
                    .Name = "date",
                    .HeaderText = "Date",
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

                DataGridView.DataSource = selectStatement.GetClassesForRegister(_messsage, _conn)
                Dim readOnlyCol As String() = {"id", "class", "name", "surname"}
                For Each col As String In readOnlyCol
                    DataGridView.Columns(col).ReadOnly = True
                Next

                Dim chkBxColumn As New DataGridViewCheckBoxColumn() With {
                     .HeaderText = "status",
                     .Name = "status"
                }

                DataGridView.Columns.Add(chkBxColumn)

                For Each row In DataGridView.Rows
                    row.cells("date").value = DateTime.Today
                Next

                For Each row In DataGridView.Rows
                    row.cells("status").value = True
                Next

                For Each row In DataGridView.Rows
                    row.cells("term").value = _term
                Next

        End Select

    End Sub

    Private Sub btnValidateAndFinalise_Click(sender As Object, e As EventArgs) Handles btnValidateAndFinalise.Click

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

        If _clause = "Update Register" Then
            Dim selection As New List(Of Register)

            For Each row In dt.Rows

                Dim studentDate As DateTime = row("date")
                Dim studentID As Integer = row("id")
                Dim studentClass As String = row("class")
                Dim studentName As String = row("name")
                Dim studentSurname As String = row("surname")
                Dim studentPresent As Boolean = row("status")
                Dim term As String = row("term")

                Dim newselection As New Register(studentDate, studentID, studentClass, studentName, studentSurname, studentPresent, term)
                selection.Add(newselection)

                UpdateStatements.UpdateClassRegister(_frm.lblConnectedUser.Text, selection, _conn)

            Next


        Else

            Dim selection As New List(Of Register)

            For Each row In dt.Rows
                Dim studentID As Integer = row("id")
                Dim studentClass As String = row("class")
                Dim studentName As String = row("name")
                Dim studentSurname As String = row("surname")
                Dim studentPresent As Boolean = row("status")
                Dim term As String = row("term")

                Dim newselection As New Register(Date.Today, studentID, studentClass, studentName, studentSurname, studentPresent, term)
                selection.Add(newselection)

            Next

            Dim isMarked As DataTable = selectStatement.GetRegisterState(_messsage, Date.Today, _conn)

            If isMarked.Rows.Count > 0 Then
                design.messagboxInfo("Marked", $"The register for the {_messsage} class has already been completed for the day.", Me)
            Else
                SQLLine.InsertRegister(_frm.lblConnectedUser.Text, selection, _conn)
            End If

        End If

        Close()

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

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateAndFinalise
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

    Private Sub FrmRegister_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        _frm.Updates()
    End Sub
End Class