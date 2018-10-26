Public Class FrmListadoProduccion

    Private Sub BtnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNueva.Click
        AbrirFormulario(FrmProduccion)
    End Sub

    Private Sub FrmListadoProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If usuarioLogueado.EsGerenteGeneral Then
            DgvProduccion.DataSource = New PersistenciaProduccion().Listar()
        Else
            DgvProduccion.DataSource = New PersistenciaProduccion().Listar(CType(usuarioLogueado, Funcionario).Sucursal)
        End If


        BtnNueva.Visible = usuarioLogueado.EsAdministrativo



    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvProduccion.SelectedRows.Count > 0 Then
            Dim frm As New FrmProduccion
            Dim produccion_seleccionada = CType(DgvProduccion.SelectedRows(0).DataBoundItem, Produccion)
            frm.produccion = produccion_seleccionada
            AbrirFormulario(frm, Nothing)
        End If

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If DgvProduccion.SelectedRows.Count > 0 Then
            Try
                Dim produccion_seleccionada = CType(DgvProduccion.SelectedRows(0).DataBoundItem, Produccion)
                Dim persistencia As New PersistenciaProduccion
                'confirmación
                Dim result As Integer = MessageBox.Show("¿Seguro que desea eliminar la producción seleccionada?", "Eliminar Producción", MessageBoxButtons.YesNoCancel)

                If result = DialogResult.Yes Then
                    persistencia.Eliminar(produccion_seleccionada)
                    FrmListadoProduccion_Load(Nothing, e)
                End If

            Catch ex As Exception
                MessageBox.Show("Producción eliminada exitosamente")
            End Try
        End If

    End Sub


    Private Sub BtnTrazabilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrazabilidad.Click

        If DgvProduccion.SelectedRows.Count > 0 Then
            Dim produccion_seleccionada = CType(DgvProduccion.SelectedRows(0).DataBoundItem, Produccion)
            produccion_seleccionada.EtapasRecorridas = New PersistenciaProduccion().ObtenerTrazabilidad(produccion_seleccionada)
            Dim frm As New FrmTrazabilidad
            frm.produccion = produccion_seleccionada
            AbrirFormulario(frm, Nothing)
        End If

    End Sub
End Class