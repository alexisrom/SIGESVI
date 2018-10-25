Public Class FrmSucursales
    Dim persistencia As PersistenciaSucursal

   

    Private Sub FrmSucursales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaSucursal()
        RestringirCampos(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)
        TxtID.Text = "0"
        DgvSucursales.DataSource = persistencia.Listar()
    End Sub

    Private Sub BtnAgregarTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarTelefono.Click
        If Not String.IsNullOrEmpty(TxtTelefono_NUM.Text) And Not LstTelefonos_REQ.Items.Contains(TxtTelefono_NUM.Text) Then
            LstTelefonos_REQ.Items.Add(TxtTelefono_NUM.Text)
            TxtTelefono_NUM.Clear()
        End If
    End Sub

    Private Sub BtnEliminarTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminarTelefono.Click

        If LstTelefonos_REQ.SelectedIndex >= 0 Then
            LstTelefonos_REQ.Items.Remove(LstTelefonos_REQ.SelectedItem)
        End If

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If ValidarCampos(Me) Then
            Dim s As New Sucursal()
            s.ID = CInt(TxtID.Text)
            s.Nombre = TxtNombre_REQ.Text
            s.Direccion = TxtDireccion_REQ.Text
            s.Departamento = TxtDepartamento_REQ.Text

            For Each item In LstTelefonos_REQ.Items
                s.Telefonos.Add(item.ToString)
            Next

            Guardar(s)
        End If
    End Sub

    Private Sub Guardar(ByVal sucursal As Sucursal)
        Try
            If TxtID.Text = "0" Then
                persistencia.Agregar(sucursal)
                MessageBox.Show("Sucursal agregado exitosamente")
            Else
                persistencia.Modificar(sucursal)
                MessageBox.Show("Sucursal modificada exitosamente")
            End If
            ControlesPorDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        If DgvSucursales.SelectedRows.Count > 0 Then
            Dim sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)

            TxtID.Text = sucursal.ID
            TxtNombre_REQ.Text = sucursal.Nombre
            TxtDireccion_REQ.Text = sucursal.Direccion
            TxtDepartamento_REQ.Text = sucursal.Departamento
            For Each t In sucursal.Telefonos
                LstTelefonos_REQ.Items.Add(t)
            Next
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If DgvSucursales.SelectedRows.Count > 0 Then
            Dim sucursal = CType(DgvSucursales.SelectedRows(0).DataBoundItem, Sucursal)
            persistencia.Eliminar(sucursal)
            ControlesPorDefecto()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ControlesPorDefecto()
    End Sub
End Class