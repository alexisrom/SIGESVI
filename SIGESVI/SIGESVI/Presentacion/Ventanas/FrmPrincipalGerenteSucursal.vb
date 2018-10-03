Public Class FrmPrincipalGerenteSucursal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New FrmFuncionarios
        frm.Show()
    End Sub

    Private Sub FrmPrincipalGerenteSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblNombreUsuario.Text = UsuarioLogueado.Nombre & " " & UsuarioLogueado.Apellido
        LblCargoUsuario.Text = UsuarioLogueado.Cargo
    End Sub
End Class