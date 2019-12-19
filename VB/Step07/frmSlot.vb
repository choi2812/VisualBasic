Public Class frmSlot

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub frmSlot_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtCoin.Text = 0

    End Sub

    Private Sub tmr1_Tick(sender As System.Object, e As System.EventArgs) Handles tmr1.Tick
        lbl1.Text = Val(lbl1.Text) + 1
        If lbl1.Text = 10 Then
            lbl1.Text = 0
        End If
        If lbl1.Text = 7 Then
            lbl1.ForeColor = Color.Red
        Else
            lbl1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnCheck.Enabled = True
        tmr1.Enabled = True
        tmr2.Enabled = True
        tmr3.Enabled = True
        pic1.Image = My.Resources.Button_Red
        pic2.Image = My.Resources.Button_Red
        pic3.Image = My.Resources.Button_Red
        txtCoin.Text = Val(txtCoin.Text) - 1


    End Sub

    Private Sub tmr2_Tick(sender As System.Object, e As System.EventArgs) Handles tmr2.Tick
        lbl2.Text = Val(lbl2.Text) + 1
        If lbl2.Text = 10 Then
            lbl2.Text = 0
        End If
        If lbl2.Text = 7 Then
            lbl2.ForeColor = Color.Red
        Else
            lbl2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tmr3_Tick(sender As System.Object, e As System.EventArgs) Handles tmr3.Tick
        lbl3.Text = Val(lbl3.Text) + 1
        If lbl3.Text = 10 Then
            lbl3.Text = 0
        End If
        If lbl3.Text = 7 Then
            lbl3.ForeColor = Color.Red
        Else
            lbl3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lbl3_Click(sender As System.Object, e As System.EventArgs) Handles lbl3.Click

    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        If tmr1.Enabled = True And tmr2.Enabled = True And tmr3.Enabled = True Then
            Exit Sub
        End If
        If lbl1.Text = lbl2.Text And lbl2.Text = lbl3.Text Then
            MessageBox.Show("おめてとう!あたりです!", "message")
            txtCoin.Text = Val(txtCoin.Text) + 10
            If lbl1.Text = 7 Then
                MessageBox.Show("おめてとう!大あたりです!", "message")
                txtCoin.Text = Val(txtCoin.Text) + 90
            End If
        Else
            MessageBox.Show("残念!", "message")
            txtCoin.Text = Val(txtCoin.Text) - 1
        End If
        If txtCoin.Text = 0 Then
            btnStart.Enabled = False
        End If

    End Sub

    Private Sub pic3_Click(sender As System.Object, e As System.EventArgs) Handles pic3.Click
        tmr3.Enabled = False
        pic3.Image = My.Resources.Button_Yellow
        If tmr1.Enabled = False And tmr2.Enabled = False And tmr3.Enabled = False Then

            btnCheck.Enabled = True
        End If
    End Sub

    Private Sub pic2_Click(sender As System.Object, e As System.EventArgs) Handles pic2.Click
        tmr2.Enabled = False
        pic2.Image = My.Resources.Button_Yellow
        If tmr1.Enabled = False And tmr2.Enabled = False And tmr3.Enabled = False Then
   
            btnCheck.Enabled = True
        End If
    End Sub

    Private Sub pic1_Click(sender As System.Object, e As System.EventArgs) Handles pic1.Click
        tmr1.Enabled = False
        pic1.Image = My.Resources.Button_Yellow
        If tmr1.Enabled = False And tmr2.Enabled = False And tmr3.Enabled = False Then

            btnCheck.Enabled = True
        End If
    End Sub

    Private Sub rbtNormal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNormal.CheckedChanged
        tmr1.Interval = 200
        tmr2.Interval = 200
        tmr3.Interval = 200
    End Sub

    Private Sub rbtFast_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtFast.CheckedChanged
        tmr1.Interval = 100
        tmr2.Interval = 100
        tmr3.Interval = 100
    End Sub

    Private Sub rbtSlow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSlow.CheckedChanged
        tmr1.Interval = 500
        tmr2.Interval = 500
        tmr3.Interval = 500
    End Sub

    Private Sub txtCoin_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCoin.TextChanged
        If Val(txtCoin.Text) = 0 Then
            btnStart.Enabled = False
        End If
        If Val(txtCoin.Text) > 0 Then
            btnStart.Enabled = True
        End If

    End Sub
End Class