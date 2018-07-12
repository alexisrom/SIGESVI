Module Validacion
    ' Sólo números
    ' Sólo letras
    Public Function solonumeros(ByVal e As TextBox) As Boolean
        If IsNumeric(e.Text)  Then
            solonumeros = True
        End If
    End Function
    Public Function sololetras(ByVal e As TextBox) As Boolean
        If Not IsNumeric(e.Text) Then
            sololetras = True
        End If
    End Function
    Public Function vacio(ByVal e As TextBox) As Boolean
        If e.Text = "" Then
            vacio = True
        End If
    End Function

    Public Function cedulavalida(ByVal e As TextBox) As Boolean
        If solonumeros(e) Then
            If e.Text > 900000 And e.Text < 60000000 Then
                cedulavalida = True
            End If
        End If
    End Function
    Public Function vaciolistbox(ByVal e As ListBox) As Boolean
        If e.Items.Count < 1 Then
            Return True
        End If

    End Function
End Module
