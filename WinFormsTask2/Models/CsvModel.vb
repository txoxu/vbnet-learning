Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class CsvModel
    Implements IModel

    Private Shared dt As New DataTable()
    Private Shared headers As String()
    Private Shared filePath As String


    Public Sub WriteCsv(filePath As String)
        Try
            Using write As New StreamWriter(filePath, False, Encoding.UTF8)
                write.WriteLine(String.Join(",", headers))

                For Each row As DataRow In dt.Rows
                    Dim fields As String() = row.ItemArray.Select(Function(field) field.ToString()).ToArray()
                    write.WriteLine(String.Join(",", fields))
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("CSVファイルの保存に失敗しました: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function RowSelect(selectId As Integer) As DataTable Implements IModel.RowSelect
        Dim table As New DataTable()

        Dim filteredRows As DataRow() = dt.Select("Id = " & selectId.ToString())
        table = filteredRows.CopyToDataTable()
        Return table
    End Function

    Public Function FormRefresh() As DataTable Implements IModel.FormRefresh
        dt.Clear()
        dt.Columns.Clear()
        Try
            filePath = My.Settings.CsvFilePath
            Using parser As New TextFieldParser(filePath, Encoding.UTF8)

                '区切り文字形式として設定
                parser.SetDelimiters(",")
                headers = parser.ReadFields()
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
    Public Sub Add(data As PersonData) Implements IModel.Add
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

        WriteCsv(filePath)
    End Sub

    Public Sub Update(data As PersonData) Implements IModel.Update

        Dim row As DataRow() = dt.Select("Id = " & data.IdData.ToString())

        row(0)("Name") = data.NameData
        row(0)("Kana") = data.KanaData
        row(0)("Age") = data.AgeData
        row(0)("Address") = data.AddressData
        row(0)("Tel") = data.TelData
        row(0)("Date") = data.DateData
        dt.AcceptChanges()

        WriteCsv(filePath)
    End Sub

    Public Sub Destroy(selectId As Integer) Implements IModel.Destroy
        Dim row As DataRow() = dt.Select("Id = " & selectId.ToString())
        row(0).Delete()
    End Sub

    Public Function Search(data As SearchData) As DataTable Implements IModel.Search
        Dim resultTable As New DataTable()


        resultTable = dt.Select("Name LIKE '%" & data.NameData & "%'").CopyToDataTable()

            If data.DateData IsNot Nothing Then
                resultTable = resultTable.Select("Date = '" & data.DateData & "'").CopyToDataTable()
            End If

            If data.FirstNumData <> Nothing Or data.LastNumData <> Nothing Then
                resultTable = resultTable.Select(data.FirstNumData & " <= Age AND " & data.LastNumData & " >= Age").CopyToDataTable()
            End If
            Return resultTable


    End Function

End Class
