Public Class frmReplace

    Private Sub btnReplace_Click(sender As System.Object, e As System.EventArgs) Handles btnReplace.Click
        frmTextEditor.find = txtFind.Text
        frmTextEditor.replace = txtReplace.Text
        frmTextEditor.subFind2()
        frmTextEditor.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        frmTextEditor.mnuReplace.Enabled = True
        Me.Close()
    End Sub
End Class