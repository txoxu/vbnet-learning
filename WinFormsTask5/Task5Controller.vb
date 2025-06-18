Imports System.DirectoryServices
Imports System.IO
Imports System.Text

Public Class Task5Controller
    Public Shared Sub CsvLoad(DialogPath As String)
        'CSV�t�@�C�������i�[
        Task5Model.FilePath = DialogPath
        '�O��I�������t�@�C�����������ꍇ�̂��߂̏�����
        Task5Model.Data.Clear()
        '�t�@�C����UTF8�ŏ������݁A�i�[
        Dim lines = File.ReadAllLines(DialogPath, System.Text.Encoding.UTF8)
        '�s���ƂɌJ��Ԃ�����
        For Each line As String In lines
            '�u,�v�������Ċi�[
            Dim fields As String() = line.Split(","c)
            '�����A1�s�̒������W�̂Ƃ�data�ɒǉ�
            If fields.Length = 8 Then
                Task5Model.Data.Rows.Add(fields)
            End If
        Next
    End Sub

    Public Shared Sub CsvSave(CsvContent As StringBuilder, dgvEmployees As DataGridView)
        '�s���ƂɌJ��Ԃ����������s
        For Each row As DataGridViewRow In dgvEmployees.Rows
            '�V�����s���Ȃ��ꍇ�ɏ���
            If Not row.IsNewRow Then
                '�s�̈��̃Z�����ƂɌJ��Ԃ����������s
                For Each cell As DataGridViewCell In row.Cells
                    '�u,�v���ɋ�؂�
                    CsvContent.Append(cell.Value.ToString() & ",")
                Next
                '�Ō�̃Z���́u,�v���폜
                CsvContent.Length -= 1
                '�i�[������
                CsvContent.AppendLine()
            End If
        Next

    End Sub

    Public Shared Sub CsvNewSave(csvContent As StringBuilder, dgvEmployees As DataGridView)

        '�e�s���J��Ԃ�����
        For Each row As DataGridViewRow In dgvEmployees.Rows
            If Not row.IsNewRow Then
                Dim rowData As New List(Of String)
                For Each cell As DataGridViewCell In row.Cells
                    rowData.Add(cell.Value.ToString())
                Next
                csvContent.AppendLine(String.Join(",", rowData))
            End If
        Next
    End Sub

    Public Shared Sub CsvSearch(searchResult As DataTable, dgvEmployees As DataGridView, num As String, searchCount As Integer)
        'searchResult�ɃJ�����𔽉f
        For Each column As DataGridViewColumn In dgvEmployees.Columns
            searchResult.Columns.Add(column.HeaderText)
        Next

        'datagridview����row�Ɋi�[���J��Ԃ�����
        For Each row As DataGridViewRow In dgvEmployees.Rows
            If Not row.IsNewRow Then
                '�����A���͂��ꂽ�l�Ɨ�̂O�Ԗځi�Ј��ԍ��j���������̏���
                If row.Cells(0).Value.ToString().Trim() = num Then
                    '�������ʂɐV�����s��ǉ�
                    Dim newRow As DataRow = searchResult.NewRow()
                    'datagridview�̃J�������i�O�`�̂���-1�j�J��Ԃ�����
                    For i As Integer = 0 To dgvEmployees.ColumnCount - 1
                        '�V�������i�Ԗڂ̍s�ɒl��ǉ�
                        newRow(i) = row.Cells(i).Value.ToString()
                    Next
                    '�������ʗp�̕\�ɒǉ�
                    searchResult.Rows.Add(newRow)
                    searchCount += 1
                End If
            End If
        Next

    End Sub

    Public Shared Sub CsvSearchReset(lines As String())
        For Each line As String In lines
            Dim fields As String() = line.Split(","c)
            If fields.Length = 8 Then
                Task5Model.Data.Rows.Add(fields)
            End If
        Next
    End Sub

    Public Shared Function CsvRowDelete(dgvEmployees As DataGridView)
        'dgvEnployees�ōs��I��
        If dgvEmployees.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvEmployees.SelectedRows
                If Not row.IsNewRow Then
                    dgvEmployees.Rows.Remove(row)
                End If
            Next
            Return "�s���폜���܂���"
        Else
            Return "�s���폜�ł��܂���ł���"
        End If
    End Function
End Class