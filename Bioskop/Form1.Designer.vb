﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnStudio = New System.Windows.Forms.Button()
        Me.BtnFilm = New System.Windows.Forms.Button()
        Me.BtnSchedule = New System.Windows.Forms.Button()
        Me.BtnTicket = New System.Windows.Forms.Button()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 18.8!)
        Me.Label1.Location = New System.Drawing.Point(249, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Page"
        '
        'BtnStudio
        '
        Me.BtnStudio.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudio.Location = New System.Drawing.Point(78, 169)
        Me.BtnStudio.Name = "BtnStudio"
        Me.BtnStudio.Size = New System.Drawing.Size(153, 34)
        Me.BtnStudio.TabIndex = 1
        Me.BtnStudio.Text = "Menu Studio"
        Me.BtnStudio.UseVisualStyleBackColor = True
        '
        'BtnFilm
        '
        Me.BtnFilm.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFilm.Location = New System.Drawing.Point(249, 169)
        Me.BtnFilm.Name = "BtnFilm"
        Me.BtnFilm.Size = New System.Drawing.Size(153, 34)
        Me.BtnFilm.TabIndex = 2
        Me.BtnFilm.Text = "Menu Film"
        Me.BtnFilm.UseVisualStyleBackColor = True
        '
        'BtnSchedule
        '
        Me.BtnSchedule.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSchedule.Location = New System.Drawing.Point(408, 169)
        Me.BtnSchedule.Name = "BtnSchedule"
        Me.BtnSchedule.Size = New System.Drawing.Size(153, 34)
        Me.BtnSchedule.TabIndex = 3
        Me.BtnSchedule.Text = "Jadwal Tayang"
        Me.BtnSchedule.UseVisualStyleBackColor = True
        '
        'BtnTicket
        '
        Me.BtnTicket.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTicket.Location = New System.Drawing.Point(249, 241)
        Me.BtnTicket.Name = "BtnTicket"
        Me.BtnTicket.Size = New System.Drawing.Size(153, 34)
        Me.BtnTicket.TabIndex = 4
        Me.BtnTicket.Text = "Pesan Tiket"
        Me.BtnTicket.UseVisualStyleBackColor = True
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(12, 54)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(141, 23)
        Me.WelcomeLabel.TabIndex = 5
        Me.WelcomeLabel.Text = "Welcome back, "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(599, 277)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(78, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 24)
        Me.ToolStripMenuItem1.Text = "Logout"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 314)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.BtnTicket)
        Me.Controls.Add(Me.BtnSchedule)
        Me.Controls.Add(Me.BtnFilm)
        Me.Controls.Add(Me.BtnStudio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStudio As Button
    Friend WithEvents BtnFilm As Button
    Friend WithEvents BtnSchedule As Button
    Friend WithEvents BtnTicket As Button
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
