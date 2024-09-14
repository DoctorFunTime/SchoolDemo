Imports System.ComponentModel
Imports System.IO
Imports bubble
Imports ColourSchemes
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports UpdateEncapsulation
Imports SQLUpdateStatements
Imports MyEncapsulation
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.Sockets
Imports SQLStatements

Public Class Homepage
    Private buttonList As New Collection
    Private design As New Design()
    Private selectStatement As New SelectStats()
    Private recentItems As New List(Of String)
    Public notifications As New List(Of Notifications)
    Private CurrentKey As Integer = 0
    Private KeyOrder As New List(Of Integer)
    Private pnlUnderline As New Guna2GradientPanel
    Private markedRegisters As Integer
    Private allRegisters As Integer
    Private WithEvents studentCountTimer As Windows.Forms.Timer
    Private WithEvents FacultyCountTimer As Windows.Forms.Timer
    Private WithEvents circlePrgBar As Windows.Forms.Timer
    Private WithEvents prgAbsentTimer As Windows.Forms.Timer
    Private WithEvents prgPresntTimer As Windows.Forms.Timer
    Private UserSettings As DataTable
    Public _darkMode As Boolean
    Private _conn As String
    Private _UserType As String
    Private _LogOut As Boolean
    Private _frmLogin As FrmLogin
    Public Sub New(conn As String, userType As String, username As String, loginForm As Form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        lblStudentCount.Text = String.Empty
        lblFacultyCount.Text = String.Empty
        lblConnectedUser.Text = username

        _frmLogin = loginForm
        _UserType = userType
        _LogOut = False
        _conn = conn
        UserSettings = selectStatement.GetUserSettings(_conn)
        If _darkMode Then btnActivateKey.ForeColor = Color.White Else btnActivateKey.ForeColor = Color.DimGray
        For Each row In UserSettings.Rows
            _darkMode = row("us_dark_mode")
        Next

        design.darkMode(Me, _darkMode, DKMsideButtons(), DKMparentButtons(), DKMlabels(), DKMpanels(), DKMEmptyButtons(), DKMEmptyText(), DKMEmptyCombo(), DKMEmptyCheck())
    End Sub
    'form load
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = Date.Today.ToString("dddd dd MMMM yyyy")
        Updates()
        DKMsettings()
        pnlUnderline.BackColor = Me.BackColor

    End Sub
    Public Sub Updates()
        'Get todays rate
        Dim effRate As DataTable = selectStatement.GetDaysRate(Date.Today, _conn)
        For Each row In effRate.Rows
            Dim baseRate As Decimal = row("exchange_rate")
            Dim effectiveRate As Decimal = 1 / baseRate
            btnEffectiveRate.Text = $"${FormatNumber(effectiveRate, 1).ToString}"
        Next

        'get active term
        Dim activeTerm As DataTable = selectStatement.GetTerm(_conn)
        For Each row In activeTerm.Rows
            Dim term As String = row("at_term").ToString
            btnTerm.Text = term
        Next

        LoadCountTimers()
        notificationUpdate()

    End Sub

    Public Sub notificationUpdate()
        'Check registers
        markedRegisters = selectStatement.GetRegisterStateForAllClasses(Date.Today, _conn).Rows.Count
        allRegisters = selectStatement.GetClasses(_conn).Rows.Count - 1

        Dim exists As Boolean = notifications.Any(Function(notif) notif.text = "Complete Registers")

        If Not allRegisters = markedRegisters Then
            If exists Then
                Dim existingNotif As Notifications = notifications.FirstOrDefault(Function(n) n.text = "Complete Registers")
                existingNotif.buttonName = $"{allRegisters - markedRegisters} unmarked registers."
            Else
                notifications.Add(New Notifications(allRegisters - markedRegisters, $"{allRegisters - markedRegisters} unmarked registers.", "Complete Registers"))
                notPaint.Text = notifications.Count
            End If
        End If

        'Get key expiry date
        Dim expDT As DataTable = selectStatement.GetActivationKeyExpiryDate(_conn)
        Dim frow As DataRow = expDT.Rows(0)

        Dim expirydate As DateTime = frow("date")
        lblActivationKey.Text = $"Expires on {expirydate.ToString("dd MMMM yyyy")}"

        Dim expireDaysLeft As Integer = DateDiff(DateInterval.Day, Date.Today, expirydate)
        If expireDaysLeft < 31 Then
            If Not notifications.Any(Function(notif) notif.text = "Activation Key") Then
                notifications.Add(New Notifications(expireDaysLeft, $"{expireDaysLeft} days left before expiry.", "Activation Key"))
                notPaint.Text = notifications.Count
            End If
        End If

        'check events
        Dim eventsDT As DataTable = selectStatement.GetEvents(_conn)
        Dim eventsInTheComingWeek As Integer = 0

        For Each row In eventsDT.Rows
            Dim eventdate As DateTime = row("date")
            Dim eventMonth As Integer = eventdate.Month
            Dim eventYear As Integer = eventdate.Year
            Dim eventDay As Integer = eventdate.Day

            Dim currentMonth As Integer = DateTime.Now.Month
            Dim currentYear As Integer = DateTime.Now.Year
            Dim currentDay As Integer = DateTime.Now.Day

            If eventMonth = currentMonth And eventYear = currentYear Then
                If eventDay >= currentDay And eventDay <= currentDay + 7 Then
                    eventsInTheComingWeek += 1
                End If
            End If
        Next


        If notifications.Any(Function(notif) notif.text = "Incoming Events (Next 7 Days)") Then
            Dim existingNotif As Notifications = notifications.FirstOrDefault(Function(n) n.text = "Incoming Events (Next 7 Days)")
            existingNotif.buttonName = $"{eventsInTheComingWeek} scheduled events."
        Else
            notifications.Add(New Notifications(1, $"{eventsInTheComingWeek} scheduled events.", "Incoming Events (Next 7 Days)"))
            notPaint.Text = notifications.Count
        End If

        'check uninvoiced students
        Dim invoicedDT As DataTable = selectStatement.GetinvoicedStudents(_conn)
        Dim allStudentsDT As DataTable = selectStatement.GetNamesFromTable(_conn)
        Dim allStudents As Integer = allStudentsDT.Rows.Count
        Dim invoicedStudents As Integer = 0

        For Each row In invoicedDT.Rows

            Dim invDate As DateTime = row("date")
            Dim invMonth As Integer = invDate.Month
            Dim invYear As Integer = invDate.Year
            Dim invDay As Integer = invDate.Day

            Dim currentMonth As Integer = DateTime.Now.Month
            Dim currentYear As Integer = DateTime.Now.Year
            Dim currentDay As Integer = DateTime.Now.Day

            If invMonth = currentMonth And invYear = currentYear Then
                invoicedStudents += 1
            End If

        Next

        Dim uninvoicedStudents As Integer = allStudents - invoicedStudents

        If notifications.Any(Function(notif) notif.text = "Students Not Invoiced") Then
            Dim existingNotif As Notifications = notifications.FirstOrDefault(Function(n) n.text = "Students Not Invoiced")
            existingNotif.buttonName = $"{uninvoicedStudents} students for {DateTime.Now.ToString("MMMM")}."
        Else
            notifications.Add(New Notifications(uninvoicedStudents, $"{uninvoicedStudents} students for {DateTime.Now.ToString("MMMM")}.", "Students Not Invoiced"))
            notPaint.Text = notifications.Count
        End If

    End Sub
    'Form closing
    Private Sub Homepage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Update userSettings
        UserSettingsUpdates()

        If _LogOut Then

        Else
            FrmLogin.Close()
        End If

    End Sub
    'Counters reloads 
    Private Sub LoadCountTimers()

        lblAbsentValue.Text = "0 / 0"
        lblPresentValue.Text = "0 / 0"

        'student Count animation
        Dim studentCount As Integer = selectStatement.GetNamesFromTable(_conn).Rows.Count
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

        Dim FacultyCount As Integer = selectStatement.GetFacultyFromTable(_conn).Rows.Count
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


        Dim presentCount As Integer = selectStatement.GetRegisterValue(Date.Today, True, _conn).Rows.Count
        Dim maxValue As Integer = selectStatement.GetNamesFromTable(_conn).Rows.Count

        prgPresent.Maximum = maxValue
        prgAbsent.Maximum = maxValue

        Dim presentValue As Integer = presentCount
        Dim absentValue As Integer

        If presentValue = 0 Then
            absentValue = maxValue
        Else
            absentValue = maxValue - presentValue
        End If

        Dim pcount, acount As Integer

        If presentValue > 150 Then
            pcount = presentValue - 100
        End If

        If absentValue > 150 Then
            acount = absentValue - 100
        End If

        prgPresntTimer = New Windows.Forms.Timer With {
            .Interval = 50
        }
        prgPresntTimer.Start()

        prgAbsentTimer = New Windows.Forms.Timer With {
            .Interval = 50
        }
        prgAbsentTimer.Start()

        AddHandler prgPresntTimer.Tick, Sub(sender As Object, e As EventArgs)
                                            If pcount = presentValue Then
                                                lblPresentValue.Text = $"{pcount} / {maxValue}"
                                                prgPresntTimer.Stop()
                                            Else
                                                prgPresent.Value = pcount
                                                pcount += 1
                                                lblPresentValue.Text = $"{pcount} / {maxValue}"
                                            End If
                                        End Sub

        AddHandler prgAbsentTimer.Tick, Sub(sender As Object, e As EventArgs)
                                            If acount = absentValue Then
                                                lblAbsentValue.Text = $"{acount} / {maxValue}"
                                                prgAbsentTimer.Stop()
                                            Else
                                                prgAbsent.Value = acount
                                                acount += 1
                                                lblAbsentValue.Text = $"{acount} / {maxValue}"
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
                Dim frm As New FrmAdmission(_darkMode, Me, _conn)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnReports"
                Dim frm As New FrmReports(_darkMode, _conn)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnExams"
                Dim frm As New FrmExaminations(_darkMode, Me, _conn)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnBanking"
                Dim frm As New FrmBanking(_darkMode, Me, btnTerm.Text, _conn)
                Dim openForm As New Design()
                openForm.OpenForm(frm, pnlDockParent)

            Case "btnControlPanel"

                If _UserType = "Admin" Then
                    Dim frm As New FrmControlPanel(_darkMode, _conn, Me)
                    Dim openForm As New Design()
                    openForm.OpenForm(frm, pnlDockParent)
                Else
                    design.messagboxError("Restricted Access", "Only an admin account can access the control panel.", Me)
                End If

        End Select

    End Sub
    Private Sub BtnMinAndClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnMinimize.Click
        If sender.name = "btnMinimize" Then
            WindowState = FormWindowState.Minimized
        ElseIf sender.name = "btnClose" Then
            _LogOut = False
            Close()
        End If
    End Sub
    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click, btnAboutUs.Click, btnHome.Click, btnSignOut.Click



        Select Case sender.name

            Case "btnHome"
                'Remove the side button styling 
                AddToButtonCollection()

                For Each item In buttonList
                    Dim btnStyleRemove As New Design()
                    btnStyleRemove.unPressedButton(item, e, _darkMode)
                Next item

                'close any docked forms 
                For Each control In pnlDockParent.Controls
                    If TypeOf control Is Form Then
                        DirectCast(control, Form).Close()
                    End If
                Next

                'remove side border
                pnlUnderline.BackColor = Me.BackColor

                Updates()

                For Each control In pnlDockParent.Controls
                    If TypeOf control Is Form Then
                        DirectCast(control, Form).Close()
                    End If
                Next

            Case "btnNotifications"

                Dim formID As String = "Notifications"
                Dim frm As New FrmSelectClass(formID, _darkMode, Me, _conn) With {
                    .notifications = notifications
                }
                frm.ShowDialog()


            Case "btnAboutUs"

            Case "btnSignOut"

                _LogOut = True
                Me.Close()
                FrmLogin.Show()
                FrmLogin.txtPassword.Text = String.Empty
                FrmLogin.txtUsername.Text = "Username"
        End Select


    End Sub
    'Button hover events
    Private Sub BtnOnHover_MouseHover(sender As Object, e As EventArgs) Handles btnNotifications.MouseHover, btnAboutUs.MouseHover, btnHome.MouseHover, btnSignOut.MouseHover


        Select Case sender.name

            Case "btnHome"
                design.ToolTip(sender, e, "Home", "Go to the homepage.")

            Case "btnNotifications"
                design.ToolTip(sender, e, "Notifications", $"You have {notPaint.Text} pending notifications.")

            Case "btnAboutUs"
                design.ToolTip(sender, e, "Developers", "More about Us.")

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
            _LogOut = False
            Close()
        End If

    End Sub
    'Quick access buttons
    Private Sub QuickAccess_Click(sender As Object, e As EventArgs) Handles btnStudentDetails.Click, btnFeesStatement.Click, btnFeesPayments.Click, btnEnroll.Click, btnCashbook.Click
        Select Case sender.name
            Case "btnStudentDetails"
                Dim frm As New FrmEventsPlanner(_darkMode, Me, _conn)
                frm.ShowDialog()

            Case "btnFeesStatement"
                Dim frm As New FrmSelectClass("Class Register", _darkMode, Me, _conn)
                frm.ShowDialog()

            Case "btnFeesPayments"
                Dim formID As String = "FrmTuition"
                Dim selectStudent As New FrmSelectStudent(formID, _darkMode, Me, _conn)
                selectStudent.ShowDialog()

            Case "btnEnroll"
                Dim frm As New FrmEnrollment(_darkMode, Me, _conn)
                frm.ShowDialog()

            Case "btnCashbook"
                Dim dt As DataTable = selectStatement.GetCashBook(_conn)

                Dim reportForm As New FrmStudentReport(dt, "Cashbook", "Cashbook", _darkMode)
                reportForm.ShowDialog()

        End Select

    End Sub
    Private Sub QuickAccess_MouseHover(sender As Object, e As EventArgs) Handles btnStudentDetails.MouseHover, btnFeesStatement.MouseHover, btnFeesPayments.MouseHover, btnEnroll.MouseHover, btnCashbook.MouseHover
        Select Case sender.name
            Case "btnStudentDetails"
                design.ToolTip(sender, e, "Events", "View incoming events.")

            Case "btnFeesStatement"
                design.ToolTip(sender, e, "Attendance Register", "Complete the days register.")

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

                Update()

            Case "btnUpdates"
                design.messagboxInfo("System Updates", "There are no available updates.", Me)

            Case "btnRunDignostics"

                If lblConnectedUser.Text = "DrFunTimes" Then
                    Dim documentsPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Four Tear Developers")
                    Dim backUpPath As String = IO.Path.Combine(documentsPath, "school_app_backup.dump")

                    If Not Directory.Exists(documentsPath) Then
                        Directory.CreateDirectory(documentsPath)
                    End If

                    Dim process As New Process()
                    process.StartInfo.FileName = "C:\Program Files\PostgreSQL\16\bin\pg_restore.exe"
                    process.StartInfo.Arguments = $"-h localhost -U postgres -d SchoolDemo -v ""{backUpPath}"""
                    process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", "Handwash")
                    process.StartInfo.RedirectStandardInput = True
                    process.StartInfo.RedirectStandardOutput = True
                    process.StartInfo.RedirectStandardError = True
                    process.StartInfo.UseShellExecute = False
                    process.StartInfo.CreateNoWindow = True

                    process.Start()

                    process.WaitForExit()

                    Dim output As String = process.StandardOutput.ReadToEnd()
                    Dim errorOutput As String = process.StandardError.ReadToEnd()

                    IO.File.WriteAllText(IO.Path.Combine(Application.StartupPath, "backup_log.txt"), output)

                    If errorOutput.Contains("ERROR") Or errorOutput.Contains("FATAL") Then
                        design.messagboxError("Error", errorOutput, Me)
                    Else
                        design.messagboxInfo("Successful", "Data was restored sucessfully.", Me)
                    End If
                Else
                    design.messagboxWarning("Warning!", "Access to this option is restricted", Me)
                End If

            Case "btnBackUpData"

                Dim documentsPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Four Tear Developers")

                If Not Directory.Exists(documentsPath) Then
                    Directory.CreateDirectory(documentsPath)
                End If

                Dim backUpPath As String = IO.Path.Combine(documentsPath, "school_app_backup.dump")

                Dim process As New Process()
                process.StartInfo.FileName = "C:\Program Files\PostgreSQL\16\bin\pg_dump.exe"
                process.StartInfo.Arguments = $"-h localhost -U postgres -F c -b -v -f ""{backUpPath}"" SchoolDemo"
                process.StartInfo.EnvironmentVariables.Add("PGPASSWORD", "Handwash")
                process.StartInfo.RedirectStandardInput = True
                process.StartInfo.RedirectStandardOutput = True
                process.StartInfo.RedirectStandardError = True
                process.StartInfo.UseShellExecute = False
                process.StartInfo.CreateNoWindow = True

                process.Start()

                process.WaitForExit()

                Dim output As String = process.StandardOutput.ReadToEnd()
                Dim errorOutput As String = process.StandardError.ReadToEnd()

                IO.File.WriteAllText(IO.Path.Combine(Application.StartupPath, "backup_log.txt"), output)

                If errorOutput.Contains("ERROR") Or errorOutput.Contains("FATAL") Then
                    design.messagboxError("Error", errorOutput, Me)
                Else
                    design.messagboxInfo("Successful", "Data was backed up sucessfully.", Me)
                End If

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
            btnTerm
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
            pnlRecommendedSettings,
            PnlStats,
            pnlAttendaceRecords
        }

        Return topPanels
    End Function
    Private Function DKMlabels() As List(Of Guna2HtmlLabel)

        Dim labels As New List(Of Guna2HtmlLabel) From {
            lblTodaysRate,
            lblSchoolTerm,
            lblStudents,
            lblStudentCount,
            lblRecommendedSettins,
            lblQuickAccess,
            lblFacultyCount,
            lblFaculty,
            lblConnectedUser,
            lblActivationKey,
            lblAbesent,
            lblPresent,
            lblDate,
            lblPresentValue,
            lblAbsentValue,
            lblStudentAvailable
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
                Dim message As String = "Term"
                Dim frm As New FrmAdjustments(message, _darkMode, _conn, Me, 0)
                frm.Show()

            Case "btnAdjRate"

                Dim message As String = "Rates"
                Dim frm As New FrmAdjustments(message, _darkMode, _conn, Me, 0)
                frm.Show()

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

        UpdateStatements.UpdateUserSettings(lblConnectedUser.Text, UserSetUpdates, _conn)

    End Sub

    Private Sub btnActivateKey_Click(sender As Object, e As EventArgs) Handles btnActivateKey.Click

        Dim currentMonth As Integer = DateTime.Now.Month
        Dim currentYear As Integer = DateTime.Now.Year

        Dim activationKey As String = InputBox("Enter your activation key:", "Activate Key")

        If Not String.IsNullOrEmpty(activationKey) Then

            For currentMonth = currentMonth To 12
                Dim daysInMonth As Integer = DateTime.DaysInMonth(currentYear, currentMonth)
                Dim key As String = ActivationKeys.GenerateActivationKey("SecretKeyCliffSchool", New DateTime(currentYear, currentMonth, daysInMonth))
                If activationKey = key Then
                    design.messagboxInfo("Successful", "Your key was succesfully activated.", Me)
                    lblActivationKey.Text = $"Expires on {New DateTime(currentYear, currentMonth, daysInMonth).ToString("dd MMMM yyyy")}"
                    UpdateStatements.UpdateActivationKey(1, activationKey, New DateTime(currentYear, currentMonth, daysInMonth), _conn)
                    notificationUpdate()
                    Exit Sub
                End If
            Next

            design.messagboxError("Error", "Invalid key.", Me)

        End If

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        Try
            Dim currentMonth As Integer = 9
            Dim currentYear As Integer = DateTime.Now.Year
            Dim daysInMonth As Integer = DateTime.DaysInMonth(currentYear, currentMonth)
            Dim evaluationDate As New DateTime(currentYear, currentMonth, daysInMonth)

            Dim expiryDate As New DateTime(currentYear, currentMonth, daysInMonth)
            Dim key As String = ActivationKeys.GenerateActivationKey("SecretKeyCliffSchool", evaluationDate)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class
Public Class ActivationKeys

    Public Shared Function GenerateActivationKey(secret As String, activateDate As DateTime) As String

        Dim currentMonthYear As String = activateDate.ToString("yyyyMM")
        Dim inputString As String = secret & currentMonthYear
        Using sha256 As SHA256 = SHA256.Create
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputString))
            Return BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16)
        End Using
    End Function
    Public Shared Function VerifyActivationKey(providedKey As String, secret As String, activateDate As DateTime) As Boolean

        Dim currentMonthYear As String = activateDate.ToString("yyyyMM")
        Dim inputString As String = secret & currentMonthYear
        Using sha256 As SHA256 = SHA256.Create
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputString))
            Dim expectedKey As String = BitConverter.ToString(hashBytes).Replace("-", "").Substring(0, 16)
            Return providedKey.Equals(expectedKey, StringComparison.OrdinalIgnoreCase)
        End Using
    End Function

End Class