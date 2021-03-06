﻿Imports System.Data.Odbc
Imports IBM.Data.Informix

Public Class PersistenciaProductoIntermedio

    Sub Agregar(ByVal producto As ProductoIntermedio)
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

            formato_consulta = "INSERT INTO producto_intermedio(id_eproducto, tipo) VALUES({0}, '{1}');"
            consulta = String.Format(formato_consulta, producto.ID, producto.Calidad)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el producto intermedio")
            End If
            BD.GuardarImagen(producto.Imagen, "especificacion_de_producto", "foto", "id_eproducto", producto.ID)
        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub


    Sub Modificar(ByVal producto As ProductoIntermedio)
        Dim formato_consulta = "UPDATE especificacion_de_producto SET nombre = '{0}', descripcion = '{1}', precio = {2} WHERE id_eproducto = {3} "
        Dim consulta = String.Format(formato_consulta, producto.Nombre, producto.Descripcion, producto.Precio, producto.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar la especificación de producto")
            End If

            formato_consulta = "UPDATE producto_intermedio SET tipo = '{0}' WHERE id_eproducto = {1} "
            consulta = String.Format(formato_consulta, producto.Calidad, producto.ID)

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar el producto intermedio")
            End If
            BD.GuardarImagen(producto.Imagen, "especificacion_de_producto", "foto", "id_eproducto", producto.ID)
        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub




    Function Listar() As List(Of ProductoIntermedio)
        Dim productos As New List(Of ProductoIntermedio)
        Dim consulta = "SELECT ep.*, pi.* FROM especificacion_de_producto ep, producto_intermedio pi WHERE ep.id_eproducto = pi.id_eproducto AND activo = 't'"
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

                    Dim p As New ProductoIntermedio()
                    p.ID = resultado("id_eproducto")
                    p.Nombre = resultado("nombre")
                    p.Descripcion = resultado("descripcion")
                    p.Precio = resultado("precio")
                    p.UnidadMedida = resultado("unidad_medida")
                    p.Categoria = resultado("categoria")
                    p.Calidad = resultado("tipo")

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



    Function Buscar(ByVal id_producto As Integer) As ProductoIntermedio

        Dim consulta = "SELECT e.* FROM producto_intermedio p, especificacion_de_producto e WHERE p.id_eproducto = e.id_eproducto AND  p.id_eproducto = " & id_producto

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader


            If resultado.HasRows Then
                resultado.Read()
                Dim m As New ProductoIntermedio
                m.Nombre = resultado("nombre")
                Return m
            End If

            Return Nothing

        Catch ex As OdbcException
            Throw ex
        End Try
    End Function


End Class
