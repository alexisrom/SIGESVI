Imports System.Data.Odbc

Public Class PersistenciaEspecificacionProducto
    Public Sub Agregar(ByVal especificacion As EspecificacionProducto)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria) VALUES(""{0}"",{1},{2},""{3}"", ""quitar este campo"") "
        Dim consulta = String.Format(formato_consulta, especificacion.Nombre, especificacion.Descripcion, especificacion.Precio, especificacion.UnidadMedida)

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
            especificacion.ID = resp("id_eproducto")

            If TypeOf especificacion Is MateriaPrima Then
                formato_consulta = "INSERT INTO materia_prima(id_eproducto, estado_sanitario, tipo_cepa) VALUES({0}, ""eliminar campo"", ""{1}"")"
                consulta = String.Format(formato_consulta, especificacion.ID, CType(especificacion, MateriaPrima).TipoCepa)
            End If


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Public Function modificar()
        Return Nothing
    End Function

    Public Function eliminar()
        Return Nothing
    End Function
End Class
