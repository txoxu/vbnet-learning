Imports System.IO
Imports System.Reflection.Metadata.Ecma335

Public Class task4Controller
    Public Shared Sub LoadCsv(filePath As String)
        task4Model.Table2.Clear()

        Dim lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8)

        For Each line As String In lines
            Dim fields = line.Split(","c)
            If fields.Length = 3 Then
                task4Model.Table2.Rows.Add(fields)
            End If
        Next
    End Sub

    Public Shared Function CsvNewRow(name As String, nameTran As String, age As String)
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(nameTran) OrElse String.IsNullOrWhiteSpace(age) Then
            Return False
        End If

        task4Model.Table2.Rows.Add(name, nameTran, age)
        Return True
    End Function

    Public Shared Sub CsvDeleteRow(dt As DataTable, DataGridView2 As DataGridView)
        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            If Not row.IsNewRow Then
                Dim drv As DataRowView = TryCast(row.DataBoundItem, DataRowView)
                If drv IsNot Nothing Then
                    dt.Rows(row.Index).Delete()
                End If
            End If
        Next
    End Sub

    Public Shared Sub SortData(dgv As DataGridView, colName As String)
        If dgv.Columns.Contains(colName) Then
            dgv.Sort(dgv.Columns(colName), ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
End Class