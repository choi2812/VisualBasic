Public Class frmJoin

    Private Sub btnMerge_Click(sender As System.Object, e As System.EventArgs) Handles btnMerge.Click
        txtFull.Text = txtFamily.Text & txtGiven.Text
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class