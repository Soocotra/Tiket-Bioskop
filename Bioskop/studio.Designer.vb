﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studio))
        Me.DataGridViewStudio = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kapasitas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_kursi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudio
        '
        Me.DataGridViewStudio.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.kapasitas, Me.harga_kursi})
        Me.DataGridViewStudio.Location = New System.Drawing.Point(25, 25)
        Me.DataGridViewStudio.Name = "DataGridViewStudio"
        Me.DataGridViewStudio.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewStudio.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewStudio.RowTemplate.Height = 24
        Me.DataGridViewStudio.Size = New System.Drawing.Size(430, 150)
        Me.DataGridViewStudio.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 125
        '
        'kapasitas
        '
        Me.kapasitas.HeaderText = "Kapasitas "
        Me.kapasitas.MinimumWidth = 6
        Me.kapasitas.Name = "kapasitas"
        Me.kapasitas.Width = 125
        '
        'harga_kursi
        '
        Me.harga_kursi.HeaderText = "Harga Kursi"
        Me.harga_kursi.MinimumWidth = 6
        Me.harga_kursi.Name = "harga_kursi"
        Me.harga_kursi.Width = 125
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.Maroon
        Me.BtnTambah.Location = New System.Drawing.Point(25, 223)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(121, 223)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.Maroon
        Me.BtnHapus.Location = New System.Drawing.Point(215, 223)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(484, 269)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridViewStudio)
        Me.Name = "studio"
        Me.Text = "studio"
        CType(Me.DataGridViewStudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewStudio As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents kapasitas As DataGridViewTextBoxColumn
    Friend WithEvents harga_kursi As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
End Class
