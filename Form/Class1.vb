
' Kelas model untuk data token
Public Class ResponseData
    Public Property token As String
    Public Property data As List(Of Product)
End Class

' Kelas model untuk response JSON
Public Class ApiResponse
    Public Property statusCode As Integer
    Public Property message As String
    Public Property errorMessage As String
    Public Property data As ResponseData
End Class

Public Class Product
    Public Property id As Integer
    Public Property name As String
    Public Property items As String
    Public Property checklistCompletionStatus As Boolean
End Class