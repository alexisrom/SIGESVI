
Public Class frm_Bienvenida

    Private Sub lbl_SIGESVI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SIGESVI.Click

    End Sub

    Private Sub lbl_Ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_IngresarAlSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Dim frm = New FrmCatalogo()
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call conecta()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql As String
        sql = "insert into almacen values(01, 'soyunasucursal', 01)"
        Dim comando As New Odbc.OdbcCommand
        conexion.conecta()
        comando.Connection = conexion.conectar
        comando.CommandText = sql
        Try
            comando.ExecuteNonQuery()
        Catch
            MsgBox("Error" & Err.Description)

        End Try
        conexion.cierra()
    End Sub

    Private Sub frm_Bienvenida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Constraseña.TextChanged

    End Sub

    Private Sub Btn_IniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IniciarSesion.Click
        Dim permitido As Boolean
        If Txt_Usuario.Text <> "fgavello" And Txt_Usuario.Text <> "drossini" And Txt_Usuario.Text <> "bmontero" And Txt_Usuario.Text <> "aromero" Then
            MsgBox("Usuario y contraseñas incorrectos")
        Else
            permitido = True
        End If

        If permitido Then

            If Txt_Usuario.Text = "fgavello" And Txt_Constraseña.Text <> "123456" Then
                MsgBox("Usuario y contraseñas incorrectos")
            Else
               If Txt_Usuario.Text = "drossini" And Txt_Constraseña.Text <> "1234567" Then
                    MsgBox("Usuario y contraseñas incorrectos")
                Else
                    If Txt_Usuario.Text = "bmontero" And Txt_Constraseña.Text <> "12345678" Then
                        MsgBox("Usuario y contraseñas incorrectos")
                    Else
                        If Txt_Usuario.Text = "aromero" And Txt_Constraseña.Text <> "123456789" Then
                            MsgBox("Usuario y contraseñas incorrectos")
                        Else
                            If Txt_Usuario.Text = "cliente" And Txt_Constraseña.Text <> "1234567890" Then
                                MsgBox("Usuario y contraseñas incorrectos")
                            Else
                                Me.Hide()
                                Dim frm = New FrmPrincipal()
                                frm.ShowDialog()
                            End If
                        End If
                    End If
                End If
            End If


        End If




    End Sub
End Class
