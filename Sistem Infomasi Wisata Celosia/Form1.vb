Public Class Form1

    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        WahanaToolStripMenuItem.Enabled = False
        KasirToolStripMenuItem.Enabled = False
        PemasukanToolStripMenuItem.Enabled = False
        PengeluaranToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub

    Sub Terbuka()
        LoginToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = True
        WahanaToolStripMenuItem.Enabled = True
        KasirToolStripMenuItem.Enabled = True
        PemasukanToolStripMenuItem.Enabled = True
        PengeluaranToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
    End Sub

    Sub sembunyi()
        FormWahana.Hide()
        FormKasir.Hide()
        FormPemasukan.Hide()
        FormPengeluaran.Hide()
        FormLaporan.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Terkunci()
    End Sub

    Private Sub WahanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WahanaToolStripMenuItem.Click
        sembunyi()
        FormWahana.TopLevel = False
        Panel1.Controls.Add(FormWahana)
        FormWahana.Show()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click
        sembunyi()
        FormKasir.TopLevel = False
        Panel1.Controls.Add(FormKasir)
        FormKasir.Show()
    End Sub

    Private Sub PemasukanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemasukanToolStripMenuItem.Click
        sembunyi()
        FormPemasukan.TopLevel = False
        Panel1.Controls.Add(FormPemasukan)
        FormPemasukan.Show()
    End Sub

    Private Sub PengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranToolStripMenuItem.Click
        sembunyi()
        FormPengeluaran.TopLevel = False
        Panel1.Controls.Add(FormPengeluaran)
        FormPengeluaran.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        sembunyi()
        FormLaporan.TopLevel = False
        Panel1.Controls.Add(FormLaporan)
        FormLaporan.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Terbuka() ' Panggil metode Terbuka untuk mengaktifkan item menu
        sembunyi() ' Sembunyikan semua form yang sedang ditampilkan
        FormLogin.Show()
    End Sub

    Private Sub CobamenuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        sembunyi()
        FormPemasukan.TopLevel = False
        Panel1.Controls.Add(FormPemasukan)
        FormPemasukan.Show()
    End Sub

End Class
