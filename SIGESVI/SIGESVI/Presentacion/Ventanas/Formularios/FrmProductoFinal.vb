Public Class FrmProductoFinal
    Dim persistencia As PersistenciaProductoFinal
    Public productoFinal As ProductoFinal
    Public etapas As List(Of EtapaElaboracion)

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
      
        If productoFinal Is Nothing Then
            TxtID.Text = "0"
        Else
            CargarDatos()
        End If

    End Sub

    Public Sub CargarDatos()
        TxtID.Text = productoFinal.ID
        TxtNombre_REQ.Text = productoFinal.Nombre
        TxtDescripcion_REQ.Text = productoFinal.Descripcion
        TxtPrecio_NUM_REQ.Text = productoFinal.Precio

    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Not ValidarCampos(Me) Then
            Return
        End If

        Dim p As New ProductoFinal()
        p.ID = CInt(TxtID.Text)
        p.Nombre = TxtNombre_REQ.Text
        p.Descripcion = TxtDescripcion_REQ.Text
        p.Precio = CDec(TxtPrecio_NUM_REQ.Text)
        p.Imagen = UCSelectorImagen.ObtenerImagen
        p.Categoria = "Tinto"
        p.UnidadMedida = "Kg"
        p.Crianza = CboCrianza.SelectedItem.ToString
        p.Embotellamiento = CboEmbotellamiento.SelectedItem.ToString
        p.Elaboracion = etapas

        Try
            If productoFinal Is Nothing Then
                persistencia.Agregar(p)
                MessageBox.Show("Producto agregado exitosamente")
            Else
                'persistencia.Modificar(p)
                MessageBox.Show("Producto modificado exitosamente")
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmProductoFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        persistencia = New PersistenciaProductoFinal()
        etapas = New List(Of EtapaElaboracion)

        SuscribirControles(Me)

        ControlesPorDefecto()
    End Sub

    Public Sub MostarEtapas()
        DgvEtapasElaboracion.DataSource = Nothing
        DgvEtapasElaboracion.DataSource = etapas
        DgvEtapasElaboracion.Refresh()
    End Sub

    Private Sub LbNuevaEtapa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbNuevaEtapa.LinkClicked
        Dim frm As New FrmEtapas
        AddOwnedForm(frm)
        frm.ShowDialog()
        MostarEtapas()
    End Sub
End Class