Imports System.Data.Odbc

Public Class PersistenciaEtapaElaboracion

    Sub AgregarEtapas(ByVal especificacionProdicto As EspecificacionProducto)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir

            For Each etapa In especificacionProdicto.Elaboracion
                Dim formato_consulta = "INSERT INTO transporte(nombre, numero, descripcion, duracion, ideproducto) VALUES(""{0}"", {1}, ""{2}"", {3}, {4})"
                Dim consulta = String.Format(formato_consulta, etapa.Nombre, etapa.Numero, etapa.Descripcion, etapa.Duracion, especificacionProdicto.ID)
                comando.CommandText = consulta
                Dim resultado = comando.ExecuteNonQuery
                If resultado <> 1 Then
                    Throw New Exception("No se pudo agregar la etapa de elaboración: " & etapa.Nombre)
                End If
            Next

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub EliminarEtapas(ByVal especificacionProdicto As EspecificacionProducto)

        Dim formato_consulta = "DELETE FROM etapa_de_elaboracion WHERE id_eproducto = {0}"
        Dim consulta = String.Format(formato_consulta, especificacionProdicto.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery
            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar las etapas de elaboracion")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub AgregarRecordatorio()

    End Sub

End Class
