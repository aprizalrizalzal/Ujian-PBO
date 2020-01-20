Imports System.Data.OleDb
Public Class FormLogin
    Dim YesNo As Integer
    Private Const hilangkan_close As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim hilang As CreateParams = MyBase.CreateParams
            hilang.ClassStyle = hilang.ClassStyle Or hilangkan_close
            Return hilang
        End Get
    End Property

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pilih()
        ComboBoxSel.Text = Nothing
        TextBoxUs.Focus()
    End Sub
    Private Sub pilih()
        connection()
        da = New OleDbDataAdapter("SELECT * FROM accountUser", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "accountUser")
        ComboBoxSel.DataSource = (ds.Tables("accountUser"))
        Me.ComboBoxSel.ValueMember = "ID"
        Me.ComboBoxSel.DisplayMember = "priority"
    End Sub
    Private Sub TextBoxPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged
        TextBoxPass.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBoxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass.CheckedChanged
        If CheckBoxShowPass.Checked Then
            TextBoxPass.UseSystemPasswordChar = False
        Else
            TextBoxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ButtonLog_Click(sender As Object, e As EventArgs) Handles ButtonLog.Click
        If TextBoxUs.Text = Nothing Then
            MsgBox("Enter Username", MsgBoxStyle.Information, "Sorry")
        ElseIf TextBoxPass.Text = Nothing Then
            MsgBox("Enter Password", MsgBoxStyle.Information, "Sorry")
        ElseIf ComboBoxSel.Text = Nothing Then
            MsgBox("Select the priority that matches the account", MsgBoxStyle.Question)
        End If

        connection()

        Dim cmd As New OleDbCommand("SELECT COUNT (*) FROM accountUser WHERE username='" & TextBoxUs.Text & "' and password='" & TextBoxPass.Text & "' and priority='" & ComboBoxSel.Text & "'", conn)
        Dim cmda As New OleDbCommand("SELECT COUNT (*) FROM accountAdmin WHERE username='" & TextBoxUs.Text & "' and password='" & TextBoxPass.Text & "' and priority='" & ComboBoxSel.Text & "'", conn)
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())
        Dim counta = Convert.ToInt32(cmda.ExecuteScalar())


        If (count > 0) Then
            Utama.Show()
            Utama.LoginSuccessfulUser()
            Me.Hide()
            MsgBox("Anda Sudah Masuk Sebagai " & ComboBoxSel.Text & "", MsgBoxStyle.Information, "Welcome " & TextBoxUs.Text & "")
        ElseIf (counta > 0) Then
            Utama.Show()
            Utama.LoginSuccessfulAdmin()
            Me.Hide()
            MsgBox("Anda Sudah Masuk Sebagai " & ComboBoxSel.Text & "", MsgBoxStyle.Information, "Welcome " & TextBoxUs.Text & "")
        Else
            MsgBox("Password and Username is wrong", MsgBoxStyle.Exclamation, "Sorry")
        End If
        
    End Sub

    Private Sub ButtonCanc_Click(sender As Object, e As EventArgs) Handles ButtonCanc.Click
        YesNo = MsgBox("Are You Sure to Cancel it", vbQuestion + vbYesNo + vbDefaultButton2, "Canceled")
        If YesNo = vbYes Then
            Me.Close()
            Utama.Show()
        End If
    End Sub

End Class
