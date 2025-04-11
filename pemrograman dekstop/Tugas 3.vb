Public Class Tugas_3
    Private Sub Tugas_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFakultas.Items.AddRange(New String() {"FMIPA", "FKIP", "FEB"})
        cbJurusan.Items.AddRange(New String() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi NIP
        If Not IsNumeric(txtNIP.Text) Then
            MessageBox.Show("NIP hanya boleh angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi nilai
        Dim tugas, uts, uas As Double
        If Not Double.TryParse(txtTugas.Text, tugas) Or Not Double.TryParse(txtUTS.Text, uts) Or Not Double.TryParse(txtUAS.Text, uas) Then
            MessageBox.Show("Masukkan nilai Tugas, UTS, dan UAS dengan benar (angka).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hitung nilai akhir
        Dim nilaiAkhir As Double = (0.3 * tugas) + (0.3 * uts) + (0.4 * uas)

        ' Tentukan Grade
        Dim grade As String = ""
        Select Case nilaiAkhir
            Case >= 78 AndAlso nilaiAkhir <= 90
                grade = "A"
            Case >= 65 AndAlso nilaiAkhir <= 77
                grade = "B"
            Case >= 50 AndAlso nilaiAkhir <= 64
                grade = "C"
            Case >= 40 AndAlso nilaiAkhir <= 49
                grade = "D"
            Case < 40
                grade = "E"
        End Select

        ' Ambil data lain
        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cbFakultas.SelectedItem
        Dim jurusan As String = cbJurusan.SelectedItem

        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki - Laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        End If

        ' Tampilkan pesan
        MessageBox.Show($"Hai : {nip}" & vbCrLf &
                        $"Nip : {nip}" & vbCrLf &
                        $"Nama : {nama}" & vbCrLf &
                        $"Fakultas : {fakultas}" & vbCrLf &
                        $"Jurusan : {jurusan}" & vbCrLf &
                        $"Jenis Kelamin : {jenisKelamin}" & vbCrLf &
                        $"Nilai Akhir : {nilaiAkhir}" & vbCrLf &
                        $"GRADE : {grade}", "Informasi")
    End Sub
End Class