Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports DatabaseSelectStatements
Imports SQLStatements
Imports MyEncapsulation
Imports Newtonsoft.Json.Linq
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmRegister
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Private _messsage As String
    Private _term As String
    Private design As New Design
    Private _darkmode As Boolean
    Public Sub New(message As String, term As String, darkmode As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHeading.Text = $"{message} Class Register - {Date.Today.ToString("dddd-MMM-yyyy")}."
        _messsage = message
        _term = term
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load

        DKMgrid()

        Dim cr_date As New DataGridViewTextBoxColumn() With {
            .Name = "cr_date",
            .HeaderText = "Date",
            .DataPropertyName = "Date",
            .ValueType = GetType(DateTime)
        }

        Dim cr_term As New DataGridViewTextBoxColumn() With {
            .Name = "cr_term",
            .HeaderText = "Term",
            .DataPropertyName = "String",
            .ValueType = GetType(String)
        }

        DataGridView.Columns.Add(cr_date)
        DataGridView.Columns.Add(cr_term)

        DataGridView.DataSource = selectStatement.GetClassesForRegister(_messsage)

        Dim chkBxColumn As New DataGridViewCheckBoxColumn() With {
         .HeaderText = "student_present",
         .Name = "student_present"
        }

        DataGridView.Columns.Add(chkBxColumn)

        For Each row In DataGridView.Rows
            row.cells("cr_date").value = DateTime.Today
        Next

        For Each row In DataGridView.Rows
            row.cells("student_present").value = True
        Next

        For Each row In DataGridView.Rows
            row.cells("cr_term").value = _term
        Next

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

        Dim selection As New List(Of Register)

        For Each row In dt.Rows
            Dim studentID As Integer = row("student_id")
            Dim studentClass As String = row("student_class")
            Dim studentName As String = row("student_name")
            Dim studentSurname As String = row("student_surname")
            Dim studentPresent As Boolean = row("student_present")
            Dim term As String = row("cr_term")

            Dim newselection As New Register(Date.Today, studentID, studentClass, studentName, studentSurname, studentPresent, term)
            selection.Add(newselection)

        Next

        Dim isMarked As DataTable = selectStatement.GetRegisterState(_messsage, Date.Today)

        If isMarked.Rows.Count > 0 Then
            design.messagboxInfo("Marked", $"The register for the {_messsage} class has already been completed for the day.", Me)
        Else
            SQLLine.InsertRegister(selection)
        End If

        Close()

    End Sub

    Private Sub DataGridView_Click(sender As Object, e As EventArgs) Handles DataGridView.Click
        For Each row In DataGridView.Rows
            row.cells("cr_date").value = DateTime.Today
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
End Class