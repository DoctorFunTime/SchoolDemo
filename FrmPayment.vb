Public Class FrmPayment
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtePickerDate.Value = DateTime.Today

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click, btnClose.Click, btnClear.Click
        Select Case sender.name
            Case "btnClose"
                Close()
            Case "btnClear"
            Case "btnConfirm"

        End Select
    End Sub

End Class