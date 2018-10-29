Public Class MenuAdministrativo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AbrirFormulario(New FrmLotes, sender)
    End Sub

    Private Sub BtnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProduccion.Click
        AbrirFormulario(New FrmListadoProduccion, sender)
    End Sub

    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(New FrmListadoProductos, sender)
    End Sub

End Class
