Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public cmd As SqlCommand
    Public Ds As DataSet

    Public MyDB As String

    Public Sub Koneksi()
<<<<<<< HEAD
        MyDB = "Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia"
        conn = New SqlConnection(MyDB)
=======
        MyDB = "Data Source=ARAA; initial catalog= SI_Wisata_Celosia;integrated security=true"
        conn = New SqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
    End Sub
End Module
