Public Class Persegi_panjang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(panjang.Text) * (lebar.Text)
        keliling.Text = Val(panjang.Text + lebar.Text) * 2
    End Sub
End Class