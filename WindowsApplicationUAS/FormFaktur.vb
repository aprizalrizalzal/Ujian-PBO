Public Class FormFaktur

    Private Sub FormStruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Focus()
        Dim waktu As Date = Now
        TextBoxTT.Text = waktu.ToString("dd/MMMM/yyyy")
        If FormPenjualan.ComboBoxJC.SelectedIndex.Equals(0) Then
            FormPenjualan.LabelUP.Text = "Panjang / Meter"
            FormPenjualan.LabelUL.Text = "Lebar / Meter"
            ColumnU1F.HeaderText = FormPenjualan.LabelUP.Text
            ColumnU2F.HeaderText = FormPenjualan.LabelUL.Text
        ElseIf FormPenjualan.ComboBoxJC.SelectedIndex.Equals(1) Then
            FormPenjualan.LabelUP.Text = "Ukuran / Lembar"
            FormPenjualan.LabelUL.Text = "Banyak / Lembar"
            ColumnU1F.HeaderText = FormPenjualan.LabelUP.Text
            ColumnU2F.HeaderText = FormPenjualan.LabelUL.Text
        End If
    End Sub

    Private Sub TextBoxN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxN.TextChanged
        TextBoxN.Text = FormPenjualan.TextBoxNamaDP.Text
    End Sub

    Private Sub TextBoxT_TextChanged(sender As Object, e As EventArgs) Handles TextBoxT.TextChanged
        TextBoxT.Text = Format(TextBoxT.Text, "Currency")
        TextBoxT.SelectionStart = TextBoxT.Text.Length
        TextBoxT.Text = FormPenjualan.TextBoxTotalBiaya.Text
    End Sub

    Private Sub TextBoxJU_TextChanged(sender As Object, e As EventArgs) Handles TextBoxJU.TextChanged
        TextBoxJU.Text = Format(TextBoxJU.Text, "Currency")
        TextBoxJU.SelectionStart = TextBoxJU.Text.Length
        TextBoxJU.Text = FormPenjualan.TextBoxJmlhU.Text
    End Sub

    Private Sub TextBoxK_TextChanged(sender As Object, e As EventArgs) Handles TextBoxK.TextChanged
        TextBoxK.Text = Format(TextBoxK.Text, "Currency")
        TextBoxK.SelectionStart = TextBoxK.Text.Length
        TextBoxK.Text = FormPenjualan.TextBoxKembalian.Text
    End Sub

    Private Sub DataGridViewFaktur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFaktur.CellContentClick
        FormPenjualan.DataGridViewTambah.Rows.Add(New String() {FormPenjualan.ComboBoxC.Text, FormPenjualan.TextBoxUPan.Text, FormPenjualan.TextBoxULeb.Text, FormPenjualan.ComboBoxHar.Text, FormPenjualan.TextBoxTotal.Text})
    End Sub

   
    Private Sub TextBoxTT_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTT.TextChanged
        TextBoxTT.Text = FormPenjualan.TextBoxTglTrns.Text
    End Sub

End Class
