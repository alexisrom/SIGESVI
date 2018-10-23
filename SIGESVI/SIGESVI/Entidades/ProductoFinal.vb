Public Class ProductoFinal
    Inherits EspecificacionProducto


    Private _Crianza As String
    Public Property Crianza() As String
        Get
            Return _Crianza
        End Get
        Set(ByVal value As String)
            _Crianza = value
        End Set
    End Property


    Private _Embotellamiento As String
    Public Property Embotellamiento() As String
        Get
            Return _Embotellamiento
        End Get
        Set(ByVal value As String)
            _Embotellamiento = value
        End Set
    End Property




    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal calidad As String, ByVal precio As Decimal, ByVal unidadmedida As String, ByVal elaboracion As List(Of EtapaElaboracion), ByVal imagen As Image, ByVal crianza As String, ByVal embotellemiento As String)

    End Sub

    Sub New()

    End Sub
End Class
