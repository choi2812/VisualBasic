<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImgChange
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
        Me.btnRocket = New System.Windows.Forms.Button()
        Me.btnExplosion = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRocket
        '
        Me.btnRocket.Location = New System.Drawing.Point(197, 508)
        Me.btnRocket.Name = "btnRocket"
        Me.btnRocket.Size = New System.Drawing.Size(75, 23)
        Me.btnRocket.TabIndex = 2
        Me.btnRocket.Text = "ロケット"
        Me.btnRocket.UseVisualStyleBackColor = True
        '
        'btnExplosion
        '
        Me.btnExplosion.Location = New System.Drawing.Point(197, 561)
        Me.btnExplosion.Name = "btnExplosion"
        Me.btnExplosion.Size = New System.Drawing.Size(75, 23)
        Me.btnExplosion.TabIndex = 3
        Me.btnExplosion.Text = "爆発"
        Me.btnExplosion.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(197, 619)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "終了"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.White
        Me.picImage.Image = Global.Step02.My.Resources.Resources.Rocket_s11
        Me.picImage.Location = New System.Drawing.Point(90, 522)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(83, 108)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 1
        Me.picImage.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(47, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "状態"
        '
        'frmImgChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 665)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExplosion)
        Me.Controls.Add(Me.btnRocket)
        Me.Controls.Add(Me.picImage)
        Me.Name = "frmImgChange"
        Me.Text = "画像の変更"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnRocket As System.Windows.Forms.Button
    Friend WithEvents btnExplosion As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
