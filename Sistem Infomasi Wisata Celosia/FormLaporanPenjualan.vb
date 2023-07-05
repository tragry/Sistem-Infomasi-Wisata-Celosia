Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporanPenjualan
    Dim hari, bln, thn As String
    Dim nobln, status As String

    Dim Conn As SqlConnection = New SqlConnection("Data Source=ARAA; " & "user id = sa; password=123456; Integrated Security=True; " &
                                                  "database=Wisata_Celosia")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Dim Da As SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim Rd As SqlDataReader

    Dim dt_penjualan As New DataTable

    Private Sub FormLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        Dim i As Integer
        For i = 2021 To Year(Now)
            cbothn.Items.Add(i)
        Next

        cbobln.Items.Clear()
        'cbobln.Items.Add("")
        cbobln.Items.Add("Januari")
        cbobln.Items.Add("Februari")
        cbobln.Items.Add("Maret")
        cbobln.Items.Add("April")
        cbobln.Items.Add("Mei")
        cbobln.Items.Add("Juni")
        cbobln.Items.Add("Juli")
        cbobln.Items.Add("Agustus")
        cbobln.Items.Add("September")
        cbobln.Items.Add("Oktober")
        cbobln.Items.Add("November")
        cbobln.Items.Add("Desember")
    End Sub

    Sub tampilblnthn()
        If cbobln.Text = "" And cbothn.Text = "" Then
            MsgBox("Pilih bulan atau tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cbobln.Text <> "" And cbothn.Text = "" Then
            MsgBox("Pilih tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cbobln.Text = "" And cbothn.Text <> "" Then
            MsgBox("Pilih bulan terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim objCmd As New SqlCommand

        dt_penjualan.Clear()

        If cbobln.Text <> "" And cbothn.Text <> "" Then
            Dim nobln As Integer = cbobln.SelectedIndex + 1
            Dim thn As Integer = CInt(cbothn.Text)
            Dim ctktgl As String = "SELECT * FROM transaksi WHERE MONTH(tgl_trans) = @nobln AND YEAR(tgl_trans) = @thn ORDER BY tgl_trans"

            objCmd.Connection = Conn
            objCmd.CommandType = CommandType.Text
            objCmd.CommandText = ctktgl
            objCmd.Parameters.AddWithValue("@nobln", nobln)
            objCmd.Parameters.AddWithValue("@thn", thn)

            Da = New SqlDataAdapter(objCmd)
            Da.Fill(dt_penjualan)
            DGVCetakPenjualan.DataSource = dt_penjualan
        End If
    End Sub

    Sub tampilharian()
        Dim objCmd As New SqlCommand

        dt_penjualan.Clear()

        Dim tgl As String = Format(dtp1.Value, "yyyy-MM-dd")
        Dim ctktgl As String = "SELECT * FROM transaksi WHERE CAST(tgl_trans AS DATE) = @tgl ORDER BY tgl_trans"

        objCmd.Connection = Conn
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = ctktgl
        objCmd.Parameters.AddWithValue("@tgl", tgl)

        Da = New SqlDataAdapter(objCmd)
        Da.Fill(dt_penjualan)
        DGVCetakPenjualan.DataSource = dt_penjualan
    End Sub

    Sub tampilsemua()
        Dim objCmd As New SqlCommand

        dt_penjualan.Clear()

        Dim ctktgl As String = "SELECT * FROM transaksi ORDER BY tgl_trans"

        objCmd.Connection = Conn
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = ctktgl

        Da = New SqlDataAdapter(objCmd)
        Da.Fill(dt_penjualan)
        DGVCetakPenjualan.DataSource = dt_penjualan
    End Sub

    Sub cetaktglpenjualan()
        Dim crpt As New ReportDocument

        nobln = cbobln.SelectedIndex + 1
        thn = cbothn.Text

        If cbobln.Text = "" And cbothn.Text = "" Then
            MsgBox("Pilih bulan atau tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cbobln.Text <> "" And cbothn.Text = "" Then
            MsgBox("Pilih tahun terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        ElseIf cbobln.Text = "" And cbothn.Text <> "" Then
            MsgBox("Pilih bulan terlebih dahulu", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim ctktgl As String = ""
        If cbobln.Text <> "" And cbothn.Text <> "" Then
            ctktgl = "SELECT * FROM transaksi WHERE MONTH(tgl_trans) = @nobln AND YEAR(tgl_trans) = @thn ORDER BY tgl_trans"
        End If

        Conn.Open()
        Cmd = New SqlCommand(ctktgl, Conn)
        Cmd.Parameters.AddWithValue("@nobln", nobln)
        Cmd.Parameters.AddWithValue("@thn", thn)
        Rd = Cmd.ExecuteReader
        Dim jml As Integer = 0

        If Rd.HasRows Then
            crpt.Load(Application.StartupPath & "\LaporanPenjualan.rpt")
            crpt.SetDataSource(dt_penjualan)
            'FormViewPenjualan.CRV.ReportSource = crpt
            'FormViewPenjualan.CRV.RefreshReport()
        Else
            MsgBox("Maaf, Data tidak ditemukan", MsgBoxStyle.Exclamation)
        End If

        Conn.Close()
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        If RBBulan.Checked Then
            tampilblnthn()
        ElseIf RBTanggal.Checked Then
            tampilharian()
        ElseIf RBSemua.Checked Then
            tampilsemua()
        End If
    End Sub
End Class
