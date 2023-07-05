Imports System.Data.SqlClient

Public Class FormKasir

    Dim Conn As SqlConnection = New SqlConnection("Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Dim Da As SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim Rd As SqlDataReader

    Dim formPemasukan As FormPemasukan

    Private Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim ADP As New SqlDataAdapter(Source, Conn)
            Dim DT As New DataTable

            ADP.Fill(DT)
            SQLTable = DT
        Catch ex As Exception
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try

    End Function

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles CmbNamaWahana.DropDown
        CmbNamaWahana.Items.Clear()
        Dim DR As DataRow
        For Each DR In SQLTable("select nama_wahana from wahana_c order by nama_wahana").Rows
            CmbNamaWahana.Items.Add(DR("nama_wahana"))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNamaWahana.SelectedIndexChanged
        If CmbNamaWahana.Text = "Kora-Kora" Then
            TxtKodeWahana.Text = "W0001"
            TxtHarga.Text = 15000
        ElseIf CmbNamaWahana.Text = "Scooter Listrik" Then
            TxtKodeWahana.Text = "W0002"
            TxtHarga.Text = 25000
        ElseIf CmbNamaWahana.Text = "Camera Spin 360" Then
            TxtKodeWahana.Text = "W0003"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Trampolin" Then
            TxtKodeWahana.Text = "W0004"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Ontang Anting" Then
            TxtKodeWahana.Text = "W0005"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Komedi Putar Balon" Then
            TxtKodeWahana.Text = "W0006"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "ATV" Then
            TxtKodeWahana.Text = "W0007"
            TxtHarga.Text = 25000
        ElseIf CmbNamaWahana.Text = "Mini Trail" Then
            TxtKodeWahana.Text = "W0008"
            TxtHarga.Text = 25000
        ElseIf CmbNamaWahana.Text = "Taman Kelinci" Then
            TxtKodeWahana.Text = "W0009"
            TxtHarga.Text = 15000
        ElseIf CmbNamaWahana.Text = "Flying Fox" Then
            TxtKodeWahana.Text = "W0010"
            TxtHarga.Text = 15000
        ElseIf CmbNamaWahana.Text = "Kolam Renang" Then
            TxtKodeWahana.Text = "W0011"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Kuda Putar" Then
            TxtKodeWahana.Text = "W0012"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Bianglala" Then
            TxtKodeWahana.Text = "W0013"
            TxtHarga.Text = 15000
        ElseIf CmbNamaWahana.Text = "Riding Dino" Then
            TxtKodeWahana.Text = "W0014"
            TxtHarga.Text = 30000
        ElseIf CmbNamaWahana.Text = "Istana Balon" Then
            TxtKodeWahana.Text = "W0015"
            TxtHarga.Text = 15000
        ElseIf CmbNamaWahana.Text = "Rainbow Slide" Then
            TxtKodeWahana.Text = "W0016"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Mobil Buggy" Then
            TxtKodeWahana.Text = "W0017"
            TxtHarga.Text = 20000
        ElseIf CmbNamaWahana.Text = "Lorong Tanpa Batas" Then
            TxtKodeWahana.Text = "W0018"
            TxtHarga.Text = 10000
        End If
    End Sub

    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged
        Dim Nilai As Integer
        If Val(TxtJumlah.Text) <> 0 Then
            Nilai = Int(TxtJumlah.Text)
            TxtJumlah.Text = Nilai
        End If
    End Sub

    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        LbTotal.Text = TxtHarga.Text * TxtJumlah.Text
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim Tambah As String = "insert into transaksi (id_struk, tgl_trans, nama_wahana, jumlah, total)" &
            "values (@id_struk,@tgl_trans, @nama_wahana, @jumlah, @total)"
        Try
            Conn.Open()
            MsgBox("Pesanan Berhasil Ditambahkan!")
            Dim cmdInsert As SqlCommand = New SqlCommand(Tambah, Conn)
            cmdInsert.Parameters.AddWithValue("@id_struk", lbl_idstruk.Text)
            cmdInsert.Parameters.AddWithValue("@tgl_trans", LbTgl.Text)
            cmdInsert.Parameters.AddWithValue("@nama_wahana", CmbNamaWahana.SelectedItem.ToString())
            cmdInsert.Parameters.AddWithValue("@jumlah", TxtJumlah.Text)
            cmdInsert.Parameters.AddWithValue("@total", LbTotal.Text)
            cmdInsert.ExecuteNonQuery()
            ViewTable()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conn.Close()
            Clear()
        End Try

        UpdateTotalBayar()
    End Sub

    Sub Clear()
        TxtHarga.Clear()
        TxtJumlah.Clear()
        TxtKodeWahana.Clear()
    End Sub

    Sub idstruk_otomatis()
        Dim urutan As String
        Dim hitung As Long
        Conn.Open()
        Cmd = New SqlCommand("SELECT MAX(id_struk) FROM transaksi", Conn)
        Dim maxIdStruk As Object = Cmd.ExecuteScalar()
        Conn.Close()

        If maxIdStruk Is DBNull.Value Then
            urutan = "00001"
        Else
            hitung = CLng(maxIdStruk) + 1
            urutan = hitung.ToString("00000")
        End If

        lbl_idstruk.Text = urutan
    End Sub

    Private Sub UpdateTotalBayar()
        Dim totalBayar As Integer = 0

        For Each row As DataGridViewRow In DGVTransaksi.Rows
            totalBayar += Convert.ToInt32(row.Cells("total").Value)
        Next

        LbTotalBayar.Text = totalBayar.ToString()
    End Sub

    Private Sub DGVTransaksi_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGVTransaksi.RowsRemoved
        ' Memanggil fungsi untuk mengupdate total bayar setelah menghapus transaksi
        UpdateTotalBayar()
    End Sub

    Sub ViewTable()
        Da = New SqlClient.SqlDataAdapter("Select * From transaksi", Conn)
        DS = New DataSet
        Da.Fill(DS, "DataTransaksi")

        ' Menerapkan filter menggunakan DataView
        Dim dv As New DataView(DS.Tables("DataTransaksi"))
        Dim idStruk As String = lbl_idstruk.Text
        dv.RowFilter = "id_struk = '" & idStruk & "'"

        DGVTransaksi.AllowUserToAddRows = False
        DGVTransaksi.DataSource = dv
        DGVTransaksi.Visible = True
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbTgl.Text = Today.ToString("yyyy-MM-dd")
        Call idstruk_otomatis()

        UpdateTotalBayar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bayar.ShowDialog()

        ' Cek apakah form "Bayar" ditutup dengan mengklik tombol "BtnOk"
        If Bayar.DialogResult = DialogResult.OK Then
            ' Hapus semua data dari DataTable yang digunakan oleh DataGridView
            DS.Tables("DataTransaksi").Rows.Clear()
            ' Tampilkan pesan atau lakukan tindakan lain setelah menghapus data
            MessageBox.Show("Data transaksi berhasil dihapus.")

            'formPemasukan.Show()
            Dim formAdmin As FormAdmin = CType(Application.OpenForms("FormAdmin"), FormAdmin)
            If formAdmin IsNot Nothing Then
                formAdmin.BukaFormPemasukan()
            End If
        End If
    End Sub


End Class