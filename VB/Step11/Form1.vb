Public Class frmTextEditor
    Dim File As String
    Public findstr As String '検索文字列
    Public find As String
    Public replace As String
    Public startpos As Integer
    Private Sub mnuQuit_Click(sender As System.Object, e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtText.TextChanged

    End Sub

    Private Sub frmTextEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtText.Top = 51
        txtText.Left = 0
        tbrFontSize.Text = 16
        tbrFonttype.Text = "MS UI Gothic"
    End Sub

    Private Sub tbrCopy_Click(sender As System.Object, e As System.EventArgs) Handles tbrCopy.Click
        EditCopy()
    End Sub

    Private Sub mnuCopy_Click(sender As System.Object, e As System.EventArgs) Handles mnuCopy.Click
        EditCopy()
    End Sub
    Private Sub EditCopy()
        If txtText.SelectedText <> "" Then
            txtText.Copy()
        End If
    End Sub

    Private Sub tbrCut_Click(sender As System.Object, e As System.EventArgs) Handles tbrCut.Click
        EditCut()
    End Sub

    Private Sub mnuCut_Click(sender As System.Object, e As System.EventArgs) Handles mnuCut.Click
        EditCut()
    End Sub
    Private Sub EditCut()
        If txtText.SelectedText <> "" Then
            txtText.Cut()
        End If
    End Sub

    Private Sub mnuPaste_Click(sender As System.Object, e As System.EventArgs) Handles mnuPaste.Click
        EditPaste()
    End Sub

    Private Sub tbrPaste_Click(sender As System.Object, e As System.EventArgs) Handles tbrPaste.Click
        EditPaste()
    End Sub
    Private Sub EditPaste()
        txtText.Paste()
    End Sub

    Private Sub tbrFontSize_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbrFontSize.TextChanged
        Dim fontsize As Integer
        fontsize = Val(tbrFontSize.Text)
        txtText.Font = New Font(tbrFonttype.Text, fontsize)
    End Sub

    Private Sub mnuUndo_Click(sender As System.Object, e As System.EventArgs) Handles mnuUndo.Click
        txtText.Undo()
    End Sub

    Private Sub tbrFonttype_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbrFonttype.TextChanged
        Dim Type As String
        Type = tbrFonttype.Text
        txtText.Font = New Font(Type, Val(tbrFontSize.Text))
    End Sub

    Private Sub mnuOpen_Click(sender As System.Object, e As System.EventArgs) Handles mnuOpen.Click
        subOpen()
    End Sub

    Private Sub mnuAppend_Click(sender As System.Object, e As System.EventArgs) Handles mnuAppend.Click
        Dim text() As String

        SaveFileDialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, SaveFileDialog.FileName, OpenMode.Output)
            text = Split(txtText.Text, vbCrLf)
            For i As Integer = 0 To UBound(text)
                PrintLine(1, text(i))
            Next
            File = SaveFileDialog.FileName
            Me.Text = File & " - テキストエデイタ"
            FileClose(1)
        End If
    End Sub

    Private Sub mnuSurge_Click(sender As System.Object, e As System.EventArgs) Handles mnuStrip.Click
        subStrip()

    End Sub
    Private Sub subStrip()
        Dim text() As String

        If File = "" Then

            SaveFileDialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
            If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                FileOpen(1, SaveFileDialog.FileName, OpenMode.Output)
                text = Split(txtText.Text, vbCrLf)
                For i As Integer = 0 To UBound(text)
                    PrintLine(1, text(i))
                Next
                File = SaveFileDialog.FileName
                FileClose(1)
            End If
        Else
            FileOpen(1, File, OpenMode.Output)
            text = Split(txtText.Text, vbCrLf)
            For i As Integer = 0 To UBound(text)
                PrintLine(1, text(i))
            Next

            Me.Text = File & " - テキストエデイタ"
            FileClose(1)
        End If
    End Sub

    Private Sub tbrStripButton_Click(sender As System.Object, e As System.EventArgs) Handles tbrStripButton.Click
        subStrip()
    End Sub

    Private Sub mnuNewItem_Click(sender As System.Object, e As System.EventArgs) Handles mnuNewItem.Click
        Dim ret As DialogResult
        If txtText.Modified = True Then
            ret = MessageBox.Show("変更を保存しますか?", "新規作成", MessageBoxButtons.YesNoCancel)
            If ret = Windows.Forms.DialogResult.Yes Then
                Dim text() As String

                SaveFileDialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
                If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    FileOpen(1, SaveFileDialog.FileName, OpenMode.Output)
                    text = Split(txtText.Text, vbCrLf)
                    For i As Integer = 0 To UBound(text)
                        PrintLine(1, text(i))
                    Next
                    File = SaveFileDialog.FileName
                    FileClose(1)
                    txtText.Clear()
                End If
            ElseIf ret = Windows.Forms.DialogResult.No Then
                txtText.Clear()
                File = "無題"
                Me.Text = File & " - テキストエデイタ"
            End If
        Else
            txtText.Clear()
            File = "無題"
            Me.Text = File & " - テキストエデイタ"
        End If
    End Sub

    Private Sub tbrNewItem_Click(sender As System.Object, e As System.EventArgs) Handles tbrNewItem.Click
        Dim ret As DialogResult
        If txtText.Modified = True Then
            ret = MessageBox.Show("変更を保存しますか?", "新規作成", MessageBoxButtons.YesNoCancel)
            If ret = Windows.Forms.DialogResult.Yes Then
                Dim text() As String

                SaveFileDialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
                If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    FileOpen(1, SaveFileDialog.FileName, OpenMode.Output)
                    text = Split(txtText.Text, vbCrLf)
                    For i As Integer = 0 To UBound(text)
                        PrintLine(1, text(i))
                    Next
                    File = SaveFileDialog.FileName
                    FileClose(1)
                    txtText.Clear()
                End If
            ElseIf ret = Windows.Forms.DialogResult.No Then
                txtText.Clear()
                File = "無題"
                Me.Text = File & " - テキストエデイタ"
            End If
        Else
            txtText.Clear()
            File = "無題"
            Me.Text = File & " - テキストエデイタ"
        End If
    End Sub

    Private Sub tbrOpen_Click(sender As System.Object, e As System.EventArgs) Handles tbrOpen.Click
        subOpen()
    End Sub
    Private Sub subOpen()
        txtText.Text = ""
        Dim buf As String

        OpenFileDialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, OpenFileDialog.FileName, OpenMode.Input)
            Do While Not EOF(1)
                buf = LineInput(1)
                txtText.Text &= buf & vbCrLf

            Loop
            File = OpenFileDialog.FileName
            FileClose(1)
        End If
        Me.Text = File & " - テキストエデイタ"
    End Sub
    Friend Sub subFind1()
        Dim findpos, startpos As Integer
        Dim findstr As String

        findstr = InputBox("検索文字列")
        If txtText.Text = "" Or findstr = "" Then
            Exit Sub
        End If

        startpos = 0
        findpos = txtText.Text.IndexOf(findstr, startpos)
        If findpos >= 0 Then
            txtText.Select(findpos, findstr.Length)
        Else
            MessageBox.Show("検索文字列はありませんでした。", "検索")
        End If
    End Sub
    Friend Sub subFind()
        Dim findpos As Integer


        If txtText.Text = "" Or findstr = "" Then
            Exit Sub
        End If

        findpos = txtText.Text.IndexOf(findstr, startpos)

        If findpos >= 0 Then
            txtText.Select(findpos, findstr.Length)
            startpos = findpos + findstr.Length
        Else
            MessageBox.Show("検索文字列はありませんでした。", "検索")
        End If

    End Sub
    Friend Sub subFind2()
        Dim findpos As Integer
        Dim startpos As Integer = 0

        If txtText.Text = "" Or find = "" Then
            Exit Sub
        End If

        findpos = txtText.Text.IndexOf(find, startpos)

        If findpos >= 0 Then
            txtText.Text = txtText.Text.Replace(find, replace)
        Else
            MessageBox.Show("置換文字列はありませんでした。", "置換")
        End If



    End Sub

    Private Sub mnuFind_Click(sender As System.Object, e As System.EventArgs) Handles mnuFind.Click
        'subFind1()

        Dim fFind As New frmFind
        mnuFind.Enabled = False
        startpos = 0
        fFind.Show()
    End Sub

    Private Sub mnuReplace_Click(sender As System.Object, e As System.EventArgs) Handles mnuReplace.Click
        Dim fReplace As New frmReplace
        mnuReplace.Enabled = False
        startpos = 0
        fReplace.Show()
    End Sub
End Class
