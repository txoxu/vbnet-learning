Public Class FormAdd
    'FormAdd_Loadでheaderの数が確定しているためnewする
    Public textBoxes As New List(Of TextBox)
    Public Sub FormAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim headers = Task5Model.CurrentHeaders
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

        btnAdd.Location = New Point(120, y + 10)
        btnClose.Location = New Point(120, y + 100)

        Me.Height = y + 200
        Me.Width = 400
    End Sub
End Class