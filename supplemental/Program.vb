Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        'Dim lists As New List(Of String)()

        'Dim input As String = ""

        'While input <> "end"
        '    input = Console.ReadLine()
        '    If input <> "end" Then
        '        lists.add(input)
        '    End If
        'End While

        'For Each food In lists
        '    If food = "���[����" Then
        '        console.writeline("���[���������X�g�ɂ���܂�")
        '        Exit For
        '    End If
        'Next

        'console.readline
        '

        'Dim name As String = ""
        'Dim age As Integer = 0

        'greet(name, age)

        'Dim greeting As String = Lang(name, age)
        'console.writeline(greeting)

        'console.readline()

        'console.writeline("�H�ו������������͂��Ă�������")
        'Dim foods(2) As String
        'For i As Integer = 0 To 2
        '    foods(i) = console.readline()
        'Next

        'Using writer As New streamwriter("foods.txt")
        '    For Each food In foods
        '        writer.writeline(food)
        '    Next
        'End Using

        'Using reader As New streamreader("foods.txt")
        '    While Not reader.endofstream
        '        Dim line As String = reader.readline()
        '        console.writeline(line)
        '    End While

        'End Using

        console.writeline("��������͂��Ă�������")
        Dim num As String = console.readline()

        Try
            Dim number As Integer = Integer.parse(num)
            Dim result As Integer = 100 / number
            console.writeline(result)
        Catch ex As dividebyzeroexception
            console.writeline("0�͓��͂��Ȃ��ł�������")
        Catch ex As formatexception
            console.writeline("���l����͂��Ă�������")
        Catch ex As exception
            console.writeline("���̑��̃G���[������" & ex.message)
        Finally
            console.writeline("�������I�����܂�")

        End Try

        console.readline()


    End Sub

    'Function Lang(name As String, age As Integer)
    '    Return name & "����i" & age.tostring() & "�΁j�A����ɂ��́I"
    'End Function

    'Sub greet(ByRef name As String, ByRef age As Integer)
    '    console.writeline("�����O����͂��Ă�������")
    '    name = console.readline()

    '    console.writeline("�N�����͂��Ă�������")
    '    Dim ag As String = console.readline()

    '    If Not Integer.TryParse(ag, age) Then
    '        console.writeline("���l����͂��Ă�������")
    '    End If
    'End Sub


End Module
