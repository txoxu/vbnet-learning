Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Module EnumAction
    '詳細、追加、編集の制御
    Public Enum Task2Action
        '詳細
        Show
        '追加
        Add
        '編集
        Edit
        '削除
        Delete
    End Enum

    'クリックイベントごとに分岐
    Public Function ChangeAction(sender As Object, e As EventArgs) As [Enum]
        Dim val As [Enum]
        Dim txt As String = sender.Text.ToString

        Select Case txt
            Case "詳細"
                val = Task2Action.Show
            Case "追加"
                val = Task2Action.Add
            Case "編集/更新"
                val = Task2Action.Edit
            Case "削除"
                val = Task2Action.Delete
        End Select

        Return val
    End Function
End Module