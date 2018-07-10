Module Validacion
    ' Sólo números
    ' Sólo letras
    Public Function solonumeros(ByVal e As TextBox) As Boolean
        If IsNumeric(e.Text) Then
            solonumeros = True
        End If
    End Function
    Public Function sololetras(ByVal e As TextBox) As Boolean
        If Not IsNumeric(e.Text) Then
            sololetras = True
        End If
    End Function
End Module
