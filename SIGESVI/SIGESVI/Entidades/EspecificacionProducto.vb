Public Class EspecificacionProducto

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property


    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property


    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property


    Private _Calidad As String
    Public Property Calidad() As String
        Get
            Return _Calidad
        End Get
        Set(ByVal value As String)
            _Calidad = value
        End Set
    End Property


    Private _Precio As Decimal
    Public Property Precio() As Decimal
        Get
            Return _Precio
        End Get
        Set(ByVal value As Decimal)
            _Precio = value
        End Set
    End Property


    Private _UnidadMedia As String
    Public Property UnidadMedida() As String
        Get
            Return _UnidadMedia
        End Get
        Set(ByVal value As String)
            _UnidadMedia = value
        End Set
    End Property


    Private _Medida As Integer
    Public Property Medida() As Integer
        Get
            Return _Medida
        End Get
        Set(ByVal value As Integer)
            _Medida = value
        End Set
    End Property



    Private _Recipiente As String
    Public Property Recipiente() As String
        Get
            Return _Recipiente
        End Get
        Set(ByVal value As String)
            _Recipiente = value
        End Set
    End Property


    Private _Elaboracion As List(Of EtapaElaboracion)
    Public Property Elaboracion() As List(Of EtapaElaboracion)
        Get
            Return _Elaboracion
        End Get
        Set(ByVal value As List(Of EtapaElaboracion))
            _Elaboracion = value
        End Set
    End Property


    Private _Categoria As String
    Public Property Categoria() As String
        Get
            Return _Categoria
        End Get
        Set(ByVal value As String)
            _Categoria = value
        End Set
    End Property



End Class
