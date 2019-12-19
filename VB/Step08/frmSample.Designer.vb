<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSample
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
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.btnDay = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtWa = New System.Windows.Forms.TextBox()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "入力月"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "最終日"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(173, 131)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 19)
        Me.txtDays.TabIndex = 2
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(173, 67)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 19)
        Me.txtMonth.TabIndex = 3
        '
        'btnDay
        '
        Me.btnDay.Location = New System.Drawing.Point(92, 173)
        Me.btnDay.Name = "btnDay"
        Me.btnDay.Size = New System.Drawing.Size(75, 23)
        Me.btnDay.TabIndex = 4
        Me.btnDay.Text = "最終日"
        Me.btnDay.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "までの和"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "から"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(144, 233)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(76, 19)
        Me.txtTo.TabIndex = 7
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(12, 229)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(83, 19)
        Me.txtFrom.TabIndex = 8
        '
        'txtWa
        '
        Me.txtWa.Location = New System.Drawing.Point(279, 233)
        Me.txtWa.Name = "txtWa"
        Me.txtWa.Size = New System.Drawing.Size(63, 19)
        Me.txtWa.TabIndex = 9
        '
        'btnWhile
        '
        Me.btnWhile.Location = New System.Drawing.Point(49, 296)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(75, 23)
        Me.btnWhile.TabIndex = 10
        Me.btnWhile.Text = "while"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(157, 296)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(75, 24)
        Me.btnDoWhile.TabIndex = 11
        Me.btnDoWhile.Text = "Dowhile"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(254, 297)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(75, 23)
        Me.btnDoUntil.TabIndex = 12
        Me.btnDoUntil.Text = "Dountil"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'frmSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 403)
        Me.Controls.Add(Me.btnDoUntil)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnWhile)
        Me.Controls.Add(Me.txtWa)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSample"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents btnDay As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtWa As System.Windows.Forms.TextBox
    Friend WithEvents btnWhile As System.Windows.Forms.Button
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button
    Friend WithEvents btnDoUntil As System.Windows.Forms.Button

End Class
