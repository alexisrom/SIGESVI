Public Class FrmFuncionarios
    Dim persistencia As PersistenciaFuncionario
    
    Private Sub FrmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        persistencia = New PersistenciaFuncionario()
        ValidarControles(Me)
        ControlesPorDefecto()
    End Sub

    Private Sub ControlesPorDefecto()
        LimpiarControles(Me)

        TxtID_NUM_REQ.Enabled = True
        DgvFuncionarios.DataSource = persistencia.Listar()
        CboSucursales_REQ.DataSource = New PersistenciaSucursal().Listar()
        CboSucursales_REQ.ValueMember = "id"
        CboSucursales_REQ.DisplayMember = "nombre"
        CboCargo_REQ.SelectedIndex = 0
    End Sub


    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

        If DgvFuncionarios.SelectedRows.Count > 0 Then
            Dim funcionario = CType(DgvFuncionarios.SelectedRows(0).DataBoundItem, Funcionario)
            TxtID_NUM_REQ.Enabled = False
            TxtID_NUM_REQ.Text = funcionario.Cedula
            TxtNombre_REQ.Text = funcionario.Nombre
            TxtApellido_REQ.Text = funcionario.Apellido
            TxtDireccion_REQ.Text = funcionario.Direccion
            TxtPass_REQ.Text = funcionario.Contrasena
            TxtUser_REQ.Text = funcionario.Usuario
            CboSucursales_REQ.SelectedValue = funcionario.Sucursal.ID
            For Each item In CboCargo_REQ.Items
                If item.ToString().Equals(funcionario.Cargo) Then
                    CboCargo_REQ.SelectedIndex = CboCargo_REQ.Items.IndexOf(item)
                End If
            Next
        End If

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If DgvFuncionarios.SelectedRows.Count > 0 Then
            Dim funcionario = CType(DgvFuncionarios.SelectedRows(0).DataBoundItem, Funcionario)
            persistencia.Eliminar(funcionario)
            ControlesPorDefecto()
        End If
    End Sub


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If ValidarCampos(Me) Then
            Dim f As New Funcionario()
            f.Cedula = CInt(TxtID_NUM_REQ.Text)
            f.Nombre = TxtNombre_REQ.Text
            f.Apellido = TxtApellido_REQ.Text
            f.Direccion = TxtDireccion_REQ.Text
            f.Usuario = TxtUser_REQ.Text
            f.Contrasena = TxtPass_REQ.Text
            f.Cargo = CboCargo_REQ.SelectedItem.ToString
            f.Sucursal = CType(CboSucursales_REQ.SelectedItem, Sucursal)
            Guardar(f)
        End If

    End Sub

    Private Sub Guardar(ByVal funcionario As Funcionario)
        Try
            If TxtID_NUM_REQ.Enabled Then
                persistencia.Agregar(funcionario)
                MessageBox.Show("Funcionario agregado exitosamente")
            Else
                persistencia.Modificar(funcionario)
                MessageBox.Show("Funcionario modificado exitosamente")
            End If
            ControlesPorDefecto()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        ControlesPorDefecto()
    End Sub

End Class