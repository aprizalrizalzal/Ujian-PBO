Public Class Utama
    Public IsLoginUser As Boolean = False
    Public IsLoginAdmin As Boolean = False
    Private Const hilangkan_close As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim hilang As CreateParams = MyBase.CreateParams
            hilang.ClassStyle = hilang.ClassStyle Or hilangkan_close
            Return hilang
        End Get
    End Property

    Private Sub Keluar()
        Dim YesNo As Integer
        YesNo = MsgBox("Apakah Anda Yakin", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")
        If YesNo = vbYes Then
            Me.Close()
            SplashScreen.Close()
        End If
    End Sub
    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItemDB.Click
        FormDataPenjualan.Show()
    End Sub
    Private Sub AccountUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        FormDataAccount.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Keluar()
        SplashScreen.Close()
        FormLogin.Close()
        FormPenjualan.Close()
    End Sub

    Private Sub Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxUtama.Focus()
        LoginToolStripMenuItem.Available = True
        If (Not IsLoginUser Or IsLoginAdmin) Then
            DataTransaksiToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Enabled = False
            PenjualanToolStripMenuItem.Enabled = False
            AccountToolStripMenuItem.Enabled = False
        End If
    End Sub
    Public Sub LoginSuccessfulUser()
        DataTransaksiToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Available = False
        LogoutToolStripMenuItem.Enabled = True
        AccountToolStripMenuItem.Enabled = False
        PenjualanToolStripMenuItem.Enabled = True
    End Sub
    Public Sub LoginSuccessfulAdmin()
        DataTransaksiToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Available = False
        LogoutToolStripMenuItem.Enabled = True
        AccountToolStripMenuItem.Enabled = True
        PenjualanToolStripMenuItem.Enabled = True
    End Sub

    Private Sub LogoutToolStripMenuItemLogOut_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Utama_Load(sender, e)
        FormLogin.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Keluar()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Tugas Akhir UAS_19 Visual Programing Aplikasi Kasir Sisitem Informasi Penjualan (Percetakan)", MsgBoxStyle.Information, "Kelompok 2 (dua)")
    End Sub
End Class