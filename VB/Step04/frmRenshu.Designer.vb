<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chkCar
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
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.gbxSex = New System.Windows.Forms.GroupBox()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.rbtMan = New System.Windows.Forms.RadioButton()
        Me.gbxAdult = New System.Windows.Forms.GroupBox()
        Me.rbtAdult = New System.Windows.Forms.RadioButton()
        Me.rbtChild = New System.Windows.Forms.RadioButton()
        Me.chkOwner = New System.Windows.Forms.CheckBox()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.gbxSex.SuspendLayout()
        Me.gbxAdult.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "氏名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "性別"
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(79, 59)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(43, 19)
        Me.txtSex.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(79, 15)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 19)
        Me.txtname.TabIndex = 3
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(217, 227)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(55, 23)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(217, 166)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(55, 23)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "チェック"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'gbxSex
        '
        Me.gbxSex.BackColor = System.Drawing.Color.White
        Me.gbxSex.Controls.Add(Me.rbtFemale)
        Me.gbxSex.Controls.Add(Me.rbtMan)
        Me.gbxSex.Location = New System.Drawing.Point(128, 40)
        Me.gbxSex.Name = "gbxSex"
        Me.gbxSex.Size = New System.Drawing.Size(51, 91)
        Me.gbxSex.TabIndex = 9
        Me.gbxSex.TabStop = False
        Me.gbxSex.Text = "性別"
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Location = New System.Drawing.Point(0, 56)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(35, 16)
        Me.rbtFemale.TabIndex = 1
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "女"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'rbtMan
        '
        Me.rbtMan.AutoSize = True
        Me.rbtMan.Location = New System.Drawing.Point(0, 22)
        Me.rbtMan.Name = "rbtMan"
        Me.rbtMan.Size = New System.Drawing.Size(35, 16)
        Me.rbtMan.TabIndex = 0
        Me.rbtMan.TabStop = True
        Me.rbtMan.Text = "男"
        Me.rbtMan.UseVisualStyleBackColor = True
        '
        'gbxAdult
        '
        Me.gbxAdult.BackColor = System.Drawing.Color.White
        Me.gbxAdult.Controls.Add(Me.rbtAdult)
        Me.gbxAdult.Controls.Add(Me.rbtChild)
        Me.gbxAdult.Location = New System.Drawing.Point(31, 137)
        Me.gbxAdult.Name = "gbxAdult"
        Me.gbxAdult.Size = New System.Drawing.Size(121, 52)
        Me.gbxAdult.TabIndex = 10
        Me.gbxAdult.TabStop = False
        Me.gbxAdult.Text = "成人"
        '
        'rbtAdult
        '
        Me.rbtAdult.AutoSize = True
        Me.rbtAdult.Location = New System.Drawing.Point(62, 18)
        Me.rbtAdult.Name = "rbtAdult"
        Me.rbtAdult.Size = New System.Drawing.Size(47, 16)
        Me.rbtAdult.TabIndex = 1
        Me.rbtAdult.TabStop = True
        Me.rbtAdult.Text = "成人"
        Me.rbtAdult.UseVisualStyleBackColor = True
        '
        'rbtChild
        '
        Me.rbtChild.AutoSize = True
        Me.rbtChild.Location = New System.Drawing.Point(0, 18)
        Me.rbtChild.Name = "rbtChild"
        Me.rbtChild.Size = New System.Drawing.Size(59, 16)
        Me.rbtChild.TabIndex = 0
        Me.rbtChild.TabStop = True
        Me.rbtChild.Text = "未成年"
        Me.rbtChild.UseVisualStyleBackColor = True
        '
        'chkOwner
        '
        Me.chkOwner.AutoSize = True
        Me.chkOwner.Location = New System.Drawing.Point(31, 225)
        Me.chkOwner.Name = "chkOwner"
        Me.chkOwner.Size = New System.Drawing.Size(70, 16)
        Me.chkOwner.TabIndex = 11
        Me.chkOwner.Text = "車の所有"
        Me.chkOwner.UseVisualStyleBackColor = True
        '
        'txtCarName
        '
        Me.txtCarName.Enabled = False
        Me.txtCarName.Location = New System.Drawing.Point(107, 225)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(72, 19)
        Me.txtCarName.TabIndex = 12
        '
        'chkCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtCarName)
        Me.Controls.Add(Me.chkOwner)
        Me.Controls.Add(Me.gbxAdult)
        Me.Controls.Add(Me.gbxSex)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "chkCar"
        Me.Text = "練習"
        Me.gbxSex.ResumeLayout(False)
        Me.gbxSex.PerformLayout()
        Me.gbxAdult.ResumeLayout(False)
        Me.gbxAdult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents gbxSex As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMan As System.Windows.Forms.RadioButton
    Friend WithEvents gbxAdult As System.Windows.Forms.GroupBox
    Friend WithEvents rbtAdult As System.Windows.Forms.RadioButton
    Friend WithEvents rbtChild As System.Windows.Forms.RadioButton
    Friend WithEvents chkOwner As System.Windows.Forms.CheckBox
    Friend WithEvents txtCarName As System.Windows.Forms.TextBox

End Class
