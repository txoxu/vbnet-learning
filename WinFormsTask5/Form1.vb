Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    'データテーブルを作成
    Dim data As New DataTable()

    '上書き保存の際に使用するためのグローバル変数
    Dim filePath As String

    'csvファイルを読み込む処理
    Private Sub btnLoadCsv_Click(sender As Object, e As EventArgs) Handles btnLoadCsv.Click
        'エクスプローラーを開き選択したファイルをdialogへ格納
        Dim dialog As New OpenFileDialog()

        'フィルターとしてcsvファイルだけに限定
        dialog.Filter = "CSVファイル(*.csv) | *.csv"

        'もし、ファイルを選択肢てokをクリックしたとき
        If dialog.ShowDialog() = DialogResult.OK Then
            'CSVファイル名を格納
            filePath = dialog.FileName
            'ラベルに表示
            lblStatus.Text = ("選択されたファイルは:" & filePath)

            '前回選択したファイルがあった場合のための初期化
            data.Clear()
            'ファイルをUTF8で書き込み、格納
            Dim lines = File.ReadAllLines(dialog.FileName, System.Text.Encoding.UTF8)
            '行ごとに繰り返し処理
            For Each line As String In lines
                '「,」を加えて格納
                Dim fields As String() = line.Split(","c)
                'もし、1行の長さが８のときdataに追加
                If fields.Length = 8 Then
                    data.Rows.Add(fields)
                End If

            Next
        End If


    End Sub


    Private Sub dgv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'data（datatable）に列を追加
        data.Columns.Add("社員ID")
        data.Columns.Add("氏名")
        data.Columns.Add("フリガナ")
        data.Columns.Add("所属部署")
        data.Columns.Add("メールアドレス")
        data.Columns.Add("電話番号")
        data.Columns.Add("入社日")
        data.Columns.Add("在籍状況")
        dgvEmployees.DataSource = data
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    '上書き保存処理
    Private Sub btnSaveCsv_Click(sender As Object, e As EventArgs) Handles btnSaveCsv.Click
        'datagridviewで変更された内容を格納
        Dim csvContent As New Text.StringBuilder()

        '行ごとに繰り返し処理を実行
        For Each row As DataGridViewRow In dgvEmployees.Rows
            '新しい行がない場合に処理
            If Not row.IsNewRow Then
                '行の一つ一つのセルごとに繰り返し処理を実行
                For Each cell As DataGridViewCell In row.Cells
                    '「,」事に区切る
                    csvContent.Append(cell.Value.ToString() & ",")
                Next
                '最後のセルの「,」を削除
                csvContent.Length -= 1
                '格納を決定
                csvContent.AppendLine()
            End If
        Next

        'もともとのファイルをcsvContentで上書き
        System.IO.File.WriteAllText(filePath, csvContent.ToString(), System.Text.Encoding.UTF8)
    End Sub

    Private Sub btnSaveAsCsv_Click(sender As Object, e As EventArgs) Handles btnSaveAsCsv.Click
        'エクスプローラーを開く
        Dim saveDialog As New SaveFileDialog()

        'csvファイルでの保存でフィルタ
        saveDialog.Filter = "CSVファイル(*.csv)| *.csv"
        saveDialog.Title = "名前を付けて保存"

        'もし、保存場所を選択してokをクリックした場合の処理
        If saveDialog.ShowDialog() = DialogResult.OK Then
            'ファイル名を格納
            Dim savePath As String = saveDialog.FileName
            'ファイルのデータを格納
            Dim csvContent As New Text.StringBuilder()

            '各行を繰り返し処理
            For Each row As DataGridViewRow In dgvEmployees.Rows
                If Not row.IsNewRow Then
                    Dim rowData As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        rowData.Add(cell.Value.ToString())
                    Next
                    csvContent.AppendLine(String.Join(",", rowData))
                End If
            Next
            System.IO.File.WriteAllText(savePath, csvContent.ToString(), System.Text.Encoding.UTF8)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '入力されたtextSeach.textを変数へ格納
        Dim num As String = textSearch.Text.Trim()

        '検索結果用のdatatableを定義
        Dim searchResult As New DataTable()


        'searchResultにカラムを反映
        For Each column As DataGridViewColumn In dgvEmployees.Columns
            searchResult.Columns.Add(column.HeaderText)
        Next

        Dim searchCount As Integer = 0

        'datagridviewからrowに格納し繰り返し処理
        For Each row As DataGridViewRow In dgvEmployees.Rows
            If Not row.IsNewRow Then
                'もし、入力された値と列の０番目（社員番号）が同じ時の処理
                If row.Cells(0).Value.ToString().Trim() = num Then
                    '検索結果に新しい行を追加
                    Dim newRow As DataRow = searchResult.NewRow()
                    'datagridviewのカラム数（０～のため-1）繰り返し処理
                    For i As Integer = 0 To dgvEmployees.ColumnCount - 1
                        '新しい列のi番目の行に値を追加
                        newRow(i) = row.Cells(i).Value.ToString()
                    Next
                    '検索結果用の表に追加
                    searchResult.Rows.Add(newRow)
                    searchCount += 1
                End If
            End If
        Next

        If searchCount > 0 Then
            lblStatus.Text = ("検索結果は" & searchCount & "件です")
        Else
            lblStatus.Text = "検索結果は０です"
        End If
        'searchResultをバインド
        dgvEmployees.DataSource = searchResult
    End Sub

    '検索結果のリセット
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        data.Clear()

        Dim lines As String() = File.ReadAllLines(filePath, System.Text.Encoding.UTF8)


        For Each line As String In lines
            Dim fields As String() = line.Split(","c)
            If fields.Length = 8 Then
                data.Rows.Add(fields)
            End If
        Next
        dgvEmployees.DataSource = data
        lblStatus.Text = "検索結果をリセットしました"
    End Sub

    '行削除機能
    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        'dgvEnployeesで行を選択
        If dgvEmployees.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvEmployees.SelectedRows
                If Not row.IsNewRow Then
                    dgvEmployees.Rows.Remove(row)
                End If
            Next
            lblStatus.Text = "行を削除しました"
        Else
            lblStatus.Text = "行を削除できませんでした"
        End If
    End Sub
End Class
