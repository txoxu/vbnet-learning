Imports System
Imports System.Data


Module Program
    Sub Main(args As String())
        'Console.WriteLine("名前を入力してください")
        'Dim name As String = Console.ReadLine()

        'Console.WriteLine("年齢を入力してください")
        'Dim age As String = Console.ReadLine()
        'Dim ag As Integer

        'If Integer.TryParse(age, ag) Then
        '    If ag >= 0 AndAlso ag <= 11 Then
        '        Console.WriteLine(name & "さんは子供です")
        '    ElseIf ag < 18 Then
        '        Console.WriteLine(name & "さんは未成年です")
        '    Else
        '        Console.WriteLine(name & "さんは大人です")
        '    End If
        'Else
        '    Console.WriteLine("年齢は数字で入力してください")
        'End If

        'Console.WriteLine("Enterキーで終了")
        'Console.ReadLine()


        'Console.WriteLine("好きな果物を３つ入力してください")

        'Dim fruits(2) As String

        'For i As Integer = 0 To 2
        '    fruits(i) = Console.ReadLine()
        'Next

        'Console.WriteLine("検索する果物を入力して下さい")
        'Dim sel As String = Console.ReadLine()

        'Dim found As Boolean = False
        'For Each fruit In fruits
        '    If fruit = sel Then
        '        found = True
        '        Exit For
        '    End If
        'Next

        'If found Then
        '    Console.WriteLine(sel & "はリストにあります")
        'Else
        '    Console.WriteLine("入力した果物はリストにありません")
        'End If

        'Console.Readline()

        'For i As Integer = 1 To 9
        '    For j As Integer = 1 To 9
        '        Dim calc As Integer = i * j
        '        Console.Write(i & "×" & j & "=" & calc & " ")
        '    Next
        '    Console.WriteLine("")
        'Next
        'Console.ReadLine()

        'Console.WriteLine("好きなフルーツを５つ入力してください")
        'Dim fruits(4) As String
        'For i As Integer = 0 To 4
        '    fruits(i) = Console.ReadLine()
        'Next

        'Console.WriteLine("検索したいフルーツを入力してください")
        'Dim sel As String = Console.ReadLine()

        'Dim found As Boolean = False
        'For Each fruit In fruits
        '    If fruit = sel Then
        '        found = True
        '        Exit For
        '    End If
        'Next

        'If found Then
        '    Console.WriteLine(sel & "はリストにあります")
        'Else
        '    Console.WriteLine(sel & "はリストにありません")
        'End If

        'Console.ReadLine()

        'Console.WriteLine("数字を入力してください")
        'Dim number As String = Console.ReadLine()
        'Dim num As Integer

        'If Not Integer.TryParse(number, num) Then
        '    Console.WriteLine("数値を入力してください")
        '    Return
        'End If

        'If num <= 1 Then
        '    Console.WriteLine("素数ではありません")
        '    Return
        'End If

        'Dim found As Boolean = True

        'For i As Integer = 2 To Math.Sqrt(num)
        '    If num Mod i = 0 Then
        '        found = False
        '        Exit For
        '    End If
        'Next

        'If found Then
        '    Console.WriteLine(num & "は素数です")
        'Else
        '    Console.WriteLine("素数ではありません")
        'End If

        'Console.ReadLine()

        'Dim data = New DataTable()

        'data.Columns.Add("name", GetType(String))
        'data.Columns.Add("age", GetType(Integer))


        'For i As Integer = 1 To 5
        '    Console.WriteLine("名前を入力してください")
        '    Dim name As String = Console.ReadLine()
        '    Console.WriteLine("年齢を入力して下さい")
        '    Dim age As String = Console.ReadLine()
        '    data.Rows.Add(name, age)
        'Next

        'Dim tw As DataRow() = data.Select("age >= 20")

        'For Each row As DataRow In tw
        '    Console.WriteLine(row("name") & "さんは二十歳以上です")

        'Next

        'Console.ReadLine()

        Console.WriteLine("曜日を入力して下さい")
        Dim datetime As String = Console.ReadLine()

        Select Case datetime
            Case "月曜日"
                Console.WriteLine("ジムに行きましょう")
            Case "火曜日"
                Console.WriteLine("家事です")
            Case "水曜日"
                Console.WriteLine("休みましょう")
            Case "木曜日"
                Console.WriteLine("仕事です")
            Case "金曜日"
                Console.WriteLine("出張です")
            Case Else
                Console.WriteLine("正しい曜日を入力してください")
        End Select


        Console.ReadLine()
    End Sub
End Module
