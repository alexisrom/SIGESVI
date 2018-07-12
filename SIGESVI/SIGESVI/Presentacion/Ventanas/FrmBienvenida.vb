Public Class frm_Bienvenida

    Private Sub lbl_SIGESVI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SIGESVI.Click

    End Sub

    Private Sub lbl_Ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Ingreso.Click

    End Sub

    Private Sub btn_IngresarAlSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IngresarAlSistema.Click
        Dim frm = New FrmLogin()
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm = New login2()
        frm.ShowDialog()
        Me.Close()
    End Sub
End Class
