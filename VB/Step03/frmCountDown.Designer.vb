<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountDown
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
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.txtLeftMinute = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.txtLeftMinutes = New System.Windows.Forms.TextBox()
        Me.txtLeftSecends = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(91, 33)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(48, 19)
        Me.txtSeconds.TabIndex = 0
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinute
        '
        Me.txtMinute.Location = New System.Drawing.Point(12, 33)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(50, 19)
        Me.txtMinute.TabIndex = 1
        Me.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLeftMinute
        '
        Me.txtLeftMinute.Location = New System.Drawing.Point(100, 114)
        Me.txtLeftMinute.Name = "txtLeftMinute"
        Me.txtLeftMinute.Size = New System.Drawing.Size(74, 19)
        Me.txtLeftMinute.TabIndex = 2
        Me.txtLeftMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(197, 31)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "スタ-ト"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(208, 208)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(52, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "秒"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "あと"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "秒"
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Interval = 1000
        '
        'txtLeftMinutes
        '
        Me.txtLeftMinutes.Location = New System.Drawing.Point(28, 173)
        Me.txtLeftMinutes.Name = "txtLeftMinutes"
        Me.txtLeftMinutes.Size = New System.Drawing.Size(73, 19)
        Me.txtLeftMinutes.TabIndex = 9
        Me.txtLeftMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLeftSecends
        '
        Me.txtLeftSecends.Location = New System.Drawing.Point(144, 173)
        Me.txtLeftSecends.Name = "txtLeftSecends"
        Me.txtLeftSecends.Size = New System.Drawing.Size(62, 19)
        Me.txtLeftSecends.TabIndex = 10
        Me.txtLeftSecends.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "分"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "秒"
        '
        'frmCountDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLeftSecends)
        Me.Controls.Add(Me.txtLeftMinutes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtLeftMinute)
        Me.Controls.Add(Me.txtMinute)
        Me.Controls.Add(Me.txtSeconds)
        Me.Name = "frmCountDown"
        Me.Text = "カウントダウンタイマ-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtMinute As System.Windows.Forms.TextBox
    Friend WithEvents txtLeftMinute As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmrCountDown As System.Windows.Forms.Timer
    Friend WithEvents txtLeftMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtLeftSecends As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
