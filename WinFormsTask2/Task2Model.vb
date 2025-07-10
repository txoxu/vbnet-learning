Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Task2Model

    Public Shared Sub FirstLoad(selectId, TsAction)
        'form2のロード時にsql serverに接続
        Call sql_start()

        '選択したIｄを使ってSQLクエリを作成
        Dim sqlShow As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & selectId.ToString & ";"

        'sqlクエリからの結果をdatatableに格納
        Dim Show As DataTable = sql_result_return(sqlShow)

        Select Case TsAction
            Case Task2Action.Show Or Task2Action.Delete
                For i As Integer = 0 To Show.Columns.Count - 1
                    Form2.TextBoxes(i).Text = Show.Rows(0).Item(i).ToString
                    Form2.TextBoxes(i).ReadOnly = True
                Next
            Case Else
                For i As Integer = 0 To Show.Columns.Count - 1
                    Form2.TextBoxes(i).Text = Show.Rows(0).Item(i).ToString
                Next
        End Select

    End Sub

    Public Shared Sub FormRefresh()
        sql_start()

        Dim sql1 As String = "SELECT Id, Name, Kana, Age FROM [dbo].[Table];"
        Dim dtb1 As DataTable = sql_result_return(sql1)

        Form1.DataGridView1.DataSource = dtb1
        sql_close()
    End Sub

    Public Shared Sub Search()
        sql_start()
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("SELECT Id, Name, Kana, Age")
        queryBuilder.AppendLine("FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id LIKE ")
        sql_close()
    End Sub

    Public Shared Sub Destroy(result)
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("DELETE FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id = @Id")

        sqlCommand.Parameters.Clear()
        sqlCommand.CommandText = queryBuilder.ToString()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(Form2.IdBox.Text))
        sql_result_no(sqlCommand.CommandText, result)

        Call sql_close()
    End Sub

    Public Shared Sub Update(result)
        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("UPDATE [dbo].[Table]")
        queryBuilder.AppendLine("SET Name = @Name, Kana = @Kana, Age = @Age, Address = @Address, Tel = @Tel")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", Form2.NameBox.Text)
        sqlCommand.Parameters.AddWithValue("@Kana", Form2.KanaBox.Text)
        sqlCommand.Parameters.AddWithValue("@Age", Form2.AgeBox.Text)
        sqlCommand.Parameters.AddWithValue("@Address", Form2.AddBox.Text)
        sqlCommand.Parameters.AddWithValue("@Tel", Form2.TelBox.Text)
        sqlCommand.Parameters.AddWithValue("@Id", Form2.IdBox.Text)

        sql_result_no(sqlCommand.CommandText, result)
        Call sql_close()
    End Sub
End Class
