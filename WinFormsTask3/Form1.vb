Imports System.IO

Public Class Form1
    '課題3 検索欄とボタンを設置し、名前や読み方でフィルタ表示
    Public CurrentFilePath As String


    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Task3Controller.Initialize(Me)
    End Sub
End Class
