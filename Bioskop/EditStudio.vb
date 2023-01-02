Public Class EditStudio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtKapasitas.Text = studio.Data_Studio.GSKapasitas
        TxtHargaKursi.Text = studio.Data_Studio.GSHargaKursi

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        studio.Data_Studio.GSKapasitas = TxtKapasitas.Text.ToString()
        studio.Data_Studio.GSHargaKursi = TxtHargaKursi.Text.ToString()

        studio.Data_Studio.UpdateDataStudioByIDDatabase(studio.selectedTableStudio,
                                                        studio.Data_Studio.GSKapasitas,
                                                        studio.Data_Studio.GSHargaKursi)

        studio.Show()
        Me.Close()

    End Sub

End Class