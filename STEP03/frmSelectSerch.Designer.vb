<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSerch
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
        Me.lblSex = New System.Windows.Forms.Label()
        Me.chkS_Resignflag = New System.Windows.Forms.CheckBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtS_Phone = New System.Windows.Forms.TextBox()
        Me.txtS_Resignflag = New System.Windows.Forms.TextBox()
        Me.txtS_Secton = New System.Windows.Forms.TextBox()
        Me.txtS_Hpay = New System.Windows.Forms.TextBox()
        Me.txtS_Sex = New System.Windows.Forms.TextBox()
        Me.txtS_Kana = New System.Windows.Forms.TextBox()
        Me.txtS_Name = New System.Windows.Forms.TextBox()
        Me.txtS_Code = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSerch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(153, 166)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(29, 12)
        Me.lblSex.TabIndex = 43
        Me.lblSex.Text = "性別"
        '
        'chkS_Resignflag
        '
        Me.chkS_Resignflag.AutoSize = True
        Me.chkS_Resignflag.Location = New System.Drawing.Point(116, 414)
        Me.chkS_Resignflag.Name = "chkS_Resignflag"
        Me.chkS_Resignflag.Size = New System.Drawing.Size(15, 14)
        Me.chkS_Resignflag.TabIndex = 42
        Me.chkS_Resignflag.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(374, 401)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 41
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txtS_Phone
        '
        Me.txtS_Phone.Location = New System.Drawing.Point(116, 320)
        Me.txtS_Phone.Name = "txtS_Phone"
        Me.txtS_Phone.Size = New System.Drawing.Size(145, 19)
        Me.txtS_Phone.TabIndex = 39
        '
        'txtS_Resignflag
        '
        Me.txtS_Resignflag.Location = New System.Drawing.Point(116, 367)
        Me.txtS_Resignflag.Name = "txtS_Resignflag"
        Me.txtS_Resignflag.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Resignflag.TabIndex = 38
        '
        'txtS_Secton
        '
        Me.txtS_Secton.Location = New System.Drawing.Point(116, 273)
        Me.txtS_Secton.Name = "txtS_Secton"
        Me.txtS_Secton.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Secton.TabIndex = 37
        '
        'txtS_Hpay
        '
        Me.txtS_Hpay.Location = New System.Drawing.Point(116, 226)
        Me.txtS_Hpay.Name = "txtS_Hpay"
        Me.txtS_Hpay.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Hpay.TabIndex = 36
        Me.txtS_Hpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS_Sex
        '
        Me.txtS_Sex.Location = New System.Drawing.Point(116, 159)
        Me.txtS_Sex.Name = "txtS_Sex"
        Me.txtS_Sex.Size = New System.Drawing.Size(31, 19)
        Me.txtS_Sex.TabIndex = 35
        '
        'txtS_Kana
        '
        Me.txtS_Kana.Location = New System.Drawing.Point(116, 112)
        Me.txtS_Kana.Name = "txtS_Kana"
        Me.txtS_Kana.Size = New System.Drawing.Size(157, 19)
        Me.txtS_Kana.TabIndex = 34
        '
        'txtS_Name
        '
        Me.txtS_Name.Location = New System.Drawing.Point(116, 65)
        Me.txtS_Name.Name = "txtS_Name"
        Me.txtS_Name.Size = New System.Drawing.Size(157, 19)
        Me.txtS_Name.TabIndex = 33
        '
        'txtS_Code
        '
        Me.txtS_Code.Location = New System.Drawing.Point(116, 18)
        Me.txtS_Code.Name = "txtS_Code"
        Me.txtS_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Code.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 12)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "退社フラグ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "電話番号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 12)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "所属コ－ド"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "時給"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "性別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "カナ名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "スタッフ名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "スタッフコード"
        '
        'btnSerch
        '
        Me.btnSerch.Location = New System.Drawing.Point(360, 32)
        Me.btnSerch.Name = "btnSerch"
        Me.btnSerch.Size = New System.Drawing.Size(75, 23)
        Me.btnSerch.TabIndex = 44
        Me.btnSerch.Text = "Serch"
        Me.btnSerch.UseVisualStyleBackColor = True
        '
        'frmSelectSerch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 446)
        Me.Controls.Add(Me.btnSerch)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.chkS_Resignflag)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtS_Phone)
        Me.Controls.Add(Me.txtS_Resignflag)
        Me.Controls.Add(Me.txtS_Secton)
        Me.Controls.Add(Me.txtS_Hpay)
        Me.Controls.Add(Me.txtS_Sex)
        Me.Controls.Add(Me.txtS_Kana)
        Me.Controls.Add(Me.txtS_Name)
        Me.Controls.Add(Me.txtS_Code)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSelectSerch"
        Me.Text = "スタッフ管理　Select文"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents chkS_Resignflag As System.Windows.Forms.CheckBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txtS_Phone As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Resignflag As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Secton As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Hpay As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Sex As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Kana As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSerch As System.Windows.Forms.Button
End Class
