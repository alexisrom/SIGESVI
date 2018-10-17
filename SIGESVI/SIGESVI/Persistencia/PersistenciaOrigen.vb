
Imports System.Data.Odbc

Public Class PersistenciaOrigen

    Sub Agregar(ByVal origen As Origen)
        Dim formato_consulta = "INSERT INTO origen(nombre, direccion, propietario) VALUES('{0}', '{1}', '{2}');"
        Dim consulta = String.Format(formato_consulta, origen.Nombre, origen.Direccion, origen.Propietario)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el nuevo origen")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub Modificar(ByVal origen As Origen)
        Dim formato_consulta = "UPDATE origen SET nombre = '{0}', direccion = '{1}', propietario = '{2}' WHERE id_origen = {3};"
        Dim consulta = String.Format(formato_consulta, origen.Nombre, origen.Direccion, origen.Propietario, origen.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery


            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo modificar el origen")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try

    End Sub


    Sub Eliminar(ByVal origen As Origen)
        Dim formato_consulta = "UPDATE origen SET activo = 'f' WHERE id_origen = {0};"
        Dim consulta = String.Format(formato_consulta, origen.ID)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim filas_afectadas = comando.ExecuteNonQuery


            If filas_afectadas <> 1 Then
                Throw New Exception("No se pudo eliminar el origen")
            End If

        Catch ex As Exception
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub


    Function Listar() As List(Of Origen)
        Dim origenes As New List(Of Origen)
        Dim consulta = "SELECT * FROM origen WHERE activo = 't'"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then

                While resultado.Read()
                    Dim origen As New Origen()
                    origen.ID = resultado("id_origen")
                    origen.Nombre = resultado("nombre")
                    origen.Direccion = resultado("direccion")
                    origen.Propietario = resultado("propietario")
                    origenes.Add(origen)
                End While

            End If
        Catch ex As Exception
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try

        Return origenes

    End Function


End Class
