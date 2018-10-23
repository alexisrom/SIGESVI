Module Conexion

    Private _Conexion As New Odbc.OdbcConnection

    Sub New()
        _Conexion.ConnectionString = "FILEDSN=" & Application.StartupPath & "\sigesvi.dsn;UID=informix;PWD=informix"
    End Sub


    Public Function Abrir()
        If _Conexion.State = ConnectionState.Closed Then
            _Conexion.Open()
        End If
        Return _Conexion
    End Function

    Public Sub Cerrar()
        If _Conexion.State = ConnectionState.Open Then
            _Conexion.Close()
        End If
    End Sub

End Module
