Public Class frmcolor

    Private Sub rbtgreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtgreen.CheckedChanged
        picBack.BackColor = Color.Green
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rbtRed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtRed.CheckedChanged
        picBack.BackColor = Color.Red
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub rbtYellow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtYellow.CheckedChanged
        picBack.BackColor = Color.Yellow
    End Sub
End Class