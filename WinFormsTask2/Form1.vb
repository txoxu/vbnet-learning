Public Class Form1
    '課題２ 複数行テキストの分割とDataGridView表示
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Name", "名前")
        DataGridView1.Columns.Add("name", "読み方")
        DataGridView1.Columns.Add("age", "年齢")

        Task2Controller.Initialize(Me)

    End Sub

End Class
