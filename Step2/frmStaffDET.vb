Public Class frmStaffDET

    Private Sub VB_StaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles VB_StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VB_StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._14jydbDataSet)

    End Sub

    Private Sub frmStaffDET_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを '_14jydbDataSet.VB_Staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.VB_StaffTableAdapter.Fill(Me._14jydbDataSet.VB_Staff)

    End Sub
End Class