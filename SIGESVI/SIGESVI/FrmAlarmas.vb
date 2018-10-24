Public Class FrmAlarmas
    Dim produccion As Produccion
    Dim etapaSeleccionada As EtapaRecorrida
    Dim persistencia As PersistenciaTrazabilidad


    Private Sub FrmAlarmas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        produccion = CType(Owner, FrmTrazabilidad).produccion
        etapaSeleccionada = CType(Owner, FrmTrazabilidad).etapaSeleccionada
        persistencia = New PersistenciaTrazabilidad


        If Not etapaSeleccionada.Alarma Is Nothing Then
            TxtDuracion_NUM_REQ.Text = etapaSeleccionada.Alarma.Duracion
            TxtMensaje_REQ.Text = etapaSeleccionada.Alarma.Mensaje
            DtpFecha.Value = etapaSeleccionada.Alarma.Fecha
        End If


        If etapaSeleccionada.FechaFin < Date.Now Then
            BtnGuardar.Enabled = False
        End If

    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        'FECHA BETWEEN etapa inicio - fin

        Dim alarma As New Alarma()
        alarma.Fecha = DtpFecha.Value
        alarma.Duracion = TxtDuracion_NUM_REQ.Text
        alarma.Mensaje = TxtMensaje_REQ.Text
        
        Try

            If alarma.Fecha < etapaSeleccionada.FechaInicio Or alarma.Fecha > etapaSeleccionada.FechaFin Then
                Throw New Exception("La alarma debe configurarse en el transucrso de la etapa")
            End If

            Dim fechaFinAlarma = DateAdd(DateInterval.Day, alarma.Duracion, alarma.Fecha)
            If fechaFinAlarma > etapaSeleccionada.FechaFin Then
                Throw New Exception("La duración de la alarma no debe superar la finalización la etapa")
            End If


            If etapaSeleccionada.Alarma Is Nothing Then
                persistencia.AgregarAlarma(produccion, etapaSeleccionada, alarma)
            Else
                'persistencia.Modificar(produccion, etapaSeleccionada, alarma)
            End If


            MessageBox.Show("Alarma configurada exitosamente")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class