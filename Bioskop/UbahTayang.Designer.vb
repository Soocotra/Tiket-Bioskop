<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahTayang
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
        Me.ubahBtn = New System.Windows.Forms.Button()
        Me.selesaiTime = New System.Windows.Forms.DateTimePicker()
        Me.selesaiText = New System.Windows.Forms.Label()
        Me.masukTime = New System.Windows.Forms.DateTimePicker()
        Me.studioCombo = New System.Windows.Forms.ComboBox()
        Me.filmCombo = New System.Windows.Forms.ComboBox()
        Me.masukText = New System.Windows.Forms.Label()
        Me.studioText = New System.Windows.Forms.Label()
        Me.filmText = New System.Windows.Forms.Label()
        Me.tanggalText = New System.Windows.Forms.Label()
        Me.tanggalDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'ubahBtn
        '
        Me.ubahBtn.Location = New System.Drawing.Point(111, 190)
        Me.ubahBtn.Name = "ubahBtn"
        Me.ubahBtn.Size = New System.Drawing.Size(75, 23)
        Me.ubahBtn.TabIndex = 22
        Me.ubahBtn.Text = "Ubah"
        Me.ubahBtn.UseVisualStyleBackColor = True
        '
        'selesaiTime
        '
        Me.selesaiTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.selesaiTime.Location = New System.Drawing.Point(155, 152)
        Me.selesaiTime.Name = "selesaiTime"
        Me.selesaiTime.Size = New System.Drawing.Size(81, 20)
        Me.selesaiTime.TabIndex = 21
        '
        'selesaiText
        '
        Me.selesaiText.AutoSize = True
        Me.selesaiText.Location = New System.Drawing.Point(27, 158)
        Me.selesaiText.Name = "selesaiText"
        Me.selesaiText.Size = New System.Drawing.Size(76, 13)
        Me.selesaiText.TabIndex = 20
        Me.selesaiText.Text = "Waktu Selesai"
        '
        'masukTime
        '
        Me.masukTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.masukTime.Location = New System.Drawing.Point(155, 116)
        Me.masukTime.Name = "masukTime"
        Me.masukTime.Size = New System.Drawing.Size(81, 20)
        Me.masukTime.TabIndex = 19
        '
        'studioCombo
        '
        Me.studioCombo.FormattingEnabled = True
        Me.studioCombo.Location = New System.Drawing.Point(155, 82)
        Me.studioCombo.Name = "studioCombo"
        Me.studioCombo.Size = New System.Drawing.Size(53, 21)
        Me.studioCombo.TabIndex = 18
        '
        'filmCombo
        '
        Me.filmCombo.FormattingEnabled = True
        Me.filmCombo.Location = New System.Drawing.Point(155, 49)
        Me.filmCombo.Name = "filmCombo"
        Me.filmCombo.Size = New System.Drawing.Size(121, 21)
        Me.filmCombo.TabIndex = 17
        '
        'masukText
        '
        Me.masukText.AutoSize = True
        Me.masukText.Location = New System.Drawing.Point(27, 122)
        Me.masukText.Name = "masukText"
        Me.masukText.Size = New System.Drawing.Size(74, 13)
        Me.masukText.TabIndex = 16
        Me.masukText.Text = "Waktu Masuk"
        '
        'studioText
        '
        Me.studioText.AutoSize = True
        Me.studioText.Location = New System.Drawing.Point(27, 85)
        Me.studioText.Name = "studioText"
        Me.studioText.Size = New System.Drawing.Size(37, 13)
        Me.studioText.TabIndex = 15
        Me.studioText.Text = "Studio"
        '
        'filmText
        '
        Me.filmText.AutoSize = True
        Me.filmText.Location = New System.Drawing.Point(27, 52)
        Me.filmText.Name = "filmText"
        Me.filmText.Size = New System.Drawing.Size(56, 13)
        Me.filmText.TabIndex = 14
        Me.filmText.Text = "Nama Film"
        '
        'tanggalText
        '
        Me.tanggalText.AutoSize = True
        Me.tanggalText.Location = New System.Drawing.Point(27, 22)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(85, 13)
        Me.tanggalText.TabIndex = 13
        Me.tanggalText.Text = "Tanggal Tayang"
        '
        'tanggalDate
        '
        Me.tanggalDate.Location = New System.Drawing.Point(155, 16)
        Me.tanggalDate.Name = "tanggalDate"
        Me.tanggalDate.Size = New System.Drawing.Size(121, 20)
        Me.tanggalDate.TabIndex = 12
        '
        'UbahTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 225)
        Me.Controls.Add(Me.ubahBtn)
        Me.Controls.Add(Me.selesaiTime)
        Me.Controls.Add(Me.selesaiText)
        Me.Controls.Add(Me.masukTime)
        Me.Controls.Add(Me.studioCombo)
        Me.Controls.Add(Me.filmCombo)
        Me.Controls.Add(Me.masukText)
        Me.Controls.Add(Me.studioText)
        Me.Controls.Add(Me.filmText)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.tanggalDate)
        Me.Name = "UbahTayang"
        Me.Text = "Ubah Jadwal Tayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ubahBtn As Button
    Friend WithEvents selesaiTime As DateTimePicker
    Friend WithEvents selesaiText As Label
    Friend WithEvents masukTime As DateTimePicker
    Friend WithEvents studioCombo As ComboBox
    Friend WithEvents filmCombo As ComboBox
    Friend WithEvents masukText As Label
    Friend WithEvents studioText As Label
    Friend WithEvents filmText As Label
    Friend WithEvents tanggalText As Label
    Friend WithEvents tanggalDate As DateTimePicker
End Class
