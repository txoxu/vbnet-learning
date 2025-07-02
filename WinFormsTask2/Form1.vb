Public Class Form1
    '課題２ 複数行テキストの分割とDataGridView表示
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call sql_start()

        Dim sql1 As String = "SELECT"
        sql1 &= " Name, Kana, Age"
        sql1 &= " FROM [dbo].[Table];"

        Dim dtb1 As DataTable = sql_result_return(sql1)

        DataGridView1.DataSource = dtb1

        Call sql_close()
        Task2Controller.Initialize(Me)

    End Sub

End Class
