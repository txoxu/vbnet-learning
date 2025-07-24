Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class CsvModel

    Private Shared dt As New DataTable()

    Public Function ReadCsv(filePath As String) As DataTable

        Try
            Using parser As New TextFieldParser(filePath, Encoding.UTF8)

                '区切り文字形式として設定
                parser.SetDelimiters(",")
                Dim headers As String() = parser.ReadFields()
                If headers Is Nothing Then Return dt

                For Each header As String In headers
                    dt.Columns.Add(header)
                Next

                dt.Columns("名前").ColumnName = "Name"
                dt.Columns("読み方").ColumnName = "Kana"
                dt.Columns("年齢").ColumnName = "Age"
                dt.Columns("住所").ColumnName = "Address"
                dt.Columns("電話番号").ColumnName = "Tel"
                dt.Columns("登録日時").ColumnName = "Date"

                While Not parser.EndOfData
                    Dim row As String() = parser.ReadFields()
                    If row IsNot Nothing Then dt.Rows.Add(row)
                End While
            End Using


            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function RowSelect(selectId As Integer) As DataTable
        Dim table As New DataTable()

        Dim filteredRows As DataRow() = dt.Select("Id = " & selectId.ToString())
        table = filteredRows.CopyToDataTable()
        Return table


    End Function
    Public Sub Add(data As PersonData)
        Dim row As DataRow = dt.NewRow()

        Dim lastrow As DataRow = dt.Rows(dt.Rows.Count - 1)
        Dim lastId As Integer = lastrow(dt.Columns("Id")).ToString()
        lastId += 1

        row("Id") = lastId
        row("Name") = data.NameData
        row("Kana") = data.KanaData
        row("Age") = data.AgeData
        row("Address") = data.AddressData
        row("Tel") = data.TelData
        row("Date") = data.DateData
        dt.Rows.Add(row)
    End Sub

    Public Sub Update(data As PersonData)

        Dim row As DataRow() = dt.Select("Id = " & data.IdData.ToString())

        row(0)("Name") = data.NameData
        row(0)("Kana") = data.KanaData
        row(0)("Age") = data.AgeData
        row(0)("Address") = data.AddressData
        row(0)("Tel") = data.TelData
        row(0)("Date") = data.DateData
        dt.AcceptChanges()
    End Sub

    Sub Destroy(selectId As Integer)

        Dim row As DataRow() = dt.Select("Id = " & selectId.ToString())
        row(0).Delete()
    End Sub



End Class
