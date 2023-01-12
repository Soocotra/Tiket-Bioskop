Public Class TambahTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        filmCombo.DataSource = Tayang.jadwal.GetDataFilmDatabase()
        studioCombo.DataSource = Tayang.jadwal.GetDataStudioDatabase()
        tanggalDate.Format = DateTimePickerFormat.Custom
        tanggalDate.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        Tayang.jadwal.GSFilm = filmCombo.SelectedItem.ToString()
        Tayang.jadwal.GSStudio = studioCombo.SelectedItem.ToString()
        Tayang.jadwal.GSTanggal = tanggalDate.Value.ToShortDateString
        Tayang.jadwal.GSWaktuMasuk = masukTime.Value.ToLongTimeString
        Tayang.jadwal.GSWaktuSelesai = selesaiTime.Value.ToLongTimeString

        Tayang.jadwal.AddDataScheduleDatabase(Tayang.jadwal.GSFilm,
                                              Tayang.jadwal.GSStudio,
                                              Tayang.jadwal.GSTanggal,
                                              Tayang.jadwal.GSWaktuMasuk,
                                              Tayang.jadwal.GSWaktuSelesai)
        Me.Close()
    End Sub
End Class