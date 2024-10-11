Imports bubble
Imports DatabaseSelectStatements
Imports Frond_End_Design
Imports Newtonsoft.Json.Linq
Imports SQLUpdateStatements

Public Class FrmLogin
    Private selectStatement As New SelectStats
    Private design As New Design
    Private connectionString As String
    Private hover As Timer
    Private _userType As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        Dim encryptedConn As String = appSettingsHelper.GetEncryptedConnections()
        connectionString = encryptedConn
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnMinimize.Click
        If sender.name = "btnMinimize" Then
            WindowState = FormWindowState.Minimized
        ElseIf sender.name = "btnClose" Then
            Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim enteredPass As String = txtPassword.Text
            Dim isPasswordValid As Boolean
            Dim isKeyValid As Boolean = False

            Dim dt As DataTable = selectStatement.GetLoginDetails(txtUsername.Text, connectionString)
            For Each row In dt.Rows
                Dim storedPassword As String = row("password_hash")
                isPasswordValid = BCrypt.Net.BCrypt.Verify(enteredPass, storedPassword)
            Next

            Dim keyDT As DataTable = selectStatement.GetActivationKeyExpiryDate(connectionString)
            Dim expRow As DataRow = keyDT.Rows(0)

            Dim expiryDate As DateTime = expRow("date")
            Dim activeYear As Integer = expiryDate.Year
            Dim activeMonth As Integer = expiryDate.Month

            If activeYear = Date.Now.Year And Not activeMonth < Date.Now.Month Then
                isKeyValid = True
            End If

            If isKeyValid Then
                If isPasswordValid Then

                    For Each row In dt.Rows
                        _userType = row("accounttype")
                    Next

                    Dim frm As New Homepage(connectionString, _userType, txtUsername.Text, Me)
                    frm.Show()
                    Me.Hide()
                Else
                    design.messagboxError("Error", "Incorrect credentials entered!", Me)
                End If
            Else
                design.messagboxError("Error", "Activation key is not valid!" & vbCrLf & vbCrLf & "Please activate a new key or contact us for assistance.", Me)
            End If
        Catch ex As Exception
            design.messagboxError("Error", ex.Message.ToString, Me)
        End Try


    End Sub

    Private Sub txtUsername_MouseEnter(sender As Object, e As EventArgs) Handles txtUsername.MouseEnter
        If sender.text = "Username" Then
            sender.text = ""
        End If

    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        If String.IsNullOrEmpty(sender.text) And txtUsername.Focused = False Then
            sender.text = "Username"
        End If
    End Sub

    Private Sub btnActivateKey_Click(sender As Object, e As EventArgs) Handles btnActivateKey.Click

        Try
            Dim currentMonth As Integer = DateTime.Now.Month
            Dim currentYear As Integer = DateTime.Now.Year

            Dim activationKey As String = InputBox("Enter your activation key:", "Activate Key")

            If Not String.IsNullOrEmpty(activationKey) Then

                For currentMonth = currentMonth To 12
                    Dim daysInMonth As Integer = DateTime.DaysInMonth(currentYear, currentMonth)
                    Dim key As String = ActivationKeys.GenerateActivationKey("SecretKeyCliffSchool", New DateTime(currentYear, currentMonth, daysInMonth))
                    If activationKey = key Then
                        design.messagboxInfo("Successful", "Your key was succesfully activated.", Me)
                        UpdateStatements.UpdateActivationKey(1, activationKey, New DateTime(currentYear, currentMonth, daysInMonth), connectionString)
                        Exit Sub
                    End If
                Next

                design.messagboxError("Error", "Invalid key.", Me)

            End If
        Catch ex As Exception
            design.messagboxError("Error", ex.Message.ToString, Me)
        End Try

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If String.IsNullOrEmpty(txtUsername.Text) Then
            txtUsername.Text = "Username"
        End If
    End Sub
End Class

Public Class appSettingsHelper

    Public Shared Function GetEncryptedConnections() As String
        Dim json As String = IO.File.ReadAllText("appsettings.json")
        Dim jsonObj As JObject = JObject.Parse(json)
        Return jsonObj("ConnectionString").ToString()
    End Function

End Class