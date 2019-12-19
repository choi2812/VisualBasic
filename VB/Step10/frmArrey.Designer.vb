<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrey
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArrey = New System.Windows.Forms.TextBox()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(238, 204)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 9
        Me.btnChange.Text = "交換"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "B"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(163, 208)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(69, 19)
        Me.txtB.TabIndex = 6
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(40, 206)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(71, 19)
        Me.txtA.TabIndex = 5
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "配列"
        '
        'txtArrey
        '
        Me.txtArrey.Location = New System.Drawing.Point(47, 265)
        Me.txtArrey.Name = "txtArrey"
        Me.txtArrey.Size = New System.Drawing.Size(201, 19)
        Me.txtArrey.TabIndex = 11
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(119, 312)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(100, 19)
        Me.txtSum.TabIndex = 12
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(14, 308)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 23)
        Me.btnSum.TabIndex = 13
        Me.btnSum.Text = "合計"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'frmArrey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 508)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.txtArrey)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Name = "frmArrey"
        Me.Text = "frmArrey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArrey As System.Windows.Forms.TextBox
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents btnSum As System.Windows.Forms.Button
End Class
