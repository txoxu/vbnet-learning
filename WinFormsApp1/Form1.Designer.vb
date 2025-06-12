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
        Button1 = New Button()
        textInput = New TextBox()
        DataGridView1 = New DataGridView()
        btnCsvRead = New Button()
        searchText = New TextBox()
        btnSearch = New Button()
        DataGridView = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(31, 33)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(268, 27)
        txtInput.TabIndex = 0
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(109, 66)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(94, 29)
        btnProcess.TabIndex = 1
        btnProcess.Text = "加工"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.Location = New Point(31, 121)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(268, 144)
        lstOutput.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(416, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' textInput
        ' 
        textInput.Location = New Point(361, 33)
        textInput.Name = "textInput"
        textInput.Size = New Size(224, 27)
        textInput.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(348, 121)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 6
        ' 
        ' btnCsvRead
        ' 
        btnCsvRead.Location = New Point(861, 18)
        btnCsvRead.Name = "btnCsvRead"
        btnCsvRead.Size = New Size(94, 29)
        btnCsvRead.TabIndex = 7
        btnCsvRead.Text = "CSV読み込み"
        btnCsvRead.UseVisualStyleBackColor = True
        ' 
        ' searchText
        ' 
        searchText.Location = New Point(770, 53)
        searchText.Name = "searchText"
        searchText.Size = New Size(269, 27)
        searchText.TabIndex = 8
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(861, 86)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 9
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(755, 121)
        DataGridView.Name = "DataGridView"
        DataGridView.RowHeadersWidth = 51
        DataGridView.Size = New Size(300, 188)
        DataGridView.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 11
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(770, 333)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 12
        Button3.Text = "上書き保存"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(934, 333)
        Button4.Name = "Button4"
        Button4.Size = New Size(130, 29)
        Button4.TabIndex = 13
        Button4.Text = "名前を付けて保存"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 480)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView)
        Controls.Add(btnSearch)
        Controls.Add(searchText)
        Controls.Add(btnCsvRead)
        Controls.Add(DataGridView1)
        Controls.Add(textInput)
        Controls.Add(Button1)
        Controls.Add(lstOutput)
        Controls.Add(btnProcess)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnProcess As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents textInput As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCsvRead As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
