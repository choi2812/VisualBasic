Public Class chkCar

    Private Sub rbtMan_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMan.CheckedChanged
        txtSex.Text = "男"
    End Sub

    Private Sub rbtFemale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtFemale.CheckedChanged
        txtSex.Text = "女"
    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        If rbtChild.Checked = False And rbtAdult.Checked = False Then
            MessageBox.Show("成人欄を選んでください", "警告!")
        End If
        If chkOwner.Checked = True And txtCarName.Text = "" Then
            MessageBox.Show("車を書いてください", "警告!")
        End If
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub chkOwner_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOwner.CheckedChanged
        If chkOwner.Checked = False Then
            txtCarName.Text = ""
            txtCarName.Enabled = False
        End If
        If chkOwner.Checked = True Then
            txtCarName.Enabled = True
        End If
    End Sub
End Class
