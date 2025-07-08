<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnNew = New Button()
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
        btnUpdate = New Button()
        btnDestroy = New Button()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(694, 415)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 0
        btnClose.Text = "閉じる"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(557, 415)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(120, 23)
        btnNew.TabIndex = 1
        btnNew.Text = "新しい行を追加"
        btnNew.UseVisualStyleBackColor = True
        btnNew.Visible = False
        ' 
        ' Id
        ' 
        Id.AutoSize = True
        Id.Location = New Point(12, 9)
        Id.Name = "Id"
        Id.Size = New Size(18, 15)
        Id.TabIndex = 2
        Id.Text = "ID"
        ' 
        ' midleName
        ' 
        midleName.AutoSize = True
        midleName.Location = New Point(145, 9)
        midleName.Name = "midleName"
        midleName.Size = New Size(31, 15)
        midleName.TabIndex = 3
        midleName.Text = "名前"
        ' 
        ' Kana
        ' 
        Kana.AutoSize = True
        Kana.Location = New Point(276, 9)
        Kana.Name = "Kana"
        Kana.Size = New Size(42, 15)
        Kana.TabIndex = 4
        Kana.Text = "読み方"
        ' 
        ' Age
        ' 
        Age.AutoSize = True
        Age.Location = New Point(421, 9)
        Age.Name = "Age"
        Age.Size = New Size(31, 15)
        Age.TabIndex = 5
        Age.Text = "年齢"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Location = New Point(12, 76)
        Address.Name = "Address"
        Address.Size = New Size(31, 15)
        Address.TabIndex = 6
        Address.Text = "住所"
        ' 
        ' Tel
        ' 
        Tel.AutoSize = True
        Tel.Location = New Point(12, 133)
        Tel.Name = "Tel"
        Tel.Size = New Size(55, 15)
        Tel.TabIndex = 7
        Tel.Text = "電話番号"
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(145, 27)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(100, 23)
        NameBox.TabIndex = 9
        ' 
        ' KanaBox
        ' 
        KanaBox.Location = New Point(276, 27)
        KanaBox.Name = "KanaBox"
        KanaBox.Size = New Size(100, 23)
        KanaBox.TabIndex = 10
        ' 
        ' AgeBox
        ' 
        AgeBox.Location = New Point(421, 27)
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(100, 23)
        AgeBox.TabIndex = 11
        ' 
        ' AddBox
        ' 
        AddBox.Location = New Point(12, 94)
        AddBox.Name = "AddBox"
        AddBox.Size = New Size(100, 23)
        AddBox.TabIndex = 12
        ' 
        ' TelBox
        ' 
        TelBox.Location = New Point(12, 151)
        TelBox.Name = "TelBox"
        TelBox.Size = New Size(100, 23)
        TelBox.TabIndex = 13
        ' 
        ' IdBox
        ' 
        IdBox.Location = New Point(12, 27)
        IdBox.Name = "IdBox"
        IdBox.Size = New Size(100, 23)
        IdBox.TabIndex = 8
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(557, 415)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(120, 23)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "更新"
        btnUpdate.UseVisualStyleBackColor = True
        btnUpdate.Visible = False
        ' 
        ' btnDestroy
        ' 
        btnDestroy.Location = New Point(557, 415)
        btnDestroy.Name = "btnDestroy"
        btnDestroy.Size = New Size(120, 23)
        btnDestroy.TabIndex = 15
        btnDestroy.Text = "削除"
        btnDestroy.UseVisualStyleBackColor = True
        btnDestroy.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDestroy)
        Controls.Add(btnUpdate)
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
        Controls.Add(btnNew)
        Controls.Add(btnClose)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnNew As Button
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
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDestroy As Button
End Class
