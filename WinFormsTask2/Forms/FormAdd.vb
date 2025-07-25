Public Class FormAdd
    Inherits FormBase

    Public Overrides Sub btnChange()
        btnNew.Visible = True
    End Sub


    Public Sub FormReset()
        For Each box As TextBox In TextBoxes
            box.Clear()
        Next
    End Sub
End Class