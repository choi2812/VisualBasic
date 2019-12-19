Public Class frmName

    Private Sub btnName_Click(sender As System.Object, e As System.EventArgs) Handles btnName.Click
        txtName.Text = "崔禎文"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
        txtName.Text = ""
    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class
