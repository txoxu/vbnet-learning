Imports System.IO

Public Class Form1
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

End Class
