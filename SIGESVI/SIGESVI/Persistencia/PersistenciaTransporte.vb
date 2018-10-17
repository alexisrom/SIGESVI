Imports System.Data.Odbc

Public Class PersistenciaTransporte

    Sub Agregar(ByVal transporte As Transporte)
        Dim formato_consulta = "INSERT INTO transporte(tipo, capacidad) VALUES(""{0}"", {1})"
        Dim consulta = String.Format(formato_consulta, transporte.Tipo, transporte.Capacidad)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el vehículo")
            End If
        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Sub Modificar(ByVal transporte As Transporte)
        Dim formato_consulta = "UPDATE transporte SET tipo = ""{0}"", capacidad = {1} WHERE id_transporte = {2}"
        Dim consulta = String.Format(formato_consulta, transporte.Tipo, transporte.Capacidad, transporte.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el vehículo")
            End If
        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Public Function Listar() As List(Of Transporte)
        Dim transportes As New List(Of Transporte)
        Dim consulta = "SELECT * FROM transporte"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim id = resultado("id_transporte")
                    Dim nombre = resultado("tipo")
                    Dim capacidad = CInt(resultado("capacidad"))
                    transportes.Add(New Transporte(id, nombre, capacidad))
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return transportes
    End Function


End Class
