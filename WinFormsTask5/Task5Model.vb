Public Class Task5Model
    Public Shared Property Data As New DataTable()
    Public Shared Property SearchResult As New DataTable()
    Public Shared Property FilePath As String

    Public Shared Sub InitializeColumns()
        With Data.Columns
            .Add("�Ј�ID")
            .Add("����")
            .Add("�t���K�i")
            .Add("��������")
            .Add("���[���A�h���X")
            .Add("�d�b�ԍ�")
            .Add("���Г�")
            .Add("�ݐЏ�")
        End With
    End Sub
End Class