Public Class FrmPrincipal

    Private Sub GestiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónToolStripMenuItem.Click

    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frm = New FrmClientes()
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

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Module1.tipousuario = "fgavello" Then
            ClientesToolStripMenuItem.Enabled = False
            VentasToolStripMenuItem.Visible = False
            ConsultasToolStripMenuItem.Enabled = False
            EstadísticasToolStripMenuItem.Enabled = False
            SucursalesGGToolStripMenuItem.Visible = False
        Else
            If Module1.tipousuario = "drossini" Then
                ClientesToolStripMenuItem.Enabled = False
            End If
        End If
        If Module1.tipousuario = "fgavello" Then

            Label2.Text = "Fernando Gavello"
            Label1.Text = "Administrativo"
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
     

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
      

    End Sub

 
End Class