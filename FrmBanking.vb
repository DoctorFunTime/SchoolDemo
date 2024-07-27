Public Class FrmBanking
    Private Sub btn_MouseHover(sender As Object, e As EventArgs) Handles btnInvoices.MouseHover, btnFeesStatements.MouseHover, btnCashBook.MouseHover
        lblAddtionalInfoBanking.Text = sender.Tag
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnInvoices.Click, btnFeesStatements.Click, btnCashBook.Click

        Select Case sender.name
            Case "btnCashBook"
                If pnlCashbookDrop.Height = 237 Then pnlCashbookDrop.Height = 59 Else pnlCashbookDrop.Height = 237
            Case "btnInvoices"
                If pnlInvoiceDrop.Height = 178 Then pnlInvoiceDrop.Height = 59 Else pnlInvoiceDrop.Height = 178
        End Select
    End Sub

    Private Sub btnDrops_Click(sender As Object, e As EventArgs) Handles btnReceipts.Click, btnExpenses.Click, btnSchoolFees.Click

        Select Case sender.name
            Case "btnReceipts"
                FrmReceipts.ShowDialog()
            Case "btnExpenses"

            Case "btnSchoolFees"
                FrmTuition.ShowDialog()
        End Select
    End Sub

End Class