﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        ' 
        ' btnDestroy
        ' 
        btnDestroy.Location = New Point(205, 326)
        btnDestroy.Name = "btnDestroy"
        btnDestroy.Size = New Size(75, 23)
        btnDestroy.TabIndex = 16
        btnDestroy.Text = "削除"
        btnDestroy.UseVisualStyleBackColor = True
        btnDestroy.Visible = False

        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "FormDelete"
        Controls.Add(btnDestroy)

    End Sub
    Friend WithEvents btnDestroy As Button
End Class
