Imports System.Data.Odbc

Public Class PersistenciaFuncionario

    Function Login(ByVal user As String, ByVal password As String) As Funcionario
        Dim funcionario As Funcionario
        Dim consulta = "SELECT * FROM funcionario WHERE activo = 't' AND "
        consulta &= "usuario = '" & user & "' AND contrasena = '" & password & "'"

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                funcionario = New Funcionario()
                While resultado.Read()
                    funcionario.Cedula = resultado("cedula")
                    funcionario.Nombre = resultado("nombre")
                    funcionario.Apellido = resultado("apellido")
                    funcionario.FechaNacimiento = resultado("fecha_nacimiento")
                    funcionario.Direccion = resultado("direccion")
                    funcionario.User = user
                    funcionario.Password = password
                    funcionario.Cargo = resultado("cargo")
                    funcionario.Sucursal = New PersistenciaSucursal().Buscar(resultado("id_sucursal"))
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try

        Return funcionario
    End Function
End Class
