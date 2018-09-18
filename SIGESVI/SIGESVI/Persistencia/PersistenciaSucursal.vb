Imports System.Data.Odbc

Public Class PersistenciaSucursal

    Sub Agregar(ByVal sucursal As Sucursal)
        Dim consulta = "INSERT INTO sucursal (nombre, direccion, departamento) VALUES"
        consulta &= "('" & sucursal.Nombre & "', '" & sucursal.Direccion & "', '" & sucursal.Departamento & "');"

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la sucursal")
            End If

            comando.CommandText = "SELECT id_sucursal FROM sucursal ORDER BY id_sucursal DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            sucursal.ID = resp("id_sucursal")

            AgregarTelefono(sucursal, comando.Connection)


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Eliminar(ByVal sucursal As Sucursal)
        Dim consulta = "UPDATE sucursal SET activo = 'f' WHERE id_sucursal =" & sucursal.ID
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar la sucursal")
            End If


        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Conectar()
        End Try
    End Sub

    Sub Modificar(ByVal sucursal As Sucursal)
        Dim consulta = "UPDATE sucursal SET "
        consulta &= "nombre = '" & sucursal.Nombre & "',"
        consulta &= "direccion = '" & sucursal.Direccion & "',"
        consulta &= "departamento = '" & sucursal.Departamento & "'"
        consulta &= "WHERE id_sucursal = '" & sucursal.ID & "'"

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar la sucursal")
            End If

            EliminarTelefonos(sucursal, comando.Connection)
            AgregarTelefono(sucursal, comando.Connection)

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Function Buscar(ByVal id As Integer) As List(Of Sucursal)
        Dim sucursales As New List(Of Sucursal)
        Dim consulta = "SELECT * FROM sucursal WHERE activo = 't' AND "
        consulta &= "id_sucursal = " & id & ""

        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                While resultado.Read()
                    Dim sucursal As New Sucursal()
                    sucursal.ID = resultado("id_sucursal")
                    sucursal.Nombre = resultado("nombre")
                    sucursal.Direccion = resultado("direccion")
                    sucursal.Departamento = resultado("departamento")
                    sucursal.Telefonos = ListarTelefonos(sucursal.ID, comando.Connection)
                    sucursales.Add(sucursal)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try

        Return sucursales
    End Function

    Function Listar() As List(Of Sucursal)

        Dim sucursales As New List(Of Sucursal)
        Dim consulta = "SELECT * FROM sucursal WHERE activo = 't'"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = ModuloConexion.Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim sucursal As New Sucursal()
                    sucursal.ID = resultado("id_sucursal")
                    sucursal.Nombre = resultado("nombre")
                    sucursal.Direccion = resultado("direccion")
                    sucursal.Departamento = resultado("departamento")
                    sucursal.Telefonos = ListarTelefonos(sucursal.ID, comando.Connection)
                    sucursales.Add(sucursal)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return sucursales
    End Function

    Private Sub AgregarTelefono(ByVal sucursal As Sucursal, ByRef conexion As OdbcConnection)
        Dim comando As New OdbcCommand

        Dim consulta = "INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES "

        Try
            comando.Connection = conexion

            For Each tel As String In sucursal.Telefonos

                comando.CommandText = consulta & "(" & sucursal.ID & ", '" & tel & "' )"
                Dim resultado = comando.ExecuteNonQuery

                If resultado <> 1 Then
                    Throw New Exception("No se pudo asignar el teléfono " & tel & " a la sucursal")
                End If
            Next

        Catch ex As OdbcException
            Throw ex
        End Try
    End Sub

    Function ListarTelefonos(ByVal id_sucursal As Integer, ByRef conexion As OdbcConnection) As List(Of String)
        Dim telefonos As New List(Of String)
        Dim consulta = "SELECT * FROM telefono_sucursal WHERE id_sucursal = " & id_sucursal
        Dim comando As New OdbcCommand
        Try
            comando.Connection = conexion
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            While resultado.Read()
                telefonos.Add(resultado("telefono"))
            End While

        Catch ex As OdbcException
            Throw ex
        End Try
        Return telefonos
    End Function

    Private Sub EliminarTelefonos(ByVal sucursal As Sucursal, ByVal conexion As OdbcConnection)

        Dim comando As New OdbcCommand

        Dim consulta = "DELETE FROM telefono_sucursal WHERE id_sucursal = " & sucursal.ID

        Try
            comando.Connection = conexion
            comando.CommandText = consulta
            Dim filasAfectadas = comando.ExecuteNonQuery()

            If filasAfectadas < 1 Then
                Throw New Exception("No se pudo eliminar los telefonos de la sucursal")
            End If

        Catch ex As OdbcException
            Throw ex
        End Try
    End Sub

End Class
