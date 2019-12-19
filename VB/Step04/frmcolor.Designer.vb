<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcolor
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
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtgreen = New System.Windows.Forms.RadioButton()
        Me.rbtYellow = New System.Windows.Forms.RadioButton()
        Me.rbtRed = New System.Windows.Forms.RadioButton()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(197, 227)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'picBack
        '
        Me.picBack.Location = New System.Drawing.Point(37, 76)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 73)
        Me.picBack.TabIndex = 3
        Me.picBack.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtRed)
        Me.GroupBox1.Controls.Add(Me.rbtYellow)
        Me.GroupBox1.Controls.Add(Me.rbtgreen)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(81, 110)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'rbtgreen
        '
        Me.rbtgreen.AutoSize = True
        Me.rbtgreen.Location = New System.Drawing.Point(3, 15)
        Me.rbtgreen.Name = "rbtgreen"
        Me.rbtgreen.Size = New System.Drawing.Size(35, 16)
        Me.rbtgreen.TabIndex = 0
        Me.rbtgreen.TabStop = True
        Me.rbtgreen.Text = "緑"
        Me.rbtgreen.UseVisualStyleBackColor = True
        '
        'rbtYellow
        '
        Me.rbtYellow.AutoSize = True
        Me.rbtYellow.Location = New System.Drawing.Point(3, 48)
        Me.rbtYellow.Name = "rbtYellow"
        Me.rbtYellow.Size = New System.Drawing.Size(35, 16)
        Me.rbtYellow.TabIndex = 1
        Me.rbtYellow.TabStop = True
        Me.rbtYellow.Text = "黄"
        Me.rbtYellow.UseVisualStyleBackColor = True
        '
        'rbtRed
        '
        Me.rbtRed.AutoSize = True
        Me.rbtRed.Location = New System.Drawing.Point(5, 79)
        Me.rbtRed.Name = "rbtRed"
        Me.rbtRed.Size = New System.Drawing.Size(35, 16)
        Me.rbtRed.TabIndex = 2
        Me.rbtRed.TabStop = True
        Me.rbtRed.Text = "赤"
        Me.rbtRed.UseVisualStyleBackColor = True
        '
        'frmcolor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "frmcolor"
        Me.Text = "信号"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbtYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rbtgreen As System.Windows.Forms.RadioButton
End Class
