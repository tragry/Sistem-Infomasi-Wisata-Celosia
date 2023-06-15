<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVTiket = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_idstruk = New System.Windows.Forms.Label()
        Me.Lbl_TanggalWaktu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBayar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pesanan Taman Celosia"
        '
        'DGVTiket
        '
        Me.DGVTiket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVTiket.BackgroundColor = System.Drawing.Color.White
        Me.DGVTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTiket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.nama, Me.qty, Me.harga, Me.jumlah})
        Me.DGVTiket.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVTiket.Location = New System.Drawing.Point(71, 131)
        Me.DGVTiket.Name = "DGVTiket"
        Me.DGVTiket.RowHeadersWidth = 51
        Me.DGVTiket.RowTemplate.Height = 24
        Me.DGVTiket.Size = New System.Drawing.Size(1000, 320)
        Me.DGVTiket.TabIndex = 25
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.no.FillWeight = 50.0!
        Me.no.HeaderText = "No"
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        '
        'nama
        '
        Me.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama.HeaderText = "Nama Wahana"
        Me.nama.MinimumWidth = 6
        Me.nama.Name = "nama"
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.qty.FillWeight = 50.0!
        Me.qty.HeaderText = "Qty"
        Me.qty.MinimumWidth = 6
        Me.qty.Name = "qty"
        '
        'harga
        '
        Me.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga.FillWeight = 70.0!
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jumlah.FillWeight = 70.0!
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nomor     :"
        '
        'lbl_idstruk
        '
        Me.lbl_idstruk.AutoSize = True
        Me.lbl_idstruk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idstruk.Location = New System.Drawing.Point(177, 83)
        Me.lbl_idstruk.Name = "lbl_idstruk"
        Me.lbl_idstruk.Size = New System.Drawing.Size(69, 22)
        Me.lbl_idstruk.TabIndex = 27
        Me.lbl_idstruk.Text = "id struk"
        '
        'Lbl_TanggalWaktu
        '
        Me.Lbl_TanggalWaktu.AutoSize = True
        Me.Lbl_TanggalWaktu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TanggalWaktu.Location = New System.Drawing.Point(958, 83)
        Me.Lbl_TanggalWaktu.Name = "Lbl_TanggalWaktu"
        Me.Lbl_TanggalWaktu.Size = New System.Drawing.Size(157, 22)
        Me.Lbl_TanggalWaktu.TabIndex = 28
        Me.Lbl_TanggalWaktu.Text = "Tanggal dan waktu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 468)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Kode Bayar    :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 465)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 30)
        Me.TextBox1.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 22)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "(no)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 557)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 22)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 557)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 22)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "0"
        '
        'BtnBayar
        '
        Me.BtnBayar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBayar.Location = New System.Drawing.Point(72, 601)
        Me.BtnBayar.Name = "BtnBayar"
        Me.BtnBayar.Size = New System.Drawing.Size(154, 38)
        Me.BtnBayar.TabIndex = 34
        Me.BtnBayar.Text = "Bayar"
        Me.BtnBayar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(986, 707)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 22)
        Me.DateTimePicker1.TabIndex = 35
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 741)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnBayar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_TanggalWaktu)
        Me.Controls.Add(Me.lbl_idstruk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVTiket)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKasir"
        Me.Text = "FormKasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGVTiket As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_idstruk As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_TanggalWaktu As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBayar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
