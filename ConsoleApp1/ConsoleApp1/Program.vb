Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        Console.WriteLine("��ڂ̐�������͂��Ă�������")
        Dim number1 As String = Console.ReadLine()
        Dim num1 As Integer

        If Not Integer.TryParse(number1, num1) Then
            Console.WriteLine("num1�̕ϊ��Ɏ��s")
        End If

        Console.WriteLine("��ڂ̐�������͂��Ă�������")
        Dim number2 As String = Console.ReadLine()
        Dim num2 As Integer

        If Not Integer.TryParse(number2, num2) Then
            Console.WriteLine("num2�̕ϊ��Ɏ��s")
        End If

        Console.WriteLine("�v�Z������͂��Ă�������")
        Dim ob As Object = Console.ReadLine()
        Dim result As Double

        Select Case ob

            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 = 0 Then
                    Console.WriteLine("�[���Ŋ���܂���")
                Else
                    result = num1 / num2
                End If

        End Select

        Console.WriteLine(result)
    End Sub
End Module
