Imports Accessibility




Public Class Form2

    Public Property Action As Task2Action

    Public Shared TextBoxes As TextBox()

    Private Sub Fom2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}


        Select Case True
                '追加フォーム
            Case Action = Task2Action.Add
                btnNew.Visible = True
                '編集更新フォーム
            Case Action = Task2Action.Edit
                btnUpdate.Visible = True
                '削除フォーム
            Case Action = Task2Action.Delete
                btnDestroy.Visible = True
        End Select

    End Sub


End Class