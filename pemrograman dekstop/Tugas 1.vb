Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Fakultas
        cbFakultas.Items.AddRange(New String() {"FMIPA", "FKIP", "FEB"})

        ' Isi ComboBox Jurusan
        cbJurusan.Items.AddRange(New String() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
    End Sub
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Validasi NIP hanya angka
        If Not IsNumeric(txtNIP.Text) Then
            MessageBox.Show("NIP hanya boleh angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil nilai dari input
        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cbFakultas.SelectedItem
        Dim jurusan As String = cbJurusan.SelectedItem

        ' Tampilkan MessageBox
        MessageBox.Show($"Hai : {nip}" & vbCrLf &
                        $"Nip : {nip}" & vbCrLf &
                        $"Nama : {nama}" & vbCrLf &
                        $"Fakultas : {fakultas}" & vbCrLf &
                        $"Jurusan : {jurusan}", "Informasi")
    End Sub
End Class
