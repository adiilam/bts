Imports System.Net.Http
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json
Public Class frmRegister

    Private users As New List(Of Dictionary(Of String, String))()
    Private Async Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        ' Validasi input
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Semua field harus diisi!")
            Return
        End If

        ' Membuat objek dictionary untuk data yang akan dikirim
        Dim userData As New Dictionary(Of String, String) From {
            {"username", username},
            {"email", email},
            {"password", password}
        }

        ' Konversi objek menjadi JSON
        Dim jsonData As String = JsonConvert.SerializeObject(userData)

        ' Mengirim data ke API menggunakan HttpClient
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://94.74.86.174:8080/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

            ' Membuat request content dengan JSON
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

            ' Kirim POST request ke API
            Dim response As HttpResponseMessage = Await client.PostAsync("api/register", content)

            ' Periksa apakah respons sukses
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Registrasi berhasil")
                txtEmail.Clear()
                txtPassword.Clear()
                txtUsername.Clear()

                Dim loginform As New frmLogin
                loginform.Show()
                Me.Hide()
                loginform = Nothing
            Else
                MessageBox.Show("Registrasi gagal: " & response.StatusCode.ToString())
            End If

            'users.Add(userData)

            'If response.IsSuccessStatusCode Then

            'End If
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class