Imports System.Data.Odbc

Public Class PersistenciaCompra


    Sub Registrar(ByVal compra As Compra)
        Dim formato_consulta = "INSERT INTO transacciones(fecha_hora) VALUES('{0}')"
        Dim consulta = String.Format(formato_consulta, FormatearFechaHora(compra.Fecha))

        Try
            Dim comando As New OdbcCommand
            comando.CommandText = consulta
            comando.Connection = Conexion.Abrir
            Dim filas_afectadas = comando.ExecuteNonQuery

            If filas_afectadas = 0 Then
                Throw New Exception("No se pudo registrar la transacción")
            End If

            comando.CommandText = "SELECT id_transaccion FROM transacciones ORDER BY id_transaccion DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            compra.ID = resp("id_transaccion")
            resp.Close()

            formato_consulta = "INSERT INTO compra(id_transaccion, costo) VALUES({0}, {1})"
            consulta = String.Format(formato_consulta, compra.ID, compra.Costo)
            comando.CommandText = consulta

            If comando.ExecuteNonQuery <> 1 Then
                Throw New Exception("No se pudo registrar la compra")
            End If

            For Each l In compra.Productos
                RegistrarLotes(l, compra, comando)
            Next

        Catch ex As Exception
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Private Sub RegistrarLotes(ByVal lote As Lote, ByVal compra As Compra, ByVal comando As OdbcCommand)
        Dim formato_consulta = "INSERT INTO LOTE(cantidad, fecha, id_origen, id_eproducto) VALUES({0}, '{1}', {2}, {3})"
        Dim consulta = String.Format(formato_consulta, lote.Stock, FormatearFecha(lote.Fecha), lote.Origen.ID, lote.Tipo.ID)

        Try
            comando.CommandText = consulta

            If comando.ExecuteNonQuery <> 1 Then
                Throw New Exception("No se pudo agregar el lote")
            End If

            comando.CommandText = "SELECT id_lote FROM lote ORDER BY id_lote DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            lote.ID = resp("id_lote")
            resp.Close()

            formato_consulta = "INSERT INTO involucra(id_lote, id_transaccion) VALUES({0}, {1})"
            consulta = String.Format(formato_consulta, lote.ID, compra.ID)
            comando.CommandText = consulta

            If comando.ExecuteNonQuery <> 1 Then
                Throw New Exception("No se pudo agregar el lote")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Function Listar() As List(Of Compra)
        Dim compras As New List(Of Compra)
        Dim formato_consulta = "SELECT * FROM transacciones t, compra c WHERE t.id_transaccion = c.id_transaccion"
        Dim consulta = formato_consulta

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim res = comando.ExecuteReader

            If res.HasRows Then
                While res.Read
                    Dim c As New Compra
                    c.Fecha = res("fecha_hora")
                    c.ID = res("id_transaccion")
                    c.Costo = res("costo")
                    compras.Add(c)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

        Return compras
    End Function

End Class
