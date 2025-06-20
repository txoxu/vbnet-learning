<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtInput = New TextBox()
        btnProcess = New Button()
        lstOutput = New ListBox()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(170, 37)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 0
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(181, 85)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(94, 29)
        btnProcess.TabIndex = 1
        btnProcess.Text = "Button1"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.Location = New Point(161, 144)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(150, 104)
        lstOutput.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstOutput)
        Controls.Add(btnProcess)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnProcess As Button
    Friend WithEvents lstOutput As ListBox

End Class
