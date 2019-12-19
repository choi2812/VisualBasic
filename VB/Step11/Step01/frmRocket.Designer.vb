<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRocket
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
        Me.tmrRocket = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picRocket = New System.Windows.Forms.PictureBox()
        Me.tmrRocket2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRocket
        '
        Me.tmrRocket.Enabled = True
        Me.tmrRocket.Interval = 50
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Location = New System.Drawing.Point(303, 493)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picRocket
        '
        Me.picRocket.BackColor = System.Drawing.Color.White
        Me.picRocket.Image = Global.Step01.My.Resources.Resources.Rocket_s1
        Me.picRocket.Location = New System.Drawing.Point(148, 465)
        Me.picRocket.Name = "picRocket"
        Me.picRocket.Size = New System.Drawing.Size(82, 98)
        Me.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRocket.TabIndex = 0
        Me.picRocket.TabStop = False
        '
        'tmrRocket2
        '
        Me.tmrRocket2.Interval = 5
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(303, 540)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmRocket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(390, 575)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picRocket)
        Me.Name = "frmRocket"
        Me.Text = "ロケット発射"
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRocket As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRocket As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents tmrRocket2 As System.Windows.Forms.Timer
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
