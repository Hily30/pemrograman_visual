Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class Form_pelanggan
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kode_pelanggan As String = txtKode_pelanggan.Text
        Dim nama_pelanggan As String = txtNama_pelanggan.Text
        Dim alamat As String = txtAlamat.Text
        Dim telepon As String = txtTelepon.Text

        Dim postData As String = $"kode_pelanggan={kode_pelanggan}&nama_pelanggan={nama_pelanggan}&alamat={alamat}&telepon={telepon}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pelanggan_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_pelanggan As String = txtKode_pelanggan.Text
        Dim nama_pelanggan As String = txtNama_pelanggan.Text
        Dim alamat As String = txtAlamat.Text
        Dim telepon As String = txtTelepon.Text

        Dim postData As String = $"kode_pelanggan={kode_pelanggan}&nama_pelanggan={nama_pelanggan}&alamat={alamat}&telepon={telepon}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pelanggan_api & "?kode_pelanggan=" & txtKode_pelanggan.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kode_pelanggan As String = txtKode_pelanggan.Text
        Dim nama_pelanggan As String = txtNama_pelanggan.Text
        Dim alamat As String = txtAlamat.Text
        Dim telepon As String = txtTelepon.Text

        Dim postData As String = $"kode_pelanggan={kode_pelanggan}&nama_pelanggan={nama_pelanggan}&alamat={alamat}&telepon={telepon}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pelanggan_api & "?kode_pelanggan=" & txtKode_pelanggan.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(pelanggan_api & "?kode_pelanggan=" & txtKode_pelanggan.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pelanggan_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pelanggan_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pelanggan_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Pelanggan) = JsonConvert.DeserializeObject(Of List(Of Pelanggan))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Pelanggan In data
                            txtKode_pelanggan.Text = mydata.kode_pelanggan
                            txtNama_pelanggan.Text = mydata.nama_pelanggan
                            txtAlamat.Text = mydata.alamat
                            txtTelepon.Text = mydata.telepon
                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtKode_pelanggan.Clear()
        txtNama_pelanggan.Clear()
        txtAlamat.Clear()
        txtTelepon.Clear()
        Reloaded()
        txtKode_pelanggan.Focus()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (pelanggan_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (pelanggan_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pelanggan_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Pelanggan) = JsonConvert.DeserializeObject(Of List(Of Pelanggan))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtKode_pelanggan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode_pelanggan.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub txttelepon_TextChanged(sender As Object, e As EventArgs) Handles txtTelepon.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtNama_pelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtNama_pelanggan.TextChanged

    End Sub

    Private Sub txtKode_pelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtKode_pelanggan.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
