Public Class Usuario

    Private _Cedula As Integer
    Public Property ID() As Integer
        Get
            Return _Cedula
        End Get
        Set(ByVal value As Integer)
            _Cedula = value
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


    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
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


    Private _Rol As String
    Public Property Rol() As String
        Get
            Return _Rol
        End Get
        Set(ByVal value As String)
            _Rol = value
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


    Private _Telefono As String
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property


    Function EsGerenteGeneral() As Boolean
        Return _Rol.Equals("Gerente General")
    End Function

    Function EsGerenteSucursal() As Boolean
        Return _Rol.Equals("Gerente Sucursal")
    End Function

    Function EsAdministrativo() As Boolean
        Return _Rol.Equals("Administrativo")
    End Function

    Function EsAsesorProfesional() As Boolean
        Return _Rol.Equals("Asesor Profesional")
    End Function

    Function EsEnologo() As Boolean
        Return _Rol.Equals("Enologo")
    End Function

    Function EsCliente() As Boolean
        Return _Rol.Equals("Cliente")
    End Function
End Class
