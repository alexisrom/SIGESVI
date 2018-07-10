Public Class FrmCliente

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click



    End Sub

    Private Sub TxtCI_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Ci.Validated
        If Txt_Ci.Text = "" Then
            EpErrores.SetError(Txt_Ci, "Ingrese una cédula válida")
        End If
    End Sub

    Private Sub TxtCI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Ci.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarTel.Click
        LblTelefonos.Items.Add(Txt_Telefono.Text)
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitar.Click
        LblTelefonos.Items.Remove(LblTelefonos.SelectedItem)
    End Sub
End Class