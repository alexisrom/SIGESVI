﻿Imports System.Data.Odbc

Public Class PersistenciaMateriaPrima

    Sub Agregar(ByVal materiaPrima As MateriaPrima)
        Dim formato_consulta = "INSERT INTO especificacion_de_producto(nombre, descripcion, precio,unidad_medida, categoria, foto) VALUES(""{0}"",""{1}"",{2},""{3}"", ""{4}"", NULL) "
        Dim consulta = String.Format(formato_consulta, materiaPrima.Nombre, materiaPrima.Descripcion, materiaPrima.Precio, materiaPrima.UnidadMedida, materiaPrima.Categoria, materiaPrima.Imagen)

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
            materiaPrima.ID = resp("id_eproducto")
            resp.Close()

            formato_consulta = "INSERT INTO materia_prima(id_eproducto, id_tipo_cepa, estado_sanitario) VALUES({0}, {1}, ""borrar este campo"");"
            consulta = String.Format(formato_consulta, materiaPrima.ID, materiaPrima.TipoCepa.ID)
            comando.CommandText = consulta
            resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la materia prima")
            End If


            'AgregarEtapas(Sucursal, comando.Connection)


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Modificar(ByVal materiaPrima As MateriaPrima)
        Dim formato_consulta = "UPDATE especificacion_de_producto SET nombre = '{0}', descripcion = '{1}', precio = {2}, categoria = '{3}', foto = NULL WHERE id_eproducto = {4}"
        Dim consulta = String.Format(formato_consulta, materiaPrima.Nombre, materiaPrima.Descripcion, materiaPrima.Precio, materiaPrima.Categoria, materiaPrima.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
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


            'AgregarEtapas(Sucursal, comando.Connection)


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Eliminar(ByVal materiaPrima As MateriaPrima)
        Dim formato_consulta = "UPDATE especificacion_de_producto SET activo = 'f' WHERE id_eproducto = {0}"
        Dim consulta = String.Format(formato_consulta, materiaPrima.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar la especificación del producto")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Function Listar() As List(Of MateriaPrima)

        Dim materiasPrimas As New List(Of MateriaPrima)
        Dim consulta = "SELECT ep.*, mp.*, tc.nombre nombre_tipo_cepa, tc.tipo tipo_tipo_cepa FROM especificacion_de_producto ep, materia_prima mp, tipo_cepa tc WHERE ep.id_eproducto = mp.id_eproducto AND mp.id_tipo_cepa = tc.id_tipo_cepa  AND activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = New Conexion().Conectar()
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
        End Try

        Return materiasPrimas
    End Function

    Function ListarEtapas(ByVal id_eproducto As Integer, ByRef conexion As OdbcConnection) As List(Of String)
        Dim telefonos As New List(Of String)
        Dim consulta = "SELECT * FROM etapa_de_elaboracion WHERE id_eproducto = " & id_eproducto
        Dim comando As New OdbcCommand
        Try
            comando.Connection = conexion
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            While resultado.Read()
                'telefonos.Add(resultado("telefono"))
            End While

        Catch ex As OdbcException
            Throw ex
        End Try
        Return telefonos
    End Function

End Class