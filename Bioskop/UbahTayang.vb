Public Class UbahTayang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        filmCombo.DataSource = Tayang.jadwal.GetDataFilmDatabase()
        filmCombo.DisplayMember = "nama"
        filmCombo.ValueMember = "id"
        studioCombo.DataSource = Tayang.jadwal.GetDataStudioDatabase()
        studioCombo.DisplayMember = "id"
        studioCombo.ValueMember = "id"

        filmCombo.SelectedValue = Tayang.jadwal.GSFilm
        filmCombo.SelectedValue = Tayang.jadwal.GSStudio
        tanggalDate.Format = DateTimePickerFormat.Custom
        tanggalDate.CustomFormat = "yyyy/MM/dd"
        masukTime.Format = DateTimePickerFormat.Custom
        masukTime.CustomFormat = "hh:mm:ss"
        selesaiTime.Format = DateTimePickerFormat.Custom
        selesaiTime.CustomFormat = "hh:mm:ss"
        tanggalDate.Value = Tayang.jadwal.GSTanggal

        masukTime.Value = Convert.ToDateTime(Tayang.jadwal.GSWaktuMasuk)
        selesaiTime.Value = Convert.ToDateTime(Tayang.jadwal.GSWaktuSelesai)

    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        Tayang.jadwal.GSFilm = filmCombo.SelectedValue.ToString
        Tayang.jadwal.GSStudio = studioCombo.SelectedValue.ToString
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