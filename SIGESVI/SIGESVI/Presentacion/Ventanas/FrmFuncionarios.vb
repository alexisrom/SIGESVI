Public Class FrmFuncionarios
    Dim persistencia As PersistenciaFuncionario
    Dim funcionario As Funcionario

    Private Sub FrmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        persistencia = New PersistenciaFuncionario()
        SuscribirControles(Me)
        InicializarFormulario()
    End Sub

    Sub InicializarFormulario()
        funcionario = Nothing


        LimpiarControles(Me)


        Dim sucursales As List(Of Sucursal)

        If UsuarioLogueado.Cargo.Equals("Gerente General") Then
            DgvFuncionarios.DataSource = persistencia.Listar()
            sucursales = New PersistenciaSucursal().Listar()
        Else
            DgvFuncionarios.DataSource = persistencia.ListarPorSucursal(UsuarioLogueado.Sucursal.ID)
            sucursales = New List(Of Sucursal)
            sucursales.Add(UsuarioLogueado.Sucursal)
        End If

        CboSucursalesREQ.DataSource = sucursales
        CboSucursalesREQ.ValueMember = "nombre"


        

            CboCargo.SelectedIndex = 0

        TxtCiNUMREQ.Enabled = True
            BtnGuardar.Text = "AGREGAR"
    End Sub

    
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        

        Try
            If DgvFuncionarios.SelectedRows.Count > 0 Then
                Dim funcionario = CType(DgvFuncionarios.SelectedRows(0).DataBoundItem, Funcionario)

                Dim persistencia = New PersistenciaFuncionario()
                persistencia.Eliminar(funcionario)
                MessageBox.Show("Funcionario eliminado exitosamente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        If Not ValidarCampos(Me) Then
            Return
        End If

        If funcionario.Cargo.Equals("Gerente Sucursal") And UsuarioLogueado.Cargo.Equals("Gerente Sucursal") Then
            MessageBox.Show("No tiene permisos para asignar este cargo")
            Return
        End If

        If funcionario Is Nothing Then
            funcionario = New Funcionario()
        End If

        funcionario.Cedula = CInt(TxtCiNUMREQ.Text)
        funcionario.Nombre = (Txt_NombreLETREQ.Text)
        funcionario.Apellido = Txt_ApellidoLETREQ.Text
        funcionario.Direccion = Txt_DireccionREQ.Text
        funcionario.Usuario = TxtUsuarioREQ.Text
        funcionario.Contrasena = TxtContrasenaREQ.Text
        funcionario.Sucursal = CType(CboSucursalesREQ.SelectedItem, Sucursal)
        funcionario.Cargo = CboCargo.SelectedItem.ToString()


        Try

            If BtnGuardar.Text.Equals("AGREGAR") Then
                persistencia.Agregar(funcionario)
                MessageBox.Show(funcionario.Cargo & " agregado exitosamente")
                InicializarFormulario()
            Else
                persistencia.Modificar(funcionario)
                MessageBox.Show(funcionario.Cargo & " modificado exitosamente")
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DgvFuncionarios.SelectedRows.Count > 0 Then
            funcionario = CType(DgvFuncionarios.SelectedRows(0).DataBoundItem, Funcionario)
            TxtCiNUMREQ.Text = funcionario.Cedula
            Txt_NombreLETREQ.Text = funcionario.Nombre
            Txt_ApellidoLETREQ.Text = funcionario.Apellido
            Txt_DireccionREQ.Text = funcionario.Direccion
            TxtContrasenaREQ.Text = funcionario.Contrasena
            TxtUsuarioREQ.Text = funcionario.Usuario


            If UsuarioLogueado.Equals("Gerente General") Then
                CboSucursalesREQ.SelectedValue = funcionario.Sucursal
            End If

            For Each item In CboCargo.Items

                If item.ToString().Equals(funcionario.Cargo) Then
                    CboCargo.SelectedIndex = CboCargo.Items.IndexOf(item)
                End If

            Next



            TxtCiNUMREQ.Enabled = False
            BtnGuardar.Text = "GUARDAR"
        End If
    End Sub


    Sub ToggleAccion()

    End Sub

End Class