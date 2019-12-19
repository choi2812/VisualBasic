Public Class frmSearch

    '필수 3행 꼭!!!
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub frmSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
        command.CommandText = "SELECT * FROM VB_Staff"
        dr = command.ExecuteReader
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        subDataDisq()

    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        If rbtAll.Checked = True Then
            command.CommandText = "SELECT * FROM VB_Staff"
        ElseIf rbtMan.Checked = True Then
            command.CommandText = "SELECT * FROM VB_Staff WHERE S_Sex =" & "'1'"
        Else
            command.CommandText = "SELECT * FROM VB_Staff WHERE S_Sex =" & "'2'"
        End If
        dr = command.ExecuteReader

        subDataDisq()
    End Sub
    Private Sub subDataDisq()
        If dr.Read() = False Then
            MessageBox.Show("デ－タはありません。", "メッセ－ジ")
            dr.Close()
            Exit Sub
        End If
        txtS_Code.Text = dr("S_Code")
        txtS_Name.Text = dr("S_Name")
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
    End Sub
End Class