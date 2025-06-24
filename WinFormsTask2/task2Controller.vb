Public Class Task2Controller
    Private Shared _view As Form1

    Public Shared Sub Initialize(view As Form1)
        _view = view
        AddHandler _view.Button1.click, AddressOf onAddClicked
    End Sub

    Private Sub onAddClicked(sender As Object, e As EventArgs)
        Dim arr As String() = SplitCsvLine(_view.textInput.Text)

        _view.DataGridView1.Rows.Add(arr)
    End Sub

    Public Shared Function SplitCsvLine(input As String) As String()
        Return input.Split(","c)
    End Function

End Class