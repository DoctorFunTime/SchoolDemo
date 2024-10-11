Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmReports
    Dim selectStatement As New SelectStats()
    Private design As New Design
    Private _darkmode As Boolean
    Private _conn As String
    Private _term As String

    Public Sub New(darkmode As Boolean, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub BtnCashBook_MouseHover(sender As Object, e As EventArgs) Handles btnStudentReports.MouseHover, btnKPI.MouseHover, btnHighAchievers.MouseHover, btnFaculty.MouseHover, btnAttendacy.MouseHover
        lblAddtionalInfoReports.Text = sender.Tag
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btnStudentReports.Click, btnKPI.Click, btnHighAchievers.Click, btnFaculty.Click, btnAttendacy.Click
        Select Case sender.name

            Case "btnKPI"
                If pnlKPIsDrop.Height = 297 Then pnlKPIsDrop.Height = 59 Else pnlKPIsDrop.Height = 297

            Case "btnStudentReports"
                If pnlStudentReportsDrop.Height = 178 Then pnlStudentReportsDrop.Height = 59 Else pnlStudentReportsDrop.Height = 178

            Case "btnAttendacy"

                Dim formID As String = "Attendacy record"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn)
                selectStudent.Show()

            Case "btnHighAchievers"
                Dim datatable As DataTable = selectStatement.GetTopThreeStudents(_term, _conn)

                Dim reportForm As New FrmStudentReport(datatable, "TopThreeStudents", "TopThreeStudents", _darkmode)
                reportForm.Show()

            Case "btnFaculty"
                Dim formID As String = "Faculty Details"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn)
                selectStudent.Show()

        End Select
    End Sub

    Private Sub pnlDrops_Click(sender As Object, e As EventArgs) Handles btnStudentGradeReport.Click, btnStudentDetailsReport.Click, btnKPIPassRates.Click, btnKPIExamGrowth.Click, btnKPIClassPassRate.Click, btnStudentPasses.Click

        Select Case sender.name
            Case "btnStudentGradeReport"
                Dim formID As String = "Student Grades"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn)
                selectStudent.Show()

            Case "btnStudentDetailsReport"
                Dim formID As String = "Student Details"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn)
                selectStudent.Show()

            Case "btnKPIExamGrowth"

                Dim formID As String = "Exam Growth"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn)
                selectStudent.Show()

            Case "btnKPIPassRates"
                Dim datatable As DataTable = selectStatement.GetSubjectPassRates(_term, _conn)

                Dim reportForm As New FrmStudentReport(datatable, "PassRates", "PassRates", _darkmode)
                reportForm.Show()

            Case "btnKPIClassPassRate"
                Dim datatable As DataTable = selectStatement.GetClassPassRates(_term, _conn)

                Dim reportForm As New FrmStudentReport(datatable, "DetailedPassRates", "DetailedPassRates", _darkmode)
                reportForm.Show()

            Case "btnStudentPasses"
                Dim datatable As DataTable = selectStatement.GetGradesCount(_term, _conn)

                Dim reportForm As New FrmStudentReport(datatable, "GradesCount", "GradesCount", _darkmode)
                reportForm.Show()

        End Select
    End Sub

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _darkmode Then
            pnlFlowMain.BackColor = Color.FromArgb(40, 30, 50)
        Else
            pnlFlowMain.BackColor = Color.White
        End If

        Dim dt As DataTable = selectStatement.GetTerm(_conn)
        For Each row In dt.Rows
            _term = row("at_term")
        Next
    End Sub

    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton)
        Return sidebarButtons
    End Function

    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
        }

        Return pagebuttons
    End Function

    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
        }
        Return topPanels
    End Function

    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoReports
        }
        Return labels
    End Function

    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnStudentReports,
           btnHighAchievers,
           btnKPI,
           btnAttendacy,
           btnFaculty
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
End Class