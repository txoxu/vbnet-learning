Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient



Public Class Task2Model
    Implements IModel

    Public Function IdSelect(selectId As Integer) As DataTable Implements IModel.IdSelect

        'form2のロード時にsql serverに接続
        Call sql_start()

        '選択したIｄを使ってSQLクエリを作成
        Dim _sqlShow As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & selectId.ToString & ";"

        'sqlクエリからの結果をdatatableに格納
        Dim sqlShow As DataTable = sql_result_return(_sqlShow)

        Call sql_close()

        Return sqlShow

    End Function

    Public Function FormRefresh() As DataTable Implements IModel.FormRefresh
        sql_start()

        Dim sql1 As String = "SELECT Id, Name, Kana, Age FROM [dbo].[Table];"
        Dim dtb1 As DataTable = sql_result_return(sql1)

        sql_close()

        Return dtb1

    End Function

    Public Function Search(keyword As String) As DataTable Implements IModel.Search
        sql_start()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT Id, Name, Kana, Age")
        queryBuilder.AppendLine("FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id LIKE '@Name'")

        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()
        sqlCommand.Parameters.AddWithValue("@Name", "%" & keyword & "%")
        Dim dtb As DataTable = sql_result_return(sqlCommand.CommandText)
        Return dtb
        sql_close()
    End Function

    Public Sub Destroy(selectId As Integer) Implements IModel.Destroy
        Call sql_start()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("DELETE FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id = @Id")

        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(selectId))
        sql_result_no(sqlCommand.CommandText)

        Call sql_close()
    End Sub

    Public Sub Update(data As DataDto) Implements IModel.update
        Call sql_start()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("UPDATE [dbo].[Table]")
        queryBuilder.AppendLine("SET Name = @Name, Kana = @Kana, Age = @Age, Address = @Address, Tel = @Tel")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", data.NameData)
        sqlCommand.Parameters.AddWithValue("@Kana", data.KanaData)
        sqlCommand.Parameters.AddWithValue("@Age", data.AgeData)
        sqlCommand.Parameters.AddWithValue("@Address", data.AddressData)
        sqlCommand.Parameters.AddWithValue("@Tel", data.TelData)
        sqlCommand.Parameters.AddWithValue("@Id", data.IdData)

        sql_result_no(sqlCommand.CommandText)

        Call sql_close()
    End Sub

    Public Sub Add(data As DataDto) Implements IModel.Add
        Call sql_start()

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO [dbo].[Table] (Name, Kana, Age, Address, Tel)")
        queryBuilder.AppendLine("VALUES (@Name, @Kana, @Age, @Address, @Tel)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", data.NameData)
        sqlCommand.Parameters.AddWithValue("@Kana", data.KanaData)
        sqlCommand.Parameters.AddWithValue("@Age", data.AgeData)
        sqlCommand.Parameters.AddWithValue("@Address", data.AddressData)
        sqlCommand.Parameters.AddWithValue("@Tel", data.TelData)

        sql_result_no(sqlCommand.CommandText)

        Call sql_close()

    End Sub

    'sql serverにアクセスする接続オブジェクト
    Public sqlsvCon As New SqlConnection
    'sql serverに対してSQL文を実行できるようにする
    Public sqlCommand As New SqlCommand

    Sub sql_start() Implements IModel.sql_start
        'sql serverの設定を付与、ConnectionString（接続文字列）
        Dim Builder = New SqlConnectionStringBuilder()

        Builder.DataSource = "(localdb)\MSSQLLocalDB" ' SQL Serverのホスト名
        Builder.InitialCatalog = "test_db" ' データベース名
        Builder.IntegratedSecurity = True ' Windows認証

        '接続文字列を配列の型に設定
        Dim ConStr = Builder.ToString()

        '接続オブジェクトに接続文字列を設定
        sqlsvCon.ConnectionString = ConStr

        sqlsvCon.Open() ' SQL Serverに接続
    End Sub

    Sub sql_close() Implements IModel.sql_close
        sqlsvCon.Close() ' SQL Serverの接続を閉じる
    End Sub

    Function sql_result_return(ByVal query As String) As DataTable Implements IModel.sql_result_return

        Dim dt As New DataTable()

        Try
            Dim Adapter = New SqlDataAdapter(query, sqlsvCon)

            Adapter.Fill(dt)

            Return dt
        Catch ex As Exception
            Return dt
            MessageBox.Show("実行できませんでした" & ex.Message)
        End Try

    End Function

    Function sql_result_no(ByVal query As String) Implements IModel.sql_result_no
        'delete, insert等値を返さない処理
        Try
            sqlCommand.Connection = sqlsvCon '接続オブジェクト
            sqlCommand.CommandText = query 'sql文を設定
            sqlCommand.ExecuteNonQuery() '値を返さないsql文を実行する
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
