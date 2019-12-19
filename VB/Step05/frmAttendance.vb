Public Class frmAttendance

    Private Sub frmSample_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstAttend.Items.Add("サ\")
    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        Dim i As Integer
        For i = 0 To lstAttend.SelectedItems.Count - 1
            lstAbsent.Items.Add(lstAttend.SelectedItems(i))
        Next
        For i = lstAttend.SelectedItems.Count - 1 To 0 Step -1
            lstAttend.Items.Remove(lstAttend.SelectedItems(i))
        Next
        txtPerson.Text = lstAbsent.Items.Count
    End Sub

    Private Sub btnLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft.Click
        Dim i As Integer
        For i = 0 To lstAbsent.SelectedItems.Count - 1
            lstAttend.Items.Add(lstAbsent.SelectedItems(i))
        Next
        For i = lstAbsent.SelectedItems.Count - 1 To 0 Step -1
            lstAbsent.Items.Remove(lstAbsent.SelectedItems(i))
        Next
        txtPerson.Text = lstAbsent.Items.Count
    End Sub

    Private Sub txtPerson_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPerson.TextChanged

    End Sub

    Private Sub btnAllLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnAllLeft.Click
        Dim i As Integer
        For i = 0 To lstAbsent.Items.Count - 1
            lstAttend.Items.Add(lstAbsent.Items(i))
        Next
        lstAbsent.Items.Clear()
        txtPerson.Text = lstAbsent.Items.Count
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnAllLeft1.Click
        Dim i As Integer
        For i = 0 To lstLate.Items.Count - 1
            lstAbsent.Items.Add(lstLate.Items(i))
        Next
        lstLate.Items.Clear()
        txtLate.Text = lstLate.Items.Count
    End Sub

    Private Sub btnRight1_Click(sender As System.Object, e As System.EventArgs) Handles btnRight1.Click
        Dim i As Integer
        For i = 0 To lstAbsent.SelectedItems.Count - 1
            lstLate.Items.Add(lstAbsent.SelectedItems(i))
        Next
        For i = lstAbsent.SelectedItems.Count - 1 To 0 Step -1
            lstAbsent.Items.Remove(lstAbsent.SelectedItems(i))
        Next
        txtLate.Text = lstLate.Items.Count
        txtPerson.Text = lstAbsent.Items.Count
    End Sub

    Private Sub btnLeft1_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft1.Click
        Dim i As Integer
        For i = 0 To lstLate.SelectedItems.Count - 1
            lstAbsent.Items.Add(lstLate.SelectedItems(i))
        Next
        For i = lstLate.SelectedItems.Count - 1 To 0 Step -1
            lstLate.Items.Remove(lstLate.SelectedItems(i))
        Next
        txtLate.Text = lstLate.Items.Count
        txtPerson.Text = lstAbsent.Items.Count
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Dim i As Integer
        For i = 0 To lstLate.Items.Count - 1
            lstAttend.Items.Add(lstLate.Items(i))
        Next
        For i = 0 To lstAbsent.Items.Count - 1
            lstAttend.Items.Add(lstAbsent.Items(i))
        Next
        lstAbsent.Items.Clear()
        lstLate.Items.Clear()
        txtPerson.Text = 0
        txtLate.Text = 0
    End Sub

    Private Sub txtLate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLate.TextChanged

    End Sub
End Class
