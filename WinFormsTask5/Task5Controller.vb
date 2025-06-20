Imports System.DirectoryServices
Imports System.IO
Imports System.Text

Public Class Task5Controller
    Public Shared Sub CsvLoad(DialogPath As String)
        Try
            'CSVファイル名を格納
            Task5Model.FilePath = DialogPath
            '前回選択したファイルがあった場合のための初期化
            Task5Model.Data.Clear()
            'ファイルをUTF8で書き込み、格納
            Dim lines = File.ReadAllLines(DialogPath, System.Text.Encoding.UTF8)
            '行ごとに繰り返し処理
            For Each line As String In lines
                '「,」を加えて格納
                Dim fields As String() = line.Split(","c)
                'もし、1行の長さが８のときdataに追加
                If fields.Length = 8 Then
                    Task5Model.Data.Rows.Add(fields)
                End If
            Next
        Catch ex As Exception
            Throw New ApplicationException("読み込みに失敗しました：" & ex.Message, ex)
        End Try
    End Sub

    Public Shared Sub CsvSave(CsvContent As StringBuilder, dgvEmployees As DataGridView)
        Try
            '行ごとに繰り返し処理を実行
            For Each row As DataGridViewRow In dgvEmployees.Rows
                '新しい行がない場合に処理
                If Not row.IsNewRow Then
                    '行の一つ一つのセルごとに繰り返し処理を実行
                    For Each cell As DataGridViewCell In row.Cells
                        '「,」事に区切る
                        CsvContent.Append(cell.Value.ToString() & ",")
                    Next
                    '最後のセルの「,」を削除
                    CsvContent.Length -= 1
                    '格納を決定
                    CsvContent.AppendLine()
                End If
            Next
            File.WriteAllText(Task5Model.FilePath, CsvContent.ToString(), System.Text.Encoding.UTF8)
        Catch ex As Exception
            Throw New ApplicationException("CSVファイルの保存中にエラーが発生しました。：" & ex.Message, ex)
        End Try
    End Sub

    Public Shared Sub CsvNewSave(savePath As String, dgvEmployees As DataGridView)
        Try

            'ファイルのデータを格納
            Dim csvContent As New Text.StringBuilder()

            '各行を繰り返し処理
            For Each row As DataGridViewRow In dgvEmployees.Rows
                If Not row.IsNewRow Then
                    Dim rowData As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing Then
                            rowData.Add(cell.Value.ToString())
                        Else
                            rowData.Add("")
                        End If
                    Next
                    csvContent.AppendLine(String.Join(",", rowData))
                End If
            Next
            System.IO.File.WriteAllText(savePath, csvContent.ToString(), System.Text.Encoding.UTF8)
        Catch ex As Exception
            Throw New ApplicationException("名前を付けて保存に失敗しました" & ex.Message, ex)
        End Try

    End Sub

    Public Shared Sub CsvSearch(searchResult As DataTable, dgvEmployees As DataGridView, num As String, ByRef searchCount As Integer)
        'searchResultにカラムを反映
        For Each column As DataGridViewColumn In dgvEmployees.Columns
            searchResult.Columns.Add(column.HeaderText)
        Next

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

    End Sub

    Public Shared Function CsvRowDelete(dgvEmployees As DataGridView)
        'dgvEnployeesで行を選択
        If dgvEmployees.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvEmployees.SelectedRows
                If Not row.IsNewRow Then
                    dgvEmployees.Rows.Remove(row)
                End If
            Next
            Return "行を削除しました"
        Else
            Return "行を削除できませんでした"
        End If
    End Function
End Class