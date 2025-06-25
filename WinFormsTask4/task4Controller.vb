Imports System.IO
Imports System.Reflection.Metadata.Ecma335

Public Class Task4Controller
    Private Shared _view As Form1
    Private Shared _addForm As FormAdd

    Public Shared Sub Initialize(view As Form1)
        _view = view
        AddHandler _view.btnCsv.Click, AddressOf onLoadCsvClicked
        AddHandler _view.btnAdd.Click, AddressOf OnAddButtonClicked
        AddHandler _view.btnDelete.Click, AddressOf OnDeleteClicked
        AddHandler _view.btnSearch.Click, AddressOf OnSearchClicked
    End Sub

    Public Shared Sub InitializeAddForm(view As FormAdd)
        _addForm = view

        AddHandler _addForm.btn.Click, AddressOf OnAddClicked
    End Sub
    Public Shared Sub onLoadCsvClicked(sender As Object, e As EventArgs)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "csvファイル(*.csv)|*.csv"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim dt = Task4Model.LoadCsv(ofd.FileName)

                Dim headers = Task4Model.CurrentHeaders
                _view.SetComboBoxHeaders(headers)

                If dt Is Nothing Then
                    MessageBox.Show("ファイルの読み込みに失敗しました")
                    Return
                End If
                _view.DataGridView2.DataSource = dt
                _view.DataGridView2.ReadOnly = True
                _view.DataGridView2.AllowUserToAddRows = False
                _view.DataGridView2.AllowUserToDeleteRows = False
            End If
        End Using
    End Sub

    Private Shared Sub OnAddClicked(sender As Object, e As EventArgs)
        Dim dt = CType(_view.DataGridView2.DataSource, DataTable)
        Dim newRow = dt.NewRow()

        For i As Integer = 0 To Task4Model.CurrentHeaders.Count - 1
            Dim header = Task4Model.CurrentHeaders(i)
            Dim value = _addForm.textBoxes(i).text.trim()
            newRow(header) = value
        Next

        dt.Rows.Add(newRow)
        MessageBox.Show("新しい行を追加しました")
        _addForm.Close()
    End Sub

    Private Shared Sub OnAddButtonClicked(sender As Object, e As EventArgs)
        Dim formAdd As New FormAdd()
        InitializeAddForm(formAdd)
        formAdd.ShowDialog()
    End Sub

    Private Shared Sub OnDeleteClicked(sender As Object, e As EventArgs)
        Dim dt = TryCast(_view.DataGridView2.DataSource, DataTable)
        If dt Is Nothing Then
            MessageBox.Show("データが読み込まれていません")
            Return
        End If

        If _view.DataGridView2.SelectedRows.Count = 0 Then
            MessageBox.Show("削除する行を選択してください")
            Return
        End If

        For Each row As DataGridViewRow In _view.DataGridView2.SelectedRows
            If Not row.IsNewRow Then
                _view.DataGridView2.Rows.Remove(row)
            End If
        Next

        MessageBox.Show("選択した行を削除しました")
    End Sub
    Private Shared Sub OnSearchClicked(sender As Object, e As EventArgs)
        Dim dt = CType(_view.DataGridView2.DataSource, DataTable)
        If dt Is Nothing Then Return

        Dim colName As String = _view.ComboBox1.SelectedItem.ToString()

        If colName = "選択してください" Then
            dt.DefaultView.Sort = ""
        ElseIf dt.Columns.Contains(colName) Then
            dt.DefaultView.Sort = $"{colName} ASC"
        End If
    End Sub
End Class