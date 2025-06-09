Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        '総合課題　お気に入りの食べ物管理アプリ
        Dim name As String = ""
        Dim age As Integer = 0

        profile(name, age)

        Dim foods As New List(Of String)()
        foodLists(foods)
        fileWriteAndRead(foods)
        search(foods)
        Console.WriteLine("何かの数字を入力してください")
        Dim num As String = Console.ReadLine()
        calc(num)
        Console.ReadLine()

    End Sub

    Sub profile(ByRef name As String, ByRef age As Integer)
        Console.WriteLine("名前を入力してください")
        name = Console.ReadLine()
        Console.WriteLine("年齢を入力してください")
        Dim ag As String = Console.ReadLine()

        If Not Integer.TryParse(ag, age) Then
            Console.WriteLine("数値を入力してください")
        End If

    End Sub

    Sub foodLists(ByRef foods As List(Of String))
        Console.WriteLine("好きな食べ物を３つ入力してください")

        For i As Integer = 0 To 2
            Dim food As String = Console.ReadLine()
            foods.Add(food)
        Next
        Console.WriteLine("リストに追加しました")
    End Sub

    Sub fileWriteAndRead(ByRef foods As Object)
        Using writer As New StreamWriter("foods.txt")
            Console.WriteLine("これから書き込みます")
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
            Console.WriteLine("読み込みが確認できました")
        End Using
    End Sub

    Sub search(ByRef foods As Object)
        For Each food In foods
            If food = "ラーメン" Then
                Console.WriteLine("ラーメンが好きなんですね！")
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
            Console.WriteLine("0は入力しないでください")
        Catch ex As FormatException
            Console.WriteLine("数値以外は入力しないでください")
        Catch ex As Exception
            Console.WriteLine("その他のエラー:" & ex.Message)
        Finally
            Console.WriteLine("処理を終了します")
        End Try
    End Sub
End Module