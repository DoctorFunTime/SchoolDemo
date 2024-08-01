Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Frond_End_Design
Imports bubble
Imports System.Drawing.Imaging
Imports System.Drawing.Printing


Public Class FrmStudentReport
    Private dt As DataTable
    Private datasetName As String
    Dim design As New Design
    Dim popUp As New NotificationBubble

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

            Dim relativeReportPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "studentDetails.rdlc")
            rv1.LocalReport.ReportPath = relativeReportPath

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
            design.messagboxError("Report error", "An error occurred while loading the report: " & ex.Message, Me)
        End Try

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExport.Click, btnClose.Click, btnRefresh.Click, btnMinimize.Click
        Select Case sender.name

            Case "btnClose"
                Close()

            Case "btnMinimize"
                WindowState = FormWindowState.Minimized

            Case "btnRefresh"
                rv1.RefreshReport()

            Case "btnPrint"
                PrintReport()
            Case "btnExport"

                Dim buttonLocation As Point = btnExport.PointToScreen(New Point(0, btnExport.Height))
                btnExport.ContextMenuStrip.Show(buttonLocation)

        End Select
    End Sub

    Private Sub ExportReport(format As String)
        Dim extension As String
        Dim filter As String
        Dim formatString As String

        Select Case format.ToLower
            Case "pdf"
                extension = "pdf"
                filter = "PDF Files (*.pdf)|*.pdf"
                formatString = "PDF"
            Case "word"
                extension = "docx"
                filter = "Word Documents (*.docx)|*.docx"
                formatString = "WORDOPENXML"
            Case "excel"
                extension = "xlsx"
                filter = "Excel Files (*.xlsx)|*.xlsx"
                formatString = "EXCELOPENXML"
            Case Else
                design.messagboxWarning("Error", "Unsurpported file format.", Me)
                Exit Sub
        End Select

        Dim saveDialog As New SaveFileDialog With {
            .Filter = filter,
            .DefaultExt = extension,
            .Title = $"Save the report as {format.ToUpper}"
            }

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim outputPath As String = saveDialog.FileName

            Try
                Dim warnings As Warning() = Nothing
                Dim streamids As String() = Nothing
                Dim mimeType As String = String.Empty
                Dim encoding As String = String.Empty
                Dim filenameExtension As String = String.Empty

                Dim bytes As Byte() = rv1.LocalReport.Render(formatString, Nothing, mimeType, encoding, filenameExtension, streamids, warnings)

                Using fs As New FileStream(outputPath, FileMode.Create)
                    fs.Write(bytes, 0, bytes.Length)
                End Using

                Dim popUp As New NotificationBubble
                popUp.ShowNotification("Ok", "Successful", $"Report was exported successfully to {outputPath}.")

            Catch ex As Exception
                design.messagboxError("Report error", "An error occurred : " & ex.Message, Me)
            End Try
        End If

    End Sub

    Private Sub PrintReport()
        Dim emfPages As List(Of Metafile) = RenderReportToEMF()

        If emfPages.Count > 0 Then
            Dim printDoc As New PrintDocument()
            Dim currentPage As Integer = 0

            ' Handle print page event
            AddHandler printDoc.PrintPage, Sub(sender As Object, e As PrintPageEventArgs)
                                               e.Graphics.DrawImage(emfPages(currentPage), e.PageBounds)
                                               currentPage += 1
                                               e.HasMorePages = (currentPage < emfPages.Count)
                                           End Sub

            ' Show the print dialog
            Using printDialog As New PrintDialog()
                printDialog.Document = printDoc

                If printDialog.ShowDialog() = DialogResult.OK Then
                    printDoc.PrinterSettings = printDialog.PrinterSettings
                    printDoc.Print()
                End If
            End Using
        Else
            design.messagboxError("Error", "No pages to print.", Me)
        End If
    End Sub
    Private Function RenderReportToEMF() As List(Of Metafile)
        Dim emfPages As New List(Of Metafile)()
        Dim warnings As Warning() = Nothing
        Dim streamIds As String() = Nothing
        Dim mimetype As String = String.Empty
        Dim encoding As String = String.Empty
        Dim extension As String = String.Empty

        ' Render the report to emf format
        Dim deviceInfo As String = "<DeviceInfo><OutputFormat>EMF</OutputFormat></DeviceInfo>"

        For i As Integer = 0 To rv1.LocalReport.GetTotalPages() - 1
            Try
                Dim bytes As Byte() = rv1.LocalReport.Render("IMAGE", deviceInfo, mimetype, encoding, extension, streamIds, warnings)

                Using ms As New MemoryStream(bytes)
                    ' Ensure MemoryStream contains data
                    If ms.Length > 0 Then
                        ms.Position = 0 ' Set the position to the beginning of the stream
                        Dim emf As New Metafile(ms)
                        emfPages.Add(emf)
                    End If
                End Using
            Catch ex As Exception
                ' Log or handle the exception as needed
                design.messagboxError("Error", $"An error occurred: {ex.Message}", Me)
            End Try
        Next

        Return emfPages
    End Function


    Private Sub StrpPDF_Click(sender As Object, e As EventArgs) Handles strpPDF.Click, strpWord.Click, strpExcel.Click
        Select Case sender.name
            Case "strpPDF"
                ExportReport("pdf")
            Case "strpWord"
                ExportReport("word")
            Case "strpExcel"
                ExportReport("excel")
        End Select
    End Sub
End Class