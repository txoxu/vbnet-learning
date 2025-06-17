Public Class task2Controller
    Public Shared Function SplitCsvLine(input As String) As String()
        Return input.Split(","c)
    End Function

End Class