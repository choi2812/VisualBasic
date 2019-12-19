Public Class frmSample

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
        txtA.Text = 0
        txtB.Text = 0
    End Sub
End Class
