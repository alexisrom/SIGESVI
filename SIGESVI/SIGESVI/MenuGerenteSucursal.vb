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

    Private Sub BtnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProduccion.Click
        AbrirFormulario(New FrmProduccion, sender)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AbrirFormulario(New FrmFuncionarios, sender)
    End Sub

    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCliente.Click
        AbrirFormulario(New FrmClientes, sender)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AbrirFormulario(New FrmAjustes, sender)
    End Sub
End Class
