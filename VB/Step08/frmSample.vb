Public Class frmSample

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDay_Click(sender As System.Object, e As System.EventArgs) Handles btnDay.Click
        Dim month As Integer = 0
        Dim day As Integer
        month = Val(txtMonth.Text)

        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                day = 31
            Case 4, 6, 9, 11
                day = 30
            Case 2
                day = 28
            Case Else
                MessageBox.Show("月が不正です""message")
        End Select
        txtDays.Text = day & "日"
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnWhile_Click(sender As System.Object, e As System.EventArgs) Handles btnWhile.Click
        Dim intFrom As Integer
        Dim intto As Integer
        Dim intwa As Integer = 0

        intFrom = Val(txtFrom.Text)
        intto = Val(txtTo.Text)

        While intFrom <= intto
            intwa += intFrom
            intFrom += 1
        End While
        txtWa.Text = intwa
    End Sub

    Private Sub btnDoWhile_Click(sender As System.Object, e As System.EventArgs) Handles btnDoWhile.Click
        Dim intFrom As Integer
        Dim intto As Integer
        Dim intwa As Integer = 0

        intFrom = Val(txtFrom.Text)
        intto = Val(txtTo.Text)

        Do While intFrom <= intto
            intwa += intFrom
            intFrom += 1
        Loop
        txtWa.Text = intwa
    End Sub

    Private Sub btnDoUntil_Click(sender As System.Object, e As System.EventArgs) Handles btnDoUntil.Click
        Dim intFrom As Integer
        Dim intto As Integer
        Dim intwa As Integer = 0

        intFrom = Val(txtFrom.Text)
        intto = Val(txtTo.Text)

        Do Until intFrom > intto
            intwa += intFrom
            intFrom += 1
        Loop
        txtWa.Text = intwa
    End Sub
End Class
