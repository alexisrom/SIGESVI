Public Class FrmMateriaPrima

    Dim persistencia As PersistenciaMateriaPrima
    Public materiaPrima As MateriaPrima

    Private Sub FrmMateriaPrima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        persistencia = New PersistenciaMateriaPrima()

        SuscribirControles(Me)

        ControlesPorDefecto()
    End Sub


    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        CboCepas.DataSource = New PersistenciaTipoCepa().ListarTodas()
        CboCepas.ValueMember = "nombre"


        If materiaPrima Is Nothing Then
            TxtID.Text = "0"
        Else
            CargarDatos()
        End If

    End Sub

    Public Sub CargarDatos()
        TxtID.Text = materiaPrima.ID
        TxtNombre_REQ.Text = materiaPrima.Nombre
        TxtDescripcion_REQ.Text = materiaPrima.Descripcion
        TxtPrecio_NUM_REQ.Text = materiaPrima.Precio

        For Each item In CboCepas.Items


            If CType(item, TipoCepa).Nombre.Equals(materiaPrima.TipoCepa.Nombre) Then
                CboCepas.SelectedIndex = CboCepas.Items.IndexOf(item)
            End If

        Next

    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim mp As New MateriaPrima()
        mp.ID = CInt(TxtID.Text)
        mp.Nombre = TxtNombre_REQ.Text
        mp.Descripcion = TxtDescripcion_REQ.Text
        mp.Precio = CDec(TxtPrecio_NUM_REQ.Text)
        mp.Imagen = PbFoto.Image
        mp.Categoria = "Tinto"
        mp.UnidadMedida = "Kg"
        mp.TipoCepa = CType(CboCepas.SelectedItem, TipoCepa)

        Try
            If materiaPrima Is Nothing Then
                persistencia.Agregar(mp)
                MessageBox.Show("Producto agregado exitosamente")
            Else
                persistencia.Modificar(mp)
                MessageBox.Show("Producto modificado exitosamente")
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class