Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class CsvModel
    Public Function ReadCsv(filePath As String) As DataTable
        Dim dt As New DataTable()

        Try
            Using parser As New TextFieldParser(filePath, Encoding.UTF8)

                '区切り文字形式として設定
                'parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(",")
                Dim headers As String = parser.ReadLine()
                If headers Is Nothing Then Return dt

                For Each header In headers
                    dt.Columns.Add(header)
                Next

                While Not parser.EndOfData
                    Dim row = parser.ReadLine()
                    If row IsNot Nothing Then dt.Rows.Add(row)
                End While
            End Using

            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
