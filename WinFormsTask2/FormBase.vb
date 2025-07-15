Imports Accessibility
Public Class FormBase
    '初期のデータをdatatableでmodelから取得
    Public Property ShowTable As DataTable

    Public Shared TextBoxes As TextBox()

    Overridable Sub readChange(ByVal TextBoxes As TextBox(), i As Integer)
        'readOnlyの有無をオーバーライドで設定
    End Sub

    Overridable Sub btnChange()
        '各ボタンの表示をオーバーライドで設定
    End Sub


    Protected Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes = {IdBox, NameBox, KanaBox, AgeBox, AddBox, TelBox}

        Dim bindingSource As New BindingSource()
        bindingSource.DataSource = ShowTable

        If ShowTable IsNot Nothing Then

            IdBox.DataBindings.Add("Text", bindingSource, "Id")
            NameBox.DataBindings.Add("Text", bindingSource, "Name")
            KanaBox.DataBindings.Add("Text", bindingSource, "Kana")
            AgeBox.DataBindings.Add("Text", bindingSource, "Age")
            AddBox.DataBindings.Add("Text", bindingSource, "Address")
            TelBox.DataBindings.Add("Text", bindingSource, "Tel")

            For i As Integer = 0 To ShowTable.Columns.Count - 1
                readChange(TextBoxes, i)
            Next
        End If
        btnChange()
    End Sub
End Class