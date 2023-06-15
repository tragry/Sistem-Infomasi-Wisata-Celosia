<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemasukan
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
        Me.DGVPemasukan = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_struk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnReload = New System.Windows.Forms.Button()
        CType(Me.DGVPemasukan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Pemasukan Taman Celosia"
        '
        'DGVPemasukan
        '
        Me.DGVPemasukan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPemasukan.BackgroundColor = System.Drawing.Color.White
        Me.DGVPemasukan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPemasukan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id_struk, Me.tanggal, Me.total})
        Me.DGVPemasukan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVPemasukan.Location = New System.Drawing.Point(74, 97)
        Me.DGVPemasukan.Name = "DGVPemasukan"
        Me.DGVPemasukan.RowHeadersWidth = 51
        Me.DGVPemasukan.RowTemplate.Height = 24
        Me.DGVPemasukan.Size = New System.Drawing.Size(1032, 434)
        Me.DGVPemasukan.TabIndex = 26
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.no.FillWeight = 50.0!
        Me.no.HeaderText = "No"
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        '
        'id_struk
        '
        Me.id_struk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_struk.HeaderText = "Id Struk"
        Me.id_struk.MinimumWidth = 6
        Me.id_struk.Name = "id_struk"
        '
        'tanggal
        '
        Me.tanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tanggal.FillWeight = 50.0!
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.MinimumWidth = 6
        Me.tanggal.Name = "tanggal"
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.total.FillWeight = 70.0!
        Me.total.HeaderText = "Total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        '
        'BtnReload
        '
        Me.BtnReload.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReload.Location = New System.Drawing.Point(946, 574)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(160, 38)
        Me.BtnReload.TabIndex = 30
        Me.BtnReload.Text = "Reload Data"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'FormPemasukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.DGVPemasukan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPemasukan"
        Me.Text = "FormPemasukan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVPemasukan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGVPemasukan As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id_struk As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents BtnReload As Button
End Class
