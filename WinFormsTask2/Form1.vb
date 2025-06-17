Public Class Form1
    '課題２ 複数行テキストの分割とDataGridView表示
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lists As New List(Of String())

        lists.Add(task2Controller.SplitCsvLine(textInput.Text)) '文字列stringー＞配列へstring()

        For i = 0 To lists.Count - 1
            DataGridView1.Rows.Add(lists(i))
        Next
    End Sub

    Private Sub list_load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Name", "名前")
        DataGridView1.Columns.Add("name", "読み方")
        DataGridView1.Columns.Add("age", "年齢")
    End Sub

End Class
