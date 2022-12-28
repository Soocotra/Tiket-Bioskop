<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostTicket
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBFilm = New System.Windows.Forms.ComboBox()
        Me.DGSchedule = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTPesan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(460, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesan Tiket"
        '
        'CBFilm
        '
        Me.CBFilm.FormattingEnabled = True
        Me.CBFilm.Location = New System.Drawing.Point(26, 195)
        Me.CBFilm.Name = "CBFilm"
        Me.CBFilm.Size = New System.Drawing.Size(263, 23)
        Me.CBFilm.TabIndex = 1
        '
        'DGSchedule
        '
        Me.DGSchedule.AllowUserToAddRows = False
        Me.DGSchedule.AllowUserToDeleteRows = False
        Me.DGSchedule.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Format = "g"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DGSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGSchedule.ColumnHeadersHeight = 29
        Me.DGSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSchedule.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGSchedule.Location = New System.Drawing.Point(295, 195)
        Me.DGSchedule.MultiSelect = False
        Me.DGSchedule.Name = "DGSchedule"
        Me.DGSchedule.ReadOnly = True
        Me.DGSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 11.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DGSchedule.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGSchedule.RowTemplate.Height = 24
        Me.DGSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSchedule.Size = New System.Drawing.Size(796, 230)
        Me.DGSchedule.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pilih Film"
        '
        'BTPesan
        '
        Me.BTPesan.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTPesan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTPesan.Location = New System.Drawing.Point(295, 451)
        Me.BTPesan.Name = "BTPesan"
        Me.BTPesan.Size = New System.Drawing.Size(796, 48)
        Me.BTPesan.TabIndex = 4
        Me.BTPesan.Text = "Pesan"
        Me.BTPesan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(587, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jadwal yang Tersedia"
        '
        'PostTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 521)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTPesan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGSchedule)
        Me.Controls.Add(Me.CBFilm)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1121, 568)
        Me.MinimumSize = New System.Drawing.Size(1121, 568)
        Me.Name = "PostTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PostTicket"
        CType(Me.DGSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBFilm As ComboBox
    Friend WithEvents DGSchedule As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BTPesan As Button
    Friend WithEvents Label3 As Label
End Class
