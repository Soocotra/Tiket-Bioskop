Public Class UbahTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'filmCombo.DataSource = Tayang.jadwal.GetDataFilmDatabase()
        'studioCombo.DataSource = Tayang.jadwal.GetDataStudioDatabase()
        tanggalDate.Format = DateTimePickerFormat.Custom
        tanggalDate.CustomFormat = "yyyy/MM/dd"
        masukTime.Format = DateTimePickerFormat.Custom
        masukTime.CustomFormat = "hh:mm:ss"
        selesaiTime.Format = DateTimePickerFormat.Custom
        selesaiTime.CustomFormat = "hh:mm:ss"
        tanggalDate.Value = Tayang.jadwal.GSTanggal
        filmCombo.Text = Tayang.jadwal.GSFilm
        studioCombo.Text = Tayang.jadwal.GSStudio
        masukTime.Value = Tayang.jadwal.GSWaktuMasuk
        selesaiTime.Value = Tayang.jadwal.GSWaktuSelesai

    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        Tayang.jadwal.GSFilm = filmCombo.SelectedItem().ToString()
        Tayang.jadwal.GSStudio = studioCombo.SelectedItem().ToString()
        Tayang.jadwal.GSTanggal = tanggalDate.Value.ToShortDateString
        Tayang.jadwal.GSWaktuMasuk = masukTime.Value.ToLongTimeString
        Tayang.jadwal.GSWaktuSelesai = selesaiTime.Value.ToLongTimeString

        Tayang.jadwal.UpdateDataScheduleByIDDatabase(Tayang.selectedTableSchedule,
                                                     Tayang.jadwal.GSFilm,
                                                     Tayang.jadwal.GSStudio,
                                                     Tayang.jadwal.GSTanggal,
                                                     Tayang.jadwal.GSWaktuMasuk,
                                                     Tayang.jadwal.GSWaktuSelesai)
        Me.Close()
    End Sub
End Class