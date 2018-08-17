Public Class FrmLogin

    Private Sub acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IngresarLogin1.Click

        'TODO: Código comentado para pruebas
        'If Txt_Usuario.Text <> "funcionario" Or Txt_Passwd.Text <> "funcionario" Then
        If False Then
            MsgBox("Usuario y contraseñas incorrectos")
        Else
            Me.Hide()
            Dim frm = New FrmPrincipal()
            frm.ShowDialog()
        End If


    End Sub

    Private Sub Lbl_Usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Usuario.Click

    End Sub

    Private Sub txtpassw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Passwd.TextChanged

    End Sub

    Private Sub Txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Usuario.TextChanged

    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lbl_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Info.Click

    End Sub

    Private Sub Lbl_Contraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Contraseña.Click

    End Sub
End Class