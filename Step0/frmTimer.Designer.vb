<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnd = New System.Windows.Forms.ToolStripMenuItem()
        Me.バジョン情報IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerufuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabTimer = New System.Windows.Forms.TabPage()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudSec = New System.Windows.Forms.NumericUpDown()
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prbTimer = New System.Windows.Forms.ProgressBar()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabSet = New System.Windows.Forms.TabPage()
        Me.rbtBarNotExist = New System.Windows.Forms.RadioButton()
        Me.rbtBarExist = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TebPageSet = New System.Windows.Forms.TabPage()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.chkYear = New System.Windows.Forms.CheckBox()
        Me.chkSec = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabTimer.SuspendLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSet.SuspendLayout()
        Me.TebPageSet.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルfToolStripMenuItem, Me.HerufuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルfToolStripMenuItem
        '
        Me.ファイルfToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEnd})
        Me.ファイルfToolStripMenuItem.Name = "ファイルfToolStripMenuItem"
        Me.ファイルfToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルfToolStripMenuItem.Text = "ファイル(&F)"
        '
        'mnuEnd
        '
        Me.mnuEnd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バジョン情報IToolStripMenuItem})
        Me.mnuEnd.Name = "mnuEnd"
        Me.mnuEnd.Size = New System.Drawing.Size(118, 22)
        Me.mnuEnd.Text = "終了(&X)"
        '
        'バジョン情報IToolStripMenuItem
        '
        Me.バジョン情報IToolStripMenuItem.Name = "バジョン情報IToolStripMenuItem"
        Me.バジョン情報IToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.バジョン情報IToolStripMenuItem.Text = "バ－ジョン情報(&I)"
        '
        'HerufuToolStripMenuItem
        '
        Me.HerufuToolStripMenuItem.Name = "HerufuToolStripMenuItem"
        Me.HerufuToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.HerufuToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabTimer)
        Me.TabControl.Controls.Add(Me.TabSet)
        Me.TabControl.Controls.Add(Me.TebPageSet)
        Me.TabControl.Location = New System.Drawing.Point(12, 39)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(564, 291)
        Me.TabControl.TabIndex = 1
        '
        'TabTimer
        '
        Me.TabTimer.Controls.Add(Me.txtSec)
        Me.TabTimer.Controls.Add(Me.txtMin)
        Me.TabTimer.Controls.Add(Me.txtHour)
        Me.TabTimer.Controls.Add(Me.txtDay)
        Me.TabTimer.Controls.Add(Me.txtMonth)
        Me.TabTimer.Controls.Add(Me.txtYear)
        Me.TabTimer.Controls.Add(Me.lblSec)
        Me.TabTimer.Controls.Add(Me.lblMin)
        Me.TabTimer.Controls.Add(Me.lblHour)
        Me.TabTimer.Controls.Add(Me.lblDay)
        Me.TabTimer.Controls.Add(Me.lblMonth)
        Me.TabTimer.Controls.Add(Me.lblYear)
        Me.TabTimer.Controls.Add(Me.Label7)
        Me.TabTimer.Controls.Add(Me.nudSec)
        Me.TabTimer.Controls.Add(Me.nudMin)
        Me.TabTimer.Controls.Add(Me.Label5)
        Me.TabTimer.Controls.Add(Me.Label4)
        Me.TabTimer.Controls.Add(Me.prbTimer)
        Me.TabTimer.Controls.Add(Me.btnStart)
        Me.TabTimer.Controls.Add(Me.Label3)
        Me.TabTimer.Controls.Add(Me.Label2)
        Me.TabTimer.Controls.Add(Me.Label1)
        Me.TabTimer.Location = New System.Drawing.Point(4, 22)
        Me.TabTimer.Name = "TabTimer"
        Me.TabTimer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTimer.Size = New System.Drawing.Size(556, 265)
        Me.TabTimer.TabIndex = 0
        Me.TabTimer.Text = "タイマ－"
        Me.TabTimer.UseVisualStyleBackColor = True
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(398, 40)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(47, 19)
        Me.txtSec.TabIndex = 28
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(322, 40)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(47, 19)
        Me.txtMin.TabIndex = 27
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(248, 40)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(47, 19)
        Me.txtHour.TabIndex = 26
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(172, 40)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(47, 19)
        Me.txtDay.TabIndex = 25
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(97, 40)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(47, 19)
        Me.txtMonth.TabIndex = 24
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(3, 40)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(65, 19)
        Me.txtYear.TabIndex = 18
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(451, 43)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(17, 12)
        Me.lblSec.TabIndex = 17
        Me.lblSec.Text = "秒"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(375, 43)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(17, 12)
        Me.lblMin.TabIndex = 16
        Me.lblMin.Text = "分"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(299, 43)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(17, 12)
        Me.lblHour.TabIndex = 15
        Me.lblHour.Text = "時"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(225, 43)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(17, 12)
        Me.lblDay.TabIndex = 14
        Me.lblDay.Text = "日"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(149, 43)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(17, 12)
        Me.lblMonth.TabIndex = 13
        Me.lblMonth.Text = "月"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(74, 43)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(17, 12)
        Me.lblYear.TabIndex = 12
        Me.lblYear.Text = "年"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "今日の日付"
        '
        'nudSec
        '
        Me.nudSec.Location = New System.Drawing.Point(161, 145)
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(37, 19)
        Me.nudSec.TabIndex = 10
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(95, 145)
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(37, 19)
        Me.nudMin.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        '
        'prbTimer
        '
        Me.prbTimer.Location = New System.Drawing.Point(54, 207)
        Me.prbTimer.Maximum = 60
        Me.prbTimer.Name = "prbTimer"
        Me.prbTimer.Size = New System.Drawing.Size(403, 23)
        Me.prbTimer.TabIndex = 6
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(282, 105)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(117, 59)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "秒"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "分"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "設定時間"
        '
        'TabSet
        '
        Me.TabSet.Controls.Add(Me.rbtBarNotExist)
        Me.TabSet.Controls.Add(Me.rbtBarExist)
        Me.TabSet.Controls.Add(Me.Label6)
        Me.TabSet.Location = New System.Drawing.Point(4, 22)
        Me.TabSet.Name = "TabSet"
        Me.TabSet.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSet.Size = New System.Drawing.Size(556, 265)
        Me.TabSet.TabIndex = 1
        Me.TabSet.Text = "設定"
        Me.TabSet.UseVisualStyleBackColor = True
        '
        'rbtBarNotExist
        '
        Me.rbtBarNotExist.AutoSize = True
        Me.rbtBarNotExist.Location = New System.Drawing.Point(98, 88)
        Me.rbtBarNotExist.Name = "rbtBarNotExist"
        Me.rbtBarNotExist.Size = New System.Drawing.Size(115, 16)
        Me.rbtBarNotExist.TabIndex = 2
        Me.rbtBarNotExist.Text = "バ－を表示しない。"
        Me.rbtBarNotExist.UseVisualStyleBackColor = True
        '
        'rbtBarExist
        '
        Me.rbtBarExist.AutoSize = True
        Me.rbtBarExist.Checked = True
        Me.rbtBarExist.Location = New System.Drawing.Point(98, 66)
        Me.rbtBarExist.Name = "rbtBarExist"
        Me.rbtBarExist.Size = New System.Drawing.Size(105, 16)
        Me.rbtBarExist.TabIndex = 1
        Me.rbtBarExist.TabStop = True
        Me.rbtBarExist.Text = "バ－を表示する。"
        Me.rbtBarExist.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "プログレスバ－の表示"
        '
        'TebPageSet
        '
        Me.TebPageSet.Controls.Add(Me.chkSec)
        Me.TebPageSet.Controls.Add(Me.chkYear)
        Me.TebPageSet.Location = New System.Drawing.Point(4, 22)
        Me.TebPageSet.Name = "TebPageSet"
        Me.TebPageSet.Size = New System.Drawing.Size(556, 265)
        Me.TebPageSet.TabIndex = 2
        Me.TebPageSet.Text = "表示設定"
        Me.TebPageSet.UseVisualStyleBackColor = True
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 1000
        '
        'chkYear
        '
        Me.chkYear.AutoSize = True
        Me.chkYear.Location = New System.Drawing.Point(237, 35)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(60, 16)
        Me.chkYear.TabIndex = 2
        Me.chkYear.Text = "年表示"
        Me.chkYear.UseVisualStyleBackColor = True
        '
        'chkSec
        '
        Me.chkSec.AutoSize = True
        Me.chkSec.Location = New System.Drawing.Point(237, 80)
        Me.chkSec.Name = "chkSec"
        Me.chkSec.Size = New System.Drawing.Size(60, 16)
        Me.chkSec.TabIndex = 3
        Me.chkSec.Text = "秒表示"
        Me.chkSec.UseVisualStyleBackColor = True
        '
        'frmTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 347)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTimer"
        Me.Text = "タイマ－"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabTimer.ResumeLayout(False)
        Me.TabTimer.PerformLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSet.ResumeLayout(False)
        Me.TabSet.PerformLayout()
        Me.TebPageSet.ResumeLayout(False)
        Me.TebPageSet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerufuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabTimer As System.Windows.Forms.TabPage
    Friend WithEvents nudSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prbTimer As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabSet As System.Windows.Forms.TabPage
    Friend WithEvents rbtBarNotExist As System.Windows.Forms.RadioButton
    Friend WithEvents rbtBarExist As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mnuEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents バジョン情報IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TebPageSet As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtHour As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents chkSec As System.Windows.Forms.CheckBox
    Friend WithEvents chkYear As System.Windows.Forms.CheckBox

End Class
