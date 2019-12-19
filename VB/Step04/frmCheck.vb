Public Class frmCheck

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub chkFamilyname_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFamilyname.CheckedChanged

    End Sub

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        If chkFamilyname.Checked = True And chkGivenname.Checked = False Then
            txtName.Text = "崔"
        End If
        If chkGivenname.Checked = True And chkFamilyname.Checked = False Then
            txtName.Text = "禎文"
        End If
        If chkFamilyname.Checked = True And chkGivenname.Checked = True Then
            txtName.Text = "崔禎文"

        End If
        If chkFamilyname.Checked = False And chkGivenname.Checked = False Then
            txtName.Text = ""
        End If
    End Sub
End Class