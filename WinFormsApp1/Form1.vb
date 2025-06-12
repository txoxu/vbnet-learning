Imports System.IO
Imports System.Data

Public Class Form1

    '課題１
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim txts As String = txtInput.Text
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


    '課題２
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lists As New List(Of String())
        lists.Add(textInput.Text.Split(","c)) '文字列stringー＞配列へstring()
        For i As Integer = 0 To lists.Count - 1
            DataGridView1.Rows.Add(lists(i))
        Next
    End Sub

    Private Sub list_load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Name", "名前")
        DataGridView1.Columns.Add("name", "読み方")
        DataGridView1.Columns.Add("age", "年齢")
    End Sub


    '課題3

    Dim table As New DataTable()
    Dim currentFilePath As String = ""
    Private Sub btnCsvRead_Click(sender As Object, e As EventArgs) Handles btnCsvRead.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "csvファイル(*.csv)|*.csv"

        If dialog.ShowDialog() = DialogResult.OK Then
            currentFilePath = dialog.FileName
            table.Clear()
            Dim lines = File.ReadAllLines(currentFilePath, System.Text.Encoding.UTF8)


            For Each line As String In lines
                Dim fields = line.Split(","c)
                If fields.Length = 3 Then
                    table.Rows.Add(fields)
                End If
            Next
        End If
    End Sub


    Private Sub form_load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("名前")
        table.Columns.Add("読み方")
        table.Columns.Add("年齢")

        DataGridView.DataSource = table
    End Sub


    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = searchText.Text.Trim()

        If keyword = "" Then
            table.DefaultView.RowFilter = ""
        Else
            table.DefaultView.RowFilter = $"名前 like '%{keyword}%' or 読み方 like '%{keyword}%'"
        End If
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentFilePath = "" Then
            MessageBox.Show("ファイルが読み込まれていません")
            Return
        End If

        Try
            Using writer As New StreamWriter(currentFilePath, False, System.Text.Encoding.UTF8)
                For Each row As DataRow In table.Rows
                    Dim line As String = String.Join(",", row.ItemArray)
                    writer.WriteLine(line)
                Next
            End Using
            MessageBox.Show("上書き保存しました")
        Catch ex As Exception
            MessageBox.Show("保存中にエラーが発生しました:" & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
