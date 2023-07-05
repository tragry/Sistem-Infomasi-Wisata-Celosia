<<<<<<< HEAD
﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FormWahana
    Dim Conn As SqlConnection = New SqlConnection("Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Dim Da As SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim Rd As SqlDataReader

    Private Sub FormWahana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewTable()
    End Sub

    Sub ViewTable()
        Da = New SqlClient.SqlDataAdapter("Select * From wahana_c", Conn)
        DS = New DataSet
        Da.Fill(DS, "DataWahana")
        DGVWahana.AllowUserToAddRows = False
        DGVWahana.DataSource = DS.Tables("DataWahana")

        'DGVWahana.RowTemplate.Height = 1000
        'Dim imgc As New DataGridViewImageColumn
        'imgc = DGVWahana.Columns(4)
        'imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim simpan As String = "insert into wahana_c (id_wahana, nama_wahana, harga, keterangan, gambar)" &
            "values (@id_wahana, @nama_wahana, @harga, @keterangan, @gambar)"
        Try
            Conn.Open()
            MsgBox("Data Wahana Berhasil Ditambahkan!")
            Dim cmdInsert As SqlCommand = New SqlCommand(simpan, Conn)
            cmdInsert.Parameters.AddWithValue("@id_wahana", TxtId.Text)
            cmdInsert.Parameters.AddWithValue("@nama_wahana", TxtNamaWahana.Text)
            cmdInsert.Parameters.AddWithValue("@harga", TxtHarga.Text)
            cmdInsert.Parameters.AddWithValue("@keterangan", TxtKeterangan.Text)

            Dim MemoryStream As New MemoryStream
            pic_gambar.BackgroundImage.Save(MemoryStream,
            pic_gambar.BackgroundImage.RawFormat)
            Dim Dgambar As Byte() = MemoryStream.GetBuffer
            Dim Images As New SqlParameter("@gambar", SqlDbType.Image)
            Images.Value = Dgambar
            cmdInsert.Parameters.Add(Images)
            MsgBox("Gambar Berhasil Disimpan")

            TxtId.Clear()
            TxtNamaWahana.Clear()
            TxtHarga.Clear()
            TxtKeterangan.Clear()
            pic_gambar.Image = Nothing

            cmdInsert.ExecuteNonQuery()
            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        If OpenFileDialog1.ShowDialog() =
        Windows.Forms.DialogResult.OK Then
            pic_gambar.BackgroundImage =
            Image.FromFile(OpenFileDialog1.FileName)
            pic_gambar.BackgroundImageLayout =
            ImageLayout.Zoom
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim EditData As String = "update wahana_c set nama_wahana= '" & TxtNamaWahana.Text & "', 
                keterangan='" & TxtKeterangan.Text & "', harga='" & TxtHarga.Text & "' where id_wahana='" & TxtId.Text & "' "
        Try
            Conn.Open()
            Dim cmd As SqlCommand = New SqlCommand(EditData, Conn)
            cmd = New SqlCommand(EditData, Conn)
            cmd.ExecuteNonQuery()
            ViewTable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conn.Close()
            MsgBox("Data Berhasil Update")
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim sqlins As String = "DELETE from wahana_c WHERE id_wahana=@id_wahana"

        Try
            Conn.Open()
            Dim cmdDelete As SqlCommand = New SqlCommand(sqlins, Conn)
            cmdDelete.Parameters.AddWithValue("@id_wahana", Me.TxtId.Text)
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.ExecuteNonQuery()

            TxtId.Clear()

            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conn.Close()
            MsgBox("Data Dihapus!")
        End Try
    End Sub
=======
﻿Public Class FormWahana
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca

End Class