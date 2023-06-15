Public Class FormKasir
    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Lbl_TanggalWaktu.Caption = Format(Of Date, "dd mmmm yyyy")()
        'jam.Caption = Time
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click
        Bayar.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.Enabled = True
        '' DateTimePicker1.Interval = 300
    End Sub
End Class