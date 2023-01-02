Public Class HapusStudio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        studio.Data_Studio.DeleteDataStudioByIDDatabase(studio.selectedTableStudio)

        Me.Close()

    End Sub


End Class