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

End Class
