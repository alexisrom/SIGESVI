Public Class FrmTrazabilidad
    Dim persistencia As PersistenciaTrazabilidad
    Public produccion As Produccion
    Public etapaSeleccionada As EtapaRecorrida

    Private Sub FrmTrazabilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTrazabilidad
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        LblProduccion.Text = "Producción: " & produccion.ID

        CboEtapas.DataSource = produccion.Producto.Elaboracion
        CboEtapas.ValueMember = "id"
        CboEtapas.DisplayMember = "nombre"

        DgvEtapasRecorridas.DataSource = Nothing
        DgvEtapasRecorridas.DataSource = produccion.EtapasRecorridas
        DgvEtapasRecorridas.Refresh()

    End Sub


    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        AbrirFormulario(FrmListadoProduccion, Nothing)
    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim etapaRecorrida As New EtapaRecorrida
        etapaRecorrida.Etapa = CType(CboEtapas.SelectedItem, EtapaElaboracion)
        etapaRecorrida.FechaInicio = DtpInicio.Value
        etapaRecorrida.FechaFin = DtpFin.Value
        etapaRecorrida.Observacion = TxtObservacion_REQ.Text

        If ValidarDatos(etapaRecorrida) Then
            Guardar(etapaRecorrida)
            ControlesPorDefecto()
        End If

    End Sub

    Private Function ValidarDatos(ByVal etapaRecorrida As EtapaRecorrida) As Boolean
        Try
            If etapaRecorrida.FechaInicio >= etapaRecorrida.FechaFin Then
                Throw New Exception("La fecha de fin debe ser mayor que la de inicio")
            End If
            For Each er In produccion.EtapasRecorridas
                If er.Etapa.ID = etapaRecorrida.Etapa.ID Then
                    Throw New Exception("La etapa seleccionada ya existe en la trazabilidad")
                End If
            Next

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    Private Sub Guardar(ByVal etapaRecorrida As EtapaRecorrida)

        Try
            If CboEtapas.Enabled Then
                persistencia.AgregarEtapa(produccion, etapaRecorrida)
                produccion.EtapasRecorridas.Add(etapaRecorrida)
            Else
                'persistencia.Modificar(etapaRecorrida)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ControlesPorDefecto()
    End Sub

    Private Sub CboEtapas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboEtapas.SelectedIndexChanged
        Dim etapa = CType(CboEtapas.SelectedItem, EtapaElaboracion)
        DtpFin.Value = DateAdd(DateInterval.Day, etapa.Duracion, DtpInicio.Value)

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        DtpInicio.Enabled = False
        DtpFin.Enabled = False
        CboEtapas.Enabled = False


        Dim etapaRecorrida = CType(DgvEtapasRecorridas.SelectedRows(0).DataBoundItem, EtapaRecorrida)
        DtpInicio.Value = etapaRecorrida.FechaInicio
        DtpFin.Value = etapaRecorrida.FechaFin
        CboEtapas.SelectedValue = etapaRecorrida.Etapa.ID
        TxtObservacion_REQ.Text = etapaRecorrida.Observacion

    End Sub

   
    Private Sub BtnConfigurarAlarma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfigurarAlarma.Click

        If DgvEtapasRecorridas.SelectedRows.Count > 0 Then
            etapaSeleccionada = CType(DgvEtapasRecorridas.SelectedRows(0).DataBoundItem, EtapaRecorrida)
            Dim frm As New FrmAlarmas
            AddOwnedForm(frm)
            frm.ShowDialog()

            DgvEtapasRecorridas.DataSource = Nothing
            DgvEtapasRecorridas.DataSource = produccion.EtapasRecorridas
            DgvEtapasRecorridas.Refresh()


        End If

    End Sub


End Class