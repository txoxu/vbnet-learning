Public Class Task1Controller

    Private Shared _view As Form1

    Public Shared Sub Initialize(view As Form1)
        _view = view
        AddHandler _view.btnProcess.click, AddressOf onProcessClicked
    End Sub

    Public Shared Sub OnProcessClicked(sender As Object, e As EventArgs)
        Dim input As String = _view.txtInput.Text
        Dim result As New List(Of String)


        result.Add(TrimText(input))
        result.Add(ReplaceTxt(input))
        Dim splitResults = SplitTxt(input)
        result.AddRange(splitResults)
        result.Add(JoinTxt(splitResults))

        _view.lstOutput.items.clear()
        _view.lstOutput.items.addRange(result.ToArray())
    End Sub
    'trim
    Public Shared Function TrimText(input As String) As String
        Return input.Trim()
    End Function

    'replace
    Public Shared Function ReplaceTxt(input As String) As String
        Return input.Replace(" ", "_").Replace("Å@", "_")
    End Function

    'split
    Public Shared Function SplitTxt(input As String) As String()
        Return input.Split(","c)
    End Function

    'join
    Public Shared Function JoinTxt(inputTxts As String()) As String
        Return String.Join("|", inputTxts.Select(Function(p) p.Trim()))
    End Function
End Class