Public Class Transaccion

    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property


    Private Productos As List(Of EspecificacionProducto)
    Public Property NewProperty() As List(Of EspecificacionProducto)
        Get
            Return Productos
        End Get
        Set(ByVal value As List(Of EspecificacionProducto))
            Productos = value
        End Set
    End Property


End Class
