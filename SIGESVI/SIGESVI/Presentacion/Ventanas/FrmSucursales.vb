Public Class FrmSucursales

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub TxtCI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txt_ID.Text = "" Then
            EpErrores.SetError(Txt_ID, "Ingrese una cédula válida")
        End If
    End Sub

    Private Sub TxtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LblTelefonos.Items.Add(Txt_Telefono.Text)
        Txt_Telefono.Clear()
    End Sub

    Private Sub Btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LblTelefonos.Items.Remove(LblTelefonos.SelectedItem)
    End Sub

    Private Sub Btn_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarTel.Click
        If solonumeros(Txt_Telefono) Then
            LblTelefonos.Items.Add(Txt_Telefono.Text)
        Else
            MsgBox("ingrese solo numeros")
        End If

    End Sub

    Private Sub Txt_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ID.TextChanged

    End Sub

    Private Sub Btn_Borrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Borrar.Click

    End Sub
End Class