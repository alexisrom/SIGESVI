﻿Imports System.Data.Odbc

Public Class PersistenciaFuncionario

    Public Sub Agregar(ByVal funcionario As Funcionario)
        Dim consulta = "INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES "
        consulta &= "('" & funcionario.Cedula & "', '" & funcionario.Sucursal.ID & "', '" & funcionario.Nombre & "','" & funcionario.Apellido & "', '" & funcionario.Direccion & "', '" & funcionario.Usuario & "', '" & funcionario.Contrasena & "', '" & funcionario.Cargo & "');"

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el funcionario")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Modificar(ByVal funcionario As Funcionario)
        Dim formato_consulta = "UPDATE funcionario SET id_sucursal=""{0}"", nombre=""{1}"", apellido=""{2}"", direccion=""{3}"", usuario=""{4}"", contrasena=""{5}"", cargo=""{6}"" WHERE cedula={7}"
        Dim consulta = String.Format(formato_consulta, funcionario.Sucursal.ID, funcionario.Nombre, funcionario.Apellido, funcionario.Direccion, funcionario.Usuario, funcionario.Contrasena, funcionario.Cargo, funcionario.Cedula)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar el funcionario")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Eliminar(ByVal funcionario As Funcionario)
        Dim consulta = "UPDATE funcionario SET activo = 'f' WHERE cedula =" & funcionario.Cedula
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar el funcionario")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Conectar()
        End Try
    End Sub


    Function Listar() As List(Of Funcionario)

        Dim funcionarios As New List(Of Funcionario)

        Dim consulta = "SELECT * FROM funcionario WHERE activo = 't'"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim funcionario As New Funcionario()
                    funcionario.Cedula = resultado("cedula")
                    funcionario.Nombre = resultado("nombre")
                    funcionario.Apellido = resultado("apellido")
                    funcionario.Direccion = resultado("direccion")
                    funcionario.Usuario = resultado("usuario")
                    funcionario.Contrasena = resultado("contrasena")
                    funcionario.Cargo = resultado("cargo")
                    Dim persistenciaSucursal = New PersistenciaSucursal()
                    Dim sucursal = PersistenciaSucursal.Buscar(CInt(resultado("id_sucursal")))
                    funcionarios.Add(funcionario)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return funcionarios
    End Function

    Function ListarPorSucursal(ByVal id_sucursal As Integer) As List(Of Funcionario)

        Dim funcionarios As New List(Of Funcionario)

        Dim formato_consulta = "SELECT * FROM funcionario WHERE activo = 't' AND id_sucursal=""{0}"""
        Dim consulta = String.Format(formato_consulta, id_sucursal)
        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim funcionario As New Funcionario()
                    funcionario.Cedula = resultado("cedula")
                    funcionario.Nombre = resultado("nombre")
                    funcionario.Apellido = resultado("apellido")
                    funcionario.Direccion = resultado("direccion")
                    funcionario.Usuario = resultado("usuario")
                    funcionario.Contrasena = resultado("contrasena")
                    funcionario.Cargo = resultado("cargo")
                    Dim sucursal = New PersistenciaSucursal().Buscar(CInt(resultado("id_sucursal")))
                    funcionarios.Add(funcionario)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return funcionarios
    End Function
End Class
