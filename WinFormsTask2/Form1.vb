Public Class Form1
    '課題２ 複数行テキストの分割とDataGridView表示
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call sql_start()

        FormRefresh()

        Call sql_close()
        Task2Controller.Initialize(Me)

    End Sub

End Class
