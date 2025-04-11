<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_3
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
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        Label5 = New Label()
        btnProcess = New Button()
        cbJurusan = New ComboBox()
        cbFakultas = New ComboBox()
        txtNama = New TextBox()
        txtNIP = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        txtTugas = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        SuspendLayout()
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(248, 99)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 32
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(153, 99)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 31
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(70, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 30
        Label5.Text = "Jenis kelamin"
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(67, 235)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(127, 23)
        btnProcess.TabIndex = 29
        btnProcess.Text = "Proses"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' cbJurusan
        ' 
        cbJurusan.FormattingEnabled = True
        cbJurusan.Location = New Point(142, 166)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(287, 23)
        cbJurusan.TabIndex = 28
        ' 
        ' cbFakultas
        ' 
        cbFakultas.FormattingEnabled = True
        cbFakultas.Location = New Point(142, 128)
        cbFakultas.Name = "cbFakultas"
        cbFakultas.Size = New Size(287, 23)
        cbFakultas.TabIndex = 27
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(142, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(288, 23)
        txtNama.TabIndex = 26
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(141, 31)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(288, 23)
        txtNIP.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(70, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 24
        Label4.Text = "Jurusan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 23
        Label3.Text = "Fakultas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 22
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 21
        Label1.Text = "NIP"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(70, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 33
        Label6.Text = "Nilai"
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(186, 206)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(78, 23)
        txtTugas.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(142, 206)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 35
        Label7.Text = "Tugas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(281, 209)
        Label8.Name = "Label8"
        Label8.Size = New Size(27, 15)
        Label8.TabIndex = 36
        Label8.Text = "UTS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(411, 212)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 15)
        Label9.TabIndex = 37
        Label9.Text = "UAS"
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(314, 209)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(78, 23)
        txtUTS.TabIndex = 38
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(446, 209)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(78, 23)
        txtUAS.TabIndex = 39
        ' 
        ' Tugas_3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Controls.Add(btnProcess)
        Controls.Add(cbJurusan)
        Controls.Add(cbFakultas)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Tugas_3"
        Text = "Tugas_3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents cbFakultas As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
End Class
