Imports Frond_End_Design
Imports Guna.UI2.WinForms
Public Class FrmFaculty

    Dim design As New Design
    Private buttonList As New Collection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dtePickerDateOfBirth.Value = Date.Today

        'load faculty page
        design.loadPnl(pnlFaculty)
        btnFaculty.PerformClick()

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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidateAndFinalise.Click, btnValidateFaculty.Click

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

            Case "btnValidateAndFinalise"

                Dim verifiedClass As Boolean = design.txtboxformats(cmbBoxClass)

                Dim subjectCheck As Boolean = False

                If cntrlCtrlSelection.Controls.Count < 1 Then
                    Dim CustomMessageBox As New Guna2MessageDialog With {
                        .Text = "At least one subject have to be enlisted!",
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

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnRoles.Click, btnFaculty.Click

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

    End Sub
End Class