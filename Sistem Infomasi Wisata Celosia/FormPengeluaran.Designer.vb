<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPengeluaran
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblIdPengeluaran = New System.Windows.Forms.Label()
        Me.LblPengeluaran = New System.Windows.Forms.Label()
        Me.LblJumlah = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.Lblketerangan = New System.Windows.Forms.Label()
        Me.TxtIdPengeluaran = New System.Windows.Forms.TextBox()
        Me.TxtTanggal = New System.Windows.Forms.TextBox()
        Me.TxtPengeluaran = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.DgvPengeluaran = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        CType(Me.DgvPengeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(446, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 35)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Pengeluaran Taman Celosia aa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblIdPengeluaran
        '
        Me.LblIdPengeluaran.AutoSize = True
        Me.LblIdPengeluaran.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdPengeluaran.Location = New System.Drawing.Point(105, 152)
        Me.LblIdPengeluaran.Name = "LblIdPengeluaran"
        Me.LblIdPengeluaran.Size = New System.Drawing.Size(163, 27)
        Me.LblIdPengeluaran.TabIndex = 27
        Me.LblIdPengeluaran.Text = "Id_Pengeluaran"
        '
        'LblPengeluaran
        '
        Me.LblPengeluaran.AutoSize = True
        Me.LblPengeluaran.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPengeluaran.Location = New System.Drawing.Point(105, 235)
        Me.LblPengeluaran.Name = "LblPengeluaran"
        Me.LblPengeluaran.Size = New System.Drawing.Size(131, 27)
        Me.LblPengeluaran.TabIndex = 28
        Me.LblPengeluaran.Text = "Pengeluaran"
        '
        'LblJumlah
        '
        Me.LblJumlah.AutoSize = True
        Me.LblJumlah.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumlah.Location = New System.Drawing.Point(105, 314)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(80, 27)
        Me.LblJumlah.TabIndex = 29
        Me.LblJumlah.Text = "Jumlah"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(723, 152)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(86, 27)
        Me.LblTanggal.TabIndex = 30
        Me.LblTanggal.Text = "Tanggal"
        '
        'Lblketerangan
        '
        Me.Lblketerangan.AutoSize = True
        Me.Lblketerangan.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblketerangan.Location = New System.Drawing.Point(105, 394)
        Me.Lblketerangan.Name = "Lblketerangan"
        Me.Lblketerangan.Size = New System.Drawing.Size(123, 27)
        Me.Lblketerangan.TabIndex = 31
        Me.Lblketerangan.Text = "Keterangan"
        '
        'TxtIdPengeluaran
        '
        Me.TxtIdPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPengeluaran.Location = New System.Drawing.Point(310, 152)
        Me.TxtIdPengeluaran.Name = "TxtIdPengeluaran"
        Me.TxtIdPengeluaran.Size = New System.Drawing.Size(371, 30)
        Me.TxtIdPengeluaran.TabIndex = 32
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTanggal.Location = New System.Drawing.Point(843, 149)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(235, 30)
        Me.TxtTanggal.TabIndex = 33
        '
        'TxtPengeluaran
        '
        Me.TxtPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPengeluaran.Location = New System.Drawing.Point(310, 232)
        Me.TxtPengeluaran.Name = "TxtPengeluaran"
        Me.TxtPengeluaran.Size = New System.Drawing.Size(371, 30)
        Me.TxtPengeluaran.TabIndex = 34
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(310, 314)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(238, 30)
        Me.TxtJumlah.TabIndex = 35
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(310, 391)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(371, 30)
        Me.TxtKeterangan.TabIndex = 36
        '
        'DgvPengeluaran
        '
        Me.DgvPengeluaran.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPengeluaran.Location = New System.Drawing.Point(241, 503)
        Me.DgvPengeluaran.Name = "DgvPengeluaran"
        Me.DgvPengeluaran.RowHeadersWidth = 51
        Me.DgvPengeluaran.RowTemplate.Height = 24
        Me.DgvPengeluaran.Size = New System.Drawing.Size(728, 150)
        Me.DgvPengeluaran.TabIndex = 37
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(725, 391)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(120, 44)
        Me.BtnSimpan.TabIndex = 39
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(860, 394)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(120, 44)
        Me.Btndelete.TabIndex = 40
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'FormPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DgvPengeluaran)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtPengeluaran)
        Me.Controls.Add(Me.TxtTanggal)
        Me.Controls.Add(Me.TxtIdPengeluaran)
        Me.Controls.Add(Me.Lblketerangan)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LblJumlah)
        Me.Controls.Add(Me.LblPengeluaran)
        Me.Controls.Add(Me.LblIdPengeluaran)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPengeluaran"
        Me.Text = "FormPengeluaran"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents LblIdPengeluaran As Label
    Friend WithEvents LblPengeluaran As Label
    Friend WithEvents LblJumlah As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents Lblketerangan As Label
    Friend WithEvents TxtIdPengeluaran As TextBox
    Friend WithEvents TxtTanggal As TextBox
    Friend WithEvents TxtPengeluaran As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents DgvPengeluaran As DataGridView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Btndelete As Button
End Class
