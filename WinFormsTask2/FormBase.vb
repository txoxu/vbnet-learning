Imports Accessibility
Public Class FormBase

    'フォームごとのEnumの値をcontrollerから取得
    Public Property Action As Task2Action

    '初期のデータをdatatableでmodelから取得
    Public Property ShowTable As DataTable

    Public Shared TextBoxes As TextBox()

    Protected Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}


        Select Case True
                '詳細フォーム
            Case Action = Task2Action.Show
                Show_Delete_TextBox()
                '追加フォーム
            Case Action = Task2Action.Add
                btnNew.Visible = True
                '編集更新フォーム
            Case Action = Task2Action.Edit
                Edit_TextBox()
                btnUpdate.Visible = True
                '削除フォーム
            Case Action = Task2Action.Delete
                Show_Delete_TextBox()
                btnDestroy.Visible = True
        End Select

    End Sub

    Public Sub Show_Delete_TextBox()
        For i As Integer = 0 To ShowTable.Columns.Count - 1
            TextBoxes(i).Text = ShowTable.Rows(0).Item(i).ToString
            TextBoxes(i).ReadOnly = True
        Next
    End Sub

    Public Sub Edit_TextBox()
        For i As Integer = 0 To ShowTable.Columns.Count - 1
            TextBoxes(i).Text = ShowTable.Rows(0).Item(i).ToString
        Next
    End Sub

    Public Sub FormReset()
        For Each box As TextBox In TextBoxes
            box.Clear()
        Next
    End Sub

End Class