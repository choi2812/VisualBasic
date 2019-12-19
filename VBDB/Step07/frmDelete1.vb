Public Class frmDelete1
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Private Sub frmDelete1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
    End Sub

    Private Sub btnSerch_Click(sender As System.Object, e As System.EventArgs) Handles btnSerch.Click
        command.CommandText = "SELECT * FROM VB_Staff WHERE S_Code =" & "'" & txtS_CodeSearch.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        subDataDisq()
    End Sub
    Private Sub subDataDisq()
        Try
            If dr.Read() = False Then
                MessageBox.Show("デ－タはありません。", "メッセ－ジ")
                dr.Close()
                Exit Sub
            End If
        Catch ex As InvalidOperationException
            MessageBox.Show("条件を指定し検索ボタンをクリックしてください。", "操作の確認")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        txtS_Code.Text = dr("S_Code")
        txtS_name.Text = dr("S_Name")
        txtS_Kana.Text = dr("S_Kana")
        txtS_Sex.Text = dr("S_Sex")

        If dr("S_Sex") = 1 Then
            lblSex.Text = "男"
        Else
            lblSex.Text = "女"
        End If

        txtS_Hpay.Text = Format(dr("S_Hpay"), "##0")
        txtS_Secton.Text = dr("S_Secton")
        txtS_Phone.Text = dr("S_Phone")

        If dr("S_Resignflag") = True Then
            chkS_Resignflag.Checked = True
        Else
            chkS_Resignflag.Checked = False
        End If
        dr.Close()
    End Sub

    Private Sub mnuClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuClose.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        Dim rat As DialogResult

        rat = MessageBox.Show("デ－タを削除します。" & vbCrLf &
                              "更新すると元に戻りません。" & vbCrLf &
                              "よろしいですか？", "確認", MessageBoxButtons.YesNo)
        If rat = Windows.Forms.DialogResult.No Then
            MessageBox.Show("キャンセルしました。", "確認")
            Exit Sub
        Else
            command.CommandText = "DELETE FROM VB_Staff WHERE S_Code LIKE" & "'" & txtS_CodeSearch.Text & "'"
             Try
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            

            MessageBox.Show("デ－タ変更しました。", "終了")
            txtS_CodeSearch.Text = ""
            txtS_Code.Text = ""
            txtS_name.Text = ""
            txtS_Kana.Text = ""
            txtS_Sex.Text = ""
            lblSex.Text = "性別"
            txtS_Hpay.Text = ""
            txtS_Secton.Text = ""
            txtS_Phone.Text = ""
            chkS_Resignflag.Checked = False
        End If


    End Sub

   
End Class









