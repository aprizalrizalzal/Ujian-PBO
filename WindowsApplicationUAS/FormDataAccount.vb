Imports System.Data.OleDb
Public Class FormDataAccount
    Dim AccountId As String
    Dim DataAdd As Boolean

    Private Sub DataGridViewAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAccount.CellClick
        isiTextBox()
        aktifChehckBox()
        If CheckBoxAdd.CheckState = CheckState.Checked Then
            CheckBoxUpdate.CheckState = CheckState.Unchecked
            CheckBoxDel.CheckState = CheckState.Unchecked
        Else
            CheckBoxAdd.Enabled = False
            CheckBoxUpdate.Enabled = True
            CheckBoxDel.Enabled = True
        End If
    End Sub
    Private Sub isiTextBox()
        Dim i As Integer
        DataAdd = False
        i = DataGridViewAccount.CurrentRow.Index
        AccountId = DataGridViewAccount.Item(0, i).Value
        TextBoxUser.Text = DataGridViewAccount.Item(1, i).Value
        TextBoxPassword.Text = DataGridViewAccount.Item(2, i).Value
        TextBoxPriority.Text = DataGridViewAccount.Item(3, i).Value
    End Sub
    Private Sub Bersihkan()
        CheckBoxAdd.Enabled = True
        TextBoxUser.Text = ""
        TextBoxPassword.Text = ""
        TextBoxPriority.Text = ""
        TextBoxUser.Focus()
    End Sub

    Private Sub isiGridUser()
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM accountUser", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "accountUser")
        DataGridViewAccount.DataSource = ds.Tables("accountUser")
        DataGridViewAccount.Enabled = True
    End Sub

    Private Sub isiGridAdmin()
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM accountAdmin", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "accountAdmin")
        DataGridViewAccount.DataSource = ds.Tables("accountAdmin")
        DataGridViewAccount.Enabled = True
    End Sub
    Private Sub user()
        If TextBoxUser.Text = "" Or TextBoxPassword.Text = "" Or TextBoxPriority.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong (Refresh) ", MsgBoxStyle.Information, "Maaf")
            CheckBoxAdd.Enabled = True
        Else
            Dim sql As String
            Me.Cursor = Cursors.WaitCursor

            If DataAdd Then
                sql = "INSERT INTO [accountUser] ([username], [password], [priority]) VALUES('" & TextBoxUser.Text & "', '" & TextBoxPassword.Text & "', '" & TextBoxPriority.Text & "')"
            Else
                sql = "UPDATE [accountUser] SET [username]='" & TextBoxUser.Text & "', [password]='" & TextBoxPassword.Text & "', [priority]='" & TextBoxPriority.Text & "' WHERE ID =" & AccountId & " "
            End If
            jalankanSql(sql)
            Bersihkan()
            isiGridUser()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub admin()
        If TextBoxUser.Text = "" Or TextBoxPassword.Text = "" Or TextBoxPriority.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong", MsgBoxStyle.Information, "Maaf")
            CheckBoxAdd.Enabled = True
        Else
            Dim sql As String
            Me.Cursor = Cursors.WaitCursor

            If DataAdd Then
                sql = "INSERT INTO [accountAdmin] ([username], [password], [priority]) VALUES('" & TextBoxUser.Text & "', '" & TextBoxPassword.Text & "', '" & TextBoxPriority.Text & "')"
            Else
                sql = "UPDATE [accountAdmin] SET [username]='" & TextBoxUser.Text & "', [password]='" & TextBoxPassword.Text & "', [priority]='" & TextBoxPriority.Text & "' WHERE ID =" & AccountId & " "
            End If
            jalankanSql(sql)
            Bersihkan()
            isiGridUser()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub deluser()
        If AccountId <> "" Then
            Dim sql As String
            Dim pesan As Integer

            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & AccountId, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            sql = "DELETE FROM [accountUser] WHERE ID = " & AccountId

            jalankanSql(sql)
            Me.Cursor = Cursors.WaitCursor
            Bersihkan()
            CheckBoxAdd.Enabled = True
            isiGridUser()
            Me.Cursor = Cursors.Default

        End If
    End Sub
    Private Sub deladmin()
        If AccountId <> "" Then
            Dim sql As String
            Dim pesan As Integer

            pesan = MsgBox("Apakah anda yakin akan menghapus Data ID " & AccountId, vbExclamation + vbYesNo, "Perhatian")
            If pesan = vbNo Then Exit Sub

            sql = "DELETE FROM [accountAdmin] WHERE ID = " & AccountId

            jalankanSql(sql)
            Me.Cursor = Cursors.WaitCursor
            Bersihkan()
            CheckBoxAdd.Enabled = True
            isiGridUser()
            Me.Cursor = Cursors.Default

        End If
    End Sub
    Private Sub Keluar()
        Dim YesNo As Integer
        YesNo = MsgBox("Apakah Anda Yakin", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Keluar()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Bersihkan()
        UncheckedAll()
        CheckBoxUpdate.Enabled = False
        CheckBoxDel.Enabled = False
        NonaktifTextBox()
    End Sub
    Private Sub UncheckedAll()
        CheckBoxAdd.CheckState = CheckState.Unchecked
        CheckBoxUpdate.CheckState = CheckState.Unchecked
        CheckBoxDel.CheckState = CheckState.Unchecked
    End Sub
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If ComboBoxSel.SelectedIndex.Equals(0) Then
            If CheckBoxAdd.CheckState = CheckState.Unchecked And CheckBoxUpdate.CheckState = CheckState.Unchecked Then
                deladmin()
            Else
                admin()
            End If
            UncheckedAll()
            isiGridAdmin()
        ElseIf ComboBoxSel.SelectedIndex.Equals(1) Then
            If CheckBoxAdd.CheckState = CheckState.Unchecked And CheckBoxUpdate.CheckState = CheckState.Unchecked Then
                deluser()
            Else
                user()
            End If
            UncheckedAll()
            isiGridUser()
        End If
        FormDataAccount_Load(sender, e)

    End Sub
    Private Sub aktifChehckBox()
        CheckBoxAdd.Enabled = True
        CheckBoxUpdate.Enabled = True
        CheckBoxDel.Enabled = True
    End Sub
    Private Sub aktifTextBox()
        TextBoxUser.Enabled = True
        TextBoxPassword.Enabled = True
        TextBoxPriority.Enabled = True
    End Sub
    Private Sub NonAktifCheckBox()
        CheckBoxAdd.Enabled = False
        CheckBoxUpdate.Enabled = False
        CheckBoxDel.Enabled = False
    End Sub
    Private Sub NonaktifTextBox()
        TextBoxUser.Enabled = False
        TextBoxPassword.Enabled = False
        TextBoxPriority.Enabled = False
    End Sub
    Private Sub ComboBoxSel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSel.SelectedIndexChanged
        If ComboBoxSel.SelectedIndex.Equals(0) Then
            isiGridAdmin()
            CheckBoxAdd.Enabled = True
            CheckBoxUpdate.Enabled = False
            CheckBoxDel.Enabled = False
            NonaktifTextBox()
            UncheckedAll()
        ElseIf ComboBoxSel.SelectedIndex.Equals(1) Then
            isiGridUser()
            CheckBoxAdd.Enabled = True
            CheckBoxUpdate.Enabled = False
            CheckBoxDel.Enabled = False
            NonaktifTextBox()
            UncheckedAll()
        End If
    End Sub

    Private Sub FormDataAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NonAktifCheckBox()
        NonaktifTextBox()
        ButtonOK.Enabled = False
    End Sub

    Private Sub CheckBoxAdd_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAdd.CheckedChanged
        If CheckBoxAdd.CheckState = CheckState.Checked Then
            CheckBoxUpdate.Enabled = False
            CheckBoxUpdate.CheckState = CheckState.Unchecked
            CheckBoxDel.Enabled = False
            CheckBoxDel.CheckState = CheckState.Unchecked
            DataAdd = True
            ButtonOK.Enabled = True
            aktifTextBox()
            Bersihkan()
        Else
            NonaktifTextBox()
            Bersihkan()
        End If

    End Sub

    Private Sub CheckBoxUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUpdate.CheckedChanged
        If CheckBoxUpdate.CheckState = CheckState.Checked Then
            CheckBoxAdd.Enabled = False
            CheckBoxAdd.CheckState = CheckState.Unchecked
            CheckBoxDel.Enabled = False
            CheckBoxDel.CheckState = CheckState.Unchecked
            DataAdd = False
            aktifTextBox()
            ButtonOK.Enabled = True
        Else
            CheckBoxDel.Enabled = True
            NonaktifTextBox()
        End If
    End Sub

    Private Sub CheckBoxDel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDel.CheckedChanged
        If CheckBoxDel.CheckState = CheckState.Checked Then
            CheckBoxAdd.Enabled = False
            CheckBoxAdd.CheckState = CheckState.Unchecked
            CheckBoxUpdate.Enabled = False
            CheckBoxUpdate.CheckState = CheckState.Unchecked
            DataAdd = False
            NonaktifTextBox()
            ButtonOK.Enabled = True
        Else
            CheckBoxUpdate.Enabled = True
        End If
    End Sub
End Class
