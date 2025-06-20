Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class Form1
    'csvファイルを読み込む処理
    Private Sub btnLoadCsv_Click(sender As Object, e As EventArgs) Handles btnLoadCsv.Click
        Try
            'エクスプローラーを開き選択したファイルをdialogへ格納
            Dim dialog As New OpenFileDialog()
            'フィルターとしてcsvファイルだけに限定
            dialog.Filter = "CSVファイル(*.csv) | *.csv"
            'もし、ファイルを選択肢てokをクリックしたとき
            If dialog.ShowDialog() = DialogResult.OK Then
                Task5Controller.CsvLoad(dialog.FileName)
                lblStatus.Text = ("選択されたファイルは:" & dialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("読み込みに失敗しました：" & ex.Message)
        End Try

    End Sub


    Private Sub dgv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        Task5Model.InitializeColumns()
        dgvEmployees.DataSource = Task5Model.Data
    End Sub


    '上書き保存処理
    Private Sub btnSaveCsv_Click(sender As Object, e As EventArgs) Handles btnSaveCsv.Click
        'datagridviewで変更された内容を格納
        Try
            Dim csvContent As New Text.StringBuilder()
            Task5Controller.CsvSave(csvContent, dgvEmployees)
            MessageBox.Show("CSVファイルを上書き保存しました")
        Catch ex As Exception
            MessageBox.Show("CSVファイルの上書き保存中にエラーが発生しました：" & ex.Message)
        End Try

    End Sub

    Private Sub btnSaveAsCsv_Click(sender As Object, e As EventArgs) Handles btnSaveAsCsv.Click
        Try
            'エクスプローラーを開く
            Dim saveDialog As New SaveFileDialog()

            'csvファイルでの保存でフィルタ
            saveDialog.Filter = "CSVファイル(*.csv)| *.csv"
            saveDialog.Title = "名前を付けて保存"

            'もし、保存場所を選択してokをクリックした場合の処理
            If saveDialog.ShowDialog() = DialogResult.OK Then
                'ファイル名を格納
                Dim savePath As String = saveDialog.FileName
                Task5Controller.CsvNewSave(savePath, dgvEmployees)
            End If
        Catch ex As Exception
            MessageBox.Show("名前を付けて保存に失敗しました" & ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '入力されたtextSeach.textを変数へ格納
        Dim num As String = StrConv(textSearch.Text.Trim(), VbStrConv.Narrow)
        num = StrConv(num, VbStrConv.Narrow)
        If Not System.Text.RegularExpressions.Regex.IsMatch(num, "^\d+$") Then
            MessageBox.Show("社員番号（数字）を正しく入力してください")
            Return
        End If
        Dim searchCount As Integer = 0

        Task5Controller.CsvSearch(Task5Model.SearchResult, dgvEmployees, num, searchCount)

        If searchCount > 0 Then
            lblStatus.Text = ("検索結果は" & searchCount & "件です")
        Else
            lblStatus.Text = "検索結果は０です"
        End If
        'searchResultをバインド
        dgvEmployees.DataSource = Task5Model.SearchResult
    End Sub

    '検索結果のリセット
    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        Task5Model.SearchResult.Clear()
        Task5Model.SearchResult.Columns.Clear()
        textSearch.Text = ""
        dgvEmployees.DataSource = Task5Model.Data
        lblStatus.Text = "検索結果をリセットしました"
    End Sub

    '行削除機能
    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        MessageBox.Show(Task5Controller.CsvRowDelete(dgvEmployees))
    End Sub
End Class
