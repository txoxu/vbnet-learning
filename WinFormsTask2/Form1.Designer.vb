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
        textInput = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        midleName = New DataGridViewTextBoxColumn()
        Kana = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' textInput
        ' 
        textInput.Location = New Point(132, 37)
        textInput.Margin = New Padding(3, 2, 3, 2)
        textInput.Name = "textInput"
        textInput.Size = New Size(110, 23)
        textInput.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(145, 88)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 1
        Button1.Text = "表追加"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {midleName, Kana, Age})
        DataGridView1.Location = New Point(71, 129)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(350, 141)
        DataGridView1.TabIndex = 2
        ' 
        ' midleName
        ' 
        midleName.HeaderText = "名前"
        midleName.Name = "midleName"
        midleName.DataPropertyName = "Name"
        ' 
        ' Kana
        ' 
        Kana.HeaderText = "読み方"
        Kana.Name = "Kana"
        Kana.DataPropertyName = "Kana"
        ' 
        ' Age
        ' 
        Age.HeaderText = "年齢"
        Age.Name = "Age"
        Age.DataPropertyName = "Age"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(145, 290)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "sql保存"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(textInput)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents midleName As DataGridViewTextBoxColumn
    Friend WithEvents Kana As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn

End Class
