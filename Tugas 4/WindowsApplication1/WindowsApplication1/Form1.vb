Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim C, F, R, K As Decimal
        R = CDec(Reamur.Text)
        C = ToCelcius(R)
        F = ToFahrenhait(R)
        K = ToKelvin(R)

        Celcius.Text = Str(C)
        Fahrenhait.Text = Str(F)
        Kelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(suhu As Decimal) As Decimal
        Dim C As Decimal
        C = (Reamur.Text + 1.8) - 273.15
        Return C
    End Function

    Private Function ToFahrenhait(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = Reamur.Text - 459.67
        Return F
    End Function

    Private Function ToKelvin(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = Reamur.Text + 1.8
        Return K
    End Function
End Class
