Public Class FrmProduccion
    Dim persistencia As PersistenciaProduccion
    Public produccion As Produccion
    

    Private Sub FrmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaProduccion
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        CboEspecificaciones.DataSource = New PersistenciaProductoFinal().Listar
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

            Dim s As New Sucursal
            s.ID = 1
            p.Sucursal = s
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
            AbrirFormulario(New FrmListadoProduccion)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        AbrirFormulario(New FrmListadoProduccion)
    End Sub

End Class