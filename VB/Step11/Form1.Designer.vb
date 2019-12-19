<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextEditor))
        Me.mnuMenuBar = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAppend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrNewItem = New System.Windows.Forms.ToolStripButton()
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton()
        Me.tbrStripButton = New System.Windows.Forms.ToolStripButton()
        Me.印刷PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrCut = New System.Windows.Forms.ToolStripButton()
        Me.tbrCopy = New System.Windows.Forms.ToolStripButton()
        Me.tbrPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ヘルプLToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tbrFontSize = New System.Windows.Forms.ToolStripComboBox()
        Me.tbrFonttype = New System.Windows.Forms.ToolStripComboBox()
        Me.txtText = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mnuMenuBar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuBar
        '
        Me.mnuMenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集ToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.mnuMenuBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuBar.Name = "mnuMenuBar"
        Me.mnuMenuBar.Size = New System.Drawing.Size(470, 26)
        Me.mnuMenuBar.TabIndex = 0
        Me.mnuMenuBar.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuOpen, Me.mnuStrip, Me.mnuAppend, Me.ToolStripSeparator2, Me.mnuQuit})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'mnuNewItem
        '
        Me.mnuNewItem.Name = "mnuNewItem"
        Me.mnuNewItem.Size = New System.Drawing.Size(190, 22)
        Me.mnuNewItem.Text = "新規作成(&N)"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(190, 22)
        Me.mnuOpen.Text = "開く(&O)"
        '
        'mnuStrip
        '
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(190, 22)
        Me.mnuStrip.Text = "上書き保存(&S)"
        '
        'mnuAppend
        '
        Me.mnuAppend.Name = "mnuAppend"
        Me.mnuAppend.Size = New System.Drawing.Size(190, 22)
        Me.mnuAppend.Text = "名前をつけて保存(&A)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(190, 22)
        Me.mnuQuit.Text = "終了(&Q)"
        '
        '編集ToolStripMenuItem
        '
        Me.編集ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.ToolStripSeparator3, Me.mnuCopy, Me.mnuCut, Me.mnuPaste, Me.ToolStripSeparator4, Me.mnuFind, Me.mnuReplace})
        Me.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem"
        Me.編集ToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.編集ToolStripMenuItem.Text = "編集(&E)"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(152, 22)
        Me.mnuUndo.Text = "元に戻す(&Z)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuCopy.Text = "コピ-(&C)"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(152, 22)
        Me.mnuCut.Text = "切り取り(&X)"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(152, 22)
        Me.mnuPaste.Text = "貼り付け(&W)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(152, 22)
        Me.mnuFind.Text = "検索(&F)"
        '
        'mnuReplace
        '
        Me.mnuReplace.Name = "mnuReplace"
        Me.mnuReplace.Size = New System.Drawing.Size(152, 22)
        Me.mnuReplace.Text = "置換(&R)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrNewItem, Me.tbrOpen, Me.tbrStripButton, Me.印刷PToolStripButton, Me.toolStripSeparator, Me.tbrCut, Me.tbrCopy, Me.tbrPaste, Me.toolStripSeparator1, Me.ヘルプLToolStripButton, Me.tbrFontSize, Me.tbrFonttype})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(470, 26)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrNewItem
        '
        Me.tbrNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrNewItem.Image = CType(resources.GetObject("tbrNewItem.Image"), System.Drawing.Image)
        Me.tbrNewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrNewItem.Name = "tbrNewItem"
        Me.tbrNewItem.Size = New System.Drawing.Size(23, 23)
        Me.tbrNewItem.Text = "新規作成(&N)"
        '
        'tbrOpen
        '
        Me.tbrOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrOpen.Image = CType(resources.GetObject("tbrOpen.Image"), System.Drawing.Image)
        Me.tbrOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrOpen.Name = "tbrOpen"
        Me.tbrOpen.Size = New System.Drawing.Size(23, 23)
        Me.tbrOpen.Text = "開く(&O)"
        '
        'tbrStripButton
        '
        Me.tbrStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrStripButton.Image = CType(resources.GetObject("tbrStripButton.Image"), System.Drawing.Image)
        Me.tbrStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrStripButton.Name = "tbrStripButton"
        Me.tbrStripButton.Size = New System.Drawing.Size(23, 23)
        Me.tbrStripButton.Text = "上書き保存(&S)"
        '
        '印刷PToolStripButton
        '
        Me.印刷PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.印刷PToolStripButton.Image = CType(resources.GetObject("印刷PToolStripButton.Image"), System.Drawing.Image)
        Me.印刷PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.印刷PToolStripButton.Name = "印刷PToolStripButton"
        Me.印刷PToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.印刷PToolStripButton.Text = "印刷(&P)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 26)
        '
        'tbrCut
        '
        Me.tbrCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCut.Image = CType(resources.GetObject("tbrCut.Image"), System.Drawing.Image)
        Me.tbrCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCut.Name = "tbrCut"
        Me.tbrCut.Size = New System.Drawing.Size(23, 23)
        Me.tbrCut.Text = "切り取り(&U)"
        '
        'tbrCopy
        '
        Me.tbrCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCopy.Image = CType(resources.GetObject("tbrCopy.Image"), System.Drawing.Image)
        Me.tbrCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCopy.Name = "tbrCopy"
        Me.tbrCopy.Size = New System.Drawing.Size(23, 23)
        Me.tbrCopy.Text = "コピー(&C)"
        '
        'tbrPaste
        '
        Me.tbrPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrPaste.Image = CType(resources.GetObject("tbrPaste.Image"), System.Drawing.Image)
        Me.tbrPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrPaste.Name = "tbrPaste"
        Me.tbrPaste.Size = New System.Drawing.Size(23, 23)
        Me.tbrPaste.Text = "貼り付け(&P)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ヘルプLToolStripButton
        '
        Me.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ヘルプLToolStripButton.Image = CType(resources.GetObject("ヘルプLToolStripButton.Image"), System.Drawing.Image)
        Me.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton"
        Me.ヘルプLToolStripButton.Size = New System.Drawing.Size(23, 23)
        Me.ヘルプLToolStripButton.Text = "ヘルプ(&L)"
        '
        'tbrFontSize
        '
        Me.tbrFontSize.Items.AddRange(New Object() {"10", "11", "12", "14", "16", "18", "20", "24", "28", "32"})
        Me.tbrFontSize.Name = "tbrFontSize"
        Me.tbrFontSize.Size = New System.Drawing.Size(75, 26)
        '
        'tbrFonttype
        '
        Me.tbrFonttype.Items.AddRange(New Object() {"MS UI Gothic", "HGP明朝B", "HGP明朝E", "MS 明朝", "MS P 明朝"})
        Me.tbrFonttype.Name = "tbrFonttype"
        Me.tbrFonttype.Size = New System.Drawing.Size(121, 26)
        '
        'txtText
        '
        Me.txtText.AcceptsTab = True
        Me.txtText.Location = New System.Drawing.Point(-12, 55)
        Me.txtText.Name = "txtText"
        Me.txtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtText.Size = New System.Drawing.Size(470, 310)
        Me.txtText.TabIndex = 2
        Me.txtText.Text = ""
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(470, 361)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuMenuBar)
        Me.MainMenuStrip = Me.mnuMenuBar
        Me.Name = "frmTextEditor"
        Me.Text = "テキストエデイタ"
        Me.mnuMenuBar.ResumeLayout(False)
        Me.mnuMenuBar.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 編集ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 印刷PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbrCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ヘルプLToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtText As System.Windows.Forms.RichTextBox
    Friend WithEvents tbrFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents mnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrFonttype As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAppend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ヘルプHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReplace As System.Windows.Forms.ToolStripMenuItem

End Class
