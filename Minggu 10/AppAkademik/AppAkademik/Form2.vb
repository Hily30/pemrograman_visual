Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKode.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data tidak ditemukan")
                matakuliah_baru = True
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKode.Text = oMatakuliah.kodemk
        txtNama.Text = oMatakuliah.namamk
        txtSKS.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKode.Clear()
        txtNama.Clear()
        txtSKS.Clear()
        txtProdi.Clear()
        txtKode.Focus()
    End Sub

    Private Sub SimpanDatamatakuliah()
        oMatakuliah.kodemk = txtKode.Text
        oMatakuliah.namamk = txtNama.Text
        oMatakuliah.sks = txtSKS.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan.")
        ElseIf (oMatakuliah.UpdateState = True) Then
            MessageBox.Show("Data Berhasil Diperbarui.")
        Else
            MessageBox.Show("Data gagal Disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKode.Text <> "" And txtNama.Text <> "") Then
            SimpanDatamatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("kodemk dan namamk tidak boleh kosong!")
        End If
    End Sub

    Private Sub Hapus()
        If (matakuliah_baru = False And txtKode.Text <> "") Then
            oMatakuliah.Hapus(txtKode.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus?", "confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class