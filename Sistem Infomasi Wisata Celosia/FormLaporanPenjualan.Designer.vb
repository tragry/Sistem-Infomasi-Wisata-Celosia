<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPenjualan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbothn = New System.Windows.Forms.ComboBox()
        Me.cbobln = New System.Windows.Forms.ComboBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.RBBulan = New System.Windows.Forms.RadioButton()
        Me.RBTanggal = New System.Windows.Forms.RadioButton()
        Me.RBSemua = New System.Windows.Forms.RadioButton()
        Me.DGVCetakPenjualan = New System.Windows.Forms.DataGridView()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCetakPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "LAPORAN PENJUALAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbothn)
        Me.GroupBox1.Controls.Add(Me.cbobln)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.RBBulan)
        Me.GroupBox1.Controls.Add(Me.RBTanggal)
        Me.GroupBox1.Controls.Add(Me.RBSemua)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1163, 202)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 36)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "."
        '
        'cbothn
        '
        Me.cbothn.FormattingEnabled = True
        Me.cbothn.Location = New System.Drawing.Point(547, 136)
        Me.cbothn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbothn.Name = "cbothn"
        Me.cbothn.Size = New System.Drawing.Size(260, 33)
        Me.cbothn.TabIndex = 8
        '
        'cbobln
        '
        Me.cbobln.FormattingEnabled = True
        Me.cbobln.Location = New System.Drawing.Point(220, 136)
        Me.cbobln.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbobln.Name = "cbobln"
        Me.cbobln.Size = New System.Drawing.Size(262, 33)
        Me.cbobln.TabIndex = 7
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Location = New System.Drawing.Point(220, 88)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(262, 30)
        Me.dtp1.TabIndex = 4
        '
        'RBBulan
        '
        Me.RBBulan.AutoSize = True
        Me.RBBulan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBulan.Location = New System.Drawing.Point(41, 141)
        Me.RBBulan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBBulan.Name = "RBBulan"
        Me.RBBulan.Size = New System.Drawing.Size(136, 27)
        Me.RBBulan.TabIndex = 3
        Me.RBBulan.TabStop = True
        Me.RBBulan.Text = "Bulan/Tahun"
        Me.RBBulan.UseVisualStyleBackColor = True
        '
        'RBTanggal
        '
        Me.RBTanggal.AutoSize = True
        Me.RBTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTanggal.Location = New System.Drawing.Point(41, 88)
        Me.RBTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBTanggal.Name = "RBTanggal"
        Me.RBTanggal.Size = New System.Drawing.Size(97, 27)
        Me.RBTanggal.TabIndex = 1
        Me.RBTanggal.TabStop = True
        Me.RBTanggal.Text = "Tanggal"
        Me.RBTanggal.UseVisualStyleBackColor = True
        '
        'RBSemua
        '
        Me.RBSemua.AutoSize = True
        Me.RBSemua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSemua.Location = New System.Drawing.Point(41, 40)
        Me.RBSemua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBSemua.Name = "RBSemua"
        Me.RBSemua.Size = New System.Drawing.Size(87, 27)
        Me.RBSemua.TabIndex = 0
        Me.RBSemua.TabStop = True
        Me.RBSemua.Text = "Semua"
        Me.RBSemua.UseVisualStyleBackColor = True
        '
        'DGVCetakPenjualan
        '
        Me.DGVCetakPenjualan.BackgroundColor = System.Drawing.Color.White
        Me.DGVCetakPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCetakPenjualan.GridColor = System.Drawing.Color.White
        Me.DGVCetakPenjualan.Location = New System.Drawing.Point(31, 311)
        Me.DGVCetakPenjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVCetakPenjualan.Name = "DGVCetakPenjualan"
        Me.DGVCetakPenjualan.RowHeadersWidth = 62
        Me.DGVCetakPenjualan.RowTemplate.Height = 28
        Me.DGVCetakPenjualan.Size = New System.Drawing.Size(1157, 376)
        Me.DGVCetakPenjualan.TabIndex = 18
        '
        'BtnCetak
        '
        Me.BtnCetak.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.Location = New System.Drawing.Point(528, 723)
        Me.BtnCetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(120, 45)
        Me.BtnCetak.TabIndex = 17
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'FormLaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVCetakPenjualan)
        Me.Controls.Add(Me.BtnCetak)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCetakPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbothn As ComboBox
    Friend WithEvents cbobln As ComboBox
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents RBBulan As RadioButton
    Friend WithEvents RBTanggal As RadioButton
    Friend WithEvents RBSemua As RadioButton
    Friend WithEvents DGVCetakPenjualan As DataGridView
    Friend WithEvents BtnCetak As Button
End Class
