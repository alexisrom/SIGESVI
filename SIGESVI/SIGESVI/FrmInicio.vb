Public Class FrmInicio
    Dim second As Integer = 0
    Private Sub TmrFechaHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrFechaHora.Tick
        LblHora.Text = Date.Now.ToString()

    End Sub

    Private Sub LbCerrarSesion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Application.Restart()
    End Sub

    Private Sub FrmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser2.Navigate("https://www.google.com.uy/?gws_rd=ssl#q=clima+" & ubicacion)
        MostrarNotificaciones()
        LblCargo.Text = usuarioLogueado.Rol

    End Sub



    Private Sub MostrarNotificaciones()
        Dim alarmas = New PersistenciaTrazabilidad().ListarTodasLasAlarmas()
        For Each a In alarmas
            Dim notificacion As New Notificacion()
            notificacion.esAlarma = True
            notificacion.LblMensaje.Text = a.Mensaje
            PnlAlarmas.Controls.Add(notificacion)
        Next
        For Each a In alarmas
            Dim notificacion As New Notificacion()
            notificacion.esAlarma = False
            notificacion.LblMensaje.Text = a.Mensaje
            PnlRecordatorios.Controls.Add(notificacion)
        Next

        'ListarAlarmas
        'ListarRecordatorios
    End Sub

    Private Sub Timerclima_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerclima.Tick

        Try
            Labeltemp.Text = "Temperatura: " & WebBrowser2.Document.GetElementById("wob_tm").InnerText & " °C"
            Labelhumedad.Text = "Humedad: " & WebBrowser2.Document.GetElementById("wob_hm").InnerText
            LabelUbicación.Text = "Ubicación: " & WebBrowser2.Document.GetElementById("wob_loc").InnerText
            pbclima.ImageLocation = WebBrowser2.Document.GetElementById("wob_tci").GetAttribute("src")

        Catch ex As Exception

        End Try
        second = second + 1

        If second = 100 Then
            Timerclima.Stop()
            second = 0
            WebBrowser2.Refresh()
            Timerclima.Start()
        End If
    End Sub

    Private Sub LbCerrarSesion_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LbCerrarSesion.LinkClicked
        Application.Restart()
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        Timerclima.Start()
    End Sub

End Class