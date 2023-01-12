
Imports MySql.Data.MySqlClient
Public Class TayangClass

    Private idJadwal As String
    Private film As String
    Private studio As String
    Private tanggal As String
    Private waktuMasuk As String
    Private waktuSelesai As String
    Private filmArray As New ArrayList()
    Private studioArray As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"
    Public Property GSIdJadwal() As String
        Get
            Return idJadwal
        End Get
        Set(value As String)
            idJadwal = value
        End Set
    End Property
    Public Property GSFilm() As String
        Get
            Return film
        End Get
        Set(value As String)
            film = value
        End Set
    End Property
    Public Property GSStudio() As String
        Get
            Return studio
        End Get
        Set(value As String)
            studio = value
        End Set
    End Property
    Public Property GSTanggal() As String
        Get
            Return tanggal
        End Get
        Set(value As String)
            tanggal = value
        End Set
    End Property
    Public Property GSWaktuMasuk() As String
        Get
            Return waktuMasuk
        End Get
        Set(value As String)
            waktuMasuk = value
        End Set
    End Property
    Public Property GSWaktuSelesai() As String
        Get
            Return waktuSelesai
        End Get
        Set(value As String)
            waktuSelesai = value
        End Set
    End Property
    Public Function GetDataScheduleDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT schedules.id AS 'ID Jadwal',
                                  films.nama AS 'Nama Film',
                                  id_studio AS 'Studio',
                                  tanggal AS 'Tanggal Tayang',
                                  waktu_mulai AS 'Waktu Mulai',
                                  waktu_selesai AS 'Waktu Selesai'
                                  FROM schedules
                                  INNER JOIN films ON schedules.id_film = films.id"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataFilmDatabase()

        Try
            Dim result As New DataTable
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                    + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, nama FROM films"
            sqlRead = sqlCommand.ExecuteReader



            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataStudioDatabase()

        Try
            Dim result As New DataTable

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                    + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id FROM studios"
            sqlRead = sqlCommand.ExecuteReader



            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function AddDataScheduleDatabase(tempFilm As String,
                                            tempStudio As String,
                                            tempTanggal As Date,
                                            tempMasuk As String,
                                            tempSelesai As String)
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "INSERT INTO schedules (id_film, id_studio, 
                                    tanggal, waktu_mulai, waktu_selesai) VALUE('" _
                                    & tempFilm & "', '" _
                                    & tempStudio & "', '" _
                                    & tempTanggal.ToString("yyyy/MM/dd") & "', '" _
                                    & tempMasuk & "', '" _
                                    & tempSelesai & "')"
            sqlRead = sqlCommand.ExecuteReader
            Debug.Print(sqlQuery)

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Function GetDataScheduleByIDDatabase(ID As String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                    + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT schedules.id,
                                  id_film,
                                  id_studio,
                                  tanggal,
                                  waktu_mulai,
                                  waktu_selesai
                                  FROM schedules
                                  WHERE schedules.id='" & ID & "' "
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
                result.Add(sqlRead.GetString(4).ToString())
                result.Add(sqlRead.GetString(5).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataScheduleByIDDatabase(ID As String,
                                            tempFilm As String,
                                            tempStudio As String,
                                            tempTanggal As Date,
                                            tempMasuk As String,
                                            tempSelesai As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE schedules SET " &
                        "id_film= '" & tempFilm & "',  " &
                        "id_studio= '" & tempStudio & "',  " &
                        "tanggal= '" & tempTanggal.ToString("yyyy/MM/dd") & "',  " &
                        "waktu_mulai= '" & tempMasuk & "',  " &
                        "waktu_selesai= '" & tempSelesai & "'  " &
                        "WHERE id= " & ID & ""
            Debug.Print(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Function DeleteDataScheduleByIDDatabase(ID As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
                                + "password = " + password + ";" + "database = " + database + "; Convert Zero Datetime=True"
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM schedules " &
                       "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
