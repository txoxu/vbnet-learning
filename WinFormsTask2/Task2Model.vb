Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Task2Model
    Public Function FirstLoad(selectId As Integer, TsAction As Task2Action) As DataTable
        'form2のロード時にsql serverに接続
        Call sql_start()

        '選択したIｄを使ってSQLクエリを作成
        Dim sqlShow As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & selectId.ToString & ";"

        'sqlクエリからの結果をdatatableに格納
        Dim Show As DataTable = sql_result_return(sqlShow)
        Return Show
    End Function

    Public Sub FormRefresh()
        sql_start()

        Dim sql1 As String = "SELECT Id, Name, Kana, Age FROM [dbo].[Table];"
        Dim dtb1 As DataTable = sql_result_return(sql1)

        Form1.DataGridView1.DataSource = dtb1
        sql_close()
    End Sub

    Public Sub Search()
        sql_start()
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT Id, Name, Kana, Age")
        queryBuilder.AppendLine("FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id LIKE ")
        sql_close()
    End Sub

    Public Sub Destroy(selectId As Integer)
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("DELETE FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id = @Id")

        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(selectId))
        sql_result_no(sqlCommand.CommandText)

        Call sql_close()
    End Sub

    Public Sub Update(DtoList As DataDto)
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("UPDATE [dbo].[Table]")
        queryBuilder.AppendLine("SET Name = @Name, Kana = @Kana, Age = @Age, Address = @Address, Tel = @Tel")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", DtoList.NameSg)
        sqlCommand.Parameters.AddWithValue("@Kana", DtoList.KanaSg)
        sqlCommand.Parameters.AddWithValue("@Age", DtoList.AgeSg)
        sqlCommand.Parameters.AddWithValue("@Address", DtoList.AddressSg)
        sqlCommand.Parameters.AddWithValue("@Tel", DtoList.TelSg)
        sqlCommand.Parameters.AddWithValue("@Id", DtoList.IdSg)

        sql_result_no(sqlCommand.CommandText)
        Call sql_close()
    End Sub

    Public Sub Add(DtoList As DataDto)
        Call sql_start()
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO [dbo].[Table] (Name, Kana, Age, Address, Tel)")
        queryBuilder.AppendLine("VALUES (@Name, @Kana, @Age, @Address, @Tel)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", DtoList.NameSg)
        sqlCommand.Parameters.AddWithValue("@Kana", DtoList.KanaSg)
        sqlCommand.Parameters.AddWithValue("@Age", DtoList.AgeSg)
        sqlCommand.Parameters.AddWithValue("@Address", DtoList.AddressSg)
        sqlCommand.Parameters.AddWithValue("@Tel", DtoList.TelSg)

        sql_result_no(sqlCommand.CommandText)
        Call sql_close()

    End Sub
End Class
