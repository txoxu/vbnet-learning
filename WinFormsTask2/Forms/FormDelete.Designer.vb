<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDelete
    Inherits FormBase

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnDestroy = New Button()
        SuspendLayout()
        ' 
        ' btnDestroy
        ' 
        btnDestroy.Location = New Point(227, 336)
        btnDestroy.Name = "btnDestroy"
        btnDestroy.Size = New Size(75, 23)
        btnDestroy.TabIndex = 16
        btnDestroy.Text = "削除"
        btnDestroy.UseVisualStyleBackColor = True
        btnDestroy.Visible = False
        ' 
        ' FormDelete
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(btnDestroy)
        Name = "FormDelete"
        Text = "FormDelete"
        Controls.SetChildIndex(btnDestroy, 0)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnDestroy As Button
End Class
