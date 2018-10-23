Public Class FrmInicio

    Private Sub TmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFechaHora.Tick
        LblHora.Text = Date.Now.ToString()
        LblCargo.Text = usuarioLogueado.Rol
    End Sub

    Private Sub LbCerrarSesion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbCerrarSesion.LinkClicked
        Application.Restart()
    End Sub
End Class