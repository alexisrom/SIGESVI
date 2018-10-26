Imports System.Data.Odbc

Public Class PersistenciaReserva

    Sub Agregar(ByVal r As Reserva)
        Dim consulta = "INSERT INTO reserva(fecha_hora, id_cliente) VALUES('{0}', {1})"
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = String.Format(consulta, DateToString(r.FechaHora), r.Cliente.ID)
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas = 0 Then
                Throw New Exception("No se pudo registrar la reserva")
            End If


            comando.CommandText = "SELECT id_reserva FROM reserva ORDER BY id_reserva DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            r.ID = resp("id_reserva")
            resp.Close()

            consulta = "INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES ({0}, {1}, {2})"
            For Each l In r.Lineas
                comando.CommandText = String.Format(consulta, r.ID, l.Producto.ID, l.Cantidad)
                filas_afectadas = comando.ExecuteNonQuery

                If filas_afectadas = 0 Then
                    Throw New Exception("No se pudo registrar la linea de reserva")
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function Listar() As List(Of Reserva)
        Dim reservas As New List(Of Reserva)

        Dim consulta = "SELECT * FROM reserva r, cliente c WHERE r.id_cliente = c.id_cliente AND r.activo = 't'"
        Try
            Dim cmd As New OdbcCommand
            cmd.Connection = Conexion.Abrir
            cmd.CommandText = consulta
            Dim res = cmd.ExecuteReader

            If res.HasRows Then

                While res.Read
                    Dim r As New Reserva
                    r.ID = res("id_reserva")
                    r.FechaHora = res("fecha_hora")
                    Dim cliente As New Cliente
                    cliente.Nombre = res("nombre")
                    r.Cliente = cliente
                    r.Lineas = ListarLineas(r.ID)
                    reservas.Add(r)
                End While

            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return reservas
    End Function

    Private Function ListarLineas(ByVal id_reserva As Integer) As List(Of LineaReserva)
        Dim lineas As New List(Of LineaReserva)

        Dim consulta = "SELECT * FROM contiene c, reserva r, especificacion_de_producto p WHERE r.id_reserva = c.id_reserva AND p.id_eproducto = c.id_eproducto AND r.id_reserva = {0}"
        Try
            Dim cmd As New OdbcCommand
            cmd.Connection = Conexion.Abrir
            cmd.CommandText = String.Format(consulta, id_reserva)
            Dim res = cmd.ExecuteReader

            If res.HasRows Then

                While res.Read
                    Dim l As New LineaReserva
                    l.Cantidad = res("cantidad")
                    Dim p As New EspecificacionProducto
                    p.Nombre = res("nombre")
                    p.ID = res("id_eproducto")
                    l.Producto = p
                    lineas.Add(l)
                End While

            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return lineas
    End Function

End Class
