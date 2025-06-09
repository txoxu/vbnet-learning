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
        btnSelectCsv = New Button()
        btnSaveCsv = New Button()
        searchBox = New TextBox()
        searchBtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(445, 289)
        DataGridView1.TabIndex = 0
        ' 
        ' btnSelectCsv
        ' 
        btnSelectCsv.Location = New Point(141, 295)
        btnSelectCsv.Name = "btnSelectCsv"
        btnSelectCsv.Size = New Size(159, 29)
        btnSelectCsv.TabIndex = 1
        btnSelectCsv.Text = "CSVファイルを選択"
        btnSelectCsv.UseVisualStyleBackColor = True
        ' 
        ' btnSaveCsv
        ' 
        btnSaveCsv.Location = New Point(12, 295)
        btnSaveCsv.Name = "btnSaveCsv"
        btnSaveCsv.Size = New Size(123, 29)
        btnSaveCsv.TabIndex = 2
        btnSaveCsv.Text = "csvファイルを保存"
        btnSaveCsv.UseVisualStyleBackColor = True
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(63, 340)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(160, 27)
        searchBox.TabIndex = 3
        searchBox.Text = "キーワード"
        ' 
        ' searchBtn
        ' 
        searchBtn.Location = New Point(93, 373)
        searchBtn.Name = "searchBtn"
        searchBtn.Size = New Size(94, 29)
        searchBtn.TabIndex = 4
        searchBtn.Text = "絞り込む"
        searchBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(searchBtn)
        Controls.Add(searchBox)
        Controls.Add(btnSaveCsv)
        Controls.Add(btnSelectCsv)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSelectCsv As Button
    Friend WithEvents btnSaveCsv As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents searchBtn As Button

End Class
