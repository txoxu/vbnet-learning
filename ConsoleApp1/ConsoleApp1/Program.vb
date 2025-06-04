Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        ' 年齢確認プログラム
        Console.WriteLine("年齢を入力してください")

        Dim age As String = Console.ReadLine()
        Dim ag As Integer

        If Integer.TryParse(age, ag) Then
            Console.WriteLine("変換に成功")
        Else
            Console.WriteLine("数字ではありません")
        End If

        If 0 <= ag AndAlso ag <= 11 Then
            Console.WriteLine("子供ですね")
        ElseIf ag >= 18 Then
            Console.WriteLine("大人ですね")
        Else
            Console.WriteLine("未成年ですね")
        End If

        Console.WriteLine("Enterキーで終了します")
        Console.ReadLine()
    End Sub
End Module
