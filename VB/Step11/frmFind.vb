Public Class frmFind

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        frmTextEditor.findstr = txtFindStr.Text
        frmTextEditor.subFind()
        frmTextEditor.Focus()
    End Sub

    Private Sub txtFindStr_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFindStr.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmTextEditor.mnuFind.Enabled = True
        Me.Close()
    End Sub
End Class