Public Class FrmProductoIntermedio

    Dim persistencia As PersistenciaProductoIntermedio

    Public productoIntermedio As ProductoIntermedio

    Private Sub PicVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVolver.Click
        AbrirFormulario(New FrmListadoProductos)
    End Sub

    Private Sub FrmProductoIntermedio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaProductoIntermedio()
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtID.Text = "0"

        If Not productoIntermedio Is Nothing Then
            TxtID.Text = productoIntermedio.ID
            TxtNombre_REQ.Text = productoIntermedio.Nombre
            TxtDescripcion_REQ.Text = productoIntermedio.Descripcion
            TxtPrecio_NUM_REQ.Text = productoIntermedio.Precio
            For Each item In CboCalidad_REQ.Items
                If item.ToString.Equals(productoIntermedio.Calidad) Then
                    CboCalidad_REQ.SelectedIndex = CboCalidad_REQ.Items.IndexOf(item)
                End If
            Next
        End If

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If ValidarCampos(Me) Then
            Dim p As New ProductoIntermedio()
            p.ID = CInt(TxtID.Text)
            p.Nombre = TxtNombre_REQ.Text
            p.Descripcion = TxtDescripcion_REQ.Text
            p.Precio = CDec(TxtPrecio_NUM_REQ.Text)
            p.Imagen = PicFoto.Image
            p.Categoria = "Tinto"
            p.UnidadMedida = "Kg"
            p.Calidad = CboCalidad_REQ.SelectedItem.ToString
            Guardar(p)
        End If
    End Sub

    Private Sub Guardar(ByVal p As ProductoIntermedio)

        Try
            If p.ID = "0" Then
                persistencia.Agregar(p)
                MessageBox.Show("Producto agregado exitosamente")
            Else
                persistencia.Modificar(p)
                MessageBox.Show("Producto modificado exitosamente")
            End If

            AbrirFormulario(New FrmListadoProductos, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class