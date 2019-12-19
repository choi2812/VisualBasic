<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlot
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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCoin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtFast = New System.Windows.Forms.RadioButton()
        Me.rbtNormal = New System.Windows.Forms.RadioButton()
        Me.rbtSlow = New System.Windows.Forms.RadioButton()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(99, 287)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "スタ-ト"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(99, 327)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "チェック"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(196, 393)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Yellow
        Me.lbl1.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(26, 59)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(67, 110)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "0"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Yellow
        Me.lbl2.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(114, 59)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(60, 110)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "0"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Yellow
        Me.lbl3.Font = New System.Drawing.Font("MS UI Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl3.Location = New System.Drawing.Point(201, 59)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(59, 110)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "0"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic1
        '
        Me.pic1.Image = Global.Step07.My.Resources.Resources.Button_Red
        Me.pic1.Location = New System.Drawing.Point(30, 195)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(63, 50)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 9
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.Image = Global.Step07.My.Resources.Resources.Button_Red
        Me.pic2.Location = New System.Drawing.Point(118, 195)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(56, 50)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 10
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Image = Global.Step07.My.Resources.Resources.Button_Red
        Me.pic3.Location = New System.Drawing.Point(205, 195)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(55, 50)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 11
        Me.pic3.TabStop = False
        '
        'tmr1
        '
        Me.tmr1.Interval = 1200
        '
        'tmr2
        '
        Me.tmr2.Interval = 1200
        '
        'tmr3
        '
        Me.tmr3.Interval = 1200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "コイン"
        '
        'txtCoin
        '
        Me.txtCoin.Location = New System.Drawing.Point(99, 19)
        Me.txtCoin.Name = "txtCoin"
        Me.txtCoin.Size = New System.Drawing.Size(100, 19)
        Me.txtCoin.TabIndex = 13
        Me.txtCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtFast)
        Me.GroupBox1.Controls.Add(Me.rbtNormal)
        Me.GroupBox1.Controls.Add(Me.rbtSlow)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定"
        '
        'rbtFast
        '
        Me.rbtFast.AutoSize = True
        Me.rbtFast.Location = New System.Drawing.Point(0, 65)
        Me.rbtFast.Name = "rbtFast"
        Me.rbtFast.Size = New System.Drawing.Size(47, 16)
        Me.rbtFast.TabIndex = 2
        Me.rbtFast.TabStop = True
        Me.rbtFast.Text = "上級"
        Me.rbtFast.UseVisualStyleBackColor = True
        '
        'rbtNormal
        '
        Me.rbtNormal.AutoSize = True
        Me.rbtNormal.Location = New System.Drawing.Point(0, 40)
        Me.rbtNormal.Name = "rbtNormal"
        Me.rbtNormal.Size = New System.Drawing.Size(47, 16)
        Me.rbtNormal.TabIndex = 1
        Me.rbtNormal.TabStop = True
        Me.rbtNormal.Text = "中級"
        Me.rbtNormal.UseVisualStyleBackColor = True
        '
        'rbtSlow
        '
        Me.rbtSlow.AutoSize = True
        Me.rbtSlow.Location = New System.Drawing.Point(0, 18)
        Me.rbtSlow.Name = "rbtSlow"
        Me.rbtSlow.Size = New System.Drawing.Size(47, 16)
        Me.rbtSlow.TabIndex = 0
        Me.rbtSlow.TabStop = True
        Me.rbtSlow.Text = "初級"
        Me.rbtSlow.UseVisualStyleBackColor = True
        '
        'frmSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCoin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmSlot"
        Me.Text = "frmSlot"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents tmr3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCoin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFast As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSlow As System.Windows.Forms.RadioButton
End Class
