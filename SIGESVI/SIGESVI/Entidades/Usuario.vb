Public Class Usuario

    Private _Cedula As Integer
    Public Property Cedula() As Integer
        Get
            Return _Cedula
        End Get
        Set(ByVal value As Integer)
            _Cedula = value
        End Set
    End Property


    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property


    Private _FechaNacimiento As Date
    Public Property FechaNacimiento() As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _FechaNacimiento = value
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


    Private _Cargo As String
    Public Property Cargo() As String
        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property


    Private _Username As String
    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property


    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
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



End Class
