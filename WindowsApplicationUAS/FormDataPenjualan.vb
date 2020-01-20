Imports System.Data.OleDb
Public Class FormDataPenjualan
    Private Sub DataPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM penjualan", conn)
        da.Fill(ds, "penjualan")
        DataGridViewPenjualan.DataSource = ds.Tables("penjualan")
        DataGridViewPenjualan.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintFormDP.PrintAction = Printing.PrintAction.PrintToPrinter
        PrintFormDP.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.Refresh()
    End Sub

End Class