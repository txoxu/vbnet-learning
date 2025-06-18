Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    'csvファイルを読み込む処理
    Private Sub btnLoadCsv_Click(sender As Object, e As EventArgs) Handles btnLoadCsv.Click
        'エクスプローラーを開き選択したファイルをdialogへ格納
        Dim dialog As New OpenFileDialog()
        'フィルターとしてcsvファイルだけに限定
        dialog.Filter = "CSVファイル(*.csv) | *.csv"
        'もし、ファイルを選択肢てokをクリックしたとき
        If dialog.ShowDialog() = DialogResult.OK Then
            Task5Controller.CsvLoad(dialog.FileName)
            lblStatus.Text = ("選択されたファイルは:" & dialog.FileName)
        End If
    End Sub


    Private Sub dgv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'data（datatable）に列を追加
        With Task5Model.Data
            .Columns.Add("社員ID")
            .Columns.Add("氏名")
            .Columns.Add("フリガナ")
            .Columns.Add("所属部署")
            .Columns.Add("メールアドレス")
            .Columns.Add("電話番号")
            .Columns.Add("入社日")
            .Columns.Add("在籍状況")
        End With

        dgvEmployees.DataSource = Task5Model.Data
    End Sub


    '上書き保存処理
    Private Sub btnSaveCsv_Click(sender As Object, e As EventArgs) Handles btnSaveCsv.Click
        'datagridviewで変更された内容を格納
        Dim csvContent As New Text.StringBuilder()

        Task5Controller.CsvSave(csvContent, dgvEmployees)
        'もともとのファイルをcsvContentで上書き
        System.IO.File.WriteAllText(Task5Model.FilePath, csvContent.ToString(), System.Text.Encoding.UTF8)
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
            Task5Controller.CsvNewSave(csvContent, dgvEmployees)

            System.IO.File.WriteAllText(savePath, csvContent.ToString(), System.Text.Encoding.UTF8)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '入力されたtextSeach.textを変数へ格納
        Dim num As String = textSearch.Text.Trim()

        '検索結果用のdatatableを定義
        Dim searchResult As New DataTable()

        Dim searchCount As Integer = 0

        Task5Controller.CsvSearch(searchResult, dgvEmployees, num, searchCount)

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
        Task5Model.Data.Clear()

        Dim lines As String() = File.ReadAllLines(Task5Model.FilePath, System.Text.Encoding.UTF8)

        Task5Controller.CsvSearchReset(lines)

        dgvEmployees.DataSource = Task5Model.Data
        lblStatus.Text = "検索結果をリセットしました"
    End Sub

    '行削除機能
    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        lblStatus.Text = Task5Controller.CsvRowDelete(dgvEmployees)
    End Sub
End Class
