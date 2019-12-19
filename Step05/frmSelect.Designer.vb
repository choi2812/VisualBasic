<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtS_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtPart = New System.Windows.Forms.RadioButton()
        Me.rbtCompleate = New System.Windows.Forms.RadioButton()
        Me.txtS_NameSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSerch = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "スタッフ名"
        '
        'txtS_name
        '
        Me.txtS_name.Location = New System.Drawing.Point(114, 208)
        Me.txtS_name.Name = "txtS_name"
        Me.txtS_name.Size = New System.Drawing.Size(86, 19)
        Me.txtS_name.TabIndex = 97
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtPart)
        Me.GroupBox1.Controls.Add(Me.rbtCompleate)
        Me.GroupBox1.Controls.Add(Me.txtS_NameSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSerch)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 100)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "抽出条件"
        '
        'rbtPart
        '
        Me.rbtPart.AutoSize = True
        Me.rbtPart.Location = New System.Drawing.Point(19, 70)
        Me.rbtPart.Name = "rbtPart"
        Me.rbtPart.Size = New System.Drawing.Size(81, 16)
        Me.rbtPart.TabIndex = 73
        Me.rbtPart.TabStop = True
        Me.rbtPart.Text = "名前の一部"
        Me.rbtPart.UseVisualStyleBackColor = True
        '
        'rbtCompleate
        '
        Me.rbtCompleate.AutoSize = True
        Me.rbtCompleate.Location = New System.Drawing.Point(19, 48)
        Me.rbtCompleate.Name = "rbtCompleate"
        Me.rbtCompleate.Size = New System.Drawing.Size(71, 16)
        Me.rbtCompleate.TabIndex = 72
        Me.rbtCompleate.TabStop = True
        Me.rbtCompleate.Text = "完全一致"
        Me.rbtCompleate.UseVisualStyleBackColor = True
        '
        'txtS_NameSearch
        '
        Me.txtS_NameSearch.Location = New System.Drawing.Point(120, 18)
        Me.txtS_NameSearch.Name = "txtS_NameSearch"
        Me.txtS_NameSearch.Size = New System.Drawing.Size(86, 19)
        Me.txtS_NameSearch.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "スタッフ名"
        '
        'btnSerch
        '
        Me.btnSerch.Location = New System.Drawing.Point(135, 70)
        Me.btnSerch.Name = "btnSerch"
        Me.btnSerch.Size = New System.Drawing.Size(75, 23)
        Me.btnSerch.TabIndex = 81
        Me.btnSerch.Text = "Serch"
        Me.btnSerch.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(350, 546)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 103
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(142, 312)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(29, 12)
        Me.lblSex.TabIndex = 102
        Me.lblSex.Text = "性別"
        '
        'chkS_Resignflag
        '
        Me.chkS_Resignflag.AutoSize = True
        Me.chkS_Resignflag.Location = New System.Drawing.Point(105, 560)
        Me.chkS_Resignflag.Name = "chkS_Resignflag"
        Me.chkS_Resignflag.Size = New System.Drawing.Size(15, 14)
        Me.chkS_Resignflag.TabIndex = 101
        Me.chkS_Resignflag.UseVisualStyleBackColor = True
        '
        'txtS_Phone
        '
        Me.txtS_Phone.Location = New System.Drawing.Point(105, 466)
        Me.txtS_Phone.Name = "txtS_Phone"
        Me.txtS_Phone.Size = New System.Drawing.Size(145, 19)
        Me.txtS_Phone.TabIndex = 100
        '
        'txtS_Resignflag
        '
        Me.txtS_Resignflag.Location = New System.Drawing.Point(105, 513)
        Me.txtS_Resignflag.Name = "txtS_Resignflag"
        Me.txtS_Resignflag.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Resignflag.TabIndex = 99
        '
        'txtS_Secton
        '
        Me.txtS_Secton.Location = New System.Drawing.Point(105, 419)
        Me.txtS_Secton.Name = "txtS_Secton"
        Me.txtS_Secton.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Secton.TabIndex = 98
        '
        'txtS_Hpay
        '
        Me.txtS_Hpay.Location = New System.Drawing.Point(105, 372)
        Me.txtS_Hpay.Name = "txtS_Hpay"
        Me.txtS_Hpay.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Hpay.TabIndex = 96
        Me.txtS_Hpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS_Sex
        '
        Me.txtS_Sex.Location = New System.Drawing.Point(105, 305)
        Me.txtS_Sex.Name = "txtS_Sex"
        Me.txtS_Sex.Size = New System.Drawing.Size(31, 19)
        Me.txtS_Sex.TabIndex = 94
        '
        'txtS_Kana
        '
        Me.txtS_Kana.Location = New System.Drawing.Point(105, 258)
        Me.txtS_Kana.Name = "txtS_Kana"
        Me.txtS_Kana.Size = New System.Drawing.Size(157, 19)
        Me.txtS_Kana.TabIndex = 93
        '
        'txtS_Code
        '
        Me.txtS_Code.Location = New System.Drawing.Point(105, 164)
        Me.txtS_Code.Name = "txtS_Code"
        Me.txtS_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Code.TabIndex = 92
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 516)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 12)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "退社フラグ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "電話番号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 422)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 12)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "所属コ－ド"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "時給"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "性別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "カナ名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "スタッフコード"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.表示ToolStripMenuItem, Me.ヘルプToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 26)
        Me.MenuStrip1.TabIndex = 105
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルToolStripMenuItem.Text = "ファイル(&F)"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(118, 22)
        Me.mnuClose.Text = "終了(&X)"
        '
        '表示ToolStripMenuItem
        '
        Me.表示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNext, Me.mnuClear})
        Me.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem"
        Me.表示ToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.表示ToolStripMenuItem.Text = "表示(&V)"
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
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVer})
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'mnuVer
        '
        Me.mnuVer.Name = "mnuVer"
        Me.mnuVer.Size = New System.Drawing.Size(178, 22)
        Me.mnuVer.Text = "バ－ジョン情報(&A)"
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 583)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtS_name)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEnd)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSelect"
        Me.Text = "スタッフ管理（デ－タ抽出）"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtS_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtPart As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompleate As System.Windows.Forms.RadioButton
    Friend WithEvents txtS_NameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSerch As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVer As System.Windows.Forms.ToolStripMenuItem

End Class
