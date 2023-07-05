Public Class Form1

    Sub Terkunci()
<<<<<<< HEAD
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        WahanaToolStripMenuItem.Enabled = False
        KasirToolStripMenuItem.Enabled = False
        PemasukanToolStripMenuItem.Enabled = False
        PengeluaranToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        KatalogToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Terkunci()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
=======
        'LoginToolStripMenuItem.Enabled = True
        'LogoutToolStripMenuItem.Enabled = False
        'WahanaToolStripMenuItem.Enabled = False
        'TiketToolStripMenuItem.Enabled = False
        'TransaksiToolStripMenuItem.Enabled = False
        'PengeluaranToolStripMenuItem.Enabled = False
        'LaporanToolStripMenuItem.Enabled = False

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub WahanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WahanaToolStripMenuItem.Click
        FormWahana.TopLevel = False
        Panel1.Controls.Add(FormWahana)
        FormWahana.Show()
    End Sub

    Private Sub TiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiketToolStripMenuItem.Click
        FormTiket.TopLevel = False
        Panel1.Controls.Add(FormTiket)
        FormTiket.Show()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click
        FormKasir.TopLevel = False
        Panel1.Controls.Add(FormKasir)
        FormKasir.Show()
    End Sub

    Private Sub PengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemasukanToolStripMenuItem.Click
        FormPemasukan.TopLevel = False
        Panel1.Controls.Add(FormPemasukan)
        FormPemasukan.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranToolStripMenuItem.Click
        FormLaporan.TopLevel = False
        Panel1.Controls.Add(FormLaporan)
        FormLaporan.Show()
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
    End Sub
End Class
