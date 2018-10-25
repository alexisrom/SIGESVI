Imports System.Data.Odbc

Public Class PersistenciaEspecificacionProducto


    Public Sub Eliminar(ByVal especificacion As EspecificacionProducto)
        Dim formato_consulta = "UPDATE especificacion_de_producto SET activo = 'f' WHERE id_eproducto = {0}"
        Dim consulta = String.Format(formato_consulta, especificacion.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar el producto")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Function Listar() As List(Of EspecificacionProducto)

        Dim consulta = "SELECT * FROM especificacion_de_producto WHERE activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()

                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return Nothing
    End Function


    Function Buscar(ByVal id_eproducto As Integer) As EspecificacionProducto
        Dim formato_consulta = "SELECT * FROM especificacion_de_producto e, {0} p WHERE e.id_eproducto = p.id_eproducto AND e.id_eproducto={1} AND activo = 't'"


        Dim e As EspecificacionProducto
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = String.Format(formato_consulta, "materia_prima", id_eproducto)
            Dim resultado = comando.ExecuteReader


            If resultado.HasRows Then
                resultado.Read()
                e = New MateriaPrima
                e.Nombre = resultado("nombre")
                Return e
            End If


            resultado.Close()
            comando.CommandText = String.Format(formato_consulta, "producto_intermedio", id_eproducto)
            resultado = comando.ExecuteReader
            If resultado.HasRows Then
                resultado.Read()
                e = New ProductoIntermedio
                e.Nombre = resultado("nombre")
                Return e
            End If

            resultado.Close()
            comando.CommandText = String.Format(formato_consulta, "producto_final", id_eproducto)
            resultado = comando.ExecuteReader
            If resultado.HasRows Then
                resultado.Read()
                e = New ProductoFinal
                e.Nombre = resultado("nombre")
                Return e
            End If


        Catch ex As OdbcException
            Throw ex
        End Try

        Return Nothing
    End Function

End Class
