Public Class frmTestDate
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Dim n_date As Date

    Private Sub frmTestDate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        n_date = Now
        txtNow.Text = Format(n_date, "yyyy/MM/dd")

        Connection.Open()
        'SQL
        command.CommandText = "SELECT * FROM Test_Date"

        dr = command.ExecuteReader

        dr.Read()

        Dim w1_date, w2_date As Date
        w1_date = dr("T_Date1")
        w2_date = dr("T_Date2")
        dr.Close()

        txtT_Date1.Text = w1_date
        txtT_Date2.Text = w2_date

    End Sub

    Private Sub txtRental_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRental.TextChanged
        Dim w_date As Date
        Dim rental As Integer

        rental = Val(txtRental.Text)
        w_date = DateAdd("d", rental, n_date)
        txtR_Date.Text = Format(w_date, "yyyy/MM/dd")

    End Sub

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        'SQL
        command.CommandText = "UPDATE Test_Date " _
                               & "SET T_Date1 = '" & Format(n_date, "yyyy/MM/dd") & "'," _
                               & "T_Date2 = '" & txtR_Date.Text & "'"
        Try
            command.ExecuteNonQuery()
            MessageBox.Show("デ－タを更新しました", "確認")

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
End Class
