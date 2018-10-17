Imports System.Data.Odbc

Public Class PersistenciaTipoCepa


    Public Sub Agregar(ByVal tipoCepa As TipoCepa)
        Dim formato_consulta = "INSERT INTO tipo_cepa(nombre, tipo) VALUES(""{0}"", ""{1}"")"
        Dim consulta = String.Format(formato_consulta, tipoCepa.Nombre, tipoCepa.Tipo)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo agregar el tipo de cepa")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Public Sub Modificar(ByVal tipoCepa As TipoCepa)
        Dim formato_consulta = "UPDATE tipo_cepa SET nombre=""{0}"", tipo=""{1}"" WHERE id_tipo_cepa = {2}"
        Dim consulta = String.Format(formato_consulta, tipoCepa.Nombre, tipoCepa.Tipo, tipoCepa.ID)

        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteNonQuery

            If resultado <> 1 Then
                Throw New Exception("No se pudo modificar el tipo de cepa")
            End If

        Catch ex As OdbcException
            Throw ex
        Finally
            ModuloConexion.Cerrar()
        End Try
    End Sub

    Public Function ListarTodas() As List(Of TipoCepa)
        Dim tiposCepas As New List(Of TipoCepa)
        Dim consulta = "SELECT * FROM tipo_cepa"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                While resultado.Read()
                    Dim id = resultado("id_tipo_cepa")
                    Dim nombre = resultado("nombre")
                    Dim tipo = resultado("tipo")
                    tiposCepas.Add(New TipoCepa(id, nombre, tipo))
                End While
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return tiposCepas
    End Function

    Public Function Buscar(ByVal id As Integer) As TipoCepa

        Dim consulta = "SELECT * FROM tipo_cepa"
        Dim comando As New OdbcCommand

        Try
            comando.Connection = New Conexion().Conectar()
            comando.CommandText = consulta
            Dim resultado = comando.ExecuteReader

            If resultado.HasRows Then
                resultado.Read()
                Dim tipoCepa As New TipoCepa()
                tipoCepa.ID = resultado("id_tipo_cepa")
                tipoCepa.Nombre = resultado("nombre")
                tipoCepa.Tipo = resultado("tipo")
                Return tipoCepa
            End If

        Catch ex As OdbcException
            Throw ex
        End Try

        Return Nothing
    End Function


    Function Listar(ByVal id_sucursal As Integer) As Integer

        Return 0
    End Function



End Class
