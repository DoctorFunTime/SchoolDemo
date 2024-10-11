Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports MyEncapsulation
Imports SQLStatements

Public Class FrmEnrollment
    Private selctStatement As New SelectStats
    Private subjectList As DataTable
    Private classList As DataTable
    Public newStdID As Integer
    Private design As New Design
    Private buttonList As New Collection
    Private sCosts As New Collection
    Private cFees As New List(Of Integer)
    Private insert As New SQLLine
    Private _docNumber As Integer
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _conn = conn
        _frm = frm
        subjectList = selctStatement.GetSubjects(_conn)
        classList = selctStatement.GetClasses(_conn)
        _docNumber = selctStatement.GetDocNumber("Invoice", _conn).Compute("MAX(dc_number)", String.Empty) + 1
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
        dtePickerDateOfBirth.Value = Date.Today

    End Sub

    'side btn click events
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click, btnStudentDetails.Click, btnPayments.Click, btnGuardian.Click, btnMedicals.Click

        'clear opened panels
        design.clearPanels(pnlDock)

        'Add buttons to collection
        addToButtonCollection()

        'Remove styling on all buttons
        For Each item In buttonList
            design.unPressedButton(item, e, 120)
        Next item

        design.PressedButton(sender, e, 135, False, _darkmode)

        Select Case sender.name

            Case "btnStudentDetails"
                design.loadPnl(pnlStudent)

            Case "btnSubjects"
                design.loadPnl(pnlSubjects)

            Case "btnGuardian"
                design.loadPnl(pnlGuardians)

            Case "btnPayments"
                design.loadPnl(pnlPayments)

            Case "btnMedicals"
                design.loadPnl(pnlMedicals)
        End Select

    End Sub

    Private Sub FrmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDocNumber.Text = $"INV00{_docNumber}"
        addToButtonCollection()

        design.loadPnl(pnlStudent)
        btnStudentDetails.PerformClick()

        ' add items to listbox
        For Each row As DataRow In subjectList.Rows
            Dim subject As String = row("s_subject").ToString
            ListBoxSubjects.Items.Add(subject)
        Next

        For Each row As DataRow In classList.Rows
            Dim sclass As String = row("cl_class").ToString
            cmbBoxClass.Items.Add(sclass)
        Next

    End Sub

    'creating chips from listbox
    Private Sub ListBoxSubjects_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxSubjects.MouseDoubleClick

        Dim GCHips As New Guna2Chip With {
            .Dock = DockStyle.Top,
            .Text = ListBoxSubjects.Text,
            .BackColor = Color.Transparent,
            .FillColor = Color.PowderBlue,
            .ForeColor = Color.Black,
            .BorderThickness = 0,
            .Font = New Font("Century gothic", 9, FontStyle.Regular)
        }

        For Each control In cntrlCtrlSelection.Controls

            If TypeOf control Is Guna2Chip Then
                If control.text = GCHips.Text Then
                    Exit Sub
                Else
                End If
            End If

        Next

        cntrlCtrlSelection.Controls.Add(GCHips)

    End Sub

    'validation buttons
    Private Sub btnValidation_Click(sender As Object, e As EventArgs) Handles btnValidateStudentDetails.Click, btnValidateSubjects.Click, btnValidateGuardians.Click, btnValidateMedicals.Click, btnValidateAndFinalise.Click

        Select Case sender.name

            Case "btnValidateStudentDetails"

                Dim verifiedDate As Boolean = design.txtboxformats(dtePickerDateOfBirth)
                Dim Validation As Boolean = design.txtboxformats(pnlStudent)

                If verifiedDate And Validation Then
                    design.PressedButton(btnStudentDetails, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlSubjects)
                    btnSubjects.PerformClick()
                End If

            Case "btnValidateSubjects"

                If cntrlCtrlSelection.Controls.Count < 3 Then
                    design.messagboxInfo("No subject(s) found.", "At least three subjects have to be enlisted!", Me)
                Else
                    design.PressedButton(btnSubjects, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlGuardians)
                    btnGuardian.PerformClick()
                End If

            Case "btnValidateGuardians"

                Dim validation As Boolean = design.txtboxformats(pnlGuardians)

                If validation Then
                    design.PressedButton(btnGuardian, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlMedicals)
                    btnMedicals.PerformClick()
                End If

            Case "btnValidateMedicals"

                Dim validation As Boolean = design.txtboxformats(pnlMedicals)

                If validation Then
                    design.PressedButton(btnMedicals, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlPayments)
                    btnPayments.PerformClick()
                End If

            Case "btnValidateAndFinalise"

                For Each item As Guna2GradientButton In buttonList
                    If Not item.ForeColor = Color.SeaGreen And Not item.Name = "btnPayments" Then
                        item.PerformClick()
                        Select Case item.Name
                            Case "btnStudentDetails"
                                btnValidateStudentDetails.PerformClick()
                            Case "btnSubjects"
                                btnValidateSubjects.PerformClick()
                            Case "btnGuardian"
                                btnValidateGuardians.PerformClick()
                            Case "btnMedicals"
                                btnValidateMedicals.PerformClick()
                        End Select
                        Exit Sub
                    End If
                Next

                Dim verifiedAmount As Boolean = design.txtboxformats(pnlPayments)

                If String.IsNullOrEmpty(txtMiscellaneous.Text) And Not txtMiscellaneousCost.Text = "0" Then
                    design.messagboxWarning("Warning", "A miscellaneous cost is detected without a corresponding amount or vice versa!", Me)
                    Exit Sub
                ElseIf txtMiscellaneous.Text = "n/a" And Not txtMiscellaneousCost.Text = "0" Then
                    design.messagboxWarning("Warning", "A miscellaneous cost is detected without a corresponding amount or vice versa!", Me)
                    Exit Sub
                ElseIf Not String.IsNullOrEmpty(txtMiscellaneous.Text) And Not txtMiscellaneous.Text = "n/a" And txtMiscellaneousCost.Text = "0" Then
                    design.messagboxWarning("Warning", "A miscellaneous cost is detected without a corresponding amount or vice versa!", Me)
                    Exit Sub
                End If

                If verifiedAmount Then

                    design.PressedButton(btnPayments, e, 120, True, _darkmode)
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "Proceed to enroll student?",
                        .Parent = Me,
                        .Buttons = MessageDialogButtons.YesNo,
                        .Style = MessageDialogStyle.Light,
                        .Icon = MessageDialogIcon.Question,
                        .Caption = "Enroll Student?"
                    }
                    Dim result As DialogResult = CustomMessageBox.Show
                    If result = DialogResult.Yes Then

                        SQLLine.InsertStudentDetails(txtFirstName.Text, txtSurname.Text, cmbBoxClass.Text, dtePickerDateOfBirth.Value, txtBirthIDNumber.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmailAddress.Text, cmbBoxTitle.Text, txtGName.Text, txtGSurname.Text, txtGAddress.Text, txtGPhoneNumber.Text, txtGEmailAddress.Text, Date.Today, _frm.lblConnectedUser.Text, _conn)

                        Dim formID As String = "Enrollment"
                        Dim selectStudent As New FrmSelectStudent(formID, _darkmode, Me, _conn) With {
                            ._frm = _frm
                        }

                        selectStudent.ShowDialog()

                        SQLLine.InsertComments("He/She has made very good progress and must maintain the standard. Keep it up!", newStdID, _frm.lblConnectedUser.Text, _conn)
                        SQLLine.InsertStudentMedicals(newStdID, txtAllegies.Text, txtRequiredTreatment.Text, txtMedications.Text, txtDosage.Text, txtSchedule.Text, txtDisabilities.Text, txtPhysician.Text, txtPhysicianContacts.Text, _frm.lblConnectedUser.Text, _conn)

                        Dim selectedSubjects As New List(Of String)

                        For Each control In cntrlCtrlSelection.Controls
                            If TypeOf control Is Guna2Chip Then
                                selectedSubjects.Add(control.text)
                            End If
                        Next

                        SQLLine.InsertStudentSubjects(newStdID, _frm.lblConnectedUser.Text, selectedSubjects, _conn)

                        Dim selection As New List(Of DataSelection)
                        addCostsToCollection()
                        Dim monthComp As String = "INV"

                        For Each item In sCosts
                            If Not item.text = "0" Then
                                Dim value As Integer
                                If Integer.TryParse(item.Text.Trim(), value) Then

                                    Dim newselection As New DataSelection(Date.Today, monthComp & "-" & item.tag, value, 0, cmbBoxCurrency.Text, "DR", cmbBoxPaymentType.Text, newStdID, txtDocNumber.Text)
                                    selection.Add(newselection)

                                End If
                            End If
                        Next

                        SQLLine.InsertStudentPayments(_frm.lblConnectedUser.Text, selection, _conn)
                        SQLLine.InsertDocNumber(_docNumber, "Invoice", _conn)

                        Dim frm As New FrmTuition(txtFirstName.Text, newStdID, _darkmode, _frm, _conn)
                        btnClose.PerformClick()
                    End If
                End If

        End Select
    End Sub

    'copy details from student
    Private Sub btnCopy_MouseHover(sender As Object, e As EventArgs) Handles btnCopyAddress.MouseHover, btnCopySurname.MouseHover

        Dim toolTip As New Guna2HtmlToolTip With {
            .AutoPopDelay = 5000,
            .AutomaticDelay = 500,
            .InitialDelay = 500,
            .ReshowDelay = 100,
            .IsBalloon = True,
            .BackColor = Color.PowderBlue,
            .Font = New Font("Century gothic", 8),
            .ForeColor = Color.Black,
            .TitleFont = New Font("Century Gothic", 12, FontStyle.Bold),
            .TitleForeColor = Color.Black,
            .ToolTipTitle = "Update Details?",
            .ToolTipIcon = ToolTipIcon.Info,
            .UseAnimation = True,
            .UseFading = True,
            .ShowAlways = False
        }

        toolTip.SetToolTip(sender, "Click to update with student details.")
    End Sub

    Private Sub btnCopySurname_Click(sender As Object, e As EventArgs) Handles btnCopyAddress.Click, btnCopySurname.Click

        Select Case sender.name
            Case "btnCopySurname"
                txtGSurname.Text = txtSurname.Text
            Case "btnCopyAddress"
                txtGAddress.Text = txtAddress.Text
        End Select

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    'Add side button list to collection
    Public Sub addToButtonCollection()
        'Empty Collection
        buttonList.Clear()

        'Add new items to the collection
        buttonList.Add(btnStudentDetails)
        buttonList.Add(btnSubjects)
        buttonList.Add(btnGuardian)
        buttonList.Add(btnPayments)
        buttonList.Add(btnMedicals)

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

    Private Sub chkBoxStudentNotApplicable_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxStudentNotApplicable.CheckedChanged, chkBoxGuardiansNotApplicable.CheckedChanged, chkBoxMedicalsNotApplicable.CheckedChanged, chkBoxPaymentsNotApplicable.CheckedChanged

        Select Case sender.name

            Case "chkBoxStudentNotApplicable"
                If sender.Checked Then
                    For Each control In pnlStudent.Controls
                        If TypeOf control Is Guna2TextBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
                End If

            Case "chkBoxGuardiansNotApplicable"
                If sender.Checked Then
                    For Each control In pnlGuardians.Controls
                        If TypeOf control Is Guna2TextBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
                End If

            Case "chkBoxMedicalsNotApplicable"
                If sender.Checked Then
                    For Each control In pnlMedicals.Controls
                        If TypeOf control Is Guna2TextBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
                End If

            Case "chkBoxPaymentsNotApplicable"
                If sender.Checked Then
                    For Each control In pnlPayments.Controls
                        If TypeOf control Is Guna2ComboBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
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

    Private Sub CmbBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUniform.SelectedValueChanged, cmbTextBooks.SelectedValueChanged, cmbBoxTransport.SelectedValueChanged, cmbBoxReportBook.SelectedValueChanged, cmbBoxClass.SelectedValueChanged

        Dim dtCosts As New DataTable
        dtCosts = selctStatement.GetStudentCosts(_conn)

        Dim dtClassCosts As New DataTable
        dtClassCosts = selctStatement.GetStudentClassCost(_conn)

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

    Private Sub txtReportBook_TextChanged(sender As Object, e As EventArgs) Handles txtUniformCost.TextChanged, txtTransportCost.TextChanged, txtTextbooksCost.TextChanged, txtReportBook.TextChanged, txtMiscellaneousCost.TextChanged, txtClassCost.TextChanged
        totalFees()
    End Sub

    Private Sub pnlPayments_Paint(sender As Object, e As PaintEventArgs) Handles pnlPayments.Paint

    End Sub

    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton) From {
            btnSubjects,
            btnStudentDetails,
            btnPayments,
            btnGuardian,
            btnMedicals
        }
        Return sidebarButtons
    End Function

    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton)
        Return pagebuttons
    End Function

    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            pnlSubjects,
            pnlStudent,
            pnlPayments,
            pnlMedicals,
            pnlGuardians,
            pnlDock
        }
        Return topPanels
    End Function

    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblPhoneNumber,
            lblSurname,
            lblDOB,
            btnBirthIDNumber,
            lblAddress,
            lblAdd,
            lblSelection,
            lblArrow,
            lblGTitle,
            lblGSurname,
            lblGPhoneNumber,
            lblGName,
            lblGEmailAdress,
            lblGAddress,
            lblSchedule,
            lblRequiredTreament,
            lblPhysicianContacts,
            lblPhysician,
            lblMedications,
            lblDosage,
            lblDisabilities,
            lblAllegies,
            lblTransportCost,
            lblTextbooksAndSupplys,
            lblReportBook,
            lblPaymentType,
            lblMiscellaneous,
            lblDocNumber,
            lblCurrency,
            lblClass,
            lblUniform,
            lblHeadingOne,
            lblFees,
            lblName,
            lblEmailAddress
        }
        Return labels
    End Function

    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateStudentDetails,
            btnValidateSubjects,
            btnValidateGuardians,
            btnValidateMedicals,
            btnValidateAndFinalise,
            btnCopySurname,
            btnCopyAddress
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
            txtSchedule,
            txtRequiredTreatment,
            txtPhysicianContacts,
            txtPhysician,
            txtMedications,
            txtDosage,
            txtDisabilities,
            txtAllegies,
            txtGSurname,
            txtGPhoneNumber,
            txtGName,
            txtGEmailAddress,
            txtGAddress,
            txtSurname,
            txtPhoneNumber,
            txtFirstName,
            txtEmailAddress,
            txtBirthIDNumber,
            txtAddress
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxTitle,
            cmbUniform,
            cmbTextBooks,
            cmbBoxTransport,
            cmbBoxReportBook,
            cmbBoxPaymentType,
            cmbBoxCurrency,
            cmbBoxClass
        }
        Return placeholder
    End Function

    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
            chkBoxStudentNotApplicable,
            chkBoxPaymentsNotApplicable,
            chkBoxMedicalsNotApplicable,
            chkBoxGuardiansNotApplicable
            }
        Return placeholder
    End Function

End Class