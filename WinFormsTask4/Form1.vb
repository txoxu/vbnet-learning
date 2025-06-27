Imports System.IO
Imports System.Data

Public Class Form1
    '課題4 新規追加・削除機能 + UI整理
    Private Sub Form1_Load(sender As Object, ex As EventArgs) Handles MyBase.Load
        Dim headers = Task4Model.CurrentHeaders
        Task4Controller.Initialize(Me)
    End Sub


    Public Sub SetComboBoxHeaders(headers As List(Of String))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("選択してください")
        If headers IsNot Nothing Then
            For Each header In headers
                ComboBox1.Items.Add(header)
            Next
        End If
        ComboBox1.SelectedIndex = 0
    End Sub

End Class
