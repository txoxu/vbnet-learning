Imports System.Text
Imports Microsoft.Data.SqlClient
Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2

    Public Shared Sub Initialize(view As Form1)
        _view = view
        '削除確認フォームボタン
        AddHandler _view.btnDelete.Click, AddressOf onDeleteClicked
        '編集更新フォーム遷移ボタン
        AddHandler _view.btnEdit.Click, AddressOf onEditClicked
        '詳細フォーム遷移ボタン
        AddHandler _view.btnShow.Click, AddressOf onShowClicked
        '追加フォーム遷移ボタン
        AddHandler _view.btnAdd.Click, AddressOf onAddClicked
        'grid更新ボタン
        AddHandler _view.btnRefresh.Click, AddressOf onRefreshClicked
    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Form2.Action = Action
        Initalize2(Form2)
        If _view.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("行を選択してください。")
            Return
        Else
            Form2.SelectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
        End If
        _view2.ShowDialog()
    End Sub

    Public Shared Sub onEditClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Form2.Action = Action
        Initalize2(Form2)

        If _view.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("行を選択してください。")
            Return
        Else
            Form2.SelectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
        End If

        _view2.ShowDialog()
    End Sub



    Public Shared Sub onShowClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Form2.Action = Action

        If _view.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("行を選択してください。")
            Return
        Else
            Form2.SelectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
        End If

        Initalize2(Form2)
        _view2.ShowDialog()
    End Sub

    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Form2.Action = Action
        Initalize2(Form2)
        _view2.ShowDialog()
    End Sub

    Public Shared Sub onRefreshClicked(sender As Object, e As EventArgs)
        FormRefresh()
    End Sub

    Public Shared Sub Initalize2(view As Form2)
        _view2 = view
        '削除ボタン
        AddHandler _view2.btnDestroy.Click, AddressOf onDestroyClicked
        '更新ボタン
        AddHandler _view2.btnUpdate.Click, AddressOf onUpdateClicked
        '閉じるボタン
        AddHandler _view2.btnClose.Click, AddressOf onCloseClicked
        '新規追加ボタン
        AddHandler _view2.btnNew.Click, AddressOf onNewClicked
    End Sub

    Public Shared Sub onDestroyClicked(sender As Object, e As EventArgs)
        MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)

        Dim result As Integer = Task2Action.Delete

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("DELETE FROM [dbo].[Table]")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(_view2.IdBox.Text))
        sql_result_no(sqlCommand.CommandText, result)

        Call sql_close()
        _view2.Close()

    End Sub

    Public Shared Sub onUpdateClicked(sender As Object, e As EventArgs)

        Dim result As Integer = Task2Action.Edit

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("UPDATE [dbo].[Table]")
        queryBuilder.AppendLine("SET Id = @Id, Name = @Name, Kana = @Kana, Age = @Age, Address = @Address, Tel = @Tel")
        queryBuilder.AppendLine("WHERE Id = @Id")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(_view2.IdBox.Text))
        sqlCommand.Parameters.AddWithValue("@Name", _view2.NameBox.Text)
        sqlCommand.Parameters.AddWithValue("@Kana", _view2.KanaBox.Text)
        sqlCommand.Parameters.AddWithValue("@Age", Integer.Parse(_view2.AgeBox.Text))
        sqlCommand.Parameters.AddWithValue("@Address", _view2.AddBox.Text)
        sqlCommand.Parameters.AddWithValue("@Tel", Integer.Parse(_view2.TelBox.Text))

        sql_result_no(sqlCommand.CommandText, result)
        Call sql_close()
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        'form2を閉じる
        _view2.Close()
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)

        Dim result As Integer = Task2Action.Add

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO [dbo].[Table] (Id, Name, Kana, Age, Address, Tel)")
        queryBuilder.AppendLine("VALUES (@Id, @Name, @Kana, @Age, @Address, @Tel)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Id", Integer.Parse(_view2.IdBox.Text))
        sqlCommand.Parameters.AddWithValue("@Name", _view2.NameBox.Text)
        sqlCommand.Parameters.AddWithValue("@Kana", _view2.KanaBox.Text)
        sqlCommand.Parameters.AddWithValue("@Age", Integer.Parse(_view2.AgeBox.Text))
        sqlCommand.Parameters.AddWithValue("@Address", _view2.AddBox.Text)
        sqlCommand.Parameters.AddWithValue("@Tel", Integer.Parse(_view2.TelBox.Text))

        sql_result_no(sqlCommand.CommandText, result)

    End Sub
End Class