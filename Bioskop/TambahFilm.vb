Public Class TambahFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DTRelease.Format = DateTimePickerFormat.Custom
        DTRelease.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
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

        If CBHorror.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Horror")
        End If
        If CBComedy.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Comedy")
        End If
        If CBRomance.Checked() Then
            MainFilm.dataFilm.GSGenre.Add("Romance")
        End If

        'Dim infoFilm = New InfoFilm()
        ''DaftarKoleksi.LbKoleksiBuku.Items.Add(DaftarKoleksi.dataPerpus.GSnamaKoleksi)
        'infoFilm.Show()

        Dim convertedGenre = MainFilm.dataFilm.convertKoleksiToString(MainFilm.dataFilm.GSGenre)
        MainFilm.dataFilm.AddDataKoleksiDatabase(
        MainFilm.dataFilm.GSNama,
        convertedGenre,
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

    Private Sub BtnTambahPhoto_Click(sender As Object, e As EventArgs) Handles BtnTambahPhoto.Click
        OpenFilePic.Title = "Buka Picture"
        OpenFilePic.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.JPEG|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFilePic.ShowDialog()
        PBPhoto.Load(OpenFilePic.FileName)
        PBPhoto.SizeMode = PictureBoxSizeMode.StretchImage

        MainFilm.dataFilm.GSPhoto = OpenFilePic.FileName
        MessageBox.Show(OpenFilePic.FileName)
        MainFilm.dataFilm.GSPhoto = MainFilm.dataFilm.GSPhoto.Replace("\", "/")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class