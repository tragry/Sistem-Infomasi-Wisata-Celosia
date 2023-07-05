Public Class Bayar

<<<<<<< HEAD
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim totalBayar As Integer = Integer.Parse(FormKasir.LbTotalBayar.Text)
        Dim nominal As Integer = Integer.Parse(TxtNominal.Text)

        Dim kembalian As Integer = nominal - totalBayar

        ' Menampilkan kembalian
        MessageBox.Show("Kembalian: " & kembalian.ToString())

        ' Menutup form Bayar
        Me.Close()
        'FormPemasukan.Show()

        ' Set DialogResult form "Bayar" menjadi OK
        Me.DialogResult = DialogResult.OK

    End Sub

End Class
=======
End Class
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
