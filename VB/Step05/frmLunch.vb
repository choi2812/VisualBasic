Public Class frmLunch

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtLunch.CheckedChanged
        lstlunch.Items.Clear()
        lstlunch.Items.Add("ハンバ-グ定食")
        lstlunch.Items.Add("しょうが焼き定食")
        lstlunch.Items.Add("野菜炒め定食")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub rbtNuddle_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtNuddle.CheckedChanged
        lstlunch.Items.Clear()
        lstlunch.Items.Add("醤油ラ-メン")
        lstlunch.Items.Add("味噌ラ-メン")
        lstlunch.Items.Add("塩ラ-メン")
    End Sub

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub lstlunch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstlunch.SelectedIndexChanged
        txtSelect.Text = lstlunch.SelectedItem
    End Sub

    Private Sub frmLunch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtNuddle.Checked = False
        rbtLunch.Checked = False
    End Sub
End Class