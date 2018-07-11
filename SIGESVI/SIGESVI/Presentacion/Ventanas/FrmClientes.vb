Public Class FrmClientes

    Private Sub Btn_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarTel.Click
        If solonumeros(Txt_Telefono) Then
            LblTelefonos.Items.Add(Txt_Telefono.Text)
        Else
            MsgBox("ingrese solo numeros")

        End If

       
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub Btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Quitar.Click
        If (LblTelefonos.SelectedIndex > -1) Then
            LblTelefonos.Items.RemoveAt(LblTelefonos.SelectedIndex)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Txt_Nombre.Text = "" Then
            ErrorProvider1.SetError(Txt_Nombre, "Ingrese un nombre")
        End If

        If Not sololetras(Txt_Nombre) Then
            ErrorProvider1.SetError(Txt_Nombre, "Los nombres no puden contener numeros")
        End If
    End Sub
End Class