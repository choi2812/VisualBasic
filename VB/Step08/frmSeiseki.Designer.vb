<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeiseki
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRank = New System.Windows.Forms.Button()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "点数"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(70, 22)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(378, 19)
        Me.txtScore.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "平均点"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "最高点"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "最低点"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "点"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "点"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "点"
        '
        'btnRank
        '
        Me.btnRank.Location = New System.Drawing.Point(342, 73)
        Me.btnRank.Name = "btnRank"
        Me.btnRank.Size = New System.Drawing.Size(75, 23)
        Me.btnRank.TabIndex = 8
        Me.btnRank.Text = "ランク"
        Me.btnRank.UseVisualStyleBackColor = True
        '
        'btnAvg
        '
        Me.btnAvg.Location = New System.Drawing.Point(122, 73)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(75, 23)
        Me.btnAvg.TabIndex = 9
        Me.btnAvg.Text = "平均等"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 12)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(308, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 12)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "C"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 12)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "B"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 12)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "A"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(404, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 12)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "人"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(404, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 12)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "人"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(404, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 12)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "人"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(404, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 12)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "人"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(262, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 12)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "ランク"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(406, 362)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 19
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(330, 237)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(68, 19)
        Me.txtC.TabIndex = 20
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(330, 180)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(68, 19)
        Me.txtB.TabIndex = 21
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(330, 134)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(68, 19)
        Me.txtA.TabIndex = 22
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(84, 237)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(90, 19)
        Me.txtMin.TabIndex = 23
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(84, 187)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(90, 19)
        Me.txtMax.TabIndex = 24
        Me.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAvg
        '
        Me.txtAvg.Location = New System.Drawing.Point(84, 130)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.Size = New System.Drawing.Size(90, 19)
        Me.txtAvg.TabIndex = 25
        Me.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(330, 294)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(68, 19)
        Me.txtD.TabIndex = 26
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSeiseki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 416)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.btnRank)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSeiseki"
        Me.Text = "クラス成績"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRank As System.Windows.Forms.Button
    Friend WithEvents btnAvg As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtAvg As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
End Class
