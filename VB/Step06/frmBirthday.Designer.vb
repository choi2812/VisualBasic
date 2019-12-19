<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBirthday
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.txtToday = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAge = New System.Windows.Forms.Button()
        Me.btnDay = New System.Windows.Forms.Button()
        Me.btnEto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEto = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDiffday = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDiffday = New System.Windows.Forms.TextBox()
        Me.babel13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "今日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "生年月日"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(141, 111)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(56, 20)
        Me.cmbMonth.TabIndex = 3
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(24, 111)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(79, 20)
        Me.cmbYear.TabIndex = 4
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(244, 111)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(53, 20)
        Me.cmbDay.TabIndex = 5
        '
        'txtToday
        '
        Me.txtToday.Location = New System.Drawing.Point(79, 20)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.Size = New System.Drawing.Size(100, 19)
        Me.txtToday.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "月"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "年"
        '
        'btnAge
        '
        Me.btnAge.Location = New System.Drawing.Point(24, 170)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(75, 23)
        Me.btnAge.TabIndex = 10
        Me.btnAge.Text = "年齢"
        Me.btnAge.UseVisualStyleBackColor = True
        '
        'btnDay
        '
        Me.btnDay.Location = New System.Drawing.Point(24, 241)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(75, 23)
        Me.btnDay.TabIndex = 11
        Me.btnDay.Text = "曜日"
        Me.btnDay.UseVisualStyleBackColor = True
        '
        'btnEto
        '
        Me.btnEto.Location = New System.Drawing.Point(24, 287)
        Me.btnEto.Name = "btnEto"
        Me.btnEto.Size = New System.Drawing.Size(75, 23)
        Me.btnEto.TabIndex = 12
        Me.btnEto.Text = "干支"
        Me.btnEto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "あなたの干支は"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 12)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "生まれた曜日は"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "あなたの年齢は"
        '
        'txtEto
        '
        Me.txtEto.Location = New System.Drawing.Point(197, 295)
        Me.txtEto.Name = "txtEto"
        Me.txtEto.Size = New System.Drawing.Size(69, 19)
        Me.txtEto.TabIndex = 16
        Me.txtEto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(197, 243)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(74, 19)
        Me.txtDay.TabIndex = 17
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(197, 178)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(74, 19)
        Me.txtAge.TabIndex = 18
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(277, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 12)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "年です"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(277, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 12)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "です"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 12)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "歳です"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(262, 339)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 22
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDiffday
        '
        Me.btnDiffday.Location = New System.Drawing.Point(24, 204)
        Me.btnDiffday.Name = "btnDiffday"
        Me.btnDiffday.Size = New System.Drawing.Size(75, 23)
        Me.btnDiffday.TabIndex = 24
        Me.btnDiffday.Text = "日数"
        Me.btnDiffday.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(105, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 12)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "あなたは生まれてから"
        '
        'txtDiffday
        '
        Me.txtDiffday.Location = New System.Drawing.Point(205, 208)
        Me.txtDiffday.Name = "txtDiffday"
        Me.txtDiffday.Size = New System.Drawing.Size(66, 19)
        Me.txtDiffday.TabIndex = 26
        Me.txtDiffday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'babel13
        '
        Me.babel13.AutoSize = True
        Me.babel13.Location = New System.Drawing.Point(277, 209)
        Me.babel13.Name = "babel13"
        Me.babel13.Size = New System.Drawing.Size(77, 12)
        Me.babel13.TabIndex = 27
        Me.babel13.Text = "日経過しました"
        '
        'frmBirthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 374)
        Me.Controls.Add(Me.babel13)
        Me.Controls.Add(Me.txtDiffday)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnDiffday)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtEto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnEto)
        Me.Controls.Add(Me.btnDay)
        Me.Controls.Add(Me.btnAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtToday)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBirthday"
        Me.Text = "あなたの生まれた日"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents txtToday As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAge As System.Windows.Forms.Button
    Friend WithEvents btnDay As System.Windows.Forms.Button
    Friend WithEvents btnEto As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEto As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDiffday As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDiffday As System.Windows.Forms.TextBox
    Friend WithEvents babel13 As System.Windows.Forms.Label

End Class
