Imports System.Data.Odbc

Public Class PersistenciaTransaccion

    Sub AgregarCompra(ByVal compra As Compra)
        Dim formato_consulta = "INSERT INTO transaccion(fecha) VALUES({0}, '{1}', {2}, {3})"
        ' Dim consulta = String.Format(formato_consulta, FormatearFecha(compra.)

        Try
            Dim comando As New Odbccommand
            comando.Connection = Conexion.Abrir
            'comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery


            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo agregar el lote")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub



End Class
