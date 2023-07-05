<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemasukan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVPemasukan = New System.Windows.Forms.DataGridView()
        CType(Me.DGVPemasukan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 46)
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
        Me.DGVPemasukan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVPemasukan.Location = New System.Drawing.Point(96, 113)
        Me.DGVPemasukan.Name = "DGVPemasukan"
        Me.DGVPemasukan.RowHeadersWidth = 51
        Me.DGVPemasukan.RowTemplate.Height = 24
        Me.DGVPemasukan.Size = New System.Drawing.Size(993, 557)
        Me.DGVPemasukan.TabIndex = 26
        '
        'FormPemasukan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 800)
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
End Class
