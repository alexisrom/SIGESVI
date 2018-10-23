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

    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property


    Private _Duracion As Integer
    Public Property Duracion() As Integer
        Get
            Return _Duracion
        End Get
        Set(ByVal value As Integer)
            _Duracion = value
        End Set
    End Property


    Private _Recordatorios As List(Of Recordatorio)
    Public Property Recordatorios() As List(Of Recordatorio)
        Get
            Return _Recordatorios
        End Get
        Set(ByVal value As List(Of Recordatorio))
            _Recordatorios = value
        End Set
    End Property


    Sub New(ByVal id As Integer, ByVal numero As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal duracion As Integer)
        Me.ID = id
        Me.Numero = numero
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Duracion = Duracion
    End Sub

    Sub New()

    End Sub

    
End Class
