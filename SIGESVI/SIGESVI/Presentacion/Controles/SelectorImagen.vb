Public Class SelectorImagen

    Private Sub BtnSeleccionarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionarImagen.Click
        If OfdSeleccionarImagen.ShowDialog() = DialogResult.OK Then
            PbFoto.Image = Image.FromFile(OfdSeleccionarImagen.FileName)
        End If
    End Sub

    Function ObtenerImagen() As Image
        Return PbFoto.Image
    End Function
End Class
