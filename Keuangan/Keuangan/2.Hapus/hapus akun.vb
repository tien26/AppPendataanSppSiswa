Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class hapus_akun

    Private Sub hapus_akun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        da = New MySqlDataAdapter("select * from datapetugas", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "datapetugas")
        DataGridView1.DataSource = (ds.Tables("datapetugas"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nip.Text = "" Then
            MsgBox("Isi NIP Terlebih Dahulu", MsgBoxStyle.OkOnly)
        Else
            Dim sql As String = " delete from datapetugas where NIP = '" & nip.Text & "' "
            Cmd = New MySqlCommand(sql, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.OkOnly)
            nip.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TombolHapus.Show()
        Me.Close()
    End Sub
End Class