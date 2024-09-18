Imports System.Net.Http
Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json

Public Class frmLogin

    Private users As List(Of Dictionary(Of String, String))

    'Public Sub New(users As List(Of Dictionary(Of String, String)))
    '    InitializeComponent()
    '    Me.users = users
    'End Sub
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim userData As New Dictionary(Of String, String) From {
            {"username", username},
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
            Dim response As HttpResponseMessage = Await client.PostAsync("api/login", content)

            Dim responseString As String = Await response.Content.ReadAsStringAsync()


            If response.IsSuccessStatusCode Then
                Dim apiResponse As ApiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseString)

                Dim token As String = apiResponse.data.token
                MessageBox.Show(apiResponse.message)

                Dim productForm As New frmChecklist(token)
                productForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login gagal: " & response.StatusCode.ToString())
            End If
            txtPassword.Clear()
            txtUsername.Clear()
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class