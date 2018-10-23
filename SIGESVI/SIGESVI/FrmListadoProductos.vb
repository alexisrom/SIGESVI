Public Class FrmListadoProductos

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvProductos.SelectedRows.Count > 0 Then
            Dim ep = CType(DgvProductos.SelectedRows(0).DataBoundItem, EspecificacionProducto)

            Dim frm
            If TypeOf ep Is MateriaPrima Then
                frm = New FrmMateriaPrima
                frm.materiaPrima = CType(ep, MateriaPrima)
            ElseIf TypeOf ep Is ProductoIntermedio Then
                frm = New FrmProductoIntermedio
                frm.productoIntermedio = CType(ep, ProductoIntermedio)
            ElseIf TypeOf ep Is ProductoFinal Then
                frm = New FrmProductoFinal
                frm.productoFinal = CType(ep, ProductoFinal)
            End If
            AbrirFormulario(frm, Nothing)

        End If

    End Sub

    Private Sub ListadoProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim eproductos As New List(Of EspecificacionProducto)

        Dim materiasprimas = New PersistenciaMateriaPrima().Listar
        For Each m In materiasprimas
            eproductos.Add(m)
        Next

        Dim productosintermedios = New PersistenciaProductoIntermedio().Listar
        For Each p In productosintermedios
            eproductos.Add(p)
        Next

        Dim productosFinal = New PersistenciaProductoFinal().Listar
        For Each p In productosFinal
            eproductos.Add(p)
        Next
        eproductos.Sort(Function(x, y) x.ID.CompareTo(y.ID))
        DgvProductos.DataSource = eproductos

    End Sub


    Private Sub BtnNuevoPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoPF.Click
        AbrirFormulario(FrmProductoFinal, sender)
    End Sub

    Private Sub BtnNuevoMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoMP.Click
        AbrirFormulario(FrmMateriaPrima, sender)
    End Sub

    Private Sub BtnNuevoPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoPI.Click
        AbrirFormulario(FrmProductoIntermedio, sender)
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim ep = CType(DgvProductos.SelectedRows(0).DataBoundItem, EspecificacionProducto)
        Dim persistencia As New PersistenciaEspecificacionProducto()

        Try
            persistencia.Eliminar(ep)
            MessageBox.Show("Especificación eliminada exitosamente")
            ListadoProductos_Load(Nothing, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DgvProductos_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProductos.CellContentDoubleClick
        

        If TypeOf Owner Is FrmCompra Then
            Dim producto_seleccionado = CType(DgvProductos.SelectedRows(0).DataBoundItem, EspecificacionProducto)
            CType(Owner, FrmCompra).productos.Add(producto_seleccionado)
            Me.Close()
        End If

    End Sub
End Class