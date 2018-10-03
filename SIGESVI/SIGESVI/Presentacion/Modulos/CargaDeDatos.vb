Module CargaDeDatos



    Public Property TiposDeCepa() As List(Of String)
        Get
            Dim tiposCepas As New List(Of String)
            tiposCepas.Add("Merlot")
            tiposCepas.Add("Cabernet Sauvignon")
            tiposCepas.Add("Tannat")
            Return tiposCepas
        End Get
        Set(ByVal value As List(Of String))

        End Set
    End Property

    

End Module
