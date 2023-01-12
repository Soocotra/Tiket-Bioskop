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
        Me.filmCombo = New System.Windows.Forms.ComboBox()
        Me.idJadwal = New System.Windows.Forms.TextBox()
        Me.filmPict = New System.Windows.Forms.PictureBox()
        Me.studioCombo = New System.Windows.Forms.ComboBox()
        Me.filmText = New System.Windows.Forms.Label()
        Me.studioText = New System.Windows.Forms.Label()
        Me.jadwalGrid = New System.Windows.Forms.DataGridView()
        Me.tambahBtn = New System.Windows.Forms.Button()
        Me.ubahBtn = New System.Windows.Forms.Button()
        Me.hapusBtn = New System.Windows.Forms.Button()
        Me.tanggalDate = New System.Windows.Forms.DateTimePicker()
        Me.jadwalLabel = New System.Windows.Forms.Label()
        CType(Me.filmPict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jadwalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filmCombo
        '
        Me.filmCombo.FormattingEnabled = True
        Me.filmCombo.Location = New System.Drawing.Point(27, 63)
        Me.filmCombo.Name = "filmCombo"
        Me.filmCombo.Size = New System.Drawing.Size(213, 21)
        Me.filmCombo.TabIndex = 1
        '
        'idJadwal
        '
        Me.idJadwal.Location = New System.Drawing.Point(26, 24)
        Me.idJadwal.Name = "idJadwal"
        Me.idJadwal.Size = New System.Drawing.Size(81, 20)
        Me.idJadwal.TabIndex = 2
        '
        'filmPict
        '
        Me.filmPict.Location = New System.Drawing.Point(28, 103)
        Me.filmPict.Name = "filmPict"
        Me.filmPict.Size = New System.Drawing.Size(136, 158)
        Me.filmPict.TabIndex = 3
        Me.filmPict.TabStop = False
        '
        'studioCombo
        '
        Me.studioCombo.FormattingEnabled = True
        Me.studioCombo.Location = New System.Drawing.Point(246, 63)
        Me.studioCombo.Name = "studioCombo"
        Me.studioCombo.Size = New System.Drawing.Size(46, 21)
        Me.studioCombo.TabIndex = 4
        '
        'filmText
        '
        Me.filmText.AutoSize = True
        Me.filmText.Location = New System.Drawing.Point(24, 47)
        Me.filmText.Name = "filmText"
        Me.filmText.Size = New System.Drawing.Size(25, 13)
        Me.filmText.TabIndex = 5
        Me.filmText.Text = "Film"
        '
        'studioText
        '
        Me.studioText.AutoSize = True
        Me.studioText.Location = New System.Drawing.Point(243, 47)
        Me.studioText.Name = "studioText"
        Me.studioText.Size = New System.Drawing.Size(37, 13)
        Me.studioText.TabIndex = 6
        Me.studioText.Text = "Studio"
        '
        'jadwalGrid
        '
        Me.jadwalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.jadwalGrid.Location = New System.Drawing.Point(193, 103)
        Me.jadwalGrid.Name = "jadwalGrid"
        Me.jadwalGrid.RowHeadersVisible = False
        Me.jadwalGrid.Size = New System.Drawing.Size(601, 264)
        Me.jadwalGrid.TabIndex = 7
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(296, 381)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 8
        Me.tambahBtn.Text = "Tambah"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'ubahBtn
        '
        Me.ubahBtn.Location = New System.Drawing.Point(377, 381)
        Me.ubahBtn.Name = "ubahBtn"
        Me.ubahBtn.Size = New System.Drawing.Size(75, 23)
        Me.ubahBtn.TabIndex = 9
        Me.ubahBtn.Text = "Ubah"
        Me.ubahBtn.UseVisualStyleBackColor = True
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(458, 381)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 10
        Me.hapusBtn.Text = "Hapus"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'tanggalDate
        '
        Me.tanggalDate.Location = New System.Drawing.Point(113, 24)
        Me.tanggalDate.Name = "tanggalDate"
        Me.tanggalDate.Size = New System.Drawing.Size(179, 20)
        Me.tanggalDate.TabIndex = 11
        '
        'jadwalLabel
        '
        Me.jadwalLabel.AutoSize = True
        Me.jadwalLabel.Location = New System.Drawing.Point(25, 9)
        Me.jadwalLabel.Name = "jadwalLabel"
        Me.jadwalLabel.Size = New System.Drawing.Size(52, 13)
        Me.jadwalLabel.TabIndex = 12
        Me.jadwalLabel.Text = "Id Jadwal"
        '
        'Tayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 416)
        Me.Controls.Add(Me.jadwalLabel)
        Me.Controls.Add(Me.tanggalDate)
        Me.Controls.Add(Me.hapusBtn)
        Me.Controls.Add(Me.ubahBtn)
        Me.Controls.Add(Me.tambahBtn)
        Me.Controls.Add(Me.jadwalGrid)
        Me.Controls.Add(Me.studioText)
        Me.Controls.Add(Me.filmText)
        Me.Controls.Add(Me.studioCombo)
        Me.Controls.Add(Me.filmPict)
        Me.Controls.Add(Me.idJadwal)
        Me.Controls.Add(Me.filmCombo)
        Me.Name = "Tayang"
        Me.Text = "Jadwal Tayang"
        CType(Me.filmPict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jadwalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents filmCombo As ComboBox
    Friend WithEvents idJadwal As TextBox
    Friend WithEvents filmPict As PictureBox
    Friend WithEvents studioCombo As ComboBox
    Friend WithEvents filmText As Label
    Friend WithEvents studioText As Label
    Friend WithEvents jadwalGrid As DataGridView
    Friend WithEvents tambahBtn As Button
    Friend WithEvents ubahBtn As Button
    Friend WithEvents hapusBtn As Button
    Friend WithEvents tanggalDate As DateTimePicker
    Friend WithEvents jadwalLabel As Label
End Class
