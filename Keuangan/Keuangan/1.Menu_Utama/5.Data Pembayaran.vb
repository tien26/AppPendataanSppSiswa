Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Form6

    Sub bersih()
        jan.Text = ""
        feb.Text = ""
        mar.Text = ""
        apr.Text = ""
        mei.Text = ""
        jun.Text = ""
        jul.Text = ""
        ags.Text = ""
        sep.Text = ""
        okt.Text = ""
        nov.Text = ""
        des.Text = ""
        total.Text = ""
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        penghubung()
        nis.Focus()
        nama.Enabled = False
        kelas.Enabled = False

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
            ElseIf nis.Text = "" Then
                MsgBox("NIS Isi Terlebih Dahulu", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.OkOnly)
                Button1.Enabled = False
                Button3.Enabled = False
                nama.Text = ""
                kelas.Text = ""
                bersih()
            End If
            Reader.Close()
        End If
        nis.MaxLength = 15
        If kelas.Text = "10 TKJ" Then
            If e.KeyChar = Chr(13) Then
                nis.Text = UCase(nis.Text)
                penghubung()
                sql = "select * from kelas1tkj where NIS='" & nis.Text & "'"
                Cmd = New MySqlCommand(sql, Con)
                Reader = Cmd.ExecuteReader
                Reader.Read()
                If Reader.HasRows = True Then
                    jan.Text = Reader.Item("JAN")
                    feb.Text = Reader.Item("FEB")
                    mar.Text = Reader.Item("MAR")
                    apr.Text = Reader.Item("APR")
                    mei.Text = Reader.Item("MEI")
                    jun.Text = Reader.Item("JUN")
                    jul.Text = Reader.Item("JUL")
                    ags.Text = Reader.Item("AGS")
                    sep.Text = Reader.Item("SEP")
                    okt.Text = Reader.Item("OKT")
                    nov.Text = Reader.Item("NOV")
                    des.Text = Reader.Item("DES")
                    Button1.Enabled = False
                    Button3.Enabled = True
                    total.Text = Val(jan.Text) + Val(feb.Text) + Val(mar.Text) + Val(apr.Text) + Val(mei.Text) + Val(jun.Text) + Val(jul.Text) + Val(ags.Text) + Val(sep.Text) + Val(okt.Text) + Val(nov.Text) + Val(des.Text)
                Else
                    MsgBox("Siswa Belum Terdaftar Disini Silahkan Lakukan Pembayaran", MsgBoxStyle.OkOnly)
                    Button1.Enabled = True
                    Button3.Enabled = False
                    bersih()
                End If
                Reader.Close()
            End If
        ElseIf kelas.Text = "11 TKJ" Then
            nis.MaxLength = 15
            If e.KeyChar = Chr(13) Then
                nis.Text = UCase(nis.Text)
                penghubung()
                sql = "select * from kelas2tkj where NIS='" & nis.Text & "'"
                Cmd = New MySqlCommand(sql, Con)
                Reader = Cmd.ExecuteReader
                Reader.Read()
                If Reader.HasRows = True Then
                    jan.Text = Reader.Item("JAN")
                    feb.Text = Reader.Item("FEB")
                    mar.Text = Reader.Item("MAR")
                    apr.Text = Reader.Item("APR")
                    mei.Text = Reader.Item("MEI")
                    jun.Text = Reader.Item("JUN")
                    jul.Text = Reader.Item("JUL")
                    ags.Text = Reader.Item("AGS")
                    sep.Text = Reader.Item("SEP")
                    okt.Text = Reader.Item("OKT")
                    nov.Text = Reader.Item("NOV")
                    des.Text = Reader.Item("DES")
                    total.Text = Val(jan.Text) + Val(feb.Text) + Val(mar.Text) + Val(apr.Text) + Val(mei.Text) + Val(jun.Text) + Val(jul.Text) + Val(ags.Text) + Val(sep.Text) + Val(okt.Text) + Val(nov.Text) + Val(des.Text)
                    Button1.Enabled = False
                    Button3.Enabled = True
                Else
                    MsgBox("Siswa Belum Terdaftar Disini Silahkan Lakukan Pembayaran", MsgBoxStyle.OkOnly)
                    Button1.Enabled = True
                    Button3.Enabled = False
                    bersih()
                End If
                Reader.Close()
            End If
        ElseIf kelas.Text = "12 TKJ" Then
            nis.MaxLength = 15
            If e.KeyChar = Chr(13) Then
                nis.Text = UCase(nis.Text)
                penghubung()
                sql = "select * from kelas3tkj where NIS='" & nis.Text & "'"
                Cmd = New MySqlCommand(sql, Con)
                Reader = Cmd.ExecuteReader
                Reader.Read()
                If Reader.HasRows = True Then
                    jan.Text = Reader.Item("JAN")
                    feb.Text = Reader.Item("FEB")
                    mar.Text = Reader.Item("MAR")
                    apr.Text = Reader.Item("APR")
                    mei.Text = Reader.Item("MEI")
                    jun.Text = Reader.Item("JUN")
                    jul.Text = Reader.Item("JUL")
                    ags.Text = Reader.Item("AGS")
                    sep.Text = Reader.Item("SEP")
                    okt.Text = Reader.Item("OKT")
                    nov.Text = Reader.Item("NOV")
                    des.Text = Reader.Item("DES")
                    total.Text = Val(jan.Text) + Val(feb.Text) + Val(mar.Text) + Val(apr.Text) + Val(mei.Text) + Val(jun.Text) + Val(jul.Text) + Val(ags.Text) + Val(sep.Text) + Val(okt.Text) + Val(nov.Text) + Val(des.Text)
                    Button1.Enabled = False
                    Button3.Enabled = True
                Else
                    MsgBox("Siswa Belum Terdaftar Disini Silahkan Lakukan Pembayaran", MsgBoxStyle.OkOnly)
                    Button1.Enabled = True
                    Button3.Enabled = False
                    bersih()
                End If
                Reader.Close()
            End If

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If jan.Text = "" Then
            MsgBox("Silahkan Bayar Iuran Bulan Januari Terlebih Dahulu", MsgBoxStyle.OkOnly, "Informasi")
        Else
            If kelas.Text = "10 TKJ" Then
                Try
                    sql = "insert into kelas1tkj values ('" & nis.Text & "','" & nama.Text & "','" & kelas.Text & "','" & jan.Text &
                        "','" & feb.Text & "','" & mar.Text & "','" & apr.Text & "','" & mei.Text & "','" & jun.Text & "','" & jul.Text &
                        "','" & ags.Text & "','" & sep.Text & "','" & okt.Text & "','" & nov.Text & "','" & des.Text & "','" & total.Text & "')"
                    Cmd = New MySqlCommand(sql, Con)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Pembayaran Berhasil Ditambahkan", MsgBoxStyle.OkOnly, "Informasi")
                    bersih()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf kelas.Text = "11 TKJ" Then
                Try
                    sql = "insert into kelas2tkj values ('" & nis.Text & "','" & nama.Text & "','" & kelas.Text & "','" & jan.Text &
                        "','" & feb.Text & "','" & mar.Text & "','" & apr.Text & "','" & mei.Text & "','" & jun.Text & "','" & jul.Text &
                        "','" & ags.Text & "','" & sep.Text & "','" & okt.Text & "','" & nov.Text & "','" & des.Text & "','" & total.Text & "')"
                    Cmd = New MySqlCommand(sql, Con)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Pembayaran Berhasil Ditambahkan", MsgBoxStyle.OkOnly, "Informasi")
                    bersih()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf kelas.Text = "12 TKJ" Then
                Try
                    sql = "insert into kelas3tkj values ('" & nis.Text & "','" & nama.Text & "','" & kelas.Text & "','" & jan.Text &
                        "','" & feb.Text & "','" & mar.Text & "','" & apr.Text & "','" & mei.Text & "','" & jun.Text & "','" & jul.Text &
                        "','" & ags.Text & "','" & sep.Text & "','" & okt.Text & "','" & nov.Text & "','" & des.Text & "','" & total.Text & "')"
                    Cmd = New MySqlCommand(sql, Con)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Pembayaran Berhasil Ditambahkan", MsgBoxStyle.OkOnly, "Informasi")
                    bersih()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Siswa Belum Terdaftar Di Data Siswa", MsgBoxStyle.OkOnly, "Informasi")
                nis.Clear()
                bersih()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If kelas.Text = "10 TKJ" Then
            Try
                sql = "update kelas1tkj set NAMASISWA='" & nama.Text & "',JAN='" & jan.Text &
                    "',FEB = '" & feb.Text & "',MAR = '" & mar.Text & "',APR = '" & apr.Text &
                    "',MEI = '" & mei.Text & "',JUN = '" & jun.Text & "',JUL = '" & jul.Text &
                    "',AGS = '" & ags.Text & "',SEP = '" & sep.Text & "',OKT = '" & okt.Text &
                    "',NOV = '" & nov.Text & "',DES = '" & des.Text & "',TOTAL = '" & total.Text & "' where NIS = '" & nis.Text & "'"
                Dim Cmd As New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Pembayaran Berhasil Diperbarui", MsgBoxStyle.OkOnly)
                bersih()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf kelas.Text = "11 TKJ" Then
            Try
                sql = "update kelas2tkj set NAMASISWA='" & nama.Text & "',JAN='" & jan.Text &
                    "',FEB = '" & feb.Text & "',MAR = '" & mar.Text & "',APR = '" & apr.Text &
                    "',MEI = '" & mei.Text & "',JUN = '" & jun.Text & "',JUL = '" & jul.Text &
                    "',AGS = '" & ags.Text & "',SEP = '" & sep.Text & "',OKT = '" & okt.Text &
                    "',NOV = '" & nov.Text & "',DES = '" & des.Text & "',TOTAL = '" & total.Text & "' where NIS = '" & nis.Text & "'"
                Dim Cmd As New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Pembayaran Berhasil Diperbarui", MsgBoxStyle.OkOnly)
                bersih()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf kelas.Text = "12 TKJ" Then
            Try
                sql = "update kelas3tkj set NAMASISWA='" & nama.Text & "',JAN='" & jan.Text &
                    "',FEB = '" & feb.Text & "',MAR = '" & mar.Text & "',APR = '" & apr.Text &
                    "',MEI = '" & mei.Text & "',JUN = '" & jun.Text & "',JUL = '" & jul.Text &
                    "',AGS = '" & ags.Text & "',SEP = '" & sep.Text & "',OKT = '" & okt.Text &
                    "',NOV = '" & nov.Text & "',DES = '" & des.Text & "',TOTAL = '" & total.Text & "' where NIS = '" & nis.Text & "'"
                Dim Cmd As New MySqlCommand(sql, Con)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Pembayaran Berhasil Diperbarui", MsgBoxStyle.OkOnly)
                bersih()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
End Class