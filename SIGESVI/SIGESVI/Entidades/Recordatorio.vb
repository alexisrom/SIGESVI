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


    ' Indica cuanto tiempo desde del inicio comienza
    Private _Dia As Integer
    Public Property Dia() As Integer
        Get
            Return _Dia
        End Get
        Set(ByVal value As Integer)
            _Dia = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return String.Format("[{0}, {1}]", _Mensaje, _Dia)
    End Function
End Class
