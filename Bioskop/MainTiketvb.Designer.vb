<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainTiketvb
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGTicket = New System.Windows.Forms.DataGridView()
        Me.BTSignOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTPesan = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        CType(Me.DGTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTicket
        '
        Me.DGTicket.AllowUserToAddRows = False
        Me.DGTicket.AllowUserToDeleteRows = False
        Me.DGTicket.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Format = "g"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DGTicket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGTicket.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGTicket.ColumnHeadersHeight = 29
        Me.DGTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGTicket.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGTicket.Location = New System.Drawing.Point(230, 103)
        Me.DGTicket.MultiSelect = False
        Me.DGTicket.Name = "DGTicket"
        Me.DGTicket.ReadOnly = True
        Me.DGTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 11.0!)
        Me.DGTicket.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGTicket.RowTemplate.Height = 24
        Me.DGTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGTicket.Size = New System.Drawing.Size(754, 436)
        Me.DGTicket.TabIndex = 0
        '
        'BTSignOut
        '
        Me.BTSignOut.BackColor = System.Drawing.Color.Transparent
        Me.BTSignOut.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSignOut.Location = New System.Drawing.Point(23, 661)
        Me.BTSignOut.Name = "BTSignOut"
        Me.BTSignOut.Size = New System.Drawing.Size(167, 36)
        Me.BTSignOut.TabIndex = 1
        Me.BTSignOut.Text = "Sign Out"
        Me.BTSignOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(37, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ticket Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Bioskop.My.Resources.Resources.image_removebg_preview__7_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.Bioskop.My.Resources.Resources.image_removebg_preview__7_
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 156)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BTPesan
        '
        Me.BTPesan.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTPesan.FlatAppearance.BorderSize = 0
        Me.BTPesan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTPesan.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTPesan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTPesan.Location = New System.Drawing.Point(230, 64)
        Me.BTPesan.Name = "BTPesan"
        Me.BTPesan.Size = New System.Drawing.Size(754, 33)
        Me.BTPesan.TabIndex = 5
        Me.BTPesan.Text = "Pesan Tiket"
        Me.BTPesan.UseVisualStyleBackColor = False
        '
        'BTDelete
        '
        Me.BTDelete.BackColor = System.Drawing.Color.Red
        Me.BTDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTDelete.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTDelete.Location = New System.Drawing.Point(847, 545)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(137, 33)
        Me.BTDelete.TabIndex = 6
        Me.BTDelete.Text = "Delete"
        Me.BTDelete.UseVisualStyleBackColor = False
        '
        'MainTiketvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bioskop.My.Resources.Resources.main_ticket_background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1008, 728)
        Me.Controls.Add(Me.BTDelete)
        Me.Controls.Add(Me.BTPesan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTSignOut)
        Me.Controls.Add(Me.DGTicket)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1026, 775)
        Me.MinimumSize = New System.Drawing.Size(1026, 775)
        Me.Name = "MainTiketvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainTiketvb"
        CType(Me.DGTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGTicket As DataGridView
    Friend WithEvents BTSignOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTPesan As Button
    Friend WithEvents BTDelete As Button
End Class
