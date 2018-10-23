Public Class FrmCompra
    Public productos As List(Of EspecificacionProducto)


    Private Sub BtnAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarProducto.Click
        Dim frm As New FrmListadoProductos
        AddOwnedForm(frm)
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frm.BtnNuevoMP.Visible = False
        frm.BtnNuevoPI.Visible = False
        frm.BtnNuevoPF.Visible = False
        frm.BtnEditar.Visible = False
        frm.BtnEliminar.Visible = False
        frm.LblAyuda.Visible = True
        frm.ShowDialog()
        DgvProductos.DataSource = Nothing
        DgvProductos.DataSource = productos
    End Sub

    
    Private Sub FrmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        productos = New List(Of EspecificacionProducto)
    End Sub

End Class