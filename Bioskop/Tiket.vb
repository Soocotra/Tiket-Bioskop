Imports MySql.Data.MySqlClient

Public Class Tiket

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared errMessage As String

    Private sqlQuery As String

    Private ReadOnly server As String = "localhost"
    Private ReadOnly usernameDB As String = "root"
    Private ReadOnly passwordDB As String = ""
    Private ReadOnly database As String = "bioskop"

    Public Function ConnectToDB()
        Return "server =" + server + ";" + "user id=" + usernameDB + ";" + "password =" + passwordDB + ";" + "database =" + database
    End Function

    Public Function index()
        Try
            Dim result As New DataTable
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "SELECT TK.ID AS 'ID' ,FL.NAMA AS MOVIE, SC.ID_STUDIO AS STUDIO, SC.WAKTU_MULAI AS START, SC.WAKTU_SELESAI AS END FROM TICKETS AS TK JOIN SCHEDULES AS SC ON TK.ID_SCHEDULE = SC.ID JOIN FILMS AS FL ON SC.ID_FILM = FL.ID"

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            dbConn.Close()
            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function postTicket(scheduleId As String, price As String) As Boolean
        Try
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "INSERT INTO TICKETS (ID_SCHEDULE, TOTAL_HARGA)
                         VALUE (" + scheduleId + "," + price + ")"

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function destroy(ticketId As String)
        Try
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "DELETE FROM TICKETS WHERE ID=" + ticketId

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader()

            dbConn.Close()

            Return True

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Sub UpdateSeat(studioId As String, isIncrease As Boolean)
        Try
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn
            Dim query As String
            If isIncrease Then
                query = "UPDATE STUDIOS 
                         SET KAPASITAS = KAPASITAS + 1
                         WHERE ID= " + studioId
            Else
                query = "UPDATE STUDIOS 
                         SET KAPASITAS = KAPASITAS - 1
                         WHERE ID= " + studioId
            End If

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function GetSchedules(selectedMovie As String)
        Try
            Dim result As New DataTable
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "SELECT SC.ID AS ID, FL.NAMA, SC.ID_STUDIO AS STUDIO, ST.KAPASITAS AS CAPACITY, SC.WAKTU_MULAI AS 'START', SC.WAKTU_SELESAI AS 'END', CONCAT('Rp.', (FL.HARGA_FILM + ST.HARGA_KURSI)) AS 'TOTAL HARGA' FROM SCHEDULES AS SC 
                         JOIN FILMS AS FL ON SC.ID_FILM = FL.ID 
                         JOIN STUDIOS AS ST ON SC.ID_STUDIO = ST.ID 
                         WHERE FL.NAMA ='" + selectedMovie + "'
                         AND ST.KAPASITAS > 0"

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            dbConn.Close()
            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetFilm()
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "SELECT NAMA FROM FILMS"

            sqlCommand.CommandText = query
            Debug.WriteLine(query)
            sqlRead = sqlCommand.ExecuteReader()

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
            End While

            Return result(0)
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Close()
        End Try
    End Function
End Class
