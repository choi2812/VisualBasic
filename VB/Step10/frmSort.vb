Public Class frmSort
    Dim data() As Integer = {54, 76, 35, 80, 23, 5, 66, 87, 32, 45}

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSort_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtOrigion.Text = data(0)
        For i As Integer = 1 To UBound(data)
            txtOrigion.Text = txtOrigion.Text & "," & data(i)
        Next
        Sort(data)
    End Sub
    Private Sub Sort(ByRef data() As Integer)

        For i As Integer = 0 To UBound(data)
            For j As Integer = i To UBound(data)
                If (data(j) < data(i)) Then
                    Swap(data(j), data(i))
                End If
            Next
        Next
        txtSorted.Text = data(0)
        For i As Integer = 1 To UBound(data)
            txtSorted.Text = txtSorted.Text & "," & data(i)
        Next
    End Sub
    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim w As Integer
        w = a
        a = b
        b = w
    End Sub
End Class