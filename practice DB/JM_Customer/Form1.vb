Public Class Form1

    Private Sub JM_CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles JM_CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JM_CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._14jydbDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを '_14jydbDataSet.JM_Customer' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.JM_CustomerTableAdapter.Fill(Me._14jydbDataSet.JM_Customer)

    End Sub

    Private Sub C_CodeTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles C_CodeTextBox.TextChanged

    End Sub
End Class
