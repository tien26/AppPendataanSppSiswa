Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Form4

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        da = New MySqlDataAdapter("select * from datasiswa", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "datasiswa")
        DataGridView1.DataSource = (ds.Tables("datasiswa"))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        da = New MySqlDataAdapter("select * from datapetugas", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "datapetugas")
        DataGridView1.DataSource = (ds.Tables("datapetugas"))
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        da = New MySqlDataAdapter("select * from kelas1tkj", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kelas1tkj")
        DataGridView1.DataSource = (ds.Tables("kelas1tkj"))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        da = New MySqlDataAdapter("select * from kelas2tkj", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kelas2tkj")
        DataGridView1.DataSource = (ds.Tables("kelas2tkj"))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        da = New MySqlDataAdapter("select * from kelas3tkj", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kelas3tkj")
        DataGridView1.DataSource = (ds.Tables("kelas3tkj"))
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TombolHapus.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        cetak.Show()
        Me.Hide()
    End Sub
End Class