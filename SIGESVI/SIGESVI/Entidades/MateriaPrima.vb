Public Class MateriaPrima

    Private _EstadoSanitario As String
    Public Property EstadoSanitario() As String
        Get
            Return _EstadoSanitario
        End Get
        Set(ByVal value As String)
            _EstadoSanitario = value
        End Set
    End Property

End Class
