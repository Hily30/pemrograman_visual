Public Class jajargenjang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(alas.Text) * (tinggi.Text)
        keliling.Text = Val(alas.Text + tinggi.Text) * 2
    End Sub
End Class