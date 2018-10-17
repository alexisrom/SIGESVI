Public Class FrmVehiculos
    Private persistencia As PersistenciaTransporte
    Private modoAlta As Boolean = True
    Private transporte As Transporte

    Private Sub FrmVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaTransporte()
        SuscribirControles(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        DgvTransportes.DataSource = persistencia.Listar()
        TxtID.ReadOnly = True
        If modoAlta Then
            TxtID.Text = "0"
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If ValidarCampos(Me) Then
            Dim id = CInt(TxtID.Text)
            Dim nombre = TxtNombre_REQ.Text
            Dim capacidad = CInt(TxtCapacidad_NUM_REQ.Text)
            Dim transporte As New Transporte(id, nombre, capacidad)
            Guardar(transporte)
            ControlesPorDefecto()
        End If
    End Sub


    Sub Guardar(ByVal transporte As Transporte)
        Try
            If modoAlta Then
                persistencia.Agregar(transporte)
            Else
                persistencia.Modificar(transporte)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvTransportes.SelectedRows.Count > 0 Then
            TxtID.Text = DgvTransportes.SelectedRows(0).Cells(0).Value
            TxtNombre_REQ.Text = DgvTransportes.SelectedRows(0).Cells(1).Value
            TxtCapacidad_NUM_REQ.Text = DgvTransportes.SelectedRows(0).Cells(2).Value
            modoAlta = False
        End If

    End Sub
End Class