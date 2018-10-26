Public Class MenuGerenteGeneral

    Private Sub BtnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProduccion.Click
        AbrirFormulario(New FrmListadoProduccion, sender)
    End Sub

    Private Sub BtnProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductos.Click
        AbrirFormulario(New FrmListadoProductos, sender)
    End Sub

    

    Private Sub BtnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmClientes, sender)
    End Sub

    Private Sub BtnSucursales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmSucursales, sender)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmAjustes, sender)
    End Sub

 
    Private Sub BtnCepas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmTipoCepa, sender)
    End Sub

    Private Sub BtnTransacciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransacciones.Click
        AbrirFormulario(New FrmTransacciones, sender)
    End Sub

    Private Sub BtnFuncionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmFuncionarios, sender)
    End Sub

    Private Sub PicLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmInicio)
    End Sub


    Private Sub MenuGerenteGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AbrirFormulario(FrmInicio)
    End Sub

    Private Sub PnlMenu_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlMenu.Paint

    End Sub

    Private Sub PicLogo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicLogo.Click
        AbrirFormulario(New FrmInicio)
    End Sub

    Private Sub BtnFuncionarios_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFuncionarios.Click
        AbrirFormulario(New FrmFuncionarios, sender)
    End Sub

    Private Sub BtnAjustes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAjustes.Click
        AbrirFormulario(New FrmAjustes, sender)
    End Sub

    Private Sub BtnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        AbrirFormulario(New FrmClientes, sender)
    End Sub

    Private Sub BtnSucursales_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSucursales.Click
        AbrirFormulario(New FrmSucursales, sender)
    End Sub



    Private Sub BtnCepas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AbrirFormulario(New FrmTipoCepa, sender)
    End Sub

  
    Private Sub BtnEstadisticas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstadisticas.Click
        AbrirFormulario(New FrmEstadisticas, sender)
    End Sub
End Class
