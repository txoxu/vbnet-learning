Imports System.Text
Imports Microsoft.Data.SqlClient
Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2

    Public Shared Sub Initialize(view As Form1)
        _view = view
        '�����{�^��
        AddHandler _view.btnSearch.Click, AddressOf onSearchClicked
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
    Public Shared Sub Access(sender, e)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim TsAction As Task2Action = Action
        Dim actionForm As New Form2()
        Initalize2(actionForm)
        actionForm.Action = Action



        Select Case TsAction
            Case Task2Action.Add
                '�������Ȃ�
            Case Else
                If _view.DataGridView1.SelectedRows.Count = 0 Then
                    MessageBox.Show("�s��I�����Ă��������B")
                    Return
                Else
                    Dim selectId As Integer = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
                    _view2.Show()
                    Task2Model.FirstLoad(selectId, TsAction)
                End If
        End Select
    End Sub

    Public Shared Sub onSearchClicked(sender As Object, e As EventArgs)
        Dim searchResult As String = _view.searchBox.Text()

        Task2Model.Search()
    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Access(sender, e)
    End Sub

    Public Shared Sub onEditClicked(sender As Object, e As EventArgs)
        Access(sender, e)
    End Sub

    Public Shared Sub onShowClicked(sender As Object, e As EventArgs)
        Access(sender, e)
    End Sub

    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Access(sender, e)
    End Sub

    Public Shared Sub onRefreshClicked(sender As Object, e As EventArgs)
        Task2Model.FormRefresh()
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
        MessageBox.Show("�{���ɍ폜���܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)
        '�폜�チ�b�Z�[�W�̔���p�ϐ�
        Dim result As Integer = Task2Action.Delete

        Task2Model.Destroy(result)
        _view2.Close()

    End Sub

    Public Shared Sub onUpdateClicked(sender As Object, e As EventArgs)
        '�ҏW/�X�V��̃��b�Z�[�W����p�ϐ�
        Dim result As Integer = Task2Action.Edit

        Task2Model.Update(result)
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        'form2�����
        _view2.Close()
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)

        Dim result As Integer = Task2Action.Add

        Dim queryBuilder As New StringBuilder()
        queryBuilder.AppendLine("INSERT INTO [dbo].[Table] (Name, Kana, Age, Address, Tel)")
        queryBuilder.AppendLine("VALUES (@Name, @Kana, @Age, @Address, @Tel)")
        sqlCommand.CommandText = queryBuilder.ToString()

        sqlCommand.Parameters.Clear()
        sqlCommand.Parameters.AddWithValue("@Name", _view2.NameBox.Text)
        sqlCommand.Parameters.AddWithValue("@Kana", _view2.KanaBox.Text)
        sqlCommand.Parameters.AddWithValue("@Age", Integer.Parse(_view2.AgeBox.Text))
        sqlCommand.Parameters.AddWithValue("@Address", _view2.AddBox.Text)
        sqlCommand.Parameters.AddWithValue("@Tel", Integer.Parse(_view2.TelBox.Text))

        sql_result_no(sqlCommand.CommandText, result)

        For Each boxItem As Control In _view2.Controls
            If TypeOf boxItem Is TextBox Then
                CType(boxItem, TextBox).Text = String.Empty
            End If
        Next

    End Sub
End Class