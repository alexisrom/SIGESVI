Public Class login2

    Private Sub acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acceder.Click
        Dim frm = New FrmPrincipal()
        If Txtuser.Text <> "cliente" Or txtpassw.Text <> "cliente" Then
            erroruser.SetError(Txtuser, "error de usuario")
            errorpassw.SetError(txtpassw, "error de contraseña")
        Else
            erroruser.Clear()
            errorpassw.Clear()

            frm.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class