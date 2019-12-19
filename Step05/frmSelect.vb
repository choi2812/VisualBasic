﻿Public Class frmSelect
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub frmSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
        rbtCompleate.Checked = True

        mnuNext.Enabled = False



    End Sub
    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub btnSerch_Click(sender As System.Object, e As System.EventArgs) Handles btnSerch.Click
        If (rbtCompleate.Checked = True) Then
            Command.CommandText = "SELECT * FROM VB_Staff WHERE S_Name =" & "'" & txtS_NameSearch.Text & "'"
        ElseIf (rbtPart.Checked = True) Then
            Command.CommandText = "SELECT * FROM VB_Staff WHERE S_Name LIKE " & "'%" & txtS_NameSearch.Text & "%'"
        Else
            Command.CommandText = "SELECT * FROM VB_Staff WHERE S_Name =" & "'" & txtS_NameSearch.Text & "'"

        End If
        Try
            dr = Command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = Command.ExecuteReader
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

        mnuNext.Enabled = True

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
        txtS_NameSearch.Text = " "
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
        rbtCompleate.Checked = False
        rbtPart.Checked = False
    End Sub



End Class
