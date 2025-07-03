Imports Accessibility




Public Class Form2
    Private Sub Fom2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form2のロード時にsql serverに接続
        Call sql_start()

        '選択した行のIdを取得
        Dim Id As Integer = Form1.DataGridView1.SelectedRows(0).Cells("Id").Value

        '選択したIｄを使ってSQLクエリを作成
        Dim sqlShow As String = "SELECT"
        sqlShow &= " *"
        sqlShow &= " FROM [dbo].[Table]"
        sqlShow &= " WHERE Id = " & Id.ToString & ";"

        'sqlクエリからの結果をdatatableに格納
        Dim Show As DataTable = sql_result_return(sqlShow)

        Call sql_close()


        Dim y As Integer = 10

        '詳細情報に必要なラベルをカラムの数だけ作成
        For Each column As DataColumn In Show.Columns
            Dim lbl As New Label()
            lbl.Text = column.ColumnName
            lbl.Location = New Point(20, y)
            y += 70
            Me.Controls.Add(lbl)
        Next

        y = 30

        '詳細情報に必要なテキストボックスをカラムの数だけ作成
        For i As Integer = 0 To Show.Columns.Count - 1
            Dim txt As New TextBox()
            txt.Text = Show.Rows(0).ItemArray(i)
            txt.Location = New Point(20, y)
            txt.ReadOnly = True ' テキストボックスを読み取り専用に設定
            y += 70
            Me.Controls.Add(txt)
        Next



    End Sub

End Class