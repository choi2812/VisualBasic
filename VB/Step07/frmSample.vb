Public Class frmSample
    Dim sw As Integer
    Dim count As Integer = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOnOff.Click

        If sw = 0 Then
            btnOnOff.Text = "ON"
            sw = 1
        Else
            btnOnOff.Text = "OFF"
            sw = 0
        End If
        count += 1
        txtCount.Text = count

    End Sub

    Private Sub frmSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sw = 0
        btnOnOff.Text = "OFF"
    End Sub
End Class
