Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public cmd As SqlCommand
    Public Ds As DataSet

    Public MyDB As String

    Public Sub Koneksi()
        MyDB = "Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia"
        conn = New SqlConnection(MyDB)
    End Sub
End Module
