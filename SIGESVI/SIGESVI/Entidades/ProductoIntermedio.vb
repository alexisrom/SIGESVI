Public Class ProductoIntermedio
    Inherits EspecificacionProducto


    Private _Calidad As String
    Public Property Calidad() As String
        Get
            Return _Calidad
        End Get
        Set(ByVal value As String)
            _Calidad = value
        End Set
    End Property


    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal calidad As String, ByVal precio As Decimal, ByVal unidadmedida As String, ByVal elaboracion As List(Of EtapaElaboracion), ByVal imagen As Image)

    End Sub

    Sub New()

    End Sub


End Class
