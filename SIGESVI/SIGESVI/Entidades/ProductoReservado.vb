Public Class ProductoReservado

    Private _Producto As EspecificacionProducto
    Public Property Producto() As EspecificacionProducto
        Get
            Return _Producto
        End Get
        Set(ByVal value As EspecificacionProducto)
            _Producto = value
        End Set
    End Property


    Private _Cantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property


End Class
