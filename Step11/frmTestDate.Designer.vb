<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestDate
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNow = New System.Windows.Forms.TextBox()
        Me.txtT_Date2 = New System.Windows.Forms.TextBox()
        Me.txtT_Date1 = New System.Windows.Forms.TextBox()
        Me.txtR_Date = New System.Windows.Forms.TextBox()
        Me.txtRental = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "今日の日付"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "レンタル日数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 12)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "返却日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DBのt_date1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DBのt_date2"
        '
        'txtNow
        '
        Me.txtNow.Location = New System.Drawing.Point(154, 64)
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Size = New System.Drawing.Size(100, 19)
        Me.txtNow.TabIndex = 6
        '
        'txtT_Date2
        '
        Me.txtT_Date2.Location = New System.Drawing.Point(154, 252)
        Me.txtT_Date2.Name = "txtT_Date2"
        Me.txtT_Date2.Size = New System.Drawing.Size(100, 19)
        Me.txtT_Date2.TabIndex = 8
        '
        'txtT_Date1
        '
        Me.txtT_Date1.Location = New System.Drawing.Point(154, 198)
        Me.txtT_Date1.Name = "txtT_Date1"
        Me.txtT_Date1.Size = New System.Drawing.Size(100, 19)
        Me.txtT_Date1.TabIndex = 9
        '
        'txtR_Date
        '
        Me.txtR_Date.Location = New System.Drawing.Point(154, 153)
        Me.txtR_Date.Name = "txtR_Date"
        Me.txtR_Date.Size = New System.Drawing.Size(100, 19)
        Me.txtR_Date.TabIndex = 10
        '
        'txtRental
        '
        Me.txtRental.Location = New System.Drawing.Point(156, 112)
        Me.txtRental.Name = "txtRental"
        Me.txtRental.Size = New System.Drawing.Size(100, 19)
        Me.txtRental.TabIndex = 11
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(204, 295)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 12
        Me.btnChange.Text = "返新"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(285, 295)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 24)
        Me.btnEnd.TabIndex = 13
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmTestDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 594)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtRental)
        Me.Controls.Add(Me.txtR_Date)
        Me.Controls.Add(Me.txtT_Date1)
        Me.Controls.Add(Me.txtT_Date2)
        Me.Controls.Add(Me.txtNow)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTestDate"
        Me.Text = "日付操作サンプル"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNow As System.Windows.Forms.TextBox
    Friend WithEvents txtT_Date2 As System.Windows.Forms.TextBox
    Friend WithEvents txtT_Date1 As System.Windows.Forms.TextBox
    Friend WithEvents txtR_Date As System.Windows.Forms.TextBox
    Friend WithEvents txtRental As System.Windows.Forms.TextBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
