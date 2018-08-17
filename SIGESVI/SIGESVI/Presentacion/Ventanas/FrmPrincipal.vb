Public Class FrmPrincipal

    Private Sub GestiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónToolStripMenuItem.Click

    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frm = New FrmClientes()
        frm.ShowDialog()
    End Sub

    Private Sub VinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VinosToolStripMenuItem.Click
        Dim frm = New FrmVinos()
        frm.ShowDialog()
    End Sub

    Private Sub TransporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm = New FrmTransporte()
        frm.ShowDialog()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionariosToolStripMenuItem.Click
        Dim frm = New FrmFuncionarios()
        frm.ShowDialog()
    End Sub

    Private Sub ProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónToolStripMenuItem.Click
        Dim frm = New FrmProduccion()
        frm.ShowDialog()
    End Sub

    Private Sub ElaboraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElaboraciónToolStripMenuItem.Click
        Dim frm = New FrmListadoProduccion()
        frm.ShowDialog()
    End Sub

    Private Sub MostoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostoToolStripMenuItem.Click
        Dim frm = New FrmMosto()
        frm.ShowDialog()
    End Sub

    Private Sub TransporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransporteToolStripMenuItem.Click
        Dim frm = New FrmVehiculos()
        frm.ShowDialog()
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacenesToolStripMenuItem.Click
        Dim frm = New FrmAlmacen()
        frm.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim frm = New FrmCompras()
        frm.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Dim frm = New FrmVentas()
        frm.ShowDialog()
    End Sub

    Private Sub OrigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenToolStripMenuItem.Click
        Dim frm = New FrmOrigen()
        frm.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim frm = New FrmEspecificacionProducto()
        frm.ShowDialog()
    End Sub

    Private Sub GestiónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónToolStripMenuItem1.Click
        Dim frm = New FrmSucursales()
        frm.ShowDialog()
    End Sub

    Private Sub TrasladoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrasladoToolStripMenuItem.Click
        Dim frm = New FrmTransporte()
        frm.ShowDialog()
    End Sub

    Private Sub CepasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CepasToolStripMenuItem.Click
        Dim frm = New FrmTipoCepas()
        frm.ShowDialog()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        Dim frm = New FrmReserva()
        frm.ShowDialog()
    End Sub

    Private Sub TrazabilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrazabilidadToolStripMenuItem.Click
        Dim frm = New FrmTrazabilidad()
        frm.ShowDialog()
    End Sub
End Class