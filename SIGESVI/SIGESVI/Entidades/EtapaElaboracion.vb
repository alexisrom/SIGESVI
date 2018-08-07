Public Class EtapaElaboracion

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    ' Número que indica el orden de sucesión de la etapa
    Private _Numero As Integer
    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
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


    Private _Duracion As Date
    Public Property Duracion() As Date
        Get
            Return _Duracion
        End Get
        Set(ByVal value As Date)
            _Duracion = value
        End Set
    End Property





End Class
