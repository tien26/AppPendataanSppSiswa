Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Module koneksi
    Public Con As MySqlConnection
    Public str, sql, simpan As String
    Public Cmd As MySqlCommand
    Public Reader As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public hasil As Integer
    Public database As New MySqlConnection
    Public tampil As New MySql.Data.MySqlClient.MySqlCommand
    Public tampilkan As MySql.Data.MySqlClient.MySqlDataReader
    Public cari As OleDbDataReader
    Public dml As New OleDbCommand

    Public Sub penghubung()
        str = "Server= localhost;user=root;database=dbkeuangan"
        Con = New MySqlConnection(str)
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
    End Sub

End Module
