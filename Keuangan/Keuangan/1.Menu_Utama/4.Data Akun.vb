Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Form5

    Sub bersih()
        nip.Text = ""
        nama.Text = ""
        username.Text = ""
        password.Text = ""
        kpassword.Text = ""
        level.Text = ""
    End Sub
    Private Sub nip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nip.KeyPress
        nip.MaxLength = 15
        If e.KeyChar = Chr(13) Then
            nip.Text = UCase(nip.Text)
            penghubung()
            sql = "select * from datapetugas where NIP='" & nip.Text & "'"
            Cmd = New MySqlCommand(sql, Con)
            Reader = Cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                nama.Text = Reader.Item("NAMAPETUGAS")
                username.Text = Reader.Item("USERNAME")
                password.Text = Reader.Item("PASSWORD")
                kpassword.Text = Reader.Item("PASSWORD")
                level.Text = Reader.Item("LEVEL")
                Button1.Enabled = True
                Button2.Enabled = True
                nama.Enabled = True
                username.Enabled = True
                password.Enabled = True
                kpassword.Enabled = True
                level.Enabled = True
            ElseIf nip.Text = "" Then
                MsgBox("NIP Isi Terlebih Dahulu", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Data Tidaak Ditemukan", MsgBoxStyle.OkOnly)
                bersih()
            End If
            Reader.Close()
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button2.Enabled = False
        nama.Enabled = False
        username.Enabled = False
        password.Enabled = False
        kpassword.Enabled = False
        level.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            sql = "update datapetugas set NAMAPETUGAS='" & nama.Text &
                "',USERNAME = '" & username.Text & "',PASSWORD = '" & password.Text & "',LEVEL = '" & level.Text &
                "' where NIP = '" & nip.Text & "'"
            Dim Cmd As New MySqlCommand(sql, Con)
            Cmd.ExecuteNonQuery()

            MsgBox("Edit Sukses", MsgBoxStyle.OkOnly)
            bersih()
            Button1.Enabled = False
            Button2.Enabled = False
            nama.Enabled = False
            username.Enabled = False
            password.Enabled = False
            kpassword.Enabled = False
            level.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If nip.Text = "" Then
            MsgBox("Isi NIP Terlebih Dahulu", MsgBoxStyle.OkOnly)
        Else
            Dim tanya = MessageBox.Show("Apakah Yakin Akan Menghapus Data ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If tanya = Windows.Forms.DialogResult.Yes Then

            Dim sql As String = " delete from datapetugas where NIP = '" & nip.Text & "' "
                Cmd = New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil", MsgBoxStyle.OkOnly)
                bersih()
            Else
                Button1.Enabled = False
                Button2.Enabled = False
                nama.Enabled = False
                username.Enabled = False
                password.Enabled = False
                kpassword.Enabled = False
                level.Enabled = False
                bersih()
            End If
        End If
    End Sub
End Class