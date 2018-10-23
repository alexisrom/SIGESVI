Public Class Funcionario
    Inherits Usuario


    Private _sucursal As Sucursal
    Public Property Sucursal() As Sucursal
        Get
            Return _sucursal
        End Get
        Set(ByVal value As Sucursal)
            _sucursal = value
        End Set
    End Property



End Class
