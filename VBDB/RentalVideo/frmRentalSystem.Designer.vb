<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalSystem
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtC_BirthDay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblC_Sex = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtC_TakeOutcount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtC_JoinDate = New System.Windows.Forms.TextBox()
        Me.txtC_ExpirationDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC_Phone = New System.Windows.Forms.TextBox()
        Me.txtC_HomePhone = New System.Windows.Forms.TextBox()
        Me.txtC_Adress = New System.Windows.Forms.TextBox()
        Me.txtC_PostNo = New System.Windows.Forms.TextBox()
        Me.txtC_Kana = New System.Windows.Forms.TextBox()
        Me.txtC_Name = New System.Windows.Forms.TextBox()
        Me.txtC_Code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.selectbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.rentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.returnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.videoCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.videoName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.overdueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnVideoSearch = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtC_BirthDay)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblC_Sex)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.btnChange)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtC_TakeOutcount)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtC_JoinDate)
        Me.GroupBox2.Controls.Add(Me.txtC_ExpirationDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtC_Phone)
        Me.GroupBox2.Controls.Add(Me.txtC_HomePhone)
        Me.GroupBox2.Controls.Add(Me.txtC_Adress)
        Me.GroupBox2.Controls.Add(Me.txtC_PostNo)
        Me.GroupBox2.Controls.Add(Me.txtC_Kana)
        Me.GroupBox2.Controls.Add(Me.txtC_Name)
        Me.GroupBox2.Controls.Add(Me.txtC_Code)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(782, 215)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "会員情報"
        '
        'txtC_BirthDay
        '
        Me.txtC_BirthDay.Location = New System.Drawing.Point(412, 49)
        Me.txtC_BirthDay.Name = "txtC_BirthDay"
        Me.txtC_BirthDay.Size = New System.Drawing.Size(100, 19)
        Me.txtC_BirthDay.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "生年月日"
        '
        'lblC_Sex
        '
        Me.lblC_Sex.AutoSize = True
        Me.lblC_Sex.Location = New System.Drawing.Point(202, 21)
        Me.lblC_Sex.Name = "lblC_Sex"
        Me.lblC_Sex.Size = New System.Drawing.Size(29, 12)
        Me.lblC_Sex.TabIndex = 53
        Me.lblC_Sex.Text = "性別"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(690, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "会員脱退"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(648, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 23)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "貸し出し履歴"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(530, 14)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(112, 23)
        Me.btnChange.TabIndex = 50
        Me.btnChange.Text = "顧客基本情報修正"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(358, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(252, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "[注意]　貸し出し本数は5本までです．"
        '
        'txtC_TakeOutcount
        '
        Me.txtC_TakeOutcount.Location = New System.Drawing.Point(468, 171)
        Me.txtC_TakeOutcount.Name = "txtC_TakeOutcount"
        Me.txtC_TakeOutcount.ReadOnly = True
        Me.txtC_TakeOutcount.Size = New System.Drawing.Size(100, 19)
        Me.txtC_TakeOutcount.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(196, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "有効期間"
        '
        'txtC_JoinDate
        '
        Me.txtC_JoinDate.Location = New System.Drawing.Point(83, 146)
        Me.txtC_JoinDate.Name = "txtC_JoinDate"
        Me.txtC_JoinDate.Size = New System.Drawing.Size(100, 19)
        Me.txtC_JoinDate.TabIndex = 46
        '
        'txtC_ExpirationDate
        '
        Me.txtC_ExpirationDate.Location = New System.Drawing.Point(255, 146)
        Me.txtC_ExpirationDate.Name = "txtC_ExpirationDate"
        Me.txtC_ExpirationDate.Size = New System.Drawing.Size(100, 19)
        Me.txtC_ExpirationDate.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "加入日"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "貸し出し本数"
        '
        'txtC_Phone
        '
        Me.txtC_Phone.Location = New System.Drawing.Point(246, 117)
        Me.txtC_Phone.Name = "txtC_Phone"
        Me.txtC_Phone.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Phone.TabIndex = 37
        '
        'txtC_HomePhone
        '
        Me.txtC_HomePhone.Location = New System.Drawing.Point(83, 117)
        Me.txtC_HomePhone.Name = "txtC_HomePhone"
        Me.txtC_HomePhone.Size = New System.Drawing.Size(100, 19)
        Me.txtC_HomePhone.TabIndex = 38
        '
        'txtC_Adress
        '
        Me.txtC_Adress.Location = New System.Drawing.Point(191, 85)
        Me.txtC_Adress.Name = "txtC_Adress"
        Me.txtC_Adress.Size = New System.Drawing.Size(386, 19)
        Me.txtC_Adress.TabIndex = 39
        '
        'txtC_PostNo
        '
        Me.txtC_PostNo.Location = New System.Drawing.Point(83, 85)
        Me.txtC_PostNo.Name = "txtC_PostNo"
        Me.txtC_PostNo.Size = New System.Drawing.Size(100, 19)
        Me.txtC_PostNo.TabIndex = 40
        '
        'txtC_Kana
        '
        Me.txtC_Kana.Location = New System.Drawing.Point(246, 49)
        Me.txtC_Kana.Name = "txtC_Kana"
        Me.txtC_Kana.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Kana.TabIndex = 41
        '
        'txtC_Name
        '
        Me.txtC_Name.Location = New System.Drawing.Point(83, 49)
        Me.txtC_Name.Name = "txtC_Name"
        Me.txtC_Name.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Name.TabIndex = 42
        '
        'txtC_Code
        '
        Me.txtC_Code.Location = New System.Drawing.Point(83, 18)
        Me.txtC_Code.Name = "txtC_Code"
        Me.txtC_Code.ReadOnly = True
        Me.txtC_Code.Size = New System.Drawing.Size(100, 19)
        Me.txtC_Code.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 12)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "会員コ－ド"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "携帯電話"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "会員氏名"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "自宅電話"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 12)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "会員カナ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "住所"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "会員加入延長"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(612, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 84)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "連帯日数料金"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "連帯料金し収納"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "円"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(79, 19)
        Me.TextBox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 12)
        Me.Label9.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.CausesValidation = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectbox, Me.rentDate, Me.returnDate, Me.videoCode, Me.videoName, Me.overdueDate})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 422)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(765, 186)
        Me.DataGridView1.TabIndex = 14
        '
        'selectbox
        '
        Me.selectbox.HeaderText = "選択"
        Me.selectbox.Name = "selectbox"
        '
        'rentDate
        '
        Me.rentDate.HeaderText = "貸し出し日"
        Me.rentDate.Name = "rentDate"
        Me.rentDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'returnDate
        '
        Me.returnDate.HeaderText = "返却日"
        Me.returnDate.Name = "returnDate"
        '
        'videoCode
        '
        Me.videoCode.HeaderText = "ビデオコ－ド"
        Me.videoCode.Name = "videoCode"
        '
        'videoName
        '
        Me.videoName.HeaderText = "ビデオ名"
        Me.videoName.Name = "videoName"
        '
        'overdueDate
        '
        Me.overdueDate.HeaderText = "延滞日数"
        Me.overdueDate.Name = "overdueDate"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(217, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 47)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "ビデオ検索"
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(437, 362)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(172, 47)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.Text = "返却"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 371)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 21)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "現在貸し出し状態表"
        '
        'btnVideoSearch
        '
        Me.btnVideoSearch.Location = New System.Drawing.Point(622, 20)
        Me.btnVideoSearch.Name = "btnVideoSearch"
        Me.btnVideoSearch.Size = New System.Drawing.Size(139, 68)
        Me.btnVideoSearch.TabIndex = 19
        Me.btnVideoSearch.Text = "ビデオ検索"
        Me.btnVideoSearch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btnJoin)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 69)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "会員検索"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(71, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 12)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "会員コード"
        '
        'btnJoin
        '
        Me.btnJoin.Location = New System.Drawing.Point(463, 21)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(75, 23)
        Me.btnJoin.TabIndex = 4
        Me.btnJoin.Text = "会員加入"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(140, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 19)
        Me.txtSearch.TabIndex = 3
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
        'frmRentalSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(846, 620)
        Me.Controls.Add(Me.btnVideoSearch)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmRentalSystem"
        Me.Text = "frmRentalSystem"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents selectbox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents rentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents returnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents videoCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents videoName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents overdueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtC_BirthDay As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblC_Sex As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtC_TakeOutcount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtC_JoinDate As System.Windows.Forms.TextBox
    Friend WithEvents txtC_ExpirationDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtC_Phone As System.Windows.Forms.TextBox
    Friend WithEvents txtC_HomePhone As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Adress As System.Windows.Forms.TextBox
    Friend WithEvents txtC_PostNo As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Kana As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtC_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnVideoSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnJoin As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
