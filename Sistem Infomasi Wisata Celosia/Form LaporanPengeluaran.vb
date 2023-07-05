Imports System.Data
Imports System.Data.SqlClient
Public Class Form_LaporanPengeluaran
    Dim hari, bln, thn As String
    Dim nobln, status As String

    Dim Conn As SqlConnection = New SqlConnection("Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Dim Da As SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim Rd As SqlDataReader

    Dim dt_pengeluaran As New DataTable
    Private Sub Form_LaporanPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildataluar()
    End Sub
    Sub tampildataluar()
        Dim i As Integer
        For i = 2021 To Year(Now)
            cbothnluar.Items.Add(i)
        Next
        cboblnluar.Items.Clear()
        'cboblnluar.Items.Add("")
        cboblnluar.Items.Add("Januari")
        cboblnluar.Items.Add("Februari")
        cboblnluar.Items.Add("Maret")
        cboblnluar.Items.Add("April")
        cboblnluar.Items.Add("Mei")
        cboblnluar.Items.Add("Juni")
        cboblnluar.Items.Add("Juli")
        cboblnluar.Items.Add("Agustus")
        cboblnluar.Items.Add("September")
        cboblnluar.Items.Add("Oktober")
        cboblnluar.Items.Add("November")
        cboblnluar.Items.Add("Desember")

    End Sub
    Sub tampilsemualuar()
        Dim objCmd As New SqlCommand

        dt_pengeluaran.Clear()

        Dim ctktgl As String = "SELECT * FROM pengeluaran ORDER BY tanggal"

        objCmd.Connection = Conn
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = ctktgl

        Da = New SqlDataAdapter(objCmd)
        Da.Fill(dt_pengeluaran)
        DGVCetakPengeluaran.DataSource = dt_pengeluaran
    End Sub


    Sub tampilblnthn()
        If cboblnluar.Text = "" And cbothnluar.Text = "" Then
            MsgBox("Pilih bulan atau tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cboblnluar.Text <> "" And cbothnluar.Text = "" Then
            MsgBox("Pilih tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cboblnluar.Text = "" And cbothnluar.Text <> "" Then
            MsgBox("Pilih tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim objCmd As New SqlCommand
        dt_pengeluaran.Clear()

        If cboblnluar.Text <> "" And cbothnluar.Text <> "" Then
            Dim nobln As Integer = cboblnluar.SelectedIndex + 1
            Dim thn As Integer = CInt(cbothnluar.Text)
            Dim ctktgl As String = "SELECT * FROM pengeluaran WHERE MONTH(tanggal) = @nobln AND YEAR(tanggal) = @thn ORDER BY tanggal"

            objCmd.Connection = Conn
            objCmd.CommandType = CommandType.Text
            objCmd.CommandText = ctktgl
            objCmd.Parameters.AddWithValue("@nobln", nobln)
            objCmd.Parameters.AddWithValue("@thn", thn)

            Da = New SqlDataAdapter(objCmd)
            Da.Fill(dt_pengeluaran)
            DGVCetakPengeluaran.DataSource = dt_pengeluaran
        End If
    End Sub

    Sub tampilharianluar()
        Dim objCmd As New SqlCommand

        dt_pengeluaran.Clear()

        Dim tgl As String = Format(dtp1luar.Value, "yyyy-MM-dd")
        Dim ctktgl As String = "SELECT * FROM pengeluaran WHERE CAST(tanggal AS DATE) = @tgl ORDER BY tanggal"

        objCmd.Connection = Conn
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = ctktgl
        objCmd.Parameters.AddWithValue("@tgl", tgl)

        Da = New SqlDataAdapter(objCmd)
        Da.Fill(dt_pengeluaran)
        DGVCetakPengeluaran.DataSource = dt_pengeluaran
    End Sub

    Sub cetaktglpengeluaran()
        'Dim crpt As New ReportDocument

        nobln = cboblnluar.SelectedIndex + 1
        thn = cbothnluar.Text

        If cboblnluar.Text = "" And cbothnluar.Text = "" Then
            MsgBox("Pilih bulan atau tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cboblnluar.Text <> "" And cbothnluar.Text = "" Then
            MsgBox("Pilih tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cboblnluar.Text = "" And cbothnluar.Text <> "" Then
            MsgBox("Pilih bulan terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim ctktgl As String = ""
        If cboblnluar.Text <> "" And cbothnluar.Text <> "" Then
            ctktgl = "SELECT * FROM transaksi WHERE MONTH(tgl_trans) = @nobln AND YEAR(tgl_trans) = @thn ORDER BY tgl_trans"
        End If

        Conn.Open()
        Cmd = New SqlCommand(ctktgl, Conn)
        Cmd.Parameters.AddWithValue("@nobln", nobln)
        Cmd.Parameters.AddWithValue("@thn", thn)
        Rd = Cmd.ExecuteReader
        Dim jml As Integer = 0

        If Rd.HasRows Then
            'crpt.Load(Application.StartupPath & "\LaporanPenjualan.rpt")
            'crpt.SetDataSource(dt_pengeluaran)
            'FormViewPenjualan.CRV.ReportSource = crpt
            'FormViewPenjualan.CRV.RefreshReport()
        Else
            MsgBox("Maaf, Data tidak ditemukan", MsgBoxStyle.Exclamation)
        End If

        Conn.Close()
    End Sub

    Private Sub BtnCetakLuar_Click(sender As Object, e As EventArgs) Handles BtnCetakLuar.Click
        If RBBulanLuar.Checked Then
            tampilblnthn()
        ElseIf RBTanggalLuar.Checked Then
            tampilharianLuar()
        ElseIf RBSemuaLuar.Checked Then
            tampilsemualuar()
        End If
    End Sub
End Class