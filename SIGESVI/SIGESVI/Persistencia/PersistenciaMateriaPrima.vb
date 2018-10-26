Imports System.Data.Odbc
Imports System.Text
Imports IBM.Data.Informix

Public Class PersistenciaMateriaPrima

    Sub Agregar(ByVal mp As MateriaPrima)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria, foto) VALUES(""{0}"",""{1}"",{2},""{3}"", ""{4}"", null) "
        Dim consulta = String.Format(formato_consulta, mp.Nombre, mp.Descripcion, mp.Precio, mp.UnidadMedida, mp.Categoria)

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
            mp.ID = resp("id_eproducto")
            resp.Close()

            formato_consulta = "INSERT INTO materia_prima(id_eproducto, id_tipo_cepa, estado_sanitario) VALUES({0}, {1}, ""borrar este campo"");"
            consulta = String.Format(formato_consulta, mp.ID, mp.TipoCepa.ID)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la materia prima")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub Modificar(ByVal materiaPrima As MateriaPrima)
        Dim formato_consulta = "UPDATE especificacion_de_producto SET nombre = '{0}', descripcion = '{1}', precio = {2}, categoria = '{3}', foto = NULL WHERE id_eproducto = {4}"
        Dim consulta = String.Format(formato_consulta, materiaPrima.Nombre, materiaPrima.Descripcion, materiaPrima.Precio, materiaPrima.Categoria, materiaPrima.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar la especificación del producto")
            End If

            formato_consulta = "UPDATE materia_prima SET id_tipo_cepa = {0} WHERE id_eproducto = {1}"
            consulta = String.Format(formato_consulta, materiaPrima.TipoCepa.ID, materiaPrima.ID)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar la materia prima")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Function Listar() As List(Of MateriaPrima)

        Dim materiasPrimas As New List(Of MateriaPrima)
        Dim consulta = "SELECT ep.*, mp.*, tc.nombre nombre_tipo_cepa, tc.tipo tipo_tipo_cepa FROM especificacion_de_producto ep, materia_prima mp, tipo_cepa tc WHERE ep.id_eproducto = mp.id_eproducto AND mp.id_tipo_cepa = tc.id_tipo_cepa  AND activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim mp As New MateriaPrima()
                    mp.ID = resultado("id_eproducto")
                    mp.Nombre = resultado("nombre")
                    mp.Descripcion = resultado("descripcion")
                    mp.Precio = resultado("precio")
                    mp.UnidadMedida = resultado("unidad_medida")
                    mp.Categoria = resultado("categoria")

                    Dim tipoCepa As New TipoCepa()
                    tipoCepa.ID = resultado("id_tipo_cepa")
                    tipoCepa.Nombre = resultado("nombre_tipo_cepa")
                    tipoCepa.Tipo = resultado("tipo_tipo_cepa")

                    mp.TipoCepa = tipoCepa

                    materiasPrimas.Add(mp)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try

        Return materiasPrimas
    End Function



End Class
