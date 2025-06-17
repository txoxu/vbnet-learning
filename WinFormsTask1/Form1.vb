Public Class Form1
    '課題１ 文字列処理の基本操作ツールを作ろう
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim txts = txtInput.Text
        process_load(txts)
    End Sub

    Private Sub process_load(ByRef txts As String)


        lstOutput.Items.Add(Task1Controller.TrimText(txts))

        lstOutput.Items.Add(Task1Controller.ReplaceTxt(txts))


        Dim inputTxts = Task1Controller.SplitTxt(txts)
        For Each txt As String In inputTxts
            lstOutput.Items.Add(txt)
        Next

        lstOutput.Items.Add(Task1Controller.JoinTxt(inputTxts))
    End Sub
End Class
