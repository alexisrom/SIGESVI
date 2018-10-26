Imports System.Data.Odbc

Public Class PersistenciaUsuario
    Function Login(ByVal usuario As String, ByVal contrasena As String) As Usuario


        Dim formato_consulta = "SELECT * FROM {0} WHERE usuario='{1}' AND contrasena='{2}' AND activo = 't'"
        Dim consulta = String.Format(formato_consulta, "funcionario", usuario, contrasena)


        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim funcionario As New Funcionario()
                    funcionario.ID = resultado("cedula")
                    funcionario.Nombre = resultado("nombre")
                    funcionario.Apellido = resultado("apellido")
                    funcionario.Direccion = resultado("direccion")
                    funcionario.Username = resultado("usuario")
                    funcionario.Password = resultado("contrasena")
                    funcionario.Rol = resultado("cargo")
                    Dim persistenciaSucursal = New PersistenciaSucursal()
                    funcionario.Sucursal = persistenciaSucursal.Buscar(CInt(resultado("id_sucursal")))
                    Return funcionario
                End While
            End If

            comando.CommandText = String.Format(formato_consulta, "cliente", usuario, contrasena)
            resultado.Close()
            resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim c As New Cliente()
                    c.ID = resultado("id_cliente")
                    c.Nombre = resultado("nombre")
                    c.Direccion = resultado("direccion")
                    c.Telefono = resultado("telefono")
                    c.Username = usuario
                    c.Password = contrasena
                    c.Rol = "Cliente"
                    Return c
                End While
            End If



        Catch ex As OdbcException
            Throw ex
        End Try

        Return Nothing
    End Function
End Class
