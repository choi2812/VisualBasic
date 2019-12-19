<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLunch
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
        Me.gbxSyurui = New System.Windows.Forms.GroupBox()
        Me.rbtNuddle = New System.Windows.Forms.RadioButton()
        Me.rbtLunch = New System.Windows.Forms.RadioButton()
        Me.gbxMenu = New System.Windows.Forms.GroupBox()
        Me.lstlunch = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.gbxSyurui.SuspendLayout()
        Me.gbxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSyurui
        '
        Me.gbxSyurui.Controls.Add(Me.rbtLunch)
        Me.gbxSyurui.Controls.Add(Me.rbtNuddle)
        Me.gbxSyurui.Location = New System.Drawing.Point(12, 39)
        Me.gbxSyurui.Name = "gbxSyurui"
        Me.gbxSyurui.Size = New System.Drawing.Size(120, 110)
        Me.gbxSyurui.TabIndex = 0
        Me.gbxSyurui.TabStop = False
        Me.gbxSyurui.Text = "種類"
        '
        'rbtNuddle
        '
        Me.rbtNuddle.AutoSize = True
        Me.rbtNuddle.Location = New System.Drawing.Point(22, 18)
        Me.rbtNuddle.Name = "rbtNuddle"
        Me.rbtNuddle.Size = New System.Drawing.Size(47, 16)
        Me.rbtNuddle.TabIndex = 0
        Me.rbtNuddle.Text = "麺類"
        Me.rbtNuddle.UseVisualStyleBackColor = True
        '
        'rbtLunch
        '
        Me.rbtLunch.AutoSize = True
        Me.rbtLunch.Location = New System.Drawing.Point(22, 69)
        Me.rbtLunch.Name = "rbtLunch"
        Me.rbtLunch.Size = New System.Drawing.Size(47, 16)
        Me.rbtLunch.TabIndex = 1
        Me.rbtLunch.Text = "定食"
        Me.rbtLunch.UseVisualStyleBackColor = True
        '
        'gbxMenu
        '
        Me.gbxMenu.Controls.Add(Me.lstlunch)
        Me.gbxMenu.Location = New System.Drawing.Point(162, 49)
        Me.gbxMenu.Name = "gbxMenu"
        Me.gbxMenu.Size = New System.Drawing.Size(185, 100)
        Me.gbxMenu.TabIndex = 1
        Me.gbxMenu.TabStop = False
        Me.gbxMenu.Text = "メニュ-"
        '
        'lstlunch
        '
        Me.lstlunch.FormattingEnabled = True
        Me.lstlunch.ItemHeight = 12
        Me.lstlunch.Location = New System.Drawing.Point(25, 18)
        Me.lstlunch.Name = "lstlunch"
        Me.lstlunch.Size = New System.Drawing.Size(120, 64)
        Me.lstlunch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "選択"
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(238, 185)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(100, 19)
        Me.txtSelect.TabIndex = 4
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(263, 227)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmLunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 262)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxMenu)
        Me.Controls.Add(Me.gbxSyurui)
        Me.Name = "frmLunch"
        Me.Text = "ランチメニュ-"
        Me.gbxSyurui.ResumeLayout(False)
        Me.gbxSyurui.PerformLayout()
        Me.gbxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxSyurui As System.Windows.Forms.GroupBox
    Friend WithEvents rbtLunch As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNuddle As System.Windows.Forms.RadioButton
    Friend WithEvents gbxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents lstlunch As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSelect As System.Windows.Forms.TextBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
End Class
