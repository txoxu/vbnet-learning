Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        '�����ۑ�@���C�ɓ���̐H�ו��Ǘ��A�v��
        Dim name As String = ""
        Dim age As Integer = 0

        profile(name, age)

        Dim foods As New List(Of String)()
        foodLists(foods)
        fileWriteAndRead(foods)
        search(foods)
        Console.WriteLine("�����̐�������͂��Ă�������")
        Dim num As String = Console.ReadLine()
        calc(num)
        Console.ReadLine()

    End Sub

    Sub profile(ByRef name As String, ByRef age As Integer)
        Console.WriteLine("���O����͂��Ă�������")
        name = Console.ReadLine()
        Console.WriteLine("�N�����͂��Ă�������")
        Dim ag As String = Console.ReadLine()

        If Not Integer.TryParse(ag, age) Then
            Console.WriteLine("���l����͂��Ă�������")
        End If

    End Sub

    Sub foodLists(ByRef foods As List(Of String))
        Console.WriteLine("�D���ȐH�ו����R���͂��Ă�������")

        For i As Integer = 0 To 2
            Dim food As String = Console.ReadLine()
            foods.Add(food)
        Next
        Console.WriteLine("���X�g�ɒǉ����܂���")
    End Sub

    Sub fileWriteAndRead(ByRef foods As Object)
        Using writer As New StreamWriter("foods.txt")
            Console.WriteLine("���ꂩ�珑�����݂܂�")
            For Each food In foods
                writer.WriteLine(food)
            Next
        End Using

        Using reader As New StreamReader("foods.txt")
            Dim line As String
            While Not reader.EndOfStream
                line = reader.ReadLine()
                Console.WriteLine(line)
            End While
            Console.WriteLine("�ǂݍ��݂��m�F�ł��܂���")
        End Using
    End Sub

    Sub search(ByRef foods As Object)
        For Each food In foods
            If food = "���[����" Then
                Console.WriteLine("���[�������D���Ȃ�ł��ˁI")
                Exit For
            End If
        Next
    End Sub

    Sub calc(ByRef num As String)

        Try
            Dim number As Integer = Integer.Parse(num)
            Dim result As Integer = 100 \ number
            Console.WriteLine(result)
        Catch ex As DivideByZeroException
            Console.WriteLine("0�͓��͂��Ȃ��ł�������")
        Catch ex As FormatException
            Console.WriteLine("���l�ȊO�͓��͂��Ȃ��ł�������")
        Catch ex As Exception
            Console.WriteLine("���̑��̃G���[:" & ex.Message)
        Finally
            Console.WriteLine("�������I�����܂�")
        End Try
    End Sub
End Module