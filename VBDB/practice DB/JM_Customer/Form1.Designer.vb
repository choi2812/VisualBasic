<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim C_CodeLabel As System.Windows.Forms.Label
        Dim C_NameLabel As System.Windows.Forms.Label
        Dim C_kanaLabel As System.Windows.Forms.Label
        Dim C_PostNoLabel As System.Windows.Forms.Label
        Dim C_Address1Label As System.Windows.Forms.Label
        Dim C_Address2Label As System.Windows.Forms.Label
        Dim C_PhoneLabel As System.Windows.Forms.Label
        Dim C_PersonalPhoneLabel As System.Windows.Forms.Label
        Dim C_AdmissionLabel As System.Windows.Forms.Label
        Me._14jydbDataSet = New JM_Customer._14jydbDataSet()
        Me.JM_CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JM_CustomerTableAdapter = New JM_Customer._14jydbDataSetTableAdapters.JM_CustomerTableAdapter()
        Me.TableAdapterManager = New JM_Customer._14jydbDataSetTableAdapters.TableAdapterManager()
        Me.JM_CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.JM_CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.C_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.C_NameTextBox = New System.Windows.Forms.TextBox()
        Me.C_kanaTextBox = New System.Windows.Forms.TextBox()
        Me.C_PostNoTextBox = New System.Windows.Forms.TextBox()
        Me.C_Address1TextBox = New System.Windows.Forms.TextBox()
        Me.C_Address2TextBox = New System.Windows.Forms.TextBox()
        Me.C_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.C_PersonalPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.C_AdmissionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        C_CodeLabel = New System.Windows.Forms.Label()
        C_NameLabel = New System.Windows.Forms.Label()
        C_kanaLabel = New System.Windows.Forms.Label()
        C_PostNoLabel = New System.Windows.Forms.Label()
        C_Address1Label = New System.Windows.Forms.Label()
        C_Address2Label = New System.Windows.Forms.Label()
        C_PhoneLabel = New System.Windows.Forms.Label()
        C_PersonalPhoneLabel = New System.Windows.Forms.Label()
        C_AdmissionLabel = New System.Windows.Forms.Label()
        CType(Me._14jydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JM_CustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_14jydbDataSet
        '
        Me._14jydbDataSet.DataSetName = "_14jydbDataSet"
        Me._14jydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JM_CustomerBindingSource
        '
        Me.JM_CustomerBindingSource.DataMember = "JM_Customer"
        Me.JM_CustomerBindingSource.DataSource = Me._14jydbDataSet
        '
        'JM_CustomerTableAdapter
        '
        Me.JM_CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JM_CustomerTableAdapter = Me.JM_CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = JM_Customer._14jydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JM_CustomerBindingNavigator
        '
        Me.JM_CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JM_CustomerBindingNavigator.BindingSource = Me.JM_CustomerBindingSource
        Me.JM_CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JM_CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JM_CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JM_CustomerBindingNavigatorSaveItem})
        Me.JM_CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JM_CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JM_CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JM_CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JM_CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JM_CustomerBindingNavigator.Name = "JM_CustomerBindingNavigator"
        Me.JM_CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JM_CustomerBindingNavigator.Size = New System.Drawing.Size(757, 25)
        Me.JM_CustomerBindingNavigator.TabIndex = 0
        Me.JM_CustomerBindingNavigator.Text = "BindingNavigator1"
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
        'JM_CustomerBindingNavigatorSaveItem
        '
        Me.JM_CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JM_CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("JM_CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JM_CustomerBindingNavigatorSaveItem.Name = "JM_CustomerBindingNavigatorSaveItem"
        Me.JM_CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.JM_CustomerBindingNavigatorSaveItem.Text = "データの保存"
        '
        'C_CodeLabel
        '
        C_CodeLabel.AutoSize = True
        C_CodeLabel.Location = New System.Drawing.Point(126, 49)
        C_CodeLabel.Name = "C_CodeLabel"
        C_CodeLabel.Size = New System.Drawing.Size(45, 12)
        C_CodeLabel.TabIndex = 1
        C_CodeLabel.Text = "C Code:"
        '
        'C_CodeTextBox
        '
        Me.C_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_Code", True))
        Me.C_CodeTextBox.Location = New System.Drawing.Point(230, 46)
        Me.C_CodeTextBox.Name = "C_CodeTextBox"
        Me.C_CodeTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_CodeTextBox.TabIndex = 2
        '
        'C_NameLabel
        '
        C_NameLabel.AutoSize = True
        C_NameLabel.Location = New System.Drawing.Point(126, 74)
        C_NameLabel.Name = "C_NameLabel"
        C_NameLabel.Size = New System.Drawing.Size(48, 12)
        C_NameLabel.TabIndex = 3
        C_NameLabel.Text = "C Name:"
        '
        'C_NameTextBox
        '
        Me.C_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_Name", True))
        Me.C_NameTextBox.Location = New System.Drawing.Point(230, 71)
        Me.C_NameTextBox.Name = "C_NameTextBox"
        Me.C_NameTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_NameTextBox.TabIndex = 4
        '
        'C_kanaLabel
        '
        C_kanaLabel.AutoSize = True
        C_kanaLabel.Location = New System.Drawing.Point(126, 99)
        C_kanaLabel.Name = "C_kanaLabel"
        C_kanaLabel.Size = New System.Drawing.Size(43, 12)
        C_kanaLabel.TabIndex = 5
        C_kanaLabel.Text = "C kana:"
        '
        'C_kanaTextBox
        '
        Me.C_kanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_kana", True))
        Me.C_kanaTextBox.Location = New System.Drawing.Point(230, 96)
        Me.C_kanaTextBox.Name = "C_kanaTextBox"
        Me.C_kanaTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_kanaTextBox.TabIndex = 6
        '
        'C_PostNoLabel
        '
        C_PostNoLabel.AutoSize = True
        C_PostNoLabel.Location = New System.Drawing.Point(126, 124)
        C_PostNoLabel.Name = "C_PostNoLabel"
        C_PostNoLabel.Size = New System.Drawing.Size(60, 12)
        C_PostNoLabel.TabIndex = 7
        C_PostNoLabel.Text = "C Post No:"
        '
        'C_PostNoTextBox
        '
        Me.C_PostNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_PostNo", True))
        Me.C_PostNoTextBox.Location = New System.Drawing.Point(230, 121)
        Me.C_PostNoTextBox.Name = "C_PostNoTextBox"
        Me.C_PostNoTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_PostNoTextBox.TabIndex = 8
        '
        'C_Address1Label
        '
        C_Address1Label.AutoSize = True
        C_Address1Label.Location = New System.Drawing.Point(126, 149)
        C_Address1Label.Name = "C_Address1Label"
        C_Address1Label.Size = New System.Drawing.Size(67, 12)
        C_Address1Label.TabIndex = 9
        C_Address1Label.Text = "C Address1:"
        '
        'C_Address1TextBox
        '
        Me.C_Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_Address1", True))
        Me.C_Address1TextBox.Location = New System.Drawing.Point(230, 146)
        Me.C_Address1TextBox.Name = "C_Address1TextBox"
        Me.C_Address1TextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_Address1TextBox.TabIndex = 10
        '
        'C_Address2Label
        '
        C_Address2Label.AutoSize = True
        C_Address2Label.Location = New System.Drawing.Point(126, 174)
        C_Address2Label.Name = "C_Address2Label"
        C_Address2Label.Size = New System.Drawing.Size(67, 12)
        C_Address2Label.TabIndex = 11
        C_Address2Label.Text = "C Address2:"
        '
        'C_Address2TextBox
        '
        Me.C_Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_Address2", True))
        Me.C_Address2TextBox.Location = New System.Drawing.Point(230, 171)
        Me.C_Address2TextBox.Name = "C_Address2TextBox"
        Me.C_Address2TextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_Address2TextBox.TabIndex = 12
        '
        'C_PhoneLabel
        '
        C_PhoneLabel.AutoSize = True
        C_PhoneLabel.Location = New System.Drawing.Point(126, 199)
        C_PhoneLabel.Name = "C_PhoneLabel"
        C_PhoneLabel.Size = New System.Drawing.Size(50, 12)
        C_PhoneLabel.TabIndex = 13
        C_PhoneLabel.Text = "C Phone:"
        '
        'C_PhoneTextBox
        '
        Me.C_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_Phone", True))
        Me.C_PhoneTextBox.Location = New System.Drawing.Point(230, 196)
        Me.C_PhoneTextBox.Name = "C_PhoneTextBox"
        Me.C_PhoneTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_PhoneTextBox.TabIndex = 14
        '
        'C_PersonalPhoneLabel
        '
        C_PersonalPhoneLabel.AutoSize = True
        C_PersonalPhoneLabel.Location = New System.Drawing.Point(126, 224)
        C_PersonalPhoneLabel.Name = "C_PersonalPhoneLabel"
        C_PersonalPhoneLabel.Size = New System.Drawing.Size(98, 12)
        C_PersonalPhoneLabel.TabIndex = 15
        C_PersonalPhoneLabel.Text = "C Personal Phone:"
        '
        'C_PersonalPhoneTextBox
        '
        Me.C_PersonalPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JM_CustomerBindingSource, "C_PersonalPhone", True))
        Me.C_PersonalPhoneTextBox.Location = New System.Drawing.Point(230, 221)
        Me.C_PersonalPhoneTextBox.Name = "C_PersonalPhoneTextBox"
        Me.C_PersonalPhoneTextBox.Size = New System.Drawing.Size(200, 19)
        Me.C_PersonalPhoneTextBox.TabIndex = 16
        '
        'C_AdmissionLabel
        '
        C_AdmissionLabel.AutoSize = True
        C_AdmissionLabel.Location = New System.Drawing.Point(126, 250)
        C_AdmissionLabel.Name = "C_AdmissionLabel"
        C_AdmissionLabel.Size = New System.Drawing.Size(72, 12)
        C_AdmissionLabel.TabIndex = 17
        C_AdmissionLabel.Text = "C Admission:"
        '
        'C_AdmissionDateTimePicker
        '
        Me.C_AdmissionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JM_CustomerBindingSource, "C_Admission", True))
        Me.C_AdmissionDateTimePicker.Location = New System.Drawing.Point(230, 246)
        Me.C_AdmissionDateTimePicker.Name = "C_AdmissionDateTimePicker"
        Me.C_AdmissionDateTimePicker.Size = New System.Drawing.Size(200, 19)
        Me.C_AdmissionDateTimePicker.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 460)
        Me.Controls.Add(C_CodeLabel)
        Me.Controls.Add(Me.C_CodeTextBox)
        Me.Controls.Add(C_NameLabel)
        Me.Controls.Add(Me.C_NameTextBox)
        Me.Controls.Add(C_kanaLabel)
        Me.Controls.Add(Me.C_kanaTextBox)
        Me.Controls.Add(C_PostNoLabel)
        Me.Controls.Add(Me.C_PostNoTextBox)
        Me.Controls.Add(C_Address1Label)
        Me.Controls.Add(Me.C_Address1TextBox)
        Me.Controls.Add(C_Address2Label)
        Me.Controls.Add(Me.C_Address2TextBox)
        Me.Controls.Add(C_PhoneLabel)
        Me.Controls.Add(Me.C_PhoneTextBox)
        Me.Controls.Add(C_PersonalPhoneLabel)
        Me.Controls.Add(Me.C_PersonalPhoneTextBox)
        Me.Controls.Add(C_AdmissionLabel)
        Me.Controls.Add(Me.C_AdmissionDateTimePicker)
        Me.Controls.Add(Me.JM_CustomerBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._14jydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JM_CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JM_CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JM_CustomerBindingNavigator.ResumeLayout(False)
        Me.JM_CustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _14jydbDataSet As JM_Customer._14jydbDataSet
    Friend WithEvents JM_CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JM_CustomerTableAdapter As JM_Customer._14jydbDataSetTableAdapters.JM_CustomerTableAdapter
    Friend WithEvents TableAdapterManager As JM_Customer._14jydbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JM_CustomerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents JM_CustomerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents C_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_kanaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_PostNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_Address1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_Address2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_PersonalPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_AdmissionDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
