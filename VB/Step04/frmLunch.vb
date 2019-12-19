Public Class frmLunch

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub rbtHamberger_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtHamberger.CheckedChanged
        txtMain.Text = "ハンバ-グ"
        picMain.Image = My.Resources.Humberg
        txtSum.Text = 780
    End Sub

    Private Sub rbtSteak_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSteak.CheckedChanged
        txtMain.Text = "ステ-キ"
        picMain.Image = My.Resources.Steak
        txtSum.Text = 1100
    End Sub

    Private Sub rbtChiken_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtChiken.CheckedChanged
        txtMain.Text = "チキンソテ-"
        picMain.Image = My.Resources.Chiken
        txtSum.Text = 850
    End Sub

    Private Sub rbtRice_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtRice.CheckedChanged
        txtRice.Text = "ライス"
        picRice.Image = My.Resources.Rice
    End Sub

    Private Sub rbtBread_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtBread.CheckedChanged
        txtRice.Text = "パン"
        picRice.Image = My.Resources.Bread
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        If rbtHamberger.Checked = True Then
            txtSum.Text = 780
        End If
        If rbtSteak.Checked = True Then
            txtSum.Text = 1100
        End If
        If rbtChiken.Checked = True Then
            txtSum.Text = 850
        End If
        If chkSalad.Checked = True Then
            txtSum.Text = txtSum.Text + 350
        End If
        If chkDrink.Checked = True Then
            txtSum.Text = txtSum.Text + 200

        End If
        If chkCake.Checked = True Then
            txtSum.Text = txtSum.Text + 300
        End If
        If chkDiscount.Checked = True Then
            txtSum.Text = Val(txtSum.Text) * 0.9
        End If
    End Sub

    Private Sub chkSalad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSalad.CheckedChanged

    End Sub

    Private Sub chkDiscount_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDiscount.CheckedChanged

    End Sub

    Private Sub frmLunch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class