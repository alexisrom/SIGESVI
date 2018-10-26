Public Class FrmAjustes

    
    Private Sub Pic_UBICACION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_UBICACION.Click
        ubicacion = InputBox("Ingrese su ubicación")

    End Sub


    Private Sub PicVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVehiculos.Click
        AbrirFormulario(New FrmVehiculos)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        AbrirFormulario(New FrmTipoCepa)
    End Sub
End Class