Public Class frmTimer

   
    
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
  
       
        tmrTimer.Enabled = True
        prbTimer.Maximum = nudMin.Value * 60 + nudSec.Value

    End Sub

    Private Sub tmrTimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimer.Tick
        Static sec As Integer = 0
       
        sec += 1
        prbTimer.Value = sec
        If sec = prbTimer.Maximum Then
            tmrTimer.Enabled = False
            MessageBox.Show("時間になりました。", "メッセ－ジ")
            sec = 0
        End If

       
    End Sub

   
    Private Sub frmTimer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        txtYear.Text = Format(Now, "yyyy")
        txtMonth.Text = Format(Now, "MM")
        txtDay.Text = Format(Now, "dd")
        txtHour.Text = Format(Now, "HH")
        txtMin.Text = Format(Now, "mm")
        txtSec.Text = Format(Now, "ss")

    End Sub

    Private Sub mnuEnd_Click(sender As System.Object, e As System.EventArgs) Handles mnuEnd.Click
        Me.Close()

    End Sub
    
    Private Sub chkYear_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkYear.CheckedChanged
        If chkYear.Checked = True Then
            txtYear.Visible = True
            lblYear.Visible = True
        Else
            txtYear.Visible = False
            lblYear.Visible = False
        End If
    End Sub

    Private Sub chkSec_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSec.CheckedChanged
        If chkSec.Checked = True Then
            txtSec.Visible = True
            lblSec.Visible = True
        Else
            txtSec.Visible = False
            lblSec.Visible = False

        End If
    End Sub

    Private Sub rbtBarNotExist_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtBarNotExist.CheckedChanged
        If rbtBarNotExist.Checked = True Then
            prbTimer.Visible = False
            Label4.Visible = False
            Label5.Visible = False
        Else
            prbTimer.Visible = True
            Label4.Visible = True
            Label5.Visible = True

        End If
    End Sub
End Class
