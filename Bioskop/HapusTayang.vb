Public Class HapusTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jadwalText.Text = Tayang.jadwal.GSIdJadwal
        tanggalText.Text = Tayang.jadwal.GSTanggal
        filmText.Text = Tayang.jadwal.GSFilm
        studioText.Text = Tayang.jadwal.GSStudio
        mulaiText.Text = Convert.ToDateTime(Tayang.jadwal.GSWaktuMasuk)
        selesaiText.Text = Convert.ToDateTime(Tayang.jadwal.GSWaktuSelesai)
    End Sub
    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        Tayang.jadwal.DeleteDataScheduleByIDDatabase(Tayang.selectedTableSchedule)

        Me.Close()
    End Sub
End Class