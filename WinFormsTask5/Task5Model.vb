Imports System.IO
Imports System.Text

Public Class Task5Model
    'csvファイルが読み込まれる都度初期化したいためここではnewはしない
    Public Shared CurrentHeaders As List(Of String)
    Public Shared Function LoadCsv(filePath As String) As DataTable
        Dim Table As New DataTable()
        CurrentHeaders = New List(Of String)

        Try
            Using read As New StreamReader(filePath, Encoding.UTF8)
                Dim headers = read.ReadLine()?.Split(","c)
                If headers Is Nothing Then Return Table

                For Each header In headers
                    Table.Columns.Add(header.Trim())
                    'listのためcolumnは必要ない
                    CurrentHeaders.Add(header.Trim())
                Next

                While Not read.EndOfStream
                    Dim row = read.ReadLine()?.Split(","c)
                    If row IsNot Nothing Then Table.Rows.Add(row)
                End While
            End Using

            Return Table
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function SaveCsv(filePath As String, table As DataTable, ByRef errorMessage As String) As Boolean
        Try
            Using writer As New StreamWriter(filePath, False, Encoding.UTF8)
                Dim headers = table.Columns.Cast(Of DataColumn).Select(Function(col) col.ColumnName)
                writer.WriteLine(String.Join(",", headers))

                For Each row As DataRow In table.Rows
                    Dim fields = row.ItemArray.Select(Function(field) field.ToString())
                    writer.WriteLine(String.Join(",", fields))
                Next
            End Using
            Return True
        Catch ex As Exception
            errorMessage = ex.Message
            Return False
        End Try
    End Function
End Class