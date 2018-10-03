Public Class frm_Bienvenida



    Private Sub Btn_IniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IniciarSesion.Click
        Try

            If ValidarCampos(Me) Then
                Dim user = Txt_UsuarioREQ.Text
                Dim pass = Txt_ConstraseñaREQ.Text
                Dim funcionario = PersistenciaUsuario.Login(user, pass)

                If funcionario Is Nothing Then
                    Throw New Exception("Usuario y/o contraseña incorrectos")
                End If

                UsuarioLogueado = funcionario
                
                Dim frm As Form

                If funcionario.Cargo.Equals("Administrativo") Then
                    frm = New FrmPrincipalAdministrativo()
                ElseIf funcionario.Cargo.Equals("Gerente Sucursal") Then
                    frm = New FrmPrincipalGerenteSucursal()
                End If

                Me.Hide()
                frm.ShowDialog()
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

End Class
