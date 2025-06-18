Imports System.IO
Imports System.Data

Public Class Form1
    '課題4 新規追加・削除機能 + UI整理

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "CSVファイル(*.csv) | *.csv"

        If dialog.ShowDialog() = DialogResult.OK Then
            task4Controller.LoadCsv(dialog.FileName)
        End If
    End Sub

    Private Sub form_Load2(sender As Object, ex As EventArgs) Handles MyBase.Load
        With task4Model.Table2
            .Columns.Add("名前")
            .Columns.Add("読み方")
            .Columns.Add("年齢")
        End With

        DataGridView2.DataSource = task4Model.Table2

        ComboBox1.Items.Add("選択してください")
        ComboBox1.Items.Add("名前")
        ComboBox1.Items.Add("年齢")
        ComboBox1.SelectedIndex = 0
    End Sub



    '新規追加
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim name As String = TextBox1.Text.Trim()
        Dim nameTran As String = TextBox2.Text.Trim()
        Dim age As String = TextBox3.Text.Trim()


        If task4Controller.CsvNewRow(name, nameTran, age) Then
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
        task4Controller.CsvDeleteRow(dt, DataGridView2)
        dt.AcceptChanges()
    End Sub

    '並び替え
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim colName As String = If(ComboBox1.SelectedItem.ToString() = "名前", "読み方", "年齢")
        task4Controller.SortData(DataGridView2, colName)
    End Sub
End Class
