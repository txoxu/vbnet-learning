Public Class FormShow
    Inherits FormBase

    Overrides Sub readChange(ByVal TextBoxes As TextBox(), i As Integer)
        TextBoxes(i).ReadOnly = True
    End Sub

End Class