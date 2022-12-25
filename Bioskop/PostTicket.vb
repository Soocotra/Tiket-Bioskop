Public Class PostTicket

    Public Shared ticketStuff As New Tiket
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        CBFilm.Items.Add(ticketStuff.GetFilm())
    End Sub
    Private Sub CBFilm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFilm.SelectedIndexChanged
        Dim selectedMovie = CBFilm.SelectedItem.ToString
        ReloadSchedules(selectedMovie)
    End Sub

    Private Sub BTPesan_Click(sender As Object, e As EventArgs) Handles BTPesan.Click
        If DGSchedule.SelectedRows.Count < 1 Then
            MessageBox.Show("Pilih jadwal untuk melanjutkan")
        Else
            Dim scheduleId = DGSchedule.Item("ID", DGSchedule.CurrentRow.Index).Value
            Dim price = DGSchedule.Item("TOTAL HARGA", DGSchedule.CurrentRow.Index).Value
            price = price.ToString.Substring(3, price.ToString.Length() - 3)

            Dim isPosted = ticketStuff.postTicket(scheduleId.ToString, price.ToString)

            Dim msg = MessageBox.Show("Yakin untuk memesan tiket ?", "Pesan Tiket", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If msg = Windows.Forms.DialogResult.Yes Then
                If isPosted Then
                    Dim studioId = DGSchedule.Item("STUDIO", DGSchedule.CurrentRow.Index).Value
                    ticketStuff.UpdateSeat(studioId, isIncrease:=False)
                    MainTiketvb.ReloadDataTickets()
                    ReloadSchedules(CBFilm.SelectedItem.ToString)
                    MessageBox.Show("Tiket berhasil dipesan !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Terjadi Kesalahan", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Public Sub ReloadSchedules(selectedMovie As String)
        DGSchedule.DataSource = ticketStuff.GetSchedules(selectedMovie)
    End Sub

End Class