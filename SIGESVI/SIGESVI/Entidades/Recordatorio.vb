Public Class Recordatorio

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
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

    ' Indica cuanto tiempo antes de culminar la etapa se notifica
    Private _FechaAnticipacion As Date
    Public Property FechaAnticipacion() As Date
        Get
            Return _FechaAnticipacion
        End Get
        Set(ByVal value As Date)
            _FechaAnticipacion = value
        End Set
    End Property


End Class
