Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim C, F, R, K As Decimal
        K = CDec(Kelvin.Text)
        C = ToCelcius(K)
        F = ToFahrenhait(K)
        R = ToReamur(K)

        Celcius.Text = Str(C)
        Fahrenhait.Text = Str(F)
        Reamur.Text = Str(R)
    End Sub

    Private Function ToCelcius(suhu As Decimal) As Decimal
        Dim C As Decimal
        C = Kelvin.Text - 273.15
        Return C
    End Function

    Private Function ToFahrenhait(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = (Kelvin.Text * 1.8) - 459.67
        Return F
    End Function

    Private Function ToReamur(suhu As Decimal) As Decimal
        Dim R As Decimal
        R = Kelvin.Text * 1.8
        Return R
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
