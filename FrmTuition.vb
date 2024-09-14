Imports DatabaseSelectStatements
Imports SQLStatements
Imports Frond_End_Design
Imports MyEncapsulation
Imports bubble
Imports Guna.UI2.WinForms

Public Class FrmTuition
    Private selectStatement As New SelectStats
    Private design As New Design
    Private Popup As New NotificationBubble
    Private sqlline As New SQLLine
    Private _docNumber As Integer
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(_stdName As String, _stdID As Integer, darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtePickerDate.Value = Date.Today
        txtDocName.Text = _stdName
        txtDocStudentID.Text = _stdID
        _frm = frm
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub studentSelection_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnConfirm.Click

        Select Case sender.name

            Case "btnClose"
                Close()

            Case "btnConfirm"
                Dim verified As Boolean = design.txtboxformats(Me)

                Dim selection As New List(Of DataSelection)
                Dim receiptPayment As New List(Of ReceiptsPayment)

                If verified Then
                    Dim value As Integer

                    If Integer.TryParse(txtDocAmount.Text.Trim(), value) Then

                        Dim newEntry As New DataSelection(dtePickerDate.Value, txtDocDescription.Text, 0, value, cmbBoxDocCurrency.Text, "CR", cmbBoxDocPaymentType.Text, txtDocStudentID.Text, txtDocDocNumber.Text)
                        selection.Add(newEntry)
                        SQLLine.InsertStudentPayments(_frm.lblConnectedUser.Text, selection, _conn)

                        If cmbBxDocReciptPayment.Text = "Receipt" Then

                            Dim AnotherEntry As New ReceiptsPayment(dtePickerDate.Value, txtDocDescription.Text, value, 0, cmbBoxDocCurrency.Text, "DR", cmbBoxDocPaymentType.Text, txtDocDocNumber.Text)
                            _docNumber = selectStatement.GetDocNumber("Receipt", _conn).Compute("MAX(dc_number)", String.Empty) + 1

                            receiptPayment.Add(AnotherEntry)
                            SQLLine.InsertReceiptPayment(_frm.lblConnectedUser.Text, receiptPayment, _conn)
                            SQLLine.InsertDocNumber(_docNumber, "Receipt", _conn)
                            Popup.ShowNotification("Ok", "Successful", "Student payment was processed successfully.", Me)

                        Else

                            Dim AnotherEntry As New ReceiptsPayment(dtePickerDate.Value, txtDocDescription.Text, 0, value, cmbBoxDocCurrency.Text, "CR", cmbBoxDocPaymentType.Text, txtDocDocNumber.Text)
                            _docNumber = selectStatement.GetDocNumber("Expense", _conn).Compute("MAX(dc_number)", String.Empty) + 1

                            receiptPayment.Add(AnotherEntry)
                            SQLLine.InsertReceiptPayment(_frm.lblConnectedUser.Text, receiptPayment, _conn)
                            SQLLine.InsertDocNumber(_docNumber, "Expense", _conn)
                            Popup.ShowNotification("Ok", "Successful", "Student payment was processed successfully.", Me)

                        End If

                        Close()

                    End If
                End If
        End Select


    End Sub

    Private Sub FrmTuition_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim effRate As DataTable = selectStatement.GetDaysRate(Date.Today, _conn)

        For Each row In effRate.Rows
            Dim baseRate As Decimal = row("exchange_rate")
            Dim effectiveRate As Decimal = 1 / baseRate
            txtDocEffectiveRate.Text = $"Effective rate : {FormatNumber(effectiveRate, 2).ToString}"
        Next
    End Sub

    Private Sub cmbBxReciptPayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBxDocReciptPayment.SelectedValueChanged
        If String.IsNullOrEmpty(txtDocDocNumber.Text) Then

            If sender.text = "Receipt" Then
                Dim recNo As Integer = selectStatement.GetDocNumber("Receipt", _conn).Compute("MAX(dc_number)", String.Empty) + 1
                txtDocDocNumber.Text = $"REC00{recNo}"
            Else
                Dim expNo As Integer = selectStatement.GetDocNumber("Expense", _conn).Compute("MAX(dc_number)", String.Empty) + 1
                txtDocDocNumber.Text = $"EXP00{expNo}"
            End If
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

        Dim topPanels As New List(Of Guna2GradientPanel)
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblPaymentType,
            lblHeadingOne,
            lblDocumentNumber,
            lblDescription,
            lblDate,
            lblCurrency,
            lblAmount,
            lblReceiptPayment
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
            txtDocStudentID,
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
            cmbBoxDocPaymentType,
            cmbBxDocReciptPayment
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function

End Class