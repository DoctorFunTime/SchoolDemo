Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Guna.UI2.WinForms
Imports System.IO
Imports System.Windows.Forms

Public Class Homepage

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'add items to dictionary

    End Sub
    Private buttonList As New Collection
    Dim toolTip As New Design()
    Dim selectStatement As New SelectStats()
    Private recentItems As New List(Of String)
    Private design As New Design
    Private myRecentsDictionary As New Dictionary(Of Integer, MyCustomObject)()
    Private CurrentKey As Integer = 0
    Private KeyOrder As New List(Of Integer)

    'form load
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView.DataSource = selectStatement.GetFeesStatement()

        'load recents
        LoadRecentItems()

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
        AddToButtonCollection()

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

    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click, btnAboutUs.Click, btnHome.Click

        'Remove the side button styling 
        AddToButtonCollection()

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
    Private Sub BtnFlipOptionsPage_Click(sender As Object, e As EventArgs) Handles btnFlipPageLeft.Click, btnFlipPageRight.Click

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
    Private Sub BtnOnHover_MouseHover(sender As Object, e As EventArgs) Handles btnNotifications.MouseHover, btnAboutUs.MouseHover, btnHome.MouseHover


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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)


        Dim popConfirm As New NotificationBubble

        If popConfirm.IsHidden() Then
            MessageBox.Show("Its not showing")
        Else
            MessageBox.Show("Showing")
        End If

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