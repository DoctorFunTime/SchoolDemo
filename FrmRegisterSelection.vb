Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports DatabaseSelectStatements
Imports Org.BouncyCastle.Crypto
Imports MyEncapsulation
Imports SQLStatements
Imports SQLDeleteStatements
Public Class FrmRegisterSelection
    Dim selectStatement As New SelectStats
    Private cFees As New List(Of Integer)
    Private sCosts As New Collection
    Private design As New Design
    Private _darkmode As Boolean
    Private _docNumber As Integer
    Private _term As String
    Private _conn As String
    Private _message As String
    Private _frm As Homepage
    Public Sub New(darkmode As Boolean, message As String, term As String, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frm = frm
        _conn = conn
        _term = term
        _darkmode = darkmode
        _message = message
        _docNumber = selectStatement.GetDocNumber("Invoice", _conn).Compute("MAX(dc_number)", String.Empty) + 1
        dtePickerDate.Value = Date.Today
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
        dtePickerDate.Value = Date.Today
    End Sub
    Private Sub FrmRegisterSelection_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _message = "Invoice Students" Then
            design.loadPnl(pnlInvoicingStudents, True)
            lblHeading.Text = "Invoicing Students"
        ElseIf _message = "Register Filter" Then
            design.loadPnl(pnlRegisterFilters, True)
        ElseIf _message = "New User" Then
            design.loadPnl(pnlUserAccounts, True)
            lblHeading.Text = "New User Account"
        End If

        txtDocNumber.Text = $"INV00{_docNumber}"

        Dim classList As DataTable = selectStatement.GetClasses(_conn)
        For Each row In classList.Rows
            Dim sclass As String = row("cl_class").ToString
            cmbClass.Items.Add(sclass)
            cmbBoxClass.Items.Add(sclass)
        Next


    End Sub
    Private Sub btnValidateAndFinalise_Click(sender As Object, e As EventArgs) Handles btnValidateAndFinalise.Click

        If pnlInvoicingStudents.Visible = True Then
            Dim verified As Boolean = design.txtboxformats(pnlInvoicingStudents)
            Dim invoicedDT As DataTable = selectStatement.GetinvoicedStudents(_conn)

            If verified Then
                Dim allStudentsDT As DataTable = selectStatement.GetFromClassForInvoicing(cmbBoxClass.Text, _conn)
                Dim allStudentIDs As New List(Of Integer)

                For Each row In allStudentsDT.Rows
                    allStudentIDs.Add(row("Student_ID"))
                Next

                For Each row In invoicedDT.Rows

                    Dim invDate As DateTime = row("date")
                    Dim invMonth As Integer = invDate.Month
                    Dim invYear As Integer = invDate.Year
                    Dim invDay As Integer = invDate.Day

                    Dim currentMonth As Integer = DateTime.Now.Month
                    Dim currentYear As Integer = DateTime.Now.Year
                    Dim currentDay As Integer = DateTime.Now.Day

                    If invMonth = currentMonth And invYear = currentYear Then
                        Dim alreadyInvoicedID As Integer = row("id")
                        If allStudentIDs.Contains(alreadyInvoicedID) Then
                            allStudentIDs.Remove(alreadyInvoicedID)
                        End If
                    End If

                Next

                Dim selection As New List(Of DataSelection)
                addCostsToCollection()

                If allStudentIDs.Count = 0 Then
                    design.messagboxInfo("Ooops!", $"No students from {cmbBoxClass.Text} were found.", Me)
                    Exit Sub
                Else
                    For Each studentID In allStudentIDs
                        For Each item In sCosts
                            If Not item.text = "0" Then
                                Dim value As Integer
                                If Integer.TryParse(item.Text.Trim(), value) Then

                                    Dim newselection As New DataSelection(Date.Today, item.tag, value, 0, cmbBoxCurrency.Text, "DR", cmbBoxPaymentType.Text, studentID, txtDocNumber.Text)
                                    selection.Add(newselection)

                                End If
                            End If
                        Next
                    Next
                End If

                SQLLine.InsertStudentPayments(_frm.lblConnectedUser.Text, selection, _conn)
                SQLLine.InsertDocNumber(_docNumber, "Invoice", _conn)
                Close()
            End If

        ElseIf pnlRegisterFilters.Visible = True Then
            Dim verified As Boolean = design.txtboxformats(pnlRegisterFilters)
            If verified Then
                Dim frm As New FrmRegister(cmbClass.Text, "Update Register", dtePickerDate.Value, cmbTerm.Text, _term, _darkmode, _frm, _conn)
                frm.ShowDialog()
            End If

        ElseIf pnlUserAccounts.Visible = True Then
            Dim verified As Boolean = design.txtboxformats(pnlUserAccounts)
            Dim passwordConfirmation As Boolean

            If txtCPassword.Text.Trim() = txtPassword.Text.Trim Then
                passwordConfirmation = True
            Else
                design.messagboxError("Error", "The provided passwords don't match!", Me)
            End If

            If verified And passwordConfirmation Then
                If cmbAccountType.Text = "Admin" Then
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "*This account is about to be saved as an Admin account." & vbCrLf & "*Admin accounts have access to editing and deleting records." & vbCrLf & vbCrLf & "Proceed?",
                        .Parent = Me,
                        .Buttons = MessageDialogButtons.YesNo,
                        .Style = MessageDialogStyle.Dark,
                        .Icon = MessageDialogIcon.Warning,
                        .Caption = "Warning!"
                    }

                    Dim result As DialogResult = CustomMessageBox.Show
                    If result = DialogResult.Yes Then
                        Dim plainTextPassword As String = txtPassword.Text
                        Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(plainTextPassword)
                        Dim NewUser As New List(Of SignUp)

                        Dim userDetails As New SignUp(txtUsername.Text, passwordHash, Date.Today, cmbAccountType.Text)
                        NewUser.Add(userDetails)
                        SQLLine.InsertNewUser(txtUsername.Text, NewUser, _conn)
                        Close()
                    Else
                    End If
                Else
                    Dim plainTextPassword As String = txtPassword.Text
                    Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(plainTextPassword)
                    Dim NewUser As New List(Of SignUp)

                    Dim userDetails As New SignUp(txtUsername.Text, passwordHash, Date.Today, cmbAccountType.Text)
                    NewUser.Add(userDetails)
                    SQLLine.InsertNewUser(txtUsername.Text, NewUser, _conn)
                    Close()
                End If
            End If
        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Public Sub addCostsToCollection()
        'Empty Collection
        sCosts.Clear()

        'Add new items to the collection
        txtMiscellaneousCost.Tag = txtMiscellaneous.Text

        sCosts.Add(txtClassCost)
        sCosts.Add(txtTransportCost)
        sCosts.Add(txtUniformCost)
        sCosts.Add(txtReportBook)
        sCosts.Add(txtTextbooksCost)
        sCosts.Add(txtMiscellaneousCost)

    End Sub
    Private Sub CmbBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUniform.SelectedValueChanged, cmbTextBooks.SelectedValueChanged, cmbBoxTransport.SelectedValueChanged, cmbBoxReportBook.SelectedValueChanged, cmbBoxClass.SelectedValueChanged

        Dim dtCosts As New DataTable
        dtCosts = selectStatement.GetStudentCosts(_conn)

        Dim dtClassCosts As New DataTable
        dtClassCosts = selectStatement.GetStudentClassCost(_conn)

        Select Case sender.name

            Case "cmbUniform"
                Dim vTest As Boolean = False

                For Each row As DataRow In dtCosts.Rows
                    Dim description As String = row("sc_description").ToString

                    If description = "Uniform" And Not sender.text = "n/a" Then
                        txtUniformCost.Text = row("sc_amount")
                        vTest = True
                    End If
                Next

                If Not vTest Then
                    txtUniformCost.Text = 0
                End If


            Case "cmbTextBooks"
                Dim vTest As Boolean = False

                For Each row As DataRow In dtCosts.Rows
                    Dim description As String = row("sc_description").ToString

                    If description = "Textbooks" And Not sender.text = "n/a" Then
                        txtTextbooksCost.Text = row("sc_amount")
                        vTest = True
                    End If
                Next

                If Not vTest Then
                    txtTextbooksCost.Text = 0
                End If

            Case "cmbBoxTransport"
                Dim vTest As Boolean = False

                For Each row As DataRow In dtCosts.Rows
                    Dim description As String = row("sc_description").ToString

                    If description = "Transport Service" And Not sender.text = "n/a" Then
                        txtTransportCost.Text = row("sc_amount")
                        vTest = True
                    End If
                Next

                If Not vTest Then
                    txtTransportCost.Text = 0
                End If

            Case "cmbBoxReportBook"
                Dim vTest As Boolean = False

                For Each row As DataRow In dtCosts.Rows
                    Dim description As String = row("sc_description").ToString

                    If description = "Report Book" And Not sender.text = "n/a" Then
                        txtReportBook.Text = row("sc_amount")
                        vTest = True
                    End If
                Next

                If Not vTest Then
                    txtReportBook.Text = 0
                End If

            Case "cmbBoxClass"
                Dim vTest As Boolean = False

                For Each row As DataRow In dtClassCosts.Rows
                    Dim description As String = row("cl_class").ToString

                    If description = sender.text And Not sender.text = "n/a" Then
                        txtClassCost.Text = row("cl_fees")
                        vTest = True
                    End If
                Next

                If Not vTest Then
                    txtClassCost.Text = 0
                End If

        End Select

    End Sub
    Private Sub totalFees()
        Dim cCost, tCost, uCost, txCost, rCost, mCost As Integer

        cFees.Clear()

        'Add new items to the collection
        If Not Integer.TryParse(txtClassCost.Text.Trim(), cCost) Then
        End If

        If Not Integer.TryParse(txtTransportCost.Text.Trim(), tCost) Then
        End If

        If Not Integer.TryParse(txtUniformCost.Text.Trim(), uCost) Then
        End If

        If Not Integer.TryParse(txtTextbooksCost.Text.Trim(), txCost) Then
        End If

        If Not Integer.TryParse(txtReportBook.Text.Trim(), rCost) Then
        End If

        If Not Integer.TryParse(txtMiscellaneousCost.Text.Trim(), mCost) Then
        End If

        cFees.Add(cCost)
        cFees.Add(tCost)
        cFees.Add(uCost)
        cFees.Add(txCost)
        cFees.Add(rCost)
        cFees.Add(mCost)

        Dim totalFees As Integer = 0

        For Each item In cFees
            totalFees = totalFees + item
        Next

        txtTotalFees.Text = totalFees

    End Sub
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtUniformCost.TextChanged, txtTransportCost.TextChanged, txtTextbooksCost.TextChanged, txtReportBook.TextChanged, txtMiscellaneousCost.TextChanged, txtClassCost.TextChanged
        totalFees()
    End Sub
    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton) From {
        }
        Return sidebarButtons
    End Function
    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton)
        Return pagebuttons
    End Function
    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            pnlInvoicingStudents,
            pnlRegisterFilters,
            pnlUserAccounts,
            pnlTopBar
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblDate,
            lblClass,
            lblHeading,
            lblTerm,
            lblTransportCost,
            lblTextbooksAndSupplys,
            lblReportBook,
            lblPaymentType,
            lblMiscellaneous,
            lblDocNumber,
            lblCurrency,
            lblClass,
            lblUniform,
            lblFees,
            lblInvClass,
            lblAccountType,
            lblUsername,
            lblPassword,
            lblCPassword
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateAndFinalise
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtUniformCost,
            txtTransportCost,
            txtTotalFees,
            txtTextbooksCost,
            txtReportBook,
            txtMiscellaneousCost,
            txtMiscellaneous,
            txtDocNumber,
            txtClassCost,
            txtUsername,
            txtPassword,
            txtCPassword
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbClass,
            cmbTerm,
            cmbUniform,
            cmbTextBooks,
            cmbBoxTransport,
            cmbBoxReportBook,
            cmbBoxPaymentType,
            cmbBoxCurrency,
            cmbBoxClass,
            cmbAccountType
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
            }
        Return placeholder
    End Function

    Private Sub FrmRegisterSelection_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        _frm.Updates()
    End Sub
End Class