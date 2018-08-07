Public Class Lote
    
    Private _Tipo As EspecificacionProducto
    Public Property Tipo() As EspecificacionProducto
        Get
            Return _Tipo
        End Get
        Set(ByVal value As EspecificacionProducto)
            _Tipo = value
        End Set
    End Property

    Private _Stock As Integer
    Public Property Stock() As Integer
        Get
            Return _Stock
        End Get
        Set(ByVal value As Integer)
            _Stock = value
        End Set
    End Property




End Class
