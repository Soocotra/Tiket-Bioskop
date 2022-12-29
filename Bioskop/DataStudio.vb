Imports MySql.Data.MySqlClient

Public Class DataStudio
    Public Shared kapasitas As Integer
    Public Shared harga_kursi As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "mysql"


    Public Function GetDataStudioDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID STUDIO', kapasitas as 'Kapasitas', 
                                  harga_kursi AS 'Harga Kursi' 
                                  FROM studios"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function


    Public Function AddDataStudioDatabase(kapasitas As Integer, harga_kursi As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO STUDIOS(kapasitas, harga_kursi) VALUE('" _
                        & kapasitas & "', '" _
                        & harga_kursi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


    Public Function GetDataStudioByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id,
                                  kapasitas, 
                                  harga_kursi
                                  FROM studios
                                  WHERE id='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function


    Public Function UpdateDataStudioByIDDatabase(ID As Integer,
                                                  kapasitas As Integer,
                                                  harga_kursi As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE studios SET " &
                        "kapasitas='" & kapasitas & "', " &
                        "harga_kursi='" & harga_kursi & "', " &
                        "WHERE id='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


    Public Function DeleteDataStudioByIDDatabase(ID As Integer)

        dbConn.ConnectionString = "Server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM studios " &
                "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()


            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Property GSKapasitas() As Integer
        Get
            Return kapasitas
        End Get
        Set(ByVal value As Integer)
            kapasitas = value
        End Set
    End Property

    Public Property GSHargaKursi() As Integer
        Get
            Return harga_kursi
        End Get
        Set(ByVal value As Integer)
            harga_kursi = value
        End Set
    End Property


End Class
