Public Class TambahStudio

    'Private Sub TxtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtID.KeyPress
    '    If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
    '        e.Handled = True
    '        MessageBox.Show("Please Insert Number Only")
    '    End If

    'End Sub

    Private Sub TxtKapasitas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKapasitas.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    Private Sub TxtHargaKursi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaKursi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        studio.Data_Studio.GSKapasitas = TxtKapasitas.Text.ToString()
        studio.Data_Studio.GSHargaKursi = TxtHargaKursi.Text.ToString()

        studio.Data_Studio.AddDataStudioDatabase(studio.Data_Studio.GSKapasitas, studio.Data_Studio.GSHargaKursi)

        Me.Close()
    End Sub

End Class