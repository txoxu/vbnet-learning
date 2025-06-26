Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class Form1
    Public CurrentFilePath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        Task5Controller.Initialize(Me)
    End Sub
End Class
