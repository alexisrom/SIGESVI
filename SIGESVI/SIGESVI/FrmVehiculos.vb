Public Class FrmVehiculos
    Dim persistencia As PersistenciaTransporte

    Private Sub FrmVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTransporte
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        DgvEtapas.DataSource = persistencia.Listar
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        If ValidarCampos(Me) Then
            Try
                persistencia.Agregar(CrearVehiculo)
                MessageBox.Show("Vehículo agregado exitosamente")
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Function CrearVehiculo() As Transporte
        Dim t As New Transporte
        t.ID = TxtMatricula_NUM_REQ.Text
        t.Tipo = TxtNombre_REQ.Text
        t.Capacidad = TxtCapacidad_NUM_REQ.Text
        Return t
    End Function


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class