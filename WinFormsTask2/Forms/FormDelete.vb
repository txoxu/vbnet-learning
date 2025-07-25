Public Class FormDelete
    Inherits FormBase

    Overrides Sub readChange(ByVal TextBoxes As TextBox(), i As Integer)
        TextBoxes(i).ReadOnly = True
    End Sub

    Overrides Sub btnChange()
        btnDestroy.Visible = True
    End Sub
End Class