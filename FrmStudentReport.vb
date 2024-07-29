Imports System.IO
Imports Microsoft.Reporting.WinForms


Public Class FrmStudentReport
    Private dt As DataTable
    Private datasetName As String

    Public Sub New(dataTable As DataTable, dataset As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dt = dataTable
        datasetName = dataset

    End Sub

    Private Sub FrmStudentReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ' Set the processing mode to local
            rv1.ProcessingMode = ProcessingMode.Local

            ' Ensure the path is correct and the file exists
            rv1.LocalReport.ReportPath = "C:\Users\ASUS\source\repos\SchoolDemo\Reports\StudentReport.rdlc"

            ' Check if the report file exists
            If Not IO.File.Exists(rv1.LocalReport.ReportPath) Then
                MessageBox.Show("Report file not found!")
                Return
            End If

            ' Set the datasource for the report
            Dim rds As New ReportDataSource(datasetName, dt)
            rv1.LocalReport.DataSources.Clear()
            rv1.LocalReport.DataSources.Add(rds)

            ' Refresh the report to display data
            rv1.RefreshReport()

        Catch ex As Exception
            ' Handle any exceptions that occur during report loading
            MessageBox.Show("An error occurred while loading the report: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExport.Click, btnClose.Click
        Select Case sender.name

            Case "btnClose"
                Close()
            Case "btnPrint"
            Case "btnExport"

                Dim warnings As Warning() = Nothing
                Dim streamids As String() = Nothing
                Dim mimeType As String = String.Empty
                Dim encoding As String = String.Empty
                Dim filenameExtension As String = "pdf"

                Try
                    Dim deviceInfo As String = "<DeviceInfo><OutputFormat>PDF</OutputFormat></DeviceInfo>"
                    Dim bytes As Byte() = rv1.LocalReport.Render("PDF", deviceInfo, mimeType, encoding, filenameExtension, streamids, warnings)

                    Using fs As New FileStream("C:\Users\ASUS\Desktop\report.pdf", FileMode.Create)
                        fs.Write(bytes, 0, bytes.Length)
                    End Using

                Catch ex As Exception
                    ' Log the exception message and stack trace
                    MessageBox.Show("An error occurred: " & ex.Message & Environment.NewLine & ex.StackTrace)
                End Try


        End Select
    End Sub


End Class