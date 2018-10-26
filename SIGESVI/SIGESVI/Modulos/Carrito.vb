Module Carrito
    Public lineas As New List(Of LineaReserva)
    Public lstProductos As ListBox
    Public lblCantidad As Label
    Private cantidad_total As Integer = 0

    Sub AgregarProducto(ByVal p As EspecificacionProducto, ByVal cantidad As Integer)
        Dim l As New LineaReserva
        l.Cantidad = cantidad
        l.Producto = p
        lineas.Add(l)
        lstProductos.Items.Add(p.Nombre & "(" & cantidad & ")")
        cantidad_total += cantidad
        lblCantidad.Text = "(" & cantidad_total & ")"
    End Sub

    Sub EliminarProducto(ByVal index As Integer)
        lineas.RemoveAt(index)
        lstProductos.Items.RemoveAt(index)
    End Sub
End Module
