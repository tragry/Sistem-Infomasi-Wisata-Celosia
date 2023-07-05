<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WahanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KatalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.WahanaToolStripMenuItem, Me.KasirToolStripMenuItem, Me.PemasukanToolStripMenuItem, Me.PengeluaranToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KatalogToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.MenuStrip2.Size = New System.Drawing.Size(1182, 46)
        Me.MenuStrip2.TabIndex = 0
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(56, 26)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'WahanaToolStripMenuItem
        '
        Me.WahanaToolStripMenuItem.Name = "WahanaToolStripMenuItem"
        Me.WahanaToolStripMenuItem.Size = New System.Drawing.Size(85, 26)
        Me.WahanaToolStripMenuItem.Text = "Wahana"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(68, 26)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'PemasukanToolStripMenuItem
        '
        Me.PemasukanToolStripMenuItem.Name = "PemasukanToolStripMenuItem"
        Me.PemasukanToolStripMenuItem.Size = New System.Drawing.Size(111, 26)
        Me.PemasukanToolStripMenuItem.Text = "Pemasukan"
        '
        'PengeluaranToolStripMenuItem
        '
        Me.PengeluaranToolStripMenuItem.Name = "PengeluaranToolStripMenuItem"
        Me.PengeluaranToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.PengeluaranToolStripMenuItem.Text = "Pengeluaran"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPengeluaranToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(89, 26)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KatalogToolStripMenuItem
        '
        Me.KatalogToolStripMenuItem.Name = "KatalogToolStripMenuItem"
        Me.KatalogToolStripMenuItem.Size = New System.Drawing.Size(86, 26)
        Me.KatalogToolStripMenuItem.Text = "Katalog"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 707)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(341, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(519, 45)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Wisata Taman Bunga Celosia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(343, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Selamat Datang di"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPengeluaranToolStripMenuItem
        '
        Me.LaporanPengeluaranToolStripMenuItem.Name = "LaporanPengeluaranToolStripMenuItem"
        Me.LaporanPengeluaranToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.LaporanPengeluaranToolStripMenuItem.Text = "Laporan Pengeluaran"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Wisata Taman Celosia"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WahanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemasukanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengeluaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KatalogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPengeluaranToolStripMenuItem As ToolStripMenuItem
End Class
