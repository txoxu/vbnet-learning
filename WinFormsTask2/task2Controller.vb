Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2

    Public Shared Sub Initialize(view As Form1)
        _view = view
        '追加ボタン
        AddHandler _view.btnAdd.Click, AddressOf onAddClicked

    End Sub

    Public Shared Sub Initalize2(view As Form2)
        _view2 = view


    End Sub
    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim form2 As New Form2()
        Initalize2(form2)
        _view2.ShowDialog()
    End Sub
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