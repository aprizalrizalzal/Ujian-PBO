Imports System.Data.OleDb
Public Class FormPenjualan
    Dim DataAddPenjualan As Boolean
    Dim DataAddMember As Boolean
    Dim penjualanID As String

    Private Sub pilihIDMem()
        connection()
        da = New OleDbDataAdapter("SELECT * FROM member", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "member")
        ComboBoxIDMem.DataSource = (ds.Tables("member"))
        Me.ComboBoxIDMem.ValueMember = "idMember"
        Me.ComboBoxIDMem.DisplayMember = "idMember"
    End Sub
    Sub NomorOtomatis()
        connection()
        cmd = New OleDbCommand("SELECT * FROM member WHERE idMember IN (SELECT MAX(idMember) FROM member)", conn)
        Dim UrutId As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutId = "ID-M-P_" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutId = "ID-M-P_" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        ComboBoxIDMem.Text = UrutId
    End Sub
    Private Sub pilihjenisCetakVinil()
        connection()
        da = New OleDbDataAdapter("SELECT * FROM jenisCetakVinil", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenisCetakVinil")
        ComboBoxC.DataSource = (ds.Tables("jenisCetakVinil"))
        ComboBoxHar.DataSource = (ds.Tables("jenisCetakVinil"))
        Me.ComboBoxC.ValueMember = "ID"
        Me.ComboBoxC.DisplayMember = "jenisCetakVinil"
        Me.ComboBoxHar.ValueMember = "ID"
        Me.ComboBoxHar.DisplayMember = "harga" 
    End Sub
    Private Sub pilihjenisCetakOpset()
        connection()
        da = New OleDbDataAdapter("SELECT * FROM jenisCetakOpset", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenisCetakOpset")
        ComboBoxC.DataSource = (ds.Tables("jenisCetakOpset"))
        ComboBoxHar.DataSource = (ds.Tables("jenisCetakOpset"))
        Me.ComboBoxC.ValueMember = "ID"
        Me.ComboBoxC.DisplayMember = "jenisCetakOpset"
        Me.ComboBoxHar.ValueMember = "ID"
        Me.ComboBoxHar.DisplayMember = "harga"
    End Sub
    Private Sub KTTT()
        Dim waktu As Date = Now
        TextBoxTglTrns.Text = waktu.ToString("dd/MMMM/yyyy")
        TextBoxKdTrans.Text = "DP_" + waktu.ToString("ddMMyyyy_HHmmss")
    End Sub
    
    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBoxMeter.Enabled = False
        CheckBoxLembar.Enabled = False
        pilihIDMem()
        ComboBoxIDMem.Text = ""
        TextBoxNamaDP.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxNohpDP.Text = ""
        GroupBoxSemua.Hide()
        TextBoxNamaDP.Focus()
        KTTT()
        DataAddPenjualan = True
        ButtonCetak.Enabled = False
    End Sub
   
    Private Sub Keluar()
        Dim YesNo As Integer
        YesNo = MsgBox("Apakah Anda Yakin", vbQuestion + vbYesNo + vbDefaultButton2, "Exit")
        If YesNo = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub Tambah()
        DataAddPenjualan = True
        CheckBoxAddMem.CheckState = CheckState.Unchecked
        ComboBoxC.Text = ""
        TextBoxUPan.Text = ""
        TextBoxULeb.Text = ""
        ComboBoxHar.Text = ""
        TextBoxTotal.Text = ""
        KTTT()
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Keluar()
    End Sub
    Private Sub Bersihkan()
        DataAddPenjualan = False
        ComboBoxJC.Enabled = True
        CheckBoxMeter.CheckState = CheckState.Unchecked
        CheckBoxLembar.CheckState = CheckState.Unchecked
        TextBoxNamaDP.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxNohpDP.Text = ""
        TextBoxNamaDP.Focus()
        TextBoxJmlhU.Text = ""
        TextBoxTotalBiaya.Text = ""
        TextBoxKembalian.Text = ""
        KTTT()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        Dim sql As String
        Dim sqlMem As String

        Me.Cursor = Cursors.WaitCursor

        If DataAddPenjualan Then
            sql = "INSERT INTO [penjualan] ([nama], [alamat], [nohp], [tanggalTransaksi], [kodeTransaksi], [jenisBarang], [panjang], [lebar], [harga], [total]) VALUES('" & TextBoxNamaDP.Text & "', '" & TextBoxAlamat.Text & "', '" & TextBoxNohpDP.Text & "','" & TextBoxTglTrns.Text & "', '" & TextBoxKdTrans.Text & "', '" & ComboBoxC.Text & "','" & TextBoxUPan.Text & "', '" & TextBoxULeb.Text & "', '" & ComboBoxHar.Text & "','" & TextBoxTotal.Text & "')"
        Else
            sql = "" 'UPDATE [penjualan] SET [nama]='" & TextBoxNamaDP.Text & "',[alamat]='" & TextBoxAlamat.Text & "', [nohp]='" & TextBoxNohpDP.Text & "', [tanggalTransaksi]='" & TextBoxTglTrns.Text & "', [kodeTransaksi]='" & TextBoxKdTrans.Text & "', [jenisBarang]='" & TextBoxJnsBar.Text & "', [panjang]='" & TextBoxUPan.Text & "', [lebar]='" & TextBoxULeb.Text & "', [harga]='" & ComboBoxHar.Text & "', [total]='" & TextBoxTotal.Text & "' WHERE ID
        End If
        If CheckBoxAddMem.CheckState = CheckState.Checked Then
            sqlMem = "INSERT INTO [member] ([idMember],[nama], [alamat], [nohp]) VALUES('" & ComboBoxIDMem.Text & "','" & TextBoxNamaDP.Text & "', '" & TextBoxAlamat.Text & "', '" & TextBoxNohpDP.Text & "')"
        Else
            sqlMem = "UPDATE [memeber] SET [idMember]='" & ComboBoxIDMem.Text & "', [nama]='" & TextBoxNamaDP.Text & "',[alamat]='" & TextBoxAlamat.Text & "', [nohp]='" & TextBoxNohpDP.Text & "' WHERE idMember"
        End If
        jalankanSqlMem(sqlMem)
        jalankanSql(sql)
        Me.Cursor = Cursors.Default
        GroupBoxSemua.Show()
        DataGridViewTambah.Rows.Add(New String() {ComboBoxC.Text, TextBoxUPan.Text, TextBoxULeb.Text, ComboBoxHar.Text, TextBoxTotal.Text})
        FormFaktur.DataGridViewFaktur.Rows.Add(New String() {ComboBoxC.Text, TextBoxUPan.Text, TextBoxULeb.Text, ComboBoxHar.Text, TextBoxTotal.Text})
        Tambah()
        Subtotal()

    End Sub

    Private Sub TextBoxTotal_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotal.TextChanged
        TextBoxTotal.Text = Format(TextBoxTotal.Text, "Currency")
        TextBoxTotal.SelectionStart = TextBoxTotal.Text.Length
    End Sub

    Private Sub TextBoxJmlhU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxJmlhU.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
        ButtonCetak.Enabled = True
    End Sub

    Private Sub TextBoxJmlhU_TextChanged(sender As Object, e As EventArgs) Handles TextBoxJmlhU.TextChanged
        If TextBoxJmlhU.Text = "Rp" Then
            TextBoxJmlhU.Text = "0"
        End If
        TextBoxJmlhU.Text = Format(TextBoxJmlhU.Text, "Currency")
        TextBoxJmlhU.SelectionStart = TextBoxJmlhU.Text.Length
        Dim total As String
        total = TextBoxTotalBiaya.Text
        TextBoxKembalian.Text = TextBoxJmlhU.Text - total
    End Sub

    Private Sub TextBoxTotalBiaya_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotalBiaya.TextChanged
        TextBoxTotalBiaya.Text = Format(TextBoxTotalBiaya.Text, "Currency")
        TextBoxTotalBiaya.SelectionStart = TextBoxTotalBiaya.Text.Length
    End Sub

    Private Sub TextBoxKembalian_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKembalian.TextChanged
        TextBoxKembalian.Text = Format(TextBoxKembalian.Text, "Currency")
        TextBoxKembalian.SelectionStart = TextBoxKembalian.Text.Length
    End Sub
    Sub Subtotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridViewTambah.Rows.Count - 1
            Hitung = Hitung + DataGridViewTambah.Rows(i).Cells(4).Value
            TextBoxTotalBiaya.Text = Hitung
        Next
    End Sub

    Private Sub Print()
        FormFaktur.TextBoxTT.Text = TextBoxTglTrns.Text
        FormFaktur.TextBoxN.Text = TextBoxNamaDP.Text
        FormFaktur.TextBoxT.Text = TextBoxTotalBiaya.Text
        FormFaktur.TextBoxJU.Text = TextBoxJmlhU.Text
        FormFaktur.TextBoxK.Text = TextBoxJmlhU.Text
        Dim YesNo As Integer
        YesNo = MsgBox("Cetak", vbQuestion + vbYesNo + vbDefaultButton2, "Informasi")
        If YesNo = vbYes Then
            FormFaktur.Show()
            FormFaktur.PrintFormFaktur.PrintAction = Printing.PrintAction.PrintToPrinter
            FormFaktur.PrintFormFaktur.Print(FormFaktur, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            FormFaktur.Close()
        End If

    End Sub

    Private Sub TextBoxNohpDP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNohpDP.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    
    Private Sub TextBoxUPan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUPan.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub TextBoxULeb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxULeb.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub ComboBoxHar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxHar.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub ButtonBersihkan_Click(sender As Object, e As EventArgs) Handles ButtonBersihkan.Click
        ComboBoxJC.Text = Nothing
        DataGridViewTambah.Rows.Clear()
        Bersihkan()
        Tambah()
    End Sub

    Private Sub ComboBoxJC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJC.SelectedIndexChanged
        If ComboBoxJC.SelectedIndex.Equals(0) Then
            pilihjenisCetakVinil()
            LabelUP.Text = "Panjang"
            LabelUL.Text = "Lebar"
            CheckBoxMeter.CheckState = CheckState.Checked
            CheckBoxLembar.Enabled = False
            ColumnU1.HeaderText = LabelUP.Text
            ColumnU2.HeaderText = LabelUL.Text
            ComboBoxJC.Enabled = False
        ElseIf ComboBoxJC.SelectedIndex.Equals(1) Then
            pilihjenisCetakOpset()
            LabelUP.Text = "Ukuran"
            LabelUL.Text = "Banyak"
            CheckBoxLembar.CheckState = CheckState.Checked
            CheckBoxMeter.Enabled = False
            ColumnU1.HeaderText = LabelUP.Text
            ColumnU2.HeaderText = LabelUL.Text
            ComboBoxJC.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxHar_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxHar.TextChanged
        ComboBoxHar.Text = Format(ComboBoxHar.Text, "Currency")
        ComboBoxHar.SelectionStart = ComboBoxHar.Text.Length
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Print()
    End Sub

    Private Sub ComboBoxIDMem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIDMem.SelectedIndexChanged
            cmd = New OleDbCommand("SELECT * FROM member WHERE idMember='" & ComboBoxIDMem.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
        If rd.HasRows Then
            TextBoxNamaDP.Text = rd.Item("nama")
            TextBoxAlamat.Text = rd.Item("alamat")
            TextBoxNohpDP.Text = rd.Item("nohp")
        End If
    End Sub
    Private Sub CheckBoxAddMem_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAddMem.CheckedChanged
        If CheckBoxAddMem.CheckState = CheckState.Checked Then
            NomorOtomatis()
            TextBoxNamaDP.Text = ""
            TextBoxAlamat.Text = ""
            TextBoxNohpDP.Text = ""
        Else
            ComboBoxIDMem.Text = ""
            ComboBoxC.Focus()
        End If
    End Sub

    Private Sub TextBoxULeb_TextChanged(sender As Object, e As EventArgs) Handles TextBoxULeb.TextChanged
        Dim hasil As String
        hasil = ComboBoxHar.Text
        TextBoxTotal.Text = Val(TextBoxUPan.Text) * Val(TextBoxULeb.Text) * hasil
    End Sub

End Class