Imports System.ComponentModel
Imports System.IO
Imports bubble
Imports ColourSchemes
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports UpdateEncapsulation
Imports SQLUpdateStatements

Public Class Homepage
    Private buttonList As New Collection
    Private design As New Design()

    Private selectStatement As New SelectStats()
    Private recentItems As New List(Of String)
    Private myRecentsDictionary As New Dictionary(Of Integer, MyCustomObject)()
    Private CurrentKey As Integer = 0
    Private KeyOrder As New List(Of Integer)
    Private pnlUnderline As New Guna2GradientPanel
    Private WithEvents studentCountTimer As Windows.Forms.Timer
    Private WithEvents FacultyCountTimer As Windows.Forms.Timer
    Private UserSettings As DataTable
    Public _darkMode As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'add items to dictionary
        Dim darkMode As New Themes
        lblStudentCount.Text = String.Empty
        lblFacultyCount.Text = String.Empty

        UserSettings = selectStatement.GetUserSettings()

        For Each row In UserSettings.Rows
            _darkMode = row("us_dark_mode")
        Next

        design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMEmptyButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    'form load
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load recents
        LoadRecentItems()

        'Get todays rate
        Dim effRate As DataTable = selectStatement.GetDaysRate(Date.Today)
        For Each row In effRate.Rows
            Dim baseRate As Decimal = row("exchange_rate")
            Dim effectiveRate As Decimal = 1 / baseRate
            btnEffectiveRate.Text = $"${FormatNumber(effectiveRate, 1).ToString}"
        Next

        'get active term
        Dim activeTerm As DataTable = selectStatement.GetTerm()
        For Each row In activeTerm.Rows
            Dim term As String = row("at_term").ToString
            btnTerm.Text = term
        Next

        DKMsettings()
        pnlUnderline.BackColor = Me.BackColor
        LoadCountTimers()

    End Sub
    'Form closing
    Private Sub Homepage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Update userSettings
        UserSettingsUpdates()
    End Sub
    'Counters reloads 
    Private Sub LoadCountTimers()

        'student Count animation
        Dim studentCount As Integer = selectStatement.GetNamesFromTable().Rows.Count
        Dim SCcount As Integer = 0

        studentCountTimer = New Windows.Forms.Timer

        If studentCount < 50 Then
            studentCountTimer.Interval = 30
        ElseIf studentCount < 150 And studentCount > 50 Then
            studentCountTimer.Interval = 15
        ElseIf studentCount > 150 Then
            SCcount = studentCount - 100
            studentCountTimer.Interval = 1
        End If

        studentCountTimer.Start()

        AddHandler studentCountTimer.Tick, Sub(sender As Object, e As EventArgs)
                                               If SCcount = studentCount Then
                                                   studentCountTimer.Stop()
                                               Else
                                                   SCcount += 1
                                                   lblStudentCount.Text = SCcount.ToString
                                               End If
                                           End Sub

        Dim FacultyCount As Integer = selectStatement.GetFacultyFromTable().Rows.Count
        Dim FCcount As Integer = 0

        FacultyCountTimer = New Windows.Forms.Timer

        If FacultyCount < 50 Then
            FacultyCountTimer.Interval = 30
        ElseIf FacultyCount < 150 And FacultyCount > 50 Then
            FacultyCountTimer.Interval = 15
        ElseIf FacultyCount > 150 Then
            FCcount = FacultyCount - 100
            FacultyCountTimer.Interval = 1
        End If

        FacultyCountTimer.Start()

        AddHandler FacultyCountTimer.Tick, Sub(sender As Object, e As EventArgs)
                                               If FCcount = FacultyCount Then
                                                   FacultyCountTimer.Stop()
                                               Else
                                                   FCcount += 1
                                                   lblFacultyCount.Text = FCcount.ToString
                                               End If
                                           End Sub

    End Sub
    'Button Click Events
    Private Sub SideBarButtons_Click(sender As Object, e As EventArgs) Handles btnReports.Click, btnExams.Click, btnControlPanel.Click, btnBanking.Click, btnAdmissions.Click

        'Add buttons to collection 
        AddToButtonCollection()

        'Remove styling on all buttons
        For Each item In buttonList
            Dim btnStyleRemove As New Design()
            btnStyleRemove.unPressedButton(item, e, _darkMode)
        Next item

        'Apply a style on clicked button
        Dim btnStyle As New Design()
        btnStyle.PressedButton(sender, e, Me, pnlUnderline, _darkMode)

        'Close currently opened form
        For Each control In pnlDockParent.Controls
            If TypeOf control Is Form Then
                DirectCast(control, Form).Close()
            End If
        Next

        Select Case sender.name

            Case "btnAdmissions"
                Dim frm As New FrmAdmission(_darkMode)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnReports"
                Dim frm As New FrmReports(_darkMode)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnExams"
                Dim frm As New FrmExaminations(_darkMode)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnBanking"
                Dim frm As New FrmBanking(_darkMode)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnControlPanel"
                design.messagboxError("Restricted Access", "Only as admin can access the control panel.", Me)

        End Select

    End Sub
    Private Sub BtnMinAndClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnMinimize.Click
        If sender.name = "btnMinimize" Then
            WindowState = FormWindowState.Minimized
        ElseIf sender.name = "btnClose" Then
            Close()
        End If
    End Sub
    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click, btnAboutUs.Click, btnHome.Click, btnConnectivity.Click, btnSignOut.Click

        'Remove the side button styling 
        AddToButtonCollection()

        For Each item In buttonList
            Dim btnStyleRemove As New Design()
            btnStyleRemove.unPressedButton(item, e, _darkMode)
        Next item

        'remove side border
        pnlUnderline.BackColor = Me.BackColor

        'close any docked forms 
        For Each control In pnlDockParent.Controls
            If TypeOf control Is Form Then
                DirectCast(control, Form).Close()
            End If
        Next

        Select Case sender.name

            Case "btnHome"

                LoadCountTimers()

                For Each control In pnlDockParent.Controls
                    If TypeOf control Is Form Then
                        DirectCast(control, Form).Close()
                    End If
                Next

            Case "btnNotifications"
                Dim popUpBubble As New NotificationBubble
                popUpBubble.ShowNotification("View.", "Proposal", "The primary objective of this project is to enhance student engagement.", Me)

            Case "btnAboutUs"
            Case "btnConnectivity"
            Case "btnSignOut"

        End Select


    End Sub
    'Button hover events
    Private Sub BtnOnHover_MouseHover(sender As Object, e As EventArgs) Handles btnNotifications.MouseHover, btnAboutUs.MouseHover, btnHome.MouseHover, btnConnectivity.MouseHover, btnSignOut.MouseHover


        Select Case sender.name

            Case "btnHome"
                design.ToolTip(sender, e, "Home", "Go to the homepage.")

            Case "btnNotifications"
                design.ToolTip(sender, e, "Notifications", "You have 0 pending notifications.")

            Case "btnAboutUs"
                design.ToolTip(sender, e, "Developers", "More about Us.")

            Case "btnConnectivity"
                If sender.ShadowDecoration.Color = Color.Transparent Then
                    design.ToolTip(sender, e, "Online", "You are connected.")
                ElseIf sender.ShadowDecoration.Color = Color.PowderBlue Then
                    design.ToolTip(sender, e, "Offline", "You are not connected.")
                End If

            Case "btnSignOut"
                design.ToolTip(sender, e, "Account", "Sign out of this account.")

        End Select
    End Sub
    'Add side button list to collection
    Public Sub AddToButtonCollection()
        'Empty Collection
        buttonList.Clear()

        'Add new items to the collection
        buttonList.Add(btnAdmissions)
        buttonList.Add(btnReports)
        buttonList.Add(btnExams)
        buttonList.Add(btnBanking)
        buttonList.Add(btnControlPanel)

    End Sub
    Private Sub BtnCloseDatabase_Click(sender As Object, e As EventArgs) Handles btnCloseDatabase.Click

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
    'Methods to add items to dictionary 
    Public Sub AddItemToDictionary(name As String, description As String)

        Dim newItem As New MyCustomObject(name, description)

        CurrentKey = GetNextAvailableKey()
        myRecentsDictionary.Add(CurrentKey, newItem)
        KeyOrder.Add(CurrentKey)

    End Sub
    Private Sub DispayItem()

        For Each key In KeyOrder
            Dim item = myRecentsDictionary(key)
            MessageBox.Show($"Key : {key}, Name : {item.Name}, Value : {item.Description}")
        Next

    End Sub
    Private Function GetNextAvailableKey() As Integer
        'Check if dictionary is empty
        If myRecentsDictionary.Count = 0 Then
            Return 1
        End If

        'get the highest key in the dictionary 
        Return myRecentsDictionary.Keys.Max() + 1
    End Function
    Public Function LoadRecentItems() As Dictionary(Of Integer, MyCustomObject)

        'Get the app data path
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        'Definining the Application path
        Dim appFolderPath As String = Path.Combine(appDataPath, "SchoolDemo")

        'Dim the path for the recent items file
        Dim recentsFilePath As String = Path.Combine(appFolderPath, "recentItems.txt")

        If File.Exists(recentsFilePath) Then
            Using reader As New StreamReader(recentsFilePath)
                While Not reader.EndOfStream

                    Dim Line As String = reader.ReadLine()
                    Dim parts() As String = Line.Split(","c)
                    If parts.Length = 3 Then

                        Dim Key As Integer
                        Dim name As String = parts(1).Trim
                        Dim Description As String = parts(2).Trim

                        If Integer.TryParse(parts(0).Trim(), Key) Then
                            AddItemToDictionary(Key, name, Description)
                        End If

                    End If

                End While
            End Using
        End If

        Return myRecentsDictionary

    End Function
    Public Sub SaveRecentItems()

        'Get the app data path
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        'Definining the Application path
        Dim appFolderPath As String = Path.Combine(appDataPath, "SchoolDemo")

        'Dim the path for the recent items file
        Dim recentsFilePath As String = Path.Combine(appFolderPath, "recentItems.txt")

        'create directory if it doesnt exist
        If Not Directory.Exists(appFolderPath) Then
            Directory.CreateDirectory(appFolderPath)
        End If

        'write the recent items to the file
        Using writer As New StreamWriter(recentsFilePath)
            For Each key In KeyOrder
                Dim item = myRecentsDictionary(key)
                writer.WriteLine($"{key}, {item.Name}, {item.Description}")
            Next
        End Using
    End Sub
    Public Sub AddItemToDictionary(Key As Integer, name As String, description As String)

        Dim newItem As New MyCustomObject(name, description)
        myRecentsDictionary.Add(Key, newItem)
        KeyOrder.Add(Key)

    End Sub
    'Quick access buttons
    Private Sub QuickAccess_Click(sender As Object, e As EventArgs) Handles btnStudentDetails.Click, btnFeesStatement.Click, btnFeesPayments.Click, btnEnroll.Click, btnCashbook.Click
        Select Case sender.name
            Case "btnStudentDetails"
                Dim frm As New FrmReports(_darkMode)
                frm.btnStudentDetailsReport.PerformClick()

            Case "btnFeesStatement"
                Dim frm As New FrmBanking(_darkMode)
                frm.btnFeesStatements.PerformClick()

            Case "btnFeesPayments"
                Dim frm As New FrmBanking(_darkMode)
                frm.btnSchoolFees.PerformClick()

            Case "btnEnroll"
                Dim frm As New FrmAdmission(_darkMode)
                frm.btnEnrollment.PerformClick()

            Case "btnCashbook"
                Dim frm As New FrmBanking(_darkMode)
                frm.btnSchoolCashbook.PerformClick()

        End Select

    End Sub
    Private Sub QuickAccess_MouseHover(sender As Object, e As EventArgs) Handles btnStudentDetails.MouseHover, btnFeesStatement.MouseHover, btnFeesPayments.MouseHover, btnEnroll.MouseHover, btnCashbook.MouseHover
        Select Case sender.name
            Case "btnStudentDetails"
                design.ToolTip(sender, e, "Student Details", "View student's records.")

            Case "btnFeesStatement"
                design.ToolTip(sender, e, "Fees Statement", "View a selected student's fees statement.")

            Case "btnFeesPayments"
                design.ToolTip(sender, e, "School Fees Payments", "Process a student's school fees.")

            Case "btnEnroll"
                design.ToolTip(sender, e, "Enrollment", "Enroll a new student.")

            Case "btnCashbook"
                design.ToolTip(sender, e, "Cashbook", "View the schools transactions and cah position.")

        End Select

    End Sub
    Private Sub RecommendedSettings_Click(sender As Object, e As EventArgs) Handles btnUpdates.Click, btnRunDignostics.Click, btnDarkMode.Click, btnBackUpData.Click
        Select Case sender.name

            Case "btnDarkMode"

                If _darkMode Then
                    _darkMode = False
                    design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMEmptyButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
                    pnlUnderline.BackColor = Me.BackColor
                    btnDarkMode.Text = "Dark Mode"
                Else
                    _darkMode = True
                    design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMEmptyButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
                    pnlUnderline.BackColor = Me.BackColor
                    btnDarkMode.Text = "Light Mode"
                End If

            Case "btnUpdates"
            Case "btnRunDignostics"
            Case "btnBackUpData"
        End Select
    End Sub
    Private Function DKMsideButtons() As List(Of Guna2GradientButton)

        Dim sidebarButtons As New List(Of Guna2GradientButton) From {
            btnAdmissions,
            btnBanking,
            btnExams,
            btnReports,
            btnControlPanel,
            btnCloseDatabase
        }

        Return sidebarButtons
    End Function
    Private Function DKMparentButtons() As List(Of Guna2GradientButton)

        Dim pagebuttons As New List(Of Guna2GradientButton) From {
            btnStudentDetails,
            btnFeesStatement,
            btnFeesPayments,
            btnEnroll,
            btnCashbook,
            btnUpdates,
            btnRunDignostics,
            btnDarkMode,
            btnBackUpData,
            btnAdjustTerm,
            btnAdjRate,
            btnEffectiveRate,
            btnTerm,
            btnChangeUsername,
            btnChangePassword,
            btnAccountSettings
        }

        Return pagebuttons
    End Function
    Private Function DKMpanels() As List(Of Guna2GradientPanel)

        Dim topPanels As New List(Of Guna2GradientPanel) From {
            pnlDockParent,
            pnlTopControls,
            pnlQuickAccess,
            pnlConnectivity,
            pnlSchoolTerm,
            pnlUsersInner,
            pnlRecommendedSettings,
            PnlStats
        }

        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblTodaysRate,
            lblTerm,
            lblStudents,
            lblStudentCount,
            lblRecommendedSettins,
            lblQuickAccess,
            lblFacultyCount,
            lblFaculty,
            lblConnectedUser,
            lblAccounts
        }

        Return labels
    End Function
    Private Function DKMEmptyButtons() As List(Of Guna2GradientButton)

        Dim placeholder As New List(Of Guna2GradientButton)
        Return placeholder
    End Function
    Private Function DKMEmptyText() As List(Of Guna2TextBox)

        Dim placeholder As New List(Of Guna2TextBox)
        Return placeholder
    End Function
    Private Function DKMEmptyCombo() As List(Of Guna2ComboBox)

        Dim placeholder As New List(Of Guna2ComboBox)
        Return placeholder
    End Function
    Private Function DKMEmptyCheck() As List(Of Guna2CheckBox)

        Dim placeholder As New List(Of Guna2CheckBox)
        Return placeholder
    End Function
    Private Sub btnAdjRate_Click(sender As Object, e As EventArgs) Handles btnAdjustTerm.Click, btnAdjRate.Click
        Select Case sender.name
            Case "btnAdjustTerm"
            Case "btnAdjRate"
        End Select
    End Sub
    Private Sub DKMsettings()
        If _darkMode Then
            btnDarkMode.Text = "Light Mode"
        Else

            btnDarkMode.Text = "Dark Mode"
        End If
    End Sub
    Private Sub UserSettingsUpdates()

        Dim UserSetUpdates As New List(Of UserSettings)
        Dim newUpdate As New UserSettings(1, _darkMode)
        UserSetUpdates.Add(newUpdate)

        UpdateStatements.UpdateUserSettings(UserSetUpdates)

    End Sub

End Class
Public Class MyCustomObject
    Public Property Name As String
    Public Property Description As String

    Public Sub New(name As String, description As String)
        Me.Name = name
        Me.Description = description
    End Sub

End Class