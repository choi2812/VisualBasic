Public Class frmImgChange

    Private Sub frmImgChange_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
  
    End Sub

    Private Sub btnRocket_Click(sender As System.Object, e As System.EventArgs) Handles btnRocket.Click
        'ロケットのイメジ'
        picImage.Image = My.Resources.Rocket_s1
        txtName.Text = "ロケットです"
    End Sub

    Private Sub btnExplosion_Click(sender As System.Object, e As System.EventArgs) Handles btnExplosion.Click
        '爆発のイメジ'
        picImage.Image = My.Resources.Explosion_s1
        txtName.Text = "爆発です"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        MessageBox.Show("ご苦労様です", "メ-ジ")
        Me.Close()
    End Sub
End Class
