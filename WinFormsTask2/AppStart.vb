

Module AppStart
    <STAThread>
    Sub Main()
        Dim MyForm As New FormTop()
        Dim Controller As New Task2Controller()
        Controller.Initialize(MyForm)
        Application.Run(MyForm)

    End Sub
End Module
