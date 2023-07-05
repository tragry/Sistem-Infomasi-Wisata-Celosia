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
        End If

        reader.Close()
        Conn.Close()

        LoadDataById("W0002")
    End Sub

    Private Sub LoadDataById(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label8.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox2.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label5.Text = keterangan
            Label7.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById2("W0003")
    End Sub

    Private Sub LoadDataById2(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label12.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox3.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label9.Text = keterangan
            Label11.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById3("W0004")
    End Sub

    Private Sub LoadDataById3(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label24.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox6.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label21.Text = keterangan
            Label23.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById4("W0005")
    End Sub

    Private Sub LoadDataById4(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label17.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox5.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label18.Text = keterangan
            Label20.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById6("W0006")
    End Sub

    Private Sub LoadDataById6(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label61.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox15.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label58.Text = keterangan
            Label60.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById7("W0007")
    End Sub

    Private Sub LoadDataById7(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label49.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox12.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label46.Text = keterangan
            Label48.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById8("W0008")
    End Sub

    Private Sub LoadDataById8(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label42.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox11.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label43.Text = keterangan
            Label45.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById9("W0009")
    End Sub

    Private Sub LoadDataById9(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label38.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox10.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label39.Text = keterangan
            Label41.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById10("W0010")
    End Sub

    Private Sub LoadDataById10(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label13.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox4.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label14.Text = keterangan
            Label16.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById11("W0011")
    End Sub

    Private Sub LoadDataById11(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label37.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox9.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label34.Text = keterangan
            Label36.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById12("W0012")
    End Sub

    Private Sub LoadDataById12(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label30.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox8.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label31.Text = keterangan
            Label33.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById13("W0013")
    End Sub

    Private Sub LoadDataById13(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label26.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox7.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label27.Text = keterangan
            Label29.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById14("W0014")
    End Sub

    Private Sub LoadDataById14(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label73.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox18.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label70.Text = keterangan
            Label72.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById15("W0015")
    End Sub

    Private Sub LoadDataById15(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label66.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox17.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label67.Text = keterangan
            Label69.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById16("W0016")
    End Sub

    Private Sub LoadDataById16(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label62.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox16.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label63.Text = keterangan
            Label65.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById17("W0017")
    End Sub

    Private Sub LoadDataById17(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label54.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox14.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label55.Text = keterangan
            Label57.Text = harga
        End If

        reader.Close()
        Conn.Close()

        LoadDataById18("W0018")
    End Sub

    Private Sub LoadDataById18(ByVal id_wahana As String)
        ' Membuka koneksi ke database
        Conn.Open()

        ' Query untuk mengambil data dari database berdasarkan id_wahana
        Dim query As String = "SELECT nama_wahana, harga, keterangan, gambar FROM wahana_c WHERE id_wahana = @id_wahana"
        Dim command As New SqlCommand(query, Conn)
        command.Parameters.AddWithValue("@id_wahana", id_wahana)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            ' Mengambil nilai dari kolom database dan mengisinya ke komponen UI
            Label50.Text = reader("nama_wahana").ToString()
            Dim imageBytes As Byte() = DirectCast(reader("gambar"), Byte())

            ' Memuat gambar dari byte array
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Try
                    Using stream As New MemoryStream(imageBytes)
                        PictureBox13.Image = Image.FromStream(stream)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Data gambar kosong atau tidak valid.")
            End If

            ' Mengambil nilai keterangan dan harga dari database
            Dim keterangan As String = reader("keterangan").ToString()
            Dim harga As String = reader("harga").ToString()

            ' Menampilkan nilai keterangan dan harga pada label
            Label51.Text = keterangan
            Label53.Text = harga
        End If

        reader.Close()
        Conn.Close()
    End Sub

    Private Sub BtnBeli_Click(sender As Object, e As EventArgs) Handles BtnBeli.Click
        FormAdmin.Show()
        Me.Close()
    End Sub
End Class
