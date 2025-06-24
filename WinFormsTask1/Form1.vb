Public Class Form1

    '課題１ 文字列処理の基本操作ツールを作ろう

    Public btnProcess As Button
    Public txtInput As TextBox
    Public lstOutput As ListBox

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Task1Controller.Initialize(Me)
    End Sub
End Class