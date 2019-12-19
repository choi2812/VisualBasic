Public Class frmCopy

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        txtDest.Text = txtSource.Text
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtDest.Text = ""
        txtSource.Text = ""
    End Sub
End Class
