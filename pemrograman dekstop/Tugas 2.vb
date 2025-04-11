Public Class Tugas_2
    Private Sub Tugas_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFakultas.Items.AddRange(New String() {"FMIPA", "FKIP", "FEB"})
        cbJurusan.Items.AddRange(New String() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi NIP
        If Not IsNumeric(txtNIP.Text) Then
            MessageBox.Show("NIP hanya boleh angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil input
        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cbFakultas.SelectedItem
        Dim jurusan As String = cbJurusan.SelectedItem

        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki - Laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tampilkan hasil
        MessageBox.Show($"Hai : {nip}" & vbCrLf &
                        $"Nip : {nip}" & vbCrLf &
                        $"Nama : {nama}" & vbCrLf &
                        $"Fakultas : {fakultas}" & vbCrLf &
                        $"Jurusan : {jurusan}" & vbCrLf &
                        $"Jenis Kelamin : {jenisKelamin}", "Informasi")
    End Sub
End Class