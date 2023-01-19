Public Class Form1
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        MenuWelcome.Text = MenuWelcome.Text + " " + Login.Users.getName


    End Sub

    Private Sub BtnStudio_Click(sender As Object, e As EventArgs) Handles BtnStudio.Click
        studio.Show()
    End Sub

    Private Sub BtnFilm_Click(sender As Object, e As EventArgs) Handles BtnFilm.Click
        MainFilm.Show()
    End Sub

    Private Sub BtnSchedule_Click(sender As Object, e As EventArgs) Handles BtnSchedule.Click
        Tayang.Show()
    End Sub

    Private Sub BtnTicket_Click(sender As Object, e As EventArgs) Handles BtnTicket.Click
        MainTiketvb.Show()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
        Login.TBEmail.Text = "user@example.net"
        Login.TBPassword.Text = ""
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub
End Class
