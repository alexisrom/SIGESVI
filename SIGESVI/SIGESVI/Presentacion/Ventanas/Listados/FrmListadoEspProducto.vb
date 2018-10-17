Public Class FrmListadoEspProducto

    Private Sub FrmListadoEspProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmFormularioEProducto
        frm.ShowDialog()

    End Sub
End Class