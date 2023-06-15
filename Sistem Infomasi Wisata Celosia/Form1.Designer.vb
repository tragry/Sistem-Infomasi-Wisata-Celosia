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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WahanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbSD = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WahanaToolStripMenuItem, Me.KasirToolStripMenuItem, Me.PemasukanToolStripMenuItem, Me.PengeluaranToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(1282, 46)
        Me.MenuStrip1.TabIndex = 85
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(89, 26)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LbSD)
        Me.Panel1.Controls.Add(Me.LbJudul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 800)
        Me.Panel1.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 1651)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(391, 45)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Taman Bunga Celosia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 986)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 45)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Taman Bunga Celosia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 978)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 45)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Taman Bunga Celosia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbSD
        '
        Me.LbSD.AutoSize = True
        Me.LbSD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSD.Location = New System.Drawing.Point(446, 305)
        Me.LbSD.Name = "LbSD"
        Me.LbSD.Size = New System.Drawing.Size(164, 23)
        Me.LbSD.TabIndex = 14
        Me.LbSD.Text = "Selamat Datang di"
        Me.LbSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(442, 328)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(483, 45)
        Me.LbJudul.TabIndex = 13
        Me.LbJudul.Text = "Taman Bunga Celosia anan"
        Me.LbJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1282, 853)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Taman Bunga Celosia"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WahanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemasukanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengeluaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbSD As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbJudul As Label
End Class
