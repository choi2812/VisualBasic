Public Class frmMen

    Private Sub btnCount_Click(sender As System.Object, e As System.EventArgs) Handles btnCount.Click
        Dim r As Double
        r = Val(txtHankei.Text)
        txtEn.Text = Format(enMen(r), "0.00")

        Dim a, b, c As Double
        a = Val(txta.Text)
        b = Val(txtb.Text)
        c = Val(txtc.Text)
        txtSankaku.Text = Format(sankakuMen(a, b, c), "0.00")
    End Sub

    Private Function enMen(ByVal r As Double) As Double
        Dim menseki As Double

        menseki = 3.141592654 * r * r

        Return menseki
    End Function

    Private Function sankakuMen(ByVal a As Double, ByVal b As Double,
                                ByVal c As Double) As Double
        Dim menseki As Double
        Dim z As Double = (a + b + c) / 2
        menseki = Math.Sqrt(z * (z - a) * (z - b) * (z - c))
        Return menseki
    End Function


    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class