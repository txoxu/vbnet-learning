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
        '    If food = "ラーメン" Then
        '        console.writeline("ラーメンがリストにあります")
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

        'console.writeline("食べ物をいくつか入力してください")
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

        console.writeline("整数を入力してください")
        Dim num As String = console.readline()

        Try
            Dim number As Integer = Integer.parse(num)
            Dim result As Integer = 100 / number
            console.writeline(result)
        Catch ex As dividebyzeroexception
            console.writeline("0は入力しないでください")
        Catch ex As formatexception
            console.writeline("数値を入力してください")
        Catch ex As exception
            console.writeline("その他のエラーが発生" & ex.message)
        Finally
            console.writeline("処理を終了します")

        End Try

        console.readline()


    End Sub

    'Function Lang(name As String, age As Integer)
    '    Return name & "さん（" & age.tostring() & "歳）、こんにちは！"
    'End Function

    'Sub greet(ByRef name As String, ByRef age As Integer)
    '    console.writeline("お名前を入力してください")
    '    name = console.readline()

    '    console.writeline("年齢を入力してください")
    '    Dim ag As String = console.readline()

    '    If Not Integer.TryParse(ag, age) Then
    '        console.writeline("数値を入力してください")
    '    End If
    'End Sub


End Module
