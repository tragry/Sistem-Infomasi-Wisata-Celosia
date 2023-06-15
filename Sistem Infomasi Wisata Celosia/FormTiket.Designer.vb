<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTiket
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtJenisTiket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdWahana = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdTiket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVTiket = New System.Windows.Forms.DataGridView()
        Me.id_tiket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_wahana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_tiket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok_tersedia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tiket Wahana Taman CELOSIA"
        '
        'TxtJenisTiket
        '
        Me.TxtJenisTiket.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJenisTiket.Location = New System.Drawing.Point(219, 255)
        Me.TxtJenisTiket.Name = "TxtJenisTiket"
        Me.TxtJenisTiket.Size = New System.Drawing.Size(409, 30)
        Me.TxtJenisTiket.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Jenis Tiket"
        '
        'TxtIdWahana
        '
        Me.TxtIdWahana.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdWahana.Location = New System.Drawing.Point(219, 197)
        Me.TxtIdWahana.Name = "TxtIdWahana"
        Me.TxtIdWahana.Size = New System.Drawing.Size(241, 30)
        Me.TxtIdWahana.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ID Wahana"
        '
        'TxtIdTiket
        '
        Me.TxtIdTiket.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdTiket.Location = New System.Drawing.Point(219, 141)
        Me.TxtIdTiket.Name = "TxtIdTiket"
        Me.TxtIdTiket.Size = New System.Drawing.Size(241, 30)
        Me.TxtIdTiket.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID Tiket"
        '
        'DGVTiket
        '
        Me.DGVTiket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVTiket.BackgroundColor = System.Drawing.Color.White
        Me.DGVTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTiket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tiket, Me.id_wahana, Me.jenis_tiket, Me.harga, Me.stok_tersedia})
        Me.DGVTiket.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVTiket.Location = New System.Drawing.Point(82, 372)
        Me.DGVTiket.Name = "DGVTiket"
        Me.DGVTiket.RowHeadersWidth = 51
        Me.DGVTiket.RowTemplate.Height = 24
        Me.DGVTiket.Size = New System.Drawing.Size(1000, 300)
        Me.DGVTiket.TabIndex = 24
        '
        'id_tiket
        '
        Me.id_tiket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_tiket.FillWeight = 50.0!
        Me.id_tiket.HeaderText = "ID Tiket"
        Me.id_tiket.MinimumWidth = 6
        Me.id_tiket.Name = "id_tiket"
        '
        'id_wahana
        '
        Me.id_wahana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_wahana.FillWeight = 50.0!
        Me.id_wahana.HeaderText = "ID Wahana"
        Me.id_wahana.MinimumWidth = 6
        Me.id_wahana.Name = "id_wahana"
        '
        'jenis_tiket
        '
        Me.jenis_tiket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_tiket.HeaderText = "Jenis Tiket"
        Me.jenis_tiket.MinimumWidth = 6
        Me.jenis_tiket.Name = "jenis_tiket"
        '
        'harga
        '
        Me.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        '
        'stok_tersedia
        '
        Me.stok_tersedia.HeaderText = "Stok Tersedia"
        Me.stok_tersedia.MinimumWidth = 6
        Me.stok_tersedia.Name = "stok_tersedia"
        Me.stok_tersedia.Width = 125
        '
        'TxtStok
        '
        Me.TxtStok.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStok.Location = New System.Drawing.Point(863, 192)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(241, 30)
        Me.TxtStok.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(721, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Stok Tersedia"
        '
        'TxtHarga
        '
        Me.TxtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(863, 136)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(241, 30)
        Me.TxtHarga.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(721, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Harga"
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(976, 308)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(154, 38)
        Me.BtnDelete.TabIndex = 31
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(803, 308)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(154, 38)
        Me.BtnUpdate.TabIndex = 30
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(630, 308)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(154, 38)
        Me.BtnCreate.TabIndex = 29
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'FormTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVTiket)
        Me.Controls.Add(Me.TxtJenisTiket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIdWahana)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIdTiket)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTiket"
        Me.Text = "FormTiket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtJenisTiket As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdWahana As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdTiket As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVTiket As DataGridView
    Friend WithEvents id_tiket As DataGridViewTextBoxColumn
    Friend WithEvents id_wahana As DataGridViewTextBoxColumn
    Friend WithEvents jenis_tiket As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stok_tersedia As DataGridViewTextBoxColumn
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCreate As Button
End Class
