Public Class frmAdd
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Private Sub frmAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
        SetSection()
    End Sub
    Private Sub SetSection()
        'VB_Section read input
        command.CommandText = "SELECT * FROM VB_Section"
        dr = command.ExecuteReader

        While dr.Read()
            cmbS_Section.Items.Add(dr("Sec_Code"))
        End While
        dr.Close()
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'data check
        command.CommandText = "SELECT * FROM VB_Staff WHERE S_Code =" & "'" & txtS_Code.Text & "'"
        dr = command.ExecuteReader
        If dr.Read() Then
            MessageBox.Show("既に同じスタッフコ－ドのデ－タがあります。", "メッセ－ジ")
            dr.Close()
            Exit Sub

        End If
        dr.Close()
        'data 確認
        Dim ret As DialogResult
        ret = MessageBox.Show("ﾃﾞ-ﾀを登録します。よろしいですか？", "確認", MessageBoxButtons.YesNo)
        If ret = Windows.Forms.DialogResult.No Then
            MessageBox.Show("キャンセルしました。", "確認")
            Exit Sub
        End If

        'data chack
        If DataCheck() = False Then
            Exit Sub
        End If

        'add prosess
        Dim SQLstr As String
        SQLstr = "INSERT INTO VB_Staff "
        SQLstr = SQLstr & "(S_Code,S_Name,S_Kana,S_Sex,S_Hpay,S_Secton,S_Phone,S_Resignflag)"
        SQLstr = SQLstr & "VALUES ("
        SQLstr = SQLstr & "'" & txtS_Code.Text & "' , "
        SQLstr = SQLstr & "'" & txtS_Name.Text & "' , "
        SQLstr = SQLstr & "'" & txtS_Kana.Text & "' , "
        SQLstr = SQLstr & "'" & txtS_Sex.Text & "' , "
        SQLstr = SQLstr & Val(txtS_Hpay.Text) & " , "
        SQLstr = SQLstr & "'" & cmbS_Section.Text & "' , "
        SQLstr = SQLstr & "'" & txtS_Phone.Text & "' , "

        If chkS_Resignflag.Checked Then
            SQLstr = SQLstr & " 1 "
        Else
            SQLstr = SQLstr & " 0 "

        End If
        SQLstr = SQLstr & ")"

        'SQL line Set
        command.CommandText = SQLstr

        'SQL start
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("デ－タを登録しました。", "確認")

    End Sub
    Private Function DataCheck() As Boolean
        'txtS_Code chack is null
        If Len(txtS_Code.Text) = 0 Then
            MessageBox.Show("スタッフコードを入れてください。", "エラ－メッセ－ジ")
            Return False
        End If
        'txtS_Name chack is null
        If Len(txtS_Name.Text) = 0 Then
            MessageBox.Show("スタッフ名を入れてください。", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Kana chack is null
        If Len(txtS_Kana.Text) = 0 Then
            MessageBox.Show("カナ名を入れてください。", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Sex chack is null
        If Len(txtS_Sex.Text) = 0 Then
            MessageBox.Show("性別を入れてください。", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Hpay chack is null
        If Len(txtS_Hpay.Text) = 0 Then
            MessageBox.Show("時給を入れてください。", "エラ－メッセ－ジ")
            Return False
        End If

        'cmbS_Section chack is null
        If Len(cmbS_Section.Text) = 0 Then
            MessageBox.Show("所属コ－ドを選択してください。", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Name  len chack
        If Len(txtS_Name.Text) > 10 Then
            MessageBox.Show("名前の文字数が多すぎます！", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Kana  len chack
        If Len(txtS_Kana.Text) > 10 Then
            MessageBox.Show("カナ名の文字数が多すぎます！", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Phone  len chack
        If Len(txtS_Phone.Text) > 13 Then
            MessageBox.Show("電話番号の文字数が多すぎます！", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Sex chack
        If Val(txtS_Sex.Text) <> 1 And Val(txtS_Sex.Text) <> 2 Then
            MessageBox.Show("性別が違います！（1：男　2：女）", "エラ－メッセ－ジ")
            Return False
        End If

        'txtS_Hpay chack
        If Val(txtS_Hpay.Text) < 500 Or Val(txtS_Hpay.Text) > 10000 Then
            MessageBox.Show("指定範囲以内の時給を設定してください。（500円～10000円）", "エラ－メッセ－ジ")
            Return False
        End If
        'ok
        Return True
    End Function
    Private Sub mnuClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuClose.Click
        Connection.Close()
        Me.Close()
    End Sub
End Class
