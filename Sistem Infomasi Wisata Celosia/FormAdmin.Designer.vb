<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WahanaTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasukanTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.KasirTSM, Me.WahanaTSM, Me.PemasukanTSM, Me.PengeluaranTSM, Me.LaporanTSM})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.MenuStrip2.Size = New System.Drawing.Size(1200, 46)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutTSM, Me.KeluarTSM})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(56, 26)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'LogoutTSM
        '
        Me.LogoutTSM.Name = "LogoutTSM"
        Me.LogoutTSM.Size = New System.Drawing.Size(148, 26)
        Me.LogoutTSM.Text = "Logout"
        '
        'KeluarTSM
        '
        Me.KeluarTSM.Name = "KeluarTSM"
        Me.KeluarTSM.Size = New System.Drawing.Size(148, 26)
        Me.KeluarTSM.Text = "Keluar"
        '
        'KasirTSM
        '
        Me.KasirTSM.Name = "KasirTSM"
        Me.KasirTSM.Size = New System.Drawing.Size(68, 26)
        Me.KasirTSM.Text = "Kasir"
        '
        'WahanaTSM
        '
        Me.WahanaTSM.Name = "WahanaTSM"
        Me.WahanaTSM.Size = New System.Drawing.Size(85, 26)
        Me.WahanaTSM.Text = "Wahana"
        '
        'PemasukanTSM
        '
        Me.PemasukanTSM.Name = "PemasukanTSM"
        Me.PemasukanTSM.Size = New System.Drawing.Size(111, 26)
        Me.PemasukanTSM.Text = "Pemasukan"
        '
        'PengeluaranTSM
        '
        Me.PengeluaranTSM.Name = "PengeluaranTSM"
        Me.PengeluaranTSM.Size = New System.Drawing.Size(120, 26)
        Me.PengeluaranTSM.Text = "Pengeluaran"
        '
        'LaporanTSM
        '
        Me.LaporanTSM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPengeluaranToolStripMenuItem})
        Me.LaporanTSM.Name = "LaporanTSM"
        Me.LaporanTSM.Size = New System.Drawing.Size(89, 26)
        Me.LaporanTSM.Text = "Laporan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 800)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1056, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADMIN"
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
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 846)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutTSM As ToolStripMenuItem
    Friend WithEvents KeluarTSM As ToolStripMenuItem
    Friend WithEvents WahanaTSM As ToolStripMenuItem
    Friend WithEvents PemasukanTSM As ToolStripMenuItem
    Friend WithEvents PengeluaranTSM As ToolStripMenuItem
    Friend WithEvents LaporanTSM As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KasirTSM As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPengeluaranToolStripMenuItem As ToolStripMenuItem
End Class
