<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBase
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnClose = New Button()
        Id = New Label()
        midleName = New Label()
        Kana = New Label()
        Age = New Label()
        Address = New Label()
        Tel = New Label()
        NameBox = New TextBox()
        KanaBox = New TextBox()
        AgeBox = New TextBox()
        AddBox = New TextBox()
        TelBox = New TextBox()
        IdBox = New TextBox()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(297, 326)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 0
        btnClose.Text = "閉じる"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Id
        ' 
        Id.AutoSize = True
        Id.Location = New Point(12, 52)
        Id.Name = "Id"
        Id.Size = New Size(18, 15)
        Id.TabIndex = 2
        Id.Text = "ID"
        ' 
        ' midleName
        ' 
        midleName.AutoSize = True
        midleName.Location = New Point(12, 102)
        midleName.Name = "midleName"
        midleName.Size = New Size(31, 15)
        midleName.TabIndex = 3
        midleName.Text = "名前"
        ' 
        ' Kana
        ' 
        Kana.AutoSize = True
        Kana.Location = New Point(193, 105)
        Kana.Name = "Kana"
        Kana.Size = New Size(42, 15)
        Kana.TabIndex = 4
        Kana.Text = "読み方"
        ' 
        ' Age
        ' 
        Age.AutoSize = True
        Age.Location = New Point(12, 159)
        Age.Name = "Age"
        Age.Size = New Size(31, 15)
        Age.TabIndex = 5
        Age.Text = "年齢"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Location = New Point(12, 218)
        Address.Name = "Address"
        Address.Size = New Size(31, 15)
        Address.TabIndex = 6
        Address.Text = "住所"
        ' 
        ' Tel
        ' 
        Tel.AutoSize = True
        Tel.Location = New Point(3, 271)
        Tel.Name = "Tel"
        Tel.Size = New Size(55, 15)
        Tel.TabIndex = 7
        Tel.Text = "電話番号"
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(77, 102)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(100, 23)
        NameBox.TabIndex = 9
        ' 
        ' KanaBox
        ' 
        KanaBox.Location = New Point(241, 102)
        KanaBox.Name = "KanaBox"
        KanaBox.Size = New Size(100, 23)
        KanaBox.TabIndex = 10
        ' 
        ' AgeBox
        ' 
        AgeBox.Location = New Point(77, 156)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(100, 23)
        AgeBox.TabIndex = 11
        ' 
        ' AddBox
        ' 
        AddBox.Location = New Point(77, 210)
        AddBox.Name = "AddBox"
        AddBox.Size = New Size(100, 23)
        AddBox.TabIndex = 12
        ' 
        ' TelBox
        ' 
        TelBox.Location = New Point(77, 268)
        TelBox.Name = "TelBox"
        TelBox.Size = New Size(100, 23)
        TelBox.TabIndex = 13
        ' 
        ' IdBox
        ' 
        IdBox.Location = New Point(77, 49)
        IdBox.Name = "IdBox"
        IdBox.ReadOnly = True
        IdBox.Size = New Size(100, 23)
        IdBox.TabIndex = 8
        ' 
        ' FormBase
        ' 
        components = New ComponentModel.Container
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(TelBox)
        Controls.Add(AddBox)
        Controls.Add(AgeBox)
        Controls.Add(KanaBox)
        Controls.Add(NameBox)
        Controls.Add(IdBox)
        Controls.Add(Tel)
        Controls.Add(Address)
        Controls.Add(Age)
        Controls.Add(Kana)
        Controls.Add(midleName)
        Controls.Add(Id)
        Controls.Add(btnClose)
        Name = "FormBase"
        Text = "FormBase"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Id As Label
    Friend WithEvents midleName As Label
    Friend WithEvents Kana As Label
    Friend WithEvents Age As Label
    Friend WithEvents Address As Label
    Friend WithEvents Tel As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents KanaBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents AddBox As TextBox
    Friend WithEvents TelBox As TextBox
    Friend WithEvents IdBox As TextBox
End Class
