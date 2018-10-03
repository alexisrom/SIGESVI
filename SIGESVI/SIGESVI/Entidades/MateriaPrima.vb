Public Class MateriaPrima
    Inherits EspecificacionProducto



    Private _EstadoSanitario As String
    Public Property EstadoSanitario() As String
        Get
            Return _EstadoSanitario
        End Get
        Set(ByVal value As String)
            _EstadoSanitario = value
        End Set
    End Property


    Private _TipoCepa As String
    Public Property TipoCepa() As String
        Get
            Return _TipoCepa
        End Get
        Set(ByVal value As String)
            _TipoCepa = value
        End Set
    End Property


End Class
