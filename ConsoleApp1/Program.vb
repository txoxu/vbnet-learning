Imports System
Imports System.Data


Module Program
    Sub Main(args As String())
        'Console.WriteLine("���O����͂��Ă�������")
        'Dim name As String = Console.ReadLine()

        'Console.WriteLine("�N�����͂��Ă�������")
        'Dim age As String = Console.ReadLine()
        'Dim ag As Integer

        'If Integer.TryParse(age, ag) Then
        '    If ag >= 0 AndAlso ag <= 11 Then
        '        Console.WriteLine(name & "����͎q���ł�")
        '    ElseIf ag < 18 Then
        '        Console.WriteLine(name & "����͖����N�ł�")
        '    Else
        '        Console.WriteLine(name & "����͑�l�ł�")
        '    End If
        'Else
        '    Console.WriteLine("�N��͐����œ��͂��Ă�������")
        'End If

        'Console.WriteLine("Enter�L�[�ŏI��")
        'Console.ReadLine()


        'Console.WriteLine("�D���ȉʕ����R���͂��Ă�������")

        'Dim fruits(2) As String

        'For i As Integer = 0 To 2
        '    fruits(i) = Console.ReadLine()
        'Next

        'Console.WriteLine("��������ʕ�����͂��ĉ�����")
        'Dim sel As String = Console.ReadLine()

        'Dim found As Boolean = False
        'For Each fruit In fruits
        '    If fruit = sel Then
        '        found = True
        '        Exit For
        '    End If
        'Next

        'If found Then
        '    Console.WriteLine(sel & "�̓��X�g�ɂ���܂�")
        'Else
        '    Console.WriteLine("���͂����ʕ��̓��X�g�ɂ���܂���")
        'End If

        'Console.Readline()

        'For i As Integer = 1 To 9
        '    For j As Integer = 1 To 9
        '        Dim calc As Integer = i * j
        '        Console.Write(i & "�~" & j & "=" & calc & " ")
        '    Next
        '    Console.WriteLine("")
        'Next
        'Console.ReadLine()

        'Console.WriteLine("�D���ȃt���[�c���T���͂��Ă�������")
        'Dim fruits(4) As String
        'For i As Integer = 0 To 4
        '    fruits(i) = Console.ReadLine()
        'Next

        'Console.WriteLine("�����������t���[�c����͂��Ă�������")
        'Dim sel As String = Console.ReadLine()

        'Dim found As Boolean = False
        'For Each fruit In fruits
        '    If fruit = sel Then
        '        found = True
        '        Exit For
        '    End If
        'Next

        'If found Then
        '    Console.WriteLine(sel & "�̓��X�g�ɂ���܂�")
        'Else
        '    Console.WriteLine(sel & "�̓��X�g�ɂ���܂���")
        'End If

        'Console.ReadLine()

        'Console.WriteLine("��������͂��Ă�������")
        'Dim number As String = Console.ReadLine()
        'Dim num As Integer

        'If Not Integer.TryParse(number, num) Then
        '    Console.WriteLine("���l����͂��Ă�������")
        '    Return
        'End If

        'If num <= 1 Then
        '    Console.WriteLine("�f���ł͂���܂���")
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
        '    Console.WriteLine(num & "�͑f���ł�")
        'Else
        '    Console.WriteLine("�f���ł͂���܂���")
        'End If

        'Console.ReadLine()

        'Dim data = New DataTable()

        'data.Columns.Add("name", GetType(String))
        'data.Columns.Add("age", GetType(Integer))


        'For i As Integer = 1 To 5
        '    Console.WriteLine("���O����͂��Ă�������")
        '    Dim name As String = Console.ReadLine()
        '    Console.WriteLine("�N�����͂��ĉ�����")
        '    Dim age As String = Console.ReadLine()
        '    data.Rows.Add(name, age)
        'Next

        'Dim tw As DataRow() = data.Select("age >= 20")

        'For Each row As DataRow In tw
        '    Console.WriteLine(row("name") & "����͓�\�Έȏ�ł�")

        'Next

        'Console.ReadLine()

        Console.WriteLine("�j������͂��ĉ�����")
        Dim datetime As String = Console.ReadLine()

        Select Case datetime
            Case "���j��"
                Console.WriteLine("�W���ɍs���܂��傤")
            Case "�Ηj��"
                Console.WriteLine("�Ǝ��ł�")
            Case "���j��"
                Console.WriteLine("�x�݂܂��傤")
            Case "�ؗj��"
                Console.WriteLine("�d���ł�")
            Case "���j��"
                Console.WriteLine("�o���ł�")
            Case Else
                Console.WriteLine("�������j������͂��Ă�������")
        End Select


        Console.ReadLine()
    End Sub
End Module
