<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculate
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
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMota = New System.Windows.Forms.Button()
        Me.btnMinuse = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtAfter = New System.Windows.Forms.TextBox()
        Me.txtFront = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(197, 214)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 0
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(218, 132)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(46, 36)
        Me.btnDivide.TabIndex = 1
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMota
        '
        Me.btnMota.Location = New System.Drawing.Point(149, 132)
        Me.btnMota.Name = "btnMota"
        Me.btnMota.Size = New System.Drawing.Size(49, 36)
        Me.btnMota.TabIndex = 2
        Me.btnMota.Text = "*"
        Me.btnMota.UseVisualStyleBackColor = True
        '
        'btnMinuse
        '
        Me.btnMinuse.Location = New System.Drawing.Point(82, 132)
        Me.btnMinuse.Name = "btnMinuse"
        Me.btnMinuse.Size = New System.Drawing.Size(48, 36)
        Me.btnMinuse.TabIndex = 3
        Me.btnMinuse.Text = "-"
        Me.btnMinuse.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 132)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 36)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "四則演算をします"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "="
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.Location = New System.Drawing.Point(91, 55)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(11, 12)
        Me.lblSign.TabIndex = 7
        Me.lblSign.Text = "+"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(218, 51)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(67, 19)
        Me.txtResult.TabIndex = 8
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAfter
        '
        Me.txtAfter.Location = New System.Drawing.Point(113, 52)
        Me.txtAfter.Name = "txtAfter"
        Me.txtAfter.Size = New System.Drawing.Size(65, 19)
        Me.txtAfter.TabIndex = 9
        Me.txtAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFront
        '
        Me.txtFront.Location = New System.Drawing.Point(2, 51)
        Me.txtFront.Name = "txtFront"
        Me.txtFront.Size = New System.Drawing.Size(72, 19)
        Me.txtFront.TabIndex = 10
        Me.txtFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtFront)
        Me.Controls.Add(Me.txtAfter)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnMinuse)
        Me.Controls.Add(Me.btnMota)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnEnd)
        Me.Name = "frmCalculate"
        Me.Text = "frmCalculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMota As System.Windows.Forms.Button
    Friend WithEvents btnMinuse As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSign As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtAfter As System.Windows.Forms.TextBox
    Friend WithEvents txtFront As System.Windows.Forms.TextBox
End Class
