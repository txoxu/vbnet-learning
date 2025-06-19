Public Class Form1
    '課題１ 文字列処理の基本操作ツールを作ろう
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        lstOutput.Items.Clear()

        lstOutput.Items.AddRange(Task1Controller.ProcessAll(txtInput.Text).ToArray())

    End Sub
End Class
