Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class MenuUtama

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya = MessageBox.Show("Apakah Anda Ingin Keluar ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim tanya = MessageBox.Show("Apakah Anda Ingin Keluar Akun?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Form2.Show()
            Form2.username.Clear()
            Form2.password.Clear()
            Form2.username.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub DataSiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSiswaToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub DataSiswaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSiswaToolStripMenuItem1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembayaranToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub KelolaAkunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelolaAkunToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class