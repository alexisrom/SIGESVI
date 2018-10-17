Public Class FrmOrigen
    Dim persistencia As PersistenciaOrigen


    Private Sub FrmOrigen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaOrigen
        SuscribirControles(Me)
        ControlesPorDefecto()
    End Sub

    Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtID.Text = "0"
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

        DgvOrigen.DataSource = persistencia.Listar()
    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Validacion.ValidarCampos(Me) Then
            Dim origen As New Origen()
            origen.ID = CInt(TxtID.Text)
            origen.Nombre = TxtNombre_REQ.Text
            origen.Direccion = TxtDireccion_REQ.Text
            origen.Propietario = TxtPropietario_REQ.Text
            Try

                If TxtID.Text.Equals("0") Then
                    persistencia.Agregar(origen)
                Else
                    persistencia.Modificar(origen)
                End If


                MessageBox.Show("Origen agregado exitosamente")
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvOrigen.SelectedRows.Count > 0 Then
            TxtID.Text = DgvOrigen.SelectedRows(0).Cells(0).Value.ToString
            TxtNombre_REQ.Text = DgvOrigen.SelectedRows(0).Cells(2).Value.ToString
            TxtDireccion_REQ.Text = DgvOrigen.SelectedRows(0).Cells(1).Value.ToString
            TxtPropietario_REQ.Text = DgvOrigen.SelectedRows(0).Cells(3).Value.ToString
        End If

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If DgvOrigen.SelectedRows.Count > 0 Then
            Dim origen = CType(DgvOrigen.SelectedRows(0).DataBoundItem, Origen)
            Try
                persistencia.Eliminar(origen)
                ControlesPorDefecto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub DgvOrigen_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvOrigen.CellClick

        If DgvOrigen.SelectedRows.Count > 0 Then
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
        Else
            BtnEditar.Enabled = False
            BtnEliminar.Enabled = False
        End If

    End Sub
End Class