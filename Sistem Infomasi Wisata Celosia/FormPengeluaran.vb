Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FormPengeluaran
    Dim conn As SqlConnection = New SqlConnection("Data Source=ARAA; " & "user id = sa; password=123456; 
Integrated Security=True; " & "database=Wisata_Celosia")
    Dim ADP As SqlDataAdapter
    Dim Ds As New DataSet
    Private cmdDelete As Object

    Sub ViewTable()
        ADP = New SqlDataAdapter("Select * From pengeluaran", conn)
        Ds = New DataSet
        ADP.Fill(Ds, "DataPengeluaran")
        DgvPengeluaran.DataSource = Ds.Tables("DataPengeluaran")
    End Sub

    Private Sub FormPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewTable()

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        'define insert statement
        Dim sqlins As String = "insert into pengeluaran (id_pengeluaran, tanggal, pengeluaran, jumlah, keterangan) " &
            "values(@id_pengeluaran, @tanggal, @pengeluaran, @jumlah, @keterangan) "

        'Create connection to SI_Wahana_Celosia database
        Try
            'Open connection
            conn.Open()
            MsgBox("Data Berhasil Disimpan")
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@id_pengeluaran", TxtIdPengeluaran.Text)
            cmdInsert.Parameters.AddWithValue("@tanggal", TxtTanggal.Text)
            cmdInsert.Parameters.AddWithValue("@pengeluaran", TxtPengeluaran.Text)
            cmdInsert.Parameters.AddWithValue("@jumlah", TxtJumlah.Text)
            cmdInsert.Parameters.AddWithValue("@keterangan", TxtKeterangan.Text)
            cmdInsert.ExecuteNonQuery()
            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            ' Close connection
            conn.Close()
            Clear()
            ' MsgBox("Connection closed.")
        End Try
    End Sub

    Private Sub Clear()
        TxtIdPengeluaran.Clear()
        TxtPengeluaran.Clear()
        TxtJumlah.Clear()
        TxtKeterangan.Clear()
        TxtTanggal.Clear()

    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim sqlins As String = "DELETE pengeluaran WHERE id_pengeluaran=@id_pengeluaran"

        Try
            conn.Open()
            Dim cmdDelete As SqlCommand = New SqlCommand(sqlins, conn)
            cmdDelete.Parameters.AddWithValue("@id_pengeluaran", Me.TxtIdPengeluaran.Text)
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.ExecuteNonQuery()

            TxtIdPengeluaran.Clear()

            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
            MsgBox("Data Dihapus!")
        End Try
    End Sub
End Class