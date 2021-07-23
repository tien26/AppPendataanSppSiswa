Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Login

    Sub bersih()
        nip.Text = ""
        nama.Text = ""
        username.Text = ""
        password.Text = ""
        kpassword.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Public Level As String
    Sub rb()
        If RadioButton1.Checked = True Then
            Level = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            Level = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            Level = RadioButton3.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bersih()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rb()
        If nip.Text = "" Then
            MsgBox("Isi NIP TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nip.Focus()
        ElseIf nama.Text = "" Then
            MsgBox("Isi Nama TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nama.Focus()
        ElseIf username.Text = "" Then
            MsgBox("Isi Username TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            username.Focus()
        ElseIf password.Text = "" Then
            MsgBox("Isi Password TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            password.Focus()
        ElseIf kpassword.Text = "" Then
            MsgBox("Isi Konfirmasi Password TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            kpassword.Focus()
        ElseIf kpassword.Text <> password.Text Then
            MsgBox("Konfirmasi Password Berbeda Mohon Cek Kembali", MsgBoxStyle.OkOnly, "Informasi")
            kpassword.Focus()
        ElseIf Level = "" Then
            MsgBox("Pilih Level TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            RadioButton1.Focus()
        Else
                Try
                    sql = "insert into datapetugas values ('" & nip.Text & "','" & nama.Text & "','" & username.Text & "','" & password.Text &
                        "','" & Level & "')"
                    Cmd = New MySqlCommand(sql, Con)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Akun Berhasil Ditambahkan", MsgBoxStyle.OkOnly, "Informasi")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                bersih()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub
End Class
