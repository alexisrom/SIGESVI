Public Class Notificacion
    Public esAlarma As Boolean = False


    Private Sub Notificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If esAlarma Then
            PnlNotificacion.BackColor = Color.FromArgb(10, 189, 227)
        Else
            PnlNotificacion.BackColor = Color.FromArgb(29, 209, 161)
        End If

    End Sub

    Private Sub PnlNotificacion_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlNotificacion.Paint

    End Sub
End Class
