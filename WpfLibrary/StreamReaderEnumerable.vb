Namespace WpfLibrary
    Public Class StreamReaderEnumerable
        Implements IEnumerable(Of String)

        Private _filePath As String

        Public Sub New(filePath As String)
            _filePath = filePath
        End Sub
        Public Function GetEnumerator() As IEnumerator(Of String) _
                Implements IEnumerable(Of String).GetEnumerator

            Return New StreamReaderEnumerator(_filePath)
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator _
                Implements IEnumerable.GetEnumerator

            Return Me.GetEnumerator()
        End Function
    End Class
End Namespace
