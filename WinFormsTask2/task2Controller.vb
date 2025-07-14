Imports System.Linq.Expressions
Imports System.Net
Imports System.Text
Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient



Public Class Task2Controller

    Private Shared _view As FormTop
    Private Shared _viewBase As FormBase
    Private Shared _viewAdd As FormAdd
    Private Shared _viewShow As FormShow
    Private Shared _viewUpdate As FormUpdate
    Private Shared _viewDelete As FormDelete

    Private Shared _model As IModel

    Private Shared selectId As Integer

    Public Sub Initialize(view As FormTop)
        _view = view
        _model = New Task2Model

        '検索ボタン
        AddHandler _view.btnSearch.Click, AddressOf onSearchClicked
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


    Public Shared Function Access(sender, e) As DataTable
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim TsAction As Task2Action = Action
        Dim actionForm As New FormBase()

        Select Case TsAction
            Case Task2Action.Add
                '何もしない
            Case Else
                If _view.DataGridView1.SelectedRows.Count = 0 Then
                    MessageBox.Show("行を選択してください。")
                Else
                    selectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
                    Dim sqlShow As DataTable = _model.IdSelect(selectId)
                    Return sqlShow
                End If
        End Select
    End Function

    Public Shared Sub onSearchClicked(sender As Object, e As EventArgs)
        Dim searchResult As String = _view.searchBox.Text()

        _model.Search()
    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access(sender, e)
        Dim actionForm As New FormDelete()
        InitializeDelete(actionForm)
        InitializeBase(actionForm)
        actionForm.Action = Task2Action.Delete
        actionForm.ShowTable = sqlShow
        _viewDelete.ShowDialog()
    End Sub

    Public Shared Sub onEditClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access(sender, e)
        Dim actionForm As New FormUpdate()
        InitializeUpdate(actionForm)
        InitializeBase(actionForm)
        actionForm.Action = Task2Action.Edit
        actionForm.ShowTable = sqlShow
        _viewUpdate.ShowDialog()
    End Sub

    Public Shared Sub onShowClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access(sender, e)
        Dim actionform As New FormShow()
        InitializeShow(actionform)
        InitializeBase(actionform)
        actionform.Action = Task2Action.Show
        actionform.ShowTable = sqlShow
        _viewShow.ShowDialog()
    End Sub

    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Access(sender, e)
        Dim actionform As New FormAdd()
        InitializeAdd(actionform)
        InitializeBase(actionform)
        actionform.Action = Task2Action.Add
        _viewAdd.ShowDialog()
    End Sub

    Public Shared Sub onRefreshClicked(sender As Object, e As EventArgs)
        Dim dtb1 As DataTable = _model.FormRefresh()
        _view.DataGridView1.DataSource = dtb1

    End Sub

    Public Shared Sub InitializeBase(view As FormBase)
        _viewBase = view
        '閉じるボタン
        AddHandler _viewBase.btnClose.Click, AddressOf onCloseClicked
    End Sub

    Public Shared Sub InitializeDelete(view As FormDelete)
        _viewDelete = view
        _viewBase = _viewDelete
        '削除ボタン
        AddHandler _viewBase.btnDestroy.Click, AddressOf onDestroyClicked
    End Sub

    Public Shared Sub InitializeUpdate(view As FormUpdate)
        _viewUpdate = view
        _viewBase = _viewUpdate
        '更新ボタン
        AddHandler _viewBase.btnUpdate.Click, AddressOf onUpdateClicked
    End Sub

    Public Shared Sub InitializeShow(view As FormShow)
        _viewShow = view
        _viewBase = _viewShow
    End Sub

    Public Shared Sub InitializeAdd(view As FormAdd)
        _viewAdd = view
        _viewBase = _viewAdd
        '新規追加ボタン
        AddHandler _viewBase.btnNew.Click, AddressOf onNewClicked
    End Sub

    Public Shared Sub onDestroyClicked(sender As Object, e As EventArgs)
        MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)
        _model.Destroy(selectId)
        MessageBox.Show("正常に削除されました")
        _viewBase.Close()

    End Sub
    Public Shared Function setDto(sender As Object)



        Dim Dto As New DataDto()
        If _viewBase.IdBox.Text IsNot "" Then
            Dto.IdSg = Integer.Parse(_viewBase.IdBox.Text)
        End If
        Dto.NameSg = _viewBase.NameBox.Text
        Dto.KanaSg = _viewBase.KanaBox.Text
        Dto.AgeSg = Integer.Parse(_viewBase.AgeBox.Text)
        Dto.AddressSg = _viewBase.AddBox.Text
        Dto.TelSg = Integer.Parse(_viewBase.TelBox.Text)
        Return Dto
    End Function

    Public Shared Sub onUpdateClicked(sender As Object, e As EventArgs)
        Dim DtoList As DataDto = setDto(sender)
        _model.update(DtoList)
        MessageBox.Show("正常に変更されました")
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        'form2を閉じる
        _viewBase.Close()
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)
        Dim DtoList As DataDto = setDto(sender)
        _model.Add(DtoList)
        MessageBox.Show("新しく追加されました")
        _viewBase.FormReset()
    End Sub
End Class