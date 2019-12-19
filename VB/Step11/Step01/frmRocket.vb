Public Class frmRocket

    Private Sub tmrRocket_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRocket.Tick
        picRocket.Top -= 5

        ' 上限に着いたら爆発
        If picRocket.Top <= 0 Then
            tmrRocket.Enabled = False
            picRocket.Image = My.Resources.Rocket_s11
            tmrRocket2.Enabled = True
        End If
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        tmrRocket.Enabled = True
    End Sub

    Private Sub frmRocket_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tmrRocket.Enabled = False
    End Sub

    Private Sub tmrRocket2_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRocket2.Tick
        picRocket.Top += 5

        If picRocket.Top >= 465 Then
            tmrRocket2.Enabled = False
            picRocket.Image = My.Resources.Explosion_s1
        End If
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        tmrRocket.Enabled = False
        tmrRocket2.Enabled = False
        picRocket.Image = My.Resources.Rocket_s1
        picRocket.Top = 465
    End Sub
End Class