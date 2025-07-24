<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTop
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
        Time = New DataGridViewTextBoxColumn()
        btnShow = New Button()
        btnAdd = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnEdit = New Button()
        Label2 = New Label()
        searchBox = New TextBox()
        btnSearch = New Button()
        NameLbl = New Label()
        DateTimePicker1 = New DateTimePicker()
        AgeComboBox = New ComboBox()
        invalidCheck = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Id, midleName, Kana, Age, Time})
        DataGridView1.Location = New Point(24, 11)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(550, 141)
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
        ' Time
        ' 
        Time.DataPropertyName = "Date"
        Time.HeaderText = "登録日時"
        Time.Name = "Time"
        Time.ReadOnly = True
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(599, 11)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(75, 23)
        btnShow.TabIndex = 3
        btnShow.Text = "詳細"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(599, 69)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "追加"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(599, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 5
        btnDelete.Text = "削除"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(599, 129)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "画面更新"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(599, 40)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 7
        btnEdit.Text = "編集/更新"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(406, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 9
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(24, 172)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(97, 23)
        searchBox.TabIndex = 10
        searchBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(433, 174)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 11
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' NameLbl
        ' 
        NameLbl.AutoSize = True
        NameLbl.Location = New Point(24, 154)
        NameLbl.Name = "NameLbl"
        NameLbl.Size = New Size(31, 15)
        NameLbl.TabIndex = 12
        NameLbl.Text = "名前"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(299, 169)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(101, 23)
        DateTimePicker1.TabIndex = 13
        ' 
        ' AgeComboBox
        ' 
        AgeComboBox.FormattingEnabled = True
        AgeComboBox.Items.AddRange(New Object() {"指定しない", "0代～20代", "30代～50代", "60代以降"})
        AgeComboBox.Location = New Point(150, 172)
        AgeComboBox.Name = "AgeComboBox"
        AgeComboBox.Size = New Size(121, 23)
        AgeComboBox.TabIndex = 14
        AgeComboBox.Text = "年代"
        ' 
        ' invalidCheck
        ' 
        invalidCheck.AutoSize = True
        invalidCheck.Location = New Point(299, 198)
        invalidCheck.Name = "invalidCheck"
        invalidCheck.Size = New Size(78, 19)
        invalidCheck.TabIndex = 15
        invalidCheck.Text = "無効にする"
        invalidCheck.UseVisualStyleBackColor = True
        ' 
        ' FormTop
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(invalidCheck)
        Controls.Add(AgeComboBox)
        Controls.Add(DateTimePicker1)
        Controls.Add(NameLbl)
        Controls.Add(btnSearch)
        Controls.Add(searchBox)
        Controls.Add(Label2)
        Controls.Add(btnEdit)
        Controls.Add(btnRefresh)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(btnShow)
        Controls.Add(DataGridView1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormTop"
        Text = "FormTop"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents NameLbl As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents AgeComboBox As ComboBox
    Friend WithEvents invalidCheck As CheckBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents midleName As DataGridViewTextBoxColumn
    Friend WithEvents Kana As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn

End Class
