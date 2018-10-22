Public Class FrmListadoProduccion

    Private Sub BtnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNueva.Click
        AbrirFormulario(FrmProduccion)
    End Sub

    Private Sub FrmListadoProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvProduccion.DataSource = New PersistenciaProduccion().Listar()
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvProduccion.SelectedRows.Count > 0 Then
            Dim frm As New FrmProduccion
            Dim produccion_seleccionada = CType(DgvProduccion.SelectedRows(0).DataBoundItem, Produccion)
            frm.produccion = produccion_seleccionada
            AbrirFormulario(frm)
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
End Class