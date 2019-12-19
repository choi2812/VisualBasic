<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalLoginSystem
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvMemder = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVideoSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC_Code = New System.Windows.Forms.TextBox()
        Me.txtC_Name = New System.Windows.Forms.TextBox()
        Me.txtC_Kana = New System.Windows.Forms.TextBox()
        Me.txtC_HomePhone = New System.Windows.Forms.TextBox()
        Me.txtC_Phone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtC_ExpirationDate = New System.Windows.Forms.TextBox()
        Me.txtC_JoinDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtC_TakeOutcount = New System.Windows.Forms.TextBox()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtC_BirthDay = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMemder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(361, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseMnemonic = False
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "会員検索"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(49, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 12)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "ビデオコ－ド"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 12)
        Me.Label14.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(140, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 19)
        Me.txtSearch.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(434, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 12)
        Me.Label9.TabIndex = 9
        '
        'dgvMemder
        '
        Me.dgvMemder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMemder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvMemder.Location = New System.Drawing.Point(2, 286)
        Me.dgvMemder.Name = "dgvMemder"
        Me.dgvMemder.RowTemplate.Height = 21
        Me.dgvMemder.Size = New System.Drawing.Size(785, 150)
        Me.dgvMemder.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        '
        'btnVideoSearch
        '
        Me.btnVideoSearch.Location = New System.Drawing.Point(603, 36)
        Me.btnVideoSearch.Name = "btnVideoSearch"
        Me.btnVideoSearch.Size = New System.Drawing.Size(101, 23)
        Me.btnVideoSearch.TabIndex = 17
        Me.btnVideoSearch.Text = "c検索"
        Me.btnVideoSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ビデオカナ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "自宅電話"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ビデオ名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "携帯電話"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ビデオコ－ド"
        '
        'txtC_Code
        '
        Me.txtC_Code.Location = New System.Drawing.Point(89, 26)
        Me.txtC_Code.Name = "txtC_Code"
        Me.txtC_Code.ReadOnly = True
        Me.txtC_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Code.TabIndex = 4
        '
        'txtC_Name
        '
        Me.txtC_Name.Location = New System.Drawing.Point(89, 57)
        Me.txtC_Name.Name = "txtC_Name"
        Me.txtC_Name.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Name.TabIndex = 16
        '
        'txtC_Kana
        '
        Me.txtC_Kana.Location = New System.Drawing.Point(252, 57)
        Me.txtC_Kana.Name = "txtC_Kana"
        Me.txtC_Kana.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Kana.TabIndex = 15
        '
        'txtC_HomePhone
        '
        Me.txtC_HomePhone.Location = New System.Drawing.Point(89, 125)
        Me.txtC_HomePhone.Name = "txtC_HomePhone"
        Me.txtC_HomePhone.Size = New System.Drawing.Size(100, 19)
        Me.txtC_HomePhone.TabIndex = 12
        '
        'txtC_Phone
        '
        Me.txtC_Phone.Location = New System.Drawing.Point(252, 125)
        Me.txtC_Phone.Name = "txtC_Phone"
        Me.txtC_Phone.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Phone.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "貸し出し本数"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "加入日"
        '
        'txtC_ExpirationDate
        '
        Me.txtC_ExpirationDate.Location = New System.Drawing.Point(261, 154)
        Me.txtC_ExpirationDate.Name = "txtC_ExpirationDate"
        Me.txtC_ExpirationDate.Size = New System.Drawing.Size(100, 19)
        Me.txtC_ExpirationDate.TabIndex = 19
        '
        'txtC_JoinDate
        '
        Me.txtC_JoinDate.Location = New System.Drawing.Point(89, 154)
        Me.txtC_JoinDate.Name = "txtC_JoinDate"
        Me.txtC_JoinDate.Size = New System.Drawing.Size(100, 19)
        Me.txtC_JoinDate.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(202, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "有効期間"
        '
        'txtC_TakeOutcount
        '
        Me.txtC_TakeOutcount.Location = New System.Drawing.Point(483, 146)
        Me.txtC_TakeOutcount.Name = "txtC_TakeOutcount"
        Me.txtC_TakeOutcount.ReadOnly = True
        Me.txtC_TakeOutcount.Size = New System.Drawing.Size(100, 19)
        Me.txtC_TakeOutcount.TabIndex = 22
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(614, 22)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(117, 23)
        Me.btnHistory.TabIndex = 25
        Me.btnHistory.Text = "貸し出し"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "購入日"
        '
        'txtC_BirthDay
        '
        Me.txtC_BirthDay.Location = New System.Drawing.Point(89, 86)
        Me.txtC_BirthDay.Name = "txtC_BirthDay"
        Me.txtC_BirthDay.Size = New System.Drawing.Size(100, 19)
        Me.txtC_BirthDay.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txtC_BirthDay)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnHistory)
        Me.GroupBox2.Controls.Add(Me.txtC_TakeOutcount)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtC_JoinDate)
        Me.GroupBox2.Controls.Add(Me.txtC_ExpirationDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtC_Phone)
        Me.GroupBox2.Controls.Add(Me.txtC_HomePhone)
        Me.GroupBox2.Controls.Add(Me.txtC_Kana)
        Me.GroupBox2.Controls.Add(Me.txtC_Name)
        Me.GroupBox2.Controls.Add(Me.txtC_Code)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(754, 176)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ビデオ詳細情報"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(239, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "新作"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmRentalLoginSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 448)
        Me.Controls.Add(Me.btnVideoSearch)
        Me.Controls.Add(Me.dgvMemder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRentalLoginSystem"
        Me.Text = "VideoSearchSystem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMemder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvMemder As System.Windows.Forms.DataGridView
    Friend WithEvents btnVideoSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtC_Code As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Kana As System.Windows.Forms.TextBox
    Friend WithEvents txtC_HomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Phone As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtC_ExpirationDate As System.Windows.Forms.TextBox
    Friend WithEvents txtC_JoinDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtC_TakeOutcount As System.Windows.Forms.TextBox
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtC_BirthDay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
