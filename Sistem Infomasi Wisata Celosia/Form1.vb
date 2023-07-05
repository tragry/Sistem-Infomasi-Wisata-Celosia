Public Class Form1

    Sub Terkunci()
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
    End Sub
End Class
