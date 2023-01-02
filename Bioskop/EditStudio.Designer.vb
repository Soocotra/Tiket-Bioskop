<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudio
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHargaKursi = New System.Windows.Forms.TextBox()
        Me.TxtKapasitas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Rp."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Harga Kursi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kapasitas"
        '
        'TxtHargaKursi
        '
        Me.TxtHargaKursi.Location = New System.Drawing.Point(147, 138)
        Me.TxtHargaKursi.Name = "TxtHargaKursi"
        Me.TxtHargaKursi.Size = New System.Drawing.Size(133, 22)
        Me.TxtHargaKursi.TabIndex = 9
        '
        'TxtKapasitas
        '
        Me.TxtKapasitas.Location = New System.Drawing.Point(147, 70)
        Me.TxtKapasitas.Name = "TxtKapasitas"
        Me.TxtKapasitas.Size = New System.Drawing.Size(133, 22)
        Me.TxtKapasitas.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "EDITING STUDIO"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnEdit.Location = New System.Drawing.Point(116, 206)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(81, 23)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit Studio"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'EditStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 250)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtHargaKursi)
        Me.Controls.Add(Me.TxtKapasitas)
        Me.Name = "EditStudio"
        Me.Text = "EditStudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHargaKursi As TextBox
    Friend WithEvents TxtKapasitas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEdit As Button
End Class
