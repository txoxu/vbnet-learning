Imports System.ComponentModel
Imports System.DirectoryServices
Imports System.IO
Imports System.Text

Public Class Task5Controller
    Private Shared _view As Form1
    Private Shared _addView As FormAdd

    Public Shared Sub addInitialize(view As FormAdd)
        _addView = view

        AddHandler _addView.btnAdd.Click, AddressOf onAddClicked
        AddHandler _addView.btnClose.Click, AddressOf onCloseClicked
    End Sub

    Public Shared Sub Initialize(view As Form1)
        _view = view

        AddHandler _view.btnCsv.Click, AddressOf onLoadCsvClicked
        AddHandler _view.btnOverWriteSave.Click, AddressOf onOverWriteClicked
        AddHandler _view.btnNewWriteSave.Click, AddressOf onNewWriteClicked
        AddHandler _view.btnDelete.Click, AddressOf onDeleteClicked
        AddHandler _view.btnSearch.Click, AddressOf onSearchClicked
        AddHandler _view.btnClear.Click, AddressOf onSearchClearClicked
        AddHandler _view.btnOpenModal.Click, AddressOf onModalOpenClicked
    End Sub

    Public Shared Function GetBoundDataTable() As DataTable
        Return TryCast(_view.DataGridView.DataSource, DataTable)
    End Function

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        _addView.Close()
    End Sub
    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim dt = GetBoundDataTable()
        Dim newRow = dt.NewRow()

        For i As Integer = 0 To Task5Model.CurrentHeaders.Count - 1
            'csv�t�@�C����ǂݍ��ނƂ���trim���Ă���̂ł����ł͂��Ȃ�
            Dim header = Task5Model.CurrentHeaders(i)
            Dim value = _addView.textBoxes(i).Text.Trim()
            newRow(header) = value
        Next

        dt.Rows.Add(newRow)
        MessageBox.Show("�V�����ǉ����܂���")
    End Sub
    Public Shared Sub onModalOpenClicked(sender As Object, e As EventArgs)
        If _view.DataGridView.DataSource IsNot Nothing Then
            Dim formAdd As New FormAdd()
            addInitialize(formAdd)
            formAdd.ShowDialog()
        Else
            MessageBox.Show("CSV�t�@�C����ǂݍ���ł�������")
        End If

    End Sub

    Public Shared Sub onSearchClearClicked(sender As Object, e As EventArgs)
        _view.searchText.Clear()

        Dim dt = GetBoundDataTable()
        dt.DefaultView.RowFilter = ""
    End Sub

    Public Shared Sub onSearchClicked(sender As Object, e As EventArgs)
        Dim keyword As String = _view.searchText.Text.Trim()
        Dim dt = GetBoundDataTable()

        If keyword = "" Then
            dt.DefaultView.RowFilter = ""
            Return
        End If

        Dim results As New List(Of String)
        For Each col As DataColumn In dt.Columns
            results.Add($"[{col.ColumnName}] like '%{keyword}%'")
        Next
        dt.DefaultView.RowFilter = String.Join(" OR ", results)
    End Sub

    Public Shared Sub onDeleteClicked(sender As Object, e As EventArgs)
        Dim dt = GetBoundDataTable()

        If dt Is Nothing Then
            MessageBox.Show("CSV�t�@�C�����ǂݍ��܂�Ă��܂���")
            Return
        End If

        If _view.DataGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("�폜����s���I������Ă��܂���")
            Return
        End If

        For Each row As DataGridViewRow In _view.DataGridView.SelectedRows
            If Not row.IsNewRow Then
                _view.DataGridView.Rows.Remove(row)
            End If
        Next

        MessageBox.Show("�I�������s���폜���܂���")
    End Sub

    Public Shared Sub onLoadCsvClicked(sener As Object, e As EventArgs)
        Using ofd As New OpenFileDialog
            ofd.Filter = "CSV�t�@�C��(*.csv) | *.csv"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim dt = Task5Model.LoadCsv(ofd.FileName)

                If dt Is Nothing Then
                    MessageBox.Show("�t�@�C���̓ǂݍ��݂Ɏ��s���܂���")
                    Return
                End If
                _view.DataGridView.DataSource = dt
                _view.CurrentFilePath = ofd.FileName
                _view.DataGridView.ReadOnly = True
                _view.DataGridView.AllowUserToAddRows = False
                _view.DataGridView.AllowUserToDeleteRows = False
            End If
        End Using
    End Sub

    Public Shared Sub onOverWriteClicked(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(_view.CurrentFilePath) Then
            MessageBox.Show("CSV�t�@�C�����ǂݍ��܂�Ă��܂���")
            Return
        End If

        Dim dt As DataTable = GetBoundDataTable()
        Dim errorMsg As String = ""
        Dim success = Task5Model.SaveCsv(_view.CurrentFilePath, dt, errorMsg)

        If success Then
            MessageBox.Show("�㏑���ۑ����܂���")
        Else
            MessageBox.Show("�㏑���ۑ��Ɏ��s���܂���")
        End If
    End Sub

    Public Shared Sub onNewWriteClicked(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(_view.CurrentFilePath) Then
            MessageBox.Show("CSV�t�@�C�����ǂݍ��܂�Ă��܂���")
            Return
        End If

        Dim ofd As New SaveFileDialog()
        ofd.Filter = "CSV�t�@�C��(*.csv)|*.csv"
        ofd.Title = "���O��t���ĕۑ�"
        Dim dt As DataTable = GetBoundDataTable()

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim errorMsg As String = ""
            Dim success = Task5Model.SaveCsv(ofd.FileName, dt, errorMsg)

            If success Then
                MessageBox.Show("���O��t���ĕۑ����܂���")
            Else
                MessageBox.Show("�ۑ��Ɏ��s���܂���" & vbCrLf & errorMsg)
            End If
        End If
    End Sub

End Class