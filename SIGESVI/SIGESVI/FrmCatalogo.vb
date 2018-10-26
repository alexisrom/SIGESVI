Public Class FrmCatalogo
    Dim mostos As New List(Of ProductoIntermedio)
    Dim vinos As New List(Of ProductoFinal)
    Dim productos As New List(Of EspecificacionProducto)
    Private cantProductos As Integer = 0
    Private menuCliente As MenuCliente
    Private Sub FrmCatalogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menuCliente = New MenuCliente
        Carrito.lstProductos = menuCliente.LstProductos
        Carrito.lblCantidad = menuCliente.LblCantidadProductos
        ManejoVentanas.frmPrincipal.PnlMenuContenedor.Controls.Add(menuCliente)
        CargarCatalogo()
    End Sub

    Private Sub CargarCatalogo()

        Dim productosintermedios = New PersistenciaProductoIntermedio().Listar
        For Each p In productosintermedios
            mostos.Add(p)
            Dim item As New CatalogoItem
            item.Producto = p
            PnlMosto.Controls.Add(item)
        Next


        Dim productosFinal = New PersistenciaProductoFinal().Listar
        For Each p In productosFinal
            vinos.Add(p)
            Dim item As New CatalogoItem
            item.Producto = p
            PnlVinos.Controls.Add(item)
        Next


    End Sub

End Class