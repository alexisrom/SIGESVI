Public Class Compra
    Inherits Transaccion


    Private _Costo As Decimal
    Public Property Costo() As Decimal
        Get
            Return _Costo
        End Get
        Set(ByVal value As Decimal)
            _Costo = value
        End Set
    End Property



End Class
