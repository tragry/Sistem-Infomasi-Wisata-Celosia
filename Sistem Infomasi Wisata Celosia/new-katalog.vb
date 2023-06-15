Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class new_katalog
    Dim Conn As SqlConnection = New SqlConnection("Data Source=ARAA;user id=sa;password=123456;Integrated Security=True;database=Wisata_Celosia")

    Private Sub new_katalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana='W0001'"
        Dim command As New SqlCommand(query, Conn)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label1.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox1.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            Label2.Text = keterangan
            Label3.Text = harga

            ' Mengatur tata letak dengan menggunakan TableLayoutPanel
            'TableLayoutPanel1.Controls.Clear()
            'TableLayoutPanel1.RowStyles.Clear()

            ' Tambahkan Label keterangan
            Dim labelKeterangan As New Label()
            labelKeterangan.AutoSize = True
            labelKeterangan.Text = keterangan
            'TableLayoutPanel1.Controls.Add(labelKeterangan, 0, 0)

            ' Tambahkan Label harga
            Dim labelHarga As New Label()
            labelHarga.AutoSize = True
            labelHarga.Text = "Harga: " & harga
            'TableLayoutPanel1.Controls.Add(labelHarga, 0, 1)

            ' Atur tata letak keterangan dan harga
            ' TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            'TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            'TableLayoutPanel1.SetCellPosition(labelKeterangan, New TableLayoutPanelCellPosition(0, 0))
            'TableLayoutPanel1.SetCellPosition(labelHarga, New TableLayoutPanelCellPosition(0, 1))
        End If

        reader.Close()
        Conn.Close()
    End Sub

End Class
