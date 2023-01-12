<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusTayang
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
        Me.hapusText = New System.Windows.Forms.Label()
        Me.hapusBtn = New System.Windows.Forms.Button()
        Me.tanggalText = New System.Windows.Forms.Label()
        Me.jadwalText = New System.Windows.Forms.Label()
        Me.filmText = New System.Windows.Forms.Label()
        Me.studioText = New System.Windows.Forms.Label()
        Me.mulaiText = New System.Windows.Forms.Label()
        Me.selesaiText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hapusText
        '
        Me.hapusText.AutoSize = True
        Me.hapusText.Location = New System.Drawing.Point(25, 23)
        Me.hapusText.Name = "hapusText"
        Me.hapusText.Size = New System.Drawing.Size(116, 13)
        Me.hapusText.TabIndex = 0
        Me.hapusText.Text = "Hapus Jadwal Tanggal"
        '
        'hapusBtn
        '
        Me.hapusBtn.Location = New System.Drawing.Point(133, 125)
        Me.hapusBtn.Name = "hapusBtn"
        Me.hapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.hapusBtn.TabIndex = 1
        Me.hapusBtn.Text = "Hapus"
        Me.hapusBtn.UseVisualStyleBackColor = True
        '
        'tanggalText
        '
        Me.tanggalText.AutoSize = True
        Me.tanggalText.Location = New System.Drawing.Point(202, 23)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(42, 13)
        Me.tanggalText.TabIndex = 2
        Me.tanggalText.Text = "tanggal"
        '
        'jadwalText
        '
        Me.jadwalText.AutoSize = True
        Me.jadwalText.Location = New System.Drawing.Point(25, 51)
        Me.jadwalText.Name = "jadwalText"
        Me.jadwalText.Size = New System.Drawing.Size(37, 13)
        Me.jadwalText.TabIndex = 3
        Me.jadwalText.Text = "jadwal"
        '
        'filmText
        '
        Me.filmText.AutoSize = True
        Me.filmText.Location = New System.Drawing.Point(155, 50)
        Me.filmText.Name = "filmText"
        Me.filmText.Size = New System.Drawing.Size(22, 13)
        Me.filmText.TabIndex = 4
        Me.filmText.Text = "film"
        '
        'studioText
        '
        Me.studioText.AutoSize = True
        Me.studioText.Location = New System.Drawing.Point(261, 51)
        Me.studioText.Name = "studioText"
        Me.studioText.Size = New System.Drawing.Size(35, 13)
        Me.studioText.TabIndex = 5
        Me.studioText.Text = "studio"
        '
        'mulaiText
        '
        Me.mulaiText.AutoSize = True
        Me.mulaiText.Location = New System.Drawing.Point(44, 101)
        Me.mulaiText.Name = "mulaiText"
        Me.mulaiText.Size = New System.Drawing.Size(63, 13)
        Me.mulaiText.TabIndex = 6
        Me.mulaiText.Text = "waktu mulai"
        '
        'selesaiText
        '
        Me.selesaiText.AutoSize = True
        Me.selesaiText.Location = New System.Drawing.Point(225, 101)
        Me.selesaiText.Name = "selesaiText"
        Me.selesaiText.Size = New System.Drawing.Size(71, 13)
        Me.selesaiText.TabIndex = 7
        Me.selesaiText.Text = "waktu selesai"
        '
        'HapusTayang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 160)
        Me.Controls.Add(Me.selesaiText)
        Me.Controls.Add(Me.mulaiText)
        Me.Controls.Add(Me.studioText)
        Me.Controls.Add(Me.filmText)
        Me.Controls.Add(Me.jadwalText)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.hapusBtn)
        Me.Controls.Add(Me.hapusText)
        Me.Name = "HapusTayang"
        Me.Text = "Hapus Jadwal Tayang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hapusText As Label
    Friend WithEvents hapusBtn As Button
    Friend WithEvents tanggalText As Label
    Friend WithEvents jadwalText As Label
    Friend WithEvents filmText As Label
    Friend WithEvents studioText As Label
    Friend WithEvents mulaiText As Label
    Friend WithEvents selesaiText As Label
End Class
