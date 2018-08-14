Imports System.Data.Odbc
Imports System.Net
Module conexion
    Public conectar As New Odbc.OdbcConnection
    Public comando As New Odbc.OdbcCommand
    Public dbcon As OdbcConnection
    Public dbconexionexitosa As Boolean = True
    Public Sub conecta()
        conectar.ConnectionString = "FILEDSN=" & Application.StartupPath & "\midsn;UID=informix;PWD=informix"
        comando.Connection = conectar
        Try
            conectar.Open()
        Catch ex As OdbcException
            MsgBox("atencion " & ex.Message.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            dbconexionexitosa = False
        End Try
    End Sub
    Public Sub cierra()
        conectar.Close()
    End Sub
End Module
