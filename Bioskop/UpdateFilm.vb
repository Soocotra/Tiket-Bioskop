Public Class UpdateFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PBPhoto.Load(MainFilm.dataFilm.GSPhoto)
        PBPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        DTRelease.Format = DateTimePickerFormat.Custom
        DTRelease.CustomFormat = "yyyy/MM/dd"
        TxtNama.Text = MainFilm.dataFilm.GSNama
        RTxtDeks.Text = MainFilm.dataFilm.GSDeks
        TxtDir.Text = MainFilm.dataFilm.GSDir
        TxtDur.Text = MainFilm.dataFilm.GSDur
        TxtPrice.Text = MainFilm.dataFilm.GSPrice


        If String.Compare(MainFilm.dataFilm.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdIndo.Checked = True
        ElseIf String.Compare(MainFilm.dataFilm.GSBahasa, "Bahasa Inggris") = 0 Then
            RdInggris.Checked = True
        ElseIf String.Compare(MainFilm.dataFilm.GSBahasa, "Bahasa Jepang") = 0 Then
            RdJepang.Checked = True
        End If

        For Each Kategori In MainFilm.dataFilm.GSGenre
            If String.Compare(Kategori, "Horror") Then
                CBHorror.Checked = True
            ElseIf String.Compare(Kategori, "Comedy") Then
                CBComedy.Checked = True
            ElseIf String.Compare(Kategori, "Romance") Then
                CBRomance.Checked = True
            End If

        Next
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        MainFilm.dataFilm.GSNama = TxtNama.Text
        MainFilm.dataFilm.GSDeks = RTxtDeks.Text
        MainFilm.dataFilm.GSDir = TxtDir.Text
        MainFilm.dataFilm.GSDur = TxtDur.Text
        MainFilm.dataFilm.GSRelease = DTRelease.Value.ToShortDateString
        MainFilm.dataFilm.GSPrice = TxtPrice.Text

        If RdIndo.Checked Then
            MainFilm.dataFilm.GSBahasa = "Bahasa Indonesia"
        End If
        If RdInggris.Checked Then
            MainFilm.dataFilm.GSBahasa = "Bahasa Inggris"
        End If
        If RdJepang.Checked Then
            MainFilm.dataFilm.GSBahasa = "Bahasa Jepang"
        End If

        If CBComedy.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Comedy")
        End If
        If CBHorror.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Horror")
        End If
        If CBRomance.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Romance")
        End If

        MainFilm.dataFilm.GSPhoto = OpenFilePic.FileName
        MainFilm.dataFilm.GSPhoto = MainFilm.dataFilm.GSPhoto.Replace("\", "/")

        'Dim infoFilm = New InfoFilm()
        ''DaftarKoleksi.LbKoleksiBuku.Items.Add(DaftarKoleksi.dataPerpus.GSnamaKoleksi)
        'infoFilm.Show()

        Dim convertedKoleksi = MainFilm.dataFilm.convertKoleksiToString(MainFilm.dataFilm.GSGenre)
        MainFilm.dataFilm.AddDataKoleksiDatabase(
        MainFilm.dataFilm.GSNama,
        convertedKoleksi,
        MainFilm.dataFilm.GSDeks,
        MainFilm.dataFilm.GSDir,
        MainFilm.dataFilm.GSDur,
        MainFilm.dataFilm.GSRelease,
        MainFilm.dataFilm.GSBahasa,
        MainFilm.dataFilm.GSPrice,
        MainFilm.dataFilm.GSPhoto
        )
        Me.Close()
    End Sub
End Class