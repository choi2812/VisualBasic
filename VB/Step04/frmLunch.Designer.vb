<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunch
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
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.txtRice = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtChiken = New System.Windows.Forms.RadioButton()
        Me.rbtSteak = New System.Windows.Forms.RadioButton()
        Me.rbtHamberger = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtBread = New System.Windows.Forms.RadioButton()
        Me.rbtRice = New System.Windows.Forms.RadioButton()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.picRice = New System.Windows.Forms.PictureBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkCake = New System.Windows.Forms.CheckBox()
        Me.chkDrink = New System.Windows.Forms.CheckBox()
        Me.chkSalad = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(29, 164)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(100, 19)
        Me.txtMain.TabIndex = 0
        '
        'txtRice
        '
        Me.txtRice.Location = New System.Drawing.Point(148, 164)
        Me.txtRice.Name = "txtRice"
        Me.txtRice.Size = New System.Drawing.Size(100, 19)
        Me.txtRice.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtChiken)
        Me.GroupBox1.Controls.Add(Me.rbtSteak)
        Me.GroupBox1.Controls.Add(Me.rbtHamberger)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "メイン"
        '
        'rbtChiken
        '
        Me.rbtChiken.AutoSize = True
        Me.rbtChiken.Location = New System.Drawing.Point(0, 110)
        Me.rbtChiken.Name = "rbtChiken"
        Me.rbtChiken.Size = New System.Drawing.Size(75, 16)
        Me.rbtChiken.TabIndex = 4
        Me.rbtChiken.TabStop = True
        Me.rbtChiken.Text = "チキンソテ-"
        Me.rbtChiken.UseVisualStyleBackColor = True
        '
        'rbtSteak
        '
        Me.rbtSteak.AutoSize = True
        Me.rbtSteak.Location = New System.Drawing.Point(0, 64)
        Me.rbtSteak.Name = "rbtSteak"
        Me.rbtSteak.Size = New System.Drawing.Size(57, 16)
        Me.rbtSteak.TabIndex = 3
        Me.rbtSteak.TabStop = True
        Me.rbtSteak.Text = "ステ-キ"
        Me.rbtSteak.UseVisualStyleBackColor = True
        '
        'rbtHamberger
        '
        Me.rbtHamberger.AutoSize = True
        Me.rbtHamberger.Location = New System.Drawing.Point(0, 18)
        Me.rbtHamberger.Name = "rbtHamberger"
        Me.rbtHamberger.Size = New System.Drawing.Size(67, 16)
        Me.rbtHamberger.TabIndex = 2
        Me.rbtHamberger.TabStop = True
        Me.rbtHamberger.Text = "ハンバ-グ"
        Me.rbtHamberger.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(119, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(84, 140)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ライス.パン"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(172, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 133)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtBread)
        Me.GroupBox4.Controls.Add(Me.rbtRice)
        Me.GroupBox4.Location = New System.Drawing.Point(148, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(94, 118)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ライス.パン"
        '
        'rbtBread
        '
        Me.rbtBread.AutoSize = True
        Me.rbtBread.Location = New System.Drawing.Point(2, 56)
        Me.rbtBread.Name = "rbtBread"
        Me.rbtBread.Size = New System.Drawing.Size(42, 16)
        Me.rbtBread.TabIndex = 1
        Me.rbtBread.TabStop = True
        Me.rbtBread.Text = "パン"
        Me.rbtBread.UseVisualStyleBackColor = True
        '
        'rbtRice
        '
        Me.rbtRice.AutoSize = True
        Me.rbtRice.Location = New System.Drawing.Point(3, 15)
        Me.rbtRice.Name = "rbtRice"
        Me.rbtRice.Size = New System.Drawing.Size(49, 16)
        Me.rbtRice.TabIndex = 0
        Me.rbtRice.TabStop = True
        Me.rbtRice.Text = "ライス"
        Me.rbtRice.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(325, 311)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'picMain
        '
        Me.picMain.Location = New System.Drawing.Point(26, 205)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(100, 50)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 5
        Me.picMain.TabStop = False
        '
        'picRice
        '
        Me.picRice.Location = New System.Drawing.Point(151, 205)
        Me.picRice.Name = "picRice"
        Me.picRice.Size = New System.Drawing.Size(100, 50)
        Me.picRice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRice.TabIndex = 6
        Me.picRice.TabStop = False
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(26, 271)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(81, 16)
        Me.chkDiscount.TabIndex = 7
        Me.chkDiscount.Text = "割引チケット"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(12, 286)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "チェック"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "合計"
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(138, 288)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(54, 19)
        Me.txtSum.TabIndex = 10
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "円"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkCake)
        Me.GroupBox5.Controls.Add(Me.chkDrink)
        Me.GroupBox5.Controls.Add(Me.chkSalad)
        Me.GroupBox5.Location = New System.Drawing.Point(275, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(114, 121)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "オプション"
        '
        'chkCake
        '
        Me.chkCake.AutoSize = True
        Me.chkCake.Location = New System.Drawing.Point(6, 99)
        Me.chkCake.Name = "chkCake"
        Me.chkCake.Size = New System.Drawing.Size(49, 16)
        Me.chkCake.TabIndex = 2
        Me.chkCake.Text = "ケ-キ"
        Me.chkCake.UseVisualStyleBackColor = True
        '
        'chkDrink
        '
        Me.chkDrink.AutoSize = True
        Me.chkDrink.Location = New System.Drawing.Point(6, 56)
        Me.chkDrink.Name = "chkDrink"
        Me.chkDrink.Size = New System.Drawing.Size(63, 16)
        Me.chkDrink.TabIndex = 1
        Me.chkDrink.Text = "ドリンク-"
        Me.chkDrink.UseVisualStyleBackColor = True
        '
        'chkSalad
        '
        Me.chkSalad.AutoSize = True
        Me.chkSalad.Location = New System.Drawing.Point(6, 18)
        Me.chkSalad.Name = "chkSalad"
        Me.chkSalad.Size = New System.Drawing.Size(51, 16)
        Me.chkSalad.TabIndex = 0
        Me.chkSalad.Text = "サラダ"
        Me.chkSalad.UseVisualStyleBackColor = True
        '
        'frmLunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 346)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.picRice)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRice)
        Me.Controls.Add(Me.txtMain)
        Me.Name = "frmLunch"
        Me.Text = "定食メニュ-"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents txtRice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtChiken As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSteak As System.Windows.Forms.RadioButton
    Friend WithEvents rbtHamberger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBread As System.Windows.Forms.RadioButton
    Friend WithEvents rbtRice As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents picRice As System.Windows.Forms.PictureBox
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCake As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrink As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalad As System.Windows.Forms.CheckBox
End Class
