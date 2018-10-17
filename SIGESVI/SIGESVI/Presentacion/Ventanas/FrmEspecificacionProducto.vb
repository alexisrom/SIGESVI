Public Class FrmEspecificacionProducto

    Private persistencia As PersistenciaEspecificacionProducto

    Private Sub FrmEspecificacionProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaEspecificacionProducto()

        SuscribirControles(Me)
        InicializarFormulario()
    End Sub

    Private Sub InicializarFormulario()
        LimpiarControles(Me)

        'DgvEtapasElaboracion.DataSource = 

    End Sub


    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If Not ValidarCampos(Me) Then
            Return
        End If

        Dim especificacion As EspecificacionProducto

        If CboCategoria.SelectedItem.ToString().Equals("Materia Prima") Then
            especificacion = New MateriaPrima()
            ' CType(especificacion, MateriaPrima).TipoCepa = CboCepas.SelectedItem.ToString()
        End If

        especificacion.Nombre = TxtNombre_REQ.Text.Trim()
        especificacion.Precio = TxtPrecio_NUM_REQ.Text.Trim()
        especificacion.Descripcion = TxtDescripcion_REQ.Text.Trim()
        especificacion.UnidadMedida = CboUnidadMedida.SelectedItem.ToString()


        Try
            persistencia.Agregar(especificacion)
            MessageBox.Show("Especificación agregada exitosamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        InicializarFormulario()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcion_REQ.TextChanged

    End Sub
End Class