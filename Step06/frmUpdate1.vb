Public Class frmUpdate1
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Private Sub frmUpdate1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
    End Sub
    Private Sub btnUpData_Click(sender As System.Object, e As System.EventArgs) Handles btnUpData.Click
        Dim rat As DialogResult
        rat = MessageBox.Show("デ－タを更新します。" & vbCrLf &
                              "更新すると元に戻りません。" & vbCrLf &
                              "よろしいですか？", "確認", MessageBoxButtons.YesNo)
        If rat = Windows.Forms.DialogResult.No Then
            MessageBox.Show("キャンセルしました。", "確認")
            Exit Sub
        End If
        Dim rate As Double
        rate = (100 + nudRate.Value) / 100
        If txtNum1.Text = " " Or txtNum2.Text = " " Then
            MessageBox.Show("ID確認範囲", "確認")
        Else
            command.CommandText = "UPDATE VB_Staff SET S_Hpay=S_Hpay*" & rate & "WHERE'" & txtNum1.Text & "'<='" & txtNum2.Text & "'"
        End If



        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("更新が完了しました。", "完了メッセ－ジ")

    End Sub

    Private Sub mnuEnd_Click(sender As System.Object, e As System.EventArgs) Handles mnuEnd.Click
        Connection.Close()
        Me.Close()
    End Sub
End Class
