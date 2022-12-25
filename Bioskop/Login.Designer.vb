<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LinkRegister = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Cambria", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(697, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME"
        '
        'TBEmail
        '
        Me.TBEmail.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TBEmail.Location = New System.Drawing.Point(659, 296)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(277, 33)
        Me.TBEmail.TabIndex = 1
        Me.TBEmail.Text = "user@example.net"
        Me.TBEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBPassword
        '
        Me.TBPassword.Font = New System.Drawing.Font("Cambria", 13.0!)
        Me.TBPassword.Location = New System.Drawing.Point(659, 393)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(277, 33)
        Me.TBPassword.TabIndex = 2
        Me.TBPassword.Text = "Password"
        Me.TBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.2!)
        Me.Label2.Location = New System.Drawing.Point(656, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.2!)
        Me.Label3.Location = New System.Drawing.Point(656, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.White
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.Font = New System.Drawing.Font("Cambria", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLogin.Location = New System.Drawing.Point(725, 457)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(152, 40)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "Sign In"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LinkRegister
        '
        Me.LinkRegister.AutoSize = True
        Me.LinkRegister.BackColor = System.Drawing.Color.White
        Me.LinkRegister.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRegister.Location = New System.Drawing.Point(859, 271)
        Me.LinkRegister.Name = "LinkRegister"
        Me.LinkRegister.Size = New System.Drawing.Size(80, 17)
        Me.LinkRegister.TabIndex = 6
        Me.LinkRegister.TabStop = True
        Me.LinkRegister.Text = "Create One!"
        '
        'Login
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BackgroundImage = Global.Bioskop.My.Resources.Resources.sl_121019_25870_59_eps_1__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1070, 665)
        Me.Controls.Add(Me.LinkRegister)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1088, 712)
        Me.MinimumSize = New System.Drawing.Size(1088, 712)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LinkRegister As LinkLabel
End Class
