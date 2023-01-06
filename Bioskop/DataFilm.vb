Imports System.Text
'Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class DataFilm

    Private namaFilm As String
    Private Genre_Arr As New List(Of String)
    Private Deks As String
    Private Dir As String
    Private Dur As String
    Private Release As String
    Private Bahasa As String
    Private Price As String
    Private Photo As String
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlComm As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    Public Property GSNama As String
        Get
            Return namaFilm
        End Get
        Set(value As String)
            namaFilm = value
        End Set
    End Property

    Public Property GSGenre As List(Of String)
        Get
            Return Genre_Arr
        End Get
        Set(value As List(Of String))
            Genre_Arr = value
        End Set
    End Property

    Public Property GSDeks As String
        Get
            Return Deks
        End Get
        Set(value As String)
            Deks = value
        End Set
    End Property

    Public Property GSDir As String
        Get
            Return Dir
        End Get
        Set(value As String)
            Dir = value
        End Set
    End Property

    Public Property GSDur As String
        Get
            Return Dur
        End Get
        Set(value As String)
            Dur = value
        End Set
    End Property

    Public Property GSRelease As String
        Get
            Return Release
        End Get
        Set(value As String)
            Release = value
        End Set
    End Property

    Public Property GSBahasa As String
        Get
            Return Bahasa
        End Get
        Set(value As String)
            Bahasa = value
        End Set
    End Property

    Public Property GSPrice As String
        Get
            Return Price
        End Get
        Set(value As String)
            Price = value
        End Set
    End Property

    Public Property GSPhoto As String
        Get
            Return Photo
        End Get
        Set(value As String)
            Photo = value
        End Set
    End Property

    Public ReadOnly Property getKoleksiDataTable As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property


    Public Function addKoleksiDataTable(namaFilm As String,
        Genre_Arr As String,
        Deks As String,
        Dir As String,
        Dur As String,
        Release As String,
        Bahasa As String,
        Price As String,
        Photo As String
        )

        koleksiDataTable.Add({
        namaFilm,
        Genre_Arr,
        Deks,
        Dir,
        Dur,
        Release,
        Bahasa,
        Price,
        Photo})

    End Function

    Public Function removeDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public Function convertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function convertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database + ";" + "convert zero datetime=True"
        dbConn.Open()
        sqlComm.Connection = dbConn
        sqlComm.CommandText = "SELECT ID AS 'ID',
                               NAMA AS 'NAMA FILM',
                               GENRE AS 'GENRE',
                               DESKRIPSI AS 'DESKRIPSI',
                               DIRECTOR AS 'DIRECTOR',
                               DURATION AS 'DURASI',
                               DATE_RELEASE AS 'DATE RELEASE',
                               BAHASA AS 'BAHASA',
                               HARGA_FILM AS 'PRICE'
                               FROM FILMS"

        sqlRead = sqlComm.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function AddDataKoleksiDatabase(namaFilm As String,
                                            Genre_Arr As String,
                                            Deks As String,
                                            Dir As String,
                                            Dur As String,
                                            Release As Date,
                                            Bahasa As String,
                                            Price As String,
                                            Photo As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = "INSERT INTO FILMS(NAMA,GENRE,DESKRIPSI,
                               DIRECTOR,DURATION,DATE_RELEASE,BAHASA, HARGA_FILM,FOTO) VALUE (
                        '" & namaFilm & "',
                        '" & Genre_Arr & "',
                        '" & Deks & "',
                        '" & Dir & "',
                        '" & Dur & "',
                        '" & Release.ToString("yyyy/MM/dd") & "',
                        '" & Bahasa & "',
                        '" & Price & "',
                        '" & Photo & "')
                        "

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("apa si")
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try

    End Function


    Public Function GetDataKoleksiByIdDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database
        dbConn.Open()

        sqlComm.Connection = dbConn
        sqlComm.CommandText = "SELECT ID,
                               NAMA,GENRE,DESKRIPSI,
                               DIRECTOR,DURATION,DATE_RELEASE,BAHASA, HARGA_FILM,FOTO
                               FROM FILMS WHERE ID ='" & ID & "'"

        sqlRead = sqlComm.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDateKoleksiByIdDatabase(ID As Integer,
                                                  namaFilm As String,
                                                    Genre_Arr As String,
                                                    Deks As String,
                                                    Dir As String,
                                                    Dur As String,
                                                    Release As Date,
                                                    Bahasa As String,
                                                    Price As String,
                                                    Photo As String)
        Release = Release.ToString()
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = " UPDATE FILMS SET 
                       " & " NAMA '" & namaFilm & "',
                       " & " GENRE '" & Genre_Arr & "',
                       " & " DESKRIPSI '" & Deks & "',
                       " & " DIRECTOR '" & Dir & "',
                       " & " DURATION '" & Dur & "',
                       " & " DATE_RELEASE '" & Release.ToString("yyyy/MM/dd") & "',
                       " & " BAHASA '" & Bahasa & "',
                       " & " HARGA_FILM '" & Price & "',
                       " & " PHOTO '" & Photo & "'
                       " & " WHERE ID =  '" & ID & "'
                       "

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIdDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " _
        + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = "DELETE FROM FILMS WHERE ID='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader
            dbConn.Close()


            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            MessageBox.Show("apa si")
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class
