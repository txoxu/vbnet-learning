Imports System.IO
Imports System.Data

Public Class Form1
    '課題4 新規追加・削除機能 + UI整理
    Dim table2 As New DataTable()
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "CSVファイル(*.csv) | *.csv"

        If dialog.ShowDialog() = DialogResult.OK Then
            table2.Clear()
            Dim lines = File.ReadAllLines(dialog.FileName, System.Text.Encoding.UTF8)

            For Each line As String In lines
                Dim fields = line.Split(","c)
                If fields.Length = 3 Then
                    table2.Rows.Add(fields)
                End If
            Next
        End If
    End Sub

    Private Sub form_Load2(sender As Object, ex As EventArgs) Handles MyBase.Load
        table2.Columns.Add("名前")
        table2.Columns.Add("読み方")
        table2.Columns.Add("年齢")
        DataGridView2.DataSource = table2

        ComboBox1.Items.Add("選択してください")
        ComboBox1.Items.Add("名前")
        ComboBox1.Items.Add("年齢")
        ComboBox1.SelectedIndex = 0
    End Sub



    '新規追加
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox3.Text <> "" Then
            table2.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            MessageBox.Show("名前と年齢を入力してください")
        End If
    End Sub

    '削除機能
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dt As DataTable = CType(DataGridView2.DataSource, DataTable)
        For Each row As DataGridViewRow In DataGridView2.SelectedRows
            If Not row.IsNewRow Then
                dt.Rows(row.Index).Delete()
            End If
        Next
        dt.AcceptChanges()
    End Sub

    '並び替え
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim colName As String = If(ComboBox1.SelectedItem.ToString() = "名前", "読み方", "年齢")
        DataGridView2.Sort(DataGridView2.Columns(colName), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

End Class
