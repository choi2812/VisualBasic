<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Me.lstAttend = New System.Windows.Forms.ListBox()
        Me.lstAbsent = New System.Windows.Forms.ListBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnAllLeft = New System.Windows.Forms.Button()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstLate = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRight1 = New System.Windows.Forms.Button()
        Me.btnLeft1 = New System.Windows.Forms.Button()
        Me.btnAllLeft1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "出席者"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "欠席者"
        '
        'lstAttend
        '
        Me.lstAttend.FormattingEnabled = True
        Me.lstAttend.ItemHeight = 12
        Me.lstAttend.Items.AddRange(New Object() {"サイ", "ピオ", "ナイン", "由香里", "Black-b"})
        Me.lstAttend.Location = New System.Drawing.Point(12, 74)
        Me.lstAttend.Name = "lstAttend"
        Me.lstAttend.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAttend.Size = New System.Drawing.Size(120, 100)
        Me.lstAttend.TabIndex = 2
        '
        'lstAbsent
        '
        Me.lstAbsent.FormattingEnabled = True
        Me.lstAbsent.ItemHeight = 12
        Me.lstAbsent.Location = New System.Drawing.Point(219, 74)
        Me.lstAbsent.Name = "lstAbsent"
        Me.lstAbsent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAbsent.Size = New System.Drawing.Size(120, 100)
        Me.lstAbsent.TabIndex = 3
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(461, 287)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(138, 74)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 5
        Me.btnRight.Text = "→"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(138, 103)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "←"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnAllLeft
        '
        Me.btnAllLeft.Location = New System.Drawing.Point(138, 151)
        Me.btnAllLeft.Name = "btnAllLeft"
        Me.btnAllLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnAllLeft.TabIndex = 7
        Me.btnAllLeft.Text = "<<"
        Me.btnAllLeft.UseVisualStyleBackColor = True
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(254, 218)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(60, 19)
        Me.txtPerson.TabIndex = 8
        Me.txtPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "人"
        '
        'lstLate
        '
        Me.lstLate.FormattingEnabled = True
        Me.lstLate.ItemHeight = 12
        Me.lstLate.Location = New System.Drawing.Point(416, 74)
        Me.lstLate.Name = "lstLate"
        Me.lstLate.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstLate.Size = New System.Drawing.Size(120, 100)
        Me.lstLate.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "遅刻.早退者"
        '
        'btnRight1
        '
        Me.btnRight1.Location = New System.Drawing.Point(345, 74)
        Me.btnRight1.Name = "btnRight1"
        Me.btnRight1.Size = New System.Drawing.Size(75, 23)
        Me.btnRight1.TabIndex = 12
        Me.btnRight1.Text = "→"
        Me.btnRight1.UseVisualStyleBackColor = True
        '
        'btnLeft1
        '
        Me.btnLeft1.Location = New System.Drawing.Point(345, 103)
        Me.btnLeft1.Name = "btnLeft1"
        Me.btnLeft1.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft1.TabIndex = 13
        Me.btnLeft1.Text = "←"
        Me.btnLeft1.UseVisualStyleBackColor = True
        '
        'btnAllLeft1
        '
        Me.btnAllLeft1.Location = New System.Drawing.Point(345, 151)
        Me.btnAllLeft1.Name = "btnAllLeft1"
        Me.btnAllLeft1.Size = New System.Drawing.Size(75, 23)
        Me.btnAllLeft1.TabIndex = 14
        Me.btnAllLeft1.Text = "<<"
        Me.btnAllLeft1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(345, 287)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "リセット"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(498, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "人"
        '
        'txtLate
        '
        Me.txtLate.Location = New System.Drawing.Point(416, 221)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.Size = New System.Drawing.Size(66, 19)
        Me.txtLate.TabIndex = 17
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 322)
        Me.Controls.Add(Me.txtLate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAllLeft1)
        Me.Controls.Add(Me.btnLeft1)
        Me.Controls.Add(Me.btnRight1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstLate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPerson)
        Me.Controls.Add(Me.btnAllLeft)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lstAbsent)
        Me.Controls.Add(Me.lstAttend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAttendance"
        Me.Text = "出席管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstAttend As System.Windows.Forms.ListBox
    Friend WithEvents lstAbsent As System.Windows.Forms.ListBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnAllLeft As System.Windows.Forms.Button
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstLate As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRight1 As System.Windows.Forms.Button
    Friend WithEvents btnLeft1 As System.Windows.Forms.Button
    Friend WithEvents btnAllLeft1 As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLate As System.Windows.Forms.TextBox

End Class
