Public Class FormLogin
    ' Simpan informasi pengguna dalam kamus
    Private users As New Dictionary(Of String, String)()

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Tambahkan pengguna ke kamus
        users.Add("admin", "admin")
        users.Add("user", "user")

        ' Periksa apakah pengguna yang dimasukkan valid
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        If users.ContainsKey(username) AndAlso users(username) = password Then
            ' Jika pengguna valid
            If username = "admin" Then
                ' Jika pengguna adalah "admin", tampilkan FormWahana
                Dim formWahana As New FormWahana()
                FormAdmin.Show()
                Form1.Hide()
            ElseIf username = "user" Then
                ' Jika pengguna adalah "user", tampilkan FormTiket
                'Dim formTiket As New FormTiket()
                'formTiket.Show()
                ' Modifikasi: Tampilkan Form NewKatalog
                Dim newKatalog As New new_katalog()
                newKatalog.Show()
                Form1.Hide()
            Else
                ' Jika pengguna bukan "admin" atau "user", tampilkan Form1
                Dim form1 As New Form1()
                form1.Show()
            End If

            Me.Close()
        Else
            ' Jika pengguna tidak valid, tampilkan pesan kesalahan
            MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kode yang ingin Anda tambahkan saat FormLogin dimuat
    End Sub
End Class
