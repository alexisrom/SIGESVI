Public Class Funcionario

    Private _cedula As Integer
    Public Property Cedula() As Integer
        Get
            Return _cedula
        End Get
        Set(ByVal value As Integer)
            _cedula = value
        End Set
    End Property


    Private _sucursal As Sucursal
    Public Property Sucursal() As Sucursal
        Get
            Return _sucursal
        End Get
        Set(ByVal value As Sucursal)
            _sucursal = value
        End Set
    End Property


    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property


    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property


    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Private _contrasena As String
    Public Property Contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property


    Private _cargo As String
    Public Property Cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property


    Sub New()

    End Sub

    Sub New(ByVal cedula As Integer, ByVal sucursal As Sucursal, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal usuario As String, ByVal contrasena As String, ByVal cargo As String)
        Me.Cedula = cedula
        Me.Sucursal = sucursal
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Direccion = direccion
        Me.Usuario = usuario
        Me.Contrasena = contrasena
        Me.Cargo = cargo
    End Sub


End Class
