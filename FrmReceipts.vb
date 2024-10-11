﻿Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports MyEncapsulation
Imports SQLStatements

Public Class FrmReceipts
    Private selectStatement As New SelectStats
    Private sqlline As New SQLLine
    Private design As New Design
    Private _docNumber As Integer
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtePickerDate.Value = Date.Today
        _frm = frm
        _conn = conn
        _docNumber = selectStatement.GetDocNumber("Receipt", _conn).Compute("MAX(dc_number)", String.Empty) + 1
        _darkmode = darkmode
        design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnConfirm.Click

        Select Case sender.name
            Case "btnClose"
                Close()
            Case "btnConfirm"

                Dim selection As New List(Of ReceiptsPayment)
                Dim verifiedEntries As Boolean = design.txtboxformats(Me)

                If verifiedEntries Then
                    Dim value As Integer
                    If Integer.TryParse(txtDocAmount.Text.Trim(), value) Then
                        Dim newselection As New ReceiptsPayment(dtePickerDate.Value, txtDocDescription.Text, value, 0, cmbBoxDocCurrency.Text, "DR", cmbBoxDocPaymentType.Text, txtDocDocNumber.Text)
                        selection.Add(newselection)
                        SQLLine.InsertReceiptPayment(_frm.lblConnectedUser.Text, selection, _conn)
                        SQLLine.InsertDocNumber(_docNumber, "Receipt", _conn)
                        Close()
                    End If
                End If

        End Select

    End Sub

    Private Sub FrmReceipts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim effRate As DataTable = selectStatement.GetDaysRate(Date.Today, _conn)

        For Each row In effRate.Rows
            Dim baseRate As Decimal = row("exchange_rate")
            Dim effectiveRate As Decimal = 1 / baseRate
            txtDocEffectiveRate.Text = $"Effective rate : {FormatNumber(effectiveRate, 2).ToString}"
        Next

        txtDocDocNumber.Text = $"REC00{_docNumber}"

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
            lblPaymentType,
            lblPayee,
            lblHeadingOne,
            lblDocumentNumber,
            lblDescription,
            lblDate,
            lblCurrency,
            lblAmount
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
            txtDocName,
            txtDocEffectiveRate,
            txtDocDocNumber,
            txtDocDescription,
            txtDocAmount
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxDocCurrency,
            cmbBoxDocPaymentType
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function

End Class