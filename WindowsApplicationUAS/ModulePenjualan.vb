Imports System.Data.OleDb
Imports System.Data
Module ModulePenjualan
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public rd As OleDbDataReader
    Public Data As String

    Public Sub connection()
        Dim Path As String
        Path = ".\db.accdb;"
        Data = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Path & ";"
        conn = New OleDbConnection(Data)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub isiGrid()
        connection()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM penjualan", conn)
        da.Fill(ds, "penjualan")
    End Sub
    Public Sub jalankanSqlMem(ByVal sqlMem As String)
        cmd = New OleDbCommand
        connection()
        Try
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlMem
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Data Ditambah Untuk Member", MsgBoxStyle.Information, "CRUD")
        Catch 
        End Try
    End Sub
    Public Sub jalankanSql(ByVal sql As String)
        cmd = New OleDbCommand
        connection()
        Try
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Data Ditambah Untuk Penjualan", MsgBoxStyle.Information, "CRUD")
        Catch ex As Exception
            MsgBox("Data Penjualan Tidak Boleh Ada Yang Kosong", MsgBoxStyle.Information, "CRUD")

        End Try
    End Sub
End Module
