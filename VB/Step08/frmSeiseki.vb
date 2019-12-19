Public Class frmSeiseki
    Dim ten() As Integer = {56, 74, 46, 78, 89, 97, 45, 76, 69, 88, 999}
    Private Sub frmSeiseki_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        txtScore.Text = ten(i)

        While ten(i + 1) < 999
            i += 1
            txtScore.Text = txtScore.Text & ", " & ten(i)
        End While

    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub btnAvg_Click(sender As System.Object, e As System.EventArgs) Handles btnAvg.Click
        Dim i As Integer = 0
        Dim sum As Double = 0
        Dim max As Integer = ten(0)
        Dim min As Integer = ten(0)
        While ten(i) < 999
            sum += ten(i)
            If ten(i) > max Then
                max = ten(i)
            End If
            If ten(i) < min Then
                min = ten(i)
            End If
            i += 1
        End While
        txtMax.Text = max
        txtMin.Text = min
        txtAvg.Text = sum / i



    End Sub

    Private Sub btnRank_Click(sender As System.Object, e As System.EventArgs) Handles btnRank.Click
        Dim i As Integer = 0
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0
        Dim d As Integer = 0

        While ten(i) < 999
            Select Case ten(i)
                Case 80 To 100
                    a = a + 1
                Case 70 To 79
                    b = b + 1
                Case 60 To 69
                    c = c + 1
                Case Else
                    d = d + 1

            End Select
            i += 1
        End While
        txtA.Text = a
        txtB.Text = b
        txtC.Text = c
        txtD.Text = d
    End Sub
End Class