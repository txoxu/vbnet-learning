Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient
Imports Npgsql



Public Class SqlServerModel
    Implements IModel

    'sql serverにアクセスする接続オブジェクト
    Public Shared sqlsvCon As New SqlConnection
    'sql serverに対してSQL文を実行できるようにする
    Public Shared sqlCommand As New SqlCommand



    Public Function RowSelect(selectId As Integer) As DataTable Implements IModel.RowSelect
        Call sql_connect()

        Dim _sqlShow As String = "SELECT * FROM [dbo].[Table] WHERE Id = " & selectId.ToString & ";"

        Dim sqlShow As DataTable = result_return(_sqlShow)

        Call sql_disconnect()

        Return sqlShow

    End Function

    Public Function FormRefresh() As DataTable Implements IModel.FormRefresh
        sql_connect()

        Dim sql As String = "SELECT Id, Name, Kana, Age, Date FROM [dbo].[Table];"
        Dim dt As DataTable = result_return(sql)

        sql_disconnect()

        Return dt

    End Function

    Public Function Search(data As SearchData) As DataTable Implements IModel.Search
        sql_connect()


        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT Id, Name, Kana, Age, Date")
        queryBuilder.AppendLine("FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Name LIKE N'" & "%" & data.NameData & "%" & "'")

        If data.DateData IsNot Nothing Then
            queryBuilder.AppendLine("AND Date = '" & data.DateData & "'")
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
        queryBuilder.AppendLine("DELETE FROM [dbo].[Table]")
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
        queryBuilder.AppendLine("UPDATE [dbo].[Table]")
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
        sqlCommand.Parameters.AddWithValue("@Date", data.DateData)

        result_no(sqlCommand.CommandText)

        Call sql_disconnect()
    End Sub

    Public Sub Add(data As PersonData) Implements IModel.Add
        Call sql_connect()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO [dbo].[Table] (Name, Kana, Age, Address, Tel, Date)")
        queryBuilder.AppendLine("VALUES (@Name, @Kana, @Age, @Address, @Tel, @Date)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", data.NameData)
        sqlCommand.Parameters.AddWithValue("@Kana", data.KanaData)
        sqlCommand.Parameters.AddWithValue("@Age", data.AgeData)
        sqlCommand.Parameters.AddWithValue("@Address", data.AddressData)
        sqlCommand.Parameters.AddWithValue("@Tel", data.TelData)
        '新規追加日時を登録
        sqlCommand.Parameters.AddWithValue("@Date", data.DateData)

        result_no(sqlCommand.CommandText)

        Call sql_disconnect()

    End Sub

    Sub sql_connect()

        '接続文字列を配列の型に設定
        Dim Builder As String = My.Settings.sqlServer

        '接続オブジェクトに接続文字列を設定
        sqlsvCon.ConnectionString = Builder

        sqlsvCon.Open() ' SQL Serverに接続
    End Sub

    Sub sql_disconnect()
        sqlsvCon.Close() ' SQL Serverの接続を閉じる
    End Sub

    Function result_return(ByVal query As String) As DataTable

        Dim dt As New DataTable()

        Try
            Dim Adapter = New SqlDataAdapter(query, sqlsvCon)

            Adapter.Fill(dt)

            Return dt
        Catch ex As Exception
            Return dt
            MessageBox.Show("データベースから値を取得できませんでした" & ex.Message)
        End Try

    End Function

    Sub result_no(ByVal query As String)
        'delete, insert等値を返さない処理
        Try
            sqlCommand.Connection = sqlsvCon '接続オブジェクト
            sqlCommand.CommandText = query 'sql文を設定
            sqlCommand.ExecuteNonQuery() '値を返さないsql文を実行する
        Catch ex As Exception
            MessageBox.Show("データベースへの変更を実行できませんでした。" & ex.Message)
        End Try
    End Sub
End Class
