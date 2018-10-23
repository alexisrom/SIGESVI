Public Class FrmTrazabilidad
    Public produccion As Produccion

    Private Sub FrmTrazabilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        LblProduccion.Text = "Producción: " & produccion.ID

    End Sub

    Sub CargarEtapas()

        Dim fechaInicio = produccion.FechaInicio
        For Each er In produccion.EtapasRecorridas
            er.FechaInicio = fechaInicio
            er.FechaFin = DateAdd(DateInterval.Day, er.Etapa.Duracion, er.FechaInicio)
            fechaInicio = DateAdd(DateInterval.Day, 1, er.FechaFin)
        Next


        



    End Sub




End Class