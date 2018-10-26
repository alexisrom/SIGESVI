Public Class CatalogoItem

    Private _Producto As EspecificacionProducto
    Public Property Producto() As EspecificacionProducto
        Get
            Return _Producto
        End Get
        Set(ByVal value As EspecificacionProducto)
            _Producto = value
            LblNombre.Text = _Producto.Nombre
            LblDescripcion.Text = _Producto.Descripcion
            LblPrecio.Text = "Precio: $" & _Producto.Precio

            If Not _Producto.Imagen Is Nothing Then
                PicFoto.Image = _Producto.Imagen
            End If

        End Set
    End Property


    Private Sub BtnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarProducto.Click
        Dim cantidad = InputBox("Ingrese la cantidad deseada")
        Carrito.AgregarProducto(_Producto, cantidad)
    End Sub
End Class
