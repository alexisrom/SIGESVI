Public Class Transporte

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
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


    Private _Capacidad As Integer
    Public Property Capacidad() As Integer
        Get
            Return _Capacidad
        End Get
        Set(ByVal value As Integer)
            _Capacidad = value
        End Set
    End Property

    Sub New(ByVal id As Integer, ByVal tipo As String, ByVal capacidad As Integer)
        Me.ID = id
        Me.Tipo = tipo
        Me.Capacidad = capacidad
    End Sub

    Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Tipo & "(" & Me.Capacidad & ")"
    End Function
End Class
