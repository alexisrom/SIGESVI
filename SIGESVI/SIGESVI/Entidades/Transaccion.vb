Public Class Transaccion

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property


    Private _FechaHora As Date
    Public Property FechaHora() As Date
        Get
            Return _FechaHora
        End Get
        Set(ByVal value As Date)
            _FechaHora = value
        End Set
    End Property


End Class
