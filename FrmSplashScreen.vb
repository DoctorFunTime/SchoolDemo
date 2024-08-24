Public Class FrmSplashScreen
    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 100
            prgBar.Value = i
            'System.Threading.Thread.Sleep(250)
        Next
    End Sub
End Class