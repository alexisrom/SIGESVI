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

            BD.GuardarImagen(mp.Imagen, "especificacion_de_producto", "foto", "id_eproducto", mp.ID)

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
            BD.GuardarImagen(materiaPrima.Imagen, "especificacion_de_producto", "foto", "id_eproducto", materiaPrima.ID)
        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Function Listar() As List(Of MateriaPrima)
        Dim materiasPrimas As New List(Of MateriaPrima)
        Dim consulta = "SELECT ep.*, mp.*, tc.nombre nombre_tipo_cepa, tc.tipo tipo_tipo_cepa FROM especificacion_de_producto ep, materia_prima mp, tipo_cepa tc WHERE ep.id_eproducto = mp.id_eproducto AND mp.id_tipo_cepa = tc.id_tipo_cepa  AND activo = 't'"
        Dim stringConnection = "Database=sigesvi;Host=192.168.81.128;Server=ol_esi;Service=9088; Protocol=onsoctcp;UID=informix;Password=informix;"

        Dim conn As New IfxConnection
        conn.ConnectionString = stringConnection

        Try
            conn.Open()
            Dim cmd As New IfxCommand
            cmd.CommandText = consulta
            cmd.Connection = conn
            Dim res = cmd.ExecuteReader


            If res.HasRows Then
                While res.Read()

                    Dim mp As New MateriaPrima()
                    mp.ID = res("id_eproducto")
                    mp.Nombre = res("nombre")
                    mp.Descripcion = res("descripcion")
                    mp.Precio = res("precio")
                    mp.UnidadMedida = res("unidad_medida")
                    mp.Categoria = res("categoria")

                    Dim tipoCepa As New TipoCepa()
                    tipoCepa.ID = res("id_tipo_cepa")
                    tipoCepa.Nombre = res("nombre_tipo_cepa")
                    tipoCepa.Tipo = res("tipo_tipo_cepa")
                    mp.TipoCepa = tipoCepa


                    If Not TypeOf res("foto") Is DBNull Then
                        Dim pictureData As Byte() = DirectCast(res("foto"), Byte())

                        Dim picture As Image = Nothing

                        Using stream As New System.IO.MemoryStream(pictureData)
                            picture = Image.FromStream(stream)
                        End Using

                        mp.Imagen = picture
                    End If

                    materiasPrimas.Add(mp)
                End While
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return materiasPrimas
    End Function




End Class
