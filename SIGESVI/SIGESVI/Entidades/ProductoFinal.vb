Public Class ProductoFinal

    Private _Insumos As ProductoIntermedio
    Public Property Insumos() As ProductoIntermedio
        Get
            Return _Insumos
        End Get
        Set(ByVal value As ProductoIntermedio)
            _Insumos = value
        End Set
    End Property

End Class
