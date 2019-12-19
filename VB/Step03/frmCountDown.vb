Public Class frmCountDown

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        txtLeftMinute.Text = Val(txtMinute.Text) * 60 + Val(txtSeconds.Text)
        txtLeftMinutes.Text = Val(txtMinute.Text)
        txtLeftSecends.Text = Val(txtSeconds.Text)
        tmrCountDown.Enabled = True
    End Sub

    Private Sub tmrCountDown_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCountDown.Tick
        txtLeftMinute.Text = Val(txtLeftMinute.Text) - 1
        txtLeftMinutes.Text = Val(txtLeftMinute.Text) \ 60
        txtLeftSecends.Text = Val(txtLeftMinute.Text) Mod 60
        If Val(txtLeftMinute.Text) = 0 Then
            tmrCountDown.Enabled = False
            MessageBox.Show("時間になりました", "メセジ")
        End If
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class