Public Class frm_Select1
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Private Sub frm_Select1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
        mnuNext.Enabled = True
    End Sub
    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub btnSerch_Click(sender As System.Object, e As System.EventArgs) Handles btnSerch.Click
        If cmbBusho.Text = "" Then
            MessageBox.Show("再度部署コ－ドを指定してください", "操作の確認")
        Else
            If cmbBusho.Text = "すべて" Then
                command.CommandText = "SELECT * FROM VB_Staff "

            Else

                command.CommandText = "SELECT * FROM VB_Staff WHERE S_Secton =" & "'" & cmbBusho.Text & "'"
            End If
        End If
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

        txtS_Resignflag.Text = dr("S_Resignflag")

        ' mnuNext.Enabled = True

    End Sub
    Private Sub mnuNext_Click(sender As System.Object, e As System.EventArgs) Handles mnuNext.Click
        subDataDisq()
    End Sub

    Private Sub mnuVer_Click(sender As System.Object, e As System.EventArgs) Handles mnuVer.Click
        MessageBox.Show("Version 1.0", "メッセ－ジ")
    End Sub

    Private Sub mnuClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuClose.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub mnuClear_Click(sender As System.Object, e As System.EventArgs) Handles mnuClear.Click

        txtS_Code.Text = " "
        txtS_name.Text = " "
        txtS_Kana.Text = " "
        txtS_Sex.Text = " "
        txtS_Hpay.Text = " "
        txtS_Secton.Text = " "
        txtS_Phone.Text = " "
        txtS_Resignflag.Text = " "
        chkS_Resignflag.Checked = False
        lblSex.Text = ""
        
    End Sub

    Private Sub cmbBusho_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbBusho.SelectedIndexChanged
        If cmbBusho.Text = "" Then
            MessageBox.Show("再度部署コ－ドを指定してください", "操作の確認")
        Else
            If cmbBusho.Text = "すべて" Then
                command.CommandText = "SELECT * FROM VB_Staff "

            Else

                command.CommandText = "SELECT * FROM VB_Staff WHERE S_Secton =" & "'" & cmbBusho.Text & "'"
            End If
        End If
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
End Class