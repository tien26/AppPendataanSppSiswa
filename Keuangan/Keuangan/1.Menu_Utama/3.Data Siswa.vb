Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Form3

    Sub bersih()
        nis.Text = ""
        nama.Text = ""
        kelamin.Text = ""
        kelas.Text = ""
        alamat.Text = ""
        nibu.Text = ""
        nayah.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
        Button1.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If nis.Text = "" Then
            MsgBox("Isi NIS TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nis.Focus()
        ElseIf nama.Text = "" Then
            MsgBox("Isi Nama Siswa TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nama.Focus()
        ElseIf kelamin.Text = "" Then
            MsgBox("Isi Jenis Kelamin TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            kelamin.Focus()
        ElseIf kelas.Text = "" Then
            MsgBox("Isi Kelas TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            kelas.Focus()
        ElseIf alamat.Text = "" Then
            MsgBox("Isi Alamat TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            alamat.Focus()
        ElseIf nibu.Text = "" Then
            MsgBox("Isi Nama Ibu TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nibu.Focus()
        ElseIf nayah.Text = "" Then
            MsgBox("Isi Nama Ayah TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nayah.Focus()
        Else
            Try
                sql = "insert into datasiswa values ('" & nis.Text & "','" & nama.Text & "','" & kelamin.Text & "','" & kelas.Text &
                    "','" & alamat.Text & "','" & nibu.Text & "','" & nayah.Text & "')"
                Cmd = New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.OkOnly, "Informasi")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            bersih()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        da = New MySqlDataAdapter("select * from datasiswa", Con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "datasiswa")
        DataGridView1.DataSource = (ds.Tables("datasiswa"))
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If nis.Text = "" Then
            MsgBox("Isi Nis Terlebih Dahulu", MsgBoxStyle.Information, "Informmasi")
            nis.Focus()
        ElseIf nama.Text = "" Then
            MsgBox("Isi Nama Terlebih Dahulu", MsgBoxStyle.Information, "Informmasi")
            nama.Focus()
        ElseIf kelamin.Text = "" Then
            MsgBox("Isi Jenis Kelamin TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            kelamin.Focus()
        ElseIf kelas.Text = "" Then
            MsgBox("Isi Kelas TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            kelas.Focus()
        ElseIf alamat.Text = "" Then
            MsgBox("Isi Alamat TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            alamat.Focus()
        ElseIf nibu.Text = "" Then
            MsgBox("Isi Nama Ibu TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nibu.Focus()
        ElseIf nayah.Text = "" Then
            MsgBox("Isi Nama Ayah TerLebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
            nayah.Focus()
        Else
            Try
                sql = "update datasiswa set NIS='" & nis.Text &
                    "',NAMASISWA = '" & nama.Text & "',JENISKELAMIN = '" & kelamin.Text & "',KELAS = '" & kelas.Text &
                    "',ALAMAT = '" & alamat.Text & "',NAMAIBU = '" & nibu.Text & "',NAMAAYAH = '" & nayah.Text &
                    "' where NIS = '" & nis.Text & "'"
                Dim Cmd As New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Siswa Berhasil Diedit", MsgBoxStyle.OkOnly, "Informasi")
                bersih()
                kelas.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub nis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nis.KeyPress
        nis.MaxLength = 15
        If e.KeyChar = Chr(13) Then
            nis.Text = UCase(nis.Text)
            penghubung()
            sql = "select * from datasiswa where NIS='" & nis.Text & "'"
            Cmd = New MySqlCommand(sql, Con)
            Reader = Cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                nama.Text = Reader.Item("NAMASISWA")
                kelas.Text = Reader.Item("KELAS")
                kelamin.Text = Reader.Item("JENISKELAMIN")
                kelas.Text = Reader.Item("KELAS")
                alamat.Text = Reader.Item("ALAMAT")
                nibu.Text = Reader.Item("NAMAIBU")
                nayah.Text = Reader.Item("NAMAAYAH")
                kelas.Enabled = False
            ElseIf nis.Text = "" Then
                MsgBox("NIS Isi Terlebih Dahulu", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.OkOnly)
                Button3.Enabled = False
                bersih()
            End If
            Reader.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nis.Text = "" Then
            MsgBox("Kolom Cari NIS Isi Terlebih Dahulu", MsgBoxStyle.Information, "Informasi")
        Else
            Try
                Call penghubung()
                Using sql As New MySqlCommand("select * from datasiswa where NIS like '%" & nis.Text & "%'", Con)
                    Using Reader As MySqlDataReader = sql.ExecuteReader
                        Using tabel As New DataTable
                            tabel.Load(Reader)
                            If tabel.Rows.Count = 0 Then
                                DataGridView1.DataSource = Nothing
                                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
                            Else
                                DataGridView1.AutoGenerateColumns = False
                                DataGridView1.DataSource = tabel
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
End Class