﻿

Imports System.ComponentModel
Imports Frond_End_Design
Imports Guna.UI2.WinForms

Public Class FrmAdmission
    Private WithEvents bwk As New BackgroundWorker()
    Private design As New Design
    Private _darkMode As Boolean
    Private _conn As String
    Private _frm As Homepage
    Public Sub New(darkmode As String, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _conn = conn
        _darkMode = darkmode
        If _darkMode Then design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnFacultyMembers.MouseHover, btnEvents.MouseHover, btnEnrollment.MouseHover, btnAttendance.MouseHover
        lblAddtionalInfoAdmissions.Text = sender.Tag
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnFacultyMembers.Click, btnEvents.Click, btnEnrollment.Click, btnAttendance.Click

        Select Case sender.name

            Case "btnAttendance"
                Dim frm As New FrmSelectClass("Class Register", _darkMode, _frm, _conn)
                frm.ShowDialog()

            Case "btnEnrollment"
                Dim frm As New FrmEnrollment(_darkMode, _frm, _conn)
                frm.Show()

            Case "btnFacultyMembers"
                Dim frm As New FrmFaculty(_darkMode, _frm, _conn)
                frm.Show()

            Case "btnEvents"
                Dim frm As New FrmEventsPlanner(_darkMode, _frm, _conn)
                frm.Show()
        End Select

    End Sub

    Private Sub FrmAdmission_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _darkMode Then
            pnlFlowMain.BackColor = Color.FromArgb(40, 30, 50)
        Else
            pnlFlowMain.BackColor = Color.White
        End If
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
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblAddtionalInfoAdmissions
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnFacultyMembers,
           btnEnrollment,
           btnAttendance,
           btnEvents
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