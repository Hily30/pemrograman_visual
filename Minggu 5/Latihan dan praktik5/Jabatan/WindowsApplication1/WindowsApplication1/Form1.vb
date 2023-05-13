Public Class Form1
    Private Sub txtNilaiAkhir_TextChanged(sender As Object, e As EventArgs) Handles txtKodeJabatan.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class
