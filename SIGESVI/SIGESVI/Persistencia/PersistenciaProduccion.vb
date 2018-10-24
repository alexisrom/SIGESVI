Imports System.Data.Odbc

Public Class PersistenciaProduccion


    Sub Agregar(ByVal produccion As Produccion)
        Dim formato_consulta = "INSERT INTO produccion(id_sucursal, id_eproducto, fecha_inicio, fecha_fin, cantidad) VALUES({0}, {1}, '{2}', '{3}', {4})"
        Dim consulta = String.Format(formato_consulta, produccion.Sucursal.ID, produccion.Producto.ID, FormatearFecha(produccion.FechaInicio), FormatearFecha(produccion.FechaFin), produccion.Cantidad)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la producción")
            End If

            'obtener id generado
            comando.CommandText = "SELECT id_produccion FROM produccion ORDER BY id_produccion DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            produccion.ID = resp("id_produccion")

            For Each e In produccion.Producto.Elaboracion
                formato_consulta = "INSERT INTO recorre(id_produccion, id_etapa, fecha_inico, fecha_fin, etapa_actual )"

            Next

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Sub Modificar(ByVal produccion As Produccion)
        Dim formato_consulta = "UPDATE produccion SET fecha_inicio = '{0}', fecha_fin = '{1}', cantidad={2} WHERE id_produccion = {3}"
        Dim consulta = String.Format(formato_consulta, FormatearFecha(produccion.FechaInicio), FormatearFecha(produccion.FechaFin), produccion.Cantidad, produccion.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar la producción")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Sub Eliminar(ByVal produccion As Produccion)
        Dim formato_consulta = "UPDATE produccion SET activo = 'f' WHERE id_produccion = {0}"
        Dim consulta = String.Format(formato_consulta, produccion.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar la producción")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Function Listar() As List(Of Produccion)
        Dim produccion As New List(Of Produccion)
        Dim consulta = "SELECT * FROM produccion WHERE activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim p As New Produccion
                    p.ID = resultado("id_produccion")
                    p.Sucursal = New PersistenciaSucursal().Buscar(resultado("id_sucursal"))
                    p.Producto = New PersistenciaProductoFinal().Buscar(resultado("id_eproducto"))
                    p.FechaInicio = resultado("fecha_inicio")
                    p.FechaFin = resultado("fecha_fin")
                    p.Cantidad = resultado("cantidad")
                    produccion.Add(p)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return produccion
    End Function

    Function ObtenerTrazabilidad(ByVal produccion As Produccion) As List(Of EtapaRecorrida)
        Dim trazabilidad As New List(Of EtapaRecorrida)
        Dim formato_consulta = "SELECT r.*, e.* FROM produccion p, recorre r, etapa_de_elaboracion e WHERE p.id_produccion = r.id_produccion AND r.id_etapa = e.id_etapa AND p.id_produccion={0} AND activo = 't'"
        Dim consulta = String.Format(formato_consulta, produccion.ID)
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then

                While resultado.Read()
                    Dim er As New EtapaRecorrida
                    er.Etapa = New EtapaElaboracion
                    er.Etapa.ID = resultado("id_etapa")
                    er.Etapa.Numero = resultado("numero")
                    er.Etapa.Nombre = resultado("nombre")
                    er.Etapa.Duracion = resultado("duracion")
                    'etapaRecorrida.Etapa.Recordatorios = resultado("id_etapa")
                    er.FechaInicio = resultado("fecha_inicio")
                    er.FechaFin = resultado("fecha_fin")
                    er.Observacion = resultado("observacion")
                    er.Alarma = New PersistenciaTrazabilidad().BuscarAlarma(produccion, er)
                    trazabilidad.Add(er)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
        Return trazabilidad
    End Function
End Class
