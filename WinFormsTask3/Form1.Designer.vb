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
        btnCsvRead = New Button()
        searchText = New TextBox()
        btnSearch = New Button()
        DataGridView = New DataGridView()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCsvRead
        ' 
        btnCsvRead.Location = New Point(220, 206)
        btnCsvRead.Name = "btnCsvRead"
        btnCsvRead.Size = New Size(94, 29)
        btnCsvRead.TabIndex = 0
        btnCsvRead.Text = "csv読み込み"
        btnCsvRead.UseVisualStyleBackColor = True
        ' 
        ' searchText
        ' 
        searchText.Location = New Point(370, 12)
        searchText.Name = "searchText"
        searchText.Size = New Size(125, 27)
        searchText.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(387, 45)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(14, 12)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(300, 188)
        DataGridView.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(345, 129)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 4
        Button3.Text = "上書き保存"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(465, 129)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 29)
        Button4.TabIndex = 5
        Button4.Text = "名前をつけて保存"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(DataGridView)
        Controls.Add(btnSearch)
        Controls.Add(searchText)
        Controls.Add(btnCsvRead)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCsvRead As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
