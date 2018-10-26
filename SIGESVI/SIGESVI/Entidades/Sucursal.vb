Public Class Sucursal

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


    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property


    Private _Departamento As String
    Public Property Departamento() As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property


    Private _Telefonos As List(Of String)
    Public Property Telefonos() As List(Of String)
        Get
            Return _Telefonos
        End Get
        Set(ByVal value As List(Of String))
            _Telefonos = value
        End Set
    End Property


    Private _Proveedor As Boolean
    Public Property Proveedor() As Boolean
        Get
            Return _Proveedor
        End Get
        Set(ByVal value As Boolean)
            _Proveedor = value
        End Set
    End Property


    Sub New()
        Me.ID = 0
        Me.Nombre = ""
        Me.Direccion = ""
        Me.Departamento = ""
        Me.Telefonos = New List(Of String)
    End Sub

    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal direccion As String, ByVal departamento As String, ByVal telefonos As List(Of String), ByVal proveedor As Boolean)
        Me.ID = id
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Departamento = departamento
        Me.Telefonos = telefonos
        Me.Proveedor = proveedor
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
