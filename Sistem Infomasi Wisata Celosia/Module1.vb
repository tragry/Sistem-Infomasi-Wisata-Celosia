Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public cmd As SqlCommand
    Public Ds As DataSet

    Public MyDB As String

    Public Sub Koneksi()
        MyDB = "Data Source=ARAA; initial catalog= SI_Wisata_Celosia;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
