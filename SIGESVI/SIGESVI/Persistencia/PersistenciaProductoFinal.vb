Imports System.Data.Odbc
Imports IBM.Data.Informix

Public Class PersistenciaProductoFinal

    Sub Agregar(ByVal producto As ProductoFinal)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria, foto) VALUES(""{0}"",""{1}"",{2},""{3}"", ""{4}"", NULL) "
        Dim consulta = String.Format(formato_consulta, producto.Nombre, producto.Descripcion, producto.Precio, producto.UnidadMedida, producto.Categoria, producto.Imagen)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la especificación de producto")
            End If

            ' Se obtiene el ID de sucursal asignado automáticamente 
            comando.CommandText = "SELECT id_eproducto FROM especificacion_de_producto ORDER BY id_eproducto DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            producto.ID = resp("id_eproducto")
            resp.Close()

            AgregarEtapas(producto, comando.Connection)

            formato_consulta = "INSERT INTO producto_final(id_eproducto, crianza, embotellamiento) VALUES({0}, '{1}', '{2}');"
            consulta = String.Format(formato_consulta, producto.ID, producto.Crianza, producto.Embotellamiento)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el producto final")
            End If



            BD.GuardarImagen(producto.Imagen, "especificacion_de_producto", "foto", "id_eproducto", producto.ID)

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub AgregarEtapas(ByVal producto As ProductoFinal, ByVal conn As OdbcConnection)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = conn

            For Each etapa In producto.Elaboracion
                Dim formato_consulta = "INSERT INTO etapa_de_elaboracion(nombre, numero, descripcion, duracion, id_eproducto) VALUES(""{0}"", {1}, ""{2}"", {3}, {4})"
                Dim consulta = String.Format(formato_consulta, etapa.Nombre, etapa.Numero, etapa.Descripcion, etapa.Duracion, producto.ID)
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
        End Try
    End Sub

    Sub AgregarRecordatorio(ByVal etapa As EtapaElaboracion, ByVal comando As OdbcCommand)
        Dim formato_consulta = "INSERT INTO recordatorio(mensaje, numero_dia, id_etapa) VALUES('{0}', {1}, {2})"
        For Each r In etapa.Recordatorios

            comando.CommandText = String.Format(formato_consulta, r.Mensaje, r.Dia, etapa.ID)

            If comando.ExecuteNonQuery = 0 Then
                Throw New Exception("No se pudo agregar el recordatorio")
            End If

        Next
    End Sub



    Function Listar() As List(Of ProductoFinal)
        Dim productos As New List(Of ProductoFinal)
        Dim consulta = "SELECT ep.*, pf.* FROM especificacion_de_producto ep, producto_final pf WHERE ep.id_eproducto = pf.id_eproducto AND activo = 't'"
        Dim stringConnection = "Database=sigesvi;Host=" & BD.HOST & ";Server=ol_esi;Service=9088; Protocol=onsoctcp;UID=informix;Password=informix;"

        Dim conn As New IfxConnection
        conn.ConnectionString = stringConnection

        Try
            conn.Open()
            Dim cmd As New IfxCommand
            cmd.CommandText = consulta
            cmd.Connection = conn
            Dim resultado = cmd.ExecuteReader


            If resultado.HasRows Then
                While resultado.Read()
                    Dim p As New ProductoFinal()
                    p.ID = resultado("id_eproducto")
                    p.Nombre = resultado("nombre")
                    p.Descripcion = resultado("descripcion")
                    p.Precio = resultado("precio")
                    p.UnidadMedida = resultado("unidad_medida")
                    p.Categoria = resultado("categoria")
                    p.Crianza = resultado("crianza")
                    p.Embotellamiento = resultado("embotellamiento")
                    p.Elaboracion = New PersistenciaEtapaElaboracion().Listar(p.ID)

                    If Not TypeOf resultado("foto") Is DBNull Then
                        Dim pictureData As Byte() = DirectCast(resultado("foto"), Byte())

                        Dim picture As Image = Nothing

                        Using stream As New System.IO.MemoryStream(pictureData)
                            picture = Image.FromStream(stream)
                        End Using

                        p.Imagen = picture
                    End If

                    productos.Add(p)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return productos
    End Function

    Function Buscar(ByVal id As Integer) As ProductoFinal

        Dim formato_consulta = "SELECT ep.*, pf.* FROM especificacion_de_producto ep, producto_final pf WHERE ep.id_eproducto = pf.id_eproducto AND activo = 't' AND ep.id_eproducto={0}"
        Dim consulta = String.Format(formato_consulta, id)
        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                resultado.Read()
                Dim p As New ProductoFinal()
                p.ID = resultado("id_eproducto")
                p.Nombre = resultado("nombre")
                p.Descripcion = resultado("descripcion")
                p.Precio = resultado("precio")
                p.UnidadMedida = resultado("unidad_medida")
                p.Categoria = resultado("categoria")
                p.Crianza = resultado("crianza")
                p.Embotellamiento = resultado("embotellamiento")
                p.Elaboracion = New PersistenciaEtapaElaboracion().Listar(p.ID)
                Return p
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return Nothing
    End Function

End Class
