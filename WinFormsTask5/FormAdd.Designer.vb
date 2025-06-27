<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdd
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
        btnAdd = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(115, 170)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 0
        btnAdd.Text = "追加"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(115, 205)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 1
        btnClose.Text = "閉じる"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' FormAdd
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnAdd)
        Name = "FormAdd"
        Text = "FormAdd"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
End Class
