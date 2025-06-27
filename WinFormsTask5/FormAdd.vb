Public Enum FormMode
    Add
    Edit
End Enum


Public Class FormAdd
    Public Property Mode As FormMode
    Public Property selectedDataRow As DataRow

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

        For i As Integer = 0 To Task5Model.CurrentHeaders.Count - 1
            Dim head = Task5Model.CurrentHeaders(i)
            Dim text = textBoxes(i)
            If Mode = FormMode.Edit Then
                text.Text = selectedDataRow(head).ToString()
            End If
        Next

        btnAdd.Location = New Point(120, y + 10)
        btnClose.Location = New Point(120, y + 100)

        Me.Height = y + 200
        Me.Width = 400

        btnAdd.Text = If(Mode = FormMode.Edit, "更新", "追加")
    End Sub
End Class