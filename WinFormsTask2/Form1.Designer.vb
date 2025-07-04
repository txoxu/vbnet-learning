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
        DataGridView1 = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        midleName = New DataGridViewTextBoxColumn()
        Kana = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        btnShow = New Button()
        btnAdd = New Button()
        btnDelete = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Id, midleName, Kana, Age})
        DataGridView1.Location = New Point(12, 11)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(350, 141)
        DataGridView1.TabIndex = 2
        ' 
        ' Id
        ' 
        Id.DataPropertyName = "Id"
        Id.HeaderText = "ID"
        Id.Name = "Id"
        Id.ReadOnly = True
        ' 
        ' midleName
        ' 
        midleName.DataPropertyName = "Name"
        midleName.HeaderText = "名前"
        midleName.Name = "midleName"
        midleName.ReadOnly = True
        ' 
        ' Kana
        ' 
        Kana.DataPropertyName = "Kana"
        Kana.HeaderText = "読み方"
        Kana.Name = "Kana"
        Kana.ReadOnly = True
        ' 
        ' Age
        ' 
        Age.DataPropertyName = "Age"
        Age.HeaderText = "年齢"
        Age.Name = "Age"
        Age.ReadOnly = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(12, 157)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 3
        btnShow.Text = "詳細"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(93, 157)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "追加"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(174, 157)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 5
        btnDelete.Text = "削除"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(btnShow)
        Controls.Add(DataGridView1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents midleName As DataGridViewTextBoxColumn
    Friend WithEvents Kana As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn

End Class
