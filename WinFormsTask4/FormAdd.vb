Imports System.Diagnostics.SymbolStore

Public Class FormAdd
    Public textBoxes As New List(Of TextBox)

    Private Sub FormAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim headers = Task4Model.CurrentHeaders
        Dim y As Integer = 20

        For Each header In headers
            Dim lbl As New Label()
            lbl.Text = header
            lbl.Location = New Point(20, y)
            lbl.AutoSize = True
            Me.Controls.Add(lbl)

            Dim txt As New TextBox()
            txt.Name = $"{header}"
            txt.Location = New Point(120, y)
            txt.Width = 200
            Me.Controls.Add(txt)

            textBoxes.Add(txt)
            y += 30
        Next


        btn.Location = New Point(120, y + 10)
        btn.Text = "追加"
    End Sub


End Class