<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdd
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
        btnNew = New Button()
        SuspendLayout()
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(227, 336)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(75, 23)
        btnNew.TabIndex = 14
        btnNew.Text = "追加"
        btnNew.UseVisualStyleBackColor = True
        btnNew.Visible = False
        ' 
        ' FormAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(btnNew)
        Name = "FormAdd"
        Text = "FormAdd"
        Controls.SetChildIndex(btnNew, 0)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
End Class
