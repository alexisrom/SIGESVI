Public Class Campo

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


    Private _Propietario As String
    Public Property Propietario() As String
        Get
            Return _Propietario
        End Get
        Set(ByVal value As String)
            _Propietario = value
        End Set
    End Property


End Class
