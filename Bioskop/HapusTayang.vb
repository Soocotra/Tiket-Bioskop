Public Class HapusTayang
    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        Tayang.jadwal.DeleteDataScheduleByIDDatabase(Tayang.selectedTableSchedule)

        Me.Close()
    End Sub
End Class