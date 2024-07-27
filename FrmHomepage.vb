Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports System.Windows.Forms

Public Class Homepage

    Private buttonList As New Collection
    Dim toolTip As New Design()
    Dim selectStatement As New SelectStats()

    'form load
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Removing top levels from forms
        TopLevelRemoval()

        'Loading options form 
        Dim loadOptions As New Design()
        loadOptions.OpenOptionsForm(FrmOptions, pnlOptionsDock)

    End Sub
    'Remove top levels from forms
    Private Sub TopLevelRemoval()

        FrmOptions.TopLevel = False
        FrmAdmission.TopLevel = False
        FrmBanking.TopLevel = False
        FrmExaminations.TopLevel = False
        FrmReports.TopLevel = False

    End Sub
    'Button Click Events
    Private Sub SideBarButtons_Click(sender As Object, e As EventArgs) Handles btnReports.Click, btnExams.Click, btnControlPanel.Click, btnBanking.Click, btnAdmissions.Click

        'set false to topLevel on forms
        TopLevelRemoval()

        'Add buttons to collection 
        addToButtonCollection()

        'Remove styling on all buttons
        For Each item In buttonList
            Dim btnStyleRemove As New Design()
            btnStyleRemove.unPressedButton(item, e)
        Next item

        'Apply a style on clicked button
        Dim btnStyle As New Design()
        btnStyle.PressedButton(sender, e, Me, pnlUnderline)

        'Close currently opened form
        For Each control In pnlDockParent.Controls
            If TypeOf control Is Form Then
                DirectCast(control, Form).Close()
            End If
        Next

        Select Case sender.name

            Case "btnAdmissions"

                Dim openForm As New Design()
                openForm.OpenForm(FrmAdmission, pnlDockParent)

            Case "btnReports"

                Dim openForm As New Design()
                openForm.OpenForm(FrmReports, pnlDockParent)

            Case "btnExams"

                Dim openForm As New Design()
                openForm.OpenForm(FrmExaminations, pnlDockParent)

            Case "btnBanking"

                Dim openForm As New Design()
                openForm.OpenForm(FrmBanking, pnlDockParent)

            Case "btnControlPanel"

                Dim CustomMessageBox As New Guna2MessageDialog With {
                    .Text = "Only an administrator has access to the control panel!",
                    .Parent = Me,
                    .Buttons = MessageDialogButtons.OK,
                    .Style = MessageDialogStyle.Dark,
                    .Icon = MessageDialogIcon.Error,
                    .Caption = "Restricted Access"
                }

                CustomMessageBox.Show()

        End Select

    End Sub
    Private Sub btnMinAndClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnMinimize.Click
        If sender.name = "btnMinimize" Then
            WindowState = FormWindowState.Minimized
        ElseIf sender.name = "btnClose" Then
            Close()
        End If
    End Sub

    Private Sub btnControls_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click, btnAboutUs.Click, btnHome.Click

        'Remove the side button styling 
        addToButtonCollection()

        For Each item In buttonList
            Dim btnStyleRemove As New Design()
            btnStyleRemove.unPressedButton(item, e)
        Next item

        'remove side border
        pnlUnderline.BackColor = Color.FromArgb(250, 250, 250)

        'close any docked forms 
        For Each control In pnlDockParent.Controls
            If TypeOf control Is Form Then
                DirectCast(control, Form).Close()
            End If
        Next

        Select Case sender.name

            Case "btnHome"

                For Each control In pnlDockParent.Controls
                    If TypeOf control Is Form Then
                        DirectCast(control, Form).Close()
                    End If
                Next

            Case "btnNotifications"
                Dim popUpBubble As New NotificationBubble
                popUpBubble.ShowNotification("View.", "Proposal", "The primary objective of this project is to enhance student engagement.")

            Case "btnAboutUs"

        End Select


    End Sub
    Private Sub btnFlipOptionsPage_Click(sender As Object, e As EventArgs) Handles btnFlipPageLeft.Click, btnFlipPageRight.Click

        Dim sliding As New Design()

        Select Case sender.name

            Case "btnFlipPageRight"
                If FrmOptions.Location.X = 0 Then
                    sliding.SlideFormLeft(FrmOptions, FrmOptions.Location.X, FrmOptions.Location.Y)
                    rdoBtnSettings.Checked = True
                End If

            Case "btnFlipPageLeft"

                If FrmOptions.Location.X = -660 Then
                    sliding.SlideFormRight(FrmOptions, FrmOptions.Location.X, FrmOptions.Location.Y)
                    rdoBtnAccounts.Checked = True
                End If

        End Select

    End Sub

    'Button hover events
    Private Sub btnOnHover_MouseHover(sender As Object, e As EventArgs) Handles btnNotifications.MouseHover, btnAboutUs.MouseHover, btnHome.MouseHover


        Select Case sender.name

            Case "btnHome"
                toolTip.ToolTip(sender, e, "Home", "Go to the homepage.")

            Case "btnNotifications"
                toolTip.ToolTip(sender, e, "Notifications", "You have 0 pending notifications.")

            Case "btnAboutUs"
                toolTip.ToolTip(sender, e, "Developers", "More about Us.")

        End Select
    End Sub

    'Add side button list to collection
    Public Sub addToButtonCollection()
        'Empty Collection
        buttonList.Clear()

        'Add new items to the collection
        buttonList.Add(btnAdmissions)
        buttonList.Add(btnReports)
        buttonList.Add(btnExams)
        buttonList.Add(btnBanking)
        buttonList.Add(btnControlPanel)

    End Sub

    Private Sub btnCloseDatabase_Click(sender As Object, e As EventArgs) Handles btnCloseDatabase.Click

        Dim CustomMessageBox As New Guna2MessageDialog With {
                    .Text = "Are you sure you want to close the application?",
                    .Parent = Me,
                    .Buttons = MessageDialogButtons.YesNo,
                    .Style = MessageDialogStyle.Light,
                    .Icon = MessageDialogIcon.Question,
                    .Caption = "Close Application"
                }

        Dim result As DialogResult = CustomMessageBox.Show
        If result = DialogResult.Yes Then
            Close()
        End If

    End Sub

End Class
