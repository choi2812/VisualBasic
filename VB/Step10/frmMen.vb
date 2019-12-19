Public Class frmMen

    Private Sub btnCaculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCaculate.Click
        Dim R As Double
        Dim L As Double
        Dim A As Double
        R = Val(txtRadius.Text)
        enMen(R, L, A)
    End Sub
    Private Sub enMen(ByVal hankei As Double, ByRef ensyu As Double, ByRef menseki As Double)
        ensyu = 2 * Math.PI * hankei
        menseki = Math.PI * hankei * hankei
        txtArea.Text = Format(menseki, "0.00")
        txtLong.Text = Format(ensyu, "0.00")
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class