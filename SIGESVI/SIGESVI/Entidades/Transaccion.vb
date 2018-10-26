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


    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property


    Private _Productos As List(Of Lote)
    Public Property Productos() As List(Of Lote)
        Get
            Return _Productos
        End Get
        Set(ByVal value As List(Of Lote))
            _Productos = value
        End Set
    End Property


    Private _Sucursal As Sucursal
    Public Property Sucursal() As Sucursal
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As Sucursal)
            _Sucursal = value
        End Set
    End Property



    Sub New()
        _Productos = New List(Of Lote)
    End Sub
End Class
