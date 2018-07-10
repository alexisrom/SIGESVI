Public Class FrmSucursales

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click



    End Sub

    Private Sub TxtCI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ID.Validated
        If Txt_ID.Text = "" Then
            EpErrores.SetError(Txt_ID, "Ingrese una cédula válida")
        End If
    End Sub

    Private Sub TxtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ID.TextChanged

    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarTel.Click
        LblTelefonos.Items.Add(Txt_Telefono.Text)
        Txt_Telefono.Clear()
    End Sub

    Private Sub Btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Borrar.Click
        LblTelefonos.Items.Remove(LblTelefonos.SelectedItem)
    End Sub
End Class