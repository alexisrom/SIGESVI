Public Class Compra

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property


    Private _Costo As Decimal
    Public Property Costo() As Decimal
        Get
            Return _Costo
        End Get
        Set(ByVal value As Decimal)
            _Costo = value
        End Set
    End Property

    ' Tener el cuanta que se debera registrar el precio de compra de cada producto != precio producto
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
