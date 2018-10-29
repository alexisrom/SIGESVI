Public Class FrmProduccion
    Dim persistencia As PersistenciaProduccion
    Public produccion As Produccion
    

    Private Sub FrmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaProduccion
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        Dim eproductos As New List(Of EspecificacionProducto)

        Dim materiasprimas = New PersistenciaMateriaPrima().Listar
        For Each m In materiasprimas
            eproductos.Add(m)
        Next

        Dim productosintermedios = New PersistenciaProductoIntermedio().Listar
        For Each p In productosintermedios
            eproductos.Add(p)
        Next

        Dim productosFinal = New PersistenciaProductoFinal().Listar
        For Each p In productosFinal
            eproductos.Add(p)
        Next
        CboEspecificaciones.DataSource = eproductos
        CboEspecificaciones.ValueMember = "id"
        CboEspecificaciones.DisplayMember = "nombre"
        LimpiarControles(Me)

        If produccion Is Nothing Then
            TxtID.Text = "0"
        Else
            TxtID.Text = produccion.ID
            TxtCantidad_NUM_REQ.Text = produccion.Cantidad
            DtpFechaInicio.Value = produccion.FechaInicio
            DtpFechaFin.Value = produccion.FechaFin
            CboEspecificaciones.SelectedItem = produccion.Producto
            BtnProgramar.Text = "GUARDAR CAMBIOS"
            If produccion.FechaInicio < Date.Now Then
                BtnProgramar.Visible = False
                TxtCantidad_NUM_REQ.Enabled = False
            End If
        End If

    End Sub


    Private Sub BtnProgramar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProgramar.Click

        If ValidarCampos(Me) Then
            Dim p As New Produccion
            p.ID = TxtID.Text
            p.Producto = CType(CboEspecificaciones.SelectedItem, EspecificacionProducto)
            p.FechaInicio = DtpFechaInicio.Value
            p.FechaFin = DtpFechaFin.Value
            p.Cantidad = CInt(TxtCantidad_NUM_REQ.Text)
            p.Sucursal = CType(usuarioLogueado, Funcionario).Sucursal
            Guardar(p)
        End If

    End Sub

    Private Sub Guardar(ByVal p As Produccion)

        Try
            If p.ID = 0 Then
                persistencia.Agregar(p)
                MessageBox.Show("Producción agregada exitosamente")
            Else
                persistencia.Modificar(p)
                MessageBox.Show("Producción modificada exitosamente")
            End If
            AbrirFormulario(FrmListadoProduccion, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        AbrirFormulario(FrmListadoProduccion)
    End Sub

End Class