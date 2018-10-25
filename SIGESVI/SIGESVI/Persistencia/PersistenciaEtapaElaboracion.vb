Imports System.Data.Odbc

Public Class PersistenciaEtapaElaboracion

    Sub AgregarEtapas(ByVal especificacionProdicto As EspecificacionProducto)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir

            For Each etapa In especificacionProdicto.Elaboracion
                Dim formato_consulta = "INSERT INTO etapa_de_elaboracion(nombre, numero, descripcion, duracion, ideproducto) VALUES(""{0}"", {1}, ""{2}"", {3}, {4})"
                Dim consulta = String.Format(formato_consulta, etapa.Nombre, etapa.Numero, etapa.Descripcion, etapa.Duracion, especificacionProdicto.ID)
                comando.CommandText = consulta
                Dim resultado = comando.ExecuteNonQuery
                If resultado <> 1 Then
                    Throw New Exception("No se pudo agregar la etapa de elaboración: " & etapa.Nombre)
                End If

                comando.CommandText = "SELECT id_etapa FROM etapa_de_elaboracion ORDER BY id_etapa DESC LIMIT 1"
                Dim resp = comando.ExecuteReader()
                resp.Read()
                etapa.ID = resp("id_etapa")
                resp.Close()

                AgregarRecordatorio(etapa, comando)

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

    Sub AgregarRecordatorio(ByVal etapa As EtapaElaboracion, ByVal comando As OdbcCommand)
        Dim formato_consulta = "INSERT INTO recordatorio(mensaje, dia, id_etapa) VALUES('{0}', {1}, {2})"
        For Each r In etapa.Recordatorios

            comando.CommandText = String.Format(formato_consulta, r.Mensaje, r.Dia, etapa.ID)

            If comando.ExecuteNonQuery = 0 Then
                Throw New Exception("No se pudo agregar el recordatorio")
            End If

        Next
    End Sub

    Function Listar(ByVal id_eproducto As Integer) As List(Of EtapaElaboracion)
        Dim etapas As New List(Of EtapaElaboracion)
        Dim formato_consulta = "SELECT * FROM etapa_de_elaboracion WHERE id_eproducto = {0}"
        Dim consulta = String.Format(formato_consulta, id_eproducto)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader


            If resultado.HasRows Then

                While resultado.Read
                    Dim etapa As New EtapaElaboracion
                    etapa.ID = resultado("id_etapa")
                    etapa.Numero = resultado("numero")
                    etapa.Nombre = resultado("nombre")
                    etapa.Duracion = resultado("duracion")
                    'etapa.Recordatorios 
                    etapas.Add(etapa)
                End While

            End If

        Catch ex As OdbcException
            Throw ex
        End Try
        Return etapas
    End Function


End Class
