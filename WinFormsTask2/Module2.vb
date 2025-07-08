Public Module Module2
    '詳細、追加、編集の制御
    Public Enum Task2Action
        '詳細
        Show
        '追加
        Add
        '編集
        Edit
    End Enum

    'クリックイベントごとに分岐
    Public Function ChangeAction(sender As Object, e As EventArgs) As [Enum]
        Dim val As [Enum]
        Dim txt As String = sender.Text.ToString

        If txt = "詳細" Then
            val = Task2Action.Show
        ElseIf txt = "追加" Then
            val = Task2Action.Add
        ElseIf txt = "編集/更新" Then
            val = Task2Action.Edit
        End If
        Return val
    End Function

    Public Sub FormRefresh()

        Dim sql1 As String = "SELECT"
        sql1 &= " Id, Name, Kana, Age"
        sql1 &= " FROM [dbo].[Table];"

        Dim dtb1 As DataTable = sql_result_return(sql1)

        Form1.DataGridView1.DataSource = dtb1

    End Sub


End Module