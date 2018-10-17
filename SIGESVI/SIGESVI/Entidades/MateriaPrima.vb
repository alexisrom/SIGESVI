Public Class MateriaPrima
    Inherits EspecificacionProducto


    Private _TipoCepa As TipoCepa
    Public Property TipoCepa() As TipoCepa
        Get
            Return _TipoCepa
        End Get
        Set(ByVal value As TipoCepa)
            _TipoCepa = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal precio As Decimal, ByVal elaboracion As List(Of EtapaElaboracion), ByVal imagen As Image, ByVal categoria As String, ByVal tipoCepa As TipoCepa)
        MyBase.New(id, nombre, descripcion, precio, "Kg", elaboracion, imagen, categoria)
        Me.TipoCepa = tipoCepa
    End Sub

End Class
