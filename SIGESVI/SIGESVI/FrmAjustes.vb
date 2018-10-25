Public Class FrmAjustes

    
    Private Sub Pic_UBICACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_UBICACION.Click
        ubicacion = InputBox("Ingrese su ubicación")

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        AbrirFormulario(FrmCampos, Nothing)
    End Sub

    Private Sub PicVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVehiculos.Click
        AbrirFormulario(New FrmVehiculos)
    End Sub
End Class