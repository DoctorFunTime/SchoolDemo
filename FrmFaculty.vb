Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports DatabaseSelectStatements
Public Class FrmFaculty

    Dim design As New Design
    Dim selectStatement As New SelectStats
    Private buttonList As New Collection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dtePickerDateOfBirth.Value = Date.Today

        'load faculty page
        design.loadPnl(pnlFaculty)
        btnFaculty.PerformClick()

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

                    design.PressedButton(btnFaculty, e, 120, True)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlRoles)
                    btnRoles.PerformClick()

                End If

            Case "btnValidateRoles"

                ValidationProcess = design.txtboxformats(pnlFaculty)

                If ValidationProcess Then

                    design.PressedButton(btnRoles, e, 120, True)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlMedicals)
                    btnMedicals.PerformClick()

                End If

            Case "btnValidateAndFinalise"

                Dim verifiedClass As Boolean = design.txtboxformats(cmbBoxClass)
                Dim subjectCheck As Boolean = False

                If cntrlCtrlSelection.Controls.Count < 1 And Not cmbBoxClass.Text = "n/a" Then
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "At least one subject has to be enlisted!",
                        .Parent = Me,
                        .Buttons = MessageDialogButtons.OK,
                        .Style = MessageDialogStyle.Light,
                        .Icon = MessageDialogIcon.Information,
                        .Caption = "No Subject(s) Found"
                    }
                    CustomMessageBox.Show()
                Else
                    subjectCheck = True
                End If
                If subjectCheck And verifiedClass Then
                    design.PressedButton(btnRoles, e, 120, True)
                    Close()
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

        design.PressedButton(sender, e, 135, False)

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
        Dim subjects As DataTable = selectStatement.GetSubjects()
        Dim classes As DataTable = selectStatement.GetClasses()
        Dim OtherRoles As DataTable = selectStatement.GetOtherRoles()

        For Each row In subjects.Rows
            Dim subject As String = row("s_subject").ToString
            ListBoxSubjects.Items.Add(subject)
        Next

        For Each row In classes.Rows
            Dim sclass As String = row("cl_class").ToString
            cmbBoxClass.Items.Add(sclass)
        Next

        For Each row In OtherRoles.Rows
            Dim otherRole As String = row("or_description").ToString
            cmbBoxOtherRoles.Items.Add(otherRole)
        Next

    End Sub

    Private Sub chkBoxRolesNotApplicable_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxRolesNotApplicable.CheckedChanged, chkBoxMedicalsNotApplicable.CheckedChanged, chkBoxFacultyNotApplicable.CheckedChanged
        Select Case sender.name

            Case "chkBoxRolesNotApplicable"
                If sender.Checked Then
                    For Each control In pnlRoles.Controls
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

End Class