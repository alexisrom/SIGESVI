Public Class FrmPrincipal

    Private Sub GestiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónToolStripMenuItem.Click

    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        Dim frm = New FrmSucursales()
        frm.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frm = New FrmClientes()
        frm.ShowDialog()
    End Sub

    Private Sub VinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VinosToolStripMenuItem.Click
        Dim frm = New FrmVinos()
        frm.ShowDialog()
    End Sub

    Private Sub TransporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransporteToolStripMenuItem1.Click
        Dim frm = New FrmTransporte()
        frm.ShowDialog()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionariosToolStripMenuItem.Click
        Dim frm = New FrmFuncionarios()
        frm.ShowDialog()
    End Sub
End Class