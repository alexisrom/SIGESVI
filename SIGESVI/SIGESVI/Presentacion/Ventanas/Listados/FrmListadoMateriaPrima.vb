Public Class FrmListadoMateriaPrima



    Private Sub FrmListadoMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGridView()
    End Sub

    Private Sub CargarGridView()
        Try
            Dim persistencia = New PersistenciaMateriaPrima()
            DgvProductos.DataSource = persistencia.Listar
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim frm As New FrmMateriaPrima
        frm.ShowDialog()
        CargarGridView()
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvProductos.SelectedRows.Count > 0 Then
            Dim frm As New FrmMateriaPrima
            frm.materiaPrima = CType(DgvProductos.SelectedRows(0).DataBoundItem, MateriaPrima)
            frm.ShowDialog()
            CargarGridView()
        End If

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If DgvProductos.SelectedRows.Count > 0 Then

            Dim materiaPrima = CType(DgvProductos.SelectedRows(0).DataBoundItem, MateriaPrima)
            Dim persistencia = New PersistenciaMateriaPrima()
            persistencia.Eliminar(materiaPrima)
            CargarGridView()
        End If

    End Sub
End Class