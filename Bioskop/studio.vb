Public Class studio

    Public Shared Data_Studio As DataStudio
    Public selectedTableStudio As Integer
    Public selectedTableStudioKapasitas As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Data_Studio = New DataStudio

        ' Add any initialization after the InitializeComponent() call.

        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewStudio.DataSource = Data_Studio.GetDataStudioDatabase()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah_studio = New TambahStudio()
        tambah_studio.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedStudio As List(Of String) = studio.Data_Studio.GetDataStudioByIDDatabase(selectedTableStudio)

        studio.Data_Studio.GSKapasitas = selectedStudio(1)
        studio.Data_Studio.GSHargaKursi = selectedStudio(2)

        Dim edit_studio = New EditStudio()
        edit_studio.Show()
    End Sub

    Private Sub studio_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()

    End Sub

    Private Sub DataGridViewStudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStudio.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewStudio.Rows(index)

        selectedTableStudio = selectedRow.Cells(0).Value
        selectedTableStudioKapasitas = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim selectedStudio As List(Of String) = studio.Data_Studio.GetDataStudioByIDDatabase(selectedTableStudio)

        Me.selectedTableStudio = selectedStudio(0)
        Dim hapus_studio = New HapusStudio()

        hapus_studio.LblID.Text = Me.selectedTableStudio
        hapus_studio.Show()

    End Sub

    Private Sub DataGridViewStudio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStudio.CellContentClick

    End Sub
End Class