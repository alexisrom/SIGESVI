Public Class MenuGerenteSucursal

    
    Private Sub BtnEstadisticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstadisticas.Click
        AbrirFormulario(New FrmEstadisticas, sender)
    End Sub

    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(New FrmListadoProductos, sender)
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AbrirFormulario(New FrmTransacciones, sender)
    End Sub
End Class
