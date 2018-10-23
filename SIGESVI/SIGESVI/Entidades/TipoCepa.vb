Public Class TipoCepa

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


    Private _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal tipo As String)
        Me.ID = id
        Me.Nombre = nombre
        Me.Tipo = tipo
    End Sub

    Sub New()

    End Sub

End Class
