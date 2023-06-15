Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harga As Integer

        'cek kategori tiket yang dipilih
        If rbAnak.Checked Then
            harga = 10000 'Harga tiket anak-anak
        ElseIf rbDewasa.Checked Then
            harga = 15000 'Harga tiket dewasa
        Else
            MessageBox.Show("Pilih Kategori tiket terlebih dahulu")
            Exit Sub
        End If

        txtHargaTiket.Text = harga.ToString
    End Sub
End Class
