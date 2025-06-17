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
        dgvEmployees = New DataGridView()
        btnLoadCsv = New Button()
        btnSaveCsv = New Button()
        btnSaveAsCsv = New Button()
        btnSearch = New Button()
        btnClearSearch = New Button()
        btnDeleteRow = New Button()
        textSearch = New TextBox()
        lblStatus = New Label()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(12, 12)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(766, 253)
        dgvEmployees.TabIndex = 0
        ' 
        ' btnLoadCsv
        ' 
        btnLoadCsv.Location = New Point(561, 271)
        btnLoadCsv.Name = "btnLoadCsv"
        btnLoadCsv.Size = New Size(122, 29)
        btnLoadCsv.TabIndex = 1
        btnLoadCsv.Text = "CSV読み込み"
        btnLoadCsv.UseVisualStyleBackColor = True
        ' 
        ' btnSaveCsv
        ' 
        btnSaveCsv.Location = New Point(694, 271)
        btnSaveCsv.Name = "btnSaveCsv"
        btnSaveCsv.Size = New Size(94, 29)
        btnSaveCsv.TabIndex = 2
        btnSaveCsv.Text = "上書き保存"
        btnSaveCsv.UseVisualStyleBackColor = True
        ' 
        ' btnSaveAsCsv
        ' 
        btnSaveAsCsv.Location = New Point(661, 306)
        btnSaveAsCsv.Name = "btnSaveAsCsv"
        btnSaveAsCsv.Size = New Size(132, 29)
        btnSaveAsCsv.TabIndex = 3
        btnSaveAsCsv.Text = "名前をつけて保存"
        btnSaveAsCsv.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(131, 361)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 4
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.Location = New Point(22, 361)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(94, 29)
        btnClearSearch.TabIndex = 5
        btnClearSearch.Text = "検索リセット"
        btnClearSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteRow
        ' 
        btnDeleteRow.Location = New Point(343, 324)
        btnDeleteRow.Name = "btnDeleteRow"
        btnDeleteRow.Size = New Size(94, 29)
        btnDeleteRow.TabIndex = 7
        btnDeleteRow.Text = "行削除"
        btnDeleteRow.UseVisualStyleBackColor = True
        ' 
        ' textSearch
        ' 
        textSearch.Location = New Point(22, 308)
        textSearch.Name = "textSearch"
        textSearch.Size = New Size(125, 27)
        textSearch.TabIndex = 8
        textSearch.Text = "社員検索"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(22, 271)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(0, 20)
        lblStatus.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(textSearch)
        Controls.Add(btnDeleteRow)
        Controls.Add(btnClearSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnSaveAsCsv)
        Controls.Add(btnSaveCsv)
        Controls.Add(btnLoadCsv)
        Controls.Add(dgvEmployees)
        Name = "Form1"
        Text = "Form1"
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnLoadCsv As Button
    Friend WithEvents btnSaveCsv As Button
    Friend WithEvents btnSaveAsCsv As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnDeleteRow As Button
    Friend WithEvents textSearch As TextBox
    Friend WithEvents lblStatus As Label

End Class
