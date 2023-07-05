<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_LaporanPengeluaran
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
        Me.DGVCetakPengeluaran = New System.Windows.Forms.DataGridView()
        Me.RBSemuaLuar = New System.Windows.Forms.RadioButton()
        Me.RBTanggalLuar = New System.Windows.Forms.RadioButton()
        Me.RBBulanLuar = New System.Windows.Forms.RadioButton()
        Me.dtp1luar = New System.Windows.Forms.DateTimePicker()
        Me.cboblnluar = New System.Windows.Forms.ComboBox()
        Me.cbothnluar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCetakLuar = New System.Windows.Forms.Button()
        CType(Me.DGVCetakPengeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCetakPengeluaran
        '
        Me.DGVCetakPengeluaran.BackgroundColor = System.Drawing.Color.White
        Me.DGVCetakPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCetakPengeluaran.GridColor = System.Drawing.Color.White
        Me.DGVCetakPengeluaran.Location = New System.Drawing.Point(58, 335)
        Me.DGVCetakPengeluaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCetakPengeluaran.Name = "DGVCetakPengeluaran"
        Me.DGVCetakPengeluaran.RowHeadersWidth = 62
        Me.DGVCetakPengeluaran.RowTemplate.Height = 28
        Me.DGVCetakPengeluaran.Size = New System.Drawing.Size(1083, 350)
        Me.DGVCetakPengeluaran.TabIndex = 18
        '
        'RBSemuaLuar
        '
        Me.RBSemuaLuar.AutoSize = True
        Me.RBSemuaLuar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSemuaLuar.Location = New System.Drawing.Point(35, 38)
        Me.RBSemuaLuar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBSemuaLuar.Name = "RBSemuaLuar"
        Me.RBSemuaLuar.Size = New System.Drawing.Size(87, 27)
        Me.RBSemuaLuar.TabIndex = 0
        Me.RBSemuaLuar.TabStop = True
        Me.RBSemuaLuar.Text = "Semua"
        Me.RBSemuaLuar.UseVisualStyleBackColor = True
        '
        'RBTanggalLuar
        '
        Me.RBTanggalLuar.AutoSize = True
        Me.RBTanggalLuar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTanggalLuar.Location = New System.Drawing.Point(35, 80)
        Me.RBTanggalLuar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBTanggalLuar.Name = "RBTanggalLuar"
        Me.RBTanggalLuar.Size = New System.Drawing.Size(97, 27)
        Me.RBTanggalLuar.TabIndex = 1
        Me.RBTanggalLuar.TabStop = True
        Me.RBTanggalLuar.Text = "Tanggal"
        Me.RBTanggalLuar.UseVisualStyleBackColor = True
        '
        'RBBulanLuar
        '
        Me.RBBulanLuar.AutoSize = True
        Me.RBBulanLuar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBulanLuar.Location = New System.Drawing.Point(35, 131)
        Me.RBBulanLuar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBBulanLuar.Name = "RBBulanLuar"
        Me.RBBulanLuar.Size = New System.Drawing.Size(136, 27)
        Me.RBBulanLuar.TabIndex = 3
        Me.RBBulanLuar.TabStop = True
        Me.RBBulanLuar.Text = "Bulan/Tahun"
        Me.RBBulanLuar.UseVisualStyleBackColor = True
        '
        'dtp1luar
        '
        Me.dtp1luar.Location = New System.Drawing.Point(201, 74)
        Me.dtp1luar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp1luar.Name = "dtp1luar"
        Me.dtp1luar.Size = New System.Drawing.Size(260, 30)
        Me.dtp1luar.TabIndex = 4
        '
        'cboblnluar
        '
        Me.cboblnluar.FormattingEnabled = True
        Me.cboblnluar.Location = New System.Drawing.Point(202, 128)
        Me.cboblnluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboblnluar.Name = "cboblnluar"
        Me.cboblnluar.Size = New System.Drawing.Size(260, 30)
        Me.cboblnluar.TabIndex = 7
        '
        'cbothnluar
        '
        Me.cbothnluar.FormattingEnabled = True
        Me.cbothnluar.Location = New System.Drawing.Point(555, 128)
        Me.cbothnluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbothnluar.Name = "cbothnluar"
        Me.cbothnluar.Size = New System.Drawing.Size(219, 30)
        Me.cbothnluar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 35)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbothnluar)
        Me.GroupBox1.Controls.Add(Me.cboblnluar)
        Me.GroupBox1.Controls.Add(Me.dtp1luar)
        Me.GroupBox1.Controls.Add(Me.RBBulanLuar)
        Me.GroupBox1.Controls.Add(Me.RBTanggalLuar)
        Me.GroupBox1.Controls.Add(Me.RBSemuaLuar)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 110)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 193)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 35)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "LAPORAN PENGELUARAN"
        '
        'BtnCetakLuar
        '
        Me.BtnCetakLuar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakLuar.Location = New System.Drawing.Point(559, 713)
        Me.BtnCetakLuar.Name = "BtnCetakLuar"
        Me.BtnCetakLuar.Size = New System.Drawing.Size(97, 45)
        Me.BtnCetakLuar.TabIndex = 21
        Me.BtnCetakLuar.Text = "Cetak"
        Me.BtnCetakLuar.UseVisualStyleBackColor = True
        '
        'Form_LaporanPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.BtnCetakLuar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVCetakPengeluaran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_LaporanPengeluaran"
        Me.Text = "Form_LaporanPengeluaran"
        CType(Me.DGVCetakPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVCetakPengeluaran As DataGridView
    Friend WithEvents RBSemuaLuar As RadioButton
    Friend WithEvents RBTanggalLuar As RadioButton
    Friend WithEvents RBBulanLuar As RadioButton
    Friend WithEvents dtp1luar As DateTimePicker
    Friend WithEvents cboblnluar As ComboBox
    Friend WithEvents cbothnluar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCetakLuar As Button
End Class
