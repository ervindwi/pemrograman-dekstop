<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas_2
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
        btnProcess = New Button()
        cbJurusan = New ComboBox()
        cbFakultas = New ComboBox()
        txtNama = New TextBox()
        txtNIP = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        SuspendLayout()
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(35, 210)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(127, 23)
        btnProcess.TabIndex = 17
        btnProcess.Text = "Proses"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' cbJurusan
        ' 
        cbJurusan.FormattingEnabled = True
        cbJurusan.Location = New Point(107, 172)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(287, 23)
        cbJurusan.TabIndex = 16
        ' 
        ' cbFakultas
        ' 
        cbFakultas.FormattingEnabled = True
        cbFakultas.Location = New Point(107, 134)
        cbFakultas.Name = "cbFakultas"
        cbFakultas.Size = New Size(287, 23)
        cbFakultas.TabIndex = 15
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(107, 72)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(288, 23)
        txtNama.TabIndex = 14
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(106, 37)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(288, 23)
        txtNIP.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 12
        Label4.Text = "Jurusan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 11
        Label3.Text = "Fakultas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 9
        Label1.Text = "NIP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 18
        Label5.Text = "Jenis kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(118, 105)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 19
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(213, 105)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 20
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' Tugas_2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Name = "Tugas_2"
        Text = "Tugas_2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents cbFakultas As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
End Class
