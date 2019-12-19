Public Class frmWa

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnWa.Click
        Dim n As Integer
        n = Val(txtNumber.Text)
        subWa(n)
    End Sub

    Private Sub subWa(ByVal m As Integer)
        Dim i As Integer = 1
        Dim total As Integer = 0
        While i <= m
            total += i
            i += 1
        End While
        txtTotal.Text = total
        lblTotal.Text = "1～" & i - 1 & "の和"
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class