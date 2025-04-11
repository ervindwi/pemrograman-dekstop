<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUAS = New TextBox()
        txtUTS = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtTugas = New TextBox()
        Label6 = New Label()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        Label5 = New Label()
        btnNew = New Button()
        cbMatkul = New ComboBox()
        txtNama = New TextBox()
        txtNIP = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSave = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        dgvData = New DataGridView()
        NIP = New DataGridViewTextBoxColumn()
        NAMA = New DataGridViewTextBoxColumn()
        Jenis_Kelamin = New DataGridViewTextBoxColumn()
        Jurusan = New DataGridViewTextBoxColumn()
        Mata_Kuliah = New DataGridViewTextBoxColumn()
        Grade = New DataGridViewTextBoxColumn()
        lblGrade = New Label()
        Label10 = New Label()
        cbJurusan = New ComboBox()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(392, 189)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(78, 23)
        txtUAS.TabIndex = 58
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(268, 189)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(78, 23)
        txtUTS.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(357, 192)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 15)
        Label9.TabIndex = 56
        Label9.Text = "UAS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(235, 192)
        Label8.Name = "Label8"
        Label8.Size = New Size(27, 15)
        Label8.TabIndex = 55
        Label8.Text = "UTS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(107, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 54
        Label7.Text = "Tugas"
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(151, 189)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(78, 23)
        txtTugas.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 52
        Label6.Text = "Nilai"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(211, 90)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 51
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(118, 90)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 50
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 49
        Label5.Text = "Jenis kelamin"
        ' 
        ' btnNew
        ' 
        btnNew.Location = New Point(32, 225)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(80, 23)
        btnNew.TabIndex = 48
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' cbMatkul
        ' 
        cbMatkul.FormattingEnabled = True
        cbMatkul.Location = New Point(118, 155)
        cbMatkul.Name = "cbMatkul"
        cbMatkul.Size = New Size(287, 23)
        cbMatkul.TabIndex = 47
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(117, 57)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(288, 23)
        txtNama.TabIndex = 45
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(118, 24)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(288, 23)
        txtNIP.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 43
        Label4.Text = "Mata Kuliah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 41
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 40
        Label1.Text = "NIP"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(135, 225)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(80, 23)
        btnSave.TabIndex = 59
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(246, 225)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(80, 23)
        btnDelete.TabIndex = 60
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClose.Location = New Point(357, 225)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(261, 23)
        btnClose.TabIndex = 61
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {NIP, NAMA, Jenis_Kelamin, Jurusan, Mata_Kuliah, Grade})
        dgvData.Location = New Point(-2, 288)
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(805, 161)
        dgvData.TabIndex = 62
        ' 
        ' NIP
        ' 
        NIP.HeaderText = "NIP"
        NIP.Name = "NIP"
        NIP.Width = 200
        ' 
        ' NAMA
        ' 
        NAMA.HeaderText = "NAMA"
        NAMA.Name = "NAMA"
        NAMA.Width = 200
        ' 
        ' Jenis_Kelamin
        ' 
        Jenis_Kelamin.HeaderText = "Jenis_Kelamin"
        Jenis_Kelamin.Name = "Jenis_Kelamin"
        ' 
        ' Jurusan
        ' 
        Jurusan.HeaderText = "Jurusan"
        Jurusan.Name = "Jurusan"
        ' 
        ' Mata_Kuliah
        ' 
        Mata_Kuliah.HeaderText = "Mata_Kuliah"
        Mata_Kuliah.Name = "Mata_Kuliah"
        ' 
        ' Grade
        ' 
        Grade.HeaderText = "Grade"
        Grade.Name = "Grade"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrade.Location = New Point(476, 189)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(91, 25)
        lblGrade.TabIndex = 63
        lblGrade.Text = "-GRADE-"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(35, 129)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 15)
        Label10.TabIndex = 64
        Label10.Text = "Jurusan"
        ' 
        ' cbJurusan
        ' 
        cbJurusan.FormattingEnabled = True
        cbJurusan.Location = New Point(118, 126)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(287, 23)
        cbJurusan.TabIndex = 65
        ' 
        ' Tugas_4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 450)
        Controls.Add(cbJurusan)
        Controls.Add(Label10)
        Controls.Add(lblGrade)
        Controls.Add(dgvData)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(txtUAS)
        Controls.Add(txtUTS)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtTugas)
        Controls.Add(Label6)
        Controls.Add(rbPerempuan)
        Controls.Add(rbLaki)
        Controls.Add(Label5)
        Controls.Add(btnNew)
        Controls.Add(cbMatkul)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Tugas_4"
        Text = "Tugas_4"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents cbMatkul As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents NIP As DataGridViewTextBoxColumn
    Friend WithEvents NAMA As DataGridViewTextBoxColumn
    Friend WithEvents Jenis_Kelamin As DataGridViewTextBoxColumn
    Friend WithEvents Jurusan As DataGridViewTextBoxColumn
    Friend WithEvents Mata_Kuliah As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents lblGrade As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbJurusan As ComboBox
End Class
