Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class hapus1

    Private Sub hapus1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        da = New MySqlDataAdapter("select * from kelas1tkj", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kelas1tkj")
        DataGridView1.DataSource = (ds.Tables("kelas1tkj"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nis.Text = "" Then
            MsgBox("Isi NIS Terlebih Dahulu", MsgBoxStyle.OkOnly)
        Else
            Dim sql As String = " delete from kelas2tkj where NIS = '" & nis.Text & "' "
            Cmd = New MySqlCommand(sql, Con)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil", MsgBoxStyle.OkOnly)
            nis.Focus()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TombolHapus.Show()
        Me.Close()
    End Sub
End Class