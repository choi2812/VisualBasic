Public Class Form1

    Private Sub btnKin1_Click(sender As System.Object, e As System.EventArgs) Handles btnKin1.Click
        Dim motokin As Integer

        motokin = Val(txtKingaku1.Text)
        kin2bai1(motokin)
    End Sub
    'サブプロシ-ジャ
    Private Sub kin2bai1(ByVal kin As Integer)
        kin = kin * 2
        txtKingaku1.Text = kin
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub btnKin2_Click(sender As System.Object, e As System.EventArgs) Handles btnKin2.Click
        Dim motokin As Integer

        motokin = Val(txtKingaku2.Text)
        motokin = kin2bai2(motokin)
        txtKingaku2.Text = motokin
    End Sub
    '関数プロシ-ジャ
    Private Function kin2bai2(ByVal kin As Integer) As Integer
        kin = kin * 2
        Return kin
    End Function
End Class
