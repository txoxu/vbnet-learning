Imports Microsoft.Data.SqlClient

Public Class Task2Model

    Public Shared Sub InsertQuery(dt As DataTable)
        ' SQL Serverに接続
        Call sql_start()
        ' SQL Serverにデータを挿入するためのコマンドを作成
        Dim sqlCommand As New SqlCommand()
        sqlCommand.Connection = Module1.sqlsvCon
        ' データテーブルの各行をループして挿入
        For Each row As DataRow In dt.Rows
            sqlCommand.CommandText = "INSERT INTO [dbo].[Table] (Name, Kana, Age) VALUES (@Name, @Kana, @Age)"
            sqlCommand.Parameters.Clear()
            sqlCommand.Parameters.AddWithValue("@Name", row("Name"))
            sqlCommand.Parameters.AddWithValue("@Kana", row("Kana"))
            sqlCommand.Parameters.AddWithValue("@Age", row("Age"))
            sql_result_no(sqlCommand.CommandText)
        Next

        ' SQL Serverの接続を閉じる
        Call sql_close()
    End Sub
End Class
