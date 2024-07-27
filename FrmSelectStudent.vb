Imports DatabaseSelectStatements
Imports Guna.UI2.WinForms

Public Class FrmSelectStudent

    Dim selectStatement As New SelectStats()
    Public stID As Integer
    Public stName As String
    Public stAmount As Integer
    Public _message As String

    Public Sub New(message As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _message = message
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnFilter.Click
        Select Case sender.name
            Case "btnClose"
                Close()


            Case "btnFilter"
                Dim datatable As DataTable = selectStatement.GetNamesFromTable()
                Dim filterText As String = "name = '" & txtStudentName.Text & "'"
                Dim dataView As New DataView(datatable) With {
                    .RowFilter = filterText
                }
                DataGridView.DataSource = dataView

        End Select
    End Sub

    Private Sub FrmSelectStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim datatable As DataTable = selectStatement.GetNamesFromTable()
        DataGridView.DataSource = datatable
    End Sub

    Private Sub DataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView.DoubleClick

        Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

        stID = selectedRow.Cells("id").Value
        stName = selectedRow.Cells("name").Value
        stAmount = selectedRow.Cells("amount").Value

        Select Case _message
            Case "FrmTuition"
                FrmTuition.txtStudentID.Text = stID
                FrmTuition.txtStudentName.Text = stName
        End Select

        Close()

    End Sub

End Class