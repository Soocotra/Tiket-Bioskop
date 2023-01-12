<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTayang
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
        Me.tanggalDate = New System.Windows.Forms.DateTimePicker()
        Me.tanggalText = New System.Windows.Forms.Label()
        Me.filmText = New System.Windows.Forms.Label()
        Me.studioText = New System.Windows.Forms.Label()
        Me.masukText = New System.Windows.Forms.Label()
        Me.filmCombo = New System.Windows.Forms.ComboBox()
        Me.studioCombo = New System.Windows.Forms.ComboBox()
        Me.masukTime = New System.Windows.Forms.DateTimePicker()
        Me.selesaiTime = New System.Windows.Forms.DateTimePicker()
        Me.selesaiText = New System.Windows.Forms.Label()
        Me.tambahBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tanggalDate
        '
        Me.tanggalDate.Location = New System.Drawing.Point(154, 16)
        Me.tanggalDate.Name = "tanggalDate"
        Me.tanggalDate.Size = New System.Drawing.Size(121, 20)
        Me.tanggalDate.TabIndex = 0
        '
        'tanggalText
        '
        Me.tanggalText.AutoSize = True
        Me.tanggalText.Location = New System.Drawing.Point(26, 22)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(85, 13)
        Me.tanggalText.TabIndex = 1
        Me.tanggalText.Text = "Tanggal Tayang"
        '
        'filmText
        '
        Me.filmText.AutoSize = True
        Me.filmText.Location = New System.Drawing.Point(26, 52)
        Me.filmText.Name = "filmText"
        Me.filmText.Size = New System.Drawing.Size(56, 13)
        Me.filmText.TabIndex = 2
        Me.filmText.Text = "Nama Film"
        '
        'studioText
        '
        Me.studioText.AutoSize = True
        Me.studioText.Location = New System.Drawing.Point(26, 85)
        Me.studioText.Name = "studioText"
        Me.studioText.Size = New System.Drawing.Size(37, 13)
        Me.studioText.TabIndex = 3
        Me.studioText.Text = "Studio"
        '
        'masukText
        '
        Me.masukText.AutoSize = True
        Me.masukText.Location = New System.Drawing.Point(26, 122)
        Me.masukText.Name = "masukText"
        Me.masukText.Size = New System.Drawing.Size(74, 13)
        Me.masukText.TabIndex = 4
        Me.masukText.Text = "Waktu Masuk"
        '
        'filmCombo
        '
        Me.filmCombo.FormattingEnabled = True
        Me.filmCombo.Location = New System.Drawing.Point(154, 49)
        Me.filmCombo.Name = "filmCombo"
        Me.filmCombo.Size = New System.Drawing.Size(121, 21)
        Me.filmCombo.TabIndex = 6
        '
        'studioCombo
        '
        Me.studioCombo.FormattingEnabled = True
        Me.studioCombo.Location = New System.Drawing.Point(154, 82)
        Me.studioCombo.Name = "studioCombo"
        Me.studioCombo.Size = New System.Drawing.Size(53, 21)
        Me.studioCombo.TabIndex = 7
        '
        'masukTime
        '
        Me.masukTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.masukTime.Location = New System.Drawing.Point(154, 116)
        Me.masukTime.Name = "masukTime"
        Me.masukTime.Size = New System.Drawing.Size(81, 20)
        Me.masukTime.TabIndex = 8
        '
        'selesaiTime
        '
        Me.selesaiTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.selesaiTime.Location = New System.Drawing.Point(154, 152)
        Me.selesaiTime.Name = "selesaiTime"
        Me.selesaiTime.Size = New System.Drawing.Size(81, 20)
        Me.selesaiTime.TabIndex = 10
        '
        'selesaiText
        '
        Me.selesaiText.AutoSize = True
        Me.selesaiText.Location = New System.Drawing.Point(26, 158)
        Me.selesaiText.Name = "selesaiText"
        Me.selesaiText.Size = New System.Drawing.Size(76, 13)
        Me.selesaiText.TabIndex = 9
        Me.selesaiText.Text = "Waktu Selesai"
        '
        'tambahBtn
        '
        Me.tambahBtn.Location = New System.Drawing.Point(110, 190)
        Me.tambahBtn.Name = "tambahBtn"
        Me.tambahBtn.Size = New System.Drawing.Size(75, 23)
        Me.tambahBtn.TabIndex = 11
        Me.tambahBtn.Text = "Tambah"
        Me.tambahBtn.UseVisualStyleBackColor = True
        '
        'TambahTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 226)
        Me.Controls.Add(Me.tambahBtn)
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
        Me.Name = "TambahTayang"
        Me.Text = "Tambah Jadwal Tayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tanggalDate As DateTimePicker
    Friend WithEvents tanggalText As Label
    Friend WithEvents filmText As Label
    Friend WithEvents studioText As Label
    Friend WithEvents masukText As Label
    Friend WithEvents filmCombo As ComboBox
    Friend WithEvents studioCombo As ComboBox
    Friend WithEvents masukTime As DateTimePicker
    Friend WithEvents selesaiTime As DateTimePicker
    Friend WithEvents selesaiText As Label
    Friend WithEvents tambahBtn As Button
End Class
