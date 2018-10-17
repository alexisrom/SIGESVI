Public Class FrmEtapas


    Private Sub FrmEtapas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Validacion.SuscribirControles(Me)
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
    End Sub

    Private Sub BtnAgregarEtapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarEtapa.Click

        If Not Validacion.ValidarCampos(Me) Then
            Return
        End If


        Dim nro = CInt(TxtNumero_NUM_REQ.Text)
        Dim nombre = TxtNombre_REQ.Text
        Dim descripcion = TxtDescripcion_REQ.Text
        Dim duracion = CInt(TxtDuracion_NUM_REQ.Text) ' > 0

        Dim etapa As New EtapaElaboracion(0, nro, nombre, descripcion, duracion)

        Dim frm As FrmProductoFinal = CType(Owner, FrmProductoFinal)
        frm.etapas.Add(etapa)
        Me.Close()
    End Sub


End Class