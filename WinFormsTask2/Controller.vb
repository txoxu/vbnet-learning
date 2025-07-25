Imports System.ClientModel.Primitives
Imports System.Linq.Expressions
Imports System.Net
Imports System.Reflection
Imports System.Text
Imports Azure.Core.HttpHeader
Imports Microsoft.Data.SqlClient



Public Class Controller

    Private Shared _view As FormTop
    Private Shared _viewBase As FormBase
    Private Shared _viewAdd As FormAdd
    Private Shared _viewUpdate As FormUpdate
    Private Shared _viewDelete As FormDelete

    Private Shared _model As IModel

    Public Shared SelectId As Integer

    Public Function ModelChange()
        Dim modelType As String = My.Settings.ModelType
        Dim assembly As Assembly = Assembly.GetExecutingAssembly()
        Dim name = assembly.GetExportedTypes()

        _model = CType(assembly.CreateInstance("WinFormsTask2." & modelType), IModel)

        Return _model
    End Function

    Public Sub Initialize(view As FormTop)
        _view = view
        ModelChange()

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


    Public Shared Function Access() As DataTable
        Dim actionForm As New FormBase()


        If _view.DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("行を選択してください。")
            Return Nothing
        Else
            SelectId = _view.DataGridView1.SelectedRows(0).Cells("Id").Value
            Dim SelectData As DataTable = _model.RowSelect(SelectId)
            Return SelectData
        End If
    End Function

    Public Shared Sub onSearchClicked(sender As Object, e As EventArgs)
        Dim data As New SearchData()
        '名前検索
        data.NameData = _view.searchBox.Text()

        '日付検索
        If _view.invalidCheck.Checked = False Then
            data.DateData = _view.DateTimePicker1.Text
        End If

        '年代検索
        data.AgeData = _view.AgeComboBox.SelectedIndex
        AgeGroup.agegroup(data)


        Dim dt As DataTable = _model.Search(data)
        _view.DataGridView1.DataSource = dt

    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access()
        If sqlShow IsNot Nothing Then
            Dim actionForm As New FormDelete()
            InitializeDelete(actionForm)
            InitializeBase(actionForm)
            actionForm.ShowTable = sqlShow
            _viewBase.ShowDialog()
        End If
    End Sub

    Public Shared Sub onEditClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access()
        If sqlShow IsNot Nothing Then
            Dim actionForm As New FormUpdate()
            InitializeUpdate(actionForm)
            InitializeBase(actionForm)
            actionForm.ShowTable = sqlShow
            _viewBase.ShowDialog()
        End If
    End Sub

    Public Shared Sub onShowClicked(sender As Object, e As EventArgs)
        Dim sqlShow = Access()
        If sqlShow IsNot Nothing Then
            Dim actionform As New FormShow()
            InitializeBase(actionform)
            actionform.ShowTable = sqlShow
            _viewBase.ShowDialog()
        End If
    End Sub

    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim actionform As New FormAdd()
        InitializeAdd(actionform)
        InitializeBase(actionform)
        _viewBase.ShowDialog()
    End Sub

    Public Shared Sub onRefreshClicked(sender As Object, e As EventArgs)
        Dim dt As DataTable = _model.FormRefresh()
        _view.DataGridView1.DataSource = dt
        _view.searchBox.Clear()

        If _view.DataGridView1.Columns.Contains("Address") Or _view.DataGridView1.Columns.Contains("Tel") Then
            _view.DataGridView1.Columns("Address").Visible = False
            _view.DataGridView1.Columns("Tel").Visible = False
        End If

    End Sub

    Public Shared Sub InitializeBase(view As FormBase)
        _viewBase = view
        '閉じるボタン
        AddHandler _viewBase.btnClose.Click, AddressOf onCloseClicked
    End Sub

    Public Shared Sub InitializeDelete(view As FormDelete)
        _viewDelete = view
        '削除ボタン
        AddHandler _viewDelete.btnDestroy.Click, AddressOf onDestroyClicked
    End Sub

    Public Shared Sub InitializeAdd(view As FormAdd)
        _viewAdd = view
        '新規追加ボタン
        AddHandler _viewAdd.btnNew.Click, AddressOf onNewClicked
    End Sub

    Public Shared Sub InitializeUpdate(view As FormUpdate)
        _viewUpdate = view
        '更新ボタン
        AddHandler _viewUpdate.btnUpdate.Click, AddressOf onUpdateClicked
    End Sub

    Public Shared Sub onDestroyClicked(sender As Object, e As EventArgs)
        MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)

        _model.Destroy(SelectId)
        MessageBox.Show("正常に削除されました")
        _viewBase.Close()

    End Sub
    Public Shared Function setData()
        Dim data As New PersonData()
        If _viewBase.IdBox.Text IsNot "" Then
            data.IdData = Integer.Parse(_viewBase.IdBox.Text)
        End If
        data.NameData = _viewBase.NameBox.Text
        data.KanaData = _viewBase.KanaBox.Text
        data.AgeData = Integer.Parse(_viewBase.AgeBox.Text)
        data.AddressData = _viewBase.AddBox.Text
        data.TelData = Integer.Parse(_viewBase.TelBox.Text)
        data.DateData = Date.Now.ToLongDateString
        Return data
    End Function

    Public Shared Sub onUpdateClicked(sender As Object, e As EventArgs)
        Dim data As PersonData = setData()
        _model.Update(data)
        MessageBox.Show("正常に変更されました")
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        _viewBase.Close()
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)
        Dim data As PersonData = setData()
        _model.Add(data)
        MessageBox.Show("新しく追加されました")
        _viewAdd.FormReset()
    End Sub
End Class