Imports Functionality
Imports Alerts
Public Class FrmOptions
    Private systemFunctionality As New SystemFunctions()
    Private popUp As New Notifications()

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnDarkMode.Click, btnUpdates.Click, btnSignOut.Click, btnRunDiagnostics.Click, btnRemove.Click, btnPassword.Click, btnNewUser.Click, btnBackUp.Click
        Select Case sender.name
            Case "btnRunDiagnostics"
                If pnlRunDiagnosticsDrop.Height = 233 Then pnlRunDiagnosticsDrop.Height = 55 Else pnlRunDiagnosticsDrop.Height = 233
        End Select
    End Sub

    Private Sub btnConnectivity_Click(sender As Object, e As EventArgs) Handles btnConnectivity.Click
        If systemFunctionality.IsConnectedToInternet() Then
            popUp.notificationBubble("Connection Succeeded!", "You are connected to the internet! ")
        Else
            popUp.notificationBubble("Connection failed!", "You are not connected to the internet! ")
        End If
    End Sub

End Class