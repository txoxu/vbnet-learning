Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        ' �N��m�F�v���O����
        Console.WriteLine("�N�����͂��Ă�������")

        Dim age As String = Console.ReadLine()
        Dim ag As Integer

        If Integer.TryParse(age, ag) Then
            Console.WriteLine("�ϊ��ɐ���")
        Else
            Console.WriteLine("�����ł͂���܂���")
        End If

        If 0 <= ag AndAlso ag <= 11 Then
            Console.WriteLine("�q���ł���")
        ElseIf ag >= 18 Then
            Console.WriteLine("��l�ł���")
        Else
            Console.WriteLine("�����N�ł���")
        End If

        Console.WriteLine("Enter�L�[�ŏI�����܂�")
        Console.ReadLine()
    End Sub
End Module
