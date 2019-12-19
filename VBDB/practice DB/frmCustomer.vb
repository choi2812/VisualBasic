Public Class frmCustomer

    Private Sub VB_CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VB_CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VB_CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._14jydbDataSet)

    End Sub

    Private Sub frmCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを '_14jydbDataSet.VB_Customer' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.VB_CustomerTableAdapter.Fill(Me._14jydbDataSet.VB_Customer)

    End Sub

    Private Sub VB_CustomerDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VB_CustomerDataGridView.CellContentClick

    End Sub
End Class
