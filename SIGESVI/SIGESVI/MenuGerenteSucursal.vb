Public Class MenuGerenteSucursal

    
    Private Sub BtnEstadisticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstadisticas.Click
        AbrirFormulario(FrmEstadisticas, sender)
    End Sub

    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(FrmListadoProductos, sender)
    End Sub

    
End Class
