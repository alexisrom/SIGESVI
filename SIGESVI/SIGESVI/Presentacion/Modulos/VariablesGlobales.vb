Module VariablesGlobales

    Private _usuarioLogueado As Funcionario
    Public Property UsuarioLogueado() As Funcionario
        Get
            Return _usuarioLogueado
        End Get
        Set(ByVal value As Funcionario)
            _usuarioLogueado = value
        End Set
    End Property


End Module
