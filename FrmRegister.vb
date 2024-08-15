Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports DatabaseSelectStatements
Imports SQLStatements
Imports MyEncapsulation
Imports Newtonsoft.Json.Linq

Public Class FrmRegister
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Private _messsage As String
    Public Sub New(message)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblHeading.Text = $"{message} Class Register - {Date.Today.ToString("dddd-MMM-yyyy")}."
        _messsage = message

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim cr_date As New DataGridViewTextBoxColumn() With {
            .Name = "cr_date",
            .HeaderText = "cr_date",
            .DataPropertyName = "Date",
            .ValueType = GetType(DateTime)
        }

        DataGridView.Columns.Add(cr_date)

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

            Dim newselection As New Register(Date.Today, studentID, studentClass, studentName, studentSurname, studentPresent)
            selection.Add(newselection)

        Next

        SQLLine.InsertRegister(selection)

    End Sub

    Private Sub DataGridView_Click(sender As Object, e As EventArgs) Handles DataGridView.Click
        For Each row In DataGridView.Rows
            row.cells("cr_date").value = DateTime.Today
        Next
    End Sub
End Class