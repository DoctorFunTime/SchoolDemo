Imports Guna.UI2.WinForms
Imports Frond_End_Design
Imports DatabaseSelectStatements
Imports SQLDeleteStatements

Public Class FrmEventsPlanner
    Private design As New Design
    Private selectStatement As New SelectStats
    Private _darkmode As Boolean
    Private _conn As String
    Private _frm As Homepage
    Public Sub New(darkmode As Boolean, frm As Form, conn As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim currentYear As Integer = DateTime.Now.Year
        dtePickerDate.MinDate = New DateTime(currentYear, 1, 1)
        dtePickerDate.MaxDate = New DateTime(currentYear, 12, 31)
        dtePickerDate.Value = Date.Today
        _conn = conn
        _frm = frm
        _darkmode = darkmode
        design.darkMode(Me, _darkmode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMFormButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmEventsPlanner_Load(sender As Object, e As EventArgs) Handles Me.Load

        If _darkmode Then
            dtePickerDate.ForeColor = Color.White
            btnAddEvent.ForeColor = Color.White
            btnAddEvent.ShadowDecoration.Color = Color.PowderBlue
        Else
            dtePickerDate.ForeColor = Color.Black
            btnAddEvent.ForeColor = Color.Black
            btnAddEvent.ShadowDecoration.Color = Color.DimGray
        End If

        UICreations()

    End Sub
    Public Sub UICreations()
        Dim color1 As Color
        Dim color2 As Color
        Dim color3 As Color
        Dim forecolor As Color
        Dim bordercolor As Color
        Dim eventsDT As DataTable = selectStatement.GetEvents(_conn)

        Dim Colors As Color() = {Color.PaleGreen, Color.SlateBlue, Color.Pink, Color.Moccasin, Color.MistyRose, Color.RosyBrown, Color.RoyalBlue, Color.Yellow, Color.SeaGreen}

        If _darkmode Then
            color1 = Color.FromArgb(40, 30, 100)
            color2 = Color.FromArgb(60, 40, 120)
            color3 = Color.SlateBlue
            forecolor = Color.White
            bordercolor = Color.PowderBlue
            pnlFlowDays.BackColor = Color.FromArgb(40, 30, 90)
            pnlFlowHeader.BackColor = Color.FromArgb(40, 30, 90)
        Else
            color1 = Color.PowderBlue
            color2 = Color.LightGray
            color3 = Color.DeepSkyBlue
            forecolor = Color.Black
            bordercolor = Color.Gray
            pnlFlowDays.BackColor = Color.White
            pnlFlowHeader.BackColor = Color.White
        End If

        pnlFlowDays.Controls.Clear()
        pnlFlowHeader.Controls.Clear()

        lblHeading.Text = $"Events Calendar - {dtePickerDate.Value.ToString("MMMM yyyy")}"

        Dim daysOfTheWeek As String() = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        For Each day As String In daysOfTheWeek
            Dim dayPanel As New Guna2GradientPanel With {
                .Size = New Size(157, 30),
                .FillColor = Color.Transparent,
                .FillColor2 = Color.Transparent
            }

            Dim label As New Guna2HtmlLabel With {
                .Text = day,
                .Location = New Point(dayPanel.Location.X + 55, dayPanel.Location.Y + 10),
                .TextAlignment = ContentAlignment.MiddleCenter,
                .ForeColor = forecolor,
                .Font = New Font("Century Gothic", 14)
            }

            dayPanel.Controls.Add(label)
            pnlFlowHeader.Controls.Add(dayPanel)
        Next

        Dim currentMonth As Integer = dtePickerDate.Value.Month
        Dim currentYear As Integer = dtePickerDate.Value.Year
        Dim firstDayOfTheMonth As New DateTime(currentYear, currentMonth, 1)
        Dim daysInMonth As Integer = DateTime.DaysInMonth(currentYear, currentMonth)
        Dim startDayOfTheWeek As Integer = CInt(firstDayOfTheMonth.DayOfWeek) ' 0 sunday, 6 saturday

        For i As Integer = 1 To startDayOfTheWeek - 1
            Dim emptyPanel As New Guna2GradientPanel With {
                    .Size = New Size(157, 95),
                    .FillColor = color1,
                    .FillColor2 = If(i = dtePickerDate.Value.Day, color3, color2),
                    .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal,
                    .Cursor = Cursors.Hand,
                    .BorderRadius = 5,
                    .BorderThickness = If(i = dtePickerDate.Value.Day, 1, 0),
                    .BorderColor = bordercolor
                }

            pnlFlowDays.Controls.Add(emptyPanel)

        Next

        For i As Integer = 1 To daysInMonth

            Dim datePanelItem As New Guna2GradientPanel With {
                    .Size = New Size(157, 95),
                    .FillColor = color1,
                    .FillColor2 = If(i = dtePickerDate.Value.Day, color3, color2),
                    .GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal,
                    .Cursor = Cursors.Hand,
                    .BorderRadius = 5,
                    .BorderThickness = If(i = dtePickerDate.Value.Day, 1, 0),
                    .BorderColor = bordercolor
                }

            Dim DateLabel As New Guna2HtmlLabel With {
                    .Text = i,
                    .Dock = DockStyle.Top,
                    .TextAlignment = ContentAlignment.MiddleCenter,
                    .ForeColor = forecolor,
                    .Font = New Font("Century Gothic", 9, FontStyle.Bold),
                    .Cursor = Cursors.Hand
                }

            Dim EventLabel As New Guna2HtmlLabel With {
                    .Text = i,
                    .Dock = DockStyle.Top,
                    .TextAlignment = ContentAlignment.MiddleCenter,
                    .ForeColor = forecolor,
                    .Font = New Font("Century Gothic", 10, FontStyle.Bold),
                    .Cursor = Cursors.Hand
                }

            For Each row In eventsDT.Rows
                Dim eventdate As DateTime = row("date")
                Dim description As String = row("description")
                Dim budget As Decimal = row("budget")
                Dim code As String = row("code")

                If eventdate.Day = i And eventdate.Month = dtePickerDate.Value.Month Then

                    Dim rand As New Random()
                    Dim randomIndex As Integer = rand.Next(0, Colors.Length)
                    Dim rndColor As Color = Colors(randomIndex)

                    Dim descriptionLabel As New Guna2GradientButton With {
                        .Text = description,
                        .Animated = True,
                        .Dock = DockStyle.Top,
                        .TextAlign = HorizontalAlignment.Left,
                        .ForeColor = Color.Black,
                        .FillColor = rndColor,
                        .FillColor2 = Color.Silver,
                        .BackColor = Color.Transparent,
                        .BorderRadius = 8,
                        .Height = 25,
                        .Font = New Font("Comic Sans MS", 9),
                        .Cursor = Cursors.Hand
                    }

                    AddHandler descriptionLabel.MouseHover, Sub(sender As Object, e As EventArgs)
                                                                If budget = 0 Then
                                                                    design.ToolTip(sender, e, "", $" You have {description} scheduled for the {code}'s.")
                                                                Else
                                                                    design.ToolTip(sender, e, "", $"Budgeted amount ${budget}.")
                                                                End If

                                                            End Sub

                    AddHandler descriptionLabel.Click, Sub(sender As Object, e As EventArgs)

                                                           Dim CustomMessageBox As New Guna2MessageDialog With {
                                                                       .Text = "Are you sure you want to remove this event from the calendar?",
                                                                       .Parent = Me,
                                                                       .Buttons = MessageDialogButtons.YesNo,
                                                                       .Style = MessageDialogStyle.Dark,
                                                                       .Icon = MessageDialogIcon.Warning,
                                                                       .Caption = "Remove Event"
                                                                   }

                                                           Dim result As DialogResult = CustomMessageBox.Show
                                                           If result = DialogResult.Yes Then
                                                               DeleteStatement.DeleteEvent(description, budget, eventdate, _frm.lblConnectedUser.Text, _conn)
                                                               UICreations()
                                                           End If
                                                       End Sub

                    datePanelItem.Controls.Add(descriptionLabel)

                End If
            Next

            datePanelItem.Controls.Add(DateLabel)
            pnlFlowDays.Controls.Add(datePanelItem)
        Next

    End Sub
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnAddEvent.MouseHover
        Select Case sender.name

            Case "btnAddEvent"
                design.ToolTip(sender, e, "New Event", "Add a new event to the calendar.")

        End Select
    End Sub
    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click

        Select Case sender.name
            Case "btnAddEvent"
                Dim frm As New FrmSplashScreen(_darkmode, Me, _frm.lblConnectedUser.Text, _conn)
                frm.ShowDialog()

        End Select
    End Sub
    Private Sub dtePickerDate_CloseUp(sender As Object, e As EventArgs) Handles dtePickerDate.CloseUp
        UICreations()
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

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            pnlTopBar
        }
        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblHeading
        }
        Return labels
    End Function
    Private Function DKMFormButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
        }
        Return pagebuttons
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox) From {
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox) From {
        }
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox) From {
        }
        Return placeholder
    End Function

    Private Sub FrmEventsPlanner_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        _frm.notificationUpdate()
    End Sub
End Class