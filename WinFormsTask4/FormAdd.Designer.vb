﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn = New Button()
        SuspendLayout()
        ' 
        ' btn
        ' 
        Me.btn.Location = New Point(103, 136)
        Me.btn.Name = "btn"
        Me.btn.Size = New Size(94, 29)
        Me.btn.TabIndex = 0
        Me.btn.Text = "btn"
        Me.btn.UseVisualStyleBackColor = True
        ' 
        ' FormAdd
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CType(Me.btn, Control))
        Name = "FormAdd"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn As Button
End Class
