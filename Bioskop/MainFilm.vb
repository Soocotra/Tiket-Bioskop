Public Class MainFilm
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambahFilm = New TambahFilm()
        tambahFilm.Show()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In DataFilm.getKoleksiDataTable()
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

    Private Sub DGFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGFilm.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub
End Class