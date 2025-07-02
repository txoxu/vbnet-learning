Public Class Task2Controller
    Private Shared _view As Form1

    Public Shared Sub Initialize(view As Form1)
        _view = view
        AddHandler _view.Button1.Click, AddressOf onAddClicked
        AddHandler _view.btnSave.Click, AddressOf onSaveClicked
    End Sub

    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim arr As String() = SplitCsvLine(_view.textInput.Text)

        _view.DataGridView1.DataSource.Rows.Add(arr)
    End Sub

    Public Shared Function SplitCsvLine(input As String) As String()
        Return input.Split(","c)
    End Function

    Public Shared Sub onSaveClicked(sender As Object, e As EventArgs)
        'もしdatagridviewのデータソースが設定されている場合,sqlに追加処理
        If _view.DataGridView1.DataSource.Rows.Count <> 0 Then
            Dim dt = CType(_view.DataGridView1.DataSource, DataTable)

            For Each row As DataGridViewRow In _view.DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim newRow As DataRow = dt.NewRow()
                    newRow("Name") = row.Cells("midleName").Value
                    newRow("Kana") = row.Cells("Kana").Value
                    newRow("Age") = row.Cells("Age").Value
                    dt.Rows.Add(newRow)
                End If
                Next
                Task2Model.InsertQuery(dt)
        End If
    End Sub

End Class