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
        DataGridView = New DataGridView()
        btnCsv = New Button()
        btnOverWriteSave = New Button()
        btnNewWriteSave = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        searchText = New TextBox()
        lblStatus = New Label()
        btnOpenModal = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(12, 12)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(766, 253)
        DataGridView.TabIndex = 0
        ' 
        ' btnCsv
        ' 
        btnCsv.Location = New Point(12, 271)
        btnCsv.Name = "btnCsv"
        btnCsv.Size = New Size(122, 29)
        btnCsv.TabIndex = 1
        btnCsv.Text = "CSV読み込み"
        btnCsv.UseVisualStyleBackColor = True
        ' 
        ' btnOverWriteSave
        ' 
        btnOverWriteSave.Location = New Point(154, 271)
        btnOverWriteSave.Name = "btnOverWriteSave"
        btnOverWriteSave.Size = New Size(94, 29)
        btnOverWriteSave.TabIndex = 2
        btnOverWriteSave.Text = "上書き保存"
        btnOverWriteSave.UseVisualStyleBackColor = True
        ' 
        ' btnNewWriteSave
        ' 
        btnNewWriteSave.Location = New Point(266, 271)
        btnNewWriteSave.Name = "btnNewWriteSave"
        btnNewWriteSave.Size = New Size(132, 29)
        btnNewWriteSave.TabIndex = 3
        btnNewWriteSave.Text = "名前をつけて保存"
        btnNewWriteSave.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(12, 361)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 4
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(12, 396)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 5
        btnClear.Text = "検索リセット"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(427, 271)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 7
        btnDelete.Text = "行削除"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' searchText
        ' 
        searchText.Location = New Point(12, 317)
        searchText.Name = "searchText"
        searchText.Size = New Size(125, 27)
        searchText.TabIndex = 8
        searchText.Text = "検索"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(22, 271)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 20)
        lblStatus.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnOpenModal.Location = New Point(545, 271)
        btnOpenModal.Name = "btnOpenModal"
        btnOpenModal.Size = New Size(94, 29)
        btnOpenModal.TabIndex = 10
        btnOpenModal.Text = "新規追加"
        btnOpenModal.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnOpenModal)
        Controls.Add(lblStatus)
        Controls.Add(searchText)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnNewWriteSave)
        Controls.Add(btnOverWriteSave)
        Controls.Add(btnCsv)
        Controls.Add(DataGridView)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btnCsv As Button
    Friend WithEvents btnOverWriteSave As Button
    Friend WithEvents btnNewWriteSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnOpenModal As Button

End Class
