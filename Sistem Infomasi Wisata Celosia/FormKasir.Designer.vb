<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKasir
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
        Me.LbTotalBayar = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnTotal = New System.Windows.Forms.Button()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGVTransaksi = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbNamaWahana = New System.Windows.Forms.ComboBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtKodeWahana = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbTgl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_idstruk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbTotalBayar
        '
        Me.LbTotalBayar.AutoSize = True
        Me.LbTotalBayar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalBayar.Location = New System.Drawing.Point(144, 731)
        Me.LbTotalBayar.Name = "LbTotalBayar"
        Me.LbTotalBayar.Size = New System.Drawing.Size(20, 22)
        Me.LbTotalBayar.TabIndex = 77
        Me.LbTotalBayar.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(86, 731)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 22)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Rp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(82, 684)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 22)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Total Bayar           :"
        '
        'BtnTotal
        '
        Me.BtnTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTotal.Location = New System.Drawing.Point(788, 345)
        Me.BtnTotal.Name = "BtnTotal"
        Me.BtnTotal.Size = New System.Drawing.Size(154, 38)
        Me.BtnTotal.TabIndex = 74
        Me.BtnTotal.Text = "Total"
        Me.BtnTotal.UseVisualStyleBackColor = True
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotal.Location = New System.Drawing.Point(280, 353)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(20, 22)
        Me.LbTotal.TabIndex = 73
        Me.LbTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 22)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Rp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(82, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 22)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Total           :"
        '
        'DGVTransaksi
        '
        Me.DGVTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTransaksi.BackgroundColor = System.Drawing.Color.White
        Me.DGVTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransaksi.Location = New System.Drawing.Point(86, 412)
        Me.DGVTransaksi.Name = "DGVTransaksi"
        Me.DGVTransaksi.RowHeadersWidth = 51
        Me.DGVTransaksi.RowTemplate.Height = 24
        Me.DGVTransaksi.Size = New System.Drawing.Size(1037, 246)
        Me.DGVTransaksi.TabIndex = 70
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(969, 693)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 38)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Bayar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(969, 345)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(154, 38)
        Me.BtnTambah.TabIndex = 68
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbNamaWahana)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.TxtJumlah)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtKodeWahana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1037, 147)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'CmbNamaWahana
        '
        Me.CmbNamaWahana.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbNamaWahana.FormattingEnabled = True
        Me.CmbNamaWahana.Location = New System.Drawing.Point(213, 92)
        Me.CmbNamaWahana.Name = "CmbNamaWahana"
        Me.CmbNamaWahana.Size = New System.Drawing.Size(281, 30)
        Me.CmbNamaWahana.TabIndex = 50
        '
        'TxtHarga
        '
        Me.TxtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(725, 37)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(241, 30)
        Me.TxtHarga.TabIndex = 47
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(725, 92)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(241, 30)
        Me.TxtJumlah.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Kode Wahana"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(583, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Jumlah"
        '
        'TxtKodeWahana
        '
        Me.TxtKodeWahana.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKodeWahana.Location = New System.Drawing.Point(213, 37)
        Me.TxtKodeWahana.Name = "TxtKodeWahana"
        Me.TxtKodeWahana.Size = New System.Drawing.Size(281, 30)
        Me.TxtKodeWahana.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nama Wahana"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(583, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Harga"
        '
        'LbTgl
        '
        Me.LbTgl.AutoSize = True
        Me.LbTgl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTgl.Location = New System.Drawing.Point(1003, 112)
        Me.LbTgl.Name = "LbTgl"
        Me.LbTgl.Size = New System.Drawing.Size(73, 22)
        Me.LbTgl.TabIndex = 66
        Me.LbTgl.Text = "tgl trans"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(839, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Tanggal        :"
        '
        'lbl_idstruk
        '
        Me.lbl_idstruk.AutoSize = True
        Me.lbl_idstruk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idstruk.Location = New System.Drawing.Point(220, 112)
        Me.lbl_idstruk.Name = "lbl_idstruk"
        Me.lbl_idstruk.Size = New System.Drawing.Size(69, 22)
        Me.lbl_idstruk.TabIndex = 64
        Me.lbl_idstruk.Text = "id struk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Nomor           :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 35)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Pesanan Taman Celosia"
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.LbTotalBayar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnTotal)
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVTransaksi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbTgl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_idstruk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKasir"
        Me.Text = "FormKasir"
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTotalBayar As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnTotal As Button
    Friend WithEvents LbTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVTransaksi As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbNamaWahana As ComboBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtKodeWahana As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbTgl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_idstruk As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
