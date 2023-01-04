Imports System.Runtime.CompilerServices
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataPerpus


    Public Sub New()

    End Sub

    Private namaFilm As String
    Private Genre_Arr As New List(Of String)
    Private Deks As String
    Private Dir As String
    Private Dur As String
    Private Release As Date
    Private Bahasa As String
    Private Price As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlComm As New MySqlCommand
    Public Shared sqlRead As New MySqlDataReader


End Class
