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

    Private Sub BTPesan_Click(sender As Object, e As EventArgs) Handles BTPesan.Click
        PostTicket.Show()
    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If DGTicket.SelectedRows.Count < 1 Then
            MessageBox.Show("Pilih jadwal untuk melanjutkan")
        Else
            ticket.GSIDTicket = DGTicket.Item("ID", DGTicket.CurrentRow.Index).Value
            ticket.GSMovie = DGTicket.Item("MOVIE", DGTicket.CurrentRow.Index).Value
            DeleteTicket.Show()
        End If
    End Sub
End Class