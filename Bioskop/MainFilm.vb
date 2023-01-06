Public Class MainFilm
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Shared dataFilm As DataFilm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        dataFilm = New DataFilm()
        ReloadDataTableDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DGFilm.DataSource = dataFilm.GetDataKoleksiDatabase()
    End Sub


    Public Sub UpdateDataTableArrayList()
        'DGFilm.Rows.Clear()
        For Each rowKoleksi In dataFilm.getKoleksiDataTable()
            Dim dataTable As String() = {
                rowKoleksi(0),
                rowKoleksi(1),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(2),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9)}
            DGFilm.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub DaftarKoleksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DGFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGFilm.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim dataSelected As List(Of String) = dataFilm.GetDataKoleksiByIdDatabase(selectedTableKoleksi)
        dataFilm.GSNama = dataSelected(1)
        dataFilm.GSDeks = dataSelected(3)
        dataFilm.GSDir = dataSelected(4)
        dataFilm.GSDur = dataSelected(5)
        dataFilm.GSRelease = dataSelected(6)
        dataFilm.GSBahasa = dataSelected(7)
        dataFilm.GSPrice = dataSelected(8)
        dataFilm.GSPhoto = dataSelected(9)

        Dim data_Koleksi As List(Of String) = dataFilm.convertStringToKoleksi(dataSelected(2))


        Dim updateFilm = New UpdateFilm()
        updateFilm.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapusFilm = New HapusFilm()
        hapusFilm.Show()
    End Sub
End Class