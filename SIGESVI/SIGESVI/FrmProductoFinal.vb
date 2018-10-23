Public Class FrmProductoFinal
    Private persistencia As PersistenciaProductoFinal
    Public productoFinal As ProductoFinal
    Public etapasDeElaboracion As List(Of EtapaElaboracion)

    Private Sub PicVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        AbrirFormulario(FrmListadoProductos, Nothing)
    End Sub


    Private Sub FrmProductoFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaProductoFinal()
        etapasDeElaboracion = New List(Of EtapaElaboracion)
        ValidarControles(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)

        If productoFinal Is Nothing Then
            TxtID.Text = "0"
        Else
            TxtID.Text = productoFinal.ID
            TxtNombre_REQ.Text = productoFinal.Nombre
            TxtDescripcion_REQ.Text = productoFinal.Descripcion
            TxtPrecio_NUM_REQ.Text = productoFinal.Precio
            For Each item In CboCategoria_REQ.Items
                If item.ToString().Equals(productoFinal.Categoria) Then
                    CboCategoria_REQ.SelectedItem = item
                End If
            Next
            For Each item In CboCrianza.Items
                If item.ToString().Equals(productoFinal.Crianza) Then
                    CboCrianza.SelectedItem = item
                End If
            Next
            For Each item In CboEmbotellamiento.Items
                If item.ToString().Equals(productoFinal.Embotellamiento) Then
                    CboEmbotellamiento.SelectedItem = item
                End If
            Next
            DgvEtapas.DataSource = productoFinal.Elaboracion
        End If

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If etapasDeElaboracion.Count <= 0 Then
            MessageBox.Show("Agregue almenos 1 etapa de elaboración")
            Return
        End If

        If ValidarCampos(Me) Then
            Dim p As New ProductoFinal()
            p.ID = CInt(TxtID.Text)
            p.Nombre = TxtNombre_REQ.Text
            p.Descripcion = TxtDescripcion_REQ.Text
            p.Precio = CDec(TxtPrecio_NUM_REQ.Text)
            p.Imagen = PicFoto.Image
            p.UnidadMedida = "Kg"
            p.Crianza = CboCrianza.SelectedItem.ToString
            p.Embotellamiento = CboEmbotellamiento.SelectedItem.ToString
            p.Categoria = CboCategoria_REQ.SelectedItem.ToString
            p.Elaboracion = etapasDeElaboracion

            Guardar(p)
        End If
    End Sub

    Private Sub Guardar(ByVal p As ProductoFinal)

        Try
            If TxtID.Text = "0" Then
                persistencia.Agregar(p)
                MessageBox.Show("Producto agregado exitosamente")
            Else
                'persistencia.Modificar(p)
                MessageBox.Show("Producto modificado exitosamente")
            End If

            AbrirFormulario(FrmListadoProductos, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAgregarEtapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarEtapa.Click
        Dim frm As New FrmEtapa
        AddOwnedForm(frm)
        frm.ShowDialog()
        MostarEtapas()
    End Sub

    Public Sub MostarEtapas()
        DgvEtapas.DataSource = Nothing
        DgvEtapas.DataSource = etapasDeElaboracion
        DgvEtapas.Refresh()
    End Sub

    Private Sub BtnEliminarEtapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarEtapa.Click

        If DgvEtapas.SelectedRows.Count > 0 And TxtID.Text = "0" Then
            Dim etapa = CType(DgvEtapas.SelectedRows(0).DataBoundItem, EtapaElaboracion)
            etapasDeElaboracion.Remove(etapa)
            MostarEtapas()
        End If

    End Sub
End Class