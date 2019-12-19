Public Class frmMaxMin
    Dim data() As Integer = {78, 57, 98, 65, 78, 88}
    Private Sub btnMaxMin_Click(sender As System.Object, e As System.EventArgs) Handles btnMaxMin.Click
        txtMax.Text = subMax(data)
        txtMin.Text = subMin(data)
    End Sub
    Private Function subMax(ByRef data() As Integer) As Integer
        Dim max As Integer = data(0)

        For i As Integer = 1 To UBound(data)
            If (data(i) > max) Then
                max = data(i)
            End If
        Next
        Return max
    End Function
    Private Function subMin(ByRef data() As Integer) As Integer
        Dim min As Integer = data(0)

        For Each var As Integer In data
            If (var < min) Then
                min = var
            End If
        Next
        Return min
    End Function

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class