Public Class Tayang
    Public Shared jadwal = New TayangClass
    Public Shared selectedTableSchedule
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
        ReloadDataScheduleDatabase()
    End Sub

    Private Sub Tayang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataScheduleDatabase()
    End Sub

    Private Sub ReloadDataScheduleDatabase()
        jadwalGrid.DataSource = jadwal.GetDataScheduleDatabase()
    End Sub

    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        TambahTayang.Show()
    End Sub

    Private Sub ubahBtn_Click(sender As Object, e As EventArgs) Handles ubahBtn.Click
        Dim selectedSchedule As List(Of String) = jadwal.GetDataScheduleByIDDatabase(selectedTableSchedule)

        Tayang.jadwal.GSFilm = selectedSchedule(1)
        Tayang.jadwal.GSStudio = selectedSchedule(2)
        Tayang.jadwal.GSTanggal = selectedSchedule(3)
        Tayang.jadwal.GSWaktuMasuk = selectedSchedule(4)
        Tayang.jadwal.GSWaktuSelesai = selectedSchedule(5)

        Dim formUpdate = New UbahTayang()
        formUpdate.Show()
    End Sub

    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        Dim selectedSchedule As List(Of String) = jadwal.GetDataScheduleByIDDatabase(selectedTableSchedule)

        Tayang.jadwal.GSIdJadwal = selectedSchedule(0)
        Tayang.jadwal.GSFilm = selectedSchedule(1)
        Tayang.jadwal.GSStudio = selectedSchedule(2)
        Tayang.jadwal.GSTanggal = selectedSchedule(3)
        Tayang.jadwal.GSWaktuMasuk = selectedSchedule(4)
        Tayang.jadwal.GSWaktuSelesai = selectedSchedule(5)
        HapusTayang.Show()
    End Sub

    Private Sub jadwalGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles jadwalGrid.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = jadwalGrid.Rows(index)

        selectedTableSchedule = selectedRow.Cells(0).Value
    End Sub
End Class