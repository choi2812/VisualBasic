Public Class frmculc
    Dim store As Double
    Dim ope As Integer = 0
    Dim clrsw As Integer = 1
    Dim mem As Double
    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "1"
        clrsw = 0
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "2"
        clrsw = 0
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "3"
        clrsw = 0
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "4"
        clrsw = 0
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "5"
        clrsw = 0
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "6"
        clrsw = 0
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "7"
        clrsw = 0
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "8"
        clrsw = 0
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "9"
        clrsw = 0
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "0"
        clrsw = 0
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        If ope <> 0 Then
            store = Caculate(store, Val(txtScreen.Text))
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "÷"
            ope = 1
            clrsw = 1
        Else
            store = Val(txtScreen.Text)
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "÷"
            ope = 1
            clrsw = 1
        End If
        txtScreen.Text = store
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        If ope <> 0 Then
            store = Caculate(store, Val(txtScreen.Text))
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "×"
            ope = 2
            clrsw = 1
        Else
            store = Val(txtScreen.Text)
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "×"
            ope = 2
            clrsw = 1
        End If
        txtScreen.Text = store
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.EventArgs) Handles btnMinus.Click
        If ope <> 0 Then
            store = Caculate(store, Val(txtScreen.Text))
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "-"
            ope = 3
            clrsw = 1
        Else
            store = Val(txtScreen.Text)
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "-"
            ope = 3
            clrsw = 1
        End If
        txtScreen.Text = store
    End Sub

    Private Sub btnPlus_Click(sender As System.Object, e As System.EventArgs) Handles btnPlus.Click
        If ope <> 0 Then
            store = Caculate(store, Val(txtScreen.Text))
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "+"
            ope = 4
            clrsw = 1
        Else
            store = Val(txtScreen.Text)
            txtScreen.Clear()
            txtScreen.Text = txtScreen.Text & "+"
            ope = 4
            clrsw = 1
        End If
        txtScreen.Text = store
    End Sub
    Private Function Caculate(ByVal s As Double, ByVal b As Double) As Double
        Dim result As Double
        If ope = 1 Then
            result = s / b
        End If
        If ope = 2 Then
            result = s * b
        End If
        If ope = 3 Then
            result = s - b
        End If
        If ope = 4 Then
            result = s + b
        End If
        clrsw = 1
        Return result
    End Function

    Private Sub btnequal_Click(sender As System.Object, e As System.EventArgs) Handles btnequal.Click
        store = Caculate(store, Val(txtScreen.Text))
        txtScreen.Text = store
        ope = 0
    End Sub

    Private Sub btnTenn_Click(sender As System.Object, e As System.EventArgs) Handles btnTenn.Click
        If clrsw = 1 Then
            txtScreen.Clear()
        End If
        txtScreen.Text = txtScreen.Text & "."
        clrsw = 0
    End Sub

    Private Sub btnAllClear_Click(sender As System.Object, e As System.EventArgs) Handles btnAllClear.Click
        txtScreen.Clear()
        ope = 0
        clrsw = 1
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtScreen.Clear()
    End Sub

    Private Sub btnMemoIn_Click(sender As System.Object, e As System.EventArgs) Handles btnMemoIn.Click
        mem = mem + Val(txtScreen.Text)
    End Sub

    Private Sub btnMemoOut_Click(sender As System.Object, e As System.EventArgs) Handles btnMemoOut.Click
        mem = mem - Val(txtScreen.Text)
    End Sub

    Private Sub btnMc_Click(sender As System.Object, e As System.EventArgs) Handles btnMc.Click
        mem = 0
    End Sub

    Private Sub btnMr_Click(sender As System.Object, e As System.EventArgs) Handles btnMr.Click
        txtScreen.Text = mem
    End Sub

    Private Sub frmculc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtScreen.Text = 0
    End Sub
End Class
