﻿Public Class frmRentalLoginSystem
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub frmRentalLoginSystem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
    End Sub
    Private Sub DataSet()
        Dim ssax As String

        While dr.Read()
            If dr("C_Sex") = 1 Then
                ssax = "男"
            Else
                ssax = "女"
            End If
            dgvMemder.Rows.Add("", dr("C_Code"), dr("C_Name"), dr("C_Kana"), ssax, dr("C_HomePhone"), dr("C_Phone"))
        End While
        dr.Close()
    End Sub

    Private Sub dgvMemder_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMemder.CellContentClick
        command.CommandText = "SELECT * FROM CJM_Customer " _
                             & " WHERE C_Code = '" & dgvMemder.CurrentRow.Cells(1).Value & "'"

        Try
            dr = command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        SubDataDisp()
    End Sub
    Private Sub SubDataDisp()
        If dr.Read() = False Then
            MessageBox.Show("デ－タはありません。", "メッセ－ジ")
            dr.Close()
            Exit Sub
        End If


        txtC_Code.Text = dr("C_Code")
        txtC_Name.Text = dr("C_Name")
        txtC_Kana.Text = dr("C_Kana")
        txtC_Adress.Text = dr("C_Adress")
        txtC_BirthDay.Text = dr("C_BirthDay")
        txtC_ExpirationDate.Text = dr("C_ExpirationDate")
        If IsDBNull(dr("C_HomePhone")) Then
            txtC_HomePhone.Text = " "
        Else
            txtC_HomePhone.Text = dr("C_HomePhone")
        End If
        txtC_JoinDate.Text = dr("C_JoinDate")
        txtC_Phone.Text = dr("C_Phone")
        txtC_PostNo.Text = dr("C_PostNo")
        txtC_TakeOutcount.Text = dr("C_TakeOutcount")
        If dr("C_Sex") = 1 Then
            lblC_Sex.Text = "男"
        Else
            lblC_Sex.Text = "女"
        End If
        dr.Close()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        command.CommandText = "SELECT * FROM CJM_Customer " & "WHERE C_Code LIKE '%" & txtSearch.Text & "%'"
        Try
            dr = command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        DataSet()
    End Sub

  
End Class
