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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNIP = New TextBox()
        txtNama = New TextBox()
        cbFakultas = New ComboBox()
        cbJurusan = New ComboBox()
        btnProcess = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 2
        Label3.Text = "Fakultas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jurusan"
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(100, 36)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(288, 23)
        txtNIP.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(100, 71)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(288, 23)
        txtNama.TabIndex = 5
        ' 
        ' cbFakultas
        ' 
        cbFakultas.FormattingEnabled = True
        cbFakultas.Location = New Point(101, 113)
        cbFakultas.Name = "cbFakultas"
        cbFakultas.Size = New Size(287, 23)
        cbFakultas.TabIndex = 6
        ' 
        ' cbJurusan
        ' 
        cbJurusan.FormattingEnabled = True
        cbJurusan.Location = New Point(101, 144)
        cbJurusan.Name = "cbJurusan"
        cbJurusan.Size = New Size(287, 23)
        cbJurusan.TabIndex = 7
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(45, 190)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(127, 23)
        btnProcess.TabIndex = 8
        btnProcess.Text = "Proses"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnProcess)
        Controls.Add(cbJurusan)
        Controls.Add(cbFakultas)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbFakultas As ComboBox
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents btnProcess As Button

End Class
