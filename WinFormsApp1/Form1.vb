Imports System.IO

Public Class Form1
    Private originalRows As New List(Of String())
    Private Sub btnSelectCsv_Click(sender As Object, e As EventArgs) Handles btnSelectCsv.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "CSVファイル(*.csv)|*.csv|テキストファイル(*.txt)|*.txt"
        ofd.Title = "CSVファイルを選択してください"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = ofd.FileName
            LoadCsv(filePath)
        End If
    End Sub

    Private Sub LoadCsv(filePath As String)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        Dim lines() As String = File.ReadAllLines(filePath)
        If lines.Length = 0 Then Return

        Dim headers() As String = lines(0).Split(","c)
        For Each header As String In headers
            DataGridView1.Columns.Add(header.Trim().Replace(" ", "").Replace("　", ""), header.Trim().Replace(" ", "").Replace("　", ""))
        Next

        originalRows.Clear()

        For i As Integer = 1 To lines.Length - 1
            Dim rowData() As String = lines(i).Split(","c)
            Dim trimmedRowData() As String = rowData.Select(Function(cell) cell.Trim()).ToArray()
            DataGridView1.Rows.Add(trimmedRowData)
            originalRows.Add(trimmedRowData)
        Next
    End Sub

    Private Sub btnSaveCsv_Click(sender As Object, e As EventArgs) Handles btnSaveCsv.Click
        If DataGridView1.Columns.Count = 0 Then
            MessageBox.Show("保存するデータがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSVファイル(*.csv)|*.csv"
        sfd.Title = "保存先を選択してください"
        sfd.FileName = "output.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim savePath As String = sfd.FileName
            SaveCsv(savePath)
            MessageBox.Show("CSVファイルを保存しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SaveCsv(filePath As String)
        Using sw As New StreamWriter(filePath, False, System.Text.Encoding.UTF8)
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In DataGridView1.Columns
                headers.Add(col.HeaderText)
            Next
            sw.WriteLine(String.Join(",", headers))


            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim cells As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                        If cellValue.Contains(",") OrElse cellValue.Contains("""") OrElse cellValue.Contains(vbCr) OrElse cellValue.Contains(vbLf) Then
                            cellValue = """" & cellValue.Replace("""", """""") & """"
                        End If
                        cells.Add(cellValue)
                    Next
                    sw.WriteLine(String.Join(",", cells))
                End If
            Next
        End Using
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim keyword As String = searchBox.Text.Trim()
        DataGridView1.Rows.Clear()

        For Each row As String() In originalRows

            If row(0).Contains(keyword) Then
                DataGridView1.Rows.Add(row)
            End If
        Next
    End Sub

End Class
