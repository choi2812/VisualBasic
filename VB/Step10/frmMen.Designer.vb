<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMen
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
        Me.btnCaculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtLong = New System.Windows.Forms.TextBox()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(216, 334)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnCaculate
        '
        Me.btnCaculate.Location = New System.Drawing.Point(216, 92)
        Me.btnCaculate.Name = "btnCaculate"
        Me.btnCaculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCaculate.TabIndex = 1
        Me.btnCaculate.Text = "計算"
        Me.btnCaculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "面積"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "円周"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "半径"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(80, 258)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 19)
        Me.txtArea.TabIndex = 5
        Me.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLong
        '
        Me.txtLong.Location = New System.Drawing.Point(80, 166)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(100, 19)
        Me.txtLong.TabIndex = 6
        Me.txtLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(80, 92)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 19)
        Me.txtRadius.TabIndex = 7
        Me.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmMen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 415)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.txtLong)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCaculate)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "frmMen"
        Me.Text = "frmMen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnCaculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtLong As System.Windows.Forms.TextBox
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
End Class
