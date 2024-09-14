Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports DatabaseSelectStatements
Imports SQLStatements
Imports bubble
Public Class FrmFaculty

    Dim design As New Design
    Dim selectStatement As New SelectStats
    Private buttonList As New Collection
    Private Popup As New NotificationBubble
    Public newFmID As Integer
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage

    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        dtePickerDateOfBirth.Value = Date.Today
        _frm = frm
        _conn = conn
        _darkmode = darkmode
        If _darkmode Then design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidateRoles.Click, btnValidateFaculty.Click, btnValidateAndFinalise.Click

        Dim ValidationProcess As Boolean = False

        Select Case sender.name

            Case "btnValidateFaculty"

                Dim verifiedDate As Boolean = design.txtboxformats(dtePickerDateOfBirth)

                ValidationProcess = design.txtboxformats(pnlFaculty)

                If ValidationProcess And verifiedDate Then

                    design.PressedButton(btnFaculty, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlRoles)
                    btnRoles.PerformClick()

                End If

            Case "btnValidateRoles"

                ValidationProcess = design.txtboxformats(pnlRoles)
                Dim subjectCheck As Boolean = False

                If cntrlCtrlSelection.Controls.Count < 1 And Not cmbBoxClass.Text = "n/a" And Not String.IsNullOrEmpty(cmbBoxClass.Text) Then
                    design.messagboxInfo("No subject(s) found.", "At least one subject has to be enlisted for an educator.", Me)
                Else
                    subjectCheck = True
                End If

                If ValidationProcess And subjectCheck Then

                    design.PressedButton(btnRoles, e, 120, True, _darkmode)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlMedicals)
                    btnMedicals.PerformClick()

                End If

            Case "btnValidateAndFinalise"

                For Each item As Guna2GradientButton In buttonList
                    If Not item.ForeColor = Color.SeaGreen And Not item.Name = "btnMedicals" Then
                        item.PerformClick()
                        Select Case item.Name
                            Case "btnFaculty"
                                btnValidateFaculty.PerformClick()
                            Case "btnRoles"
                                btnValidateRoles.PerformClick()
                        End Select
                        Exit Sub
                    End If
                Next

                Dim verifiedMedicals As Boolean = design.txtboxformats(pnlMedicals)

                If verifiedMedicals Then

                    design.PressedButton(btnRoles, e, 120, True, _darkmode)

                    SQLLine.InsertFacultyDetails(txtFirstName.Text, txtSurname.Text, cmbBoxClass.Text,
                                                 dtePickerDateOfBirth.Value, txtBirthIDNumber.Text,
                                                 txtAddress.Text, txtPhoneNumber.Text, txtEmailAddress.Text, txtAllegies.Text,
                                                 txtRequiredTreatment.Text, txtMedications.Text, txtDosage.Text,
                                                 txtSchedule.Text, txtDisabilities.Text, txtPhysician.Text,
                                                 txtPhysicianContacts.Text, Date.Today, _frm.lblConnectedUser.Text, _conn)

                    Dim facultySelection As New FrmSelectStudent("New Faculty", _darkmode, Me, _conn) With {
                        ._frm = _frm
                    }
                    facultySelection.ShowDialog()

                    Dim selectedSubjects As New List(Of String)
                    For Each control In cntrlCtrlSelection.Controls
                        If TypeOf control Is Guna2Chip Then
                            selectedSubjects.Add(control.text)
                        End If
                    Next

                    SQLLine.InsertEducatorSubjects(newFmID, _frm.lblConnectedUser.Text, selectedSubjects, _conn)
                    Popup.ShowNotification("Ok", "Successful", "Faculty member was successfully added.", Me)
                    Close()
                    _frm.Updates()
                End If

        End Select
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnRoles.Click, btnFaculty.Click, btnMedicals.Click

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

            Case "btnFaculty"
                design.loadPnl(pnlFaculty)

            Case "btnRoles"
                design.loadPnl(pnlRoles)

            Case "btnMedicals"
                design.loadPnl(pnlMedicals)

        End Select
    End Sub
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

    'Add side button list to collection
    Public Sub addToButtonCollection()

        'Empty Collection
        buttonList.Clear()

        'Add new items to the collection
        buttonList.Add(btnFaculty)
        buttonList.Add(btnRoles)
        buttonList.Add(btnMedicals)

    End Sub

    Private Sub FrmFaculty_Load(sender As Object, e As EventArgs) Handles Me.Load
        'add subjects to listbox

        Dim subjects As DataTable = selectStatement.GetSubjects(_conn)
        Dim classes As DataTable = selectStatement.GetClasses(_conn)
        Dim OtherRoles As DataTable = selectStatement.GetOtherRoles(_conn)

        For Each row In subjects.Rows
            Dim subject As String = row("s_subject").ToString
            ListBoxSubjects.Items.Add(subject)
        Next

        For Each row In classes.Rows
            Dim sclass As String = row("cl_class").ToString
            cmbBoxClass.Items.Add(sclass)
        Next

        design.loadPnl(pnlFaculty)
        btnFaculty.PerformClick()
    End Sub

    Private Sub chkBoxNotApplicable_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxMedicalsNotApplicable.CheckedChanged, chkBoxFacultyNotApplicable.CheckedChanged
        Select Case sender.name

            Case "chkBoxRolesNotApplicable"

                If sender.Checked Then
                    For Each control In pnlRoles.Controls
                        If TypeOf control Is Guna2TextBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
                End If

                If sender.Checked Then
                    For Each control In pnlRoles.Controls
                        If TypeOf control Is Guna2ComboBox AndAlso String.IsNullOrEmpty(control.text) Then
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

            Case "chkBoxFacultyNotApplicable"
                If sender.Checked Then
                    For Each control In pnlFaculty.Controls
                        If TypeOf control Is Guna2TextBox AndAlso String.IsNullOrEmpty(control.text) Then
                            control.text = "n/a"
                        End If
                    Next
                End If

        End Select
    End Sub
    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton) From {
            btnRoles,
            btnFaculty,
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
            pnlRoles,
            pnlMedicals,
            pnlFaculty,
            pnlDock
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblSchedule,
            lblRequiredTreament,
            lblPhysicianContacts,
            lblPhysician,
            lblMedications,
            lblDosage,
            lblDisabilities,
            lblAllegies,
            lblSelection,
            lblHeadingOne,
            lblClass,
            lblArrow,
            lblAdd,
            lblSurname,
            lblPhoneNumber,
            lblName,
            lblEmailAddress,
            lblDOB,
            lblAddress,
            lblBirthIDNumber
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnValidateRoles,
            btnValidateFaculty,
            btnValidateAndFinalise
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
            txtSchedule,
            txtRequiredTreatment,
            txtPhysicianContacts,
            txtPhysician,
            txtMedications,
            txtDosage,
            txtDisabilities,
            txtAllegies,
            txtEmailAddress,
            txtPhoneNumber,
            txtAddress,
            txtBirthIDNumber,
            txtSurname,
            txtFirstName
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
            cmbBoxClass
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
            chkBoxMedicalsNotApplicable,
            chkBoxFacultyNotApplicable
            }
        Return placeholder
    End Function

End Class