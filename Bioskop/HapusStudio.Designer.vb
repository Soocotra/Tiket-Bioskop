<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusStudio
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblStudio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnHapus.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(124, 179)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(100, 28)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.Color.IndianRed
        Me.LblID.Location = New System.Drawing.Point(206, 95)
        Me.LblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(46, 36)
        Me.LblID.TabIndex = 4
        Me.LblID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Ingin Menghapus Studio Data Studio"
        '
        'LblStudio
        '
        Me.LblStudio.AutoSize = True
        Me.LblStudio.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudio.ForeColor = System.Drawing.Color.IndianRed
        Me.LblStudio.Location = New System.Drawing.Point(91, 95)
        Me.LblStudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStudio.Name = "LblStudio"
        Me.LblStudio.Size = New System.Drawing.Size(121, 36)
        Me.LblStudio.TabIndex = 6
        Me.LblStudio.Text = "STUDIO"
        '
        'HapusStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 230)
        Me.Controls.Add(Me.LblStudio)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusStudio"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblStudio As Label
End Class
