Imports System.Data.Odbc

Public Class PersistenciaTrazabilidad

    Sub AgregarEtapa(ByVal produccion As Produccion, ByVal etapaRecorrida As EtapaRecorrida)
        Dim formato_consulta = "INSERT INTO recorre(id_produccion, id_etapa, fecha_inicio, fecha_fin, observacion) VALUES({0}, {1}, '{2}', '{3}', '{4}')"
        Dim consulta = String.Format(formato_consulta, produccion.ID, etapaRecorrida.Etapa.ID, FormatearFecha(etapaRecorrida.FechaInicio), FormatearFecha(etapaRecorrida.FechaFin), etapaRecorrida.Observacion)

        Try
            Dim comando As New OdbcCommand
            comando.CommandText = consulta
            comando.Connection = Conexion.Abrir
            Dim filasAfectadas = comando.ExecuteNonQuery

            If filasAfectadas = 0 Then
                Throw New Exception("No se pudo agregar la etapa a la trazabilidad")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Sub AgregarAlarma(ByVal produccion As Produccion, ByVal etapaRecorrida As EtapaRecorrida, ByVal alarma As Alarma)
        Dim formato_consulta = "INSERT INTO alarma(id_produccion, id_etapa, fecha, duracion, mensaje) VALUES({0}, {1}, '{2}', {3}, '{4}')"
        Dim consulta = String.Format(formato_consulta, produccion.ID, etapaRecorrida.Etapa.ID, FormatearFecha(alarma.Fecha), alarma.Duracion, alarma.Mensaje)

        Try
            Dim comando As New OdbcCommand
            comando.CommandText = consulta
            comando.Connection = Conexion.Abrir
            Dim filasAfectadas = comando.ExecuteNonQuery

            If filasAfectadas = 0 Then
                Throw New Exception("No se pudo agregar la alarma")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function BuscarAlarma(ByVal produccion As Produccion, ByVal etapaRecorrida As EtapaRecorrida) As Alarma
        Dim formato_consulta = "SELECT * FROM recorre r, alarma a WHERE r.id_produccion = a.id_produccion AND r.id_etapa = a.id_etapa AND r.id_produccion={0} AND r.id_etapa={1}"
        Dim consulta = String.Format(formato_consulta, produccion.ID, etapaRecorrida.Etapa.ID)
        Try
            Dim comando As New OdbcCommand
            comando.CommandText = consulta
            comando.Connection = Conexion.Abrir
            Dim resultado = comando.ExecuteReader


            If resultado.HasRows Then
                resultado.Read()
                Dim a As New Alarma
                a.Fecha = resultado("fecha")
                a.Duracion = resultado("duracion")
                a.Mensaje = resultado("mensaje")
                Return a
            End If

            Return Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ListarTodasLasAlarmas() As List(Of Alarma)
        Dim alarmas As New List(Of Alarma)
        Dim formato_consulta = "SELECT * FROM recorre r, alarma a WHERE r.id_produccion = a.id_produccion AND r.id_etapa = a.id_etapa"
        Dim consulta = String.Format(formato_consulta)
        Try
            Dim comando As New OdbcCommand
            comando.CommandText = consulta
            comando.Connection = Conexion.Abrir
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read
                    Dim a As New Alarma
                    a.Fecha = resultado("fecha")
                    a.Duracion = resultado("duracion")
                    a.Mensaje = resultado("mensaje")
                    alarmas.Add(a)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
        Return alarmas
    End Function

End Class
