Imports System.Data.Odbc

Module PersistenciaUsuario

    'TODO: Crear entidad Usuario, heredar desde funcionario y cliente 
    Function Login(ByVal user As String, ByVal pass As String) As Funcionario

        Dim formato_consulta = "SELECT * FROM funcionario WHERE usuario = ""{0}"" AND contrasena = ""{1}"" AND activo='t'"
        Dim consulta = String.Format(formato_consulta, user, pass)

        Try
            Dim comando As New OdbcCommand
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                resultado.Read()
                Dim ci = resultado("cedula")
                Dim sucursal = New PersistenciaSucursal().Buscar(resultado("id_sucursal"))
                Dim nombre = resultado("nombre")
                Dim apellido = resultado("apellido")
                Dim direccion = resultado("direccion")
                Dim cargo = resultado("cargo")


                Return New Funcionario(ci, sucursal, nombre, apellido, direccion, user, pass, cargo)

            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try



        Return Nothing
    End Function


End Module
