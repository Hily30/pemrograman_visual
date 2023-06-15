Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkMember.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHargaBarang.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hargabarang As Double = CDbl(txtHargaBarang.Text)
        Dim jumlahbarang As Double = CInt(txtJumlahBarang.Text)
        Dim totalbayar As Double = hargabarang * jumlahbarang

        If chkMember.Checked Then
            totalbayar *= 0.9 'diskon 10% untuk anggota
        End If

        lblTotalBayar.Text = "Total Bayar: Rp " & Format(totalbayar)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
