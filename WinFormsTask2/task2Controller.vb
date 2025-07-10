Imports System.Net
Imports System.Text
Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient
Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2
    Private Shared _model As New Task2Model

    Private Shared selectId As Integer


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
                    selectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
                    Dim Show As DataTable = _model.FirstLoad(selectId, TsAction)
                    actionForm.ShowTable = Show
                End If
        End Select
        _view2.ShowDialog()
    End Sub

    Public Shared Sub onSearchClicked(sender As Object, e As EventArgs)
        Dim searchResult As String = _view.searchBox.Text()

        _model.Search()
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
        _model.FormRefresh()
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
        _model.Destroy(selectId)
        MessageBox.Show("����ɍ폜����܂���")
        _view2.Close()

    End Sub
    Public Shared Function setDto()
        Dim Dto As New DataDto()
        If _view2.IdBox.Text IsNot "" Then
            Dto.IdSg = Integer.Parse(_view2.IdBox.Text)
        End If
        Dto.NameSg = _view2.NameBox.Text
        Dto.KanaSg = _view2.KanaBox.Text
        Dto.AgeSg = Integer.Parse(_view2.AgeBox.Text)
        Dto.AddressSg = _view2.AddBox.Text
        Dto.TelSg = Integer.Parse(_view2.TelBox.Text)
        Return Dto
    End Function

    Public Shared Sub onUpdateClicked(sender As Object, e As EventArgs)
        Dim DtoList As DataDto = setDto()
        _model.Update(DtoList)
        MessageBox.Show("����ɕύX����܂���")
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        'form2�����
        _view2.Close()
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)
        Dim DtoList As DataDto = setDto()
        _model.Add(DtoList)
        MessageBox.Show("�V�����ǉ�����܂���")
        _view2.FormReset()
    End Sub
End Class