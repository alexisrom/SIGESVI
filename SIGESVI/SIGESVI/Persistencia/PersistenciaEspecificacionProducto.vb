Imports System.Data.Odbc

Public Class PersistenciaEspecificacionProducto
    Public Sub Agregar(ByVal ep As EspecificacionProducto)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria) VALUES(""{0}"",{1},{2},""{3}"", ""{4}"") "
        Dim consulta = String.Format(formato_consulta, ep.Nombre, ep.Descripcion, ep.Precio, ep.UnidadMedida, ep.Categoria)

        Try
            Dim comando As New OdbcCommand
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se agregar la nueva especificación")
            End If

            ' Se obtiene el ID de especificacion asignado automáticamente 
            comando.CommandText = "SELECT id_eproducto FROM especificacion_de_producto ORDER BY id_eproducto DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            ep.ID = resp("id_eproducto")

            If TypeOf ep Is MateriaPrima Then
                formato_consulta = "INSERT INTO materia_prima(id_eproducto, estado_sanitario, tipo_cepa) VALUES({0}, ""eliminar campo"", ""{1}"")"
                consulta = String.Format(formato_consulta, ep.ID, CType(ep, MateriaPrima).TipoCepa)
            End If


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Public Function Modificar(ByVal especificacion As EspecificacionProducto)
        Return Nothing
    End Function

    Public Function Eliminar(ByVal especificacion As EspecificacionProducto)
        Return Nothing
    End Function

    Function Listar() As List(Of Sucursal)

        Dim consulta = "SELECT * FROM especificacion_de_producto WHERE activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = New Conexion().Conectar()
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
End Class
