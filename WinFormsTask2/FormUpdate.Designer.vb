<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdate
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
        btnUpdate = New Button()
        SuspendLayout()
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(205, 326)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "変更"
        btnUpdate.UseVisualStyleBackColor = True
        btnUpdate.Visible = False
        ' 
        ' FormUpdate
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUpdate)
        Name = "FormUpdate"
        Text = "FormUpdate"
        Controls.SetChildIndex(btnUpdate, 0)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUpdate As Button
End Class
