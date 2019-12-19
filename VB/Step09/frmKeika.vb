Public Class frmKeika

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        setDay()
    End Sub

    Private Sub setDay()
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
            If isleap(Val(cmbYear.Text)) Then
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

    Private Function isleap(ByVal y As Integer) As Boolean
        If (y Mod 4 = 0 And y Mod 100 <> 0) Or y Mod 400 = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        setDay()
    End Sub

    Private Sub btnDays_Click(sender As System.Object, e As System.EventArgs) Handles btnDays.Click
        Dim birthdata As String
        Dim sdata As Date

        birthdata = cmbYear.Text & "/" & cmbMonth.Text & "/" & cmbDay.Text
        sdata = CDate(birthdata)
        txtDiffDays.Text = DateDiff("d", sdata, Now)
    End Sub

    Private Sub frmKeika_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 2014 To 1980 Step -1
            cmbYear.Items.Add(i)
        Next
        Dim j As Integer
        For j = 1 To 12
            cmbMonth.Items.Add(j)
        Next


        txtNow.Text = Format(Now, "D")
    End Sub
End Class