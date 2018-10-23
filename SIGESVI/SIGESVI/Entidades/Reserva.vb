Public Class Reserva

    Private _Cliente As Cliente
    Public Property Cliente() As Cliente
        Get
            Return _Cliente
        End Get
        Set(ByVal value As Cliente)
            _Cliente = value
        End Set
    End Property

    Private _FechaHora As String
    Public Property FechaHora() As String
        Get
            Return _FechaHora
        End Get
        Set(ByVal value As String)
            _FechaHora = value
        End Set
    End Property

    'Pendiente, Completada
    Private _Estado As String
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

End Class
