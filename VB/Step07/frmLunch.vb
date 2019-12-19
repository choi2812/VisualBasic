Public Class frmLunch
    Dim lunch() As Integer = {650, 780, 700, 880, 750, 680}
    Dim n As Integer

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub lbxMenu_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbxMenu.SelectedIndexChanged
        txtMenu.Text = lbxMenu.SelectedItem
        For i As Integer = 0 To 5
            If lbxMenu.SelectedItem = lbxMenu.Items(i) Then
                n = i
            End If
        Next
        txtMoney.Text = lunch(n)
    End Sub
End Class