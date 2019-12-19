Public Class frmBirthday

    Private Sub cmbYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbYear.SelectedIndexChanged

        Dim k As Integer
        Dim endday As Integer
        Dim mon As Integer
        mon = Val(cmbMonth.Text)
        If mon = 1 Or mon = 3 Or mon = 5 Or mon = 7 Or mon = 8 Or mon = 10 Or mon = 12 Then
            endday = 31
        End If
        If mon = 4 Or mon = 6 Or mon = 9 Or mon = 11 Then
            endday = 30
        End If
        If mon = 2 Then
            If (Val(cmbYear.Text) Mod 4 = 0 And Val(cmbYear.Text) <> 0) Or Val(cmbYear.Text) Mod 400 = 0 Then
                endday = 29
            Else
                endday = 28
            End If
        End If
        cmbDay.Items.Clear()

        For k = 1 To endday
            cmbDay.Items.Add(k)
        Next
    End Sub

    Private Sub frmBirthday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load   
        Dim i As Integer
        For i = 2014 To 1980 Step -1
            cmbYear.Items.Add(i)
        Next
        Dim j As Integer
        For j = 1 To 12
            cmbMonth.Items.Add(j)
        Next


        txtToday.Text = Format(Now, "D")
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub txtDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDay.TextChanged

    End Sub

    Private Sub btnDay_Click(sender As System.Object, e As System.EventArgs) Handles btnDay.Click
        Dim birthdata As String
        Dim sdata As Date
        birthdata = cmbYear.Text & "/" & cmbMonth.Text & "/" & cmbDay.Text
        sdata = CDate(birthdata)
        txtDay.Text = Format(sdata, "dddd")
    End Sub

    Private Sub btnAge_Click(sender As System.Object, e As System.EventArgs) Handles btnAge.Click
        Dim age As Integer
        age = Format(Now, "yyyy") - Val(cmbYear.Text)
        If Val(cmbMonth.Text) > Format(Now, "mm") Then
            age -= 1
        ElseIf Val(cmbMonth.Text) = Format(Now, "MM") And Val(cmbDay.Text) > Format(Now, "dd") Then
            age -= 1
        End If
        txtAge.Text = age
    End Sub

    Private Sub btnEto_Click(sender As System.Object, e As System.EventArgs) Handles btnEto.Click
        Dim str() As String = {"申", "酉", "戌", "核", "子", "丑", "寅", "亥", "辰", "己", "午", "未"}
        Dim i As Integer
        i = Val(cmbYear.Text) Mod 12
        txtEto.Text = str(i)
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDay.SelectedIndexChanged

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        Dim k As Integer
        Dim endday As Integer
        Dim mon As Integer
        mon = Val(cmbMonth.Text)
        If mon = 1 Or mon = 3 Or mon = 5 Or mon = 7 Or mon = 8 Or mon = 10 Or mon = 12 Then
            endday = 31
        End If
        If mon = 4 Or mon = 6 Or mon = 9 Or mon = 11 Then
            endday = 30
        End If
        If mon = 2 Then
            If (Val(cmbYear.Text) Mod 4 = 0 And Val(cmbYear.Text) <> 0) Or Val(cmbYear.Text) Mod 400 = 0 Then
                endday = 29
            Else
                endday = 28
            End If
        End If
        cmbDay.Items.Clear()

        For k = 1 To endday
            cmbDay.Items.Add(k)
        Next
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        cmbYear.Text = ""
        cmbMonth.Text = ""
        cmbDay.Text = ""
        txtAge.Text = ""
        txtEto.Text = ""
        txtDay.Text = ""
        txtDiffday.Text = ""
    End Sub

    Private Sub btnDiffday_Click(sender As System.Object, e As System.EventArgs) Handles btnDiffday.Click
        Dim date1 As Date
        Dim birthdata As String
        birthdata = cmbYear.Text & "/" & cmbMonth.Text & "/" & cmbDay.Text
        date1 = CDate(birthdata)
        txtDiffday.Text = DateDiff("d", date1, Now)
    End Sub
End Class
