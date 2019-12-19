<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKingaku1 = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnKin1 = New System.Windows.Forms.Button()
        Me.btnKin2 = New System.Windows.Forms.Button()
        Me.txtKingaku2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "元金"
        '
        'txtKingaku1
        '
        Me.txtKingaku1.Location = New System.Drawing.Point(59, 84)
        Me.txtKingaku1.Name = "txtKingaku1"
        Me.txtKingaku1.Size = New System.Drawing.Size(100, 19)
        Me.txtKingaku1.TabIndex = 1
        Me.txtKingaku1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(224, 357)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnKin1
        '
        Me.btnKin1.Location = New System.Drawing.Point(224, 80)
        Me.btnKin1.Name = "btnKin1"
        Me.btnKin1.Size = New System.Drawing.Size(75, 23)
        Me.btnKin1.TabIndex = 5
        Me.btnKin1.Text = "倍額(サブ)"
        Me.btnKin1.UseVisualStyleBackColor = True
        '
        'btnKin2
        '
        Me.btnKin2.Location = New System.Drawing.Point(224, 167)
        Me.btnKin2.Name = "btnKin2"
        Me.btnKin2.Size = New System.Drawing.Size(75, 23)
        Me.btnKin2.TabIndex = 8
        Me.btnKin2.Text = "倍額(関数)"
        Me.btnKin2.UseVisualStyleBackColor = True
        '
        'txtKingaku2
        '
        Me.txtKingaku2.Location = New System.Drawing.Point(59, 167)
        Me.txtKingaku2.Name = "txtKingaku2"
        Me.txtKingaku2.Size = New System.Drawing.Size(100, 19)
        Me.txtKingaku2.TabIndex = 7
        Me.txtKingaku2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "元金"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 433)
        Me.Controls.Add(Me.btnKin2)
        Me.Controls.Add(Me.txtKingaku2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnKin1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtKingaku1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKingaku1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnKin1 As System.Windows.Forms.Button
    Friend WithEvents btnKin2 As System.Windows.Forms.Button
    Friend WithEvents txtKingaku2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
