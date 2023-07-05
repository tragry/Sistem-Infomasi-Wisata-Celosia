<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
Partial Class FormPengeluaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerNonUserCode()>
=======
    <System.Diagnostics.DebuggerNonUserCode()> _
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
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
<<<<<<< HEAD
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
        Me.Label2.Location = New System.Drawing.Point(414, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 35)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Pengeluaran Taman Celosia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblIdPengeluaran
        '
        Me.LblIdPengeluaran.AutoSize = True
        Me.LblIdPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdPengeluaran.Location = New System.Drawing.Point(107, 144)
        Me.LblIdPengeluaran.Name = "LblIdPengeluaran"
        Me.LblIdPengeluaran.Size = New System.Drawing.Size(132, 22)
        Me.LblIdPengeluaran.TabIndex = 27
        Me.LblIdPengeluaran.Text = "Id_Pengeluaran"
        '
        'LblPengeluaran
        '
        Me.LblPengeluaran.AutoSize = True
        Me.LblPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPengeluaran.Location = New System.Drawing.Point(107, 201)
        Me.LblPengeluaran.Name = "LblPengeluaran"
        Me.LblPengeluaran.Size = New System.Drawing.Size(106, 22)
        Me.LblPengeluaran.TabIndex = 28
        Me.LblPengeluaran.Text = "Pengeluaran"
        '
        'LblJumlah
        '
        Me.LblJumlah.AutoSize = True
        Me.LblJumlah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJumlah.Location = New System.Drawing.Point(107, 255)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(65, 22)
        Me.LblJumlah.TabIndex = 29
        Me.LblJumlah.Text = "Jumlah"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(727, 144)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(72, 22)
        Me.LblTanggal.TabIndex = 30
        Me.LblTanggal.Text = "Tanggal"
        '
        'Lblketerangan
        '
        Me.Lblketerangan.AutoSize = True
        Me.Lblketerangan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblketerangan.Location = New System.Drawing.Point(107, 315)
        Me.Lblketerangan.Name = "Lblketerangan"
        Me.Lblketerangan.Size = New System.Drawing.Size(99, 22)
        Me.Lblketerangan.TabIndex = 31
        Me.Lblketerangan.Text = "Keterangan"
        '
        'TxtIdPengeluaran
        '
        Me.TxtIdPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPengeluaran.Location = New System.Drawing.Point(278, 144)
        Me.TxtIdPengeluaran.Name = "TxtIdPengeluaran"
        Me.TxtIdPengeluaran.Size = New System.Drawing.Size(238, 30)
        Me.TxtIdPengeluaran.TabIndex = 32
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTanggal.Location = New System.Drawing.Point(847, 141)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(235, 30)
        Me.TxtTanggal.TabIndex = 33
        '
        'TxtPengeluaran
        '
        Me.TxtPengeluaran.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPengeluaran.Location = New System.Drawing.Point(278, 201)
        Me.TxtPengeluaran.Name = "TxtPengeluaran"
        Me.TxtPengeluaran.Size = New System.Drawing.Size(400, 30)
        Me.TxtPengeluaran.TabIndex = 34
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(278, 255)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(238, 30)
        Me.TxtJumlah.TabIndex = 35
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(278, 315)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(461, 70)
        Me.TxtKeterangan.TabIndex = 36
        '
        'DgvPengeluaran
        '
        Me.DgvPengeluaran.BackgroundColor = System.Drawing.Color.White
        Me.DgvPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPengeluaran.Location = New System.Drawing.Point(110, 416)
        Me.DgvPengeluaran.Name = "DgvPengeluaran"
        Me.DgvPengeluaran.RowHeadersWidth = 51
        Me.DgvPengeluaran.RowTemplate.Height = 24
        Me.DgvPengeluaran.Size = New System.Drawing.Size(972, 319)
        Me.DgvPengeluaran.TabIndex = 37
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(924, 273)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(158, 44)
        Me.BtnSimpan.TabIndex = 39
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(924, 341)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(158, 44)
        Me.Btndelete.TabIndex = 40
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
=======
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(423, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pengeluaran Taman Celosia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        '
        'FormPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.Color.LightSteelBlue
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
=======
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Label1)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPengeluaran"
        Me.Text = "FormPengeluaran"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
<<<<<<< HEAD
        CType(Me.DgvPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
=======
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
<<<<<<< HEAD
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
=======

    Friend WithEvents Label1 As Label
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
End Class
