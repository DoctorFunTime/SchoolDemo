
Imports Frond_End_Design
Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms

Public Class FrmEnrollment

    Dim design As New Design
    Private buttonList As New Collection

    'side btn click events
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click, btnStudentDetails.Click, btnPayments.Click, btnGuardian.Click

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

            Case "btnStudentDetails"
                design.loadPnl(pnlStudent)

            Case "btnSubjects"
                design.loadPnl(pnlSubjects)

            Case "btnGuardian"
                design.loadPnl(pnlGuardians)

            Case "btnPayments"
                design.loadPnl(pnlPayments)

        End Select

    End Sub

    Private Sub FrmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        design.loadPnl(pnlStudent)
        btnStudentDetails.PerformClick()

        ' add items to listbox

        ListBoxSubjects.Items.Add("Mathematics")
        ListBoxSubjects.Items.Add("English")
        ListBoxSubjects.Items.Add("Economics")
        ListBoxSubjects.Items.Add("Chemistry")
        ListBoxSubjects.Items.Add("Physics")
        ListBoxSubjects.Items.Add("Biology")
        ListBoxSubjects.Items.Add("Business Studies")
        ListBoxSubjects.Items.Add("Divinity")
        ListBoxSubjects.Items.Add("IT")
        ListBoxSubjects.Items.Add("Accounting")
        ListBoxSubjects.Items.Add("combined Sciences")
        ListBoxSubjects.Items.Add("Food and nutrition")
        ListBoxSubjects.Items.Add("Shona")
        ListBoxSubjects.Items.Add("Literature")
        ListBoxSubjects.Items.Add("Commerce")
        ListBoxSubjects.Items.Add("Statistics")


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
    Private Sub btnValidation_Click(sender As Object, e As EventArgs) Handles btnValidateStudentDetails.Click, btnValidateSubjects.Click, btnValidateGuardians.Click, btnValidateAndFinalise.Click

        Select Case sender.name

            Case "btnValidateStudentDetails"

                Dim verifiedDate As Boolean = design.txtboxformats(dtePickerDateOfBirth)
                Dim Validation As Boolean = False

                Validation = design.txtboxformats(pnlStudent)

                If verifiedDate And Validation Then
                    design.PressedButton(btnStudentDetails, e, 120, True)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlSubjects)
                    btnSubjects.PerformClick()
                End If

            Case "btnValidateSubjects"

                If cntrlCtrlSelection.Controls.Count < 3 Then
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "At least three subjects have to be enlisted!",
                        .Parent = Me,
                        .Buttons = MessageDialogButtons.OK,
                        .Style = MessageDialogStyle.Light,
                        .Icon = MessageDialogIcon.Information,
                        .Caption = "No Subjects Found"
                    }
                    CustomMessageBox.Show()

                Else
                    design.PressedButton(btnSubjects, e, 120, True)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlGuardians)
                    btnGuardian.PerformClick()
                End If

            Case "btnValidateGuardians"

                Dim verifiedTitle As Boolean = design.txtboxformats(cmbBoxTitle)
                Dim validation As Boolean = False

                validation = design.txtboxformats(pnlGuardians)

                If verifiedTitle And validation Then

                    design.PressedButton(btnGuardian, e, 120, True)
                    design.clearPanels(pnlDock)
                    design.loadPnl(pnlPayments)
                    btnPayments.PerformClick()

                End If

            Case "btnValidateAndFinalise"

                Dim verifiedClass As Boolean = design.txtboxformats(cmbBoxClass)
                Dim verifiedAmount As Boolean = design.txtboxformats(pnlPayments)

                If verifiedAmount And verifiedClass Then

                    design.PressedButton(btnPayments, e, 120, True)

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

    Private Sub btnCopySurname_Click(sender As Object, e As EventArgs) Handles btnCopySurname.Click, btnCopyAddress.Click

        Select Case sender.name
            Case "btnCopySurname"
                txtGSurname.Text = txtSurname.Text
            Case "btnCopyAddress"
                txtGAddress.Text = txtAddress.Text
        End Select

    End Sub

    Private Sub cmbBoxClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxClass.SelectedIndexChanged
        Select Case cmbBoxClass.Text
            Case "Form 1"
                txtFees.Text = 30

            Case "Form 2"
                txtFees.Text = 40

            Case "Form 3"
                txtFees.Text = 45

            Case "Form 4"
                txtFees.Text = 50

            Case "Form 5"
                txtFees.Text = 55

            Case "Form 6"
                txtFees.Text = 60

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

    End Sub

End Class