Public Class frmArrey

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        Dim a, b As Integer

        a = Val(txtA.Text)
        b = Val(txtB.Text)
        Swap(a, b)
        txtA.Text = a
        txtB.Text = b
    End Sub
    Private Sub Swap(ByRef pa As Integer, ByRef pb As Integer)
        Dim w As Integer

        w = pa
        pa = pb
        pb = w
    End Sub

    Private Sub frmSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtA.Text = 100
        txtB.Text = 200
        txtArrey.Text = "54, 76, 35, 80, 23, 5, 66, 87, 32, 45"
    End Sub

    Private Sub btnSum_Click(sender As System.Object, e As System.EventArgs) Handles btnSum.Click
        Dim data() As Integer = {54, 76, 35, 80, 23, 5, 66, 87, 32, 45}
        txtSum.Text = fncSum(data)
    End Sub
    Private Function fncSum(ByRef data() As Integer) As Integer
        Dim total As Integer = 0
        For i As Integer = 0 To UBound(data)
            total += data(i)
        Next
        Return total
    End Function
End Class