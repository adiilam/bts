Imports Newtonsoft.Json
Imports System.Net.Http

Public Class frmChecklist
    Private userToken As String

    Public Sub New(token As String)
        InitializeComponent()
        Me.userToken = token
        LoadProducts()
    End Sub

    Private Async Sub LoadProducts()
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://94.74.86.174:8080/")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", userToken)

            Dim response As HttpResponseMessage = Await client.GetAsync("api/checklist")

            Dim responseString As String = Await response.Content.ReadAsStringAsync()

            If response.IsSuccessStatusCode Then
                ' Uraikan JSON ke list produk
                Dim responsData As ResponseData = JsonConvert.DeserializeObject(Of ResponseData)(responseString)

                ' Tampilkan produk di DataGridView atau ListBox
                If responsData.data IsNot Nothing Then
                    dgvProducts.DataSource = responsData.data ' Misalnya menggunakan DataGridView
                End If ' Misalnya menggunakan DataGridView
            Else
                MessageBox.Show("Gagal memuat data produk: " & response.StatusCode.ToString())
            End If
        End Using
    End Sub

End Class

