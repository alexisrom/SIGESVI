Public Class Lote

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

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


    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property



    Private _Origen As Sucursal
    Public Property Origen() As Sucursal
        Get
            Return _Origen
        End Get
        Set(ByVal value As Sucursal)
            _Origen = value
        End Set
    End Property




    Public Overrides Function ToString() As String

        Return Me.Tipo.Nombre & " (" & Me.Stock & ")"
    End Function

End Class
