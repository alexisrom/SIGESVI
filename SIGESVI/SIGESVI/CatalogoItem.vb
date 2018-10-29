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

        Try
            Dim cantidad = CInt(InputBox("Ingrese la cantidad deseada"))
            Carrito.AgregarProducto(_Producto, cantidad)
        Catch ex As Exception
            MessageBox.Show("La cantidad debe ser numérica")
        End Try

    End Sub
End Class
