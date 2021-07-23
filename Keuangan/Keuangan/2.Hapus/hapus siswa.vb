Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class hapus_siswa

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        da = New MySqlDataAdapter("select * from datasiswa", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "datasiswa")
        DataGridView1.DataSource = (ds.Tables("datasiswa"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nis.Text = "" Then
            MsgBox("Isi NIS Terlebih Dahulu", MsgBoxStyle.OkOnly)
        Else
            Dim sql As String = " delete from datasiswa where NIS = '" & nis.Text & "' "
            Cmd = New MySqlCommand(sql, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.OkOnly)
            nis.Focus()
        End If
    End Sub

    Private Sub hapus_siswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TombolHapus.Show()
        Me.Close()
    End Sub
End Class