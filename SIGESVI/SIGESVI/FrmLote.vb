Public Class FrmLotes

    Private persistencia As PersistenciaLote

    Private Sub FrmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaLote
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        Dim lotes = persistencia.Listar
        lotes.Sort(Function(x, y) x.ID.CompareTo(y.ID))
        DgvLotes.DataSource = lotes
        CboEspecificaciones.DataSource = ListarEspecificaciones()

        CboOrigenes.DataSource = New PersistenciaSucursal().Listar
        CboOrigenes.ValueMember = "id"
        CboOrigenes.DisplayMember = "nombre"
        LimpiarControles(Me)
        TxtID_NUM_REQ.Text = "0"
        TxtFecha.Text = Date.Now.Date

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If ValidarCampos(Me) Then
            Dim l As New Lote()
            l.ID = TxtID_NUM_REQ.Text
            l.Fecha = Date.Now.Date
            l.Stock = TxtStock_NUM_REQ.Text
            l.Origen = CType(CboOrigenes.SelectedItem, Sucursal)
            l.Tipo = CType(CboEspecificaciones.SelectedItem, EspecificacionProducto)
            Guardar(l)
        End If
    End Sub

    Private Sub Guardar(ByVal lote As Lote)
        Try
            If lote.ID = 0 Then
                persistencia.Agregar(lote)
                MessageBox.Show("Lote agregado exitosamente")
            Else
                persistencia.Modificar(lote)
                MessageBox.Show("Lote modificado exitosamente")
            End If
            ControlesPorDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvLotes.SelectedRows.Count > 0 Then
            Dim lote = CType(DgvLotes.SelectedRows(0).DataBoundItem, Lote)
            TxtID_NUM_REQ.Text = lote.ID
            TxtStock_NUM_REQ.Text = lote.Stock
            TxtFecha.Text = lote.Fecha.Date

            For Each item In CboEspecificaciones.Items
                If item.ToString.Equals(lote.Tipo.Nombre) Then
                    CboEspecificaciones.SelectedItem = item
                End If
            Next

            For Each item In CboOrigenes.Items
                If item.ToString.Equals(lote.Origen.Nombre) Then
                    CboOrigenes.SelectedItem = item
                End If
            Next

        End If
    End Sub

    Private Function ListarEspecificaciones() As List(Of EspecificacionProducto)
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
        Return eproductos
    End Function

End Class