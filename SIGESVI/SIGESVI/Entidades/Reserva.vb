Public Class Reserva

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property


    Private _Cliente As Cliente
    Public Property Cliente() As Cliente
        Get
            Return _Cliente
        End Get
        Set(ByVal value As Cliente)
            _Cliente = value
        End Set
    End Property

    Private _FechaHora As String
    Public Property FechaHora() As String
        Get
            Return _FechaHora
        End Get
        Set(ByVal value As String)
            _FechaHora = value
        End Set
    End Property


    Private _Lineas As List(Of LineaReserva)
    Public Property Lineas() As List(Of LineaReserva)
        Get
            Return _Lineas
        End Get
        Set(ByVal value As List(Of LineaReserva))
            _Lineas = value
        End Set
    End Property



    Public Property Productos_Reservados() As String
        Get
            Dim retorno As String = ""

            For Each l In Lineas
                retorno += l.Producto.Nombre & " (" & l.Cantidad & ") - "
            Next

            Return retorno
        End Get
        Set(ByVal value As String)

        End Set
    End Property




End Class
