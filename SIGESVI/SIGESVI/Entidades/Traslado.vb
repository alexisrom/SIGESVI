Public Class Traslado

    ' Puede ser almacen, viñedo o entrega
    Private _Destino As String
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property

End Class
