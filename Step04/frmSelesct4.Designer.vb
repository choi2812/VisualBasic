<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelesct4
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVer1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtWoman = New System.Windows.Forms.RadioButton()
        Me.rbtMan = New System.Windows.Forms.RadioButton()
        Me.rbtAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpay2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPay1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSerch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtS_name = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.chkS_Resignflag = New System.Windows.Forms.CheckBox()
        Me.txtS_Phone = New System.Windows.Forms.TextBox()
        Me.txtS_Resignflag = New System.Windows.Forms.TextBox()
        Me.txtS_Secton = New System.Windows.Forms.TextBox()
        Me.txtS_Hpay = New System.Windows.Forms.TextBox()
        Me.txtS_Sex = New System.Windows.Forms.TextBox()
        Me.txtS_Kana = New System.Windows.Forms.TextBox()
        Me.txtS_Code = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.表示VToolStripMenuItem, Me.mnuVer1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 26)
        Me.MenuStrip1.TabIndex = 87
        Me.MenuStrip1.Text = "ヘルプ(&H)"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(118, 22)
        Me.mnuClose.Text = "終了(&X)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNext, Me.mnuClear})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        'mnuNext
        '
        Me.mnuNext.Name = "mnuNext"
        Me.mnuNext.Size = New System.Drawing.Size(131, 22)
        Me.mnuNext.Text = "次候補(&N)"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(131, 22)
        Me.mnuClear.Text = "クリア(&C)"
        '
        'mnuVer1
        '
        Me.mnuVer1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVer})
        Me.mnuVer1.Name = "mnuVer1"
        Me.mnuVer1.Size = New System.Drawing.Size(75, 22)
        Me.mnuVer1.Text = "ヘルプ(&H)"
        '
        'mnuVer
        '
        Me.mnuVer.Name = "mnuVer"
        Me.mnuVer.Size = New System.Drawing.Size(178, 22)
        Me.mnuVer.Text = "バ－ジョン情報(&A)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSerch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 127)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "抽出条件"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtWoman)
        Me.GroupBox3.Controls.Add(Me.rbtMan)
        Me.GroupBox3.Controls.Add(Me.rbtAll)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 97)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "性別"
        '
        'rbtWoman
        '
        Me.rbtWoman.AutoSize = True
        Me.rbtWoman.Location = New System.Drawing.Point(21, 69)
        Me.rbtWoman.Name = "rbtWoman"
        Me.rbtWoman.Size = New System.Drawing.Size(35, 16)
        Me.rbtWoman.TabIndex = 2
        Me.rbtWoman.TabStop = True
        Me.rbtWoman.Text = "女"
        Me.rbtWoman.UseVisualStyleBackColor = True
        '
        'rbtMan
        '
        Me.rbtMan.AutoSize = True
        Me.rbtMan.Location = New System.Drawing.Point(21, 46)
        Me.rbtMan.Name = "rbtMan"
        Me.rbtMan.Size = New System.Drawing.Size(35, 16)
        Me.rbtMan.TabIndex = 1
        Me.rbtMan.TabStop = True
        Me.rbtMan.Text = "男"
        Me.rbtMan.UseVisualStyleBackColor = True
        '
        'rbtAll
        '
        Me.rbtAll.AutoSize = True
        Me.rbtAll.Location = New System.Drawing.Point(21, 21)
        Me.rbtAll.Name = "rbtAll"
        Me.rbtAll.Size = New System.Drawing.Size(52, 16)
        Me.rbtAll.TabIndex = 0
        Me.rbtAll.TabStop = True
        Me.rbtAll.Text = "すべて"
        Me.rbtAll.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpay2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtPay1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 51)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "時給"
        '
        'txtpay2
        '
        Me.txtpay2.Location = New System.Drawing.Point(113, 18)
        Me.txtpay2.Name = "txtpay2"
        Me.txtpay2.Size = New System.Drawing.Size(59, 19)
        Me.txtpay2.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "時給"
        '
        'txtPay1
        '
        Me.txtPay1.Location = New System.Drawing.Point(37, 18)
        Me.txtPay1.Name = "txtPay1"
        Me.txtPay1.Size = New System.Drawing.Size(54, 19)
        Me.txtPay1.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 12)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "~"
        '
        'btnSerch
        '
        Me.btnSerch.Location = New System.Drawing.Point(342, 67)
        Me.btnSerch.Name = "btnSerch"
        Me.btnSerch.Size = New System.Drawing.Size(75, 23)
        Me.btnSerch.TabIndex = 81
        Me.btnSerch.Text = "Serch"
        Me.btnSerch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "スタッフ名"
        '
        'txtS_name
        '
        Me.txtS_name.Location = New System.Drawing.Point(111, 206)
        Me.txtS_name.Name = "txtS_name"
        Me.txtS_name.Size = New System.Drawing.Size(86, 19)
        Me.txtS_name.TabIndex = 134
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(139, 310)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(29, 12)
        Me.lblSex.TabIndex = 139
        Me.lblSex.Text = "性別"
        '
        'chkS_Resignflag
        '
        Me.chkS_Resignflag.AutoSize = True
        Me.chkS_Resignflag.Location = New System.Drawing.Point(102, 558)
        Me.chkS_Resignflag.Name = "chkS_Resignflag"
        Me.chkS_Resignflag.Size = New System.Drawing.Size(15, 14)
        Me.chkS_Resignflag.TabIndex = 138
        Me.chkS_Resignflag.UseVisualStyleBackColor = True
        '
        'txtS_Phone
        '
        Me.txtS_Phone.Location = New System.Drawing.Point(102, 464)
        Me.txtS_Phone.Name = "txtS_Phone"
        Me.txtS_Phone.Size = New System.Drawing.Size(145, 19)
        Me.txtS_Phone.TabIndex = 137
        '
        'txtS_Resignflag
        '
        Me.txtS_Resignflag.Location = New System.Drawing.Point(102, 511)
        Me.txtS_Resignflag.Name = "txtS_Resignflag"
        Me.txtS_Resignflag.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Resignflag.TabIndex = 136
        '
        'txtS_Secton
        '
        Me.txtS_Secton.Location = New System.Drawing.Point(102, 417)
        Me.txtS_Secton.Name = "txtS_Secton"
        Me.txtS_Secton.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Secton.TabIndex = 135
        '
        'txtS_Hpay
        '
        Me.txtS_Hpay.Location = New System.Drawing.Point(102, 370)
        Me.txtS_Hpay.Name = "txtS_Hpay"
        Me.txtS_Hpay.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Hpay.TabIndex = 133
        Me.txtS_Hpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS_Sex
        '
        Me.txtS_Sex.Location = New System.Drawing.Point(102, 303)
        Me.txtS_Sex.Name = "txtS_Sex"
        Me.txtS_Sex.Size = New System.Drawing.Size(31, 19)
        Me.txtS_Sex.TabIndex = 131
        '
        'txtS_Kana
        '
        Me.txtS_Kana.Location = New System.Drawing.Point(102, 256)
        Me.txtS_Kana.Name = "txtS_Kana"
        Me.txtS_Kana.Size = New System.Drawing.Size(157, 19)
        Me.txtS_Kana.TabIndex = 130
        '
        'txtS_Code
        '
        Me.txtS_Code.Location = New System.Drawing.Point(106, 162)
        Me.txtS_Code.Name = "txtS_Code"
        Me.txtS_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Code.TabIndex = 129
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 514)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 12)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "退社フラグ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 467)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "電話番号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 12)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "所属コ－ド"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "時給"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "性別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "カナ名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 12)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "スタッフコード"
        '
        'frmSelesct4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 581)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtS_name)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.chkS_Resignflag)
        Me.Controls.Add(Me.txtS_Phone)
        Me.Controls.Add(Me.txtS_Resignflag)
        Me.Controls.Add(Me.txtS_Secton)
        Me.Controls.Add(Me.txtS_Hpay)
        Me.Controls.Add(Me.txtS_Sex)
        Me.Controls.Add(Me.txtS_Kana)
        Me.Controls.Add(Me.txtS_Code)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSelesct4"
        Me.Text = "スタッフ管理（デ－タ抽出）"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVer1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtWoman As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMan As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpay2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPay1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSerch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtS_name As System.Windows.Forms.TextBox
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents chkS_Resignflag As System.Windows.Forms.CheckBox
    Friend WithEvents txtS_Phone As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Resignflag As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Secton As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Hpay As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Sex As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Kana As System.Windows.Forms.TextBox
    Friend WithEvents txtS_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
