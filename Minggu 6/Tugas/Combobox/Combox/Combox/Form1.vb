Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim biaya As Integer
        Select Case ComboBox1.SelectedIndex
            Case 0
                'Teknik Informatika'
                biaya = 1200000
            Case 1
                'Peternakan'
                biaya = 1100000
            Case 2
                'Industri'
                biaya = 1000000
        End Select
        lblBiayaRegistrasi.Text = "Biaya Registrasi: Rp." & biaya.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
