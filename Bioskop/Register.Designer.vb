<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBConfPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.Location = New System.Drawing.Point(80, 277)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(179, 32)
        Me.BtnRegister.TabIndex = 5
        Me.BtnRegister.Text = "Sign Up"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Register"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TBName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TBConfPassword)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TBPassword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnRegister)
        Me.Panel1.Controls.Add(Me.TBEmail)
        Me.Panel1.Location = New System.Drawing.Point(303, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 316)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(145, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name"
        '
        'TBName
        '
        Me.TBName.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.TBName.Location = New System.Drawing.Point(81, 70)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(179, 23)
        Me.TBName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(102, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Password"
        '
        'TBConfPassword
        '
        Me.TBConfPassword.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.TBConfPassword.Location = New System.Drawing.Point(80, 240)
        Me.TBConfPassword.Name = "TBConfPassword"
        Me.TBConfPassword.Size = New System.Drawing.Size(179, 23)
        Me.TBConfPassword.TabIndex = 4
        Me.TBConfPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(134, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(146, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Email"
        '
        'TBPassword
        '
        Me.TBPassword.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.TBPassword.Location = New System.Drawing.Point(80, 182)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(179, 23)
        Me.TBPassword.TabIndex = 3
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'TBEmail
        '
        Me.TBEmail.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.TBEmail.Location = New System.Drawing.Point(80, 127)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(179, 23)
        Me.TBEmail.TabIndex = 2
        '
        'Register
        '
        Me.AcceptButton = Me.BtnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bioskop.My.Resources.Resources.register_background1
        Me.ClientSize = New System.Drawing.Size(890, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximumSize = New System.Drawing.Size(906, 599)
        Me.MinimumSize = New System.Drawing.Size(906, 599)
        Me.Name = "Register"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TBConfPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBName As TextBox
End Class
