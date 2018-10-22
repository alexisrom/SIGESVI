Imports System.Data.Odbc

Public Class PersistenciaCliente

    Public Sub Agregar(ByVal cliente As Cliente)
        Dim formato_consulta = "INSERT INTO cliente (id_cliente, nombre, direccion, telefono) VALUES ({0}, '{1}', '{2}', '{3}')"
        Dim consulta = String.Format(formato_consulta, cliente.CI, cliente.Nombre, cliente.Direccion, cliente.Telefono)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo registrar al cliente")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Public Sub Modificar(ByVal cliente As Cliente)
        Dim formato_consulta = "UPDATE cliente SET nombre = '{0}', direccion = '{1}', telefono = '{2}' WHERE id_cliente = {3}"
        Dim consulta = String.Format(formato_consulta, cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.CI)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar los datos del cliente")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub


    Public Sub Eliminar(ByVal cliente As Cliente)
        Dim formato_consulta = "UPDATE cliente SET activo = 'f' WHERE id_cliente = {0}"
        Dim consulta = String.Format(formato_consulta, cliente.CI)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar al cliente")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub



    Function Listar() As List(Of Cliente)

        Dim clientes As New List(Of Cliente)

        Dim consulta = "SELECT * FROM cliente WHERE activo = 't'"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim cliente As New Cliente()
                    cliente.CI = resultado("id_cliente")
                    cliente.Nombre = resultado("nombre")
                    cliente.Direccion = resultado("direccion")
                    cliente.Telefono = resultado("telefono")
                    'cliente.Usuario = resultado("usuario")
                    'cliente.Contrasena = resultado("contrasena")
                    
                    clientes.Add(cliente)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return clientes
    End Function
End Class
