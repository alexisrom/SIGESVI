Imports System.Data.Odbc

Public Class PersistenciaProductoIntermedio
    Sub Agregar(ByVal producto As ProductoIntermedio)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria, foto) VALUES(""{0}"",""{1}"",{2},""{3}"", ""{4}"", NULL) "
        Dim consulta = String.Format(formato_consulta, producto.Nombre, producto.Descripcion, producto.Precio, producto.UnidadMedida, producto.Categoria, producto.Imagen)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
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

            formato_consulta = "INSERT INTO producto_intermedio(id_eproducto, tipo) VALUES({0}, '{Yemo}');"
            consulta = String.Format(formato_consulta, producto.ID, producto.Calidad)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el producto final")
            End If





        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Function Listar() As List(Of ProductoIntermedio)

        Dim productos As New List(Of ProductoIntermedio)
        Dim consulta = "SELECT ep.*, pi.* FROM especificacion_de_producto ep, producto_intermedio pi WHERE ep.id_eproducto = pi.id_eproducto AND activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

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
                    productos.Add(p)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return productos
    End Function
End Class
