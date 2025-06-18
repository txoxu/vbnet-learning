Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Task3Controller
    Public Shared Sub LoadCsvFile(filePath As String)
        Task3Model.CurrentFilePath = filePath
        Task3Model.Table.Clear()

        Dim lines = File.ReadLines(filePath, System.Text.Encoding.UTF8)

        For Each line As String In lines
            Dim fields = line.Split(","c)
            If fields.Length = 3 Then
                Task3Model.Table.Rows.Add(fields)
            End If
        Next
    End Sub

    Public Shared Sub ApplySearchFilter(ByRef table As DataTable, keyword As String)
        If keyword.Trim() = "" Then
            table.DefaultView.RowFilter = ""
        Else
            table.DefaultView.RowFilter = $"���O like '%{keyword}%' or �ǂݕ� like '%{keyword}%'"
        End If
    End Sub

    Public Shared Sub SaveCsvFile(filePath As String)
        If String.IsNullOrWhiteSpace(filePath) Then
            MessageBox.Show("�t�@�C�����ǂݍ��܂�Ă��܂���")
            Return
        End If

        Try
            Using writer As New StreamWriter(filePath, False, System.Text.Encoding.UTF8)
                For Each row As DataRow In Task3Model.Table.Rows
                    Dim line As String = String.Join(",", row.ItemArray)
                    writer.WriteLine(line)
                Next
            End Using
            MessageBox.Show("�㏑���ۑ����܂���")
        Catch ex As Exception
            MessageBox.Show("�ۑ����ɃG���[���������܂���")

        End Try
    End Sub

    Public Shared Sub SaveCsvNewFile(filPath As String, DataGridView As DataGridView)
        Try
            Using writer As New StreamWriter(filPath, False, System.Text.Encoding.UTF8)
                For Each row As DataGridViewRow In DataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim values As New List(Of String)
                        For i As Integer = 0 To DataGridView.Columns.Count - 1
                            values.Add(row.Cells(i).Value?.ToString())
                        Next
                        writer.WriteLine(String.Join(",", values))
                    End If
                Next
            End Using
            MessageBox.Show("�ۑ����܂���")
        Catch ex As Exception
            MessageBox.Show("�ۑ��ł��܂���ł���" & ex.Message)
        End Try
    End Sub

End Class