<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJoin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFull = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "2つの文字列を結合します"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "姓"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "名"
        '
        'txtGiven
        '
        Me.txtGiven.Location = New System.Drawing.Point(177, 57)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(100, 19)
        Me.txtGiven.TabIndex = 3
        '
        'txtFamily
        '
        Me.txtFamily.Location = New System.Drawing.Point(35, 57)
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(100, 19)
        Me.txtFamily.TabIndex = 4
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(35, 114)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(75, 23)
        Me.btnMerge.TabIndex = 5
        Me.btnMerge.Text = "結合"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "姓名"
        '
        'txtFull
        '
        Me.txtFull.Location = New System.Drawing.Point(35, 208)
        Me.txtFull.Name = "txtFull"
        Me.txtFull.Size = New System.Drawing.Size(100, 19)
        Me.txtFull.TabIndex = 7
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(202, 206)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtFull)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.txtFamily)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJoin"
        Me.Text = "文字の結合"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGiven As System.Windows.Forms.TextBox
    Friend WithEvents txtFamily As System.Windows.Forms.TextBox
    Friend WithEvents btnMerge As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFull As System.Windows.Forms.TextBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
End Class
