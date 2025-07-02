Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Task3Controller
    Private Shared _view As Form1

    Public Shared Sub Initialize(view As Form1)
        _view = view
        AddHandler _view.btnCsvRead.Click, AddressOf onLoadCsvClicked
        AddHandler _view.btnOverWriteSave.Click, AddressOf SaveCsvClicked
        AddHandler _view.btnNewWriteSave.Click, AddressOf SaveCsvNewClicked
        AddHandler _view.btnSearch.Click, AddressOf SearchFilter
    End Sub

    Public Shared Sub onLoadCsvClicked(sender As Object, e As EventArgs)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "csvファイル(*.csv)|*.csv"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim dt = Task3Model.LoadCsv(ofd.FileName)
                If dt Is Nothing Then
                    MessageBox.Show("ファイルの読み込みに失敗しました")
                    Return
                End If
                _view.DataGridView.DataSource = dt
                _view.CurrentFilePath = ofd.FileName
            End If
        End Using
    End Sub

    Public Shared Sub SearchFilter(sender As Object, e As EventArgs)
        Dim keyword As String = _view.searchText.Text.Trim()
        Dim dt As DataTable = CType(_view.DataGridView.DataSource, DataTable)

        If keyword = "" Then
            dt.DefaultView.RowFilter = ""
            Return
        End If

        Dim conditions As New List(Of String)
        For Each col As DataColumn In dt.Columns
            conditions.Add($"[{col.ColumnName}] Like '%{keyword}%'")
        Next

        dt.DefaultView.RowFilter = String.Join(" OR ", conditions)

    End Sub

    Public Shared Sub SaveCsvClicked(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(_view.CurrentFilePath) Then
            MessageBox.Show("ファイルが読み込まれていません")
            Return
        End If

        Dim dt As DataTable = CType(_view.DataGridView.DataSource, DataTable)
        Dim errorMsg As String = ""
        Dim success = Task3Model.SaveCsv(_view.CurrentFilePath, dt, errorMsg)
        If success Then
            MessageBox.Show("上書き保存しました")
        Else
            MessageBox.Show("上書き保存に失敗しました" & vbCrLf & errorMsg)
        End If
    End Sub

    Public Shared Sub SaveCsvNewClicked(sender As Object, e As EventArgs)
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "CSVファイル(*.csv)|*.csv"
        dialog.Title = "名前を付けて保存"
        Dim dt As DataTable = CType(_view.DataGridView.DataSource, DataTable)

        If dialog.ShowDialog() = DialogResult.OK Then
            Dim errorMsg As String = ""
            Dim success = Task3Model.SaveNewCsv(dialog.FileName, dt, errorMsg)
            If success Then
                MessageBox.Show("名前を付けて保存しました")
            Else
                MessageBox.Show("保存に失敗しました" & vbCrLf & errorMsg)
            End If
        End If

    End Sub

End Class