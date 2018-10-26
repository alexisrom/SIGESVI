Public Class MenuAsesorProfesional


    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(New FrmListadoProductos, sender)
    End Sub

    Private Sub BtnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProduccion.Click
        AbrirFormulario(New FrmListadoProduccion, sender)
    End Sub
End Class
