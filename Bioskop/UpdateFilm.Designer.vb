<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateFilm
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnUpdatePhoto = New System.Windows.Forms.Button()
        Me.GbGenre = New System.Windows.Forms.GroupBox()
        Me.CBRomance = New System.Windows.Forms.CheckBox()
        Me.CBComedy = New System.Windows.Forms.CheckBox()
        Me.CBHorror = New System.Windows.Forms.CheckBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.GBBahasa = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdJepang = New System.Windows.Forms.RadioButton()
        Me.RdIndo = New System.Windows.Forms.RadioButton()
        Me.DTRelease = New System.Windows.Forms.DateTimePicker()
        Me.TxtDur = New System.Windows.Forms.TextBox()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.RTxtDeks = New System.Windows.Forms.RichTextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBPhoto = New System.Windows.Forms.PictureBox()
        Me.OpenFilePic = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GbGenre.SuspendLayout()
        Me.GBBahasa.SuspendLayout()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(617, 389)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(278, 37)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "Perbarui"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnUpdatePhoto
        '
        Me.BtnUpdatePhoto.Location = New System.Drawing.Point(42, 356)
        Me.BtnUpdatePhoto.Name = "BtnUpdatePhoto"
        Me.BtnUpdatePhoto.Size = New System.Drawing.Size(187, 22)
        Me.BtnUpdatePhoto.TabIndex = 36
        Me.BtnUpdatePhoto.Text = "Perbarui Gambar"
        Me.BtnUpdatePhoto.UseVisualStyleBackColor = True
        '
        'GbGenre
        '
        Me.GbGenre.Controls.Add(Me.CBRomance)
        Me.GbGenre.Controls.Add(Me.CBComedy)
        Me.GbGenre.Controls.Add(Me.CBHorror)
        Me.GbGenre.Location = New System.Drawing.Point(327, 145)
        Me.GbGenre.Name = "GbGenre"
        Me.GbGenre.Size = New System.Drawing.Size(196, 113)
        Me.GbGenre.TabIndex = 34
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
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(699, 287)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(196, 23)
        Me.TxtPrice.TabIndex = 33
        '
        'GBBahasa
        '
        Me.GBBahasa.Controls.Add(Me.RdInggris)
        Me.GBBahasa.Controls.Add(Me.RdJepang)
        Me.GBBahasa.Controls.Add(Me.RdIndo)
        Me.GBBahasa.Location = New System.Drawing.Point(699, 153)
        Me.GBBahasa.Name = "GBBahasa"
        Me.GBBahasa.Size = New System.Drawing.Size(196, 113)
        Me.GBBahasa.TabIndex = 32
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
        'DTRelease
        '
        Me.DTRelease.Location = New System.Drawing.Point(699, 100)
        Me.DTRelease.Name = "DTRelease"
        Me.DTRelease.Size = New System.Drawing.Size(196, 23)
        Me.DTRelease.TabIndex = 31
        '
        'TxtDur
        '
        Me.TxtDur.Location = New System.Drawing.Point(327, 405)
        Me.TxtDur.Name = "TxtDur"
        Me.TxtDur.Size = New System.Drawing.Size(196, 23)
        Me.TxtDur.TabIndex = 30
        '
        'TxtDir
        '
        Me.TxtDir.Location = New System.Drawing.Point(327, 356)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(196, 23)
        Me.TxtDir.TabIndex = 29
        '
        'RTxtDeks
        '
        Me.RTxtDeks.Location = New System.Drawing.Point(327, 272)
        Me.RTxtDeks.Name = "RTxtDeks"
        Me.RTxtDeks.Size = New System.Drawing.Size(196, 51)
        Me.RTxtDeks.TabIndex = 28
        Me.RTxtDeks.Text = ""
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(327, 100)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(196, 23)
        Me.TxtNama.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(614, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(614, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Bahasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Duration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(610, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tanggal Rilis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Director"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Deksripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Genre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nama Film"
        '
        'PBPhoto
        '
        Me.PBPhoto.Location = New System.Drawing.Point(42, 103)
        Me.PBPhoto.Name = "PBPhoto"
        Me.PBPhoto.Size = New System.Drawing.Size(187, 236)
        Me.PBPhoto.TabIndex = 35
        Me.PBPhoto.TabStop = False
        '
        'OpenFilePic
        '
        Me.OpenFilePic.FileName = "OpenFilePic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(337, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 40)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Perbarui Data Film"
        '
        'UpdateFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 478)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnUpdatePhoto)
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
        Me.Name = "UpdateFilm"
        Me.Text = "Update Film"
        Me.GbGenre.ResumeLayout(False)
        Me.GbGenre.PerformLayout()
        Me.GBBahasa.ResumeLayout(False)
        Me.GBBahasa.PerformLayout()
        CType(Me.PBPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnUpdatePhoto As Button
    Friend WithEvents PBPhoto As PictureBox
    Friend WithEvents GbGenre As GroupBox
    Friend WithEvents CBRomance As CheckBox
    Friend WithEvents CBComedy As CheckBox
    Friend WithEvents CBHorror As CheckBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents GBBahasa As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdJepang As RadioButton
    Friend WithEvents RdIndo As RadioButton
    Friend WithEvents DTRelease As DateTimePicker
    Friend WithEvents TxtDur As TextBox
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents RTxtDeks As RichTextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFilePic As OpenFileDialog
    Friend WithEvents Label9 As Label
End Class
