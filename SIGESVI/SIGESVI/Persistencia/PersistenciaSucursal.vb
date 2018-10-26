Imports System.Data.Odbc

Public Class PersistenciaSucursal

    Sub Agregar(ByVal sucursal As Sucursal)
        Dim formato_consulta = "INSERT INTO sucursal(nombre, direccion, departamento, proveedor) VALUES(""{0}"", ""{1}"", ""{2}"", '{3}')"
        Dim proveedor = "f"

        If sucursal.Proveedor Then
            proveedor = "t"
        End If

        Dim consulta = String.Format(formato_consulta, sucursal.Nombre, sucursal.Direccion, sucursal.Departamento, proveedor)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar la sucursal")
            End If

            ' Se obtiene el ID de sucursal asignado automáticamente 
            comando.CommandText = "SELECT id_sucursal FROM sucursal ORDER BY id_sucursal DESC LIMIT 1"
            Dim resp = comando.ExecuteReader()
            resp.Read()
            sucursal.ID = resp("id_sucursal")

            AgregarTelefono(sucursal, comando.Connection)

        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub Eliminar(ByVal sucursal As Sucursal)
        Dim consulta = "UPDATE sucursal SET activo = 'f' WHERE id_sucursal =" & sucursal.ID
        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery


            If resultado <> 1 Then
                Throw New Exception("No se pudo eliminar la sucursal")
            End If


        Catch ex As OdbcException
            Throw ex
        Finally
            Conexion.Cerrar()
        End Try
    End Sub

    Sub Modificar(ByVal sucursal As Sucursal)
        Dim formato_consulta = "UPDATE sucursal SET nombre=""{0}"", direccion=""{1}"", departamento=""{2}"", proveedor='{3}' WHERE id_sucursal={4}"
        Dim proveedor = "f"

        If sucursal.Proveedor Then
            proveedor = "t"
        End If

        Dim consulta = String.Format(formato_consulta, sucursal.Nombre, sucursal.Direccion, sucursal.Departamento, proveedor, sucursal.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = Conexion.Abrir
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
            Conexion.Cerrar()
        End Try
    End Sub

    Function Buscar(ByVal id As Integer) As Sucursal

        Dim formato_consulta = "SELECT * FROM sucursal WHERE activo = 't' AND id_sucursal={0}"
        Dim consulta = String.Format(formato_consulta, id)

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                While resultado.Read()

                    Dim nombre = resultado("nombre")
                    Dim direccion = resultado("direccion")
                    Dim departamento = resultado("departamento")
                    Dim telefonos = ListarTelefonos(id, comando.Connection)
                    Dim proveedor = resultado("proveedor")

                    Return New Sucursal(id, nombre, direccion, departamento, telefonos, proveedor)
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            'Conexion.Cerrar()
        End Try

        Return Nothing
    End Function

    Function Listar() As List(Of Sucursal)

        Dim sucursales As New List(Of Sucursal)
        Dim consulta = "SELECT * FROM sucursal WHERE activo = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim id = resultado("id_sucursal")
                    Dim nombre = resultado("nombre")
                    Dim direccion = resultado("direccion")
                    Dim departamento = resultado("departamento")
                    Dim telefonos = ListarTelefonos(id, comando.Connection)
                    Dim proveedor = resultado("proveedor")
                    sucursales.Add(New Sucursal(id, nombre, direccion, departamento, telefonos, proveedor))
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return sucursales
    End Function
    Function ListarProveedores() As List(Of Sucursal)

        Dim sucursales As New List(Of Sucursal)
        Dim consulta = "SELECT * FROM sucursal WHERE activo = 't' AND proveedor = 't'"

        Try
            Dim comando As New OdbcCommand
            comando.Connection = Conexion.Abrir
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim id = resultado("id_sucursal")
                    Dim nombre = resultado("nombre")
                    Dim direccion = resultado("direccion")
                    Dim departamento = resultado("departamento")
                    Dim telefonos = ListarTelefonos(id, comando.Connection)
                    Dim proveedor = resultado("proveedor")
                    sucursales.Add(New Sucursal(id, nombre, direccion, departamento, telefonos, proveedor))
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

            'If filasAfectadas < 1 Then
            '    Throw New Exception("No se pudo eliminar los telefonos de la sucursal")
            'End If

        Catch ex As OdbcException
            Throw ex
        End Try
    End Sub

End Class
