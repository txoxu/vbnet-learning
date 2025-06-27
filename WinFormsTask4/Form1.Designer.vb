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
        btnAdd = New Button()
        ComboBox1 = New ComboBox()
        btnDelete = New Button()
        btnSearch = New Button()
        DataGridView2 = New DataGridView()
        btnCsv = New Button()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(166, 403)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 20
        btnAdd.Text = "新規追加"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(66, 457)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "条件"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(66, 403)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 22
        btnDelete.Text = "削除"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(83, 507)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 23
        btnSearch.Text = "並び替え"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(31, 209)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(432, 188)
        DataGridView2.TabIndex = 24
        ' 
        ' btnCsv
        ' 
        btnCsv.Location = New Point(266, 403)
        btnCsv.Name = "btnCsv"
        btnCsv.Size = New Size(197, 29)
        btnCsv.TabIndex = 25
        btnCsv.Text = "csvファイルを読み込む"
        btnCsv.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 725)
        Controls.Add(btnCsv)
        Controls.Add(DataGridView2)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(ComboBox1)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCsv As Button

End Class
