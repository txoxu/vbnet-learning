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
        End If
        Return val
    End Function
End Module