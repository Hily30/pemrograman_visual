Public Class kubus
    Private Sub kubus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        luas.Text = Val(rusuk.Text ^ 3)
        volume.Text = Val(rusuk.Text ^ 2) * 6
    End Sub
End Class