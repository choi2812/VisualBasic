<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffDET
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaffDET))
        Dim S_CodeLabel As System.Windows.Forms.Label
        Dim S_NameLabel As System.Windows.Forms.Label
        Dim S_KanaLabel As System.Windows.Forms.Label
        Dim S_SexLabel As System.Windows.Forms.Label
        Dim S_HpayLabel As System.Windows.Forms.Label
        Dim S_SectonLabel As System.Windows.Forms.Label
        Dim S_PhoneLabel As System.Windows.Forms.Label
        Dim S_ResignflagLabel As System.Windows.Forms.Label
        Me._14jydbDataSet = New Step2._14jydbDataSet()
        Me.VB_StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VB_StaffTableAdapter = New Step2._14jydbDataSetTableAdapters.VB_StaffTableAdapter()
        Me.TableAdapterManager = New Step2._14jydbDataSetTableAdapters.TableAdapterManager()
        Me.VB_StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VB_StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.S_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.S_NameTextBox = New System.Windows.Forms.TextBox()
        Me.S_KanaTextBox = New System.Windows.Forms.TextBox()
        Me.S_SexTextBox = New System.Windows.Forms.TextBox()
        Me.S_HpayTextBox = New System.Windows.Forms.TextBox()
        Me.S_SectonTextBox = New System.Windows.Forms.TextBox()
        Me.S_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.S_ResignflagCheckBox = New System.Windows.Forms.CheckBox()
        S_CodeLabel = New System.Windows.Forms.Label()
        S_NameLabel = New System.Windows.Forms.Label()
        S_KanaLabel = New System.Windows.Forms.Label()
        S_SexLabel = New System.Windows.Forms.Label()
        S_HpayLabel = New System.Windows.Forms.Label()
        S_SectonLabel = New System.Windows.Forms.Label()
        S_PhoneLabel = New System.Windows.Forms.Label()
        S_ResignflagLabel = New System.Windows.Forms.Label()
        CType(Me._14jydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VB_StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VB_StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VB_StaffBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_14jydbDataSet
        '
        Me._14jydbDataSet.DataSetName = "_14jydbDataSet"
        Me._14jydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VB_StaffBindingSource
        '
        Me.VB_StaffBindingSource.DataMember = "VB_Staff"
        Me.VB_StaffBindingSource.DataSource = Me._14jydbDataSet
        '
        'VB_StaffTableAdapter
        '
        Me.VB_StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Step2._14jydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VB_StaffTableAdapter = Me.VB_StaffTableAdapter
        '
        'VB_StaffBindingNavigator
        '
        Me.VB_StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VB_StaffBindingNavigator.BindingSource = Me.VB_StaffBindingSource
        Me.VB_StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VB_StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VB_StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VB_StaffBindingNavigatorSaveItem})
        Me.VB_StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VB_StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VB_StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VB_StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VB_StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VB_StaffBindingNavigator.Name = "VB_StaffBindingNavigator"
        Me.VB_StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VB_StaffBindingNavigator.Size = New System.Drawing.Size(296, 25)
        Me.VB_StaffBindingNavigator.TabIndex = 0
        Me.VB_StaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 18)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'VB_StaffBindingNavigatorSaveItem
        '
        Me.VB_StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VB_StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("VB_StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VB_StaffBindingNavigatorSaveItem.Name = "VB_StaffBindingNavigatorSaveItem"
        Me.VB_StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VB_StaffBindingNavigatorSaveItem.Text = "データの保存"
        '
        'S_CodeLabel
        '
        S_CodeLabel.AutoSize = True
        S_CodeLabel.Location = New System.Drawing.Point(37, 47)
        S_CodeLabel.Name = "S_CodeLabel"
        S_CodeLabel.Size = New System.Drawing.Size(64, 12)
        S_CodeLabel.TabIndex = 1
        S_CodeLabel.Text = "スタッフコード"
        '
        'S_CodeTextBox
        '
        Me.S_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Code", True))
        Me.S_CodeTextBox.Location = New System.Drawing.Point(115, 44)
        Me.S_CodeTextBox.Name = "S_CodeTextBox"
        Me.S_CodeTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_CodeTextBox.TabIndex = 2
        '
        'S_NameLabel
        '
        S_NameLabel.AutoSize = True
        S_NameLabel.Location = New System.Drawing.Point(37, 72)
        S_NameLabel.Name = "S_NameLabel"
        S_NameLabel.Size = New System.Drawing.Size(49, 12)
        S_NameLabel.TabIndex = 3
        S_NameLabel.Text = "スタッフ名"
        '
        'S_NameTextBox
        '
        Me.S_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Name", True))
        Me.S_NameTextBox.Location = New System.Drawing.Point(115, 69)
        Me.S_NameTextBox.Name = "S_NameTextBox"
        Me.S_NameTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_NameTextBox.TabIndex = 4
        '
        'S_KanaLabel
        '
        S_KanaLabel.AutoSize = True
        S_KanaLabel.Location = New System.Drawing.Point(37, 97)
        S_KanaLabel.Name = "S_KanaLabel"
        S_KanaLabel.Size = New System.Drawing.Size(36, 12)
        S_KanaLabel.TabIndex = 5
        S_KanaLabel.Text = "カナ名"
        '
        'S_KanaTextBox
        '
        Me.S_KanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Kana", True))
        Me.S_KanaTextBox.Location = New System.Drawing.Point(115, 94)
        Me.S_KanaTextBox.Name = "S_KanaTextBox"
        Me.S_KanaTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_KanaTextBox.TabIndex = 6
        '
        'S_SexLabel
        '
        S_SexLabel.AutoSize = True
        S_SexLabel.Location = New System.Drawing.Point(37, 122)
        S_SexLabel.Name = "S_SexLabel"
        S_SexLabel.Size = New System.Drawing.Size(29, 12)
        S_SexLabel.TabIndex = 7
        S_SexLabel.Text = "性別"
        '
        'S_SexTextBox
        '
        Me.S_SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Sex", True))
        Me.S_SexTextBox.Location = New System.Drawing.Point(115, 119)
        Me.S_SexTextBox.Name = "S_SexTextBox"
        Me.S_SexTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_SexTextBox.TabIndex = 8
        '
        'S_HpayLabel
        '
        S_HpayLabel.AutoSize = True
        S_HpayLabel.Location = New System.Drawing.Point(37, 147)
        S_HpayLabel.Name = "S_HpayLabel"
        S_HpayLabel.Size = New System.Drawing.Size(29, 12)
        S_HpayLabel.TabIndex = 9
        S_HpayLabel.Text = "時給"
        '
        'S_HpayTextBox
        '
        Me.S_HpayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Hpay", True))
        Me.S_HpayTextBox.Location = New System.Drawing.Point(115, 144)
        Me.S_HpayTextBox.Name = "S_HpayTextBox"
        Me.S_HpayTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_HpayTextBox.TabIndex = 10
        '
        'S_SectonLabel
        '
        S_SectonLabel.AutoSize = True
        S_SectonLabel.Location = New System.Drawing.Point(37, 172)
        S_SectonLabel.Name = "S_SectonLabel"
        S_SectonLabel.Size = New System.Drawing.Size(0, 12)
        S_SectonLabel.TabIndex = 11
        '
        'S_SectonTextBox
        '
        Me.S_SectonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Secton", True))
        Me.S_SectonTextBox.Location = New System.Drawing.Point(115, 169)
        Me.S_SectonTextBox.Name = "S_SectonTextBox"
        Me.S_SectonTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_SectonTextBox.TabIndex = 12
        '
        'S_PhoneLabel
        '
        S_PhoneLabel.AutoSize = True
        S_PhoneLabel.Location = New System.Drawing.Point(37, 197)
        S_PhoneLabel.Name = "S_PhoneLabel"
        S_PhoneLabel.Size = New System.Drawing.Size(49, 12)
        S_PhoneLabel.TabIndex = 13
        S_PhoneLabel.Text = "S Phone:"
        '
        'S_PhoneTextBox
        '
        Me.S_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VB_StaffBindingSource, "S_Phone", True))
        Me.S_PhoneTextBox.Location = New System.Drawing.Point(115, 194)
        Me.S_PhoneTextBox.Name = "S_PhoneTextBox"
        Me.S_PhoneTextBox.Size = New System.Drawing.Size(104, 19)
        Me.S_PhoneTextBox.TabIndex = 14
        '
        'S_ResignflagLabel
        '
        S_ResignflagLabel.AutoSize = True
        S_ResignflagLabel.Location = New System.Drawing.Point(37, 224)
        S_ResignflagLabel.Name = "S_ResignflagLabel"
        S_ResignflagLabel.Size = New System.Drawing.Size(72, 12)
        S_ResignflagLabel.TabIndex = 15
        S_ResignflagLabel.Text = "S Resignflag:"
        '
        'S_ResignflagCheckBox
        '
        Me.S_ResignflagCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VB_StaffBindingSource, "S_Resignflag", True))
        Me.S_ResignflagCheckBox.Location = New System.Drawing.Point(115, 219)
        Me.S_ResignflagCheckBox.Name = "S_ResignflagCheckBox"
        Me.S_ResignflagCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.S_ResignflagCheckBox.TabIndex = 16
        Me.S_ResignflagCheckBox.Text = "CheckBox1"
        Me.S_ResignflagCheckBox.UseVisualStyleBackColor = True
        '
        'frmStaffDET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 276)
        Me.Controls.Add(S_CodeLabel)
        Me.Controls.Add(Me.S_CodeTextBox)
        Me.Controls.Add(S_NameLabel)
        Me.Controls.Add(Me.S_NameTextBox)
        Me.Controls.Add(S_KanaLabel)
        Me.Controls.Add(Me.S_KanaTextBox)
        Me.Controls.Add(S_SexLabel)
        Me.Controls.Add(Me.S_SexTextBox)
        Me.Controls.Add(S_HpayLabel)
        Me.Controls.Add(Me.S_HpayTextBox)
        Me.Controls.Add(S_SectonLabel)
        Me.Controls.Add(Me.S_SectonTextBox)
        Me.Controls.Add(S_PhoneLabel)
        Me.Controls.Add(Me.S_PhoneTextBox)
        Me.Controls.Add(S_ResignflagLabel)
        Me.Controls.Add(Me.S_ResignflagCheckBox)
        Me.Controls.Add(Me.VB_StaffBindingNavigator)
        Me.Name = "frmStaffDET"
        Me.Text = "Form1"
        CType(Me._14jydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VB_StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VB_StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VB_StaffBindingNavigator.ResumeLayout(False)
        Me.VB_StaffBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _14jydbDataSet As Step2._14jydbDataSet
    Friend WithEvents VB_StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VB_StaffTableAdapter As Step2._14jydbDataSetTableAdapters.VB_StaffTableAdapter
    Friend WithEvents TableAdapterManager As Step2._14jydbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VB_StaffBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VB_StaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents S_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_KanaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_HpayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_SectonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents S_ResignflagCheckBox As System.Windows.Forms.CheckBox
End Class
