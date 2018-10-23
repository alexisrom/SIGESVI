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



    Private _Elaboracion As List(Of EtapaElaboracion)
    Public Property Elaboracion() As List(Of EtapaElaboracion)
        Get
            Return _Elaboracion
        End Get
        Set(ByVal value As List(Of EtapaElaboracion))
            _Elaboracion = value
        End Set
    End Property


    Private _Imagen As System.Drawing.Image
    Public Property Imagen() As System.Drawing.Image
        Get
            Return _Imagen
        End Get
        Set(ByVal value As System.Drawing.Image)
            _Imagen = value
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


    Private _Tipo As String
    Public Property Tipo() As String
        Get

            If TypeOf Me Is MateriaPrima Then
                Return "MP"
            End If

            If TypeOf Me Is ProductoIntermedio Then
                Return "PI"
            End If

            Return "PF"

        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property


    Sub New()

    End Sub
    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal precio As Decimal, ByVal unidadmedida As String, ByVal elaboracion As List(Of EtapaElaboracion), ByVal imagen As Image, ByVal categoria As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Precio = precio
        Me.UnidadMedida = unidadmedida
        Me.Elaboracion = elaboracion
        Me.Imagen = imagen
        Me.Categoria = categoria
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
