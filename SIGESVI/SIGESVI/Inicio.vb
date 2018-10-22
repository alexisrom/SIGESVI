Public Class Inicio

    Private Sub TmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFechaHora.Tick
        LblHora.Text = Date.Now.ToString()
    End Sub
End Class