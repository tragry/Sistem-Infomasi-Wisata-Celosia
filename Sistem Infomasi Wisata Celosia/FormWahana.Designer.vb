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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaWahana = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.pic_gambar = New System.Windows.Forms.PictureBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGVWahana = New System.Windows.Forms.DataGridView()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.pic_gambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Wahana Taman CELOSIA"
        '
        'TxtId
        '
        Me.TxtId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.Location = New System.Drawing.Point(210, 132)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(241, 30)
        Me.TxtId.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID "
        '
        'TxtNamaWahana
        '
        Me.TxtNamaWahana.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaWahana.Location = New System.Drawing.Point(210, 188)
        Me.TxtNamaWahana.Name = "TxtNamaWahana"
        Me.TxtNamaWahana.Size = New System.Drawing.Size(241, 30)
        Me.TxtNamaWahana.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Wahana"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(210, 293)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(409, 30)
        Me.TxtKeterangan.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 356)
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
        Me.BtnCreate.Text = "Simpan"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(918, 213)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(154, 38)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(918, 293)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(154, 38)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'pic_gambar
        '
        Me.pic_gambar.BackColor = System.Drawing.Color.White
        Me.pic_gambar.Location = New System.Drawing.Point(210, 356)
        Me.pic_gambar.Name = "pic_gambar"
        Me.pic_gambar.Size = New System.Drawing.Size(241, 50)
        Me.pic_gambar.TabIndex = 23
        Me.pic_gambar.TabStop = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Location = New System.Drawing.Point(465, 356)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(154, 38)
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
        Me.DGVWahana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVWahana.Location = New System.Drawing.Point(72, 462)
        Me.DGVWahana.Name = "DGVWahana"
        Me.DGVWahana.RowHeadersWidth = 51
        Me.DGVWahana.RowTemplate.Height = 24
        Me.DGVWahana.Size = New System.Drawing.Size(1000, 302)
        Me.DGVWahana.TabIndex = 25
        '
        'TxtHarga
        '
        Me.TxtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(210, 239)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(241, 30)
        Me.TxtHarga.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Harga"
        '
        'FormWahana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVWahana)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.pic_gambar)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNamaWahana)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormWahana"
        Me.Text = "FormWahana"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic_gambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVWahana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaWahana As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents pic_gambar As PictureBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DGVWahana As DataGridView
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label6 As Label
End Class
