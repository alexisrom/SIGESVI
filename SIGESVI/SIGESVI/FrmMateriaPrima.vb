Public Class FrmMateriaPrima

    Dim persistencia As PersistenciaMateriaPrima

    Public materiaPrima As MateriaPrima

    Private Sub PicVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicVolver.Click
        AbrirFormulario(New FrmListadoProductos)
    End Sub

    Private Sub FrmMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaMateriaPrima()
        ValidarControles(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtID.Text = "0"
        CboCepas.DataSource = New PersistenciaTipoCepa().ListarTodas()
        CboCepas.ValueMember = "nombre"

        If Not materiaPrima Is Nothing Then
            TxtID.Text = materiaPrima.ID
            TxtNombre_REQ.Text = materiaPrima.Nombre
            TxtDescripcion_REQ.Text = materiaPrima.Descripcion
            TxtPrecio_NUM_REQ.Text = materiaPrima.Precio
            For Each item In CboCepas.Items
                If CType(item, TipoCepa).Nombre.Equals(materiaPrima.TipoCepa.Nombre) Then
                    CboCepas.SelectedIndex = CboCepas.Items.IndexOf(item)
                End If
            Next
        End If

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If ValidarCampos(Me) Then
            Dim mp As New MateriaPrima()
            mp.ID = CInt(TxtID.Text)
            mp.Nombre = TxtNombre_REQ.Text
            mp.Descripcion = TxtDescripcion_REQ.Text
            mp.Precio = CDec(TxtPrecio_NUM_REQ.Text)
            mp.Imagen = PicFoto.Image
            mp.Categoria = "Tinto"
            mp.UnidadMedida = "Kg"
            mp.TipoCepa = CType(CboCepas.SelectedItem, TipoCepa)
            Guardar(mp)
        End If

    End Sub

    Private Sub Guardar(ByVal mp As MateriaPrima)

        Try
            If mp.ID = "0" Then
                persistencia.Agregar(mp)
                MessageBox.Show("Producto agregado exitosamente")
            Else
                persistencia.Modificar(mp)
                MessageBox.Show("Producto modificado exitosamente")
            End If

            AbrirFormulario(New FrmListadoProductos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class