Public Class frmKinshu

    Private Sub frmKinshu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub btnTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnTotal.Click
        Dim a As Integer
        a = Val(txtTotal.Text)
        txt10000.Text = a \ 10000
        a = a Mod 10000
        txt5000.Text = a \ 5000
        a = a Mod 5000
        txt1000.Text = a \ 1000
        a = a Mod 1000
        txt500.Text = a \ 500
        a = a Mod 500
        txt100.Text = a \ 100
        a = a Mod 100
        txt50.Text = a \ 50
        a = a Mod 50
        txt10.Text = a \ 10
        a = a Mod 10
        txt5.Text = a \ 5
        a = a Mod 5
        txt1.Text = a

    End Sub
End Class