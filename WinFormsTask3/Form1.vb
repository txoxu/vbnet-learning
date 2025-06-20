Imports System.IO

Public Class Form1
    '課題3 検索欄とボタンを設置し、名前や読み方でフィルタ表示

    Private Sub btnCsvRead_Click(sender As Object, e As EventArgs) Handles btnCsvRead.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "csvファイル(*.csv)|*.csv"

        If dialog.ShowDialog() = DialogResult.OK Then
            Task3Controller.LoadCsvFile(dialog.FileName)
        End If
    End Sub


    Private Sub form_load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Task3Model.Table
            .Columns.Add("名前")
            .Columns.Add("読み方")
            .Columns.Add("年齢")
        End With


        DataGridView.DataSource = Task3Model.Table
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = searchText.Text.Trim()

        Task3Controller.ApplySearchFilter(Task3Model.Table, keyword)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Task3Controller.SaveCsvFile(Task3Model.CurrentFilePath)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "CSVファイル(*.csv)| *.csv"
        dialog.Title = "名前を付けて保存"

        If dialog.ShowDialog() = DialogResult.OK Then
            Task3Controller.SaveCsvNewFile(dialog.FileName, DataGridView)
        End If
    End Sub

End Class
