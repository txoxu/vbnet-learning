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
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        Button5 = New Button()
        Button6 = New Button()
        DataGridView2 = New DataGridView()
        Button7 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Button3
        ' 
        Button3.Location = New Point(790, 333)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 12
        Button3.Text = "上書き保存"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(909, 333)
        Button4.Name = "Button4"
        Button4.Size = New Size(130, 29)
        Button4.TabIndex = 13
        Button4.Text = "名前を付けて保存"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 438)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(174, 438)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(319, 438)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 405)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 17
        Label1.Text = "名前"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 405)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 18
        Label2.Text = "読み方"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(319, 405)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 19
        Label3.Text = "年齢"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(31, 471)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 20
        Button2.Text = "新規追加"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(31, 515)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "条件"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(145, 471)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 22
        Button5.Text = "削除"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(31, 559)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 23
        Button6.Text = "並び替え"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(486, 438)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(432, 188)
        DataGridView2.TabIndex = 24
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(486, 632)
        Button7.Name = "Button7"
        Button7.Size = New Size(197, 29)
        Button7.TabIndex = 25
        Button7.Text = "csvファイルを読み込む"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 725)
        Controls.Add(Button7)
        Controls.Add(DataGridView2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
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
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button7 As Button

End Class
