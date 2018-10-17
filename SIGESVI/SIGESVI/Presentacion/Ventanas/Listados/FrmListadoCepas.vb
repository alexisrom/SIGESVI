Public Class FrmListadoCepas

    Private Sub FrmListadoCepas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvTiposCepas.DataSource = New PersistenciaTipoCepa().ListarTodas
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmTipoCepa
        frm.ShowDialog()
        DgvTiposCepas.DataSource = New PersistenciaTipoCepa().ListarTodas
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvTiposCepas.SelectedRows.Count > 0 Then
            Dim frm As New FrmTipoCepa
            frm.modoAlta = False
            frm.LblTitulo.Text = "Modificar Tipo de Cepa"
            frm.tipoCepa = CType(DgvTiposCepas.SelectedRows(0).DataBoundItem, TipoCepa)
            frm.ShowDialog()
            DgvTiposCepas.DataSource = New PersistenciaTipoCepa().ListarTodas
        End If

    End Sub
End Class