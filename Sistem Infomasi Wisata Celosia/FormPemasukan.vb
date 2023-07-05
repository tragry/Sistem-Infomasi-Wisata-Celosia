<<<<<<< HEAD
﻿Imports System.Data.SqlClient

Public Class FormPemasukan
    Dim Conn As SqlConnection
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub FormPemasukan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New SqlConnection("Data Source=ARAA; user id=sa; password=123456; Integrated Security=True; database=Wisata_Celosia")
        ViewTable()
    End Sub

    Sub ViewTable()
        Dim query As String = "SELECT id_struk, tgl_trans, SUM(total) AS total FROM transaksi GROUP BY id_struk, tgl_trans"

        Try
            Conn.Open()
            ADP = New SqlDataAdapter(query, Conn)
            DS = New DataSet
            ADP.Fill(DS, "DataPemasukan")

            ' Tambahkan kolom "No" pada DataTable
            Dim dataTable As DataTable = DS.Tables("DataPemasukan")
            dataTable.Columns.Add("No", GetType(Integer))

            ' Tentukan posisi kolom "No" sebelum kolom "id_struk"
            dataTable.Columns("No").SetOrdinal(dataTable.Columns("id_struk").Ordinal)

            ' Isi nomor urut pada kolom "No"
            For i As Integer = 0 To dataTable.Rows.Count - 1
                dataTable.Rows(i)("No") = i + 1
            Next

            DGVPemasukan.DataSource = dataTable

            ' Set judul kolom
            DGVPemasukan.Columns("No").HeaderText = "No"
            DGVPemasukan.Columns("id_struk").HeaderText = "ID Struk"
            DGVPemasukan.Columns("tgl_trans").HeaderText = "Tanggal"
            DGVPemasukan.Columns("total").HeaderText = "Total"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
=======
﻿Public Class FormPemasukan

End Class
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
