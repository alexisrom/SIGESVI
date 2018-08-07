Public Class ProductoIntermedio

    Private _Insumos As MateriaPrima
    Public Property Insumos() As MateriaPrima
        Get
            Return _Insumos
        End Get
        Set(ByVal value As MateriaPrima)
            _Insumos = value
        End Set
    End Property

End Class
