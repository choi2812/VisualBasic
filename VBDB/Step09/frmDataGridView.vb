Public Class frmDataGridView
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Dim ssex As String

    Private Sub frmDataGridView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
    End Sub
    Private Sub DataSet()
        Dim ssax As String

        While dr.Read()
            If dr("S_Sex") = 1 Then
                ssex = "男"
            Else
                ssax = "女"
            End If
            dgvStaff.Rows.Add("", dr("S_Code"), dr("S_Name"), ssax)
        End While
        dr.Close()
    End Sub


    Private Sub ファイルToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ファイルToolStripMenuItem.Click
        Connection.Close()
        Me.Close()
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick
        command.CommandText = "SELECT * FROM VB_Staff,VB_Section " _
                            & " WHERE S_Code = '" & dgvStaff.CurrentRow.Cells(1).Value & "'" _
                            & " AND VB_Staff.S_Secton = VB_Section.Sec_Code"

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
        

        txtS_Code.Text = dr("S_Code")
        txtS_name.Text = dr("S_Name")
        txtS_Kana.Text = dr("S_Kana")
        txtS_Sex.Text = dr("S_Sex")
        txtS_Hpay.Text = Format(dr("S_Hpay"), "##0")
        txtS_Section.Text = dr("S_Secton")
        txtS_Phone.Text = dr("S_Phone")

        If dr("S_Resignflag") = True Then
            chkS_Resignflag.Checked = True
        Else
            chkS_Resignflag.Checked = False
        End If
        If dr("S_Sex") = 1 Then
            lblSex.Text = "男"
        Else
            lblSex.Text = "女"
        End If
        dr.Close()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        command.CommandText = "SELECT * FROM VB_Staff " & "WHERE S_Name LIKE '%" & txtS_NameSearch.Text & "%'"
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