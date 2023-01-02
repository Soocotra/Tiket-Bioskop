<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahStudio
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
        Me.TxtKapasitas = New System.Windows.Forms.TextBox()
        Me.TxtHargaKursi = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtKapasitas
        '
        Me.TxtKapasitas.Location = New System.Drawing.Point(153, 55)
        Me.TxtKapasitas.Name = "TxtKapasitas"
        Me.TxtKapasitas.Size = New System.Drawing.Size(133, 22)
        Me.TxtKapasitas.TabIndex = 2
        '
        'TxtHargaKursi
        '
        Me.TxtHargaKursi.Location = New System.Drawing.Point(153, 123)
        Me.TxtHargaKursi.Name = "TxtHargaKursi"
        Me.TxtHargaKursi.Size = New System.Drawing.Size(133, 22)
        Me.TxtHargaKursi.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnTambah.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.Black
        Me.BtnTambah.Location = New System.Drawing.Point(122, 204)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah "
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kapasitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga Kursi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rp."
        '
        'TambahStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 256)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtHargaKursi)
        Me.Controls.Add(Me.TxtKapasitas)
        Me.Name = "TambahStudio"
        Me.Text = "TambahStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKapasitas As TextBox
    Friend WithEvents TxtHargaKursi As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
