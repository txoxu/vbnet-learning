Imports System.IO
Imports System.Text

Public Class Task4Model

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
End Class