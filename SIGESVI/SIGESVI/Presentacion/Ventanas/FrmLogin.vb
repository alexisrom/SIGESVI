﻿Public Class FrmLogin

    Private Sub acceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IngresarLogin1.Click
        Dim frm = New FrmPrincipal()
        If Txt_Usuario.Text <> "funcionario" Or Txt_Passwd.Text <> "funcionario" Then
            erroruser.SetError(Txt_Usuario, "error de usuario")
            errorpassw.SetError(Txt_Passwd, "error de contraseña")
        Else
            erroruser.Clear()
            errorpassw.Clear()

            frm.ShowDialog()
            Me.Close()
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