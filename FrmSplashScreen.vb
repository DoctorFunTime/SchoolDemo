Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports SQLStatements

Public Class FrmSplashScreen
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Private design As New Design
    Private _darkmode As String
    Private _conn As String
    Private _username As String
    Private _frmRefresh As FrmEventsPlanner

    Public Sub New(darkmode As Boolean, frm As Form, username As String, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _conn = conn
        _frmRefresh = frm
        _username = username
        _darkmode = darkmode
        dtePickerDate.Value = Date.Today
        design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim effRate As DataTable = selectStatement.GetDaysRate(Date.Today, _conn)

        For Each row In effRate.Rows
            Dim baseRate As Decimal = row("exchange_rate")
            Dim effectiveRate As Decimal = 1 / baseRate
            txtDocEffectiveRate.Text = $"Effective rate : {FormatNumber(effectiveRate, 2).ToString}"
        Next

        Dim classDt As DataTable = selectStatement.GetClasses(_conn)
        For Each row In classDt.Rows()
            cmbBoxDocCurrency.Items.Add(row("cl_class"))
        Next
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim verified As Boolean = design.txtboxformats(Me)

        If verified Then
            SQLLine.InsertEvent(txtDocDescription.Text, dtePickerDate.Value, txtDocAmount.Text, cmbBoxDocCurrency.Text, _username, _conn)
            Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmSplashScreen_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        _frmRefresh.UICreations()
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

        Dim topPanels As New List(Of Guna2GradientPanel)
        Return topPanels
    End Function

    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblHeadingOne,
            lblDescription,
            lblDate,
            lblCurrency,
            lblAmount,
            lblValidate
        }
        Return labels
    End Function

    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
           btnConfirm
        }
        Return pagebuttons
    End Function

    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtDocEffectiveRate,
            txtDocDescription,
            txtDocAmount
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxDocCurrency
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function

End Class