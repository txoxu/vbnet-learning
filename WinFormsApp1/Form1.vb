Imports System.IO
Imports System.Data

Public Class Form1

    '課題１ 文字列処理の基本操作ツールを作ろう
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


    '課題２ 複数行テキストの分割とDataGridView表示
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


    '課題3 検索欄とボタンを設置し、名前や読み方でフィルタ表示

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
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "CSVファイル(*.csv)| *.csv"
        dialog.Title = "名前を付けて保存"

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(dialog.FileName, False, System.Text.Encoding.UTF8)
                    For Each row As DataGridViewRow In DataGridView.Rows
                        If Not row.IsNewRow Then
                            Dim values As New List(Of String)
                            For i As Integer = 0 To DataGridView.Columns.Count - 1
                                values.Add(row.Cells(i).Value?.ToString())
                            Next
                            writer.WriteLine(String.Join(",", values))
                        End If
                    Next
                End Using
                MessageBox.Show("保存しました")
            Catch ex As Exception
                MessageBox.Show("保存できませんでした" & ex.Message)
            End Try
        End If
    End Sub

    '課題4 新規追加・削除機能 + UI整理
    Dim table2 As New DataTable()
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "CSVファイル(*.csv) | *.csv"

        If dialog.ShowDialog() = DialogResult.OK Then
            table2.Clear()
            Dim lines = File.ReadAllLines(dialog.FileName, System.Text.Encoding.UTF8)

            For Each line As String In lines
                Dim fields = line.Split(","c)
                If fields.Length = 3 Then
                    table2.Rows.Add(fields)
                End If
            Next
        End If
    End Sub

    Private Sub form_Load2(sender As Object, ex As EventArgs) Handles MyBase.Load
        table2.Columns.Add("名前")
        table2.Columns.Add("読み方")
        table2.Columns.Add("年齢")
        DataGridView2.DataSource = table2

        ComboBox1.Items.Add("選択してください")
        ComboBox1.Items.Add("名前")
        ComboBox1.Items.Add("年齢")
        ComboBox1.SelectedIndex = 0
    End Sub



    '新規追加
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox3.Text <> "" Then
            table2.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            MessageBox.Show("名前と年齢を入力してください")
        End If
    End Sub

    '削除機能
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dt As DataTable = CType(DataGridView2.DataSource, DataTable)
        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            If Not row.IsNewRow Then
                dt.Rows(row.Index).Delete()
            End If
        Next
        dt.AcceptChanges()
    End Sub

    '並び替え
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim colName As String = If(ComboBox1.SelectedItem.ToString() = "名前", "読み方", "年齢")
        DataGridView2.Sort(DataGridView2.Columns(colName), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
