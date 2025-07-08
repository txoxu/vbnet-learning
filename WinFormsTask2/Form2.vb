Imports Accessibility




Public Class Form2

    Public Property Action As Task2Action
    Public Property SelectId As Integer

    Private Sub Fom2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case True
            '詳細フォーム
            Case Action = Task2Action.Show
                'form2のロード時にsql serverに接続
                Call sql_start()

                '選択したIｄを使ってSQLクエリを作成
                Dim sqlShow As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & SelectId.ToString & ";"

                'sqlクエリからの結果をdatatableに格納
                Dim Show As DataTable = sql_result_return(sqlShow)

                Call sql_close()

                '選択したIdのデータをフォームに表示
                Dim txt As TextBox() = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}

                For i As Integer = 0 To Show.Columns.Count - 1
                    txt(i).Text = Show.Rows(0).Item(i).ToString
                    txt(i).ReadOnly = True
                Next



                '追加フォーム
            Case Action = Task2Action.Add

                Call sql_start()
                btnNew.Visible = True


                '編集更新フォーム
            Case Action = Task2Action.Edit

                Call sql_start()
                '選択したIｄを使ってSQLクエリを作成
                Dim sqlEdit As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & SelectId.ToString & ";"

                'sqlクエリからの結果をdatatableに格納
                Dim Show As DataTable = sql_result_return(sqlEdit)

                '選択したIdのデータをフォームに表示
                Dim txt As TextBox() = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}

                For i As Integer = 0 To Show.Columns.Count - 1
                    txt(i).Text = Show.Rows(0).Item(i).ToString
                Next

                btnUpdate.Visible = True

            Case Action = Task2Action.Delete
                'form2のロード時にsql serverに接続
                Call sql_start()

                '選択したIｄを使ってSQLクエリを作成
                Dim sqlShow As String = "SELECT * FROM [dbo].[Table]WHERE Id = " & SelectId.ToString & ";"

                'sqlクエリからの結果をdatatableに格納
                Dim Show As DataTable = sql_result_return(sqlShow)

                '選択したIdのデータをフォームに表示
                Dim txt As TextBox() = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}

                For i As Integer = 0 To Show.Columns.Count - 1
                    txt(i).Text = Show.Rows(0).Item(i).ToString
                    txt(i).ReadOnly = True
                Next

                btnDestroy.Visible = True

        End Select

    End Sub


End Class