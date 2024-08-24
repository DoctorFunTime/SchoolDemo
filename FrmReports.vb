Imports System.Web.UI.Design.WebControls
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmReports
    Dim selectStatement As New SelectStats()
    Private design As New Design
    Private _darkmode As Boolean
    Public Sub New(darkmode)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub BtnCashBook_MouseHover(sender As Object, e As EventArgs) Handles btnStudentReports.MouseHover, btnHighAchievers.MouseHover, btnKPI.MouseHover, btnAttendacy.MouseHover, btnAreasOfConcern.MouseHover
        lblAddtionalInfoReports.Text = sender.Tag
    End Sub

    Private Sub BtnAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentReports.Click, btnHighAchievers.Click, btnKPI.Click, btnAttendacy.Click, btnAreasOfConcern.Click
        Select Case sender.name

            Case "btnKPI"
                If pnlKPIsDrop.Height = 178 Then pnlKPIsDrop.Height = 59 Else pnlKPIsDrop.Height = 178

            Case "btnStudentReports"
                If pnlStudentReportsDrop.Height = 178 Then pnlStudentReportsDrop.Height = 59 Else pnlStudentReportsDrop.Height = 178

            Case "btnAttendacy"

                Dim formID As String = "Attendacy record"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me)
                selectStudent.ShowDialog()

        End Select
    End Sub

    Private Sub pnlDrops_Click(sender As Object, e As EventArgs) Handles btnStudentGradeReport.Click, btnStudentDetailsReport.Click

        Select Case sender.name
            Case "btnStudentGradeReport"
                Dim formID As String = "Student Grades"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me)
                selectStudent.ShowDialog()

            Case "btnStudentDetailsReport"
                Dim formID As String = "Student Details"
                Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me)
                selectStudent.ShowDialog()

        End Select
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
            flowpnl
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
           btnAreasOfConcern
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