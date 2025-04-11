Public Class Tugas_4
    Dim selectedRow As Integer = -1

    Private Sub Tugas_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi combobox jurusan
        cbJurusan.Items.AddRange(New String() {"Manajemen Informatika", "Sistem Informasi", "Ilmu Komputer"})

        ' Isi combobox mata kuliah
        cbMatkul.Items.AddRange(New String() {"Pemrograman Mobile", "Basis Data", "Pemrogrman dekstop"})
    End Sub

    Private Sub txtTugas_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged, txtUTS.TextChanged, txtUAS.TextChanged
        If txtTugas.Text = "" Or txtUTS.Text = "" Or txtUAS.Text = "" Then Exit Sub

        Dim tugas As Double = Val(txtTugas.Text)
        Dim uts As Double = Val(txtUTS.Text)
        Dim uas As Double = Val(txtUAS.Text)

        Dim total As Double = (0.3 * tugas) + (0.3 * uts) + (0.4 * uas)

        If total >= 78 Then
            lblGrade.Text = "A"
        ElseIf total >= 65 Then
            lblGrade.Text = "B"
        ElseIf total >= 50 Then
            lblGrade.Text = "C"
        ElseIf total >= 40 Then
            lblGrade.Text = "D"
        Else
            lblGrade.Text = "E"
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNIP.Enabled = True
        txtNIP.Text = ""
        txtNama.Text = ""
        txtTugas.Text = ""
        txtUTS.Text = ""
        txtUAS.Text = ""
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        cbJurusan.SelectedIndex = -1
        cbMatkul.SelectedIndex = -1
        lblGrade.Text = "-GRADE-"
        selectedRow = -1
        txtNIP.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim jk As String = ""
        If rbLaki.Checked Then
            jk = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            jk = "Perempuan"
        End If

        If selectedRow = -1 Then
            ' Tambah data baru
            dgvData.Rows.Add(txtNIP.Text, txtNama.Text, jk, cbJurusan.Text, cbMatkul.Text, lblGrade.Text)
        Else
            ' Update data yang dipilih
            dgvData.Rows(selectedRow).Cells(0).Value = txtNIP.Text
            dgvData.Rows(selectedRow).Cells(1).Value = txtNama.Text
            dgvData.Rows(selectedRow).Cells(2).Value = jk
            dgvData.Rows(selectedRow).Cells(3).Value = cbJurusan.Text
            dgvData.Rows(selectedRow).Cells(4).Value = cbMatkul.Text
            dgvData.Rows(selectedRow).Cells(5).Value = lblGrade.Text
        End If

        ' Reset field
        btnNew.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedRow <> -1 Then
            Dim confirm As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                dgvData.Rows.RemoveAt(selectedRow)
                btnNew.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        If e.RowIndex >= 0 Then
            selectedRow = e.RowIndex
            txtNIP.Text = dgvData.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNama.Text = dgvData.Rows(e.RowIndex).Cells(1).Value.ToString()

            Dim jk As String = dgvData.Rows(e.RowIndex).Cells(2).Value.ToString()
            If jk = "Laki-Laki" Then
                rbLaki.Checked = True
            ElseIf jk = "Perempuan" Then
                rbPerempuan.Checked = True
            End If

            cbJurusan.Text = dgvData.Rows(e.RowIndex).Cells(3).Value.ToString()
            cbMatkul.Text = dgvData.Rows(e.RowIndex).Cells(4).Value.ToString()
            lblGrade.Text = dgvData.Rows(e.RowIndex).Cells(5).Value.ToString()

            txtNIP.Enabled = False
        End If
    End Sub
End Class
