<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWahana
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
<<<<<<< HEAD
=======
        Me.DGVWahana = New System.Windows.Forms.DataGridView()
        Me.id_wahana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wahana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaWahana = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.pic_gambar = New System.Windows.Forms.PictureBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGVWahana = New System.Windows.Forms.DataGridView()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pic_gambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
=======
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVWahana
        '
        Me.DGVWahana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVWahana.BackgroundColor = System.Drawing.Color.White
        Me.DGVWahana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVWahana.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_wahana, Me.Wahana, Me.Keterangan, Me.gambar})
        Me.DGVWahana.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVWahana.Location = New System.Drawing.Point(80, 387)
        Me.DGVWahana.Name = "DGVWahana"
        Me.DGVWahana.RowHeadersWidth = 51
        Me.DGVWahana.RowTemplate.Height = 24
        Me.DGVWahana.Size = New System.Drawing.Size(1000, 300)
        Me.DGVWahana.TabIndex = 11
        '
        'id_wahana
        '
        Me.id_wahana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_wahana.FillWeight = 20.0!
        Me.id_wahana.HeaderText = "ID"
        Me.id_wahana.MinimumWidth = 6
        Me.id_wahana.Name = "id_wahana"
        '
        'Wahana
        '
        Me.Wahana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Wahana.HeaderText = "Wahana"
        Me.Wahana.MinimumWidth = 6
        Me.Wahana.Name = "Wahana"
        '
        'Keterangan
        '
        Me.Keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Keterangan.FillWeight = 150.0!
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.MinimumWidth = 6
        Me.Keterangan.Name = "Keterangan"
        '
        'gambar
        '
        Me.gambar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gambar.FillWeight = 70.0!
        Me.gambar.HeaderText = "Gambar"
        Me.gambar.MinimumWidth = 6
        Me.gambar.Name = "gambar"
        '
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label1.Location = New System.Drawing.Point(437, 40)
=======
        Me.Label1.Location = New System.Drawing.Point(416, 33)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Wahana Taman CELOSIA"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TxtId.Location = New System.Drawing.Point(217, 111)
=======
        Me.TxtId.Location = New System.Drawing.Point(210, 132)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(241, 30)
        Me.TxtId.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label2.Location = New System.Drawing.Point(75, 114)
=======
        Me.Label2.Location = New System.Drawing.Point(68, 135)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID "
        '
        'TxtNamaWahana
        '
        Me.TxtNamaWahana.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TxtNamaWahana.Location = New System.Drawing.Point(217, 175)
=======
        Me.TxtNamaWahana.Location = New System.Drawing.Point(210, 188)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.TxtNamaWahana.Name = "TxtNamaWahana"
        Me.TxtNamaWahana.Size = New System.Drawing.Size(241, 30)
        Me.TxtNamaWahana.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label3.Location = New System.Drawing.Point(75, 178)
=======
        Me.Label3.Location = New System.Drawing.Point(68, 191)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Wahana"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TxtKeterangan.Location = New System.Drawing.Point(217, 308)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(366, 90)
=======
        Me.TxtKeterangan.Location = New System.Drawing.Point(210, 246)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(409, 30)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.TxtKeterangan.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label4.Location = New System.Drawing.Point(75, 311)
=======
        Me.Label4.Location = New System.Drawing.Point(68, 249)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Keterangan"
        '
<<<<<<< HEAD
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(625, 360)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(149, 38)
        Me.BtnCreate.TabIndex = 20
        Me.BtnCreate.Text = "Simpan"
=======
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(210, 306)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(241, 30)
        Me.TextBox4.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Gambar"
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(918, 132)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(154, 38)
        Me.BtnCreate.TabIndex = 20
        Me.BtnCreate.Text = "Create"
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.BtnUpdate.Location = New System.Drawing.Point(809, 360)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(147, 38)
=======
        Me.BtnUpdate.Location = New System.Drawing.Point(918, 213)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(154, 38)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.BtnDelete.Location = New System.Drawing.Point(990, 360)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(146, 38)
=======
        Me.BtnDelete.Location = New System.Drawing.Point(918, 293)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(154, 38)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'pic_gambar
        '
        Me.pic_gambar.BackColor = System.Drawing.Color.White
        Me.pic_gambar.Location = New System.Drawing.Point(20, 39)
        Me.pic_gambar.Name = "pic_gambar"
        Me.pic_gambar.Size = New System.Drawing.Size(318, 87)
        Me.pic_gambar.TabIndex = 23
        Me.pic_gambar.TabStop = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Location = New System.Drawing.Point(358, 62)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(140, 39)
        Me.BtnBrowse.TabIndex = 24
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DGVWahana
        '
        Me.DGVWahana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVWahana.BackgroundColor = System.Drawing.Color.White
        Me.DGVWahana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVWahana.Location = New System.Drawing.Point(79, 429)
        Me.DGVWahana.Name = "DGVWahana"
        Me.DGVWahana.RowHeadersWidth = 51
        Me.DGVWahana.RowTemplate.Height = 24
        Me.DGVWahana.Size = New System.Drawing.Size(1057, 321)
        Me.DGVWahana.TabIndex = 25
        '
        'TxtHarga
        '
        Me.TxtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(217, 245)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(241, 30)
        Me.TxtHarga.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Harga"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pic_gambar)
        Me.GroupBox1.Controls.Add(Me.BtnBrowse)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(618, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 159)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Gambar"
        '
=======
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        'FormWahana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVWahana)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
=======
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNamaWahana)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label2)
<<<<<<< HEAD
=======
        Me.Controls.Add(Me.DGVWahana)
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormWahana"
        Me.Text = "FormWahana"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
<<<<<<< HEAD
        CType(Me.pic_gambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
=======
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
<<<<<<< HEAD
=======

    Friend WithEvents DGVWahana As DataGridView
    Friend WithEvents id_wahana As DataGridViewTextBoxColumn
    Friend WithEvents Wahana As DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As DataGridViewTextBoxColumn
    Friend WithEvents gambar As DataGridViewTextBoxColumn
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaWahana As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents Label4 As Label
<<<<<<< HEAD
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents pic_gambar As PictureBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DGVWahana As DataGridView
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
=======
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
>>>>>>> 39d7d3b5ef7710882f4ebd4af424a87edbfa57ca
End Class
