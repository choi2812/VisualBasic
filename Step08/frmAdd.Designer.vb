<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.txtS_Name = New System.Windows.Forms.TextBox()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.chkS_Resignflag = New System.Windows.Forms.CheckBox()
        Me.txtS_Phone = New System.Windows.Forms.TextBox()
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbS_Section = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "スタッフ名"
        '
        'txtS_Name
        '
        Me.txtS_Name.Location = New System.Drawing.Point(114, 89)
        Me.txtS_Name.Name = "txtS_Name"
        Me.txtS_Name.Size = New System.Drawing.Size(86, 19)
        Me.txtS_Name.TabIndex = 139
        '
        'btnmodify
        '
        Me.btnmodify.Location = New System.Drawing.Point(350, 521)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(75, 23)
        Me.btnmodify.TabIndex = 144
        Me.btnmodify.Text = "変更"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'chkS_Resignflag
        '
        Me.chkS_Resignflag.AutoSize = True
        Me.chkS_Resignflag.Location = New System.Drawing.Point(105, 397)
        Me.chkS_Resignflag.Name = "chkS_Resignflag"
        Me.chkS_Resignflag.Size = New System.Drawing.Size(15, 14)
        Me.chkS_Resignflag.TabIndex = 142
        Me.chkS_Resignflag.UseVisualStyleBackColor = True
        '
        'txtS_Phone
        '
        Me.txtS_Phone.Location = New System.Drawing.Point(105, 347)
        Me.txtS_Phone.Name = "txtS_Phone"
        Me.txtS_Phone.Size = New System.Drawing.Size(145, 19)
        Me.txtS_Phone.TabIndex = 141
        '
        'txtS_Hpay
        '
        Me.txtS_Hpay.Location = New System.Drawing.Point(105, 253)
        Me.txtS_Hpay.Name = "txtS_Hpay"
        Me.txtS_Hpay.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Hpay.TabIndex = 138
        Me.txtS_Hpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtS_Sex
        '
        Me.txtS_Sex.Location = New System.Drawing.Point(105, 186)
        Me.txtS_Sex.Name = "txtS_Sex"
        Me.txtS_Sex.Size = New System.Drawing.Size(31, 19)
        Me.txtS_Sex.TabIndex = 136
        '
        'txtS_Kana
        '
        Me.txtS_Kana.Location = New System.Drawing.Point(105, 139)
        Me.txtS_Kana.Name = "txtS_Kana"
        Me.txtS_Kana.Size = New System.Drawing.Size(157, 19)
        Me.txtS_Kana.TabIndex = 135
        '
        'txtS_Code
        '
        Me.txtS_Code.Location = New System.Drawing.Point(105, 45)
        Me.txtS_Code.Name = "txtS_Code"
        Me.txtS_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtS_Code.TabIndex = 134
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 12)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "退社フラグ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "電話番号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 12)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "所属コ－ド"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "時給"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "性別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 12)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "カナ名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "スタッフコード"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 26)
        Me.MenuStrip1.TabIndex = 146
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
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(369, 422)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 147
        Me.btnAdd.Text = "登録"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbS_Section
        '
        Me.cmbS_Section.FormattingEnabled = True
        Me.cmbS_Section.Location = New System.Drawing.Point(99, 300)
        Me.cmbS_Section.Name = "cmbS_Section"
        Me.cmbS_Section.Size = New System.Drawing.Size(121, 20)
        Me.cmbS_Section.TabIndex = 148
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 520)
        Me.Controls.Add(Me.cmbS_Section)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtS_Name)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.chkS_Resignflag)
        Me.Controls.Add(Me.txtS_Phone)
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
        Me.Name = "frmAdd"
        Me.Text = "スタッフ登録処理"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtS_Name As System.Windows.Forms.TextBox
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents chkS_Resignflag As System.Windows.Forms.CheckBox
    Friend WithEvents txtS_Phone As System.Windows.Forms.TextBox
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
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cmbS_Section As System.Windows.Forms.ComboBox

End Class
