<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahFilm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.RTxtDeks = New System.Windows.Forms.RichTextBox()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.TxtDur = New System.Windows.Forms.TextBox()
        Me.DTRelease = New System.Windows.Forms.DateTimePicker()
        Me.GBBahasa = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdJepang = New System.Windows.Forms.RadioButton()
        Me.RdIndo = New System.Windows.Forms.RadioButton()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.GbGenre = New System.Windows.Forms.GroupBox()
        Me.CBRomance = New System.Windows.Forms.CheckBox()
        Me.CBComedy = New System.Windows.Forms.CheckBox()
        Me.CBHorror = New System.Windows.Forms.CheckBox()
        Me.BtnTambahPhoto = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.OpenFilePic = New System.Windows.Forms.OpenFileDialog()
        Me.PBPhoto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GBBahasa.SuspendLayout()
        Me.GbGenre.SuspendLayout()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Directur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Deksripsi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(622, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Duration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(622, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Date Release"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(360, 152)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(196, 23)
        Me.TxtNama.TabIndex = 8
        '
        'RTxtDeks
        '
        Me.RTxtDeks.Location = New System.Drawing.Point(360, 331)
        Me.RTxtDeks.Name = "RTxtDeks"
        Me.RTxtDeks.Size = New System.Drawing.Size(196, 51)
        Me.RTxtDeks.TabIndex = 10
        Me.RTxtDeks.Text = ""
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(360, 409)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(196, 23)
        Me.TxtDir.TabIndex = 11
        '
        'TxtDur
        '
        Me.TxtDur.Location = New System.Drawing.Point(360, 456)
        Me.TxtDur.Name = "TxtDur"
        Me.TxtDur.Size = New System.Drawing.Size(196, 23)
        Me.TxtDur.TabIndex = 12
        '
        'DTRelease
        '
        Me.DTRelease.Location = New System.Drawing.Point(707, 152)
        Me.DTRelease.Name = "DTRelease"
        Me.DTRelease.Size = New System.Drawing.Size(196, 23)
        Me.DTRelease.TabIndex = 13
        '
        'GBBahasa
        '
        Me.GBBahasa.Controls.Add(Me.RdInggris)
        Me.GBBahasa.Controls.Add(Me.RdJepang)
        Me.GBBahasa.Controls.Add(Me.RdIndo)
        Me.GBBahasa.Location = New System.Drawing.Point(707, 206)
        Me.GBBahasa.Name = "GBBahasa"
        Me.GBBahasa.Size = New System.Drawing.Size(196, 113)
        Me.GBBahasa.TabIndex = 14
        Me.GBBahasa.TabStop = False
        Me.GBBahasa.Text = "Bahasa"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(17, 80)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(108, 19)
        Me.RdInggris.TabIndex = 2
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdJepang
        '
        Me.RdJepang.AutoSize = True
        Me.RdJepang.Location = New System.Drawing.Point(17, 55)
        Me.RdJepang.Name = "RdJepang"
        Me.RdJepang.Size = New System.Drawing.Size(106, 19)
        Me.RdJepang.TabIndex = 1
        Me.RdJepang.TabStop = True
        Me.RdJepang.Text = "Bahasa Jepang"
        Me.RdJepang.UseVisualStyleBackColor = True
        '
        'RdIndo
        '
        Me.RdIndo.AutoSize = True
        Me.RdIndo.Location = New System.Drawing.Point(17, 31)
        Me.RdIndo.Name = "RdIndo"
        Me.RdIndo.Size = New System.Drawing.Size(124, 19)
        Me.RdIndo.TabIndex = 0
        Me.RdIndo.TabStop = True
        Me.RdIndo.Text = "Bahasa Indonesia"
        Me.RdIndo.UseVisualStyleBackColor = True
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(707, 347)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(196, 23)
        Me.TxtPrice.TabIndex = 15
        '
        'GbGenre
        '
        Me.GbGenre.Controls.Add(Me.CBRomance)
        Me.GbGenre.Controls.Add(Me.CBComedy)
        Me.GbGenre.Controls.Add(Me.CBHorror)
        Me.GbGenre.Location = New System.Drawing.Point(360, 191)
        Me.GbGenre.Name = "GbGenre"
        Me.GbGenre.Size = New System.Drawing.Size(196, 113)
        Me.GbGenre.TabIndex = 15
        Me.GbGenre.TabStop = False
        Me.GbGenre.Text = "Genre"
        '
        'CBRomance
        '
        Me.CBRomance.AutoSize = True
        Me.CBRomance.Location = New System.Drawing.Point(17, 79)
        Me.CBRomance.Name = "CBRomance"
        Me.CBRomance.Size = New System.Drawing.Size(80, 19)
        Me.CBRomance.TabIndex = 2
        Me.CBRomance.Text = "Romance"
        Me.CBRomance.UseVisualStyleBackColor = True
        '
        'CBComedy
        '
        Me.CBComedy.AutoSize = True
        Me.CBComedy.Location = New System.Drawing.Point(17, 54)
        Me.CBComedy.Name = "CBComedy"
        Me.CBComedy.Size = New System.Drawing.Size(74, 19)
        Me.CBComedy.TabIndex = 1
        Me.CBComedy.Text = "Comedy"
        Me.CBComedy.UseVisualStyleBackColor = True
        '
        'CBHorror
        '
        Me.CBHorror.AutoSize = True
        Me.CBHorror.Location = New System.Drawing.Point(17, 30)
        Me.CBHorror.Name = "CBHorror"
        Me.CBHorror.Size = New System.Drawing.Size(67, 19)
        Me.CBHorror.TabIndex = 0
        Me.CBHorror.Text = "Horror"
        Me.CBHorror.UseVisualStyleBackColor = True
        '
        'BtnTambahPhoto
        '
        Me.BtnTambahPhoto.Location = New System.Drawing.Point(36, 416)
        Me.BtnTambahPhoto.Name = "BtnTambahPhoto"
        Me.BtnTambahPhoto.Size = New System.Drawing.Size(223, 37)
        Me.BtnTambahPhoto.TabIndex = 17
        Me.BtnTambahPhoto.Text = "Unggah Gambar"
        Me.BtnTambahPhoto.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(625, 434)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(278, 37)
        Me.BtnTambah.TabIndex = 18
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'OpenFilePic
        '
        Me.OpenFilePic.FileName = "OpenFileDialog1"
        '
        'PBPhoto
        '
        Me.PBPhoto.Location = New System.Drawing.Point(36, 149)
        Me.PBPhoto.Name = "PBPhoto"
        Me.PBPhoto.Size = New System.Drawing.Size(223, 248)
        Me.PBPhoto.TabIndex = 16
        Me.PBPhoto.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 33)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Tambah Data Film"
        '
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 531)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnTambahPhoto)
        Me.Controls.Add(Me.PBPhoto)
        Me.Controls.Add(Me.GbGenre)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.GBBahasa)
        Me.Controls.Add(Me.DTRelease)
        Me.Controls.Add(Me.TxtDur)
        Me.Controls.Add(Me.TxtDir)
        Me.Controls.Add(Me.RTxtDeks)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TambahFilm"
        Me.Text = "Tambah FIlm"
        Me.GBBahasa.ResumeLayout(False)
        Me.GBBahasa.PerformLayout()
        Me.GbGenre.ResumeLayout(False)
        Me.GbGenre.PerformLayout()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents RTxtDeks As RichTextBox
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents TxtDur As TextBox
    Friend WithEvents DTRelease As DateTimePicker
    Friend WithEvents GBBahasa As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdJepang As RadioButton
    Friend WithEvents RdIndo As RadioButton
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents GbGenre As GroupBox
    Friend WithEvents CBRomance As CheckBox
    Friend WithEvents CBComedy As CheckBox
    Friend WithEvents CBHorror As CheckBox
    Friend WithEvents PBPhoto As PictureBox
    Friend WithEvents BtnTambahPhoto As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents OpenFilePic As OpenFileDialog
    Friend WithEvents Label9 As Label
End Class
