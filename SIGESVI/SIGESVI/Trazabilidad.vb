Public Class Trazabilidad


    Private _Produccion As Produccion
    Public Property Produccion() As Produccion
        Get
            Return _Produccion
        End Get
        Set(ByVal value As Produccion)
            _Produccion = value
        End Set
    End Property


    Private _Etapas As List(Of EtapaElaboracion)
    Public Property NewProperty() As List(Of EtapaElaboracion)
        Get
            Return _Etapas
        End Get
        Set(ByVal value As List(Of EtapaElaboracion))
            _Etapas = value
        End Set
    End Property



    Private _FechaInicio As Date
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property


    Private _FechaFin As Date
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property


    Private _EtapaActual As EtapaElaboracion
    Public Property EtapaActual() As EtapaElaboracion
        Get
            Return _EtapaActual
        End Get
        Set(ByVal value As EtapaElaboracion)
            _EtapaActual = value
        End Set
    End Property



End Class
