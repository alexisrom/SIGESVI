Public Class LineaReserva

    Private _cantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property


    Private _Producto As EspecificacionProducto
    Public Property Producto() As EspecificacionProducto
        Get
            Return _Producto
        End Get
        Set(ByVal value As EspecificacionProducto)
            _Producto = value
        End Set
    End Property

End Class
