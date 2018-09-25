Public Class FrmFuncionarios
    Dim persistencia As PersistenciaFuncionario

    Private Sub FrmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarSucursales()
        Dim persistencia As New PersistenciaFuncionario()
        Dim funcionarios = persistencia.Listar()
        DgvFuncionarios.DataSource = funcionarios

    End Sub


    Sub CargarSucursales()
        Dim sucurales = New PersistenciaSucursal().Listar()
        CboSucursales.DataSource = sucurales
        CboSucursales.ValueMember = "nombre"
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim funcionario As New Funcionario()
        funcionario.Cedula = CInt(Txt_Ci.Text)
        funcionario.Nombre = Txt_Nombre.Text
        funcionario.Apellido = Txt_Apellido.Text
        funcionario.Direccion = Txt_Direccion.Text
        funcionario.Usuario = TxtUsuario.Text
        funcionario.Contrasena = TxtContrasena.Text
        funcionario.Sucursal = CType(CboSucursales.SelectedItem, Sucursal)
        funcionario.Cargo = Cbo_cargo.SelectedItem.ToString()

        Dim persistencia = New PersistenciaFuncionario()
        persistencia.Agregar(funcionario)


    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        If DgvFuncionarios.SelectedRows.Count > 0 Then
            Dim funcionario = CType(DgvFuncionarios.SelectedRows(0).DataBoundItem, Funcionario)

            Dim persistencia = New PersistenciaFuncionario()
            persistencia.Eliminar(funcionario)
        End If

    End Sub
End Class