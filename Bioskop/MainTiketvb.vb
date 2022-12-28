Public Class MainTiketvb

    Public ticket As New Tiket()

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ReloadDataTickets()

    End Sub

    Public Sub ReloadDataTickets()
        DGTicket.DataSource = ticket.index()
    End Sub

    Private Sub DGTicket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTicket.CellContentClick

    End Sub

    Private Sub BTPesan_Click(sender As Object, e As EventArgs) Handles BTPesan.Click
        PostTicket.Show()
    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If DGTicket.SelectedRows.Count < 1 Then
            MessageBox.Show("Pilih jadwal untuk melanjutkan")
        Else
            Dim opt = MessageBox.Show("Hapus Tiket ?", "Delete Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If opt = Windows.Forms.DialogResult.Yes Then
                Dim selectedRow = DGTicket.Item("ID", DGTicket.CurrentRow.Index).Value

                Dim isDeleted = ticket.destroy(selectedRow.ToString)

                If isDeleted Then
                    Dim studioId = DGTicket.Item("STUDIO", DGTicket.CurrentRow.Index).Value
                    Dim selectedMovie = DGTicket.Item("MOVIE", DGTicket.CurrentRow.Index).Value
                    ticket.UpdateSeat(studioId, isIncrease:=True)
                    ReloadDataTickets()
                    PostTicket.ReloadSchedules(selectedMovie)
                    MessageBox.Show("Tiket Berhasil Terhapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Terjadi Kesalahan", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If
    End Sub

    Private Sub BTSignOut_Click(sender As Object, e As EventArgs) Handles BTSignOut.Click
        Me.Close()
        Login.Show()
    End Sub

End Class