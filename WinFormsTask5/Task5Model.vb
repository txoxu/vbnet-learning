Public Class Task5Model
    Public Shared Property Data As New DataTable()
    Public Shared Property SearchResult As New DataTable()
    Public Shared Property FilePath As String

    Public Shared Sub InitializeColumns()
        With Data.Columns
            .Add("社員ID")
            .Add("氏名")
            .Add("フリガナ")
            .Add("所属部署")
            .Add("メールアドレス")
            .Add("電話番号")
            .Add("入社日")
            .Add("在籍状況")
        End With
    End Sub
End Class