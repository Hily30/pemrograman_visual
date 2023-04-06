Public Class Segitiga
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tinggi.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(alas.Text) * (tinggi.Text) / 2
        keliling.Text = Val(alas.Text) + (tinggi.Text) + (luas.Text)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
