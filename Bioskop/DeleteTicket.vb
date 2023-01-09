Public Class DeleteTicket

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        IDLabel.Text = MainTiketvb.ticket.GSIDTicket

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        Dim isDeleted = MainTiketvb.ticket.destroy(IDLabel.Text.ToString)

        If isDeleted Then
            Dim selectedMovie = MainTiketvb.ticket.GSMovie
            MainTiketvb.ReloadDataTickets()
            PostTicket.ReloadSchedules(selectedMovie)
            Me.Close()
        Else
            MessageBox.Show("Terjadi Kesalahan", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class