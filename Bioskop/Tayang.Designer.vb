<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tayang
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
        Me.filmPict = New System.Windows.Forms.PictureBox()
        Me.jadwalGrid = New System.Windows.Forms.DataGridView()
        Me.tambahBtn = New System.Windows.Forms.Button()
        Me.ubahBtn = New System.Windows.Forms.Button()
        Me.hapusBtn = New System.Windows.Forms.Button()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.filmPict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jadwalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filmPict
        '
        Me.filmPict.Location = New System.Drawing.Point(35, 127)
        Me.filmPict.Margin = New System.Windows.Forms.Padding(4)
        Me.filmPict.Name = "filmPict"
        Me.filmPict.Size = New System.Drawing.Size(185, 239)
        Me.filmPict.TabIndex = 3
        Me.filmPict.TabStop = False
        '
        'jadwalGrid
        '
        Me.jadwalGrid.AllowUserToAddRows = False
        Me.jadwalGrid.AllowUserToDeleteRows = False
        Me.jadwalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.jadwalGrid.Location = New System.Drawing.Point(257, 127)
        Me.jadwalGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.jadwalGrid.Name = "jadwalGrid"
        Me.jadwalGrid.ReadOnly = True
        Me.jadwalGrid.RowHeadersVisible = False
        Me.jadwalGrid.RowHeadersWidth = 51
        Me.jadwalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.jadwalGrid.Size = New System.Drawing.Size(801, 325)
        Me.jadwalGrid.TabIndex = 7
        '
        'tambahBtn
        '
        Me.tambahBtn.BackColor = System.Drawing.Color.ForestGreen
        Me.tambahBtn.FlatAppearance.BorderSize = 0
        Me.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tambahBtn.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambahBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tambahBtn.Location = New System.Drawing.Point(473, 471)
        Me.tambahBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(225, 28)
        Me.tambahBtn.TabIndex = 8
        Me.tambahBtn.Text = "Tambah"
        Me.tambahBtn.UseVisualStyleBackColor = False
        '
        'ubahBtn
        '
        Me.ubahBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.ubahBtn.FlatAppearance.BorderSize = 0
        Me.ubahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ubahBtn.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubahBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ubahBtn.Location = New System.Drawing.Point(706, 469)
        Me.ubahBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ubahBtn.Name = "ubahBtn"
        Me.ubahBtn.Size = New System.Drawing.Size(239, 28)
        Me.ubahBtn.TabIndex = 9
        Me.ubahBtn.Text = "Ubah"
        Me.ubahBtn.UseVisualStyleBackColor = False
        '
        'hapusBtn
        '
        Me.hapusBtn.BackColor = System.Drawing.Color.Crimson
        Me.hapusBtn.FlatAppearance.BorderSize = 0
        Me.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapusBtn.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hapusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hapusBtn.Location = New System.Drawing.Point(953, 469)
        Me.hapusBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.Size = New System.Drawing.Size(105, 28)
        Me.hapusBtn.TabIndex = 10
        Me.hapusBtn.Text = "Hapus"
        Me.hapusBtn.UseVisualStyleBackColor = False
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoEllipsis = True
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelJudul.Location = New System.Drawing.Point(31, 370)
        Me.LabelJudul.MaximumSize = New System.Drawing.Size(181, 21)
        Me.LabelJudul.MinimumSize = New System.Drawing.Size(51, 21)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(51, 21)
        Me.LabelJudul.TabIndex = 13
        Me.LabelJudul.Text = "Judul"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(415, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Form Jadwal Tayang"
        '
        'Tayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelJudul)
        Me.Controls.Add(Me.hapusBtn)
        Me.Controls.Add(Me.ubahBtn)
        Me.Controls.Add(Me.tambahBtn)
        Me.Controls.Add(Me.jadwalGrid)
        Me.Controls.Add(Me.filmPict)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tayang"
        Me.Text = "Jadwal Tayang"
        CType(Me.filmPict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jadwalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents filmPict As PictureBox
    Friend WithEvents jadwalGrid As DataGridView
    Friend WithEvents tambahBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents hapusBtn As Button
    Friend WithEvents LabelJudul As Label
    Friend WithEvents Label1 As Label
End Class
