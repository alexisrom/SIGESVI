Public Class Produccion


    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
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


    Private _Producto As EspecificacionProducto
    Public Property Producto() As EspecificacionProducto
        Get
            Return _Producto
        End Get
        Set(ByVal value As EspecificacionProducto)
            _Producto = value
        End Set
    End Property


    Private _FechaInicio As Date
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property


    Private _FechaFin As Date
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
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



    Private _EtapasRecorridas As List(Of EtapaRecorrida)
    Public Property EtapasRecorridas() As List(Of EtapaRecorrida)
        Get
            Return _EtapasRecorridas
        End Get
        Set(ByVal value As List(Of EtapaRecorrida))
            _EtapasRecorridas = value
        End Set
    End Property


End Class
