Imports System.Data.Odbc

Public Class PersistenciaTransaccion

    Sub Agregar(ByVal transaccion As Transaccion)
        Dim formato_consulta = "INSERT INTO transacciones(fecha_hora) VALUES('{0}')"
        Dim consulta = String.Format(formato_consulta, DateTimeToString(transaccion.Fecha))

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo registrar la transacción")
            End If

            'obtener id
            comando.CommandText = "SELECT id_transaccion FROM transacciones ORDER BY id_transaccion DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            transaccion.ID = resp("id_transaccion")
            resp.Close()


            If TypeOf transaccion Is Venta Then
                AgregarVenta(CType(transaccion, Venta), comando)
            ElseIf TypeOf transaccion Is Traslado Then
                AgregarTraslado(CType(transaccion, Traslado), comando)
            End If


            formato_consulta = "INSERT INTO involucra(id_lote, id_transaccion) VALUES({0}, {1})"
            For Each p In transaccion.Productos
                comando.CommandText = String.Format(formato_consulta, p.ID, transaccion.ID)
                filas_afectadas = comando.ExecuteNonQuery()

                If filas_afectadas = 0 Then
                    Throw New Exception("No se pudo registar el lote vendido")
                End If

            Next


        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

    End Sub

    Private Sub AgregarVenta(ByVal venta As Venta, ByVal comando As OdbcCommand)
        Try
            comando.CommandText = String.Format("INSERT INTO venta(id_transaccion, costo) VALUES({0}, {1})", venta.ID, venta.Precio)
            Dim filas_afectadas = comando.ExecuteNonQuery


            If filas_afectadas = 0 Then
                Throw New Exception("No se pudo registrar la venta")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AgregarTraslado(ByVal t As Traslado, ByVal comando As OdbcCommand)
        Try
            comando.CommandText = String.Format("INSERT INTO traslado(id_transaccion, id_transporte, destino) VALUES({0}, {1}, '{2}')", t.ID, t.Vehiculo.ID, t.Destino)
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas = 0 Then
                Throw New Exception("No se pudo registrar el traslado")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Function ListarVentas() As List(Of Venta)
        Dim ventas As New List(Of Venta)
        Dim formato_consulta = "SELECT * FROM transacciones t, venta v WHERE t.id_transaccion = v.id_transaccion"
        Dim consulta = formato_consulta
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim res = comando.ExecuteReader

            If res.HasRows Then
                While res.Read
                    Dim v As New Venta
                    v.Fecha = res("fecha_hora")
                    v.ID = res("id_transaccion")
                    v.Precio = res("costo")
                    ventas.Add(v)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()

        End Try

        Return ventas
    End Function

    Function ListarTraslados() As List(Of Traslado)
        Dim traslados As New List(Of Traslado)
        Dim formato_consulta = "SELECT * FROM transacciones t, traslado tr, transporte tra WHERE t.id_transaccion = tr.id_transaccion AND tr.id_transporte = tra.id_transporte"
        Dim consulta = formato_consulta
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim res = comando.ExecuteReader

            If res.HasRows Then
                While res.Read
                    Dim t As New Traslado
                    t.ID = res("id_transaccion")
                    t.Fecha = res("fecha_hora")
                    t.Destino = res("destino")
                    Dim v As New Transporte
                    v.Tipo = res("nombre")
                    v.Capacidad = res("capacidad")
                    t.Vehiculo = v
                    traslados.Add(t)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()

        End Try

        Return traslados
    End Function


End Class
