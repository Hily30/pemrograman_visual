Public Class Lingkaran
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(jari.Text ^ 2) * 3.14
        keliling.Text = Val(jari.Text) * 2 * 3.14
    End Sub
End Class