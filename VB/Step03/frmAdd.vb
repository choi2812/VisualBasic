Public Class frmAdd

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtAdd.Text) + Val(txtAdded.Text)
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class