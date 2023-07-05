Public Class FormAdmin

    Sub sembunyi()
        FormWahana.Hide()
        FormKasir.Hide()
        FormPemasukan.Hide()
        FormPengeluaran.Hide()
        FormLaporanPenjualan.Hide()
        Form_LaporanPengeluaran.Hide()
    End Sub

    Private Sub WahanaTSM_Click(sender As Object, e As EventArgs) Handles WahanaTSM.Click
        sembunyi()
        FormWahana.TopLevel = False
        Panel1.Controls.Add(FormWahana)
        FormWahana.Show()
    End Sub

    Private Sub PemasukanTSM_Click(sender As Object, e As EventArgs) Handles PemasukanTSM.Click
        sembunyi()
        FormPemasukan.TopLevel = False
        Panel1.Controls.Add(FormPemasukan)
        FormPemasukan.Show()
    End Sub

    Private Sub PengeluaranTSM_Click(sender As Object, e As EventArgs) Handles PengeluaranTSM.Click
        sembunyi()
        FormPengeluaran.TopLevel = False
        Panel1.Controls.Add(FormPengeluaran)
        FormPengeluaran.Show()
    End Sub

    Private Sub LaporanTSM_Click(sender As Object, e As EventArgs) Handles LaporanTSM.Click
        sembunyi()
        FormLaporanPenjualan.TopLevel = False
        Panel1.Controls.Add(FormLaporanPenjualan)
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub LogoutTSM_Click(sender As Object, e As EventArgs) Handles LogoutTSM.Click
        Form1.Show()
    End Sub

    Private Sub KeluarTSM_Click(sender As Object, e As EventArgs) Handles KeluarTSM.Click
        Me.Close()
    End Sub

    Private Sub KasirTSM_Click(sender As Object, e As EventArgs) Handles KasirTSM.Click
        sembunyi()
        FormKasir.TopLevel = False
        Panel1.Controls.Add(FormKasir)
        FormKasir.Show()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        sembunyi()
        FormLaporanPenjualan.TopLevel = False
        Panel1.Controls.Add(FormLaporanPenjualan)
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub LaporanPengeluaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPengeluaranToolStripMenuItem.Click
        sembunyi()
        Form_LaporanPengeluaran.TopLevel = False
        Panel1.Controls.Add(Form_LaporanPengeluaran)
        Form_LaporanPengeluaran.Show()
    End Sub


    Public Sub BukaFormPemasukan()
        Dim formPemasukan As New FormPemasukan()
        formPemasukan.TopLevel = False
        formPemasukan.FormBorderStyle = FormBorderStyle.None
        formPemasukan.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(formPemasukan)
        formPemasukan.Show()
    End Sub
End Class