Imports System.Drawing.Text
Imports DatabaseSelectStatements
Imports Guna.UI2.WinForms

Public Class FrmSelectClass
    Private selctStatement As New SelectStats
    Private classList As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        classList = selctStatement.GetClasses()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmSelectClass_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each row In classList.Rows
            Dim sclass As String = row("cl_class").ToString
            classButton(sclass)
        Next

    End Sub

    Private Sub classButton(message As String)

        Dim classButton As New Guna2GradientButton With {
            .Text = message,
            .TextAlign = HorizontalAlignment.Center,
            .Font = New Font("Century Gothic", 14),
            .ForeColor = Color.Black,
            .Size = New Size(180, 150),
            .Cursor = Cursors.Hand,
            .Animated = True,
            .BorderRadius = 5,
            .FillColor = Color.PowderBlue,
            .FillColor2 = Color.LightGray
        }

        AddHandler classButton.Click, AddressOf classButtonClicked
        pnlFlwClasses.Controls.Add(classButton)

    End Sub

    Private Sub classButtonClicked(sender As Object, e As EventArgs)

        Dim register As New FrmRegister($"{sender.text}")
        register.Show()
    End Sub
End Class