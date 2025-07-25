Imports System.Collections


Public Class StreamReaderEnumerator
        Implements IEnumerator(Of String)

        Private _sr As IO.StreamReader
        Private _current As String

        Public Sub New(filePath As String)
            _sr = New IO.StreamReader(filePath, System.Text.Encoding.UTF8)
        End Sub

        Public ReadOnly Property Current() As String _
            Implements IEnumerator(Of String).Current

            Get
                If _sr Is Nothing OrElse _current Is Nothing Then
                    Throw New InvalidOperationException()
                End If

                Return _current
            End Get
        End Property

        Private ReadOnly Property Current1() As Object _
            Implements IEnumerator.Current

            Get
                Return Current
            End Get
        End Property

        Public Sub Reset() _
        Implements IEnumerator.Reset

            '内部バッファをクリアして、ストリームの先頭に戻す
            _sr.DiscardBufferedData()
            'ストリームの位置を先頭に戻す(Beginが0)
            _sr.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            _current = Nothing
        End Sub

        Public Function MoveNext() As Boolean _
            Implements IEnumerator.MoveNext

            _current = _sr.ReadLine()
            If _current Is Nothing Then Return False
            Return True
        End Function

        Private disposedValue As Boolean = False

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' Dispose of managed resources.
                End If
                _current = Nothing
                _sr.Close()
                _sr.Dispose()
            End If

            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
    End Class

