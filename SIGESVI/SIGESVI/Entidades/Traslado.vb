Public Class Traslado
    Inherits Transaccion

    Private _Destino As String
    Public Property Destino() As String
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property


    Private _Vehiculo As Transporte
    Public Property Vehiculo() As Transporte
        Get
            Return _Vehiculo
        End Get
        Set(ByVal value As Transporte)
            _Vehiculo = value
        End Set
    End Property


End Class
