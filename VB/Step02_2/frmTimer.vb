Public Class frmTimer

    Private Sub txtTime_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTime.TextChanged

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        txtRemain.Text = Val(txtTime.Text)
        tmrKitchen.Enabled = True
    End Sub

    Private Sub tmrKitchen_Tick(sender As System.Object, e As System.EventArgs) Handles tmrKitchen.Tick
        txtRemain.Text = Val(txtRemain.Text) - 1
        If Val(txtRemain.Text) <= 0 Then
            tmrKitchen.Enabled = False
            picBurger.Image = My.Resources.Burger_H
            MessageBox.Show("時間になりました", "メセジ-")

        End If

    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
