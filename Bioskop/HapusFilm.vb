Public Class HapusFilm
    Private Sub HapusFilm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblNamafilm.Text = MainFilm.selectedTableKoleksiNama
    End Sub

    Private Sub BtnKonfimHapus_Click(sender As Object, e As EventArgs) Handles BtnKonfimHapus.Click
        MainFilm.dataFilm.DeleteDataKoleksiByIdDatabase(MainFilm.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class