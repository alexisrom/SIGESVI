Public Class FrmCampos
    Private persistencia As PersistenciaOrigen
  

    Private Sub FrmCampos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaOrigen
        ValidarControles(Me)
        ControlesPorDefecto()
    End Sub


    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtID.Text = "0"
        TxtNombre_REQ.Focus()
        DgvCampos.DataSource = persistencia.Listar
    End Sub


    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If ValidarCampos(Me) Then
            Dim campo As New Origen()
            campo.ID = TxtID.Text
            campo.Nombre = TxtNombre_REQ.Text
            campo.Direccion = TxtDireccion_REQ.Text
            campo.Propietario = TxtPropietario_REQ.Text
            Guardar(campo)
        End If
    End Sub

    Private Sub Guardar(ByVal origen As Origen)
        Try
            If origen.ID = 0 Then
                persistencia.Agregar(origen)
                MessageBox.Show("Campo agregado exitosamente")
            Else
                persistencia.Modificar(origen)
                MessageBox.Show("Campo modificado exitosamente")
            End If
            ControlesPorDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvCampos.SelectedRows.Count > 0 Then
            Dim campo = CType(DgvCampos.SelectedRows(0).DataBoundItem, Origen)
            TxtID.Text = campo.ID
            TxtNombre_REQ.Text = campo.Nombre
            TxtDireccion_REQ.Text = campo.Direccion
            TxtPropietario_REQ.Text = campo.Propietario
        End If

    End Sub


    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If DgvCampos.SelectedRows.Count > 0 Then
            Dim origen = CType(DgvCampos.SelectedRows(0).DataBoundItem, Origen)
            persistencia.Eliminar(origen)
            ControlesPorDefecto()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ControlesPorDefecto()
    End Sub

End Class