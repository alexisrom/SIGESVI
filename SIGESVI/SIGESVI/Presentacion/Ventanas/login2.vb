Public Class login2

    Private Sub acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IngresarLogin2.Click
        Dim frm = New FrmPrincipal()
        If Txt_Usuario.Text <> "cliente" Or Txt_Passwd.Text <> "cliente" Then
            erroruser.SetError(Txt_Usuario, "error de usuario")
            errorpassw.SetError(Txt_Passwd, "error de contraseña")
        Else
            erroruser.Clear()
            errorpassw.Clear()

            frm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class