Public Class FrmClientes

    Private Sub Btn_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarTel.Click
        If solonumeros(Txt_Telefono) Then
            LblTelefonos.Items.Add(Txt_Telefono)
        Else
            MsgBox("ingrese solo numeros")

        End If
    End Sub
End Class