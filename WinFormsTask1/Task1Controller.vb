Public Class Task1Controller
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