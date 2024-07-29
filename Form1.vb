Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private dt As DataTable

    Public Sub New(dataTable As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dt = dataTable
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set the processing mode to local
            ReportViewer1.ProcessingMode = ProcessingMode.Local

            ' Set the datasource for the report
            Dim rds As New ReportDataSource("DTSStudents", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' Refresh the report to display data
            ReportViewer1.RefreshReport()

            InspectReport(ReportViewer1)


        Catch ex As Exception
            ' Handle any exceptions that occur during report loading
            MessageBox.Show("An error occurred while loading the report: " & ex.Message)
        End Try
    End Sub
    Public Sub InspectReport(reportViewer As ReportViewer)

        Dim localReport As Microsoft.Reporting.WinForms.LocalReport = reportViewer.LocalReport

        For Each dataSource As ReportDataSource In localReport.DataSources
            MessageBox.Show("Datasource Name: " & dataSource.Name)
            Dim datatable As DataTable = CType(dataSource.Value, DataTable)
            MessageBox.Show("Number of rows in table : " & datatable.Rows.Count)
        Next

        MessageBox.Show("Report Path : " & localReport.ReportPath)

    End Sub
End Class