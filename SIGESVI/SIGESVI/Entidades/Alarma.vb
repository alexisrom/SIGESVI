Public Class Alarma

    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
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


    Private _Mensaje As String
    Public Property Mensaje() As String
        Get
            Return _Mensaje
        End Get
        Set(ByVal value As String)
            _Mensaje = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Mensaje
    End Function

End Class
