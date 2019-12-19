<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudRate = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpData = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnd})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'mnuEnd
        '
        Me.mnuEnd.Name = "mnuEnd"
        Me.mnuEnd.Size = New System.Drawing.Size(152, 22)
        Me.mnuEnd.Text = "終了(&X)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "時給を更新します。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(57, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "アップ率"
        '
        'nudRate
        '
        Me.nudRate.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.nudRate.Location = New System.Drawing.Point(128, 102)
        Me.nudRate.Name = "nudRate"
        Me.nudRate.Size = New System.Drawing.Size(55, 23)
        Me.nudRate.TabIndex = 4
        Me.nudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(197, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "％"
        '
        'btnUpData
        '
        Me.btnUpData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUpData.Location = New System.Drawing.Point(197, 142)
        Me.btnUpData.Name = "btnUpData"
        Me.btnUpData.Size = New System.Drawing.Size(75, 23)
        Me.btnUpData.TabIndex = 6
        Me.btnUpData.Text = "更新"
        Me.btnUpData.UseVisualStyleBackColor = True
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnUpData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUpdate"
        Me.Text = "時給変更処理"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpData As System.Windows.Forms.Button

End Class
