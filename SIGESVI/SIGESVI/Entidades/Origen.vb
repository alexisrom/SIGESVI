Public Class Origen

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
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


    Private _Propietario As String
    Public Property Propietario() As String
        Get
            Return _Propietario
        End Get
        Set(ByVal value As String)
            _Propietario = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal direccion As String, ByVal propietario As String)

    End Sub

End Class
