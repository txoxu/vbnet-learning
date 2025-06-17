Public Class Form1
    '課題１ 文字列処理の基本操作ツールを作ろう
    Private Sub btnProcess_Click(sender As Object, e As EventArgs)
        Dim txts = txtInput.Text
        process_load(txts)
    End Sub

    Private Sub process_load(ByRef txts As String)
        'trim
        Dim trimTxt As String = txts.Trim()
        lstOutput.Items.Add(trimTxt)

        'replace
        Dim replaceTxt As String = txts.Replace(" ", "_").Replace("　", "_")
        lstOutput.Items.Add(replaceTxt)

        'split
        Dim splitTxt() As String = txts.Split(","c)
        For Each txt As String In splitTxt
            lstOutput.Items.Add(txt)
        Next


        'join
        Dim joinTxt As String = String.Join(" | ", splitTxt.Select(Function(s) s.Trim()))
        lstOutput.Items.Add(joinTxt)
    End Sub

End Class
