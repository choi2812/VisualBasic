<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
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
        Me.chkGivenname = New System.Windows.Forms.CheckBox()
        Me.chkFamilyname = New System.Windows.Forms.CheckBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkGivenname
        '
        Me.chkGivenname.AutoSize = True
        Me.chkGivenname.Location = New System.Drawing.Point(109, 62)
        Me.chkGivenname.Name = "chkGivenname"
        Me.chkGivenname.Size = New System.Drawing.Size(36, 16)
        Me.chkGivenname.TabIndex = 0
        Me.chkGivenname.Text = "名"
        Me.chkGivenname.UseVisualStyleBackColor = True
        '
        'chkFamilyname
        '
        Me.chkFamilyname.AutoSize = True
        Me.chkFamilyname.Location = New System.Drawing.Point(12, 62)
        Me.chkFamilyname.Name = "chkFamilyname"
        Me.chkFamilyname.Size = New System.Drawing.Size(36, 16)
        Me.chkFamilyname.TabIndex = 1
        Me.chkFamilyname.Text = "姓"
        Me.chkFamilyname.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(197, 62)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "表示"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(197, 227)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 3
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 4
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.chkFamilyname)
        Me.Controls.Add(Me.chkGivenname)
        Me.Name = "frmCheck"
        Me.Text = "frmCheck"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkGivenname As System.Windows.Forms.CheckBox
    Friend WithEvents chkFamilyname As System.Windows.Forms.CheckBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class
