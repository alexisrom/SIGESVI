Imports IBM.Data.Informix

Module BD
    Public HOST = "192.168.81.128"

    Sub GuardarImagen(ByVal imagen As Image, ByVal tabla As String, ByVal campo As String, ByVal clave As String, ByVal valor As Integer)


        If imagen Is Nothing Then
            Return
        End If


        Dim stringConnection = "Database=sigesvi;Host=" & HOST & ";Server=ol_esi;Service=9088; Protocol=onsoctcp;UID=informix;Password=informix;"

        Dim conn As New IfxConnection
        conn.ConnectionString = stringConnection

        Try
            conn.Open()
            Dim cmd As New IfxCommand
            cmd.CommandText = String.Format("UPDATE {0} SET {1} = (?) WHERE {2} = {3}", tabla, campo, clave, valor)
            cmd.Connection = conn

            Dim bitmapBytes As Byte()
            Using stream As New System.IO.MemoryStream
                imagen.Save(stream, imagen.RawFormat)
                bitmapBytes = stream.ToArray
            End Using

            Dim param As New IfxParameter
            param.Value = bitmapBytes
            param.IfxType = IfxType.Byte
            cmd.Parameters.Add(param)

            Dim filas = cmd.ExecuteNonQuery
            If filas = 0 Then
                Throw New Exception("No se pudo guardar la imagen")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Module
