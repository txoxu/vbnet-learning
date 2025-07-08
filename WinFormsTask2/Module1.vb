Imports Microsoft.Data.SqlClient
Module Module1
    'sql serverにアクセスする接続オブジェクト
    Public sqlsvCon As New SqlConnection
    'sql serverに対してSQL文を実行できるようにする
    Public sqlCommand As New SqlCommand


    Sub sql_start()
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

    Sub sql_close()
        sqlsvCon.Close() ' SQL Serverの接続を閉じる
    End Sub

    Function sql_result_return(ByVal query As String) As DataTable

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


    Function sql_result_no(ByVal query As String, result As Integer)
        'delete, insert等値を返さない処理
        Try
            sqlCommand.Connection = sqlsvCon　'接続オブジェクト
            sqlCommand.CommandText = query　'sql文を設定
            sqlCommand.ExecuteNonQuery() '値を返さないsql文を実行する
            Select Case result
                Case 1
                    Return MessageBox.Show("正常に保存しました")
                Case 2
                    Return MessageBox.Show("正常に更新しました")
                Case 3
                    Return MessageBox.Show("正常に削除しました")
            End Select

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Module
