Imports System.Text
Imports Microsoft.Data.SqlClient
Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2

    Public Shared Sub Initialize(view As Form1)
        _view = view
        '�폜�m�F�t�H�[���{�^��
        AddHandler _view.btnDelete.Click, AddressOf onDeleteClicked
        '�ҏW�X�V�t�H�[���J�ڃ{�^��
        AddHandler _view.btnEdit.Click, AddressOf onEditClicked
        '�ڍ׃t�H�[���J�ڃ{�^��
        AddHandler _view.btnShow.Click, AddressOf onShowClicked
        '�ǉ��t�H�[���J�ڃ{�^��
        AddHandler _view.btnAdd.Click, AddressOf onAddClicked
        'grid�X�V�{�^��
        AddHandler _view.btnRefresh.Click, AddressOf onRefreshClicked
    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Form2.Action = Action
        Initalize2(Form2)
        If _view.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("�s��I�����Ă��������B")
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
            MessageBox.Show("�s��I�����Ă��������B")
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
            MessageBox.Show("�s��I�����Ă��������B")
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
        '�폜�{�^��
        AddHandler _view2.btnDestroy.Click, AddressOf onDestroyClicked
        '�X�V�{�^��
        AddHandler _view2.btnUpdate.Click, AddressOf onUpdateClicked
        '����{�^��
        AddHandler _view2.btnClose.Click, AddressOf onCloseClicked
        '�V�K�ǉ��{�^��
        AddHandler _view2.btnNew.Click, AddressOf onNewClicked
    End Sub

    Public Shared Sub onDestroyClicked(sender As Object, e As EventArgs)
        MessageBox.Show("�폜���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)

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
        'form2�����
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