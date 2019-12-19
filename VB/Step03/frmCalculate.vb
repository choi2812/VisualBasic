Public Class frmCalculate

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles lblSign.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        txtResult.Text = Val(txtFront.Text) / Val(txtAfter.Text)
        lblSign.Text = "/"
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtFront.Text) + Val(txtAfter.Text)
        lblSign.Text = "+"
    End Sub

    Private Sub btnMinuse_Click(sender As System.Object, e As System.EventArgs) Handles btnMinuse.Click
        txtResult.Text = Val(txtFront.Text) - Val(txtAfter.Text)
        lblSign.Text = "-"
    End Sub

    Private Sub btnMota_Click(sender As System.Object, e As System.EventArgs) Handles btnMota.Click
        txtResult.Text = Val(txtFront.Text) * Val(txtAfter.Text)
        lblSign.Text = "*"
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class