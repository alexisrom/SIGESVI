Public Class Venta

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property



    Private Precio As Decimal
    Public Property NewProperty() As Decimal
        Get
            Return Precio
        End Get
        Set(ByVal value As Decimal)
            Precio = value
        End Set
    End Property



    Private _Productos As List(Of EspecificacionProducto)
    Public Property Productos() As List(Of EspecificacionProducto)
        Get
            Return _Productos
        End Get
        Set(ByVal value As List(Of EspecificacionProducto))
            _Productos = value
        End Set
    End Property


End Class
