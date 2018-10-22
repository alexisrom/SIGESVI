Imports System.Data.Odbc

Public Class PersistenciaLote

    Sub Agregar(ByVal lote As Lote)
        Dim formato_consulta = "INSERT INTO LOTE(cantidad, fecha, id_origen, id_eproducto) VALUES({0}, '{1}', {2}, {3})"
        Dim fecha = lote.Fecha.Day & "-" & lote.Fecha.Month & "-" & lote.Fecha.Date.Year
        Dim consulta = String.Format(formato_consulta, lote.Stock, fecha, lote.Origen.ID, lote.Tipo.ID)

        Try
            Dim comando As New Odbccommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
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

    Sub Modificar(ByVal lote As Lote)
        Dim formato_consulta = "UPDATE lote SET cantidad = {0} WHERE id_lote = {1}"
        Dim consulta = String.Format(formato_consulta, lote.Stock, lote.ID)

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo modificar el lote")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Sub Eliminar(ByVal lote As Lote)
        Dim formato_consulta = "UPDATE lote SET activo = 'f' WHERE id_lote = {0}"
        Dim consulta = String.Format(formato_consulta, lote.ID)

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo eliminar el lote")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Function Listar() As List(Of Lote)
        Dim lotes As New List(Of Lote)
        'Dim consulta = "SELECT * FROM lote l, especificacion_de_producto e, origen o WHERE l.id_eproducto = e.id_eproducto AND o.id_origen = l.id_origen AND e.activo = 't'"
        Dim consulta = "SELECT * FROM lote l, especificacion_de_producto e, origen o WHERE l.id_eproducto = e.id_eproducto AND o.id_origen = l.id_origen AND e.activo = 't'"
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read
                    Dim lote As New Lote
                    lote.ID = resultado("id_lote")
                    lote.Stock = resultado("cantidad")
                    lote.Fecha = resultado("fecha")
                    'lote.Tipo = New PersistenciaEspecificacionProducto.buscar
                    'lote.Origen = PersistenciaOrigen.Buscar
                    lotes.Add(lote)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

        Return lotes
    End Function


End Class
