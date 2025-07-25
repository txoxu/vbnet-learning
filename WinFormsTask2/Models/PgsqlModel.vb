Imports System.Text
Imports Npgsql

Public Class PgsqlModel
    Implements IModel

    'postgresqlにアクセスする接続オブジェクト
    Public pgsqlCon As New NpgsqlConnection

    'postgresqlに対してSQL文を実行できるようにする
    Public sqlCommand As New NpgsqlCommand

    Public Function RowSelect(selectid As Integer) As DataTable Implements IModel.RowSelect
        Call sql_connect()

        '選択したIｄを使ってSQLクエリを作成
        Dim _sqlShow As String = "SELECT * FROM person WHERE Id = " & selectid.ToString & ";"

        'sqlクエリからの結果をdatatableに格納
        Dim sqlShow As DataTable = result_return(_sqlShow)

        Call sql_disconnect()

        Return sqlShow

    End Function

    Public Function FormRefresh() As DataTable Implements IModel.FormRefresh
        sql_connect()

        Dim sql As String = "SELECT Id, Name, Kana, Age, Date FROM person;"
        Dim dt As DataTable = result_return(sql)

        sql_disconnect()

        Return dt

    End Function

    Public Function Search(data As SearchData) As DataTable Implements IModel.Search
        sql_connect()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT Id, Name, Kana, Age, Date")
        queryBuilder.AppendLine("FROM person")
        queryBuilder.AppendLine("WHERE Name LIKE N'" & "%" & data.NameData & "%" & "'")

        If data.DateData IsNot Nothing Then
            queryBuilder.AppendLine("AND Date = (select '" & data.DateData & "'::date)")
        End If

        If data.FirstNumData <> Nothing Or data.LastNumData <> Nothing Then
            queryBuilder.AppendLine("AND Age BETWEEN '" & data.FirstNumData & "' AND '" & data.LastNumData & "'")
        End If
        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()


        Dim dt As DataTable = result_return(sqlCommand.CommandText)
        sql_disconnect()
        Return dt

    End Function

    Public Sub Destroy(selectId As Integer) Implements IModel.Destroy
        Call sql_connect()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("DELETE FROM person")
        queryBuilder.AppendLine("WHERE Id = @Id")

        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(selectId))
        result_no(sqlCommand.CommandText)

        Call sql_disconnect()
    End Sub

    Public Sub Update(data As PersonData) Implements IModel.Update
        Call sql_connect()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("UPDATE person")
        queryBuilder.AppendLine("SET Name = @Name, Kana = @Kana, Age = @Age")
        queryBuilder.AppendLine(", Address = @Address, Tel = @Tel, Date = @Date")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", data.NameData)
        sqlCommand.Parameters.AddWithValue("@Kana", data.KanaData)
        sqlCommand.Parameters.AddWithValue("@Age", data.AgeData)
        sqlCommand.Parameters.AddWithValue("@Address", data.AddressData)
        sqlCommand.Parameters.AddWithValue("@Tel", data.TelData)
        sqlCommand.Parameters.AddWithValue("@Id", data.IdData)
        '編集した時刻を登録
        sqlCommand.Parameters.AddWithValue("@Date", Date.Parse(data.DateData))

        result_no(sqlCommand.CommandText)

        Call sql_disconnect()
    End Sub

    Public Sub Add(data As PersonData) Implements IModel.Add
        Call sql_connect()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO person (Name, Kana, Age, Address, Tel, Date)")
        queryBuilder.AppendLine("VALUES (@Name, @Kana, @Age, @Address, @Tel, @Date)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", data.NameData)
        sqlCommand.Parameters.AddWithValue("@Kana", data.KanaData)
        sqlCommand.Parameters.AddWithValue("@Age", data.AgeData)
        sqlCommand.Parameters.AddWithValue("@Address", data.AddressData)
        sqlCommand.Parameters.AddWithValue("@Tel", data.TelData)
        '新規追加日時を登録
        sqlCommand.Parameters.AddWithValue("@Date", Date.Parse(data.DateData))

        result_no(sqlCommand.CommandText)

        Call sql_disconnect()

    End Sub

    Sub sql_connect()

        Dim builder As String = My.Settings.Postgres

        '付与済み情報を接続オブジェクトに設定
        pgsqlCon.ConnectionString = builder

        pgsqlCon.Open()
    End Sub

    Sub sql_disconnect()
        pgsqlCon.Close()
    End Sub

    Function result_return(ByVal query As String) As DataTable
        'select系のSQLクエリ

        Dim dt As New DataTable()

        Try
            'queryに格納してあるsqlクエリでデータベースから取得した値をDataSet(データのメモリ内のキャッシュ)へ
            Dim Adapter = New NpgsqlDataAdapter(query, pgsqlCon)

            'datatableにDataSet内のデータを更新
            Adapter.Fill(dt)

            Return dt
        Catch ex As Exception
            Return dt
            MessageBox.Show("データベースから値を取得できませんでした" & ex.Message)
        End Try
    End Function

    Sub result_no(ByVal query As String)
        'delete, insert, update系のSQLクエリ

        Try
            '接続時の接続文字列をsqlコマンドへ付与
            sqlCommand.Connection = pgsqlCon

            'sqlクエリをsqlコマンドへ付与
            sqlCommand.CommandText = query

            '更新系の処理に使用する。sql実行により影響を受けた行の数が返される
            sqlCommand.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("データベースへの変更を実行できませんでした。" & ex.Message)
        End Try
    End Sub
End Class
