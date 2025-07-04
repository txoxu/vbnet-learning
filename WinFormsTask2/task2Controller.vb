Public Class Task2Controller
    Private Shared _view As Form1
    Private Shared _view2 As Form2
    Public Shared _action As [Enum]

    Public Shared Sub Initialize(view As Form1)
        _view = view
        '詳細ボタン
        AddHandler _view.btnShow.Click, AddressOf onShowClicked
        '追加ボタン
        AddHandler _view.btnAdd.Click, AddressOf onAddClicked

    End Sub

    Public Shared Sub Initalize2(view As Form2, action As [Enum])
        _view2 = view
        _action = action
        AddHandler _view2.btnClose.Click, AddressOf onCloseClicked
        AddHandler _view2.btnNew.Click, AddressOf onNewClicked
    End Sub

    Public Shared Sub onNewClicked(sender As Object, e As EventArgs)
        Dim textBoxes As New List(Of TextBox)
        For Each textbox As TextBox In _view2.Controls.OfType(Of TextBox)()
            textBoxes.Add(textbox)
        Next
    End Sub
    Public Shared Sub onAddClicked(sender As Object, e As EventArgs)
        Dim Action As [Enum] = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Initalize2(Form2, Action)
        _view2.ShowDialog(_action)
    End Sub

    Public Shared Sub onCloseClicked(sender As Object, e As EventArgs)
        'form2を閉じる
        _view2.Close()
    End Sub
    Public Shared Sub onShowClicked(sender As Object, e As EventArgs)
        Dim Action As Task2Action = ChangeAction(sender, e)
        Dim Form2 As New Form2()
        Initalize2(Form2, Action)
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