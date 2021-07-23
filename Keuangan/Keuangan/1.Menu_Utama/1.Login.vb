Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tanya = MessageBox.Show("Apakah Anda Ingin Keluar ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If username.Text = "" Then
            MsgBox("Isi Username TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            username.Focus()
        ElseIf username.Text = "" Then
            MsgBox("Isi Password TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            password.Focus()
        Else
            Dim sql As String
            sql = "select * from datapetugas where Username ='" + username.Text + "' and Password ='" + password.Text + "'"
            Cmd = New MySqlCommand(sql, Con)
            da = New MySqlDataAdapter(Cmd)
            ds = New Data.DataSet
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical)
                username.Text = ""
                password.Text = ""
            Else
                MsgBox("Login Telah Berhasil", MsgBoxStyle.OkOnly)
                Me.Hide()
                MenuUtama.Show()
                MenuUtama.ToolStripStatusLabel2.Text = username.Text
            End If
        End If
    End Sub
End Class